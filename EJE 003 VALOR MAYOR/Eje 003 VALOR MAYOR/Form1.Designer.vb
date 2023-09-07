<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Valor1 = New System.Windows.Forms.Label()
        Me.Valor2 = New System.Windows.Forms.Label()
        Me.ValorMayor = New System.Windows.Forms.Label()
        Me.Comparar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(310, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(310, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Valor1
        '
        Me.Valor1.AutoSize = True
        Me.Valor1.Location = New System.Drawing.Point(218, 105)
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(40, 13)
        Me.Valor1.TabIndex = 2
        Me.Valor1.Text = "Valor 1"
        '
        'Valor2
        '
        Me.Valor2.AutoSize = True
        Me.Valor2.Location = New System.Drawing.Point(218, 161)
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(40, 13)
        Me.Valor2.TabIndex = 3
        Me.Valor2.Text = "Valor 2"
        '
        'ValorMayor
        '
        Me.ValorMayor.AutoSize = True
        Me.ValorMayor.Location = New System.Drawing.Point(328, 197)
        Me.ValorMayor.Name = "ValorMayor"
        Me.ValorMayor.Size = New System.Drawing.Size(63, 13)
        Me.ValorMayor.TabIndex = 4
        Me.ValorMayor.Text = "Valor Mayor"
        '
        'Comparar
        '
        Me.Comparar.Location = New System.Drawing.Point(323, 232)
        Me.Comparar.Name = "Comparar"
        Me.Comparar.Size = New System.Drawing.Size(75, 23)
        Me.Comparar.TabIndex = 5
        Me.Comparar.Text = "Comparar"
        Me.Comparar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(323, 273)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 439)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Comparar)
        Me.Controls.Add(Me.ValorMayor)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Valor1 As System.Windows.Forms.Label
    Friend WithEvents Valor2 As System.Windows.Forms.Label
    Friend WithEvents ValorMayor As System.Windows.Forms.Label
    Friend WithEvents Comparar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button

End Class
