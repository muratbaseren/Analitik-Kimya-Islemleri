<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.cmnuTabControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.YeniSekmeAcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SekmeyiKaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SekmeyiKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.TumSekmeleriKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.btnSaveAll = New System.Windows.Forms.ToolStripButton
        Me.btnSekmeKapat = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.cmnuTabControl.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmnuTabControl
        '
        Me.cmnuTabControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniSekmeAcToolStripMenuItem, Me.SekmeyiKaydetToolStripMenuItem, Me.ToolStripMenuItem1, Me.SekmeyiKapatToolStripMenuItem, Me.ToolStripMenuItem2, Me.TumSekmeleriKapatToolStripMenuItem})
        Me.cmnuTabControl.Name = "cmnuTabControl"
        Me.cmnuTabControl.Size = New System.Drawing.Size(185, 104)
        '
        'YeniSekmeAcToolStripMenuItem
        '
        Me.YeniSekmeAcToolStripMenuItem.Image = CType(resources.GetObject("YeniSekmeAcToolStripMenuItem.Image"), System.Drawing.Image)
        Me.YeniSekmeAcToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.YeniSekmeAcToolStripMenuItem.Name = "YeniSekmeAcToolStripMenuItem"
        Me.YeniSekmeAcToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.YeniSekmeAcToolStripMenuItem.Text = "Yeni Sekme Aç"
        '
        'SekmeyiKaydetToolStripMenuItem
        '
        Me.SekmeyiKaydetToolStripMenuItem.Image = CType(resources.GetObject("SekmeyiKaydetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SekmeyiKaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.SekmeyiKaydetToolStripMenuItem.Name = "SekmeyiKaydetToolStripMenuItem"
        Me.SekmeyiKaydetToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SekmeyiKaydetToolStripMenuItem.Text = "Sekmeyi Kaydet"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 6)
        '
        'SekmeyiKapatToolStripMenuItem
        '
        Me.SekmeyiKapatToolStripMenuItem.Image = CType(resources.GetObject("SekmeyiKapatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SekmeyiKapatToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.SekmeyiKapatToolStripMenuItem.Name = "SekmeyiKapatToolStripMenuItem"
        Me.SekmeyiKapatToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SekmeyiKapatToolStripMenuItem.Text = "Sekmeyi Kapat"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 6)
        '
        'TumSekmeleriKapatToolStripMenuItem
        '
        Me.TumSekmeleriKapatToolStripMenuItem.Image = CType(resources.GetObject("TumSekmeleriKapatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TumSekmeleriKapatToolStripMenuItem.Name = "TumSekmeleriKapatToolStripMenuItem"
        Me.TumSekmeleriKapatToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.TumSekmeleriKapatToolStripMenuItem.Text = "Tüm Sekmeleri Kapat"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.btnSaveAll, Me.btnSekmeKapat, Me.ToolStripSeparator3, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(977, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "Yeni Titrasyon Kayýt Sekmesi Oluþtur"
        Me.NewToolStripButton.ToolTipText = "Yeni Titrasyon Kayýt Sekmesi Oluþtur"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "Titrasyon Kayýt Dosyasý Aç"
        Me.OpenToolStripButton.ToolTipText = "Titrasyon Kayýt Dosyasý Aç"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Seçili Sekmeyi Kaydet"
        Me.SaveToolStripButton.ToolTipText = "Seçili Sekmeyi Kaydet"
        '
        'btnSaveAll
        '
        Me.btnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveAll.Image = CType(resources.GetObject("btnSaveAll.Image"), System.Drawing.Image)
        Me.btnSaveAll.ImageTransparentColor = System.Drawing.Color.White
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveAll.Text = "Tüm Sekmeleri Kaydet"
        '
        'btnSekmeKapat
        '
        Me.btnSekmeKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSekmeKapat.Image = CType(resources.GetObject("btnSekmeKapat.Image"), System.Drawing.Image)
        Me.btnSekmeKapat.ImageTransparentColor = System.Drawing.Color.White
        Me.btnSekmeKapat.Name = "btnSekmeKapat"
        Me.btnSekmeKapat.Size = New System.Drawing.Size(23, 22)
        Me.btnSekmeKapat.Text = "Sekme Kapat"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "Kes"
        Me.CutToolStripButton.ToolTipText = "Kes"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "Kopyala"
        Me.CopyToolStripButton.ToolTipText = "Kopyala"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "Yapýþtýr"
        Me.PasteToolStripButton.ToolTipText = "Yapýþtýr"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Hakkýnda"
        Me.HelpToolStripButton.ToolTipText = "Hakkýnda"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(977, 634)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.cmnuTabControl
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(961, 618)
        Me.TabControl1.TabIndex = 3
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 659)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form4"
        Me.Text = "Titrasyon Hesaplamalarý"
        Me.cmnuTabControl.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnSaveAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSekmeKapat As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmnuTabControl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents YeniSekmeAcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SekmeyiKaydetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SekmeyiKapatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TumSekmeleriKapatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
