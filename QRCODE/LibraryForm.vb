Imports System.Data.OleDb
Public Class LibraryForm
    Dim cat As String
    Private Sub LibraryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateBooks()

    End Sub

    Private Sub populateBooks()
        sql = "SELECT* FROM BOOKS ORDER BY BOOK_ID ASC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.LibraryDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub CountBookID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS BOK_ID FROM BOOKS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("BOK_ID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.LibraryBookNumberTextBox.Text = cmid + 1
    End Sub

    Private Sub LibraryAddBookButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryAddBookButton.Click
        CountBookID()
        Me.LibraryBookTitleTextBox.Clear()
        Me.LibraryBookAuthorTextBox.Clear()
        Me.LibraryCategoryTextBox.Clear()
        Me.LibraryBookISBTextBox.Clear()
        Me.LibraryBookTitleTextBox.Focus()

    End Sub

    Private Sub LibrarySaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibrarySaveButton.Click
        sql = "INSERT INTO BOOKS(BOOK_ID, BOOK_TITLE, BOOK_AUTHOR, BOOK_ISB, BOOK_CATEGORY)VALUES(" & CInt(Me.LibraryBookNumberTextBox.Text) & ", '" & Me.LibraryBookTitleTextBox.Text & "', '" & Me.LibraryBookAuthorTextBox.Text & "'," & CInt(Me.LibraryBookISBTextBox.Text) & ", '" & Me.LibraryCategoryTextBox.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("New book has been added!")
            populateBooks()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LibraryUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryUpdateButton.Click
        sql = "UPDATE BOOKS SET BOOK_TITLE='" & Me.LibraryBookTitleTextBox.Text & "', BOOK_AUTHOR='" & Me.LibraryBookAuthorTextBox.Text & "', BOOK_ISB=" & CInt(Me.LibraryBookISBTextBox.Text) & ", BOOK_CATEGORY='" & Me.LibraryCategoryTextBox.Text & "' WHERE BOOK_ID=" & CInt(Me.LibraryBookNumberTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("The book details has been updated!")
            populateBooks()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LibraryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LibraryDataGridView.CellContentClick
        sql = "SELECT * FROM BOOKS WHERE BOOK_ID=" & CInt(LibraryDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.LibraryBookNumberTextBox.Text = dr("BOOK_ID")
            Me.LibraryBookTitleTextBox.Text = dr("BOOK_TITLE")
            Me.LibraryBookAuthorTextBox.Text = dr("BOOK_AUTHOR")
            Me.LibraryBookISBTextBox.Text = dr("BOOK_ISB")
            Me.LibraryCategoryTextBox.Text = dr("BOOK_CATEGORY")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub LibraryExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryExitButton.Click
        Me.Close()
    End Sub
End Class