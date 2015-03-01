Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlException
Imports System.Drawing.Printing
Public Class frmchitietCHITIETHOADON
    Dim cls As New ClsConnect
    Dim Danhsach As New ArrayList
    Dim Dong_hien_hanh As Integer = 0
    Dim Trang_thai_them_moi As Boolean = True
    Dim khoa As New ArrayList()
    Private Sub Nhap_lai()
        txtmacthd.Text = ""
        txtsoluong.Text = ""
        cbbmaCHITIETHOADON.Text = ""
        txtmacthd.Focus()
    End Sub
    Private Sub btnmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi.Click
        Nhap_lai()
    End Sub
    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub frmhanghoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.ShowDataToGrid("Select * from CHITIETHOADON", DataGridView1)
    End Sub
#Region "Lay du lieu tren datagrid dien vao cac textbox"
    Private Sub LoadTextBox()
        txtmacthd.DataBindings.Clear()
        txtmacthd.DataBindings.Add("Text", DataGridView1.DataSource, "CTHD_ID")
        cbbmahoadon.DataBindings.Clear()
        cbbmahoadon.DataBindings.Add("Text", DataGridView1.DataSource, "HD_ID")
        cbbmasp.DataBindings.Clear()
        cbbmasp.DataBindings.Add("Text", DataGridView1.DataSource, "CTHD_IDKHACHHANG")
        txtsoluong.DataBindings.Clear()
        txtsoluong.DataBindings.Add("Text", DataGridView1.DataSource, "CTHD_SOLUONG")
    End Sub
#End Region
#Region "Khi click chuot tren datagrid"
    Private Sub dtgdanhsach_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        LoadTextBox()
    End Sub
#End Region

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        If (txtmacthd.Text.Trim().ToUpper() <> "") Then
            cls.Update_Data("Delete from CHITIETHOADON where CTHD_ID='" & txtmacthd.Text.Trim().ToUpper() & "'")
        Else
            MessageBox.Show("Chon ban ghi can xoa tren luoi.", "Thong bao")
        End If
        cls.ShowDataToGrid("Select * from CHITIETHOADON", DataGridView1)
        Nhap_lai()
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Dim lenh As String
        Dim st As String
        st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
        Dim cn As New SqlConnection
        cn.ConnectionString = st
        If txtmacthd.Text = "" Or cbbmahoadon.Text = "" Or cbbmasp.Text = "" Or txtsoluong.Text = "" Then
            MsgBox(" Bạn Phải Nhập Giá Trị Cấn Sửa !!! ")
        Else
            lenh = "Update CHITIETHOADON set CTHD_ID='" & txtmacthd.Text & "',CTHD_ID = '" & cbbmahoadon.Text & "',CTHD_MASANPHAM = '" & cbbmasp.Text & "',CTHD_SOLUONG = '" & txtsoluong.Text & "'where CTHD_ID =  '" & Trim(txtmacthd.Text) & "'"
            Dim cmd As New SqlCommand(lenh, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            cls.ShowDataToGrid("Select * from CHITIETHOADON", DataGridView1)
            Nhap_lai()
        End If
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim lenh As String
        Dim st As String
        st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
        Dim cn As New SqlConnection
        cn.ConnectionString = st
        If txtmacthd.Text = "" Or cbbmahoadon.Text = "" Or cbbmasp.Text = "" Or txtsoluong.Text = "" Then
            MsgBox(" Bạn Phải Nhập Giá Trị Cấn Thêm !!! ")
        Else

            lenh = "insert into CHITIETHOADON(CTHD_ID,CTHD_IDHD,CTHD_MASANPHAM,CTHD_SOLUONG) values('" & txtmacthd.Text & "','" & cbbmahoadon.Text & "','" & cbbmasp.Text & "','" & txtsoluong.Text & "')"
            Dim cmd As New SqlCommand(lenh, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            cls.ShowDataToGrid("Select * from CHITIETHOADON", DataGridView1)
            Nhap_lai()
        End If
    End Sub
End Class