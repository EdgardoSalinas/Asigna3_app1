<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_numero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_numero2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_promedio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca el primer numero:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 8)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(481, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Implementar la función Promedio que reciba dos números reales y retorne el promed" &
    "io de ambos"
        '
        'txt_numero1
        '
        Me.txt_numero1.Location = New System.Drawing.Point(189, 54)
        Me.txt_numero1.Name = "txt_numero1"
        Me.txt_numero1.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Introduzca el segundo numero:"
        '
        'txt_numero2
        '
        Me.txt_numero2.Location = New System.Drawing.Point(189, 92)
        Me.txt_numero2.Name = "txt_numero2"
        Me.txt_numero2.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(129, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calcular el Promedio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado Promedio:"
        '
        'txt_promedio
        '
        Me.txt_promedio.Location = New System.Drawing.Point(189, 148)
        Me.txt_promedio.Name = "txt_promedio"
        Me.txt_promedio.Size = New System.Drawing.Size(100, 20)
        Me.txt_promedio.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.txt_promedio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_numero2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_numero1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Asignacion3_Aplicacion1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_numero1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numero2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_promedio As TextBox
End Class
