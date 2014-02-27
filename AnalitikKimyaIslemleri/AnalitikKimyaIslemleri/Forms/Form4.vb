#Region "imports"
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
#End Region

Public Class Form4

#Region "Form Olaylarý"
    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            For Each tp As myTabPage In Me.TabControl1.TabPages
                CrysViewerUlasma(tp).ReportSource = Nothing
            Next

            'If System.IO.File.Exists("c:\tit_db.mdb") = True Then Kill("c:\tit_db.mdb")
            'Kill(Application.StartupPath & "\" & "*.mdb")

            CType(CType(Me.MdiParent.Controls(0), MenuStrip).Items(1), ToolStripMenuItem).DropDownItems(1).Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Kill(Application.StartupPath & "\" & "*.mdb")
        Catch ex As Exception

        End Try
        'If System.IO.File.Exists(Application.StartupPath & "\" & "tit_db.mdb") = True Then Kill(Application.StartupPath & "\" & "tit_db.mdb")
        'FileCopy(Application.StartupPath & "\Databases\" & "tit_db.mdb", Application.StartupPath & "\" & "tit_db.mdb")
    End Sub
#End Region

#Region "Runtime TabPage Methodlarý"
    Private Sub TabPageOlusturma(ByVal PageName As String)
        Dim tp As myTabPage = New myTabPage(New myTabPageAyarlari(), New DatabaseAyarlari(), New CrystalReportAyarlari())
        tp.Text = PageName

        Dim pnl As myPanel = New myPanel
        '"RaporYarat_Click" adlý public event ,user control'de "Rapor Yarat" butonuna basýlýnca "RaiseEvent RaporYarat_Click" komutu ile çalýþýr.Burada O public event gerçekleþince gidilecek konumu tanýmladýk. "RaporYarat" adlý sub çalýþýr..
        AddHandler pnl.RaporYarat_Click, AddressOf RaporYarat

        tp.Controls.Add(pnl)
        Me.TabControl1.TabPages.Add(tp)

        'Oluþturulan TabPage'in database'de tablosu oluþturulur..
        TabPageDbOlusturma(tp)
    End Sub

    Private Sub TabPageDbOlusturma(ByVal tp As myTabPage)
        Dim DatabaseIsmi As String = "db_" & CStr(Me.TabControl1.TabPages.Count - 1) & ".mdb"
        DatabaseOlusturma(DatabaseIsmi)

        Dim dbConn As dbConnection = New dbConnection(DatabaseIsmi)
        dbConn.CreateTable(True, "Table1_0")
        dbConn.CreateTable(False, "Table2_0")

        tp.DatabaseAyarlari.DatabaseIsmi = DatabaseIsmi
    End Sub

    Private Function KaydetmeIcinKontrolIcerigiOkuma(ByVal ctrl As Control) As String
        KaydetmeIcinKontrolIcerigiOkuma = ""

        If TypeOf ctrl Is TextBox Then
            KaydetmeIcinKontrolIcerigiOkuma = CType(ctrl, TextBox).Text.ToString
        ElseIf TypeOf ctrl Is ComboBox Then
            KaydetmeIcinKontrolIcerigiOkuma = CType(ctrl, ComboBox).SelectedIndex.ToString
        End If

        Return KaydetmeIcinKontrolIcerigiOkuma
    End Function

    Private Function KaydetmeIcinDtOlusturma(ByVal Name As String, ByVal txt As String, ByVal DRow As DataRow) As DataRow
        Select Case Name
            Case "txtTitrantIsmi"
                DRow(0) = txt.ToString
            Case "txtTitrantDerisimi"
                DRow(1) = txt.ToString
            Case "txtTitrantHacmi"
                DRow(2) = txt.ToString
            Case "cmbTitrantTuru"
                DRow(3) = txt.ToString
            Case "txtTitreEdilenIsmi"
                DRow(4) = txt.ToString
            Case "txtTitreEdilenDerisimi"
                DRow(5) = txt.ToString
            Case "txtTitreEdilenHacmi"
                DRow(6) = txt.ToString
            Case "cmbTitreEdilenTuru"
                DRow(7) = txt.ToString
            Case "txtTesirDegeri"
                DRow(8) = txt.ToString
            Case "txtHacimArtis"
                DRow(9) = txt.ToString
            Case "txtRaporBasligi"
                DRow(10) = txt.ToString
            Case "txtDipNot"
                DRow(11) = txt.ToString
            Case "txtImza"
                DRow(12) = txt.ToString
        End Select

        Return DRow
    End Function

    Private Sub TabPageKaydetme(ByVal Konum As String, ByVal tp As myTabPage)
        '*******************************************************************************
        '************************** .TKD XML Dosyasýnýn Oluþturulmasý*******************

        Dim DT As DataTable = New DataTable
        DT.Columns.Add("txtTitrantIsmi")
        DT.Columns.Add("txtTitrantDerisimi")
        DT.Columns.Add("txtTitrantHacmi")
        DT.Columns.Add("cmbTitrantTuru")
        DT.Columns.Add("txtTitreEdilenIsmi")
        DT.Columns.Add("txtTitreEdilenDerisimi")
        DT.Columns.Add("txtTitreEdilenHacmi")
        DT.Columns.Add("cmbTitreEdilenTuru")
        DT.Columns.Add("txtTesirDegeri")
        DT.Columns.Add("txtHacimArtis")
        DT.Columns.Add("txtDipNot")
        DT.Columns.Add("txtRaporBasligi")
        DT.Columns.Add("txtImza")
        DT.Columns.Add("ListDosyasiKonumu")

        Dim DRow As DataRow
        DRow = DT.NewRow

        'myTabPage içinde tüm kontrollere ulaþýlýr.
        For Each ctrl As Control In Me.TabControl1.SelectedTab.Controls(0).Controls
            'Eðer kontrol bir groupbox ise ayrýca onun içindeki kontrollerdede dönülür.
            If TypeOf ctrl Is GroupBox Then
                'Kontrolün ismi, içeriði ve iþlenecek dataRow "KaydetmeIcinDtOlusturma" adlý sub'a gönderilerek DataRow oluþturulur.
                For Each ctrl2 As Control In ctrl.Controls
                    If TypeOf ctrl2 Is TextBox OrElse TypeOf ctrl2 Is ComboBox Then
                        KaydetmeIcinDtOlusturma(ctrl2.Name, KaydetmeIcinKontrolIcerigiOkuma(ctrl2).ToString, DRow)
                    End If
                Next
            ElseIf TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox Then
                KaydetmeIcinDtOlusturma(ctrl.Name, KaydetmeIcinKontrolIcerigiOkuma(ctrl).ToString, DRow)
            End If
        Next

        'Me.TabControl1.SelectedTab.Controls(0).Controls(3).Name.ToString
        'lstDegerler listview 'ýna eriþilir.Listedeki deðerleri XML olarak kaydetmek için.
        Dim lst As ListView
        For Each ctrl As Control In Me.TabControl1.SelectedTab.Controls(0).Controls
            If TypeOf ctrl Is ListView Then
                lst = CType(ctrl, ListView)
                Exit For
            End If
        Next

        '********** if listview item sayýsý "0" deðilse..**************************************
        'ListView'daki degerlerin bulundugu xml dosyasýnýn konumu .tkl uzantýlý xml'e iþlenir..
        Dim tkl_path As String
        If Not lst.Items.Count = 0 Then
            tkl_path = Konum.Substring(0, Konum.LastIndexOf("\") + 1) & tp.Text & ".tkl"
        Else
            tkl_path = "Nothing"
        End If

        DRow(13) = tkl_path

        DT.Rows.Add(DRow)

        '.tkd uzantýlý XML oluþturulur..
        Dim dllFRW As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        dllFRW.XMLFileWriter(DT, Konum)

        '************************** .TKD XML Dosyasýnýn Oluþturulmasý Sonu*******************
        '************************************************************************************

        DT.Dispose()

        '************************************************************************************
        '************************** .TKL XML Dosyasýnýn Oluþturulmasý************************
        'Eðer listede deðer yoksa..
        If lst.Items.Count = 0 Then Exit Sub

        'Eðer listede deðer varsa, .tkl uzantýlý XML dosyasý oluþturulmak üzere veriler iþlenir.
        DT = New DataTable
        DT.Columns.Add("EklenenTitrant")
        DT.Columns.Add("ToplamHacim")
        DT.Columns.Add("Derisim")
        DT.Columns.Add("ph")

        For Each itm As ListViewItem In lst.Items
            DRow = DT.NewRow
            DRow(0) = itm.SubItems(0).Text.ToString
            DRow(1) = itm.SubItems(1).Text.ToString
            DRow(2) = itm.SubItems(2).Text.ToString
            DRow(3) = itm.SubItems(3).Text.ToString
            DT.Rows.Add(DRow)
        Next

        '.tkl uzantýlý XML oluþturulur..
        dllFRW.XMLFileWriter(DT, tkl_path)

        '************************** .TKL XML Dosyasýnýn Oluþturulmasý************************
        '************************************************************************************
    End Sub

    Private Sub AcmaIcinKontrollereDegerAtama(ByVal Ctrl As Control, ByVal Drow As DataRow)
        Select Case Ctrl.Name.ToString
            Case "txtTitrantIsmi"
                Ctrl.Text = Drow(0).ToString
            Case "txtTitrantDerisimi"
                Ctrl.Text = Drow(1).ToString
            Case "txtTitrantHacmi"
                Ctrl.Text = Drow(2).ToString
            Case "cmbTitrantTuru"
                If CInt(Drow(3).ToString) <> -1 Then
                    CType(Ctrl, ComboBox).SelectedIndex = CInt(Drow(3).ToString)
                Else
                    CType(Ctrl, ComboBox).Text = "Seçiniz.."
                End If
            Case "txtTitreEdilenIsmi"
                Ctrl.Text = Drow(4).ToString
            Case "txtTitreEdilenDerisimi"
                Ctrl.Text = Drow(5).ToString
            Case "txtTitreEdilenHacmi"
                Ctrl.Text = Drow(6).ToString
            Case "cmbTitreEdilenTuru"
                If CInt(Drow(7).ToString) <> -1 Then
                    CType(Ctrl, ComboBox).SelectedIndex = CInt(Drow(7).ToString)
                Else
                    CType(Ctrl, ComboBox).Text = "Seçiniz.."
                End If
            Case "txtTesirDegeri"
                Ctrl.Text = Drow(8).ToString
            Case "txtHacimArtis"
                Ctrl.Text = Drow(9).ToString
            Case "txtRaporBasligi"
                Ctrl.Text = Drow(10).ToString
            Case "txtDipNot"
                Ctrl.Text = Drow(11).ToString
            Case "txtImza"
                Ctrl.Text = Drow(12).ToString
        End Select
    End Sub

    Private Sub TabPageAcma(ByVal Konum As String)
        Dim DT_tkd As DataTable = New DataTable

        '.tkd uzantýlý XML dosya içeriði DataTable'a aktarýlýr..
        Dim dllFRW As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        DT_tkd = dllFRW.ReadXMLFile(Konum)

        'DataTable içeriði seçili TabPage 'e aktarýlýr.
        For Each Drow As DataRow In DT_tkd.Rows
            'myTabPage içinde tüm kontrollere ulaþýlýr.
            For Each ctrl As Control In Me.TabControl1.SelectedTab.Controls(0).Controls
                'Eðer kontrol bir groupbox ise ayrýca onun içindeki kontrollerdede dönülür.
                If TypeOf ctrl Is GroupBox Then
                    For Each ctrl2 As Control In ctrl.Controls
                        'groupbox içindede textbox veya combobox için sistem meþgul olsun.
                        If TypeOf ctrl2 Is TextBox OrElse TypeOf ctrl2 Is ComboBox Then
                            AcmaIcinKontrollereDegerAtama(ctrl2, Drow)
                        End If
                    Next
                    'Eðer groupbox deðilse textbox veya combobox için sistem meþgul olsun.
                ElseIf TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox Then
                    AcmaIcinKontrollereDegerAtama(ctrl, Drow)
                End If
            Next

            'Eðer .tkd uzantýlý XML 'de son satýrda .tkl uzantýlý dosya konumu
            'varsa..
            If Not Drow(13).ToString = "Nothing" Then
                Dim DT_tkl As DataTable = New DataTable
                DT_tkl = dllFRW.ReadXMLFile(Drow(13).ToString)

                'Me.TabControl1.SelectedTab.Controls(0).Controls(3).Name.ToString()
                'lstDegerler listview 'ýna eriþilir.Listedeki deðerleri XML olarak kaydetmek için.
                Dim lst As ListView
                For Each cont As Control In Me.TabControl1.SelectedTab.Controls(0).Controls
                    If TypeOf cont Is ListView Then
                        lst = CType(cont, ListView)
                        Exit For
                    End If
                Next

                lst.Items.Clear()
                Dim itm As ListViewItem

                For Each dr As DataRow In DT_tkl.Rows
                    itm = New ListViewItem
                    itm.Text = dr(0).ToString
                    For i As Integer = 1 To 3
                        itm.SubItems.Add(dr(i).ToString)
                    Next
                    lst.Items.Add(itm)
                Next
            End If
        Next

        CType(Me.TabControl1.SelectedTab.Controls(0), myPanel).RaporAktiflestir()
    End Sub
#End Region

#Region "KesKopyalaYapistir"
    Private Sub CutCopyPaste(ByVal ctrl As Control, ByVal UserEvent As String)
        If TypeOf ctrl Is TextBox Then
            Dim txt As TextBox = CType(ctrl, TextBox)
            If txt.Focused = True Then
                If UserEvent <> "Paste" Then
                    If txt.SelectionLength <> 0 Then
                        Select Case UserEvent
                            Case "Cut"
                                txt.Cut()
                            Case "Copy"
                                txt.Copy()
                        End Select
                    End If
                Else
                    txt.Paste()
                End If
            End If
        End If
    End Sub

    Private Sub CutCopyPasteEvents(ByVal UserEvent As String, ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.TabControl1.SelectedIndex <> -1 Then
            For Each ctrl As Control In Me.TabControl1.SelectedTab.Controls(0).Controls
                If TypeOf ctrl Is GroupBox Then
                    For Each ctrl2 As Control In ctrl.Controls
                        CutCopyPaste(ctrl2, UserEvent)
                    Next
                Else
                    CutCopyPaste(ctrl, UserEvent)
                End If
            Next
        End If
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
#End Region

#Region "Menü Olaylarý"

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim TabPageBaslik As String = InputBox("Sekme Ismini Giriniz:", "Yeni Sekme")
        TabPageOlusturma(TabPageBaslik)

        If Me.TabControl1.TabPages.Count <> 0 Then
            Me.TabControl1.SelectedIndex = Me.TabControl1.TabPages.Count - 1
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click

        Me.OpenFileDialog1.Filter = "Titrasyon Kayýt Dosyasý(*.tkd)|*.tkd"
        Me.OpenFileDialog1.Title = "Titrasyon Kayýt Dosyasý Aç"
        Me.OpenFileDialog1.FileName = ""

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TabPageOlusturma(Me.OpenFileDialog1.FileName.ToString.Substring(Me.OpenFileDialog1.FileName.LastIndexOf("\") + 1, Me.OpenFileDialog1.FileName.LastIndexOf(".") - Me.OpenFileDialog1.FileName.LastIndexOf("\") - 1))

            If Me.TabControl1.TabPages.Count <> 0 Then
                Me.TabControl1.SelectedIndex = Me.TabControl1.TabPages.Count - 1
                TabPageAcma(Me.OpenFileDialog1.FileName)
            End If

        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

        If Me.TabControl1.SelectedIndex = -1 Then
            MessageBox.Show("Kaydetme iþlemi için bir sekme seçili deðil. Lütfen bir sekme seçiniz..", "Seçili Sekme Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Me.SaveFileDialog1.Filter = "Titrasyon Kayýt Dosyasý(*.tkd)|*.tkd"
        Me.OpenFileDialog1.Title = "Titrasyon Kayýt Dosyasý Kaydet"
        Me.SaveFileDialog1.FileName = Me.TabControl1.SelectedTab.Text

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TabPageKaydetme(Me.SaveFileDialog1.FileName, CType(Me.TabControl1.SelectedTab, myTabPage))
        End If
    End Sub

    Private Sub btnSaveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAll.Click
        If Me.TabControl1.TabPages.Count <> 0 Then
            If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim TabPageNames As ArrayList = New ArrayList
                Dim i As Integer = 0
                Dim tpIsmi As String

                For Each tp As myTabPage In Me.TabControl1.TabPages
                    'Ayný isimli tabpage varsa Ana isme gerekli numaralandýrma ekleme için Ana isim deðiþkene atýlýr..
                    tpIsmi = tp.Text

                    'Eðer ayný isimli sekme varsa sekme isminde yapýlacak düzenleme..
                    If TabPageNames.Count <> 0 Then
Tekrar:
                        For Each str As String In TabPageNames
                            If str = tp.Text Then
                                i += 1
                                tp.Text = tpIsmi & "_" & i.ToString
                                GoTo Tekrar
                            End If
                        Next
                    End If

                    i = 0

                    TabPageNames.Add(tp.Text)
                    'Me.TabControl1.SelectedTab = tp
                    TabPageKaydetme(FolderBrowserDialog1.SelectedPath & "\" & tp.Text & ".tkd", tp)
                Next
            End If
        End If
    End Sub

    Private Sub btnSekmeKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSekmeKapat.Click
        If Me.TabControl1.SelectedIndex <> -1 Then
            Dim tp As myTabPage = Me.TabControl1.SelectedTab
            '========
            'Eski Kod
            '========
            'Dim db As dbConnection = New dbConnection()

            'db.DropTable(tp.DatabaseAyarlari.Tablo1.ToString)
            'db.DropTable(tp.DatabaseAyarlari.Tablo2.ToString)
            '========
            CrysViewerUlasma(tp).ReportSource = Nothing
            tp.CrystalReportAyarlari.RaporInstance.Dispose()
            Kill(Application.StartupPath & "\" & tp.DatabaseAyarlari.DatabaseIsmi)

            tp.Dispose()
        End If
    End Sub
#End Region

#Region "CrystalReport"
    '=============================================================
    ''CrystalReport Ayarlarý..
    'Private Sub ConfigureCrystalReport()
    '    Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
    '    myConnectionInfo.Type = ConnectionInfoType.DBFile
    '    myConnectionInfo.DatabaseName = Application.StartupPath & "\" & "tit_db.mdb"

    '    Dim myReportPath As String = Application.StartupPath & "\" & "CrystalReport2.rpt"
    '    Me.CrystalReportViewer1.ReportSource = myReportPath

    '    SetDBLogonForReport(myConnectionInfo)
    'End Sub

    ''CrystalReport için her tablonun incelenemsi..
    'Private Sub SetDBLogonForReport(ByVal ConnectionInfo As ConnectionInfo)
    '    Dim myTableLogonInfos As TableLogOnInfos = Me.CrystalReportViewer1.LogOnInfo
    '    For Each myTableLogOnInfo As TableLogOnInfo In myTableLogonInfos
    '        If CType(Me.TabControl1.SelectedTab, myTabPage).DatabaseAyarlari.Tablo1.ToString = myTableLogOnInfo.TableName.ToString Then
    '            myTableLogOnInfo.ConnectionInfo = ConnectionInfo
    '        End If
    '    Next
    'End Sub
    '=============================================================

    Public Sub RaporYarat(ByVal sender As Object, ByVal e As EventArgs)
        Dim tp As myTabPage = CType(Me.TabControl1.SelectedTab, myTabPage)

        Dim db_conn As dbConnection
        db_conn = New dbConnection(tp.DatabaseAyarlari.DatabaseIsmi.ToString)
        db_conn.DeleteTables("Table1_0", "Table2_0")

        Dim DT As DataTable
        Dim Drow As DataRow
        Dim lst As ListView

        'Seçili TabPage'deki UserControl'de ListView 'a eriþilir.
        For Each ctrl As Control In tp.Controls(0).Controls
            If TypeOf ctrl Is ListView Then
                lst = CType(ctrl, ListView)
                Exit For
            End If
        Next

        If Not lst.Items.Count = 0 Then
            DT = New DataTable
            For Each clm As ColumnHeader In lst.Columns
                DT.Columns.Add(clm.Text)
            Next

            'ListView'daki her bir item için dönülür ve DataTable oluþturulur.
            For Each itm As ListViewItem In lst.Items
                Drow = DT.NewRow

                For i As Integer = 0 To 3
                    Drow(i) = itm.SubItems(i).Text.ToString
                Next

                DT.Rows.Add(Drow)
            Next

            'insert iþlemi gerçekleþir.
            db_conn.InsertTable1("Table1_0", DT)
        Else
            MessageBox.Show("Lütfen hesapla butonuna basýnýz ve bir hesaplama yaptýktan sonra Rapor Yarat' ý kullanýnýz..", "Hesaplama Yapýlmamýþ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

        DT.Dispose()
        DT = New DataTable

        DT.Columns.AddRange(New DataColumn() {(New DataColumn("txtTitrantIsmi")), (New DataColumn("txtTitrantDerisimi")), (New DataColumn("txtTitrantHacmi")), (New DataColumn("cmbTitrantTuru")), (New DataColumn("txtTitreEdilenIsmi")), (New DataColumn("txtTitreEdilenDerisimi")), (New DataColumn("txtTitreEdilenHacmi")), (New DataColumn("cmbTitreEdilenTuru")), (New DataColumn("txtTesirDegeri")), (New DataColumn("txtHacimArtis")), (New DataColumn("txtDipNot")), (New DataColumn("txtRaporBasligi")), (New DataColumn("txtImza"))})

        Drow = DT.NewRow

        'myTabPage içinde tüm kontrollere ulaþýlýr.
        For Each ctrl As Control In Me.TabControl1.SelectedTab.Controls(0).Controls
            'Eðer kontrol bir groupbox ise ayrýca onun içindeki kontrollerdede dönülür.
            If TypeOf ctrl Is GroupBox Then
                'Kontrolün ismi, içeriði ve iþlenecek dataRow "KaydetmeIcinDtOlusturma" adlý sub'a gönderilerek DataRow oluþturulur.
                For Each ctrl2 As Control In ctrl.Controls
                    If TypeOf ctrl2 Is TextBox Then
                        Drow = KaydetmeIcinDtOlusturma(ctrl2.Name, KaydetmeIcinKontrolIcerigiOkuma(ctrl2).ToString, Drow)
                    ElseIf TypeOf ctrl2 Is ComboBox Then
                        Dim Index As Integer = CInt(KaydetmeIcinKontrolIcerigiOkuma(ctrl2).ToString)
                        Drow = KaydetmeIcinDtOlusturma(ctrl2.Name, [Enum].GetName(New MaddeTuru().GetType, Index), Drow)
                    End If
                Next
            ElseIf TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox Then
                If TypeOf ctrl Is TextBox Then
                    Drow = KaydetmeIcinDtOlusturma(ctrl.Name, KaydetmeIcinKontrolIcerigiOkuma(ctrl).ToString, Drow)
                ElseIf TypeOf ctrl Is ComboBox Then
                    Dim Index As Integer = CInt(KaydetmeIcinKontrolIcerigiOkuma(ctrl).ToString)
                    Drow = KaydetmeIcinDtOlusturma(ctrl.Name, [Enum].GetName(New MaddeTuru().GetType, Index), Drow)
                End If
            End If
        Next

        db_conn.InsertTable2("Table2_0", Drow)

        RaporOlustur(tp)
    End Sub

    Private Sub RaporOlustur(ByVal tp As myTabPage)
        'Crystal report'un okuyacaðý database "c:\" ya kopyalanýr..
        DatabaseKopyala(tp.DatabaseAyarlari.DatabaseIsmi.ToString)

        Dim rapor As CrystalReport2 = New CrystalReport2
        'Dim myReportPath As String = Application.StartupPath & "\" & "CrystalReport2.rpt"

        'Dim DS As DataSet = New DataSet
        'Dim DT1 As DataTable = New DataTable
        'Dim DT2 As DataTable = New DataTable

        'Dim db As dbConnection = New dbConnection
        'DT1 = db.SelectTable(tp.DatabaseAyarlari.Tablo1.ToString)
        'DT2 = db.SelectTable(tp.DatabaseAyarlari.Tablo2.ToString)

        'DS.Tables.Add(DT1)
        'DS.Tables.Add(DT2)

        'rapor.SetDataSource(DS)
        tp.CrystalReportAyarlari.RaporInstance = Nothing
        tp.CrystalReportAyarlari.RaporInstance = rapor

        CrysViewerUlasma(tp).ReportSource = tp.CrystalReportAyarlari.RaporInstance
    End Sub

    Private Function CrysViewerUlasma(ByVal tp As myTabPage) As CrystalDecisions.Windows.Forms.CrystalReportViewer
        CrysViewerUlasma = Nothing

        For Each ctrl As Control In tp.Controls(0).Controls
            If TypeOf ctrl Is CrystalDecisions.Windows.Forms.CrystalReportViewer Then
                CrysViewerUlasma = CType(ctrl, CrystalDecisions.Windows.Forms.CrystalReportViewer)
            End If
        Next

        Return CrysViewerUlasma
    End Function

    Private Sub DatabaseKopyala(ByVal DatabaseIsmi As String)
        'If System.IO.File.Exists("c:\tit_db.mdb") = True Then Kill("c:\tit_db.mdb")
        'FileCopy(Application.StartupPath & "\" & DatabaseIsmi, "c:\tit_db.mdb")
    End Sub

    Private Sub DatabaseOlusturma(ByVal DatabaseIsmi As String)
        FileCopy(Application.StartupPath & "\Databases\" & "db_tit.mdb", Application.StartupPath & "\" & DatabaseIsmi)
    End Sub
#End Region

#Region "cmnuTabControl Olaylarý"
    Private Sub YeniSekmeAcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniSekmeAcToolStripMenuItem.Click
        NewToolStripButton_Click(sender, e)
    End Sub

    Private Sub SekmeyiKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SekmeyiKaydetToolStripMenuItem.Click
        SaveToolStripButton_Click(sender, e)
    End Sub

    Private Sub SekmeyiKapatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SekmeyiKapatToolStripMenuItem.Click
        btnSekmeKapat_Click(sender, e)
    End Sub

    Private Sub TumSekmeleriKapatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TumSekmeleriKapatToolStripMenuItem.Click
        If Me.TabControl1.TabPages.Count = 0 Then Exit Sub

        For Each tp As myTabPage In Me.TabControl1.TabPages
            Me.TabControl1.SelectedTab = tp
            btnSekmeKapat_Click(sender, e)
        Next
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If Me.TabControl1.TabPages.Count = 0 Then Exit Sub

        Dim tp As myTabPage = CType(Me.TabControl1.SelectedTab, myTabPage)

        'CrysViewerUlasma(tp).ReportSource = Nothing
        If Not tp.CrystalReportAyarlari.RaporInstance Is Nothing Then
            CrysViewerUlasma(tp).ReportSource = tp.CrystalReportAyarlari.RaporInstance
        End If
    End Sub
#End Region

End Class