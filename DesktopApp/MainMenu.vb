Public Class MainMenu
    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y
        Me.Top = 0
        Me.Left = 0
        MenuPanel.Height = y - (y / 9)
        MenuPanel.Width = x - (x / 9)
        MenuPanel.Left = (Me.Width - MenuPanel.Width) / 2
        MenuPanel.Top = (Me.Height - MenuPanel.Height) / 2
    End Sub

    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click
        Authentication.Show()
        Me.Hide()

    End Sub

    Private Sub Process1btn_Click(sender As Object, e As EventArgs) Handles Process1btn.Click
        Process1.Show()
        Me.Hide()

    End Sub

    Private Sub Process2btn_Click(sender As Object, e As EventArgs) Handles Process2btn.Click
        Process2.Show()
        Me.Hide()

    End Sub

    Private Sub Process3btn_Click(sender As Object, e As EventArgs) Handles Process3btn.Click
        Process3.Show()
        Me.Hide()
    End Sub
End Class