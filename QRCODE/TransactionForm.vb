Imports System.Data.OleDb
Public Class TransactionForm
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
   
    Private Sub TransactionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateTransaction()

    End Sub

    Private Sub populateTransaction()
        sql = "SELECT BORROWERS.BORROW_ID, BORROWERS.BOOK_TITLE, BORROWERS.BORROWER_NAME, STUDENTS.STUD_ID, STUDENTS.STUD_SECTION, BOOKS.BOOK_AUTHOR FROM ((BORROWERS INNER JOIN STUDENTS ON BORROWERS.STUD_ID=STUDENTS.STUD_ID) INNER JOIN BOOKS ON BORROWERS.BOOK_ID=BOOKS.BOOK_ID) ORDER BY BORROWERS.BORROW_ID DESC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.TransactionDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub SaveQRButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveQRButton.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub TransactionSearchBorrowerTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionSearchBorrowerTextBox.TextChanged
        'SearchTransactions()
    End Sub


    Private Sub TransactionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TransactionDataGridView.CellContentClick
        sql = "SELECT BORROWERS.BORROW_ID, BORROWERS.BORROWER_NAME, BORROWERS.BOOK_TITLE, BOOKS.BOOK_AUTHOR, BOOKS.BOOK_CATEGORY, BOOKS.BOOK_ISB, STUDENTS.STUD_SECTION, STUDENTS.STUD_COUNT, BOOKS.BOOK_ID, BORROWERS.RECEIPT_NO FROM ((BORROWERS INNER JOIN STUDENTS ON BORROWERS.STUD_ID=STUDENTS.STUD_ID) INNER JOIN BOOKS ON BORROWERS.BOOK_ID=BOOKS.BOOK_ID) WHERE BORROW_ID=" & CInt(TransactionDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.TborrowernameTextBox.Text = dr("BORROWER_NAME")
            Me.TbooktitleTextBox.Text = dr("BOOK_TITLE")
            Me.TbookauthorTextBox.Text = dr("BOOK_AUTHOR")
            Me.TbookcategoryTextBox.Text = dr("BOOK_CATEGORY")
            Me.TbookisbTextBox.Text = dr("BOOK_ISB")
            Me.TsectionTextBox.Text = dr("STUD_SECTION")
            Me.TstudentcountTextBox.Text = dr("STUD_COUNT")
            Me.TreceiptnumberTextBox.Text = dr("RECEIPT_NO")
            Me.TbookidTextBox.Text = dr("BOOK_ID")
            Me.tborrowidTextBox.Text = dr("BORROW_ID")

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

   
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TreceiptnumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreceiptnumberTextBox.TextChanged
        PictureBox1.BackgroundImage = QR_Generator.Encode(TreceiptnumberTextBox.Text)
    End Sub
End Class