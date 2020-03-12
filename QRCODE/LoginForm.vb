
Imports System.Data.OleDb

Public Class LoginForm



    Dim countlog As Integer
    Public username_login, password_login, cool_name As String
    Public i As Integer
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)

        cool()
    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Dim inform As DialogResult
        If countlog < 2 Then
            sql = "SELECT * FROM USERACCOUNT WHERE USERNAME='" & Trim(Me.usernameTextBox.Text) & "'" &
                "AND PASSWORD='" & Trim(Me.passwordTextBox.Text) & "'"
            cmd = New OleDbCommand(sql, con)
            Try
                dr = cmd.ExecuteReader()
                dr.Read()
                i = dr("USER_ID")
                username_login = dr("USERNAME")
                password_login = dr("PASSWORD")
                cool_name = dr("COOL_NAME")
                dr.Close()
                MessageBox.Show("You are successfully log-in!")
                RegisterBookTransaction.Show()
                Me.Hide()
            Catch io As InvalidOperationException
                MessageBox.Show("Invalid Account!")
                username_login = ""
                password_login = ""
                i = 0
                countlog = countlog + 1
                clearTb()
            Catch ex As OleDbException
                MessageBox.Show(ex.Message.ToString())
            End Try
        Else
            inform = MessageBox.Show("Sorry, the system will exit for security purposes!", "Notice Message", MessageBoxButtons.OK)
            If inform = DialogResult.OK Then
                End
            End If
        End If
    End Sub
    Private Sub clearTb()
        Me.usernameTextBox.Clear()
        Me.passwordTextBox.Clear()
        Me.usernameTextBox.Focus()
    End Sub

    Private Sub cool()
        Me.usernameTextBox.Focus()
    End Sub


End Class