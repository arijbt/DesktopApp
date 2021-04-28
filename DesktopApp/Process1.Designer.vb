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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Process1))
        Me.ProcessPanel = New System.Windows.Forms.Panel()
        Me.returnbtn = New System.Windows.Forms.Button()
        Me.InnerPanel = New System.Windows.Forms.Panel()
        Me.param2tb = New System.Windows.Forms.TextBox()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.param4tb = New System.Windows.Forms.TextBox()
        Me.param3tb = New System.Windows.Forms.TextBox()
        Me.param1tb = New System.Windows.Forms.TextBox()
        Me.timetb = New System.Windows.Forms.TextBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.param6tb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.param8tb = New System.Windows.Forms.TextBox()
        Me.param7tb = New System.Windows.Forms.TextBox()
        Me.param5tb = New System.Windows.Forms.TextBox()
        Me.ProcessPanel.SuspendLayout()
        Me.InnerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessPanel
        '
        Me.ProcessPanel.BackColor = System.Drawing.Color.White
        Me.ProcessPanel.Controls.Add(Me.returnbtn)
        Me.ProcessPanel.Controls.Add(Me.InnerPanel)
        Me.ProcessPanel.Location = New System.Drawing.Point(43, 29)
        Me.ProcessPanel.Name = "ProcessPanel"
        Me.ProcessPanel.Size = New System.Drawing.Size(875, 554)
        Me.ProcessPanel.TabIndex = 0
        '
        'returnbtn
        '
        Me.returnbtn.BackColor = System.Drawing.Color.Transparent
        Me.returnbtn.FlatAppearance.BorderSize = 0
        Me.returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.returnbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.returnbtn.ForeColor = System.Drawing.Color.White
        Me.returnbtn.Image = CType(resources.GetObject("returnbtn.Image"), System.Drawing.Image)
        Me.returnbtn.Location = New System.Drawing.Point(20, 20)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(56, 44)
        Me.returnbtn.TabIndex = 28
        Me.returnbtn.UseVisualStyleBackColor = False
        '
        'InnerPanel
        '
        Me.InnerPanel.BackColor = System.Drawing.Color.White
        Me.InnerPanel.Controls.Add(Me.param6tb)
        Me.InnerPanel.Controls.Add(Me.Label7)
        Me.InnerPanel.Controls.Add(Me.Label8)
        Me.InnerPanel.Controls.Add(Me.Label9)
        Me.InnerPanel.Controls.Add(Me.Label10)
        Me.InnerPanel.Controls.Add(Me.param8tb)
        Me.InnerPanel.Controls.Add(Me.param7tb)
        Me.InnerPanel.Controls.Add(Me.param5tb)
        Me.InnerPanel.Controls.Add(Me.param2tb)
        Me.InnerPanel.Controls.Add(Me.Submitbtn)
        Me.InnerPanel.Controls.Add(Me.Label6)
        Me.InnerPanel.Controls.Add(Me.Label5)
        Me.InnerPanel.Controls.Add(Me.Label4)
        Me.InnerPanel.Controls.Add(Me.Label3)
        Me.InnerPanel.Controls.Add(Me.Label2)
        Me.InnerPanel.Controls.Add(Me.Label1)
        Me.InnerPanel.Controls.Add(Me.param4tb)
        Me.InnerPanel.Controls.Add(Me.param3tb)
        Me.InnerPanel.Controls.Add(Me.param1tb)
        Me.InnerPanel.Controls.Add(Me.timetb)
        Me.InnerPanel.Controls.Add(Me.DatePicker)
        Me.InnerPanel.Location = New System.Drawing.Point(79, 41)
        Me.InnerPanel.Name = "InnerPanel"
        Me.InnerPanel.Size = New System.Drawing.Size(752, 454)
        Me.InnerPanel.TabIndex = 34
        '
        'param2tb
        '
        Me.param2tb.Location = New System.Drawing.Point(253, 236)
        Me.param2tb.Name = "param2tb"
        Me.param2tb.Size = New System.Drawing.Size(100, 23)
        Me.param2tb.TabIndex = 14
        '
        'Submitbtn
        '
        Me.Submitbtn.BackColor = System.Drawing.Color.Gray
        Me.Submitbtn.FlatAppearance.BorderSize = 0
        Me.Submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submitbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Submitbtn.ForeColor = System.Drawing.Color.White
        Me.Submitbtn.Location = New System.Drawing.Point(630, 400)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(100, 33)
        Me.Submitbtn.TabIndex = 33
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(630, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Param 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(425, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Param 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(253, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Param 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(83, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Param 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(489, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(83, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date"
        '
        'param4tb
        '
        Me.param4tb.Location = New System.Drawing.Point(630, 236)
        Me.param4tb.Name = "param4tb"
        Me.param4tb.Size = New System.Drawing.Size(100, 23)
        Me.param4tb.TabIndex = 16
        '
        'param3tb
        '
        Me.param3tb.Location = New System.Drawing.Point(425, 236)
        Me.param3tb.Name = "param3tb"
        Me.param3tb.Size = New System.Drawing.Size(100, 23)
        Me.param3tb.TabIndex = 15
        '
        'param1tb
        '
        Me.param1tb.Location = New System.Drawing.Point(83, 236)
        Me.param1tb.Name = "param1tb"
        Me.param1tb.Size = New System.Drawing.Size(100, 23)
        Me.param1tb.TabIndex = 13
        '
        'timetb
        '
        Me.timetb.Location = New System.Drawing.Point(630, 105)
        Me.timetb.Name = "timetb"
        Me.timetb.Size = New System.Drawing.Size(100, 23)
        Me.timetb.TabIndex = 12
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(153, 105)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 23)
        Me.DatePicker.TabIndex = 0
        '
        'param6tb
        '
        Me.param6tb.Location = New System.Drawing.Point(253, 321)
        Me.param6tb.Name = "param6tb"
        Me.param6tb.Size = New System.Drawing.Size(100, 23)
        Me.param6tb.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(630, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Param 8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(425, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Param 7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(253, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Param 6"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(83, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 19)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Param 5"
        '
        'param8tb
        '
        Me.param8tb.Location = New System.Drawing.Point(630, 321)
        Me.param8tb.Name = "param8tb"
        Me.param8tb.Size = New System.Drawing.Size(100, 23)
        Me.param8tb.TabIndex = 37
        '
        'param7tb
        '
        Me.param7tb.Location = New System.Drawing.Point(425, 321)
        Me.param7tb.Name = "param7tb"
        Me.param7tb.Size = New System.Drawing.Size(100, 23)
        Me.param7tb.TabIndex = 36
        '
        'param5tb
        '
        Me.param5tb.Location = New System.Drawing.Point(83, 321)
        Me.param5tb.Name = "param5tb"
        Me.param5tb.Size = New System.Drawing.Size(100, 23)
        Me.param5tb.TabIndex = 34
        '
        'Process1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(973, 621)
        Me.Controls.Add(Me.ProcessPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Process1"
        Me.Text = "Process1"
        Me.ProcessPanel.ResumeLayout(False)
        Me.InnerPanel.ResumeLayout(False)
        Me.InnerPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents ProcessPanel As Panel
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents param4tb As TextBox
    Friend WithEvents param3tb As TextBox
    Friend WithEvents param2tb As TextBox
    Friend WithEvents param1tb As TextBox
    Friend WithEvents timetb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents returnbtn As Button
    Friend WithEvents Submitbtn As Button
    Friend WithEvents InnerPanel As Panel
    Friend WithEvents param6tb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents param8tb As TextBox
    Friend WithEvents param7tb As TextBox
    Friend WithEvents param5tb As TextBox
End Class