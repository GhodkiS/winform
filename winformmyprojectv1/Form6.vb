Public Class Form6


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim myform As New Form1

        myform.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Threading.Thread.Sleep(5000)
        Me.Close()
    End Sub

    Private Sub Form6_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class