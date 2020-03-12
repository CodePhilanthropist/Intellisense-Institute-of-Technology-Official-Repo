<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowersForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LibraryBack = New System.Windows.Forms.LinkLabel()
        Me.SearchBorrowNameButton = New System.Windows.Forms.Button()
        Me.SearchBookTitleButton = New System.Windows.Forms.Button()
        Me.BorrowerReceiptTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerReturnDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.greetLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BorrowerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BorrowerBookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BorrowerBookNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BorrowRegisterSTudentsButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BorrowerUpdateButton = New System.Windows.Forms.Button()
        Me.BorrowerSaveButton = New System.Windows.Forms.Button()
        Me.BorrowerAddButton = New System.Windows.Forms.Button()
        Me.BorrowerDataGridView = New System.Windows.Forms.DataGridView()
        Me.BorrowCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerDateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BorrowerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(27, 298)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "QR_Code.png"
        Me.SaveFileDialog1.Filter = "PNG IMAGE|*.png"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.SaveButton)
        Me.Panel3.Controls.Add(Me.ClearButton)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(274, 968)
        Me.Panel3.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(43, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 27)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "transaction code"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveButton.Location = New System.Drawing.Point(64, 549)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(72, 47)
        Me.SaveButton.TabIndex = 27
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClearButton.Location = New System.Drawing.Point(142, 549)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(72, 47)
        Me.ClearButton.TabIndex = 28
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'LibraryBack
        '
        Me.LibraryBack.AutoSize = True
        Me.LibraryBack.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LibraryBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LibraryBack.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryBack.Location = New System.Drawing.Point(216, 73)
        Me.LibraryBack.Name = "LibraryBack"
        Me.LibraryBack.Size = New System.Drawing.Size(92, 27)
        Me.LibraryBack.TabIndex = 89
        Me.LibraryBack.TabStop = True
        Me.LibraryBack.Text = "Go Back"
        '
        'SearchBorrowNameButton
        '
        Me.SearchBorrowNameButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchBorrowNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBorrowNameButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.SearchBorrowNameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchBorrowNameButton.Location = New System.Drawing.Point(618, 390)
        Me.SearchBorrowNameButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBorrowNameButton.Name = "SearchBorrowNameButton"
        Me.SearchBorrowNameButton.Size = New System.Drawing.Size(56, 37)
        Me.SearchBorrowNameButton.TabIndex = 15
        Me.SearchBorrowNameButton.Text = "..."
        Me.SearchBorrowNameButton.UseVisualStyleBackColor = False
        '
        'SearchBookTitleButton
        '
        Me.SearchBookTitleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchBookTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBookTitleButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.SearchBookTitleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchBookTitleButton.Location = New System.Drawing.Point(618, 291)
        Me.SearchBookTitleButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBookTitleButton.Name = "SearchBookTitleButton"
        Me.SearchBookTitleButton.Size = New System.Drawing.Size(56, 37)
        Me.SearchBookTitleButton.TabIndex = 13
        Me.SearchBookTitleButton.Text = "..."
        Me.SearchBookTitleButton.UseVisualStyleBackColor = False
        '
        'BorrowerReceiptTextBox
        '
        Me.BorrowerReceiptTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BorrowerReceiptTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BorrowerReceiptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorrowerReceiptTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BorrowerReceiptTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerReceiptTextBox.Location = New System.Drawing.Point(758, 495)
        Me.BorrowerReceiptTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerReceiptTextBox.Name = "BorrowerReceiptTextBox"
        Me.BorrowerReceiptTextBox.Size = New System.Drawing.Size(262, 39)
        Me.BorrowerReceiptTextBox.TabIndex = 20
        '
        'BorrowerReturnDateTimePicker
        '
        Me.BorrowerReturnDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.BorrowerReturnDateTimePicker.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerReturnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BorrowerReturnDateTimePicker.Location = New System.Drawing.Point(758, 298)
        Me.BorrowerReturnDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerReturnDateTimePicker.Name = "BorrowerReturnDateTimePicker"
        Me.BorrowerReturnDateTimePicker.Size = New System.Drawing.Size(253, 25)
        Me.BorrowerReturnDateTimePicker.TabIndex = 18
        '
        'greetLabel
        '
        Me.greetLabel.AutoSize = True
        Me.greetLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greetLabel.Location = New System.Drawing.Point(647, 24)
        Me.greetLabel.Name = "greetLabel"
        Me.greetLabel.Size = New System.Drawing.Size(268, 39)
        Me.greetLabel.TabIndex = 82
        Me.greetLabel.Text = "Rian Rey Barriga."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(501, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 39)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Welcome"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(480, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(461, 27)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "add a new borrow transactions to your record"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(752, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 27)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "receipt number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(752, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 27)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "borrow date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(752, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 27)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "return date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(752, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 27)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "category"
        '
        'BorrowerIDTextBox
        '
        Me.BorrowerIDTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BorrowerIDTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BorrowerIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorrowerIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BorrowerIDTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerIDTextBox.Location = New System.Drawing.Point(345, 495)
        Me.BorrowerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerIDTextBox.Name = "BorrowerIDTextBox"
        Me.BorrowerIDTextBox.Size = New System.Drawing.Size(262, 39)
        Me.BorrowerIDTextBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(340, 457)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 27)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "borrower id"
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BorrowerNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BorrowerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorrowerNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BorrowerNameTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(345, 390)
        Me.BorrowerNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(262, 39)
        Me.BorrowerNameTextBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(340, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 27)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "borrower name"
        '
        'BorrowerBookTitleTextBox
        '
        Me.BorrowerBookTitleTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BorrowerBookTitleTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BorrowerBookTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorrowerBookTitleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BorrowerBookTitleTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerBookTitleTextBox.Location = New System.Drawing.Point(345, 290)
        Me.BorrowerBookTitleTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerBookTitleTextBox.Name = "BorrowerBookTitleTextBox"
        Me.BorrowerBookTitleTextBox.Size = New System.Drawing.Size(262, 39)
        Me.BorrowerBookTitleTextBox.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(340, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 27)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "book title"
        '
        'BorrowerBookNumberTextBox
        '
        Me.BorrowerBookNumberTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BorrowerBookNumberTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BorrowerBookNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorrowerBookNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BorrowerBookNumberTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerBookNumberTextBox.Location = New System.Drawing.Point(345, 186)
        Me.BorrowerBookNumberTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerBookNumberTextBox.Name = "BorrowerBookNumberTextBox"
        Me.BorrowerBookNumberTextBox.Size = New System.Drawing.Size(262, 39)
        Me.BorrowerBookNumberTextBox.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(340, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 27)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "borrow number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BorrowRegisterSTudentsButton)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.BorrowerUpdateButton)
        Me.Panel1.Controls.Add(Me.BorrowerSaveButton)
        Me.Panel1.Controls.Add(Me.BorrowerAddButton)
        Me.Panel1.Location = New System.Drawing.Point(1102, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 762)
        Me.Panel1.TabIndex = 91
        '
        'BorrowRegisterSTudentsButton
        '
        Me.BorrowRegisterSTudentsButton.AutoEllipsis = True
        Me.BorrowRegisterSTudentsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowRegisterSTudentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorrowRegisterSTudentsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowRegisterSTudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowRegisterSTudentsButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowRegisterSTudentsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowRegisterSTudentsButton.Location = New System.Drawing.Point(36, 456)
        Me.BorrowRegisterSTudentsButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowRegisterSTudentsButton.Name = "BorrowRegisterSTudentsButton"
        Me.BorrowRegisterSTudentsButton.Size = New System.Drawing.Size(205, 71)
        Me.BorrowRegisterSTudentsButton.TabIndex = 26
        Me.BorrowRegisterSTudentsButton.Text = "Register Student"
        Me.BorrowRegisterSTudentsButton.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoEllipsis = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(36, 374)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 71)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Receipt"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BorrowerUpdateButton
        '
        Me.BorrowerUpdateButton.AutoEllipsis = True
        Me.BorrowerUpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerUpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorrowerUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowerUpdateButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerUpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowerUpdateButton.Location = New System.Drawing.Point(36, 293)
        Me.BorrowerUpdateButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerUpdateButton.Name = "BorrowerUpdateButton"
        Me.BorrowerUpdateButton.Size = New System.Drawing.Size(205, 71)
        Me.BorrowerUpdateButton.TabIndex = 23
        Me.BorrowerUpdateButton.Text = "Update"
        Me.BorrowerUpdateButton.UseVisualStyleBackColor = False
        '
        'BorrowerSaveButton
        '
        Me.BorrowerSaveButton.AutoEllipsis = True
        Me.BorrowerSaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorrowerSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowerSaveButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerSaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowerSaveButton.Location = New System.Drawing.Point(36, 213)
        Me.BorrowerSaveButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerSaveButton.Name = "BorrowerSaveButton"
        Me.BorrowerSaveButton.Size = New System.Drawing.Size(205, 71)
        Me.BorrowerSaveButton.TabIndex = 22
        Me.BorrowerSaveButton.Text = "Save"
        Me.BorrowerSaveButton.UseVisualStyleBackColor = False
        '
        'BorrowerAddButton
        '
        Me.BorrowerAddButton.AutoEllipsis = True
        Me.BorrowerAddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorrowerAddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowerAddButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowerAddButton.Location = New System.Drawing.Point(36, 133)
        Me.BorrowerAddButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerAddButton.Name = "BorrowerAddButton"
        Me.BorrowerAddButton.Size = New System.Drawing.Size(205, 71)
        Me.BorrowerAddButton.TabIndex = 21
        Me.BorrowerAddButton.Text = "Add"
        Me.BorrowerAddButton.UseVisualStyleBackColor = False
        '
        'BorrowerDataGridView
        '
        Me.BorrowerDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowerDataGridView.Location = New System.Drawing.Point(252, 548)
        Me.BorrowerDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerDataGridView.Name = "BorrowerDataGridView"
        Me.BorrowerDataGridView.Size = New System.Drawing.Size(879, 160)
        Me.BorrowerDataGridView.TabIndex = 92
        '
        'BorrowCategoryTextBox
        '
        Me.BorrowCategoryTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.BorrowCategoryTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BorrowCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorrowCategoryTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BorrowCategoryTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowCategoryTextBox.Location = New System.Drawing.Point(757, 186)
        Me.BorrowCategoryTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowCategoryTextBox.Name = "BorrowCategoryTextBox"
        Me.BorrowCategoryTextBox.Size = New System.Drawing.Size(262, 39)
        Me.BorrowCategoryTextBox.TabIndex = 17
        '
        'BorrowerDateTimePicker
        '
        Me.BorrowerDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.BorrowerDateTimePicker.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.BorrowerDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BorrowerDateTimePicker.Location = New System.Drawing.Point(757, 399)
        Me.BorrowerDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerDateTimePicker.Name = "BorrowerDateTimePicker"
        Me.BorrowerDateTimePicker.Size = New System.Drawing.Size(254, 25)
        Me.BorrowerDateTimePicker.TabIndex = 94
        '
        'BorrowersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.BorrowerDateTimePicker)
        Me.Controls.Add(Me.BorrowCategoryTextBox)
        Me.Controls.Add(Me.BorrowerDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LibraryBack)
        Me.Controls.Add(Me.SearchBorrowNameButton)
        Me.Controls.Add(Me.SearchBookTitleButton)
        Me.Controls.Add(Me.BorrowerReceiptTextBox)
        Me.Controls.Add(Me.BorrowerReturnDateTimePicker)
        Me.Controls.Add(Me.greetLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BorrowerIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BorrowerNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BorrowerBookTitleTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BorrowerBookNumberTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "BorrowersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Borrower"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BorrowerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents LibraryBack As System.Windows.Forms.LinkLabel
    Friend WithEvents SearchBorrowNameButton As System.Windows.Forms.Button
    Friend WithEvents SearchBookTitleButton As System.Windows.Forms.Button
    Friend WithEvents BorrowerReceiptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerReturnDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents greetLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BorrowerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BorrowerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BorrowerBookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BorrowerBookNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BorrowRegisterSTudentsButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BorrowerUpdateButton As System.Windows.Forms.Button
    Friend WithEvents BorrowerSaveButton As System.Windows.Forms.Button
    Friend WithEvents BorrowerAddButton As System.Windows.Forms.Button
    Friend WithEvents BorrowerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BorrowCategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
