<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtEklenenTitrantHacmi = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtToplamHacim = New System.Windows.Forms.TextBox
        Me.txtDerisim = New System.Windows.Forms.TextBox
        Me.txtPh = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnTamam = New System.Windows.Forms.Button
        Me.btnIptal = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtEklenenTitrantHacmi
        '
        Me.txtEklenenTitrantHacmi.Location = New System.Drawing.Point(152, 20)
        Me.txtEklenenTitrantHacmi.Name = "txtEklenenTitrantHacmi"
        Me.txtEklenenTitrantHacmi.Size = New System.Drawing.Size(118, 20)
        Me.txtEklenenTitrantHacmi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Eklenen Titrant Hacmi(ml) :"
        '
        'txtToplamHacim
        '
        Me.txtToplamHacim.Location = New System.Drawing.Point(152, 46)
        Me.txtToplamHacim.Name = "txtToplamHacim"
        Me.txtToplamHacim.Size = New System.Drawing.Size(118, 20)
        Me.txtToplamHacim.TabIndex = 2
        '
        'txtDerisim
        '
        Me.txtDerisim.Location = New System.Drawing.Point(152, 72)
        Me.txtDerisim.Name = "txtDerisim"
        Me.txtDerisim.Size = New System.Drawing.Size(118, 20)
        Me.txtDerisim.TabIndex = 3
        '
        'txtPh
        '
        Me.txtPh.Location = New System.Drawing.Point(152, 98)
        Me.txtPh.Name = "txtPh"
        Me.txtPh.Size = New System.Drawing.Size(118, 20)
        Me.txtPh.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Toplam Hacim(ml) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Deriþim(M) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "pH :"
        '
        'btnTamam
        '
        Me.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnTamam.Location = New System.Drawing.Point(152, 132)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(52, 23)
        Me.btnTamam.TabIndex = 8
        Me.btnTamam.Text = "Tamam"
        Me.btnTamam.UseVisualStyleBackColor = True
        '
        'btnIptal
        '
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.Location = New System.Drawing.Point(218, 132)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(52, 23)
        Me.btnIptal.TabIndex = 8
        Me.btnIptal.Text = "Ýptal"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AcceptButton = Me.btnTamam
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnIptal
        Me.ClientSize = New System.Drawing.Size(283, 167)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnTamam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPh)
        Me.Controls.Add(Me.txtDerisim)
        Me.Controls.Add(Me.txtToplamHacim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEklenenTitrantHacmi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.Text = "Deðer Düzenleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEklenenTitrantHacmi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtToplamHacim As System.Windows.Forms.TextBox
    Friend WithEvents txtDerisim As System.Windows.Forms.TextBox
    Friend WithEvents txtPh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTamam As System.Windows.Forms.Button
    Friend WithEvents btnIptal As System.Windows.Forms.Button
End Class
