<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.grpTitrant = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTitrantHacmi = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTitrantDerisimi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTitrantTuru = New System.Windows.Forms.ComboBox
        Me.txtTitrantIsmi = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpTitreEdilen = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTitreEdilenHacmi = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTitreEdilenDerisimi = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbTitreEdilenTuru = New System.Windows.Forms.ComboBox
        Me.txtTitreEdilenIsmi = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.grpAyarlar = New System.Windows.Forms.GroupBox
        Me.txtRaporBasligi = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDipNot = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtHacimArtis = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTesirDegeri = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtImza = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lsvDegerler = New System.Windows.Forms.ListView
        Me.clmTitrantHacmi = New System.Windows.Forms.ColumnHeader
        Me.clmTitreHacmi = New System.Windows.Forms.ColumnHeader
        Me.clmAsitDersimi = New System.Windows.Forms.ColumnHeader
        Me.clmPh = New System.Windows.Forms.ColumnHeader
        Me.cmnuLstDegerler = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuSeciliDuzenle = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuSeciliSil = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuTumunuSil = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnRaporYarat = New System.Windows.Forms.ToolStripMenuItem
        Me.btnHesapla = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnRaporYarat = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDuzenle = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.grpTitrant.SuspendLayout()
        Me.grpTitreEdilen.SuspendLayout()
        Me.grpAyarlar.SuspendLayout()
        Me.cmnuLstDegerler.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTitrant
        '
        Me.grpTitrant.Controls.Add(Me.Label4)
        Me.grpTitrant.Controls.Add(Me.txtTitrantHacmi)
        Me.grpTitrant.Controls.Add(Me.Label3)
        Me.grpTitrant.Controls.Add(Me.txtTitrantDerisimi)
        Me.grpTitrant.Controls.Add(Me.Label2)
        Me.grpTitrant.Controls.Add(Me.cmbTitrantTuru)
        Me.grpTitrant.Controls.Add(Me.txtTitrantIsmi)
        Me.grpTitrant.Controls.Add(Me.Label1)
        Me.grpTitrant.Location = New System.Drawing.Point(3, 3)
        Me.grpTitrant.Name = "grpTitrant"
        Me.grpTitrant.Size = New System.Drawing.Size(464, 66)
        Me.grpTitrant.TabIndex = 0
        Me.grpTitrant.TabStop = False
        Me.grpTitrant.Text = "Titrant Bilgileri"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Türü"
        '
        'txtTitrantHacmi
        '
        Me.txtTitrantHacmi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTitrantHacmi.Location = New System.Drawing.Point(258, 35)
        Me.txtTitrantHacmi.Name = "txtTitrantHacmi"
        Me.txtTitrantHacmi.Size = New System.Drawing.Size(100, 21)
        Me.txtTitrantHacmi.TabIndex = 5
        Me.txtTitrantHacmi.Tag = "sayisal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hacmi (ml)"
        '
        'txtTitrantDerisimi
        '
        Me.txtTitrantDerisimi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTitrantDerisimi.Location = New System.Drawing.Point(152, 35)
        Me.txtTitrantDerisimi.Name = "txtTitrantDerisimi"
        Me.txtTitrantDerisimi.Size = New System.Drawing.Size(100, 21)
        Me.txtTitrantDerisimi.TabIndex = 3
        Me.txtTitrantDerisimi.Tag = "sayisal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Deriþimi (M)"
        '
        'cmbTitrantTuru
        '
        Me.cmbTitrantTuru.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbTitrantTuru.FormattingEnabled = True
        Me.cmbTitrantTuru.Items.AddRange(New Object() {"Asit", "Baz"})
        Me.cmbTitrantTuru.Location = New System.Drawing.Point(364, 35)
        Me.cmbTitrantTuru.Name = "cmbTitrantTuru"
        Me.cmbTitrantTuru.Size = New System.Drawing.Size(94, 23)
        Me.cmbTitrantTuru.TabIndex = 1
        Me.cmbTitrantTuru.Text = "Seçiniz.."
        '
        'txtTitrantIsmi
        '
        Me.txtTitrantIsmi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTitrantIsmi.Location = New System.Drawing.Point(46, 35)
        Me.txtTitrantIsmi.Name = "txtTitrantIsmi"
        Me.txtTitrantIsmi.Size = New System.Drawing.Size(100, 21)
        Me.txtTitrantIsmi.TabIndex = 1
        Me.txtTitrantIsmi.Tag = "metinsel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ismi"
        '
        'grpTitreEdilen
        '
        Me.grpTitreEdilen.Controls.Add(Me.Label5)
        Me.grpTitreEdilen.Controls.Add(Me.txtTitreEdilenHacmi)
        Me.grpTitreEdilen.Controls.Add(Me.Label6)
        Me.grpTitreEdilen.Controls.Add(Me.txtTitreEdilenDerisimi)
        Me.grpTitreEdilen.Controls.Add(Me.Label7)
        Me.grpTitreEdilen.Controls.Add(Me.cmbTitreEdilenTuru)
        Me.grpTitreEdilen.Controls.Add(Me.txtTitreEdilenIsmi)
        Me.grpTitreEdilen.Controls.Add(Me.Label8)
        Me.grpTitreEdilen.Location = New System.Drawing.Point(3, 75)
        Me.grpTitreEdilen.Name = "grpTitreEdilen"
        Me.grpTitreEdilen.Size = New System.Drawing.Size(464, 66)
        Me.grpTitreEdilen.TabIndex = 3
        Me.grpTitreEdilen.TabStop = False
        Me.grpTitreEdilen.Text = "Titre Edilen Bilgileri"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(364, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Türü"
        '
        'txtTitreEdilenHacmi
        '
        Me.txtTitreEdilenHacmi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTitreEdilenHacmi.Location = New System.Drawing.Point(258, 35)
        Me.txtTitreEdilenHacmi.Name = "txtTitreEdilenHacmi"
        Me.txtTitreEdilenHacmi.Size = New System.Drawing.Size(100, 21)
        Me.txtTitreEdilenHacmi.TabIndex = 5
        Me.txtTitreEdilenHacmi.Tag = "sayisal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Hacmi (ml)"
        '
        'txtTitreEdilenDerisimi
        '
        Me.txtTitreEdilenDerisimi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTitreEdilenDerisimi.Location = New System.Drawing.Point(152, 35)
        Me.txtTitreEdilenDerisimi.Name = "txtTitreEdilenDerisimi"
        Me.txtTitreEdilenDerisimi.Size = New System.Drawing.Size(100, 21)
        Me.txtTitreEdilenDerisimi.TabIndex = 3
        Me.txtTitreEdilenDerisimi.Tag = "sayisal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Deriþimi (M)"
        '
        'cmbTitreEdilenTuru
        '
        Me.cmbTitreEdilenTuru.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbTitreEdilenTuru.FormattingEnabled = True
        Me.cmbTitreEdilenTuru.Items.AddRange(New Object() {"Asit", "Baz"})
        Me.cmbTitreEdilenTuru.Location = New System.Drawing.Point(364, 35)
        Me.cmbTitreEdilenTuru.Name = "cmbTitreEdilenTuru"
        Me.cmbTitreEdilenTuru.Size = New System.Drawing.Size(94, 23)
        Me.cmbTitreEdilenTuru.TabIndex = 1
        Me.cmbTitreEdilenTuru.Text = "Seçiniz.."
        '
        'txtTitreEdilenIsmi
        '
        Me.txtTitreEdilenIsmi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTitreEdilenIsmi.Location = New System.Drawing.Point(46, 35)
        Me.txtTitreEdilenIsmi.Name = "txtTitreEdilenIsmi"
        Me.txtTitreEdilenIsmi.Size = New System.Drawing.Size(100, 21)
        Me.txtTitreEdilenIsmi.TabIndex = 1
        Me.txtTitreEdilenIsmi.Tag = "metinsel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ismi"
        '
        'grpAyarlar
        '
        Me.grpAyarlar.Controls.Add(Me.txtRaporBasligi)
        Me.grpAyarlar.Controls.Add(Me.Label13)
        Me.grpAyarlar.Controls.Add(Me.txtDipNot)
        Me.grpAyarlar.Controls.Add(Me.Label9)
        Me.grpAyarlar.Controls.Add(Me.txtHacimArtis)
        Me.grpAyarlar.Controls.Add(Me.Label11)
        Me.grpAyarlar.Controls.Add(Me.txtTesirDegeri)
        Me.grpAyarlar.Controls.Add(Me.Label12)
        Me.grpAyarlar.Location = New System.Drawing.Point(3, 147)
        Me.grpAyarlar.Name = "grpAyarlar"
        Me.grpAyarlar.Size = New System.Drawing.Size(464, 102)
        Me.grpAyarlar.TabIndex = 4
        Me.grpAyarlar.TabStop = False
        Me.grpAyarlar.Text = "Ayarlar"
        '
        'txtRaporBasligi
        '
        Me.txtRaporBasligi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRaporBasligi.Location = New System.Drawing.Point(152, 70)
        Me.txtRaporBasligi.MaxLength = 60
        Me.txtRaporBasligi.Name = "txtRaporBasligi"
        Me.txtRaporBasligi.Size = New System.Drawing.Size(306, 21)
        Me.txtRaporBasligi.TabIndex = 8
        Me.txtRaporBasligi.Tag = "metinsel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(71, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Rapor Baþlýðý :"
        '
        'txtDipNot
        '
        Me.txtDipNot.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtDipNot.Location = New System.Drawing.Point(308, 15)
        Me.txtDipNot.MaxLength = 190
        Me.txtDipNot.Multiline = True
        Me.txtDipNot.Name = "txtDipNot"
        Me.txtDipNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDipNot.Size = New System.Drawing.Size(150, 41)
        Me.txtDipNot.TabIndex = 7
        Me.txtDipNot.Tag = "metinsel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(258, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Dip Not:"
        '
        'txtHacimArtis
        '
        Me.txtHacimArtis.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtHacimArtis.Location = New System.Drawing.Point(152, 35)
        Me.txtHacimArtis.Name = "txtHacimArtis"
        Me.txtHacimArtis.Size = New System.Drawing.Size(100, 21)
        Me.txtHacimArtis.TabIndex = 3
        Me.txtHacimArtis.Tag = "sayisal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(152, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Hacim Artýþ Deðeri"
        '
        'txtTesirDegeri
        '
        Me.txtTesirDegeri.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTesirDegeri.Location = New System.Drawing.Point(46, 35)
        Me.txtTesirDegeri.Name = "txtTesirDegeri"
        Me.txtTesirDegeri.Size = New System.Drawing.Size(100, 21)
        Me.txtTesirDegeri.TabIndex = 1
        Me.txtTesirDegeri.Tag = "sayisal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Tesir Deðeri"
        '
        'txtImza
        '
        Me.txtImza.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtImza.Location = New System.Drawing.Point(286, 463)
        Me.txtImza.MaxLength = 60
        Me.txtImza.Name = "txtImza"
        Me.txtImza.Size = New System.Drawing.Size(181, 21)
        Me.txtImza.TabIndex = 5
        Me.txtImza.Tag = "metinsel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(245, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Imza :"
        '
        'lsvDegerler
        '
        Me.lsvDegerler.CheckBoxes = True
        Me.lsvDegerler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmTitrantHacmi, Me.clmTitreHacmi, Me.clmAsitDersimi, Me.clmPh})
        Me.lsvDegerler.ContextMenuStrip = Me.cmnuLstDegerler
        Me.lsvDegerler.FullRowSelect = True
        Me.lsvDegerler.Location = New System.Drawing.Point(3, 255)
        Me.lsvDegerler.Name = "lsvDegerler"
        Me.lsvDegerler.Size = New System.Drawing.Size(464, 202)
        Me.lsvDegerler.TabIndex = 5
        Me.lsvDegerler.UseCompatibleStateImageBehavior = False
        Me.lsvDegerler.View = System.Windows.Forms.View.Details
        '
        'clmTitrantHacmi
        '
        Me.clmTitrantHacmi.Text = "Eklenen Titrant Hacmi(ml)"
        Me.clmTitrantHacmi.Width = 100
        '
        'clmTitreHacmi
        '
        Me.clmTitreHacmi.Text = "Toplam Hacim(ml)"
        Me.clmTitreHacmi.Width = 120
        '
        'clmAsitDersimi
        '
        Me.clmAsitDersimi.Text = "Deriþimi(M)"
        Me.clmAsitDersimi.Width = 100
        '
        'clmPh
        '
        Me.clmPh.Text = "pH"
        Me.clmPh.Width = 100
        '
        'cmnuLstDegerler
        '
        Me.cmnuLstDegerler.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuSeciliDuzenle, Me.cmnuSeciliSil, Me.ToolStripMenuItem1, Me.cmnuTumunuSil, Me.ToolStripMenuItem2, Me.cmnRaporYarat})
        Me.cmnuLstDegerler.Name = "cmnuLstDegerler"
        Me.cmnuLstDegerler.Size = New System.Drawing.Size(150, 104)
        '
        'cmnuSeciliDuzenle
        '
        Me.cmnuSeciliDuzenle.Name = "cmnuSeciliDuzenle"
        Me.cmnuSeciliDuzenle.Size = New System.Drawing.Size(149, 22)
        Me.cmnuSeciliDuzenle.Text = "Seçili Düzenle"
        '
        'cmnuSeciliSil
        '
        Me.cmnuSeciliSil.Name = "cmnuSeciliSil"
        Me.cmnuSeciliSil.Size = New System.Drawing.Size(149, 22)
        Me.cmnuSeciliSil.Text = "Ýþaretlileri Sil"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 6)
        '
        'cmnuTumunuSil
        '
        Me.cmnuTumunuSil.Name = "cmnuTumunuSil"
        Me.cmnuTumunuSil.Size = New System.Drawing.Size(149, 22)
        Me.cmnuTumunuSil.Text = "Tümünü Sil"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(146, 6)
        '
        'cmnRaporYarat
        '
        Me.cmnRaporYarat.Name = "cmnRaporYarat"
        Me.cmnRaporYarat.Size = New System.Drawing.Size(149, 22)
        Me.cmnRaporYarat.Text = "Rapor Yarat"
        '
        'btnHesapla
        '
        Me.btnHesapla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnHesapla.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHesapla.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnHesapla.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnHesapla.Location = New System.Drawing.Point(85, 0)
        Me.btnHesapla.Name = "btnHesapla"
        Me.btnHesapla.Size = New System.Drawing.Size(75, 25)
        Me.btnHesapla.TabIndex = 7
        Me.btnHesapla.Text = "Hesapla"
        Me.btnHesapla.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.btnHesapla)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 529)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1397, 25)
        Me.Panel1.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnRaporYarat)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(170, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(156, 25)
        Me.Panel5.TabIndex = 10
        '
        'btnRaporYarat
        '
        Me.btnRaporYarat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnRaporYarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRaporYarat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRaporYarat.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRaporYarat.Location = New System.Drawing.Point(0, 0)
        Me.btnRaporYarat.Name = "btnRaporYarat"
        Me.btnRaporYarat.Size = New System.Drawing.Size(156, 25)
        Me.btnRaporYarat.TabIndex = 3
        Me.btnRaporYarat.Text = "Rapor Oluþtur ve Göster"
        Me.btnRaporYarat.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(160, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 25)
        Me.Panel6.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(75, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 25)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDuzenle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 25)
        Me.Panel2.TabIndex = 3
        '
        'btnDuzenle
        '
        Me.btnDuzenle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDuzenle.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDuzenle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDuzenle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDuzenle.Location = New System.Drawing.Point(0, 0)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.Size = New System.Drawing.Size(75, 25)
        Me.btnDuzenle.TabIndex = 6
        Me.btnDuzenle.Text = "Düzenle"
        Me.btnDuzenle.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(473, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(924, 481)
        Me.CrystalReportViewer1.TabIndex = 9
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'myPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lsvDegerler)
        Me.Controls.Add(Me.txtImza)
        Me.Controls.Add(Me.grpAyarlar)
        Me.Controls.Add(Me.grpTitreEdilen)
        Me.Controls.Add(Me.grpTitrant)
        Me.Name = "myPanel"
        Me.Size = New System.Drawing.Size(988, 554)
        Me.grpTitrant.ResumeLayout(False)
        Me.grpTitrant.PerformLayout()
        Me.grpTitreEdilen.ResumeLayout(False)
        Me.grpTitreEdilen.PerformLayout()
        Me.grpAyarlar.ResumeLayout(False)
        Me.grpAyarlar.PerformLayout()
        Me.cmnuLstDegerler.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTitrant As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTitrantTuru As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitrantIsmi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitrantHacmi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitrantDerisimi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpTitreEdilen As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitreEdilenHacmi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTitreEdilenDerisimi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTitreEdilenTuru As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitreEdilenIsmi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grpAyarlar As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImza As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHacimArtis As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTesirDegeri As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lsvDegerler As System.Windows.Forms.ListView
    Friend WithEvents txtRaporBasligi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDipNot As System.Windows.Forms.TextBox
    Friend WithEvents clmTitrantHacmi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmTitreHacmi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAsitDersimi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPh As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnuLstDegerler As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuSeciliDuzenle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuSeciliSil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuTumunuSil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnRaporYarat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHesapla As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnRaporYarat As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDuzenle As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
