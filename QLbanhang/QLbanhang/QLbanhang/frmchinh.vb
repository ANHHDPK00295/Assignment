Imports System.Windows.Forms
Imports System.IO
Public Class frmchinh
    Private Sub mndangxuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mndangxuat.Click
        frmdangnhap.ShowDialog()
    End Sub

    Private Sub mndoimatkhau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mndoimatkhau.Click
        Dim Matkhau As New frmDoimatkhau()
        Matkhau.MdiParent = Me
        Matkhau.Show()
    End Sub
    Private Sub mntaotaikhoanmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mntaotaikhoanmoi.Click
        Dim Taikhoan As New FrmTaotaikhoan()
        Taikhoan.MdiParent = Me
        Taikhoan.Show()
    End Sub

    Private Sub mnxoataikhoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnxoataikhoan.Click
        Dim XoaTaikhoan As New FrmXoataikhoan()
        XoaTaikhoan.MdiParent = Me
        XoaTaikhoan.Show()
    End Sub

    Private Sub mnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnthoat.Click
        Me.Close()
    End Sub

    Private Sub mncongcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mncongcu.Click
        Me.Thanhcongcu.Visible = Me.mncongcu.Checked
    End Sub

    Private Sub mnstrangthai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mntrangthai.Click
        Me.Thanhtrangthai.Visible = Me.mntrangthai.checked
    End Sub

    Private Sub mnhuongdan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnhuongdan.Click
        Dim c1, c2, taptin As String
        c1 = """"
        c2 = """"""
        taptin = Directory.GetCurrentDirectory() & "\" & "huongdan.docx"
        taptin = c1 & taptin & c2 & """"
        Shell("C:\Program Files\Microsoft Office\Office12\WINWORD.EXE " & taptin, AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnbanquyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnbanquyen.Click
        Dim Banquyen As New frmbanquyen()
        Banquyen.MdiParent = Me
        Banquyen.Show()
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        Dim c1, c2, taptin As String
        c1 = """"
        c2 = """"""
        taptin = Directory.GetCurrentDirectory() & "\" & "huongdan.docx"
        taptin = c1 & taptin & c2 & """"
        Shell("C:\Program Files\Microsoft Office\Office12\WINWORD.EXE " & taptin, AppWinStyle.NormalFocus)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Matkhau As New frmDoimatkhau()
        Matkhau.MdiParent = Me
        Matkhau.Show()
    End Sub

    Private Sub Tooltaotaikhoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Taikhoan As New FrmTaotaikhoan()
        Taikhoan.MdiParent = Me
        Taikhoan.Show()
    End Sub

    Private Sub Toolxoataikhoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim XoaTaikhoan As New FrmXoataikhoan()
        XoaTaikhoan.MdiParent = Me
        XoaTaikhoan.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim X, Y As String
        X = Microsoft.VisualBasic.Left(Me.Text, 1)
        Y = Microsoft.VisualBasic.Right(Me.Text, Len(Me.Text) - 1)
        Me.Text = Y + X
    End Sub

    Private Sub frmchinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblthu.Text = tinhthu(Now.DayOfWeek.ToString) & ". Ngày " & Date.Now.Day & " tháng " & Date.Now.Month & " năm " & Date.Now.Year
        lblThoigian.Text = "Bây giờ là: " & Date.Now.Hour.ToString & " giờ " & Date.Now.Minute.ToString & " phút "
    End Sub
    Private Function tinhthu(ByVal ch As String) As String
        Dim kq As String

        If ch = "Monday" Then
            kq = "Thứ hai"
        ElseIf ch = "Tuesday" Then
            kq = "Thứ ba"
        ElseIf ch = "Wednesday" Then
            kq = "Thứ tư"
        ElseIf ch = "Thursday" Then
            kq = "Thứ năm"
        ElseIf ch = "Friday" Then
            kq = "Thứ sáu"
        ElseIf ch = "Saturday" Then
            kq = "Thứ bảy"
        Else
            kq = "Chủ nhật"
        End If

        Return kq
    End Function

    Private Sub mnchucvu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnhanghoa.Click
        Dim frmcv As New frmhanghoa
        frmcv.MdiParent = Me
        frmcv.Show()
    End Sub

    Private Sub mnnhanvien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnhoadon.Click
        Dim frmcv As New frmhoadon
        frmcv.MdiParent = Me
        frmcv.Show()
    End Sub

    Private Sub mnphong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnchitiethoadon.Click
        Dim frmcv As New frmchitiethoadon
        frmcv.MdiParent = Me
        frmcv.Show()
    End Sub

    Private Sub frmchinh_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Bạn Chắc Chắn Muốn Thoát Chương Trình ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Thông Báo") = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
        End
    End Sub


End Class