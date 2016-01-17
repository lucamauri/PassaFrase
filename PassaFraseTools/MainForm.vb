Imports System.IO
Imports System.Text

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TXTSource.Text = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString).ToString).ToString, "\PassaFraseCore\Dizionario\").ToString
        TXTSource.Text = "d:\Users\luca\Documents\Visual Studio Projects\PassaFrase\PassaFraseCore\Dizionario\"
    End Sub

    Private Sub CMDCompute_Click(sender As Object, e As EventArgs) Handles CMDCompute.Click
        Dim Handler As New PassaFraseCore.TextHandler
        Dim FullContent As New StringBuilder

        For Each Lettera As String In Directory.EnumerateFiles(TXTSource.Text)
            If Lettera.Substring(Lettera.Length - 4).ToLower <> ".txt" Then
                'Console.WriteLine(Lettera)
                FullContent.Append(Handler.textFromFile(Lettera))
            End If
        Next

        'TXTOutput.Text = FullContent.ToString
        Handler.textToFile(Path.Combine(TXTSource.Text, "dizionario.txt"), FullContent.ToString)
    End Sub
End Class