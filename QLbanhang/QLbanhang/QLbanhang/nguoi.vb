Public Class classnguoi
#Region "khai báo biến thành viên"
    Protected mho_ten As String
    Protected mgioi_tinh As String
    Protected mngay_sinh As Date
    Protected mdia_chi As String
#End Region

#Region " thành phần thuộc tính"
    Public Property hoten() As String
        Get
            Return mho_ten
        End Get
        Set(ByVal value As String)
            mho_ten = value
        End Set
    End Property
    Public Property gioitinh() As String
        Get
            Return mgioi_tinh
        End Get
        Set(ByVal value As String)
            mgioi_tinh = value
        End Set
    End Property
    Public Property ngaysinh() As Date
        Get
            Return mngay_sinh
        End Get
        Set(ByVal value As Date)
            mngay_sinh = value
        End Set
    End Property
    Public Property diachi() As String
        Get
            Return mdia_chi

        End Get
        Set(ByVal value As String)
            mdia_chi = value
        End Set
    End Property
#End Region

#Region " khởi tạo "
    Public Sub New()
        hoten = ""
        gioitinh = "Nam"
        ngaysinh = "1/1/1950"
        diachi = ""
    End Sub

    Public Sub New(ByVal ho_ten As String, ByVal gioi_tinh As String, ByVal ngay_sinh As Date, ByVal dia_chi As String)
        Me.hoten = ho_ten
        Me.gioitinh = gioi_tinh
        Me.ngaysinh = ngay_sinh
        Me.diachi = dia_chi
    End Sub
    Public Sub New(ByVal cn As classnguoi)
        Me.hoten = cn.hoten
        Me.gioitinh = cn.gioitinh
        Me.ngaysinh = cn.ngaysinh
        Me.diachi = cn.diachi
    End Sub
#End Region
#Region "hàm hủy"
    Protected Overrides Sub finalize()
        MyBase.Finalize()
        GC.Collect()
    End Sub
#End Region
End Class

