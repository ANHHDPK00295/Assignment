Public Class nguoidung
#Region "Biến thành viên"
    Protected mtaikhoan As String
    Protected mmatkhau As String
#End Region
#Region "Thuộc tính của biến thành viên"
    Public Property taikhoan() As String
        Get
            Return mtaikhoan
        End Get
        Set(ByVal value As String)
            mtaikhoan = value
        End Set
    End Property
    Public Property matkhau() As String
        Get
            Return mmatkhau
        End Get
        Set(ByVal value As String)
            mmatkhau = value
        End Set
    End Property
#End Region

#Region "Hàm khởi tạo"
    Public Sub New()
        taikhoan = ""
        matkhau = ""
    End Sub

    Public Sub New(ByVal taikhoan As String, ByVal matkhau As String)
        Me.taikhoan = taikhoan
        Me.matkhau = matkhau
    End Sub

    Public Sub New(ByVal ND As nguoidung)
        Me.taikhoan = ND.taikhoan
        Me.matkhau = ND.matkhau
    End Sub
#End Region

#Region "Hàm hủy"
    Protected Overrides Sub finalize()
        GC.Collect()
    End Sub
#End Region

End Class
