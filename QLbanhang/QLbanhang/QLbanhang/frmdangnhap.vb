Imports System.IO
Public Class frmdangnhap
    Dim Danhsach As New ArrayList()
    Private Sub btndangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndangnhap.Click
        If txtdangnhap.Text = "" Then
            MsgBox(" Username không được rỗng", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thông báo")

        ElseIf txtmatkhau.Text = "" Then
            MsgBox(" Password không được rỗng", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thông báo")
        Else
            Dim kq As Boolean = False

            'Kiem tra tung phan tu trong Arraylist Danhsach
            For i As Integer = 0 To Danhsach.Count - 1
                'Kiem tra tai khoan va mat khau
                If txtdangnhap.Text.Trim() = Danhsach(i).taikhoan And txtmatkhau.Text.Trim() = Danhsach(i).matkhau Then
                    kq = True
                    frmchinh.Show()
                    If Danhsach(i).taikhoan <> "admin" Or Danhsach(i).taikhoan <> "admin" Then
                        frmchinh.mntaotaikhoanmoi.Visible = False
                        frmchinh.mnxoataikhoan.Visible = False
                    Else
                        frmchinh.mndangnhap.Visible = False
                    End If
                    Me.Close()
                    Exit For
                End If
                frmchinh.mndangnhap.Visible = False
            Next

            If kq = False Then
                MsgBox("Đăng nhập không thành công" & vbNewLine & "Tài đăng nhập hoặc Mật khẩu không đúng! ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cảnh báo")

            End If
        End If
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Application.Exit()
    End Sub

    Private Sub DangNhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Duongdan As String
        Duongdan = Directory.GetCurrentDirectory() & "\" & "login.txt"
        'Đưa vào ArrayList Danhsach 
        Danhsach = Doc_du_lieu(Duongdan)
    End Sub
    Public Function Doc_du_lieu(ByVal Taptin As String) As ArrayList

        'Khai báo biến Ketqua kiểu ArrayList
        Dim Ketqua As New ArrayList

        'Kiểm tra tập tin có tồn tại không?
        If IO.File.Exists(Taptin) Then

            'Khởi tạo biến mở tập tin và đọc tập tin
            Dim F As New FileIO.TextFieldParser(Taptin)

            'Khai báo các thuộc tính phân cách nhau bằng ký tự ngăn cách
            F.TextFieldType = FileIO.FieldType.Delimited

            'Ký tự ngăn cách được sử dụng là ký tự Tab
            F.SetDelimiters(New String() {vbTab})

            'Đọc tập tin từ đầu đến cuối
            Do While Not F.EndOfData

                'Lấy các thuộc tính của lớp ra mảng
                Dim Thongtin() As String = F.ReadFields()

                'Khởi tạo một biến kiểu lớp đối tượng đã khai báo
                Dim ND As New Nguoidung

                'Lần lượt gán giá trị cho các thành phần
                ND.taikhoan = Thongtin(0)
                ND.matkhau = Thongtin(1)

                'Đưa các thuọc tính vào ArrayList
                Ketqua.Add(ND)
            Loop
            'Sau khi thao tác xong trên tập tin phải đóng tập tin lại
            F.Close()

        End If
        'Tra ve ArrayList
        Return Ketqua

    End Function
End Class
