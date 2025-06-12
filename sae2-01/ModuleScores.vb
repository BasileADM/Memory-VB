Imports System.Data
Imports System.IO

Module ModuleScores

    ' Table en mémoire pour stocker les scores des joueurs
    Public ScoresTable As New DataTable()

    ' Chemin du fichier où les scores seront sauvegardés (fichier texte dans le dossier de l'application)
    Private ReadOnly ScoresFile As String = Path.Combine(Application.StartupPath, "scores.txt")

    ' Initialise la structure de la table des scores (colonnes "Nom du joueur" et "Temps")
    Sub InitialiserScores()
        If ScoresTable.Columns.Count = 0 Then
            ScoresTable.Columns.Add("Nom du joueur", GetType(String))
            ScoresTable.Columns.Add("Temps", GetType(TimeSpan))
        End If
    End Sub

    ' Charge les scores depuis le fichier "scores.txt" dans la DataTable
    Sub ChargerScores()
        InitialiserScores()  ' Assure que la table est initialisée avant chargement
        ScoresTable.Rows.Clear()  ' Vide la table avant de la remplir à nouveau
        If File.Exists(ScoresFile) Then
            Dim lignes = File.ReadAllLines(ScoresFile)  ' Lit toutes les lignes du fichier
            For Each ligne In lignes
                Dim parties = ligne.Split(";"c)  ' Sépare chaque ligne par le caractère ';'
                If parties.Length = 2 Then  ' Vérifie que la ligne contient bien deux parties (nom;temps)
                    Dim nom = parties(0)
                    Dim temps As TimeSpan
                    ' Tente de convertir la chaîne en TimeSpan
                    If TimeSpan.TryParse(parties(1), temps) Then
                        ScoresTable.Rows.Add(nom, temps)  ' Ajoute la ligne à la table
                    End If
                End If
            Next
        End If
    End Sub

    ' Sauvegarde le contenu de la DataTable dans le fichier texte "scores.txt"
    Sub SauvegarderScores()
        Dim lignes As New List(Of String)
        ' Pour chaque ligne dans la table, crée une ligne texte "nom;temps"
        For Each row As DataRow In ScoresTable.Rows
            lignes.Add($"{row("Nom du joueur")};{row("Temps")}")
        Next
        File.WriteAllLines(ScoresFile, lignes)  ' Écrit toutes les lignes dans le fichier
    End Sub

    ' Ajoute un nouveau score à la DataTable et sauvegarde immédiatement
    Sub AjouterScore(nom As String, temps As TimeSpan)
        InitialiserScores()
        ScoresTable.Rows.Add(nom, temps)  ' Ajout du score en mémoire
        SauvegarderScores()  ' Sauvegarde dans le fichier
    End Sub

    ' Efface tous les scores à la fois en mémoire et dans le fichier
    Sub ResetScores()
        ScoresTable.Rows.Clear()  ' Vide la table en mémoire
        File.WriteAllText(ScoresFile, String.Empty)  ' Vide le fichier sur le disque
        ChargerScores()  ' Recharge (table vide)
    End Sub

    ' Retourne une nouvelle DataTable avec les scores triés par temps croissant (meilleurs scores en premier)
    Function GetScoresTries() As DataTable
        InitialiserScores()
        Dim dtTrie As DataTable = ScoresTable.Clone()  ' Clone la structure de la table (sans les données)
        ' Sélectionne les lignes triées par temps ascendant et les importe dans la nouvelle table
        For Each row As DataRow In ScoresTable.Select("", "Temps ASC")
            dtTrie.ImportRow(row)
        Next
        Return dtTrie
    End Function

    ' Renvoie une liste des noms des joueurs uniques, triés par ordre alphabétique
    Function ObtenirNomsJoueursUniques() As List(Of String)
        InitialiserScores()
        ChargerScores()  ' Recharge les scores pour avoir les données à jour

        ' Récupère tous les noms de joueurs depuis la table des scores
        Dim noms = ScoresTable.AsEnumerable().
            Select(Function(r) r.Field(Of String)("Nom du joueur"))

        ' Supprime les doublons
        Dim nomsUniques = noms.Distinct()

        ' Trie les noms par ordre alphabétique
        Dim nomsTries = nomsUniques.OrderBy(Function(n) n)

        ' Convertit le résultat en liste et la retourne
        Return nomsTries.ToList()
    End Function

End Module
