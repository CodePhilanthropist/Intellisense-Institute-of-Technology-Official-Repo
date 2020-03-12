Imports System.Data.OleDb
Public Class RegisterBookTransaction
    Private Sub RegisterBookTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)

        Me.coolgreeterLabel.Text = LoginForm.cool_name
    End Sub
    Public fullname, librarian As String
    Private Sub BorrowerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerButton.Click
        BorrowersForm.Show()
    End Sub

    Private Sub LibraryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryButton.Click
        LibraryForm.Show()
    End Sub

    Private Sub TransactionsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsButton.Click

        TransactionForm.Show()
    End Sub

    Private Sub LogoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        End
    End Sub
End Class
