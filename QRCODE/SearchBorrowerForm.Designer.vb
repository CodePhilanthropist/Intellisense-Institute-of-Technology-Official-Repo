<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBorrowerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchBorrowerForm))
        Me.BorrowerOk = New System.Windows.Forms.Button()
        Me.SearchBorrowerTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BorrowerOk
        '
        Me.BorrowerOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowerOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowerOk.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!)
        Me.BorrowerOk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowerOk.Location = New System.Drawing.Point(572, 30)
        Me.BorrowerOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BorrowerOk.Name = "BorrowerOk"
        Me.BorrowerOk.Size = New System.Drawing.Size(112, 38)
        Me.BorrowerOk.TabIndex = 74
        Me.BorrowerOk.Text = "Done"
        Me.BorrowerOk.UseVisualStyleBackColor = False
        '
        'SearchBorrowerTextBox
        '
        Me.SearchBorrowerTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.SearchBorrowerTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.SearchBorrowerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBorrowerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchBorrowerTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBorrowerTextBox.Location = New System.Drawing.Point(214, 30)
        Me.SearchBorrowerTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBorrowerTextBox.Name = "SearchBorrowerTextBox"
        Me.SearchBorrowerTextBox.Size = New System.Drawing.Size(333, 39)
        Me.SearchBorrowerTextBox.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(22, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 27)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "search borrower"
        '
        'SearchBorrowerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(739, 98)
        Me.Controls.Add(Me.BorrowerOk)
        Me.Controls.Add(Me.SearchBorrowerTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchBorrowerForm"
        Me.Text = "Search Borrower"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorrowerOk As System.Windows.Forms.Button
    Friend WithEvents SearchBorrowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
