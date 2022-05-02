Imports System.Text.RegularExpressions
Public Class Form2
    Private Sub closeFirewallbtn_Click(sender As Object, e As EventArgs) Handles closeFirewallbtn.Click
        Me.Close()

    End Sub

    Private Sub applyFirewallbtn_Click(sender As Object, e As EventArgs) Handles applyFirewallbtn.Click

        'If Form1.firewallTg1.Checked = False Then
        'Form1.firewallTg1.Checked = True
        'Me.Close()
        'End If
        Dim p2 As Process

        Try
            p2 = Process.GetProcessById(CInt(processText.Text))
            If MessageBox.Show("Do you want to kill process " + p2.ProcessName + "?", "Title", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                p2.Kill()
                MsgBox("successfully killed process")
            End If
        Catch ex As Exception
            MsgBox("process not found")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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



            If (item1.Count = 5) Then

                DataGridView1.Rows(counter - 1).Cells(0).Value = item1(0)
                DataGridView1.Rows(counter - 1).Cells(1).Value = item1(1)
                DataGridView1.Rows(counter - 1).Cells(2).Value = item1(2)
                DataGridView1.Rows(counter - 1).Cells(3).Value = item1(3)
                DataGridView1.Rows(counter - 1).Cells(4).Value = item1(4)

                Dim p = Process.GetProcessById(CInt(item1(4)))

                DataGridView1.Rows(counter - 1).Cells(5).Value = p.ProcessName
                counter = counter + 1
            End If


            If (item1.Count = 4) Then

                DataGridView1.Rows(counter - 1).Cells(0).Value = item1(0)
                DataGridView1.Rows(counter - 1).Cells(1).Value = item1(1)
                DataGridView1.Rows(counter - 1).Cells(2).Value = item1(2)
                'DataGridView1.Rows(counter - 1).Cells(3).Value = item1(3)
                DataGridView1.Rows(counter - 1).Cells(4).Value = item1(3)

                Dim p1 = Process.GetProcessById(CInt(item1(3)))

                DataGridView1.Rows(counter - 1).Cells(5).Value = p1.ProcessName
                counter = counter + 1
            End If

        Next



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.ColumnIndex = 4 Then
            'Do any thing

            processText.Text = DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString()

        End If
    End Sub


End Class