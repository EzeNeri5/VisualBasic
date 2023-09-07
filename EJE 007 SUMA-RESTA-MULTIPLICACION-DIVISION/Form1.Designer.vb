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
        Me.tex1 = New System.Windows.Forms.TextBox()
        Me.Tex2 = New System.Windows.Forms.TextBox()
        Me.Tex3 = New System.Windows.Forms.TextBox()
        Me.Valor1 = New System.Windows.Forms.Label()
        Me.Valor2 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.Suma = New System.Windows.Forms.Button()
        Me.Resta = New System.Windows.Forms.Button()
        Me.Multiplicacion = New System.Windows.Forms.Button()
        Me.Division = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tex1
        '
        Me.tex1.Location = New System.Drawing.Point(244, 37)
        Me.tex1.Name = "tex1"
        Me.tex1.Size = New System.Drawing.Size(100, 20)
        Me.tex1.TabIndex = 0
        '
        'Tex2
        '
        Me.Tex2.Location = New System.Drawing.Point(244, 79)
        Me.Tex2.Name = "Tex2"
        Me.Tex2.Size = New System.Drawing.Size(100, 20)
        Me.Tex2.TabIndex = 1
        '
        'Tex3
        '
        Me.Tex3.Location = New System.Drawing.Point(244, 124)
        Me.Tex3.Name = "Tex3"
        Me.Tex3.Size = New System.Drawing.Size(100, 20)
        Me.Tex3.TabIndex = 2
        '
        'Valor1
        '
        Me.Valor1.AutoSize = True
        Me.Valor1.Location = New System.Drawing.Point(163, 43)
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(40, 13)
        Me.Valor1.TabIndex = 3
        Me.Valor1.Text = "Valor 1"
        '
        'Valor2
        '
        Me.Valor2.AutoSize = True
        Me.Valor2.Location = New System.Drawing.Point(163, 86)
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(40, 13)
        Me.Valor2.TabIndex = 4
        Me.Valor2.Text = "Valor 2"
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(163, 131)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(55, 13)
        Me.Resultado.TabIndex = 5
        Me.Resultado.Text = "Resultado"
        '
        'Suma
        '
        Me.Suma.Location = New System.Drawing.Point(214, 165)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(75, 23)
        Me.Suma.TabIndex = 6
        Me.Suma.Text = "Suma"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.Location = New System.Drawing.Point(304, 165)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(75, 23)
        Me.Resta.TabIndex = 7
        Me.Resta.Text = "Resta"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.Location = New System.Drawing.Point(214, 221)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(75, 23)
        Me.Multiplicacion.TabIndex = 8
        Me.Multiplicacion.Text = "Multiplicacion"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.Location = New System.Drawing.Point(304, 221)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(75, 23)
        Me.Division.TabIndex = 9
        Me.Division.Text = "Division"
        Me.Division.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(252, 273)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 366)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.Multiplicacion)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.Tex3)
        Me.Controls.Add(Me.Tex2)
        Me.Controls.Add(Me.tex1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tex1 As System.Windows.Forms.TextBox
    Friend WithEvents Tex2 As System.Windows.Forms.TextBox
    Friend WithEvents Tex3 As System.Windows.Forms.TextBox
    Friend WithEvents Valor1 As System.Windows.Forms.Label
    Private WithEvents Valor2 As System.Windows.Forms.Label
    Friend WithEvents Resultado As System.Windows.Forms.Label
    Friend WithEvents Suma As System.Windows.Forms.Button
    Friend WithEvents Resta As System.Windows.Forms.Button
    Friend WithEvents Multiplicacion As System.Windows.Forms.Button
    Friend WithEvents Division As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button

End Class
