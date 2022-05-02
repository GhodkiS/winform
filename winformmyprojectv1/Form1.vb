Imports Microsoft.AspNetCore.Http
Imports System.Web
Imports System.Net.NetworkInformation
Imports System.Diagnostics
Imports System.Net
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Management
Imports System.Globalization

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startBtn.Click


        Label1.Visible = True
        Label3.Visible = True
        Label4.Visible = True

        Label6.Text = "Network Monitoring:  Started"

    End Sub

    Private Sub stopBtn_Click(sender As Object, e As EventArgs) Handles stopBtn.Click

        Label1.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        Label6.Text = "Network Monitoring: Stopped"



    End Sub

    Private Sub systemTrayBtn_Click(sender As Object, e As EventArgs) Handles systemTrayBtn.Click
        'First minimize the form
        Me.WindowState = FormWindowState.Minimized

        'Now make it invisible (make it look like it went into the system tray)
        Me.Visible = False

        'Cancel the closing of the application


        nfi.Visible = True
    End Sub

    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = "Network Monitoring: Stopped"
        BackgroundWorker1.RunWorkerAsync()
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        For Each netadapter As NetworkInterface In nics
            'next lets set variable to get interface properties for later use
            Dim intproperties As IPInterfaceProperties = netadapter.GetIPProperties()

            'get first number of IP address.
            Dim firstnum As String
            Try
                firstnum = intproperties.UnicastAddresses(1).Address.ToString()
                firstnum = firstnum.Substring(0, firstnum.IndexOf("."))
            Catch ex As Exception
                'If not IPv4 then
                firstnum = "NOPE"
            End Try

            'check if first number if valid IPv4 address
            If Val(firstnum) > 0 And Not Val(firstnum) = 169 And Not Val(firstnum) = 127 Then


                'now add the network adaptername to the list
                Label4.Text = Label4.Text + ", " + netadapter.Name

            End If




        Next

        Dim process As New Process()
        Dim output As String = String.Empty

        process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System)
        process.StartInfo.FileName = "netsh"
        process.StartInfo.Arguments = "advfirewall show allprofiles"
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.ErrorDialog = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.UseShellExecute = False
        process.Start()


        process.WaitForExit(5000)

        Dim counter2 = 0
        output = process.StandardOutput.ReadToEnd()

        Dim spiltoutput = output.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim item6()




        For Each item3 As String In spiltoutput
            If item3.Contains("Domain Profile Settings") Then


                item6 = (Regex.Replace(spiltoutput(counter2 + 2), " {2,}", " ")).Trim.Split(" ")


                Label5.Text = Label5.Text + "                                                  " + item6(1)




            End If

            If item3.Contains("Private Profile Settings") Then


                item6 = (Regex.Replace(spiltoutput(counter2 + 2), " {2,}", " ")).Trim.Split(" ")
                Label2.Text = Label2.Text + "                                                    " + item6(1)



            End If

            If item3.Contains("Public Profile Settings") Then

                item6 = (Regex.Replace(spiltoutput(counter2 + 2), " {2,}", " ")).Trim.Split(" ")

                Label7.Text = Label7.Text + "                                                     " + item6(1)



            End If

            counter2 = counter2 + 1

        Next


        ' define a select query
        Dim dtBootTime As New DateTime()

        Dim query As New SelectQuery("SELECT LastBootUpTime FROM Win32_OperatingSystem WHERE

        Primary='true'")



        ' create a new management object searcher and pass it

        ' the select query


        Dim searcher As New ManagementObjectSearcher(query)



        ' get the datetime value and set the local boot

        ' time variable to contain that value

        Dim mo As ManagementObject



        For Each mo In searcher.Get()



            dtBootTime = ManagementDateTimeConverter.ToDateTime(mo.Properties("LastBootUpTime").Value.ToString())



            ' display the start time and date
            lastbootlbl.Text = lastbootlbl.Text + "                                  " + dtBootTime.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " " + dtBootTime.ToLongTimeString()





        Next



        searcher = Nothing

        mo = Nothing

        Dim domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName
        Dim hostName = Dns.GetHostName()
        hostName += domainName
        hostnamelbl.Text = hostnamelbl.Text + "                                      " + hostName
        Me.CenterToScreen()



    End Sub

    Private Sub nfi_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nfi.MouseDoubleClick
        nfi.Visible = False
        Me.WindowState = FormWindowState.Maximized
        Me.Visible = True
    End Sub





    Private Sub FirewallBtn_Click(sender As Object, e As EventArgs) Handles FirewallBtn.Click

        Dim myForm As New Form2
        myForm.ShowDialog()

    End Sub

    Private Sub cookieCleanBtn_Click(sender As Object, e As EventArgs) Handles cookieCleanBtn.Click
        Dim myForm As New Form3
        myForm.ShowDialog()

    End Sub


    Private Sub portBlockerBtn_Click(sender As Object, e As EventArgs) Handles portBlockerBtn.Click
        Dim myForm As New Form4
        myForm.ShowDialog()

    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        While True
            Threading.Thread.Sleep(1000)
            Dim cpu As PerformanceCounter  '''Declare in class level

            'On form load(actually you need to initialize it first)

            cpu = New PerformanceCounter("Processor", "% Processor Time", "_Total")

            '''Finally,get the value :

            'MsgBox(cpu.NextValue & "%") '''Use .ToString if required
            Dim dump = cpu.NextValue
            dump = (cpu.NextValue)
            Threading.Thread.Sleep(1000)
            Me.Invoke(Sub()
                          'safe to access the form or controls in here
                          Label3.Text = "CPU Utilization: " & CInt(cpu.NextValue) & "%"
                      End Sub)



            Dim speeds As Double() = New Double(4) {}
            For i As Integer = 0 To 4
                Dim jQueryFileSize As Integer = 261
                'Size of File in KB.
                Dim client As New WebClient()
                Dim startTime As DateTime = DateTime.Now
                client.DownloadFile("http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.js", "jQuery.js")
                Dim endTime As DateTime = DateTime.Now
                speeds(i) = Math.Round((jQueryFileSize / (endTime - startTime).TotalSeconds))
            Next

            Me.Invoke(Sub()
                          'safe to access the form or controls in here
                          Label1.Text = (String.Format("Download Speed: {0}KB/s", CInt(speeds.Average())))
                      End Sub)



            ' Label6.Text = "System Status: Started"
            Threading.Thread.Sleep(15000)

        End While

    End Sub



    Private Sub advPortScanBtn_Click(sender As Object, e As EventArgs) Handles advPortScanBtn.Click

        Dim myform As New Form5

        myform.ShowDialog()



    End Sub

    Private Sub mainformclosebtn_Click(sender As Object, e As EventArgs) Handles mainformclosebtn.Click

        Me.Close()


    End Sub

End Class
