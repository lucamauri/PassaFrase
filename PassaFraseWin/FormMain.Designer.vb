<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NUDWords = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NUDTotal = New System.Windows.Forms.NumericUpDown()
        Me.LVPassPhrases = New System.Windows.Forms.ListView()
        Me.CHPassPhrase = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHBits = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHGuessMassive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHGuessOffline = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHGuessOnline = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OPTInitials = New System.Windows.Forms.RadioButton()
        Me.OPTUpperCase = New System.Windows.Forms.RadioButton()
        Me.OPTLowerCase = New System.Windows.Forms.RadioButton()
        Me.CHHash = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDWords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NUDWords)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.NUDTotal)
        Me.GroupBox1.Controls.Add(Me.LVPassPhrases)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 458)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'NUDWords
        '
        Me.NUDWords.Location = New System.Drawing.Point(76, 19)
        Me.NUDWords.Name = "NUDWords"
        Me.NUDWords.Size = New System.Drawing.Size(78, 20)
        Me.NUDWords.TabIndex = 3
        Me.NUDWords.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NUDTotal
        '
        Me.NUDTotal.Location = New System.Drawing.Point(273, 19)
        Me.NUDTotal.Name = "NUDTotal"
        Me.NUDTotal.Size = New System.Drawing.Size(75, 20)
        Me.NUDTotal.TabIndex = 2
        Me.NUDTotal.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LVPassPhrases
        '
        Me.LVPassPhrases.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHPassPhrase, Me.CHBits, Me.CHGuessMassive, Me.CHGuessOffline, Me.CHGuessOnline, Me.CHHash})
        Me.LVPassPhrases.Location = New System.Drawing.Point(6, 222)
        Me.LVPassPhrases.Name = "LVPassPhrases"
        Me.LVPassPhrases.Size = New System.Drawing.Size(698, 230)
        Me.LVPassPhrases.TabIndex = 1
        Me.LVPassPhrases.UseCompatibleStateImageBehavior = False
        Me.LVPassPhrases.View = System.Windows.Forms.View.Details
        '
        'CHPassPhrase
        '
        Me.CHPassPhrase.Text = "Passphrase"
        Me.CHPassPhrase.Width = 250
        '
        'CHBits
        '
        Me.CHBits.Text = "Bits"
        '
        'CHGuessMassive
        '
        Me.CHGuessMassive.Text = "Massive"
        Me.CHGuessMassive.Width = 100
        '
        'CHGuessOffline
        '
        Me.CHGuessOffline.Text = "Offline"
        Me.CHGuessOffline.Width = 100
        '
        'CHGuessOnline
        '
        Me.CHGuessOnline.Text = "Online"
        Me.CHGuessOnline.Width = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OPTInitials)
        Me.GroupBox2.Controls.Add(Me.OPTUpperCase)
        Me.GroupBox2.Controls.Add(Me.OPTLowerCase)
        Me.GroupBox2.Location = New System.Drawing.Point(354, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 90)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'OPTInitials
        '
        Me.OPTInitials.AutoSize = True
        Me.OPTInitials.Checked = True
        Me.OPTInitials.Location = New System.Drawing.Point(6, 19)
        Me.OPTInitials.Name = "OPTInitials"
        Me.OPTInitials.Size = New System.Drawing.Size(104, 17)
        Me.OPTInitials.TabIndex = 2
        Me.OPTInitials.TabStop = True
        Me.OPTInitials.Text = "Iniziali Maiuscole"
        Me.OPTInitials.UseVisualStyleBackColor = True
        '
        'OPTUpperCase
        '
        Me.OPTUpperCase.AutoSize = True
        Me.OPTUpperCase.Location = New System.Drawing.Point(6, 65)
        Me.OPTUpperCase.Name = "OPTUpperCase"
        Me.OPTUpperCase.Size = New System.Drawing.Size(80, 17)
        Me.OPTUpperCase.TabIndex = 1
        Me.OPTUpperCase.Text = "MAISCOLO"
        Me.OPTUpperCase.UseVisualStyleBackColor = True
        '
        'OPTLowerCase
        '
        Me.OPTLowerCase.AutoSize = True
        Me.OPTLowerCase.Location = New System.Drawing.Point(6, 42)
        Me.OPTLowerCase.Name = "OPTLowerCase"
        Me.OPTLowerCase.Size = New System.Drawing.Size(72, 17)
        Me.OPTLowerCase.TabIndex = 0
        Me.OPTLowerCase.Text = "minuscolo"
        Me.OPTLowerCase.UseVisualStyleBackColor = True
        '
        'CHHash
        '
        Me.CHHash.Text = "MD5 Hash"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NUDWords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OPTInitials As RadioButton
    Friend WithEvents OPTUpperCase As RadioButton
    Friend WithEvents OPTLowerCase As RadioButton
    Friend WithEvents LVPassPhrases As ListView
    Friend WithEvents CHPassPhrase As ColumnHeader
    Friend WithEvents CHBits As ColumnHeader
    Friend WithEvents CHGuessOffline As ColumnHeader
    Friend WithEvents CHGuessOnline As ColumnHeader
    Friend WithEvents CHGuessMassive As ColumnHeader
    Friend WithEvents NUDTotal As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents NUDWords As NumericUpDown
    Friend WithEvents CHHash As ColumnHeader
End Class
