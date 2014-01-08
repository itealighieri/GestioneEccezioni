<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Somma = New System.Windows.Forms.Button
        Me.Sottrai = New System.Windows.Forms.Button
        Me.Moltiplica = New System.Windows.Forms.Button
        Me.Dividi = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(47, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Primo operando"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Secondo operando"
        '
        'Somma
        '
        Me.Somma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Somma.Location = New System.Drawing.Point(194, 53)
        Me.Somma.Name = "Somma"
        Me.Somma.Size = New System.Drawing.Size(28, 35)
        Me.Somma.TabIndex = 5
        Me.Somma.Text = "+"
        Me.Somma.UseVisualStyleBackColor = True
        '
        'Sottrai
        '
        Me.Sottrai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sottrai.Location = New System.Drawing.Point(228, 53)
        Me.Sottrai.Name = "Sottrai"
        Me.Sottrai.Size = New System.Drawing.Size(28, 35)
        Me.Sottrai.TabIndex = 6
        Me.Sottrai.Text = "-"
        Me.Sottrai.UseVisualStyleBackColor = True
        '
        'Moltiplica
        '
        Me.Moltiplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moltiplica.Location = New System.Drawing.Point(194, 94)
        Me.Moltiplica.Name = "Moltiplica"
        Me.Moltiplica.Size = New System.Drawing.Size(28, 35)
        Me.Moltiplica.TabIndex = 7
        Me.Moltiplica.Text = "*"
        Me.Moltiplica.UseVisualStyleBackColor = True
        '
        'Dividi
        '
        Me.Dividi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dividi.Location = New System.Drawing.Point(228, 94)
        Me.Dividi.Name = "Dividi"
        Me.Dividi.Size = New System.Drawing.Size(28, 35)
        Me.Dividi.TabIndex = 8
        Me.Dividi.Text = "/"
        Me.Dividi.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Dividi)
        Me.Controls.Add(Me.Moltiplica)
        Me.Controls.Add(Me.Sottrai)
        Me.Controls.Add(Me.Somma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Somma As System.Windows.Forms.Button
    Friend WithEvents Sottrai As System.Windows.Forms.Button
    Friend WithEvents Moltiplica As System.Windows.Forms.Button
    Friend WithEvents Dividi As System.Windows.Forms.Button

End Class
