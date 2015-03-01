Imports System.IO
Public Class FrmTaotaikhoan
    Dim Danhsach As New ArrayList()
    Private Sub FrmTaotaikhoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Đọc dữ liệu từ tập tin login.txt 
        Dim Duongdan As String
        Duongdan = Directory.GetCurrentDirectory() & "\" & "login.txt"

        'Đưa vào ArrayList Danhsach 
        Danhsach = Doc_du_lieu(Duongdan)
    End Sub

    Private Sub Taomoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Taomoi.Click
        Dim Taptin As String
        Taptin = Directory.GetCurrentDirectory() & "\" & "login.txt"
        If txttaikhoanmoi.Text = "" Or txtmatkhaumoi.Text = "" Or txtxacnhanmatkhaumoi.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thông báo")
        ElseIf txtmatkhaumoi.Text <> txtxacnhanmatkhaumoi.Text Then
            MsgBox("Vui lòng kiểm tra lại mật khẩu!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thông báo")
        Else
            Dim nd1 As New nguoidung
            nd1.taikhoan = txttaikhoanmoi.Text
            nd1.matkhau = txtmatkhaumoi.Text
            Danhsach.Add(nd1)
            MsgBox("Tạo tài khoản thành công!", MsgBoxStyle.OkOnly, "Thông báo")
            Luu_du_lieu(Taptin, Danhsach)
            txtmatkhaumoi.Text = ""
            txttaikhoanmoi.Text = ""
            txtxacnhanmatkhaumoi.Text = ""
            txttaikhoanmoi.Focus()
        End If
    End Sub

    Private Sub Thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thoat.Click
        Me.Close()
    End Sub
    Public Function Luu_du_lieu(ByVal Taptin As String, ByVal Danhsach As ArrayList) As Boolean

        Try
            'Khởi tạo biến lưu tập tin theo hình thức ghi đè với bảng mã UTF-8
            Dim F As New IO.StreamWriter(Taptin, False)

            'Khai báo biến lấy nội dung lưu vào tập tin
            Dim Chuoi As String = ""

            'Lần lượt duyệt qua các biến trong danh sách
            For i As Integer = 0 To Danhsach.Count - 1

                'Nếu kiểu của biến đúng với kiểu của lớp đối tượng khai báo mới sử dụng
                If TypeOf Danhsach(i) Is Nguoidung Then
                    Dim ND As Nguoidung = Danhsach(i)

                    'Nối nội dung các thông tin cách nhau với ký tự Tab
                    Chuoi &= ND.taikhoan & vbTab & ND.matkhau & vbTab & vbNewLine

                End If
            Next
            'Sau khi tập hợp đủ nội dung, lưu vào tập tin
            F.Write(Chuoi)

            'Đóng tập tin lại
            F.Close()
        Catch ex As Exception
        End Try
    End Function
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