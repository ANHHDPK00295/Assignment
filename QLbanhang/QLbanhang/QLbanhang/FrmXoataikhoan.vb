Imports System.IO
Public Class FrmXoataikhoan
    Dim Danhsach As New ArrayList()
    Dim kt As Boolean = False
    Private Sub FrmXoataikhoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Duongdan As String
        Duongdan = Directory.GetCurrentDirectory() & "\" & "login.txt"
        'Đưa vào ArrayList Danhsach 
        Danhsach = Doc_du_lieu(Duongdan)

        'Xuất danh sách người dùng ra ListView
        Xuat_danh_sach_nguoi_dung_ra_ListView()
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
    'Thêm thành viên vào ListView
    Private Sub Them_nguoi_dung_vao_ListView(ByVal ND As nguoidung)
        Listdanhsach.Items.Add(New ListViewItem(New String() {ND.taikhoan, ND.matkhau}))
    End Sub
    'Xuất danh sách người dùng ra ListView
    Private Sub Xuat_danh_sach_nguoi_dung_ra_ListView()

        'Trước khi xuất thì xoá trắng ListView
        Listdanhsach.Items.Clear()

        'Lấy toàn bộ dữ liệu trong ArrayList Danhsach đổ vào ListView
        For I As Integer = 0 To Danhsach.Count - 1

            'Gọi phương thức thêm thành viên vào ListView
            Them_nguoi_dung_vao_ListView(Danhsach(I))
        Next
    End Sub
    'Sự kiện click chuột vào listview
    Private Sub Listdanhsach_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Listdanhsach.MouseClick
        kt = True
    End Sub

    Private Sub Listdanhsach_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listdanhsach.SelectedIndexChanged
        Listdanhsach.FocusedItem.Checked = True
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        'Kiểm tra người dùng có chọn mẫu tin để xoá hay không?
        If kt = False Then
            MsgBox("Chọn tài khoản cần xoá", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "Thông báo")

        ElseIf MsgBox("Bạn có thật muốn xóa tài khoản này này (y/n)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
            For i As Integer = 0 To Danhsach.Count - 1
                If Listdanhsach.Items(i).Checked = True Then
                    'Xoá ra khỏi ArrayList
                    Xoa_ra_khoi_ArrayList(Listdanhsach.FocusedItem.Index)
                End If
            Next
        End If
        kt = False
        Xuat_danh_sach_nguoi_dung_ra_ListView()
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
    'Xoá ra khỏi ArrayList Danhsach tại vị trí thứ i
    Private Sub Xoa_ra_khoi_ArrayList(ByVal i As Integer)
        Danhsach.RemoveAt(i)
    End Sub
End Class