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
        Me.ButtonLunes = New System.Windows.Forms.Button()
        Me.ButtonMartes = New System.Windows.Forms.Button()
        Me.ButtonMiercoles = New System.Windows.Forms.Button()
        Me.ButtonJueves = New System.Windows.Forms.Button()
        Me.ButtonViernes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonLunes
        '
        Me.ButtonLunes.Location = New System.Drawing.Point(99, 93)
        Me.ButtonLunes.Name = "ButtonLunes"
        Me.ButtonLunes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLunes.TabIndex = 0
        Me.ButtonLunes.Text = "Lunes"
        Me.ButtonLunes.UseVisualStyleBackColor = True
        '
        'ButtonMartes
        '
        Me.ButtonMartes.Location = New System.Drawing.Point(214, 93)
        Me.ButtonMartes.Name = "ButtonMartes"
        Me.ButtonMartes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMartes.TabIndex = 1
        Me.ButtonMartes.Text = "Martes"
        Me.ButtonMartes.UseVisualStyleBackColor = True
        '
        'ButtonMiercoles
        '
        Me.ButtonMiercoles.Location = New System.Drawing.Point(339, 93)
        Me.ButtonMiercoles.Name = "ButtonMiercoles"
        Me.ButtonMiercoles.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMiercoles.TabIndex = 2
        Me.ButtonMiercoles.Text = "Miercoles"
        Me.ButtonMiercoles.UseVisualStyleBackColor = True
        '
        'ButtonJueves
        '
        Me.ButtonJueves.Location = New System.Drawing.Point(469, 93)
        Me.ButtonJueves.Name = "ButtonJueves"
        Me.ButtonJueves.Size = New System.Drawing.Size(75, 23)
        Me.ButtonJueves.TabIndex = 3
        Me.ButtonJueves.Text = "Jueves"
        Me.ButtonJueves.UseVisualStyleBackColor = True
        '
        'ButtonViernes
        '
        Me.ButtonViernes.Location = New System.Drawing.Point(591, 93)
        Me.ButtonViernes.Name = "ButtonViernes"
        Me.ButtonViernes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonViernes.TabIndex = 4
        Me.ButtonViernes.Text = "Viernes"
        Me.ButtonViernes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dia Seleccionado Es:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(339, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonSalir.Location = New System.Drawing.Point(326, 184)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(138, 27)
        Me.ButtonSalir.TabIndex = 7
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 455)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonViernes)
        Me.Controls.Add(Me.ButtonJueves)
        Me.Controls.Add(Me.ButtonMiercoles)
        Me.Controls.Add(Me.ButtonMartes)
        Me.Controls.Add(Me.ButtonLunes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonLunes As System.Windows.Forms.Button
    Friend WithEvents ButtonMartes As System.Windows.Forms.Button
    Friend WithEvents ButtonMiercoles As System.Windows.Forms.Button
    Friend WithEvents ButtonJueves As System.Windows.Forms.Button
    Friend WithEvents ButtonViernes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button

End Class
