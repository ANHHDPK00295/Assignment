'Code của lớp ClsConnect (Lớp kết nối)
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class ClsConnect
    'Khai bao cac bien toan cuc
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public adapter As SqlDataAdapter
    Public ds As DataSet
#Region " Khởi tạo các biến"
    Public Sub Khoitao()
        Try
            cn = New SqlConnection
            cmd = New SqlCommand
            adapter = New SqlDataAdapter
            ds = New DataSet
        Catch ex As Exception
            cn.Dispose()
            cmd.Dispose()
            adapter.Dispose()
            ds.Dispose()
        End Try
    End Sub
#End Region

#Region "Thu hoi bo nho da cap cho cac doi tuong"
    Public Sub Dong()
        cn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        ds.Dispose()
    End Sub
#End Region

#Region "Mo ket noi"
    Public Sub EnableConnect()
        Try
            Dim st As String
            ' Chuoi ket noi theo dac quyen he dieu hanh
            'st = "Data Source=(local);Database=Northwind;Integrated Security=true;"
            ' Chuoi ket noi theo dac quyen cua he quan tri SQL
            st = "Data Source=PC2015011705ARW\SQLEXPRESS;Initial Catalog=QL_BANHANG;Integrated Security=True;"
            Khoitao()
            cn.ConnectionString = st
            cn.Open()
        Catch ex As Exception
            Dong()
        End Try

    End Sub
#End Region

#Region "Dong ket noi"
    Public Sub DisableConnect()
        cn.Close()
        Dong()
    End Sub
#End Region

#Region "tra ve doi tuong data set"
    Public Function ReturnDataSet(ByVal st As String) As DataSet
        EnableConnect()
        cmd.CommandText = st
        cmd.CommandType = CommandType.Text
        cmd.Connection = cn
        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(ds)
        Return ds
        DisableConnect()
    End Function
#End Region

#Region "Hien thi du lieu len gridview"
    Public Sub ShowDataToGrid(ByVal strSQL As String, ByVal grd As DataGridView)
        grd.DataSource = ReturnDataSet(strSQL).Tables(0).DefaultView
    End Sub
#End Region

#Region "Thu tuc cap nhat du lieu voi tham so dau vao la mot cau lenh sql"
    Public Sub Update_Data(ByVal sql As String)
        EnableConnect()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        DisableConnect()
    End Sub
#End Region

End Class
