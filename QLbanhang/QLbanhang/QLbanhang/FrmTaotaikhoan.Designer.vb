<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaotaikhoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTaotaikhoan))
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Taomoi = New System.Windows.Forms.Button()
        Me.txtxacnhanmatkhaumoi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmatkhaumoi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttaikhoanmoi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(282, 196)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(75, 25)
        Me.Thoat.TabIndex = 27
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Taomoi
        '
        Me.Taomoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Taomoi.Location = New System.Drawing.Point(179, 196)
        Me.Taomoi.Name = "Taomoi"
        Me.Taomoi.Size = New System.Drawing.Size(75, 25)
        Me.Taomoi.TabIndex = 26
        Me.Taomoi.Text = "Tạo mới"
        Me.Taomoi.UseVisualStyleBackColor = True
        '
        'txtxacnhanmatkhaumoi
        '
        Me.txtxacnhanmatkhaumoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxacnhanmatkhaumoi.Location = New System.Drawing.Point(179, 154)
        Me.txtxacnhanmatkhaumoi.Name = "txtxacnhanmatkhaumoi"
        Me.txtxacnhanmatkhaumoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtxacnhanmatkhaumoi.Size = New System.Drawing.Size(178, 26)
        Me.txtxacnhanmatkhaumoi.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Xác nhận lại mật khẩu: "
        '
        'txtmatkhaumoi
        '
        Me.txtmatkhaumoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatkhaumoi.Location = New System.Drawing.Point(179, 90)
        Me.txtmatkhaumoi.Name = "txtmatkhaumoi"
        Me.txtmatkhaumoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhaumoi.Size = New System.Drawing.Size(178, 26)
        Me.txtmatkhaumoi.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nhập mật khẩu: "
        '
        'txttaikhoanmoi
        '
        Me.txttaikhoanmoi.Location = New System.Drawing.Point(179, 33)
        Me.txttaikhoanmoi.Name = "txttaikhoanmoi"
        Me.txttaikhoanmoi.Size = New System.Drawing.Size(178, 20)
        Me.txttaikhoanmoi.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nhập tài khoản: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 128)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmTaotaikhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 228)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Taomoi)
        Me.Controls.Add(Me.txtxacnhanmatkhaumoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmatkhaumoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttaikhoanmoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmTaotaikhoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tạo Tài Khoản"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Taomoi As System.Windows.Forms.Button
    Friend WithEvents txtxacnhanmatkhaumoi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmatkhaumoi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttaikhoanmoi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
