<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchBookForm))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SearchBookTextBox = New System.Windows.Forms.TextBox()
        Me.BookOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(25, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 27)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "search book "
        '
        'SearchBookTextBox
        '
        Me.SearchBookTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.SearchBookTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.SearchBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBookTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchBookTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBookTextBox.Location = New System.Drawing.Point(200, 24)
        Me.SearchBookTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBookTextBox.Name = "SearchBookTextBox"
        Me.SearchBookTextBox.Size = New System.Drawing.Size(333, 39)
        Me.SearchBookTextBox.TabIndex = 70
        '
        'BookOk
        '
        Me.BookOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BookOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookOk.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.BookOk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BookOk.Location = New System.Drawing.Point(558, 24)
        Me.BookOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BookOk.Name = "BookOk"
        Me.BookOk.Size = New System.Drawing.Size(112, 38)
        Me.BookOk.TabIndex = 71
        Me.BookOk.Text = "Done"
        Me.BookOk.UseVisualStyleBackColor = False
        '
        'SearchBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(709, 100)
        Me.Controls.Add(Me.BookOk)
        Me.Controls.Add(Me.SearchBookTextBox)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchBookForm"
        Me.Tag = ""
        Me.Text = "Enter Book Title"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SearchBookTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookOk As System.Windows.Forms.Button
End Class
