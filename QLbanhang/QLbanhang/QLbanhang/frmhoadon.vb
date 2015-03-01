Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlException
Imports System.Drawing.Printing
Public Class frmhoadon
    Dim cls As New ClsConnect
    Dim Danhsach As New ArrayList
    Dim Dong_hien_hanh As Integer = 0
    Dim Trang_thai_them_moi As Boolean = True
    Dim khoa As New ArrayList()
    Private Sub Nhap_lai()
        txtmahoadon.Text = ""
        txtngay.Text = ""
        cbbmanhanvien.Text = ""
        txtmahoadon.Focus()
    End Sub
    Private Sub btnmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi.Click
        Nhap_lai()
    End Sub
    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub frmhanghoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.ShowDataToGrid("Select * from HOADON", DataGridView1)
    End Sub
#Region "Lay du lieu tren datagrid dien vao cac textbox"
    Private Sub LoadTextBox()
        txtmahoadon.DataBindings.Clear()
        txtmahoadon.DataBindings.Add("Text", DataGridView1.DataSource, "HD_ID")
        txtngay.DataBindings.Clear()
        txtngay.DataBindings.Add("Text", DataGridView1.DataSource, "HD_NGAY")
        cbbmakh.DataBindings.Clear()
        cbbmakh.DataBindings.Add("Text", DataGridView1.DataSource, "HD_IDKHACHHANG")
        cbbmanhanvien.DataBindings.Clear()
        cbbmanhanvien.DataBindings.Add("Text", DataGridView1.DataSource, "HD_IDNHANVIEN")
    End Sub
#End Region
#Region "Khi click chuot tren datagrid"
    Private Sub dtgdanhsach_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        LoadTextBox()
    End Sub
#End Region

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        If (txtmahoadon.Text.Trim().ToUpper() <> "") Then
            cls.Update_Data("Delete from HOADON where HD_ID='" & txtmahoadon.Text.Trim().ToUpper() & "'")
        Else
            MessageBox.Show("Chon ban ghi can xoa tren luoi.", "Thong bao")
        End If
        cls.ShowDataToGrid("Select * from HOADON", DataGridView1)
        Nhap_lai()
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Dim lenh As String
        Dim st As String
        st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
        Dim cn As New SqlConnection
        cn.ConnectionString = st
        If txtmahoadon.Text = "" Or txtngay.Text = "" Or cbbmakh.Text = "" Or cbbmanhanvien.Text = "" Then
            MsgBox(" Bạn Phải Nhập Giá Trị Cấn Sửa !!! ")
        Else
            lenh = "Update HOADON set HD_ID='" & txtmahoadon.Text & "',HD_NGAY = '" & txtngay.Text & "',HD_IDKHACHHANG = '" & cbbmakh.Text & "',HD_IDNHANVIEN = '" & cbbmanhanvien.Text & "'where HD_ID =  '" & Trim(txtmahoadon.Text) & "'"
            Dim cmd As New SqlCommand(lenh, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            cls.ShowDataToGrid("Select * from HOADON", DataGridView1)
            Nhap_lai()
        End If
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim lenh As String
        Dim st As String
        st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
        Dim cn As New SqlConnection
        cn.ConnectionString = st
        If txtmahoadon.Text = "" Or txtngay.Text = "" Or cbbmakh.Text = "" Or cbbmanhanvien.Text = "" Then
            MsgBox(" Bạn Phải Nhập Giá Trị Cấn Thêm !!! ")
        Else

            lenh = "insert into HOADON(HD_ID,HD_NGAY,HD_IDKHACHHANG,HD_IDNHANVIEN) values('" & txtmahoadon.Text & "','" & txtngay.Text & "','" & cbbmakh.Text & "','" & cbbmanhanvien.Text & "')"
            Dim cmd As New SqlCommand(lenh, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            cls.ShowDataToGrid("Select * from HOADON", DataGridView1)
            Nhap_lai()
        End If
    End Sub
End Class