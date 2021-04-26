<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Process1
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
        Me.param4tb = New System.Windows.Forms.TextBox()
        Me.param1tb = New System.Windows.Forms.TextBox()
        Me.param5tb = New System.Windows.Forms.TextBox()
        Me.param8tb = New System.Windows.Forms.TextBox()
        Me.param7tb = New System.Windows.Forms.TextBox()
        Me.param6tb = New System.Windows.Forms.TextBox()
        Me.param3tb = New System.Windows.Forms.TextBox()
        Me.param2tb = New System.Windows.Forms.TextBox()
        Me.timetb = New System.Windows.Forms.TextBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.returnbtn = New System.Windows.Forms.Button()
        Me.ProcessPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessPanel
        '
        Me.ProcessPanel.BackColor = System.Drawing.Color.White
        Me.ProcessPanel.Controls.Add(Me.returnbtn)
        Me.ProcessPanel.Controls.Add(Me.Submitbtn)
        Me.ProcessPanel.Controls.Add(Me.param4tb)
        Me.ProcessPanel.Controls.Add(Me.param1tb)
        Me.ProcessPanel.Controls.Add(Me.param5tb)
        Me.ProcessPanel.Controls.Add(Me.param8tb)
        Me.ProcessPanel.Controls.Add(Me.param7tb)
        Me.ProcessPanel.Controls.Add(Me.param6tb)
        Me.ProcessPanel.Controls.Add(Me.param3tb)
        Me.ProcessPanel.Controls.Add(Me.param2tb)
        Me.ProcessPanel.Controls.Add(Me.timetb)
        Me.ProcessPanel.Controls.Add(Me.DatePicker)
        Me.ProcessPanel.Location = New System.Drawing.Point(43, 29)
        Me.ProcessPanel.Name = "ProcessPanel"
        Me.ProcessPanel.Size = New System.Drawing.Size(703, 464)
        Me.ProcessPanel.TabIndex = 0
        '
        'param4tb
        '
        Me.param4tb.Location = New System.Drawing.Point(535, 211)
        Me.param4tb.Name = "param4tb"
        Me.param4tb.Size = New System.Drawing.Size(93, 23)
        Me.param4tb.TabIndex = 9
        '
        'param1tb
        '
        Me.param1tb.Location = New System.Drawing.Point(72, 211)
        Me.param1tb.Name = "param1tb"
        Me.param1tb.Size = New System.Drawing.Size(93, 23)
        Me.param1tb.TabIndex = 8
        '
        'param5tb
        '
        Me.param5tb.Location = New System.Drawing.Point(72, 304)
        Me.param5tb.Name = "param5tb"
        Me.param5tb.Size = New System.Drawing.Size(93, 23)
        Me.param5tb.TabIndex = 7
        '
        'param8tb
        '
        Me.param8tb.Location = New System.Drawing.Point(535, 304)
        Me.param8tb.Name = "param8tb"
        Me.param8tb.Size = New System.Drawing.Size(93, 23)
        Me.param8tb.TabIndex = 6
        '
        'param7tb
        '
        Me.param7tb.Location = New System.Drawing.Point(373, 304)
        Me.param7tb.Name = "param7tb"
        Me.param7tb.Size = New System.Drawing.Size(93, 23)
        Me.param7tb.TabIndex = 5
        '
        'param6tb
        '
        Me.param6tb.Location = New System.Drawing.Point(222, 304)
        Me.param6tb.Name = "param6tb"
        Me.param6tb.Size = New System.Drawing.Size(93, 23)
        Me.param6tb.TabIndex = 4
        '
        'param3tb
        '
        Me.param3tb.Location = New System.Drawing.Point(373, 211)
        Me.param3tb.Name = "param3tb"
        Me.param3tb.Size = New System.Drawing.Size(93, 23)
        Me.param3tb.TabIndex = 3
        '
        'param2tb
        '
        Me.param2tb.Location = New System.Drawing.Point(222, 211)
        Me.param2tb.Name = "param2tb"
        Me.param2tb.Size = New System.Drawing.Size(93, 23)
        Me.param2tb.TabIndex = 2
        '
        'timetb
        '
        Me.timetb.Location = New System.Drawing.Point(506, 72)
        Me.timetb.Name = "timetb"
        Me.timetb.Size = New System.Drawing.Size(93, 23)
        Me.timetb.TabIndex = 1
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(84, 70)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 23)
        Me.DatePicker.TabIndex = 0
        '
        'Submitbtn
        '
        Me.Submitbtn.Location = New System.Drawing.Point(506, 402)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(134, 36)
        Me.Submitbtn.TabIndex = 10
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = True
        '
        'returnbtn
        '
        Me.returnbtn.Location = New System.Drawing.Point(506, 350)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(134, 36)
        Me.returnbtn.TabIndex = 11
        Me.returnbtn.Text = "return"
        Me.returnbtn.UseVisualStyleBackColor = True
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
        Me.ProcessPanel.ResumeLayout(False)
        Me.ProcessPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents ProcessPanel As Panel
    Friend WithEvents param4tb As TextBox
    Friend WithEvents param1tb As TextBox
    Friend WithEvents param5tb As TextBox
    Friend WithEvents param8tb As TextBox
    Friend WithEvents param7tb As TextBox
    Friend WithEvents param6tb As TextBox
    Friend WithEvents param3tb As TextBox
    Friend WithEvents param2tb As TextBox
    Friend WithEvents timetb As TextBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents returnbtn As Button
    Friend WithEvents Submitbtn As Button
End Class