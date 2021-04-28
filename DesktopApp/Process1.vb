Imports System.Data.SqlClient
Imports System.Globalization
Public Class Process1

    Dim Tester As Boolean
    Dim connection As New SqlConnection("Server= DESKTOP-OGLIQOT; Database = TestDesktopApp; Integrated Security =True")
    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y
        Me.Top = 0
        Me.Left = 0
        ProcessPanel.Height = y - (y / 9)
        ProcessPanel.Width = x - (x / 9)
        ProcessPanel.Left = (Me.Width - ProcessPanel.Width) / 2
        ProcessPanel.Top = (Me.Height - ProcessPanel.Height) / 2
        InnerPanel.Width = ProcessPanel.Width - (ProcessPanel.Width / 3)
        InnerPanel.Height = ProcessPanel.Height - (ProcessPanel.Height / 3)
        InnerPanel.Left = (ProcessPanel.Width - InnerPanel.Width) / 2
        InnerPanel.Top = (ProcessPanel.Height - InnerPanel.Height) / 2
        Submitbtn.Left = param4tb.Left

    End Sub

    Private Sub checker()
        Dim TestInt As Integer
        Dim provider As CultureInfo = CultureInfo.InvariantCulture
        If (Integer.TryParse(param5tb.Text, TestInt) Or Len(param5tb.Text) = 0) And (Integer.TryParse(param6tb.Text, TestInt) Or Len(param6tb.Text) = 0) And IsNumeric(param7tb.Text) = False And IsNumeric(param8tb.Text) = False And (IsNumeric(param1tb.Text) = True Or Len(param1tb.Text) = 0) And (IsNumeric(param2tb.Text) = True Or Len(param2tb.Text) = 0) And (IsNumeric(param3tb.Text) = True Or Len(param3tb.Text) = 0) And (IsNumeric(param4tb.Text) = True Or Len(param4tb.Text) = 0) Then

            Try
                Date.ParseExact(timetb.Text, "HH:mm", provider)
                Tester = True
            Catch e As FormatException
                Tester = False
            End Try


        Else
            Tester = False
        End If
    End Sub
    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        Dim p1 As Double = 0
        Dim p2 As Double = 0
        Dim p3 As Double = 0
        Dim p4 As Double = 0
        If param1tb.Text <> "" Then
            p1 = Double.Parse(param1tb.Text)
        End If
        If param2tb.Text <> "" Then
            p2 = Double.Parse(param2tb.Text)
        End If
        If param3tb.Text <> "" Then
            p3 = Double.Parse(param3tb.Text)
        End If
        If param4tb.Text <> "" Then
            p4 = Double.Parse(param4tb.Text)
        End If

        checker()
        If Tester = False Then
            MsgBox("Submission Not valid, verify fields")
        Else
            Dim userid As Integer = 1
            Dim command As New SqlCommand("insert into Process1(userid, Date,Time, Param1, Param2, Param3, Param4, Param5, Param6, Param7, Param8) values ('" & userid & "','" & DatePicker.Value & "', '" & timetb.Text & "', '" & p1 & "', '" & p2 & "', '" & p3 & "', '" & p4 & "', '" & param5tb.Text & "', '" & param6tb.Text & "', '" & param7tb.Text & "', '" & param8tb.Text & "')", connection)

            If connection.State = ConnectionState.Closed Then
                connection.Open()

            End If


            If command.ExecuteNonQuery = 1 Then
                MsgBox("Submission OK:" & vbCrLf & "Date: " & DatePicker.Value.ToShortDateString() & vbCrLf & "Time: " & timetb.Text & vbCrLf & "Param 1: " & param1tb.Text & vbCrLf & "Param 2: " & param2tb.Text & vbCrLf & "Param 3: " & param3tb.Text & vbCrLf & "Param 4: " & param4tb.Text & vbCrLf & "Param 5: " & param5tb.Text & vbCrLf & "Param 6: " & param6tb.Text & vbCrLf & "Param 7: " & param7tb.Text & vbCrLf & "Param 8: " & param8tb.Text)
                DatePicker.Value = Now
                timetb.Clear()
                param1tb.Clear()
                param2tb.Clear()
                param3tb.Clear()
                param4tb.Clear()
                param5tb.Clear()
                param6tb.Clear()
                param7tb.Clear()
                param8tb.Clear()
            Else
                MsgBox("Submission Not valid, verify connection")
            End If
            connection.Close()

        End If
    End Sub

    Private Sub param1tb_GotFocus(sender As Object, e As EventArgs) Handles param1tb.GotFocus
        param1tb.ForeColor = Color.Black

    End Sub

    Private Sub param2tb_GotFocus(sender As Object, e As EventArgs) Handles param2tb.GotFocus
        param2tb.ForeColor = Color.Black

    End Sub

    Private Sub param3tb_GotFocus(sender As Object, e As EventArgs) Handles param3tb.GotFocus
        param3tb.ForeColor = Color.Black

    End Sub

    Private Sub param4tb_GotFocus(sender As Object, e As EventArgs) Handles param4tb.GotFocus
        param4tb.ForeColor = Color.Black

    End Sub

    Private Sub param5tb_GotFocus(sender As Object, e As EventArgs) Handles param5tb.GotFocus
        param5tb.ForeColor = Color.Black

    End Sub

    Private Sub param6tb_GotFocus(sender As Object, e As EventArgs) Handles param6tb.GotFocus
        param6tb.ForeColor = Color.Black

    End Sub

    Private Sub param7tb_GotFocus(sender As Object, e As EventArgs) Handles param7tb.GotFocus
        param7tb.ForeColor = Color.Black

    End Sub

    Private Sub param8tb_GotFocus(sender As Object, e As EventArgs) Handles param8tb.GotFocus
        param8tb.ForeColor = Color.Black

    End Sub


    Private Sub timetb_LostFocus(sender As Object, e As EventArgs) Handles timetb.LostFocus
        MainModule.TimeValidation(timetb)

    End Sub

    Private Sub param1tb_LostFocus(sender As Object, e As EventArgs) Handles param1tb.LostFocus
        MainModule.DecOnly(param1tb)
    End Sub

    Private Sub param2tb_LostFocus(sender As Object, e As EventArgs) Handles param2tb.LostFocus
        MainModule.DecOnly(param2tb)
    End Sub

    Private Sub param3tb_LostFocus(sender As Object, e As EventArgs) Handles param3tb.LostFocus
        MainModule.DecOnly(param3tb)
    End Sub

    Private Sub param4tb_LostFocus(sender As Object, e As EventArgs) Handles param4tb.LostFocus
        MainModule.DecOnly(param4tb)
    End Sub

    Private Sub param5tb_LostFocus(sender As Object, e As EventArgs) Handles param5tb.LostFocus
        MainModule.IntOnly(param5tb)
    End Sub

    Private Sub param6tb_LostFocus(sender As Object, e As EventArgs) Handles param6tb.LostFocus
        MainModule.IntOnly(param6tb)
    End Sub

    Private Sub param7tb_LostFocus(sender As Object, e As EventArgs) Handles param7tb.LostFocus
        MainModule.StringOnly(param7tb)
    End Sub

    Private Sub param8tb_LostFocus(sender As Object, e As EventArgs) Handles param8tb.LostFocus
        MainModule.StringOnly(param8tb)
    End Sub

    Private Sub timetb_GotFocus(sender As Object, e As EventArgs) Handles timetb.GotFocus
        If timetb.Text = "" Then
            timetb.Text = Now.Hour() & ":" & Now.Minute()
        Else
            timetb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub DatePicker_LostFocus(sender As Object, e As EventArgs) Handles DatePicker.LostFocus
        If DatePicker.Value.ToShortDateString() > Now.Date.ToShortDateString() Then
            MessageBox.Show("Invalid date. The date will be set to today's date again!")
            DatePicker.Value = Now
        End If
    End Sub

    Private Sub DatePicker_GotFocus(sender As Object, e As EventArgs) Handles DatePicker.GotFocus
        DatePicker.CalendarForeColor = Color.Black
    End Sub

    Private Sub returnbtn_Click_1(sender As Object, e As EventArgs) Handles returnbtn.Click
        MainMenu.Show()
        Me.Hide()
        DatePicker.Value = Now
        timetb.Clear()
        param1tb.Clear()
        param2tb.Clear()
        param3tb.Clear()
        param4tb.Clear()
        param5tb.Clear()
        param6tb.Clear()
        param7tb.Clear()
        param8tb.Clear()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles param7tb.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles param8tb.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles param6tb.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles param5tb.TextChanged

    End Sub
End Class