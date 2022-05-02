<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.startBtn = New System.Windows.Forms.Button()
        Me.stopBtn = New System.Windows.Forms.Button()
        Me.portBlockerBtn = New System.Windows.Forms.Button()
        Me.cookieCleanBtn = New System.Windows.Forms.Button()
        Me.advPortScanBtn = New System.Windows.Forms.Button()
        Me.FirewallBtn = New System.Windows.Forms.Button()
        Me.systemTrayBtn = New System.Windows.Forms.Button()
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.netSpeedLbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lastbootlbl = New System.Windows.Forms.Label()
        Me.hostnamelbl = New System.Windows.Forms.Label()
        Me.firewall1 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.mainformclosebtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.BackColor = System.Drawing.SystemColors.Control
        Me.startBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startBtn.ForeColor = System.Drawing.Color.Black
        Me.startBtn.Location = New System.Drawing.Point(12, 323)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(179, 37)
        Me.startBtn.TabIndex = 0
        Me.startBtn.Text = "Start"
        Me.startBtn.UseVisualStyleBackColor = False
        '
        'stopBtn
        '
        Me.stopBtn.BackColor = System.Drawing.SystemColors.Control
        Me.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stopBtn.ForeColor = System.Drawing.Color.Black
        Me.stopBtn.Location = New System.Drawing.Point(189, 323)
        Me.stopBtn.Name = "stopBtn"
        Me.stopBtn.Size = New System.Drawing.Size(191, 37)
        Me.stopBtn.TabIndex = 2
        Me.stopBtn.Text = "Stop"
        Me.stopBtn.UseVisualStyleBackColor = False
        '
        'portBlockerBtn
        '
        Me.portBlockerBtn.BackColor = System.Drawing.SystemColors.Control
        Me.portBlockerBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.portBlockerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.portBlockerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.portBlockerBtn.ForeColor = System.Drawing.Color.Black
        Me.portBlockerBtn.Location = New System.Drawing.Point(12, 359)
        Me.portBlockerBtn.Name = "portBlockerBtn"
        Me.portBlockerBtn.Size = New System.Drawing.Size(368, 30)
        Me.portBlockerBtn.TabIndex = 3
        Me.portBlockerBtn.Text = "Port Blocker"
        Me.portBlockerBtn.UseVisualStyleBackColor = False
        '
        'cookieCleanBtn
        '
        Me.cookieCleanBtn.BackColor = System.Drawing.SystemColors.Control
        Me.cookieCleanBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cookieCleanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cookieCleanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cookieCleanBtn.ForeColor = System.Drawing.Color.Black
        Me.cookieCleanBtn.Location = New System.Drawing.Point(12, 416)
        Me.cookieCleanBtn.Name = "cookieCleanBtn"
        Me.cookieCleanBtn.Size = New System.Drawing.Size(368, 31)
        Me.cookieCleanBtn.TabIndex = 4
        Me.cookieCleanBtn.Text = "Cookie Cleaner"
        Me.cookieCleanBtn.UseVisualStyleBackColor = False
        '
        'advPortScanBtn
        '
        Me.advPortScanBtn.BackColor = System.Drawing.SystemColors.Control
        Me.advPortScanBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.advPortScanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.advPortScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.advPortScanBtn.ForeColor = System.Drawing.Color.Black
        Me.advPortScanBtn.Location = New System.Drawing.Point(12, 388)
        Me.advPortScanBtn.Name = "advPortScanBtn"
        Me.advPortScanBtn.Size = New System.Drawing.Size(368, 29)
        Me.advPortScanBtn.TabIndex = 5
        Me.advPortScanBtn.Text = "Advance Port Scanner"
        Me.advPortScanBtn.UseVisualStyleBackColor = False
        '
        'FirewallBtn
        '
        Me.FirewallBtn.BackColor = System.Drawing.SystemColors.Control
        Me.FirewallBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FirewallBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FirewallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FirewallBtn.ForeColor = System.Drawing.Color.Black
        Me.FirewallBtn.Location = New System.Drawing.Point(12, 446)
        Me.FirewallBtn.Name = "FirewallBtn"
        Me.FirewallBtn.Size = New System.Drawing.Size(368, 32)
        Me.FirewallBtn.TabIndex = 6
        Me.FirewallBtn.Text = "Firewall"
        Me.FirewallBtn.UseVisualStyleBackColor = False
        '
        'systemTrayBtn
        '
        Me.systemTrayBtn.BackColor = System.Drawing.SystemColors.Control
        Me.systemTrayBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.systemTrayBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.systemTrayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.systemTrayBtn.ForeColor = System.Drawing.Color.Black
        Me.systemTrayBtn.Location = New System.Drawing.Point(12, 498)
        Me.systemTrayBtn.Name = "systemTrayBtn"
        Me.systemTrayBtn.Size = New System.Drawing.Size(162, 44)
        Me.systemTrayBtn.TabIndex = 7
        Me.systemTrayBtn.Text = "Click To Minimize To The SystemTray"
        Me.systemTrayBtn.UseVisualStyleBackColor = False
        '
        'nfi
        '
        Me.nfi.BalloonTipText = "Network Watch"
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "Network Watch"
        Me.nfi.Visible = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.netSpeedLbl)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 89)
        Me.Panel1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-1, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Available Adaptors:"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Network Monitoring:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(193, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CPU Utilization"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-1, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Download Speed:"
        Me.Label1.Visible = False
        '
        'netSpeedLbl
        '
        Me.netSpeedLbl.AutoSize = True
        Me.netSpeedLbl.Location = New System.Drawing.Point(36, 28)
        Me.netSpeedLbl.Name = "netSpeedLbl"
        Me.netSpeedLbl.Size = New System.Drawing.Size(0, 15)
        Me.netSpeedLbl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lastbootlbl)
        Me.Panel2.Controls.Add(Me.hostnamelbl)
        Me.Panel2.Controls.Add(Me.firewall1)
        Me.Panel2.Location = New System.Drawing.Point(12, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 176)
        Me.Panel2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Public"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Domain"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Private"
        '
        'lastbootlbl
        '
        Me.lastbootlbl.AutoSize = True
        Me.lastbootlbl.ForeColor = System.Drawing.Color.Black
        Me.lastbootlbl.Location = New System.Drawing.Point(18, 117)
        Me.lastbootlbl.Name = "lastbootlbl"
        Me.lastbootlbl.Size = New System.Drawing.Size(94, 15)
        Me.lastbootlbl.TabIndex = 3
        Me.lastbootlbl.Text = "System last boot"
        '
        'hostnamelbl
        '
        Me.hostnamelbl.AutoSize = True
        Me.hostnamelbl.ForeColor = System.Drawing.Color.Black
        Me.hostnamelbl.Location = New System.Drawing.Point(18, 144)
        Me.hostnamelbl.Name = "hostnamelbl"
        Me.hostnamelbl.Size = New System.Drawing.Size(83, 15)
        Me.hostnamelbl.TabIndex = 2
        Me.hostnamelbl.Text = "System FQDN:"
        '
        'firewall1
        '
        Me.firewall1.AutoSize = True
        Me.firewall1.ForeColor = System.Drawing.Color.Black
        Me.firewall1.Location = New System.Drawing.Point(17, 10)
        Me.firewall1.Name = "firewall1"
        Me.firewall1.Size = New System.Drawing.Size(82, 15)
        Me.firewall1.TabIndex = 0
        Me.firewall1.Text = "Firewall Status"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'mainformclosebtn
        '
        Me.mainformclosebtn.BackColor = System.Drawing.SystemColors.Control
        Me.mainformclosebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainformclosebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.mainformclosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainformclosebtn.ForeColor = System.Drawing.Color.Black
        Me.mainformclosebtn.Location = New System.Drawing.Point(218, 498)
        Me.mainformclosebtn.Name = "mainformclosebtn"
        Me.mainformclosebtn.Size = New System.Drawing.Size(162, 44)
        Me.mainformclosebtn.TabIndex = 11
        Me.mainformclosebtn.Text = "Close"
        Me.mainformclosebtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(389, 561)
        Me.Controls.Add(Me.mainformclosebtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.systemTrayBtn)
        Me.Controls.Add(Me.FirewallBtn)
        Me.Controls.Add(Me.advPortScanBtn)
        Me.Controls.Add(Me.cookieCleanBtn)
        Me.Controls.Add(Me.portBlockerBtn)
        Me.Controls.Add(Me.stopBtn)
        Me.Controls.Add(Me.startBtn)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(405, 600)
        Me.Name = "Form1"
        Me.Text = "Network Watch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents startBtn As Button
    Friend WithEvents stopBtn As Button
    Friend WithEvents portBlockerBtn As Button
    Friend WithEvents cookieCleanBtn As Button
    Friend WithEvents advPortScanBtn As Button
    Friend WithEvents FirewallBtn As Button
    Friend WithEvents systemTrayBtn As Button
    Friend WithEvents nfi As NotifyIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lastbootlbl As Label
    Friend WithEvents hostnamelbl As Label
    Friend WithEvents firewall1 As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents netSpeedLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents mainformclosebtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
End Class
