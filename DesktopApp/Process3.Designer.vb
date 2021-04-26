<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Process3
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
        Me.ProcessPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ProcessPanel
        '
        Me.ProcessPanel.BackColor = System.Drawing.Color.White
        Me.ProcessPanel.Location = New System.Drawing.Point(43, 29)
        Me.ProcessPanel.Name = "ProcessPanel"
        Me.ProcessPanel.Size = New System.Drawing.Size(703, 464)
        Me.ProcessPanel.TabIndex = 0
        '
        'Process1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.ProcessPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Process1"
        Me.Text = "Process1"
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents ProcessPanel As Panel
End Class