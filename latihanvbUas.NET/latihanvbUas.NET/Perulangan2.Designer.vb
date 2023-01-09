<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perulangan2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.bNext = New System.Windows.Forms.Button
        Me.bWhile = New System.Windows.Forms.Button
        Me.bUntil = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PERULANGAN 2"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(42, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(143, 238)
        Me.ListBox1.TabIndex = 2
        '
        'bNext
        '
        Me.bNext.Location = New System.Drawing.Point(224, 91)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(75, 23)
        Me.bNext.TabIndex = 3
        Me.bNext.Text = "FOR NEXT"
        Me.bNext.UseVisualStyleBackColor = True
        '
        'bWhile
        '
        Me.bWhile.Location = New System.Drawing.Point(224, 159)
        Me.bWhile.Name = "bWhile"
        Me.bWhile.Size = New System.Drawing.Size(75, 23)
        Me.bWhile.TabIndex = 4
        Me.bWhile.Text = "DO WHILE"
        Me.bWhile.UseVisualStyleBackColor = True
        '
        'bUntil
        '
        Me.bUntil.Location = New System.Drawing.Point(224, 228)
        Me.bUntil.Name = "bUntil"
        Me.bUntil.Size = New System.Drawing.Size(75, 23)
        Me.bUntil.TabIndex = 5
        Me.bUntil.Text = "DO UNTIL"
        Me.bUntil.UseVisualStyleBackColor = True
        '
        'Perulangan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 368)
        Me.Controls.Add(Me.bUntil)
        Me.Controls.Add(Me.bWhile)
        Me.Controls.Add(Me.bNext)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Perulangan2"
        Me.Text = "Perulangan2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bNext As System.Windows.Forms.Button
    Friend WithEvents bWhile As System.Windows.Forms.Button
    Friend WithEvents bUntil As System.Windows.Forms.Button
End Class
