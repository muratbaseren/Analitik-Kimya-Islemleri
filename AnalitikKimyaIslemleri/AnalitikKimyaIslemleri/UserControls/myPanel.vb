#Region "imports"
Imports System.Math
#End Region

Public Class myPanel

#Region "Yerel Deðiþkenler"
    Private arr(1) As String
    Private i As Integer
#End Region

#Region "Public Olaylar"
    Public Event RaporYarat_Click(ByVal sender As Object, ByVal e As EventArgs)
#End Region

#Region "Public Methods"
    Public Sub RaporAktiflestir()
        If Me.lsvDegerler.Items.Count <> 0 Then
            Me.btnRaporYarat.Enabled = True
        End If
    End Sub
#End Region

#Region "Form Olaylarý"
    Private Sub myPanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtHacimArtis.Text = "1"
        Me.txtTesirDegeri.Text = "1"
        Me.lsvDegerler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Public Sub RaporHesapDuzenleme(ByVal Sender As Object, ByVal e As EventArgs) Handles btnDuzenle.Click, txtHacimArtis.TextChanged, txtTesirDegeri.TextChanged, txtTitrantDerisimi.TextChanged, txtTitrantHacmi.TextChanged, txtTitreEdilenDerisimi.TextChanged, txtTitreEdilenHacmi.TextChanged
        Me.btnRaporYarat.Enabled = False
    End Sub

    Public Sub RaporButonuDurumu(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
#End Region

#Region "Kontrol Mekanizmasý"
    Private Function KontrolKontrolu(ByVal ctrl As Control) As Boolean
        KontrolKontrolu = False

        If (TypeOf ctrl Is TextBox AndAlso ctrl.Tag = "sayisal") OrElse TypeOf ctrl Is ComboBox Then
            If TypeOf ctrl Is TextBox Then
                If IsNumeric(CType(ctrl, TextBox).Text) = False Then
                    CType(ctrl, TextBox).Focus()
                    MessageBox.Show("Geçerli sayýsal bir ifade girilmemiþ. Lütfen düzeltip hesapla iþlemini deneyiniz..", "Sayýsal Ýfade Hatasý!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    KontrolKontrolu = True
                Else
                    If CType(ctrl, TextBox).Name = "txtTesirDegeri" OrElse CType(ctrl, TextBox).Name = "txtHacimArtis" Then
                        If CType(CType(ctrl, TextBox).Text, Single) < 1 AndAlso CType(ctrl, TextBox).Name = "txtTesirDegeri" Then
                            CType(ctrl, TextBox).Text = 1
                        ElseIf CType(CType(ctrl, TextBox).Text, Single) <= 0 AndAlso CType(ctrl, TextBox).Name = "txtHacimArtis" Then
                            CType(ctrl, TextBox).Text = 1
                        End If
                    End If
                End If
            Else
                If CType(ctrl, ComboBox).SelectedIndex = -1 Then
                    CType(ctrl, ComboBox).Focus()
                    MessageBox.Show("Lütfen tür alanlarýnda bir deðer seçiniz..", "Tür Seçimi Yapýlmamýþ!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    KontrolKontrolu = True
                Else
                    arr(i) = CType(ctrl, ComboBox).Text
                    i += 1
                End If
            End If
        End If


        Return KontrolKontrolu
    End Function

    Private Function KontrolMekanizmasi() As Boolean
        KontrolMekanizmasi = False
        i = 0
        arr(0) = ""
        arr(1) = ""

        'Alanlara sayý girildiði yada combobox'larda seçim yapýlýp yapýlmadýðýnýn kontrolü.
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                For Each ctrl2 As Control In ctrl.Controls
                    KontrolMekanizmasi = KontrolKontrolu(ctrl2)
                    If KontrolMekanizmasi = True Then Exit For
                Next
            Else
                KontrolMekanizmasi = KontrolKontrolu(ctrl)
                If KontrolMekanizmasi = True Then Exit For
            End If
            If KontrolMekanizmasi = True Then Exit For
        Next

        'Titrant ve titre edilen türünün farklý seçilip seçilmediði kontrolü.
        If KontrolMekanizmasi = False Then
            If arr(0).ToString = arr(1).ToString Then
                MessageBox.Show("Lütfen titrant ve titre edilen türünü farklý seçiniz..", "Türler Ayný", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                KontrolMekanizmasi = True
            End If
        End If

        Return KontrolMekanizmasi
    End Function
#End Region

#Region "HesaplaDüzeneRaporYarat"
    Private Sub btnHesapla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHesapla.Click
        If KontrolMekanizmasi() = False Then
            Dim TitrantDer As Single = CType(Me.txtTitrantDerisimi.Text, Single)
            Dim TitrantHac As Single = CType(Me.txtTitrantHacmi.Text, Single)
            Dim TitreDer As Single = CType(Me.txtTitreEdilenDerisimi.Text, Single)
            Dim TitreHac As Single = CType(Me.txtTitreEdilenHacmi.Text, Single)
            Dim TesirDeg As Single = CType(Me.txtTesirDegeri.Text, Single)
            Dim HacimArtisi As Single = CType(Me.txtHacimArtis.Text, Single)
            Dim AsitDer As Single = 0
            Dim ph As Single = 0
            Dim ToplamHacim As Single = TitrantHac + TitreHac
            Dim i As Single = 0

            Me.lsvDegerler.Items.Clear()

            Do
                If (TitrantDer * (i)) > (TitreDer * TitreHac) Then
                    AsitDer = (1 / TesirDeg) * (((TitrantDer * (i)) - (TitreDer * TitreHac)) / (TitreHac + i))
                    ph = 14 - CType(-Log(AsitDer), Single)
                Else
                    AsitDer = (1 / TesirDeg) * (((TitreDer * TitreHac) - (TitrantDer * (i))) / (TitreHac + i))
                    ph = CType(-Log(AsitDer), Single)
                End If


                Dim itm As ListViewItem = New ListViewItem()
                itm.Text = i.ToString
                itm.SubItems.Add((i + TitreHac).ToString)
                itm.SubItems.Add(AsitDer.ToString)
                itm.SubItems.Add(ph.ToString)

                Me.lsvDegerler.Items.Add(itm)

                i += HacimArtisi
            Loop While (i <= TitrantHac)
        End If

        Me.btnRaporYarat.Enabled = True
    End Sub

    Private Sub btnDuzenle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuzenle.Click
        cmnuSeciliDuzenle_Click(sender, e)
    End Sub

    Private Sub btnRaporYarat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaporYarat.Click
        RaiseEvent RaporYarat_Click(sender, e)
    End Sub
#End Region

#Region "ContextMenuOlaylarý"
    Private Sub cmnuSeciliDuzenle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuSeciliDuzenle.Click
        If Not Me.lsvDegerler.FocusedItem Is Nothing Then
            Dim frm As Form5 = New Form5
            frm.DegerYaz(Me.lsvDegerler.FocusedItem)
            If frm.ShowDialog = DialogResult.OK Then
                Me.lsvDegerler.FocusedItem.SubItems(0).Text = frm.itm.SubItems(0).Text
                Me.lsvDegerler.FocusedItem.SubItems(1).Text = frm.itm.SubItems(1).Text
                Me.lsvDegerler.FocusedItem.SubItems(2).Text = frm.itm.SubItems(2).Text
                Me.lsvDegerler.FocusedItem.SubItems(3).Text = frm.itm.SubItems(3).Text
            End If
        Else
            MessageBox.Show("Lütfen listeden bir satýr seçerek düzenleme yapýnýz..", "Seçili Satýr Yok !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cmnuSeciliSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuSeciliSil.Click
        For Each itm As ListViewItem In Me.lsvDegerler.CheckedItems
            itm.Remove()
        Next
    End Sub

    Private Sub cmnuTumunuSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTumunuSil.Click
        Me.lsvDegerler.Items.Clear()
    End Sub

    Private Sub cmnRaporYarat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnRaporYarat.Click
        btnRaporYarat_Click(sender, e)
    End Sub
#End Region

End Class
