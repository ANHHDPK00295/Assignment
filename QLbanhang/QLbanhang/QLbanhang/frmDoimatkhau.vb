Imports System.IO
Public Class frmDoimatkhau

    Private Sub frmDoimatkhau_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Taptin As String
        Taptin = Directory.GetCurrentDirectory() & "\" & "Login.txt"
        If txtTaikhoan.Text = "" Or txtMatkhaucu.Text = "" Or txtMatkhaumoi.Text = "" Or txtNhaplaimatkhaumoi.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thong bao")
            txtTaikhoan.Focus()
        ElseIf txtMatkhaumoi.Text <> txtNhaplaimatkhaumoi.Text Then
            MsgBox("Nhập khẩu mới nhập lại không đúng", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thong bao")
        Else
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

                'Lần lượt gán giá trị cho các thành phần
                If txtTaikhoan.Text.Trim() = Thongtin(0) And txtMatkhaucu.Text.Trim() = Thongtin(1) Then
                    Luu_du_lieu(Taptin, txtTaikhoan.Text, txtMatkhaumoi.Text)
                    MsgBox("Mật khẩu đã đổi thành công!", MsgBoxStyle.OkOnly, "Thông báo")
                    Exit Do
                Else
                    MsgBox("Tài khoản hoặc Mật khẩu không đúng!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Thong bao")
                End If
            Loop
            F.Close()
        End If

    End Sub
    Public Sub Luu_du_lieu(ByVal Taptin As String, ByVal user As String, ByVal pass As String)

        Try
            'Khởi tạo biến lưu tập tin theo hình thức ghi đè với bảng mã UTF-8
            Dim F As New IO.StreamWriter(Taptin, False)

            'Khai báo biến lấy nội dung lưu vào tập tin
            Dim Chuoi As String = user & vbTab & pass

            'Sau khi tập hợp đủ nội dung, lưu vào tập tin
            F.Write(Chuoi)

            'Đóng tập tin lại
            F.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class