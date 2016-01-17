<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTSource = New System.Windows.Forms.TextBox()
        Me.CMDSource = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CMDDest = New System.Windows.Forms.Button()
        Me.CMDCompute = New System.Windows.Forms.Button()
        Me.TXTOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTOutput)
        Me.GroupBox1.Controls.Add(Me.CMDCompute)
        Me.GroupBox1.Controls.Add(Me.CMDDest)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.CMDSource)
        Me.GroupBox1.Controls.Add(Me.TXTSource)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 311)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TXTSource
        '
        Me.TXTSource.Location = New System.Drawing.Point(11, 19)
        Me.TXTSource.Name = "TXTSource"
        Me.TXTSource.Size = New System.Drawing.Size(517, 20)
        Me.TXTSource.TabIndex = 0
        '
        'CMDSource
        '
        Me.CMDSource.Location = New System.Drawing.Point(534, 19)
        Me.CMDSource.Name = "CMDSource"
        Me.CMDSource.Size = New System.Drawing.Size(75, 23)
        Me.CMDSource.TabIndex = 1
        Me.CMDSource.Text = "Button1"
        Me.CMDSource.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(517, 20)
        Me.TextBox2.TabIndex = 2
        '
        'CMDDest
        '
        Me.CMDDest.Location = New System.Drawing.Point(534, 63)
        Me.CMDDest.Name = "CMDDest"
        Me.CMDDest.Size = New System.Drawing.Size(75, 23)
        Me.CMDDest.TabIndex = 3
        Me.CMDDest.Text = "Button2"
        Me.CMDDest.UseVisualStyleBackColor = True
        '
        'CMDCompute
        '
        Me.CMDCompute.Location = New System.Drawing.Point(453, 89)
        Me.CMDCompute.Name = "CMDCompute"
        Me.CMDCompute.Size = New System.Drawing.Size(75, 23)
        Me.CMDCompute.TabIndex = 4
        Me.CMDCompute.Text = "Button3"
        Me.CMDCompute.UseVisualStyleBackColor = True
        '
        'TXTOutput
        '
        Me.TXTOutput.Location = New System.Drawing.Point(11, 118)
        Me.TXTOutput.Multiline = True
        Me.TXTOutput.Name = "TXTOutput"
        Me.TXTOutput.Size = New System.Drawing.Size(598, 176)
        Me.TXTOutput.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMDCompute As Button
    Friend WithEvents CMDDest As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CMDSource As Button
    Friend WithEvents TXTSource As TextBox
    Friend WithEvents TXTOutput As TextBox
End Class
