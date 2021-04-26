Imports System.Globalization
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Authentication
    Dim connection As New System.Data.SqlClient.SqlConnection("Server= DESKTOP-OGLIQOT; Database = TestDesktopApp; Integrated Security =True")
    Private Sub Authentication_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y
        Me.Top = 0
        Me.Left = 0

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
    Private Function StringtoMD5(ByVal Content As String) As String
        Dim M5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = M5.ComputeHash(ByteString)
        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s_psw As String
        s_psw = StringtoMD5(txtPass.Text)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim command As New SqlCommand("SELECT * From Users WHERE Username='" & TextBox1.Text & "'And psw= '" & s_psw & "';", connection)

        Dim mydata As SqlDataReader
        mydata = command.ExecuteReader()
        If mydata.HasRows = 0 Then
            MsgBox("Sorry! We can't find your Username and Password. Verify your login parameters")
        Else
            'to do
            txtPass.Clear()
            TextBox1.Clear()
            Me.Hide()
            MainMenu.Show()

        End If

        connection.Close()
    End Sub

    Private Sub Authentication_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPass.PasswordChar = "*"
    End Sub

End Class