<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStudentsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterStudentsForm))
        Me.StudentFirstName = New System.Windows.Forms.TextBox()
        Me.cool = New System.Windows.Forms.Label()
        Me.StudentLastName = New System.Windows.Forms.TextBox()
        Me.sa = New System.Windows.Forms.Label()
        Me.StudentMiddleName = New System.Windows.Forms.TextBox()
        Me.tingko = New System.Windows.Forms.Label()
        Me.StudentGender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentSection = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudentCount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentAdd = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentUpdate = New System.Windows.Forms.Button()
        Me.StudentExit = New System.Windows.Forms.Button()
        Me.StudentSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentFirstName
        '
        Me.StudentFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.StudentFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentFirstName.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentFirstName.Location = New System.Drawing.Point(61, 386)
        Me.StudentFirstName.Name = "StudentFirstName"
        Me.StudentFirstName.Size = New System.Drawing.Size(262, 39)
        Me.StudentFirstName.TabIndex = 23
        '
        'cool
        '
        Me.cool.AutoSize = True
        Me.cool.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cool.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cool.Location = New System.Drawing.Point(56, 356)
        Me.cool.Name = "cool"
        Me.cool.Size = New System.Drawing.Size(111, 27)
        Me.cool.TabIndex = 81
        Me.cool.Text = "first name"
        '
        'StudentLastName
        '
        Me.StudentLastName.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentLastName.BackColor = System.Drawing.SystemColors.Window
        Me.StudentLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentLastName.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentLastName.Location = New System.Drawing.Point(61, 285)
        Me.StudentLastName.Name = "StudentLastName"
        Me.StudentLastName.Size = New System.Drawing.Size(262, 39)
        Me.StudentLastName.TabIndex = 22
        '
        'sa
        '
        Me.sa.AutoSize = True
        Me.sa.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sa.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.sa.Location = New System.Drawing.Point(56, 255)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(106, 27)
        Me.sa.TabIndex = 79
        Me.sa.Text = "last name"
        '
        'StudentMiddleName
        '
        Me.StudentMiddleName.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentMiddleName.BackColor = System.Drawing.SystemColors.Window
        Me.StudentMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentMiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentMiddleName.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentMiddleName.Location = New System.Drawing.Point(61, 491)
        Me.StudentMiddleName.Name = "StudentMiddleName"
        Me.StudentMiddleName.Size = New System.Drawing.Size(262, 39)
        Me.StudentMiddleName.TabIndex = 24
        '
        'tingko
        '
        Me.tingko.AutoSize = True
        Me.tingko.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tingko.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tingko.Location = New System.Drawing.Point(56, 461)
        Me.tingko.Name = "tingko"
        Me.tingko.Size = New System.Drawing.Size(140, 27)
        Me.tingko.TabIndex = 86
        Me.tingko.Text = "middle name"
        '
        'StudentGender
        '
        Me.StudentGender.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentGender.BackColor = System.Drawing.SystemColors.Window
        Me.StudentGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentGender.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGender.Location = New System.Drawing.Point(419, 285)
        Me.StudentGender.Name = "StudentGender"
        Me.StudentGender.Size = New System.Drawing.Size(262, 39)
        Me.StudentGender.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(414, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 27)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "gender"
        '
        'StudentSection
        '
        Me.StudentSection.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentSection.BackColor = System.Drawing.SystemColors.Window
        Me.StudentSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentSection.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentSection.Location = New System.Drawing.Point(419, 386)
        Me.StudentSection.Name = "StudentSection"
        Me.StudentSection.Size = New System.Drawing.Size(262, 39)
        Me.StudentSection.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(414, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 27)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "section"
        '
        'StudentID
        '
        Me.StudentID.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentID.BackColor = System.Drawing.SystemColors.Window
        Me.StudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentID.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentID.Location = New System.Drawing.Point(419, 491)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(262, 39)
        Me.StudentID.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(414, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 27)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "school id"
        '
        'StudentCount
        '
        Me.StudentCount.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.StudentCount.BackColor = System.Drawing.SystemColors.Window
        Me.StudentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentCount.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentCount.Location = New System.Drawing.Point(61, 180)
        Me.StudentCount.Name = "StudentCount"
        Me.StudentCount.Size = New System.Drawing.Size(262, 39)
        Me.StudentCount.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(56, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 27)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "student count"
        '
        'StudentAdd
        '
        Me.StudentAdd.AutoEllipsis = True
        Me.StudentAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StudentAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StudentAdd.Location = New System.Drawing.Point(865, 264)
        Me.StudentAdd.Name = "StudentAdd"
        Me.StudentAdd.Size = New System.Drawing.Size(141, 60)
        Me.StudentAdd.TabIndex = 28
        Me.StudentAdd.Text = "Add"
        Me.StudentAdd.UseVisualStyleBackColor = False
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Location = New System.Drawing.Point(70, 550)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(729, 172)
        Me.StudentDataGridView.TabIndex = 98
        '
        'StudentUpdate
        '
        Me.StudentUpdate.AutoEllipsis = True
        Me.StudentUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StudentUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentUpdate.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StudentUpdate.Location = New System.Drawing.Point(865, 401)
        Me.StudentUpdate.Name = "StudentUpdate"
        Me.StudentUpdate.Size = New System.Drawing.Size(141, 60)
        Me.StudentUpdate.TabIndex = 30
        Me.StudentUpdate.Text = "Update"
        Me.StudentUpdate.UseVisualStyleBackColor = False
        '
        'StudentExit
        '
        Me.StudentExit.AutoEllipsis = True
        Me.StudentExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StudentExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentExit.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StudentExit.Location = New System.Drawing.Point(865, 470)
        Me.StudentExit.Name = "StudentExit"
        Me.StudentExit.Size = New System.Drawing.Size(141, 60)
        Me.StudentExit.TabIndex = 31
        Me.StudentExit.Text = "Exit"
        Me.StudentExit.UseVisualStyleBackColor = False
        '
        'StudentSave
        '
        Me.StudentSave.AutoEllipsis = True
        Me.StudentSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StudentSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentSave.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StudentSave.Location = New System.Drawing.Point(865, 332)
        Me.StudentSave.Name = "StudentSave"
        Me.StudentSave.Size = New System.Drawing.Size(141, 60)
        Me.StudentSave.TabIndex = 29
        Me.StudentSave.Text = "Save"
        Me.StudentSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(414, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 27)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "profile picture"
        '
        'Pic1
        '
        Me.Pic1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic1.Location = New System.Drawing.Point(606, 27)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(216, 216)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic1.TabIndex = 100
        Me.Pic1.TabStop = False
        '
        'BrowseButton
        '
        Me.BrowseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrowseButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.BrowseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BrowseButton.Location = New System.Drawing.Point(418, 137)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(167, 36)
        Me.BrowseButton.TabIndex = 101
        Me.BrowseButton.Text = "Browse Image"
        Me.BrowseButton.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RegisterStudentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 749)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StudentSave)
        Me.Controls.Add(Me.StudentExit)
        Me.Controls.Add(Me.StudentUpdate)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.StudentAdd)
        Me.Controls.Add(Me.StudentCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentSection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StudentGender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StudentMiddleName)
        Me.Controls.Add(Me.tingko)
        Me.Controls.Add(Me.StudentFirstName)
        Me.Controls.Add(Me.cool)
        Me.Controls.Add(Me.StudentLastName)
        Me.Controls.Add(Me.sa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisterStudentsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register a Sudent"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cool As System.Windows.Forms.Label
    Friend WithEvents StudentLastName As System.Windows.Forms.TextBox
    Friend WithEvents sa As System.Windows.Forms.Label
    Friend WithEvents StudentMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents tingko As System.Windows.Forms.Label
    Friend WithEvents StudentGender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentSection As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StudentCount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StudentAdd As System.Windows.Forms.Button
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StudentUpdate As System.Windows.Forms.Button
    Friend WithEvents StudentExit As System.Windows.Forms.Button
    Friend WithEvents StudentSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
