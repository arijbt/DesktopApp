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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.param4tb = New System.Windows.Forms.TextBox()
        Me.param3tb = New System.Windows.Forms.TextBox()
        Me.param2tb = New System.Windows.Forms.TextBox()
        Me.param1tb = New System.Windows.Forms.TextBox()
        Me.timetb = New System.Windows.Forms.TextBox()
        Me.returnbtn = New System.Windows.Forms.Button()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProcessPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessPanel
        '
        Me.ProcessPanel.BackColor = System.Drawing.Color.White
        Me.ProcessPanel.Controls.Add(Me.Label6)
        Me.ProcessPanel.Controls.Add(Me.Label5)
        Me.ProcessPanel.Controls.Add(Me.Label4)
        Me.ProcessPanel.Controls.Add(Me.Label3)
        Me.ProcessPanel.Controls.Add(Me.Label2)
        Me.ProcessPanel.Controls.Add(Me.Label1)
        Me.ProcessPanel.Controls.Add(Me.param4tb)
        Me.ProcessPanel.Controls.Add(Me.param3tb)
        Me.ProcessPanel.Controls.Add(Me.param2tb)
        Me.ProcessPanel.Controls.Add(Me.param1tb)
        Me.ProcessPanel.Controls.Add(Me.timetb)
        Me.ProcessPanel.Controls.Add(Me.returnbtn)
        Me.ProcessPanel.Controls.Add(Me.Submitbtn)
        Me.ProcessPanel.Controls.Add(Me.DatePicker)
        Me.ProcessPanel.Location = New System.Drawing.Point(43, 29)
        Me.ProcessPanel.Name = "ProcessPanel"
        Me.ProcessPanel.Size = New System.Drawing.Size(703, 464)
        Me.ProcessPanel.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(574, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Param 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Param 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Param 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Param 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(506, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Date"
        '
        'param4tb
        '
        Me.param4tb.Location = New System.Drawing.Point(574, 190)
        Me.param4tb.Name = "param4tb"
        Me.param4tb.Size = New System.Drawing.Size(100, 23)
        Me.param4tb.TabIndex = 16
        '
        'param3tb
        '
        Me.param3tb.Location = New System.Drawing.Point(425, 190)
        Me.param3tb.Name = "param3tb"
        Me.param3tb.Size = New System.Drawing.Size(100, 23)
        Me.param3tb.TabIndex = 15
        '
        'param2tb
        '
        Me.param2tb.Location = New System.Drawing.Point(253, 190)
        Me.param2tb.Name = "param2tb"
        Me.param2tb.Size = New System.Drawing.Size(100, 23)
        Me.param2tb.TabIndex = 14
        '
        'param1tb
        '
        Me.param1tb.Location = New System.Drawing.Point(87, 190)
        Me.param1tb.Name = "param1tb"
        Me.param1tb.Size = New System.Drawing.Size(100, 23)
        Me.param1tb.TabIndex = 13
        '
        'timetb
        '
        Me.timetb.Location = New System.Drawing.Point(574, 72)
        Me.timetb.Name = "timetb"
        Me.timetb.Size = New System.Drawing.Size(100, 23)
        Me.timetb.TabIndex = 12
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
        'Submitbtn
        '
        Me.Submitbtn.Location = New System.Drawing.Point(506, 402)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(134, 36)
        Me.Submitbtn.TabIndex = 10
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = True
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(153, 72)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 23)
        Me.DatePicker.TabIndex = 0
        '
        'Process3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.ProcessPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Process3"
        Me.Text = "Process1"
        Me.ProcessPanel.ResumeLayout(False)
        Me.ProcessPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents ProcessPanel As Panel
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents returnbtn As Button
    Friend WithEvents Submitbtn As Button
    Friend WithEvents param4tb As TextBox
    Friend WithEvents param3tb As TextBox
    Friend WithEvents param2tb As TextBox
    Friend WithEvents param1tb As TextBox
    Friend WithEvents timetb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class