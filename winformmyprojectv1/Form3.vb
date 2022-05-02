Imports System.Web
Imports System.Net
Imports System
Imports System.IO
Public Class Form3
    Private Sub clearCookieBtn_Click(sender As Object, e As EventArgs) Handles clearCookieBtn.Click
        If MessageBox.Show("Cookies will be deleted for marked browsers", "Message Box", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            For Each item In browserCheckList.CheckedItems

                For Each Dir As String In Directory.GetDirectories("c:\users")
                    If item = "Google Chrome" Then
                        Try
                            File.Delete(Dir + "\appdata\Local\Google\Chrome\User Data\Default\Network\cookies")
                        Catch

                        End Try
                    ElseIf item = "Mozilla FireFox" Then
                        Try
                            File.Delete(Dir + "\appdata\Roaming\Mozilla\Firefox\profiles\*\cookies.*")
                        Catch

                        End Try
                    ElseIf item = "Microsoft Edge" Then
                        Try
                            File.Delete(Dir + "\appdata\Local\Microsoft\Edge\User Data\Default\Network\cookies")

                        Catch

                        End Try
                    End If

                Next


            Next

            MsgBox("cookies are cleared successfully")
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To browserCheckList.Items.Count - 1
                browserCheckList.SetItemChecked(i, checked)
            Next

        End If


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load








    End Sub

    Private Sub cookieClose_Click(sender As Object, e As EventArgs) Handles cookieClose.Click
        Me.Close()
    End Sub
End Class