Public Class Form3

    Private Rapor As CrystalReport1

    Public Sub RaporAc(ByVal FormIsmi As String)
        Me.Text = FormIsmi
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Rapor.Dispose()
        Me.CrystalReportViewer1.ReportSource = Nothing

        'If Not System.IO.File.Exists("c:\rpt_db.mdb") = False Then
        '    Kill("c:\rpt_db.mdb")
        'End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rapor = New CrystalReport1
        Me.CrystalReportViewer1.ReportSource = Rapor
    End Sub
End Class