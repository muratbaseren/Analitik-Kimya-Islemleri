#Region "imports"
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class Form2

#Region "GroupBox Olaylarý"
    Private Sub GrupAc(ByVal grp As GroupBox)

        Do While grp.Left < 207
            grp.Left += 1
        Loop

        Do While grp.Top > 31
            grp.Top -= 1
        Loop

        Do While grp.Height < CType(grp.Tag, GroupBoxDetaylari).YukseklikH
            grp.Height += 1
        Loop

        CType(grp.Tag, GroupBoxDetaylari).Durum = True
    End Sub

    Private Sub GrupKapa(ByVal grp As GroupBox)
        Do While grp.Height > 15
            grp.Height -= 1
        Loop

        Do While grp.Top < CType(grp.Tag, GroupBoxDetaylari).KonumY
            grp.Top += 1
        Loop

        Do While grp.Left > CType(grp.Tag, GroupBoxDetaylari).KonumX
            grp.Left -= 1
        Loop

        CType(grp.Tag, GroupBoxDetaylari).Durum = False
    End Sub

    Private Sub GroupBoxTiklama(ByVal sender As Object, ByVal e As EventArgs) Handles grpGercekDeger.Click, grpOrtalama.Click, grpOrtStdHatasi.Click, grpStdHata.Click, grpStdSapma.Click, grpVaryans.Click, grpYuzdeBagStdSapma.Click
        Dim ctrl As Control
        Dim grp As GroupBox
        Dim HepsiKapali As Boolean = True

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                grp = CType(ctrl, GroupBox)
                If CType(CType(ctrl, GroupBox).Tag, GroupBoxDetaylari).Durum = True Then
                    GrupKapa(CType(ctrl, GroupBox))
                    HepsiKapali = False
                    Exit For
                End If
            End If
        Next

        'Eðer týklanan groupbox açýk olan groupbox deðilse yenisini açar yoksa açýk olaný yukarda kapadýktan sonra çýkar..
        If Not ctrl.Name = CType(sender, GroupBox).Name OrElse HepsiKapali = True Then
            If CType(CType(sender, GroupBox).Tag, GroupBoxDetaylari).Durum.ToString = False Then
                GrupAc(CType(sender, GroupBox))
            Else
                GrupKapa(CType(sender, GroupBox))
            End If
        End If

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            CType(CType(Me.MdiParent.Controls(0), MenuStrip).Items(1), ToolStripMenuItem).DropDownItems(0).Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable = New DataTable
        Dim Detaylar As GroupBoxDetaylari

        Dim dll_FWR As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        DT = dll_FWR.ReadXMLFile(Application.StartupPath & "\GroupBoxAyarlari.xml")

        'Herbir groupbox için XML bilgileri okunup "GroupBoxDetaylari" instance 'ý oluþturulur ve "Tag" içine atýlýr..
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                Dim grp As GroupBox = CType(ctrl, GroupBox)

                For Each dr As DataRow In DT.Rows
                    If dr(0).ToString = grp.Name Then
                        Detaylar = New GroupBoxDetaylari(CInt(dr(1).ToString), CInt(dr(2).ToString), CInt(dr(3).ToString), False)
                        grp.Tag = Detaylar
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Grup_StandartForeColor()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                CType(ctrl, GroupBox).ForeColor = Color.Blue
            End If
        Next
    End Sub

    Private Sub Grup_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpStdHata.MouseHover, grpGercekDeger.MouseHover, grpOrtalama.MouseHover, grpOrtStdHatasi.MouseHover, grpStdSapma.MouseHover, grpVaryans.MouseHover, grpYuzdeBagStdSapma.MouseHover
        Grup_StandartForeColor()

        CType(sender, GroupBox).ForeColor = Color.Red
    End Sub
#End Region

#Region "Liste Olaylarý"
    Private Sub btnDegerEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDegerEkle.Click
        If IsNumeric(Me.txtDegerEkle.Text) = True Then
            Me.clbDegerler.Items.Add(Me.txtDegerEkle.Text)
        Else
            MessageBox.Show("Lütfen bir sayý giriniz..", "Sayý Giriniz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnDegerSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDegerSil.Click
        If MessageBox.Show("Ýþaretli deðer ya da deðerler silinsin mi?", "Ýþaretli Deðer(leri) Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            For i As Integer = Me.clbDegerler.Items.Count - 1 To 0 Step -1
                If Me.clbDegerler.GetItemCheckState(i) = CheckState.Checked Then
                    Me.clbDegerler.Items.RemoveAt(i)
                End If
            Next
        End If
    End Sub

    Private Sub clbDegerler_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles clbDegerler.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnDegerSil_Click(sender, e)
        End If
    End Sub

    Private Sub btnYukari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYukari.Click
        Dim index As Integer = Me.clbDegerler.SelectedIndex

        If Not Me.clbDegerler.SelectedIndex = -1 Then
            If Not Me.clbDegerler.SelectedIndex = 0 Then
                Me.clbDegerler.Items.Insert(index - 1, Me.clbDegerler.SelectedItem)
                Me.clbDegerler.Items.RemoveAt(Me.clbDegerler.SelectedIndex)
                Me.clbDegerler.SelectedIndex = index - 1
            End If
        End If
    End Sub

    Private Sub btnAsagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsagi.Click
        Dim index As Integer = Me.clbDegerler.SelectedIndex

        If Not Me.clbDegerler.SelectedIndex = -1 Then
            If Not Me.clbDegerler.SelectedIndex = Me.clbDegerler.Items.Count - 1 Then
                Me.clbDegerler.Items.Insert(index + 2, Me.clbDegerler.SelectedItem)
                Me.clbDegerler.Items.RemoveAt(Me.clbDegerler.SelectedIndex)
                Me.clbDegerler.SelectedIndex = index + 1
            End If
        End If
    End Sub

#End Region

#Region "Menü Olaylarý"
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Me.clbDegerler.Items.Clear()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        If Me.clbDegerler.Items.Count <> 0 Then
            If MessageBox.Show("Varolan listeniz deðiþecektir. Deðerleriniz kaybolacaktýr. Devam etmek istiyormusunuz?", "Liste Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Me.OpenFileDialog1.Filter = "Deðer Listesi(*.xml)|*.xml"
        Me.OpenFileDialog1.Title = "Deðer Listesi Açma"

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dll_FRW As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
            Dim DT As DataTable = New DataTable

            DT = dll_FRW.ReadXMLFile(Me.OpenFileDialog1.FileName.ToString)

            For Each DR As DataRow In DT.Rows
                Me.clbDegerler.Items.Add(CType(DR.Item(0).ToString, Single))
            Next
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If Me.clbDegerler.Items.Count = 0 Then Exit Sub

        Me.SaveFileDialog1.Filter = "Deðer Listesi(*.xml)|*.xml"
        Me.SaveFileDialog1.Title = "Deðerlerin Listesini Kaydetme"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim DT As DataTable = New DataTable
            Dim DR As DataRow

            DT.Columns.Add("Deger")

            For i As Integer = 0 To Me.clbDegerler.Items.Count - 1
                DR = DT.NewRow()
                DR.Item(0) = Me.clbDegerler.Items(i).ToString
                DT.Rows.Add(DR)
            Next

            Dim dll_FRW As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
            dll_FRW.XMLFileWriter(DT, Me.SaveFileDialog1.FileName.ToString)

        End If
    End Sub

    Private Sub CutCopyPasteEvents(ByVal UserEvent As String, ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is GroupBox) OrElse (TypeOf ctrl Is Panel) Then
                For Each ctrl2 As Control In ctrl.Controls
                    If TypeOf ctrl2 Is TextBox Then
                        Dim txt As TextBox = CType(ctrl2, TextBox)
                        If txt.Focused = True Then
                            If txt.SelectionLength <> 0 Then
                                Select Case UserEvent
                                    Case "Cut"
                                        txt.Cut()
                                    Case "Copy"
                                        txt.Copy()
                                End Select
                            ElseIf UserEvent = "Paste" Then
                                txt.Paste()
                            End If
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        CutCopyPasteEvents("Cut", sender, e)
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        CutCopyPasteEvents("Copy", sender, e)
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        CutCopyPasteEvents("Paste", sender, e)
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

        Dim RaporIsmi As String = InputBox("Rapor Baþlýðý Giriniz...", "Rapor Baþlýðý")

        'Connection ve Command oluþturulur..
        Dim ConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\rpt_db.mdb;"
        Dim Conn As OleDbConnection
        Dim Cmd As OleDbCommand

        Try

            Conn = New OleDbConnection(ConnStr)
            Cmd = New OleDbCommand()
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure

            'Ýlk olarak Tablodaki veriler silinir..
            Conn.Open()

            'Deðerler tablosu temizlenir..
            Cmd.CommandText = "sp_TemizleDegerler"
            Cmd.ExecuteNonQuery()

            'Sonuçlar tablosu temizlenir..
            Cmd.CommandText = "sp_TemizleSonuclar"
            Cmd.ExecuteNonQuery()

            'Sonuclar tablosu deðerleri girilir..
            Cmd.Parameters.AddWithValue("@ID", Now.ToShortDateString)
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@StdHat", CType(Me.txtStdHatSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@StdHat", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@StdSap", CType(Me.txtStdSapSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@StdSap", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@Var", CType(Me.txtVarSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@Var", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@GerDeg", CType(Me.txtGerDegSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@GerDeg", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@BagStdSap", CType(Me.txtBagStdSapSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@BagStdSap", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@OrtStdHat", CType(Me.txtOrtStdHatSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@OrtStdHat", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@Ort", CType(Me.txtOrtSonuc.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@Ort", 0.0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@DegSay", Me.clbDegerler.Items.Count)
            Else
                Cmd.Parameters.AddWithValue("@DegSay", 0)
            End If
            If Not Me.txtStdHatSonuc.Text Is Nothing AndAlso IsNumeric(Me.txtStdHatSonuc.Text) = True Then
                Cmd.Parameters.AddWithValue("@tDegeri", CType(Me.txtGerDegTDeg.Text, Single))
            Else
                Cmd.Parameters.AddWithValue("@tDegeri", 0.0)
            End If

            Cmd.Parameters.AddWithValue("@RaporIsmi", RaporIsmi.ToString)

            'Sonuclar tablosu Insert iþlemi..
            Cmd.CommandText = "sp_SonucEkle"
            Cmd.ExecuteNonQuery()

            'Veriler Degerler tablosuna Insert edilir..
            For i As Integer = 0 To Me.clbDegerler.Items.Count - 1
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Deger", CType(Me.clbDegerler.Items(i).ToString, Single))

                Cmd.CommandText = "sp_DegerEkle"
                Cmd.ExecuteNonQuery()
            Next

            'parametre deðerleri temizlenir..
            Cmd.Parameters.Clear()

            System.Threading.Thread.Sleep(500)

            'Raporlama için Database ,CrystalReport'un okuyabilmesi için C:\ ya kopyalanýr..
            'FileCopy(Application.StartupPath & "\rpt_db.mdb", "c:\rpt_db.mdb")

            System.Threading.Thread.Sleep(500)

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "DATABASE HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "GENEL HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Finally
            Conn.Close()
            Cmd.Dispose()
            Conn.Dispose()
        End Try

        'Raporlama Form 'u açýlýr..
        Dim frm As Form3 = New Form3
        frm.RaporAc(RaporIsmi)
        frm.Show()
    End Sub

    Private Sub HesapMakinesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HesapMakinesi.Click
        Shell(Application.StartupPath & "\calc.exe", AppWinStyle.NormalFocus)
    End Sub
#End Region

#Region "Hesaplamalar"
    Private Function Kontroller(ByVal HesapTuru As HesapTipi) As Boolean
        Kontroller = False

        If Me.clbDegerler.Items.Count = 0 Then
            MessageBox.Show("Girilmiþ veriniz bulunmamaktadýr. Lütfen veri girip öyle hesaplama yapýnýz..", "Girilmiþ Veri Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Kontroller = True
            Return Kontroller
            Exit Function
        End If

        Return Kontroller
    End Function

    Private Function Ortalama() As Single
        Dim Ort As Single = 0
        Try


            For i As Integer = 0 To Me.clbDegerler.Items.Count - 1
                Ort = Ort + Me.clbDegerler.Items(i)
            Next i
            Ort = Ort / Me.clbDegerler.Items.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Hata", MessageBoxButtons.OK)
        End Try

        Return Ort
    End Function

    Private Function StandartSapma() As Single
        Dim DegerOrtalamasi As Single = Ortalama()

        For i As Integer = 0 To Me.clbDegerler.Items.Count - 1
            StandartSapma = StandartSapma + ((Me.clbDegerler.Items(i) - DegerOrtalamasi) ^ 2)
        Next i

        StandartSapma = (StandartSapma / (Me.clbDegerler.Items.Count - 1)) ^ (1 / 2)

        Return StandartSapma
    End Function

    Private Sub btnStdHatHesapla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStdHatHesapla.Click

        Dim GercekDeger As Single
        Dim Toplam As Single = 0

        If Kontroller(HesapTipi.StandartHata) Then Exit Sub

        If IsNumeric(Me.txtStdHatGerDeg.Text) = False Then
            MessageBox.Show("Gerçek deðeri lütfen sayý olarak giriniz..", "Gerçek Deðer Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        GercekDeger = CType(Me.txtStdHatGerDeg.Text, Single)

        If Me.clbDegerler.Items.Count < 21 Then
            If MessageBox.Show("Standart Hata 20'den fazla veri için yapýlan bir iþlemdir.Veri sayýnýz 20 veya 20'den az ise Standart Sapma'yý kullanmalýsýnýz.." & Chr(13) & Chr(13) & "Yinede devam etmek istiyor musunuz?", "Standart Hata Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        For i As Integer = 0 To Me.clbDegerler.Items.Count - 1
            Toplam = Toplam + (Me.clbDegerler.Items(i) - GercekDeger) ^ 2
        Next i

        Toplam = (Toplam / Me.clbDegerler.Items.Count) ^ (1 / 2)
        txtStdHatSonuc.Text = Toplam
    End Sub

    Private Sub btnStdSapHesapla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStdSapHesapla.Click
        Me.txtStdSapOrt.Text = Ortalama()
        Me.txtStdSapSonuc.Text = StandartSapma()
        'Ara_Ortalama = Ortalama
    End Sub

    Private Sub btnVarHesapla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVarHesapla.Click
        If Kontroller(HesapTipi.Varyans) Then Exit Sub

        Me.txtVarOrt.Text = Ortalama().ToString
        Me.txtVarStdSapma.Text = StandartSapma().ToString
        Me.txtVarSonuc.Text = (CType(Me.txtVarStdSapma.Text, Single) ^ (1 / 2)).ToString
    End Sub

    Private Sub btnBagStdSapHesapla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBagStdSapHesapla.Click
        If Kontroller(HesapTipi.YuzdeBagilStdSapma) Then Exit Sub

        Me.txtBagStdSapOrt.Text = Ortalama().ToString
        Me.txtBagStdSapStdSap.Text = StandartSapma().ToString
        Me.txtBagStdSapSonuc.Text = (CType(Me.txtBagStdSapStdSap.Text, Single) / CType(Me.txtBagStdSapOrt.Text, Single) * 100).ToString
    End Sub

    Private Sub btnOrtStdHatHesapla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOrtStdHatHesapla.Click
        If Kontroller(HesapTipi.OrtStdHatasi) Then Exit Sub

        Me.txtOrtStdHatDegSay.Text = Me.clbDegerler.Items.Count.ToString
        Me.txtOrtStdHatStdSap.Text = StandartSapma().ToString
        Me.txtOrtStdHatSonuc.Text = (CType(Me.txtOrtStdHatStdSap.Text, Single) / (CType(Me.clbDegerler.Items.Count, Single) ^ (1 / 2))).ToString
    End Sub

    Private Sub btnOrtHesapla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOrtHesapla.Click
        If Kontroller(HesapTipi.Ortalama) Then Exit Sub

        Me.txtOrtDegSay.Text = Me.clbDegerler.Items.Count.ToString
        Me.txtOrtSonuc.Text = Ortalama().ToString
    End Sub

    Private Sub btnGerDegHesapla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGerDegHesapla.Click
        If Kontroller(HesapTipi.GercekDeger) Then Exit Sub

        If IsNumeric(Me.txtGerDegTDeg.Text) = False Then
            MessageBox.Show("Lütfen t deðerini sayý olarak giriniz.." & vbCrLf & vbCrLf & "(t tablosundan  " & Me.clbDegerler.Items.Count - 1.ToString & "  serbestlik derecesinde  %... ifadenize karþýlýk gelen deðeri okuyup giriniz.. ", "t Deðeri Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Me.txtGerDegDegSay.Text = Me.clbDegerler.Items.Count.ToString
        Me.txtGerDegOrt.Text = Ortalama().ToString
        Me.txtGerDegStdSap.Text = StandartSapma().ToString
        Me.txtGerDegSonuc.Text = ((CType(Me.txtGerDegStdSap.Text, Single) + (CType(Me.txtGerDegStdSap.Text, Single) * CType(Me.txtGerDegTDeg.Text, Single))) / (CType(Me.clbDegerler.Items.Count, Single) ^ (1 / 2))).ToString

    End Sub
#End Region

End Class

Public Enum HesapTipi
    [StandartHata] = 0
    [StandartSapma] = 1
    [Varyans] = 2
    [GercekDeger] = 3
    [YuzdeBagilStdSapma] = 4
    [OrtStdHatasi] = 5
    [Ortalama] = 6
End Enum