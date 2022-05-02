Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim process As New Process()
        Dim output As String = String.Empty

        process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System)
        process.StartInfo.FileName = "netsh"
        process.StartInfo.Arguments = "advfirewall firewall add rule name=Block" + portblocktxt.Text + " protocol=TCP dir=out remoteport=" + portblocktxt.Text + " action=block"
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.ErrorDialog = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.UseShellExecute = False
        Try
            If MessageBox.Show("Do you want to block port " + portblocktxt.Text + "?", "Title", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                process.Start()
                MsgBox("port blocked successfully")
            End If
        Catch
            MsgBox("failed to block port")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class