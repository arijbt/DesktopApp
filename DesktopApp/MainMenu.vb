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
        Me.Hide()
        Authentication.Show()
    End Sub

    Private Sub Process1btn_Click(sender As Object, e As EventArgs) Handles Process1btn.Click
        Me.Hide()
        Process1.Show()
    End Sub

    Private Sub Process2btn_Click(sender As Object, e As EventArgs) Handles Process2btn.Click
        Me.Hide()
        Process2.Show()
    End Sub

    Private Sub Process3btn_Click(sender As Object, e As EventArgs) Handles Process3btn.Click
        Me.Hide()
        Process3.Show()
    End Sub
End Class