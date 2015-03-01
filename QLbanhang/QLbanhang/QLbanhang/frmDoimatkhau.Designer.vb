<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoimatkhau
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoimatkhau))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtNhaplaimatkhaumoi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatkhaumoi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatkhaucu = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtTaikhoan = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(293, 229)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 34
        Me.Cancel.Text = "&Thoát"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(189, 229)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 33
        Me.OK.Text = "&Đồng ý"
        '
        'txtNhaplaimatkhaumoi
        '
        Me.txtNhaplaimatkhaumoi.Location = New System.Drawing.Point(189, 198)
        Me.txtNhaplaimatkhaumoi.Name = "txtNhaplaimatkhaumoi"
        Me.txtNhaplaimatkhaumoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNhaplaimatkhaumoi.Size = New System.Drawing.Size(198, 20)
        Me.txtNhaplaimatkhaumoi.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nhập lại mật  khẩu mới"
        '
        'txtMatkhaumoi
        '
        Me.txtMatkhaumoi.Location = New System.Drawing.Point(190, 147)
        Me.txtMatkhaumoi.Name = "txtMatkhaumoi"
        Me.txtMatkhaumoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatkhaumoi.Size = New System.Drawing.Size(198, 20)
        Me.txtMatkhaumoi.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Mật khẩu mới"
        '
        'txtMatkhaucu
        '
        Me.txtMatkhaucu.Location = New System.Drawing.Point(190, 97)
        Me.txtMatkhaucu.Name = "txtMatkhaucu"
        Me.txtMatkhaucu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatkhaucu.Size = New System.Drawing.Size(197, 20)
        Me.txtMatkhaucu.TabIndex = 28
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(186, 75)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(100, 19)
        Me.PasswordLabel.TabIndex = 27
        Me.PasswordLabel.Text = "Mật khẩu cũ"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTaikhoan
        '
        Me.txtTaikhoan.Location = New System.Drawing.Point(189, 43)
        Me.txtTaikhoan.Name = "txtTaikhoan"
        Me.txtTaikhoan.Size = New System.Drawing.Size(198, 20)
        Me.txtTaikhoan.TabIndex = 26
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(186, 17)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(118, 23)
        Me.UsernameLabel.TabIndex = 25
        Me.UsernameLabel.Text = "Tài khoản"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 60)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(138, 148)
        Me.LogoPictureBox.TabIndex = 24
        Me.LogoPictureBox.TabStop = False
        '
        'frmDoimatkhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 266)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtNhaplaimatkhaumoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMatkhaumoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMatkhaucu)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.txtTaikhoan)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Name = "frmDoimatkhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đổi Mật Khẩu"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtNhaplaimatkhaumoi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMatkhaumoi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMatkhaucu As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtTaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
