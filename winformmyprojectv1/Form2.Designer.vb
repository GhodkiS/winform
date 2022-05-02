<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.applyFirewallbtn = New System.Windows.Forms.Button()
        Me.closeFirewallbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Protocol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForignIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.processText = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'applyFirewallbtn
        '
        Me.applyFirewallbtn.Location = New System.Drawing.Point(539, 410)
        Me.applyFirewallbtn.Name = "applyFirewallbtn"
        Me.applyFirewallbtn.Size = New System.Drawing.Size(174, 23)
        Me.applyFirewallbtn.TabIndex = 0
        Me.applyFirewallbtn.Text = "Kill running process"
        Me.applyFirewallbtn.UseVisualStyleBackColor = True
        '
        'closeFirewallbtn
        '
        Me.closeFirewallbtn.Location = New System.Drawing.Point(827, 410)
        Me.closeFirewallbtn.Name = "closeFirewallbtn"
        Me.closeFirewallbtn.Size = New System.Drawing.Size(75, 23)
        Me.closeFirewallbtn.TabIndex = 1
        Me.closeFirewallbtn.Text = "Close"
        Me.closeFirewallbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Protocol, Me.LocalIP, Me.ForignIP, Me.State, Me.ProcessID, Me.ProcessName})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 64)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(930, 321)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(930, 321)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(930, 321)
        Me.DataGridView1.TabIndex = 2
        '
        'Protocol
        '
        Me.Protocol.HeaderText = "Protocol"
        Me.Protocol.Name = "Protocol"
        Me.Protocol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'LocalIP
        '
        Me.LocalIP.HeaderText = "Local IP"
        Me.LocalIP.Name = "LocalIP"
        Me.LocalIP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LocalIP.Width = 200
        '
        'ForignIP
        '
        Me.ForignIP.HeaderText = "Forign IP"
        Me.ForignIP.Name = "ForignIP"
        Me.ForignIP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ForignIP.Width = 200
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.State.Width = 132
        '
        'ProcessID
        '
        Me.ProcessID.HeaderText = "Process ID"
        Me.ProcessID.Name = "ProcessID"
        Me.ProcessID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProcessName
        '
        Me.ProcessName.HeaderText = "Process Name"
        Me.ProcessName.Name = "ProcessName"
        Me.ProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProcessName.Width = 160
        '
        'processText
        '
        Me.processText.Enabled = False
        Me.processText.Location = New System.Drawing.Point(308, 408)
        Me.processText.Name = "processText"
        Me.processText.Size = New System.Drawing.Size(201, 23)
        Me.processText.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.processText)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.closeFirewallbtn)
        Me.Controls.Add(Me.applyFirewallbtn)
        Me.MaximumSize = New System.Drawing.Size(960, 489)
        Me.MinimumSize = New System.Drawing.Size(960, 489)
        Me.Name = "Form2"
        Me.Text = "Firewall"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents applyFirewallbtn As Button
    Friend WithEvents closeFirewallbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Protocol As DataGridViewTextBoxColumn
    Friend WithEvents LocalIP As DataGridViewTextBoxColumn
    Friend WithEvents ForignIP As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewTextBoxColumn
    Friend WithEvents ProcessID As DataGridViewTextBoxColumn
    Friend WithEvents ProcessName As DataGridViewTextBoxColumn
    Friend WithEvents processText As TextBox
End Class
