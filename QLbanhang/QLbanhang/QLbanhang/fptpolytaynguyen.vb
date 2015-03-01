Public Class fptpolytaynguyen

    Dim dem As Byte = 0
    Private Sub fptpolytaynguyen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tg.Enabled = True
        tg.Interval = 1000
    End Sub

    Private Sub fptpolytaynguyen_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Escape Then
            frmdangnhap.Show()
            Me.Close()
        End If
    End Sub

    Private Sub tg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tg.Tick
        lbldaucham.Text = lbldaucham.Text + "."
        If lbldaucham.Text = "......." Then
            lbldaucham.Text = "."
        End If

        dem = dem + 10

        If dem > 100 Then
            tg.Enabled = False
            FrmDangnhap.Show()
            Me.Close()
        Else
            ProgressBar1.Value = dem
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class