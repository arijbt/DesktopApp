<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.Logoutbtn = New System.Windows.Forms.Button()
        Me.Process1btn = New System.Windows.Forms.Button()
        Me.Process2btn = New System.Windows.Forms.Button()
        Me.Process3btn = New System.Windows.Forms.Button()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.White
        Me.MenuPanel.Controls.Add(Me.Process3btn)
        Me.MenuPanel.Controls.Add(Me.Process2btn)
        Me.MenuPanel.Controls.Add(Me.Process1btn)
        Me.MenuPanel.Controls.Add(Me.Logoutbtn)
        Me.MenuPanel.Location = New System.Drawing.Point(43, 29)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(713, 464)
        Me.MenuPanel.TabIndex = 0
        '
        'Logoutbtn
        '
        Me.Logoutbtn.BackColor = System.Drawing.Color.Gray
        Me.Logoutbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Logoutbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Logoutbtn.Location = New System.Drawing.Point(553, 402)
        Me.Logoutbtn.Margin = New System.Windows.Forms.Padding(0)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Logoutbtn.Size = New System.Drawing.Size(134, 36)
        Me.Logoutbtn.TabIndex = 0
        Me.Logoutbtn.Text = "Logout"
        Me.Logoutbtn.UseVisualStyleBackColor = False
        '
        'Process1btn
        '
        Me.Process1btn.Location = New System.Drawing.Point(156, 94)
        Me.Process1btn.Name = "Process1btn"
        Me.Process1btn.Size = New System.Drawing.Size(105, 60)
        Me.Process1btn.TabIndex = 1
        Me.Process1btn.Text = "Process 1"
        Me.Process1btn.UseVisualStyleBackColor = True
        '
        'Process2btn
        '
        Me.Process2btn.Location = New System.Drawing.Point(468, 94)
        Me.Process2btn.Name = "Process2btn"
        Me.Process2btn.Size = New System.Drawing.Size(94, 60)
        Me.Process2btn.TabIndex = 2
        Me.Process2btn.Text = "Process 2"
        Me.Process2btn.UseVisualStyleBackColor = True
        '
        'Process3btn
        '
        Me.Process3btn.Location = New System.Drawing.Point(314, 207)
        Me.Process3btn.Name = "Process3btn"
        Me.Process3btn.Size = New System.Drawing.Size(118, 56)
        Me.Process3btn.TabIndex = 3
        Me.Process3btn.Text = "Process 3"
        Me.Process3btn.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.MenuPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Logoutbtn As Button
    Friend WithEvents Process3btn As Button
    Friend WithEvents Process2btn As Button
    Friend WithEvents Process1btn As Button
End Class