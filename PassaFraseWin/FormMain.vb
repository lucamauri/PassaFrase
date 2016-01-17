Public Class FormMain
    Dim Worker As PassaFraseCore.PassaFraseCore
    Dim ResultCase As PassaFraseCore.PassaFraseCore.WordCase = PassaFraseCore.PassaFraseCore.WordCase.CamelCase

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Worker As PassaFraseCore.PassaFraseCore

        Console.WriteLine("Caricamento dizionario")
        Worker = New PassaFraseCore.PassaFraseCore
        Console.WriteLine("Dizionario caricato")

        Console.WriteLine("Parola casuale : >" & Worker.GetRandomWord(ResultCase) & "<")
        Console.WriteLine("Numero casuale : >" & Worker.GetRandomNumer(4) & "<")
        Console.WriteLine("Numero di parole : " & Worker.Dizionario.Count & " Moltiplicato per 3 : " & Worker.Dizionario.Count * 3)
        Console.WriteLine("Logaritmo : " & Math.Log(Worker.Dizionario.Count * 3, 2))
        Console.WriteLine("Tempo (1.000 tentativi/secondo) : " & (2 ^ (Math.Log(Worker.Dizionario.Count * 3, 2) * 1)) / 1000 / 60 / 60 / 24 / 365.25)
    End Sub

    Private Sub OPTInitials_CheckedChanged(sender As Object, e As EventArgs) Handles OPTInitials.CheckedChanged, OPTLowerCase.CheckedChanged, OPTUpperCase.CheckedChanged
        If OPTInitials.Checked Then
            ResultCase = PassaFraseCore.PassaFraseCore.WordCase.CamelCase
        ElseIf OPTLowerCase.Checked Then
            ResultCase = PassaFraseCore.PassaFraseCore.WordCase.Lowercase
        Else
            ResultCase = PassaFraseCore.PassaFraseCore.WordCase.Uppercase
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Worker As PassaFraseCore.PassaFraseCore
        Dim CurrentItem As ListViewItem
        Dim Result As String

        Worker = New PassaFraseCore.PassaFraseCore

        'TODO Rinomina in *PassPhraseCount*
        For PassPhrase As Integer = 1 To NUDTotal.Value
            Result = Worker.GeneratepassPhrase(NUDWords.Value, ResultCase)
            CurrentItem = LVPassPhrases.Items.Add(Worker.CurrentPassPhrase)
            'Console.WriteLine("Parola casuale : >" & Worker.CurrentPassPhrase & "<")

            If Result <> "OK" Then
                MessageBox.Show(Result, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            With CurrentItem
                .SubItems.Add(Math.Round(Worker.CurrentBitsOfEntropy, 2).ToString)
                ''.SubItems.Add(Math.Round(Worker.CurrentCombinationNumber, 2).ToString)

                '.SubItems.Add(Math.Round(Worker.EstimatedTimeToGuessMassive.TotalDays / 365.25, 2))
                '.SubItems.Add(Math.Round(Worker.EstimatedTimeToGuessOffline.TotalDays / 365.25, 2))
                '.SubItems.Add(Math.Round(Worker.EstimatedTimeToGuessOnline.TotalDays / 365.25, 2))

                '.SubItems.Add(Worker.Seconds)
                'Console.WriteLine("Numero di parole : " & Worker.NumberOfSymbols & " - " & (2 ^ (Math.Log(Worker.Dizionario.Count * 3, 2))))
                'Console.WriteLine("Tempo (1.000 tentativi/secondo) : " & (2 ^ (Math.Log(Worker.Dizionario.Count * 3, 2) * 4)) / 1000 / 60 / 60 / 24 / 365.25)

                .SubItems.Add(Math.Round(Worker.EstimatedTimeToGuessMassive / PassaFraseCore.PassaFraseCore.SecondsToYears, 2))
                .SubItems.Add(Math.Round(Worker.EstimatedTimeToGuessOffline / PassaFraseCore.PassaFraseCore.SecondsToYears, 2))
                .SubItems.Add(Math.Round(Worker.EstimatedTimeToGuessOnline / PassaFraseCore.PassaFraseCore.SecondsToYears, 2))

                .SubItems.Add(Worker.CurrentMD5Hash)
            End With
        Next

    End Sub
End Class