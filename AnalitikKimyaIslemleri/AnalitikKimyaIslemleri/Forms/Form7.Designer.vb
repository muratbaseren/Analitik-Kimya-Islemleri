<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstAdresler = New System.Windows.Forms.ListView
        Me.clmSil = New System.Windows.Forms.ColumnHeader
        Me.clmBaslik = New System.Windows.Forms.ColumnHeader
        Me.clmAdres = New System.Windows.Forms.ColumnHeader
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssAdresSayisi = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBaslik = New System.Windows.Forms.TextBox
        Me.txtWebAdresi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSil = New System.Windows.Forms.Button
        Me.btnEkle = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnTamam = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstAdresler)
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(276, 180)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Web Adresleri"
        '
        'lstAdresler
        '
        Me.lstAdresler.CheckBoxes = True
        Me.lstAdresler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmSil, Me.clmBaslik, Me.clmAdres})
        Me.lstAdresler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAdresler.FullRowSelect = True
        Me.lstAdresler.Location = New System.Drawing.Point(5, 18)
        Me.lstAdresler.Name = "lstAdresler"
        Me.lstAdresler.Size = New System.Drawing.Size(266, 135)
        Me.lstAdresler.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstAdresler.TabIndex = 1
        Me.lstAdresler.UseCompatibleStateImageBehavior = False
        Me.lstAdresler.View = System.Windows.Forms.View.Details
        '
        'clmSil
        '
        Me.clmSil.Text = "Sil"
        Me.clmSil.Width = 40
        '
        'clmBaslik
        '
        Me.clmBaslik.Text = "Adres Baþlýðý"
        Me.clmBaslik.Width = 100
        '
        'clmAdres
        '
        Me.clmAdres.Text = "Web Adresi"
        Me.clmAdres.Width = 120
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssAdresSayisi})
        Me.StatusStrip1.Location = New System.Drawing.Point(5, 153)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(266, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssAdresSayisi
        '
        Me.tssAdresSayisi.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssAdresSayisi.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tssAdresSayisi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tssAdresSayisi.Name = "tssAdresSayisi"
        Me.tssAdresSayisi.Size = New System.Drawing.Size(4, 17)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baþlýk :"
        '
        'txtBaslik
        '
        Me.txtBaslik.Location = New System.Drawing.Point(81, 194)
        Me.txtBaslik.Name = "txtBaslik"
        Me.txtBaslik.Size = New System.Drawing.Size(198, 20)
        Me.txtBaslik.TabIndex = 3
        '
        'txtWebAdresi
        '
        Me.txtWebAdresi.Location = New System.Drawing.Point(81, 220)
        Me.txtWebAdresi.Name = "txtWebAdresi"
        Me.txtWebAdresi.Size = New System.Drawing.Size(198, 20)
        Me.txtWebAdresi.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Web Adresi :"
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(204, 246)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(75, 23)
        Me.btnSil.TabIndex = 7
        Me.btnSil.Text = "&Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(123, 246)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 23)
        Me.btnEkle.TabIndex = 6
        Me.btnEkle.Text = "Ekl&e"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 11)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(204, 294)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(75, 23)
        Me.btnTamam.TabIndex = 10
        Me.btnTamam.Text = "Tamam"
        Me.btnTamam.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AcceptButton = Me.btnTamam
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 325)
        Me.Controls.Add(Me.btnTamam)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.txtWebAdresi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBaslik)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Web Adresleri(Sýk Kullanýlanlar)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstAdresler As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBaslik As System.Windows.Forms.TextBox
    Friend WithEvents txtWebAdresi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSil As System.Windows.Forms.Button
    Friend WithEvents btnEkle As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTamam As System.Windows.Forms.Button
    Friend WithEvents tssAdresSayisi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents clmSil As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmBaslik As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAdres As System.Windows.Forms.ColumnHeader
End Class
