<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdangnhap))
        Me.cbxquyen = New System.Windows.Forms.ComboBox()
        Me.lblquyen = New System.Windows.Forms.Label()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxquyen
        '
        Me.cbxquyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxquyen.FormattingEnabled = True
        Me.cbxquyen.Location = New System.Drawing.Point(312, 139)
        Me.cbxquyen.Name = "cbxquyen"
        Me.cbxquyen.Size = New System.Drawing.Size(220, 28)
        Me.cbxquyen.TabIndex = 23
        '
        'lblquyen
        '
        Me.lblquyen.AutoSize = True
        Me.lblquyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblquyen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblquyen.Location = New System.Drawing.Point(207, 145)
        Me.lblquyen.Name = "lblquyen"
        Me.lblquyen.Size = New System.Drawing.Size(97, 16)
        Me.lblquyen.TabIndex = 22
        Me.lblquyen.Text = "Quyền truy cập"
        '
        'btnthoat
        '
        Me.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnthoat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthoat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnthoat.Location = New System.Drawing.Point(429, 188)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(85, 35)
        Me.btnthoat.TabIndex = 21
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(29, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Chúc Bạn Ngày Mới Vui Vẻ"
        '
        'btndangnhap
        '
        Me.btndangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btndangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btndangnhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndangnhap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btndangnhap.Location = New System.Drawing.Point(294, 188)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(103, 35)
        Me.btndangnhap.TabIndex = 19
        Me.btndangnhap.Text = "Đăng Nhập"
        Me.btndangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtmatkhau.Location = New System.Drawing.Point(312, 102)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(220, 26)
        Me.txtmatkhau.TabIndex = 18
        '
        'txtdangnhap
        '
        Me.txtdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtdangnhap.Location = New System.Drawing.Point(312, 59)
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(220, 26)
        Me.txtdangnhap.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(207, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Mật khẩu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(207, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tên đăng nhập"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(240, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(8, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'frmdangnhap
        '
        Me.AcceptButton = Me.btndangnhap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 228)
        Me.Controls.Add(Me.cbxquyen)
        Me.Controls.Add(Me.lblquyen)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.txtdangnhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmdangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxquyen As System.Windows.Forms.ComboBox
    Friend WithEvents lblquyen As System.Windows.Forms.Label
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
