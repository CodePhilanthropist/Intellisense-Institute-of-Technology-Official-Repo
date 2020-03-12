Imports System.Data.OleDb
Public Class BorrowersForm
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateBorrowers()
        Me.greetLabel.Text = LoginForm.cool_name
    End Sub
   
    Private Sub populateBorrowers()
        sql = "SELECT BORROW_ID, BOOK_TITLE, BORROWER_NAME, STUD_ID, BOOK_CATEGORY, R_DATE, B_DATE, RECEIPT_NO FROM BORROWERS ORDER BY BORROW_ID DESC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.BorrowerDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub CountBorrowID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS BOR_ID FROM BORROWERS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("BOR_ID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.BorrowerBookNumberTextBox.Text = cmid + 1
        Me.BorrowerBookIDTextBox.Text = cmid + 1
        Me.studcountTextBox.Text = cmid + 1
    End Sub

    Private Sub SaveButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ClearButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        BorrowerReceiptTextBox.Clear()
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub BorrowerGenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerGenerateButton.Click
    '    Try
    '        PictureBox1.Image = QR_Generator.Encode(BorrowerReceiptTextBox.Text)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Private Sub BorrowRegisterSTudentsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowRegisterSTudentsButton.Click
        RegisterStudentsForm.Show()
    End Sub

    
    Private Sub BorrowerAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerAddButton.Click
        CountBorrowID()
        Me.BorrowerBookTitleTextBox.Clear()
        Me.BorrowerNameTextBox.Clear()
        Me.BorrowerIDTextBox.Clear()
        Me.BorrowCategoryTextBox.Clear()
        'Me.BorrowerReturnDateTimePicker = Nothing
        'Me.BorrowerDateTimePicker = Nothing
        Me.BorrowerReceiptTextBox.Text = "RECEIPT" & BorrowerBookNumberTextBox.Text & Today.Day & Today.Month & Today.Year
        Me.BorrowerBookTitleTextBox.Focus()
    End Sub


    
    Private Sub BorrowerSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerSaveButton.Click
        sql = "INSERT INTO BORROWERS(BORROW_ID, BOOK_ID, STUD_COUNT, BOOK_TITLE, BORROWER_NAME, STUD_ID, BOOK_CATEGORY, R_DATE, B_DATE, RECEIPT_NO) VALUES (" & CInt(BorrowerBookNumberTextBox.Text) & ", " & CInt(Me.BorrowerBookIDTextBox.Text) & ", " & CInt(Me.studcountTextBox.Text) & ", '" & Me.BorrowerBookTitleTextBox.Text & "', '" & Me.BorrowerNameTextBox.Text & "', '" & Me.BorrowerIDTextBox.Text & "', '" & Me.BorrowCategoryTextBox.Text & "', '" & Me.BorrowerReturnDateTimePicker.Text & "', '" & Me.BorrowerDateTimePicker.Text & "', '" & Me.BorrowerReceiptTextBox.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("New borrow transaction has been added!")
            populateBorrowers()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    
    Private Sub BorrowerUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerUpdateButton.Click
        sql = "UPDATE BORROWERS SET BOOK_ID='" & CInt(Me.BorrowerBookIDTextBox.Text) & "', STUD_COUNT='" & CInt(Me.studcountTextBox.Text) & "', BOOK_TITLE='" & Me.BorrowerBookTitleTextBox.Text & "', BORROWER_NAME='" & Me.BorrowerNameTextBox.Text & "', STUD_ID='" & Me.BorrowerIDTextBox.Text & "', BOOK_CATEGORY='" & Me.BorrowCategoryTextBox.Text & "', R_DATE='" & Me.BorrowerReturnDateTimePicker.Text & "', B_DATE='" & Me.BorrowerDateTimePicker.Text & "', RECEIPT_NO='" & Me.BorrowerReceiptTextBox.Text & "' WHERE BORROW_ID=" & CInt(Me.BorrowerBookNumberTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("The borrower details has been updated!")
            populateBorrowers()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


    Private Sub BorrowerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BorrowerDataGridView.CellContentClick
        sql = "SELECT * FROM BORROWERS WHERE BORROW_ID=" & CInt(BorrowerDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.BorrowerBookNumberTextBox.Text = dr("BORROW_ID")
            Me.BorrowerBookTitleTextBox.Text = dr("BOOK_TITLE")
            Me.BorrowerNameTextBox.Text = dr("BORROWER_NAME")
            Me.BorrowerIDTextBox.Text = dr("STUD_ID")
            Me.BorrowCategoryTextBox.Text = dr("BOOK_CATEGORY")
            Me.BorrowerReturnDateTimePicker.Text = dr("R_DATE")
            Me.BorrowerDateTimePicker.Text = dr("B_DATE")
            Me.BorrowerReceiptTextBox.Text = dr("RECEIPT_NO")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub


    Private Sub LibraryBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LibraryBack.LinkClicked
        Me.Close()
    End Sub

    Private Sub SearchBookTitleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBookTitleButton.Click
        SearchBookForm.Show()
    End Sub

    Private Sub BorrowerReceiptTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerReceiptTextBox.TextChanged
        PictureBox1.BackgroundImage = QR_Generator.Encode(BorrowerReceiptTextBox.Text)
    End Sub


    Private Sub SearchBorrowNameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBorrowNameButton.Click
        SearchBorrowerForm.Show()
    End Sub
End Class
