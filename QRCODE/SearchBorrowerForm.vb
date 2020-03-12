Imports System.Data.OleDb

Public Class SearchBorrowerForm
    Public fullname As String
    Private Sub SearchBorrowerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
    End Sub

    Private Sub SearchBorrowers()
        sql = "SELECT * FROM STUDENTS WHERE STUD_LASTNAME LIKE '%" & Me.SearchBorrowerTextBox.Text & "%' OR STUD_FIRSTNAME LIKE '%" & Me.SearchBorrowerTextBox.Text & "%' OR STUD_MIDDLENAME LIKE '%" & Me.SearchBorrowerTextBox.Text & "%' OR STUD_ID LIKE '%" & Me.SearchBorrowerTextBox.Text & "%'"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            fullname = dr("STUD_FIRSTNAME") & ",   " & dr("STUD_MIDDLENAME") & ",   " & dr("STUD_LASTNAME")
            BorrowersForm.BorrowerNameTextBox.Text = fullname
            BorrowersForm.BorrowerIDTextBox.Text = dr("STUD_ID")
            'dr("STUD_COUNT")

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SearchBorrowerTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBorrowerTextBox.TextChanged
        SearchBorrowers()

    End Sub

    Private Sub BorrowerOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowerOk.Click
        Me.Close()
    End Sub
End Class