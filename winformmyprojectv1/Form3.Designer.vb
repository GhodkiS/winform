<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cookieClose = New System.Windows.Forms.Button()
        Me.clearCookieBtn = New System.Windows.Forms.Button()
        Me.browserCheckList = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'cookieClose
        '
        Me.cookieClose.Location = New System.Drawing.Point(152, 138)
        Me.cookieClose.Name = "cookieClose"
        Me.cookieClose.Size = New System.Drawing.Size(100, 23)
        Me.cookieClose.TabIndex = 0
        Me.cookieClose.Text = "Close"
        Me.cookieClose.UseVisualStyleBackColor = True
        '
        'clearCookieBtn
        '
        Me.clearCookieBtn.Location = New System.Drawing.Point(12, 138)
        Me.clearCookieBtn.Name = "clearCookieBtn"
        Me.clearCookieBtn.Size = New System.Drawing.Size(117, 23)
        Me.clearCookieBtn.TabIndex = 1
        Me.clearCookieBtn.Text = "Clear Cookies"
        Me.clearCookieBtn.UseVisualStyleBackColor = True
        '
        'browserCheckList
        '
        Me.browserCheckList.FormattingEnabled = True
        Me.browserCheckList.Items.AddRange(New Object() {"Google Chrome", "Microsoft Edge", "Mozilla FireFox"})
        Me.browserCheckList.Location = New System.Drawing.Point(40, 27)
        Me.browserCheckList.Name = "browserCheckList"
        Me.browserCheckList.Size = New System.Drawing.Size(212, 58)
        Me.browserCheckList.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.browserCheckList)
        Me.Controls.Add(Me.clearCookieBtn)
        Me.Controls.Add(Me.cookieClose)
        Me.MaximumSize = New System.Drawing.Size(300, 212)
        Me.MinimumSize = New System.Drawing.Size(300, 212)
        Me.Name = "Form3"
        Me.Text = "Clear Cookies"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cookieClose As Button
    Friend WithEvents clearCookieBtn As Button
    Friend WithEvents browserCheckList As CheckedListBox
End Class
