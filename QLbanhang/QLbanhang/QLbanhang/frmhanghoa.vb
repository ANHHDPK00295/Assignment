Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlException
Imports System.Drawing.Printing
Public Class frmhanghoa
    Dim cls As New ClsConnect
    Dim Danhsach As New ArrayList
    Dim Dong_hien_hanh As Integer = 0
    Dim Trang_thai_them_moi As Boolean = True
    Dim khoa As New ArrayList()
    Private Sub Nhap_lai()
        txtmasanpham.Text = ""
        txttensp.Text = ""
        txtmota.Text = ""
        txtgia.Text = ""
        cbbmaloai.Text = ""
        txtmasanpham.Focus()
    End Sub
    Private Sub btnmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoi.Click
        Nhap_lai()
    End Sub
    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub frmhanghoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.ShowDataToGrid("Select * from SANPHAM", DataGridView1)
    End Sub
#Region "Lay du lieu tren datagrid dien vao cac textbox"
    Private Sub LoadTextBox()
        txtmasanpham.DataBindings.Clear()
        txtmasanpham.DataBindings.Add("Text", DataGridView1.DataSource, "SP_ID")
        txttensp.DataBindings.Clear()
        txttensp.DataBindings.Add("Text", DataGridView1.DataSource, "SP_TENSANPHAM")
        txtgia.DataBindings.Clear()
        txtgia.DataBindings.Add("Text", DataGridView1.DataSource, "SP_DONGIA")
        txtmota.DataBindings.Clear()
        txtmota.DataBindings.Add("Text", DataGridView1.DataSource, "SP_MOTA")
        cbbmaloai.DataBindings.Clear()
        cbbmaloai.DataBindings.Add("Text", DataGridView1.DataSource, "SP_IDLOAISP")
    End Sub
#End Region
#Region "Khi click chuot tren datagrid"
    Private Sub dtgdanhsach_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        LoadTextBox()
    End Sub
#End Region

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        If (txtmasanpham.Text.Trim().ToUpper() <> "") Then
            cls.Update_Data("Delete from SANPHAM where SP_ID='" & txtmasanpham.Text.Trim().ToUpper() & "'")
        Else
            MessageBox.Show("Chon ban ghi can xoa tren luoi.", "Thong bao")
        End If
        cls.ShowDataToGrid("Select * from SANPHAM", DataGridView1)
        Nhap_lai()
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Dim lenh As String
        Dim st As String
        st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
        Dim cn As New SqlConnection
        cn.ConnectionString = st
        If txtmasanpham.Text = "" Or txttensp.Text = "" Or txtgia.Text = "" Or txtmota.Text = "" Or cbbmaloai.Text = "" Then
            MsgBox(" Bạn Phải Nhập Giá Trị Cấn Sửa !!! ")
        Else
            lenh = "Update SANPHAM set SP_ID='" & txtmasanpham.Text & "',SP_TENSANPHAM = '" & txttensp.Text & "',SP_DONGIA = '" & txtgia.Text & "',SP_IDLOAISP = '" & cbbmaloai.Text & "'where SP_ID =  '" & Trim(txtmasanpham.Text) & "'"
            Dim cmd As New SqlCommand(lenh, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            cls.ShowDataToGrid("Select * from SANPHAM", DataGridView1)
            Nhap_lai()
        End If
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim lenh As String
        Dim st As String
        st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
        Dim cn As New SqlConnection
        cn.ConnectionString = st
        If txtmasanpham.Text = "" Or txttensp.Text = "" Or txtgia.Text = "" Or txtmota.Text = "" Or cbbmaloai.Text = "" Then
            MsgBox(" Bạn Phải Nhập Giá Trị Cấn Thêm !!! ")
        Else

            lenh = "insert into SANPHAM(SP_ID,SP_TENSANPHAM,SP_DONGIA,SP_MOTA,SP_IDLOAISP) values('" & txtmasanpham.Text & "','" & txttensp.Text & "','" & txtgia.Text & "','" & txtmota.Text & "','" & cbbmaloai.Text & "')"
            Dim cmd As New SqlCommand(lenh, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            cls.ShowDataToGrid("Select * from SANPHAM", DataGridView1)
            Nhap_lai()
        End If
    End Sub
End Class