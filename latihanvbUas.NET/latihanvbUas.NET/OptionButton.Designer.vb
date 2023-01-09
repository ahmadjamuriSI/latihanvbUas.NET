<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionButton
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbSotoAyam = New System.Windows.Forms.RadioButton
        Me.rbSotoDaging = New System.Windows.Forms.RadioButton
        Me.rbSotoIga = New System.Windows.Forms.RadioButton
        Me.rbTehManis = New System.Windows.Forms.RadioButton
        Me.rbEsTeh = New System.Windows.Forms.RadioButton
        Me.rbEsJeruk = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENGGUNAKAN OPTION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSotoIga)
        Me.GroupBox1.Controls.Add(Me.rbSotoDaging)
        Me.GroupBox1.Controls.Add(Me.rbSotoAyam)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 160)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Makanan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTehManis)
        Me.GroupBox2.Controls.Add(Me.rbEsTeh)
        Me.GroupBox2.Controls.Add(Me.rbEsJeruk)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 160)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Minuman"
        '
        'rbSotoAyam
        '
        Me.rbSotoAyam.AutoSize = True
        Me.rbSotoAyam.Location = New System.Drawing.Point(6, 31)
        Me.rbSotoAyam.Name = "rbSotoAyam"
        Me.rbSotoAyam.Size = New System.Drawing.Size(76, 17)
        Me.rbSotoAyam.TabIndex = 5
        Me.rbSotoAyam.TabStop = True
        Me.rbSotoAyam.Text = "Soto Ayam"
        Me.rbSotoAyam.UseVisualStyleBackColor = True
        '
        'rbSotoDaging
        '
        Me.rbSotoDaging.AutoSize = True
        Me.rbSotoDaging.Location = New System.Drawing.Point(6, 72)
        Me.rbSotoDaging.Name = "rbSotoDaging"
        Me.rbSotoDaging.Size = New System.Drawing.Size(84, 17)
        Me.rbSotoDaging.TabIndex = 6
        Me.rbSotoDaging.TabStop = True
        Me.rbSotoDaging.Text = "Soto Daging"
        Me.rbSotoDaging.UseVisualStyleBackColor = True
        '
        'rbSotoIga
        '
        Me.rbSotoIga.AutoSize = True
        Me.rbSotoIga.Location = New System.Drawing.Point(6, 119)
        Me.rbSotoIga.Name = "rbSotoIga"
        Me.rbSotoIga.Size = New System.Drawing.Size(65, 17)
        Me.rbSotoIga.TabIndex = 7
        Me.rbSotoIga.TabStop = True
        Me.rbSotoIga.Text = "Soto Iga"
        Me.rbSotoIga.UseVisualStyleBackColor = True
        '
        'rbTehManis
        '
        Me.rbTehManis.AutoSize = True
        Me.rbTehManis.Location = New System.Drawing.Point(17, 31)
        Me.rbTehManis.Name = "rbTehManis"
        Me.rbTehManis.Size = New System.Drawing.Size(74, 17)
        Me.rbTehManis.TabIndex = 8
        Me.rbTehManis.TabStop = True
        Me.rbTehManis.Text = "Teh manis"
        Me.rbTehManis.UseVisualStyleBackColor = True
        '
        'rbEsTeh
        '
        Me.rbEsTeh.AutoSize = True
        Me.rbEsTeh.Location = New System.Drawing.Point(17, 82)
        Me.rbEsTeh.Name = "rbEsTeh"
        Me.rbEsTeh.Size = New System.Drawing.Size(59, 17)
        Me.rbEsTeh.TabIndex = 9
        Me.rbEsTeh.TabStop = True
        Me.rbEsTeh.Text = "Es Teh"
        Me.rbEsTeh.UseVisualStyleBackColor = True
        '
        'rbEsJeruk
        '
        Me.rbEsJeruk.AutoSize = True
        Me.rbEsJeruk.Location = New System.Drawing.Point(17, 128)
        Me.rbEsJeruk.Name = "rbEsJeruk"
        Me.rbEsJeruk.Size = New System.Drawing.Size(66, 17)
        Me.rbEsJeruk.TabIndex = 10
        Me.rbEsJeruk.TabStop = True
        Me.rbEsJeruk.Text = "Es Jeruk"
        Me.rbEsJeruk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'OptionButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 370)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OptionButton"
        Me.Text = "OptionButton"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSotoIga As System.Windows.Forms.RadioButton
    Friend WithEvents rbSotoDaging As System.Windows.Forms.RadioButton
    Friend WithEvents rbSotoAyam As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTehManis As System.Windows.Forms.RadioButton
    Friend WithEvents rbEsTeh As System.Windows.Forms.RadioButton
    Friend WithEvents rbEsJeruk As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
