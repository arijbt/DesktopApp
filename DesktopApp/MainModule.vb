Imports System.Globalization

Public Class MainModule
    Sub Main()
        Application.Run(New Authentication())
    End Sub
    Public Shared Sub DecOnly(tb As TextBox)
        If Len(tb.Text) = 0 Then
            tb.ForeColor = Color.Black
            Exit Sub
        ElseIf (IsNumeric(tb.Text)) = False Then
            'tb.BackColor = Color.Red
            tb.ForeColor = Color.Red
        Else
            tb.ForeColor = Color.Black
            tb.Text = String.Format("{0:N2}", Double.Parse(tb.Text))

            Exit Sub
        End If

    End Sub
    Public Shared Sub StringOnly(tb As TextBox)
        If Len(tb.Text) = 0 Then
            tb.ForeColor = Color.Black
            Exit Sub
        ElseIf (IsNumeric(tb.Text)) = True Then
            'tb.BackColor = Color.Red
            tb.ForeColor = Color.Red
        Else
            tb.ForeColor = Color.Black
            Exit Sub
        End If

    End Sub

    Public Shared Sub IntOnly(tb As TextBox)
        Dim TestInt As Integer
        If Integer.TryParse(tb.Text, TestInt) Then
            tb.ForeColor = Color.Black
            Exit Sub
        Else
            tb.ForeColor = Color.Red
        End If
    End Sub

    Public Shared Sub TimeValidation(tb As TextBox)

        Dim provider As CultureInfo = CultureInfo.InvariantCulture
        Try
            Date.ParseExact(tb.Text, "HH:mm", provider)
            tb.ForeColor = Color.Black
        Catch e As FormatException
            tb.ForeColor = Color.Red
        End Try

    End Sub

End Class
