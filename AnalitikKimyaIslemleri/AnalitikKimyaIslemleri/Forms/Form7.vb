Public Class Form7

    'Public Event WebAdresleriYenile(ByVal sender As Object, ByVal e As FormClosingEventArgs)

    Private Liste_ As DataTable

    Public Property Liste() As DataTable
        Get
            Return Me.Liste_
        End Get
        Set(ByVal value As DataTable)
            Me.Liste_ = value
        End Set
    End Property

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dll As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        Dim dt As DataTable = New DataTable

        dt = dll.ReadXMLFile(Application.StartupPath & "\" & "WbAdrs.xml")

        For Each dr As DataRow In dt.Rows
            Dim itm As ListViewItem = New ListViewItem
            itm.Text = ""
            'itm.SubItems.Add(dr(0).ToString)
            'itm.SubItems.Add(dr(1).ToString)
            itm.SubItems.AddRange(New ListViewItem.ListViewSubItem() {(New ListViewItem.ListViewSubItem(itm, dr(0).ToString)), (New ListViewItem.ListViewSubItem(itm, dr(1).ToString))})

            Me.lstAdresler.Items.Add(itm)
        Next

        Me.tssAdresSayisi.Text = Me.lstAdresler.Items.Count & " adet adres vardýr."
    End Sub

    Private Sub btnEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEkle.Click
        Dim itm As ListViewItem = New ListViewItem
        Dim adres As String = Me.txtWebAdresi.Text
        If adres.Substring(0, 7) <> "http:\\" Then adres = "http:\\" & adres

        itm.Text = ""
        itm.SubItems.AddRange(New ListViewItem.ListViewSubItem() {(New ListViewItem.ListViewSubItem(itm, Me.txtBaslik.Text)), (New ListViewItem.ListViewSubItem(itm, adres))})
        Me.lstAdresler.Items.Add(itm)

        Me.tssAdresSayisi.Text = Me.lstAdresler.Items.Count & " adet adres vardýr."
    End Sub

    Private Sub btnSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSil.Click
        Dim msj As String = "Seçili mesajlarý silmek istediðinize emin misiniz?"

        If MessageBox.Show(msj, "Seçili Adresleri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            For Each itm As ListViewItem In Me.lstAdresler.CheckedItems
                itm.Remove()
            Next
        End If

        Me.tssAdresSayisi.Text = Me.lstAdresler.Items.Count & " adet adres vardýr."
    End Sub

    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click
        Dim dt As DataTable = New DataTable
        dt.Columns.AddRange(New DataColumn() {(New DataColumn("Baslik")), (New DataColumn("Adres"))})

        Dim dr As DataRow

        For Each itm As ListViewItem In Me.lstAdresler.Items
            dr = dt.NewRow
            dr(0) = itm.SubItems(1).Text
            dr(1) = itm.SubItems(2).Text
            dt.Rows.Add(dr)
        Next

        Dim dll As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        dll.XMLFileWriter(dt, Application.StartupPath & "\" & "WbAdrs.xml")

        Me.Liste_ = dt

        'RaiseEvent WebAdresleriYenile(sender, e)

        Me.Close()
    End Sub

    Private Sub lstAdresler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAdresler.SelectedIndexChanged
        If Not Me.lstAdresler.FocusedItem Is Nothing Then
            Dim itm As ListViewItem = Me.lstAdresler.FocusedItem
            Me.txtBaslik.Text = itm.SubItems(1).Text
            Me.txtWebAdresi.Text = itm.SubItems(2).Text
        End If
    End Sub
End Class