Imports System.Data.OleDb
Public Class TransactionForm
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
   
    Private Sub TransactionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateTransaction()

    End Sub

    Private Sub populateTransaction()
        sql = "SELECT * FROM TRANSACTION ORDER BY TRANSACTION_NO ASC"
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
    Private Sub LibraryExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryExitButton.Click
        Me.Close()
    End Sub

    Private Sub TransactionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TransactionDataGridView.CellContentClick
        sql = "SELECT * FROM TRANSACTION WHERE TRANSACTION_NO=" & CInt(TransactionDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.TborrowernameTextBox.Text = dr("STUD_COUNT")
            Me.TbookidTextBox.Text = dr("BOOK_ID")
            Me.TlibrarianTextBox.Text = dr("USER_ID")
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