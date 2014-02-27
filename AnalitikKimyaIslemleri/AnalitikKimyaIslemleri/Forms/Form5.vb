Public Class Form5

    Private itm_ As ListViewItem

    Public Property itm() As ListViewItem
        Get
            Return Me.itm_
        End Get
        Set(ByVal value As ListViewItem)
            Me.itm_ = value
        End Set
    End Property

    Public Sub DegerYaz(ByVal itm As ListViewItem)
        Me.txtEklenenTitrantHacmi.Text = itm.SubItems(0).Text
        Me.txtToplamHacim.Text = itm.SubItems(1).Text
        Me.txtDerisim.Text = itm.SubItems(2).Text
        Me.txtPh.Text = itm.SubItems(3).Text

        itm_ = itm
    End Sub

    Private Sub Form5_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim new_itm As ListViewItem = New ListViewItem
        new_itm.Text = Me.txtEklenenTitrantHacmi.Text
        new_itm.SubItems.Add(Me.txtToplamHacim.Text)
        new_itm.SubItems.Add(Me.txtDerisim.Text)
        new_itm.SubItems.Add(Me.txtPh.Text)

        itm_ = new_itm
    End Sub
End Class