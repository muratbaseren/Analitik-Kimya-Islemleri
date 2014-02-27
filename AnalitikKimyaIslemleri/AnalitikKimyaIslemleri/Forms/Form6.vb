Public Class Form6

    Public Sub Loading(ByVal DosyaKonumu As String, ByVal FormBasligi As String)
        Me.Text = FormBasligi
        Me.ToolStripStatusLabel1.Text = "Makale Konumu : " & Application.StartupPath & "\" & DosyaKonumu
        Me.WebBrowser1.Navigate(Application.StartupPath & "\" & DosyaKonumu)
    End Sub
End Class