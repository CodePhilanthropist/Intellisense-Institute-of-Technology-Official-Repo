Imports System.Data.OleDb
Public Class RegisterStudentsForm
    Dim bytImage() As Byte
    Private Sub RegisterStudentsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateStudents()
    End Sub
    Private Sub populateStudents()
        sql = "SELECT* FROM STUDENTS ORDER BY STUD_COUNT DESC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.StudentDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CountStudentID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS STUDENT_COUNT FROM STUDENTS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("STUDENT_COUNT")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.StudentCount.Text = cmid + 1
    End Sub

    Private Sub StudentAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAdd.Click
        CountStudentID()
        Me.StudentLastName.Clear()
        Me.StudentFirstName.Clear()
        Me.StudentMiddleName.Clear()
        Me.StudentGender.Clear()
        Me.StudentSection.Clear()
        Me.StudentID.Clear()
        Me.StudentLastName.Focus()
        Me.Pic1.Image = Nothing
    End Sub

    Private Sub StudentSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentSave.Click
        Dim ms As New System.IO.MemoryStream
        Dim bmpImage As New Bitmap(Pic1.Image)

        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        bytImage = ms.ToArray()
        ms.Close()
        sql = "INSERT INTO STUDENTS(STUD_COUNT, STUD_LASTNAME, STUD_FIRSTNAME, STUD_MIDDLENAME, STUD_GENDER, STUD_SECTION, STUD_ID, AVATAR)VALUES(" & Me.StudentCount.Text & ", '" & Me.StudentLastName.Text & "', '" & Me.StudentFirstName.Text & "', '" & Me.StudentMiddleName.Text & "', '" & Me.StudentGender.Text & "', '" & Me.StudentSection.Text & "', '" & Me.StudentID.Text & "', @image)"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@image", bytImage)
        Try

            cmd.ExecuteNonQuery()
            MessageBox.Show("New student has been added!")
            populateStudents()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub StudentUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentUpdate.Click
        Dim ms As New System.IO.MemoryStream
        Dim bmpImage As New Bitmap(Pic1.Image)

        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        bytImage = ms.ToArray()
        ms.Close()
        sql = "UPDATE STUDENTS SET STUD_LASTNAME = '" & Me.StudentLastName.Text & "', STUD_FIRSTNAME='" & Me.StudentFirstName.Text & "', STUD_MIDDLENAME='" & Me.StudentMiddleName.Text & "', STUD_GENDER='" & Me.StudentGender.Text & "', STUD_SECTION='" & Me.StudentSection.Text & "', STUD_ID='" & Me.StudentID.Text & "', AVATAR=@image WHERE STUD_COUNT=" & CInt(Me.StudentCount.Text) & ""
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@image", bytImage)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("The student details has been updated!")
            populateStudents()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub StudentDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        sql = "SELECT * FROM STUDENTS WHERE STUD_COUNT=" & CInt(StudentDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.StudentCount.Text = dr("STUD_COUNT")
            Me.StudentLastName.Text = dr("STUD_LASTNAME")
            Me.StudentFirstName.Text = dr("STUD_FIRSTNAME")
            Me.StudentMiddleName.Text = dr("STUD_MIDDLENAME")
            Me.StudentGender.Text = dr("STUD_GENDER")
            Me.StudentSection.Text = dr("STUD_SECTION")
            Me.StudentID.Text = dr("STUD_ID")
            Dim imgbytes As Byte() = CType(dr("AVATAR"), Byte())
            Using ms As New IO.MemoryStream(imgbytes)
                Pic1.Image = Image.FromStream(ms)
                Pic1.SizeMode = PictureBoxSizeMode.StretchImage
            End Using
            dr.Read()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub StudentExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentExit.Click
        Me.Close()
    End Sub


    Private Sub BrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pic1.Image = Image.FromFile(dialog.FileName)
            Pic1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class