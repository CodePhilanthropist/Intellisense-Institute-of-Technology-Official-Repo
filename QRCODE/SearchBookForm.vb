Imports System.Data.OleDb
Public Class SearchBookForm

    Private Sub SearchBookForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
    End Sub

    Private Sub SearchBooks()
        sql = "SELECT * FROM BOOKS WHERE BOOK_TITLE LIKE '%" & Me.SearchBookTextBox.Text & "%' OR BOOK_AUTHOR LIKE '%" & Me.SearchBookTextBox.Text & "%'"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            BorrowersForm.BorrowerBookTitleTextBox.Text = dr("BOOK_TITLE")
            BorrowersForm.BorrowCategoryTextBox.Text = dr("BOOK_CATEGORY")

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SearchBookTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBookTextBox.TextChanged
        SearchBooks()
    End Sub

    Private Sub BookOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookOk.Click
        Me.Close()
    End Sub
End Class