Imports System.Text.RegularExpressions
Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        Dim process As New Process()
        Dim output As String = String.Empty

        process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System)
        process.StartInfo.FileName = "netstat"
        process.StartInfo.Arguments = "-a -n  -o"
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.ErrorDialog = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.UseShellExecute = False
        process.Start()


        process.WaitForExit(5000)


        output = process.StandardOutput.ReadToEnd()
        Dim spiltoutput = output.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim counter = 1
        Dim counter1 = 0

        For Each item3 As String In spiltoutput
            Dim item4 = (Regex.Replace(item3, " {2,}", " ")).Trim

            Dim item5 = item4.Split(" ")
            If item5.Count = 4 Or item5.Count = 5 Then

                counter1 = counter1 + 1

            End If



        Next
        DataGridView1.Rows.Add(counter1)

        For Each item As String In spiltoutput

            Dim item2 = (Regex.Replace(item, " {2,}", " ")).Trim


            Dim item1 = item2.Split(" ")

            Dim idx = item1(1).LastIndexOf(":")
            Dim idx1 = idx + 1
            Dim lastidx = item1(1).Length - idx1


            If (item1.Count = 5) Then
                DataGridView1.Rows(counter - 1).Cells(0).Value = item1(1).Substring(0, idx)
                DataGridView1.Rows(counter - 1).Cells(1).Value = item1(1).Substring(idx1, lastidx)
                counter = counter + 1

            End If


            If (item1.Count = 4) Then

                DataGridView1.Rows(counter - 1).Cells(0).Value = item1(1).Substring(0, idx)
                DataGridView1.Rows(counter - 1).Cells(1).Value = item1(1).Substring(idx1, lastidx)


                counter = counter + 1
            End If

        Next
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        DataGridView1.Rows.Clear()
    End Sub
End Class