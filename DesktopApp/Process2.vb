Public Class Process2
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

    Private Sub MenuPanel_Paint(sender As Object, e As PaintEventArgs) Handles ProcessPanel.Paint

    End Sub
End Class