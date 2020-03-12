<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibraryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibraryForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SearchBookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.SearchTitleButton = New System.Windows.Forms.Button()
        Me.LibraryAddBookButton = New System.Windows.Forms.Button()
        Me.LibraryUpdateButton = New System.Windows.Forms.Button()
        Me.PrintDetailsButton = New System.Windows.Forms.Button()
        Me.LibraryExitButton = New System.Windows.Forms.Button()
        Me.LibraryBookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.LibraryBookLabel = New System.Windows.Forms.Label()
        Me.LibraryBookAuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LibraryBookISBTextBox = New System.Windows.Forms.TextBox()
        Me.LibraryBookNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LibraryDataGridView = New System.Windows.Forms.DataGridView()
        Me.LibrarySaveButton = New System.Windows.Forms.Button()
        Me.LibraryCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.LibraryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(405, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.SearchBookTitleTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SearchTitleButton)
        Me.Panel1.Location = New System.Drawing.Point(-11, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1392, 150)
        Me.Panel1.TabIndex = 20
        '
        'SearchBookTitleTextBox
        '
        Me.SearchBookTitleTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.SearchBookTitleTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.SearchBookTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBookTitleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchBookTitleTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBookTitleTextBox.Location = New System.Drawing.Point(500, 57)
        Me.SearchBookTitleTextBox.Name = "SearchBookTitleTextBox"
        Me.SearchBookTitleTextBox.Size = New System.Drawing.Size(422, 39)
        Me.SearchBookTitleTextBox.TabIndex = 39
        '
        'SearchTitleButton
        '
        Me.SearchTitleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchTitleButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.SearchTitleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchTitleButton.Location = New System.Drawing.Point(928, 61)
        Me.SearchTitleButton.Name = "SearchTitleButton"
        Me.SearchTitleButton.Size = New System.Drawing.Size(56, 29)
        Me.SearchTitleButton.TabIndex = 40
        Me.SearchTitleButton.Text = "..."
        Me.SearchTitleButton.UseVisualStyleBackColor = False
        '
        'LibraryAddBookButton
        '
        Me.LibraryAddBookButton.AutoEllipsis = True
        Me.LibraryAddBookButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryAddBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LibraryAddBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryAddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LibraryAddBookButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryAddBookButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LibraryAddBookButton.Location = New System.Drawing.Point(191, 211)
        Me.LibraryAddBookButton.Name = "LibraryAddBookButton"
        Me.LibraryAddBookButton.Size = New System.Drawing.Size(203, 60)
        Me.LibraryAddBookButton.TabIndex = 34
        Me.LibraryAddBookButton.Text = "Add Book "
        Me.LibraryAddBookButton.UseVisualStyleBackColor = False
        '
        'LibraryUpdateButton
        '
        Me.LibraryUpdateButton.AutoEllipsis = True
        Me.LibraryUpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryUpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LibraryUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LibraryUpdateButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryUpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LibraryUpdateButton.Location = New System.Drawing.Point(191, 359)
        Me.LibraryUpdateButton.Name = "LibraryUpdateButton"
        Me.LibraryUpdateButton.Size = New System.Drawing.Size(203, 60)
        Me.LibraryUpdateButton.TabIndex = 36
        Me.LibraryUpdateButton.Text = "Update Book"
        Me.LibraryUpdateButton.UseVisualStyleBackColor = False
        '
        'PrintDetailsButton
        '
        Me.PrintDetailsButton.AutoEllipsis = True
        Me.PrintDetailsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PrintDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintDetailsButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintDetailsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrintDetailsButton.Location = New System.Drawing.Point(191, 436)
        Me.PrintDetailsButton.Name = "PrintDetailsButton"
        Me.PrintDetailsButton.Size = New System.Drawing.Size(203, 60)
        Me.PrintDetailsButton.TabIndex = 37
        Me.PrintDetailsButton.Text = "Print Details"
        Me.PrintDetailsButton.UseVisualStyleBackColor = False
        '
        'LibraryExitButton
        '
        Me.LibraryExitButton.AutoEllipsis = True
        Me.LibraryExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LibraryExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibraryExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LibraryExitButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LibraryExitButton.Location = New System.Drawing.Point(191, 514)
        Me.LibraryExitButton.Name = "LibraryExitButton"
        Me.LibraryExitButton.Size = New System.Drawing.Size(203, 60)
        Me.LibraryExitButton.TabIndex = 38
        Me.LibraryExitButton.Text = "Exit"
        Me.LibraryExitButton.UseVisualStyleBackColor = False
        '
        'LibraryBookTitleTextBox
        '
        Me.LibraryBookTitleTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.LibraryBookTitleTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LibraryBookTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibraryBookTitleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LibraryBookTitleTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryBookTitleTextBox.Location = New System.Drawing.Point(510, 215)
        Me.LibraryBookTitleTextBox.Name = "LibraryBookTitleTextBox"
        Me.LibraryBookTitleTextBox.Size = New System.Drawing.Size(262, 39)
        Me.LibraryBookTitleTextBox.TabIndex = 29
        '
        'LibraryBookLabel
        '
        Me.LibraryBookLabel.AutoSize = True
        Me.LibraryBookLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryBookLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LibraryBookLabel.Location = New System.Drawing.Point(505, 185)
        Me.LibraryBookLabel.Name = "LibraryBookLabel"
        Me.LibraryBookLabel.Size = New System.Drawing.Size(108, 27)
        Me.LibraryBookLabel.TabIndex = 69
        Me.LibraryBookLabel.Text = "book title"
        '
        'LibraryBookAuthorTextBox
        '
        Me.LibraryBookAuthorTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.LibraryBookAuthorTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LibraryBookAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibraryBookAuthorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LibraryBookAuthorTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryBookAuthorTextBox.Location = New System.Drawing.Point(510, 312)
        Me.LibraryBookAuthorTextBox.Name = "LibraryBookAuthorTextBox"
        Me.LibraryBookAuthorTextBox.Size = New System.Drawing.Size(262, 39)
        Me.LibraryBookAuthorTextBox.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(505, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 27)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "book author"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(505, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 27)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(912, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 27)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "book isb number"
        '
        'LibraryBookISBTextBox
        '
        Me.LibraryBookISBTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.LibraryBookISBTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LibraryBookISBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibraryBookISBTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LibraryBookISBTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryBookISBTextBox.Location = New System.Drawing.Point(917, 215)
        Me.LibraryBookISBTextBox.Name = "LibraryBookISBTextBox"
        Me.LibraryBookISBTextBox.Size = New System.Drawing.Size(262, 39)
        Me.LibraryBookISBTextBox.TabIndex = 32
        '
        'LibraryBookNumberTextBox
        '
        Me.LibraryBookNumberTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.LibraryBookNumberTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LibraryBookNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibraryBookNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LibraryBookNumberTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryBookNumberTextBox.Location = New System.Drawing.Point(917, 312)
        Me.LibraryBookNumberTextBox.Name = "LibraryBookNumberTextBox"
        Me.LibraryBookNumberTextBox.Size = New System.Drawing.Size(262, 39)
        Me.LibraryBookNumberTextBox.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(912, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 27)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "library book number"
        '
        'LibraryDataGridView
        '
        Me.LibraryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibraryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.LibraryDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LibraryDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.LibraryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LibraryDataGridView.Location = New System.Drawing.Point(573, 475)
        Me.LibraryDataGridView.Name = "LibraryDataGridView"
        Me.LibraryDataGridView.Size = New System.Drawing.Size(606, 172)
        Me.LibraryDataGridView.StandardTab = True
        Me.LibraryDataGridView.TabIndex = 80
        '
        'LibrarySaveButton
        '
        Me.LibrarySaveButton.AutoEllipsis = True
        Me.LibrarySaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibrarySaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LibrarySaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LibrarySaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LibrarySaveButton.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibrarySaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LibrarySaveButton.Location = New System.Drawing.Point(191, 286)
        Me.LibrarySaveButton.Name = "LibrarySaveButton"
        Me.LibrarySaveButton.Size = New System.Drawing.Size(203, 60)
        Me.LibrarySaveButton.TabIndex = 35
        Me.LibrarySaveButton.Text = "Save Book"
        Me.LibrarySaveButton.UseVisualStyleBackColor = False
        '
        'LibraryCategoryTextBox
        '
        Me.LibraryCategoryTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.LibraryCategoryTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LibraryCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibraryCategoryTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LibraryCategoryTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibraryCategoryTextBox.Location = New System.Drawing.Point(510, 405)
        Me.LibraryCategoryTextBox.Name = "LibraryCategoryTextBox"
        Me.LibraryCategoryTextBox.Size = New System.Drawing.Size(262, 39)
        Me.LibraryCategoryTextBox.TabIndex = 31
        '
        'LibraryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LibraryCategoryTextBox)
        Me.Controls.Add(Me.LibrarySaveButton)
        Me.Controls.Add(Me.LibraryDataGridView)
        Me.Controls.Add(Me.LibraryBookNumberTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LibraryBookISBTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibraryBookAuthorTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LibraryBookTitleTextBox)
        Me.Controls.Add(Me.LibraryBookLabel)
        Me.Controls.Add(Me.LibraryExitButton)
        Me.Controls.Add(Me.PrintDetailsButton)
        Me.Controls.Add(Me.LibraryUpdateButton)
        Me.Controls.Add(Me.LibraryAddBookButton)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LibraryForm"
        Me.Text = "Intellisense Institute of Technology Library"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LibraryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SearchBookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchTitleButton As System.Windows.Forms.Button
    Friend WithEvents LibraryAddBookButton As System.Windows.Forms.Button
    Friend WithEvents LibraryUpdateButton As System.Windows.Forms.Button
    Friend WithEvents PrintDetailsButton As System.Windows.Forms.Button
    Friend WithEvents LibraryExitButton As System.Windows.Forms.Button
    Friend WithEvents LibraryBookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LibraryBookLabel As System.Windows.Forms.Label
    Friend WithEvents LibraryBookAuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LibraryBookISBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LibraryBookNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LibraryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LibrarySaveButton As System.Windows.Forms.Button
    Friend WithEvents LibraryCategoryTextBox As System.Windows.Forms.TextBox
End Class
