Imports System.Data.SqlClient
Imports System.Globalization
Public Class Process2

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
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        DatePicker.Value = Now
        timetb.Clear()
        param1tb.Clear()
        param2tb.Clear()
        param3tb.Clear()
        param4tb.Clear()
        MainMenu.Show()
        Me.Hide()

    End Sub
    Private Sub checker()
        Dim provider As CultureInfo = CultureInfo.InvariantCulture
        If (IsNumeric(param1tb.Text) = False) And (IsNumeric(param2tb.Text) = True Or Len(param2tb.Text) = 0) And (IsNumeric(param3tb.Text) = True Or Len(param3tb.Text) = 0) And (IsNumeric(param4tb.Text) = True Or Len(param4tb.Text) = 0) Then

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
        Dim p2 As Double = 0
        Dim p3 As Double = 0
        Dim p4 As Double = 0
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
            Dim command As New SqlCommand("insert into Process2(userid, Date,Time, Param1, Param2, Param3, Param4) values ('" & userid & "','" & DatePicker.Value & "', '" & timetb.Text & "', '" & param1tb.Text & "', '" & p2 & "', '" & p3 & "', '" & p4 & "')", connection)

            If connection.State = ConnectionState.Closed Then
                connection.Open()

            End If


            If command.ExecuteNonQuery = 1 Then
                MsgBox("Submission OK:" & vbCrLf & "Date: " & DatePicker.Value.ToShortDateString() & vbCrLf & "Time: " & timetb.Text & vbCrLf & "Param 1: " & param1tb.Text & vbCrLf & "Param 2: " & param2tb.Text & vbCrLf & "Param 3: " & param3tb.Text & vbCrLf & "Param 4: " & param4tb.Text)
                DatePicker.Value = Now
                timetb.Clear()
                param1tb.Clear()
                param2tb.Clear()
                param3tb.Clear()
                param4tb.Clear()
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


    Private Sub timetb_GotFocus(sender As Object, e As EventArgs) Handles timetb.GotFocus
        If timetb.Text = "" Then
            timetb.Text = Now.Hour() & ":" & Now.Minute()
        Else
            timetb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub timetb_LostFocus(sender As Object, e As EventArgs) Handles timetb.LostFocus
        MainModule.TimeValidation(timetb)

    End Sub

    Private Sub param1tb_LostFocus(sender As Object, e As EventArgs) Handles param1tb.LostFocus
        MainModule.StringOnly(param1tb)
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
    Private Sub DatePicker_LostFocus(sender As Object, e As EventArgs) Handles DatePicker.LostFocus
        If DatePicker.Value.ToShortDateString() > Now.Date.ToShortDateString() Then
            MessageBox.Show("Invalid date. The date will be set to today's date again!")
            DatePicker.Value = Now
        End If
    End Sub

End Class