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
        Me.Horas = New System.Windows.Forms.Label()
        Me.Convertir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Segundos = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.Location = New System.Drawing.Point(134, 52)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(35, 13)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "Horas"
        '
        'Convertir
        '
        Me.Convertir.Location = New System.Drawing.Point(117, 87)
        Me.Convertir.Name = "Convertir"
        Me.Convertir.Size = New System.Drawing.Size(75, 23)
        Me.Convertir.TabIndex = 1
        Me.Convertir.Text = "Convertir"
        Me.Convertir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(213, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(213, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(213, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Segundos
        '
        Me.Segundos.AutoSize = True
        Me.Segundos.Location = New System.Drawing.Point(127, 122)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(55, 13)
        Me.Segundos.TabIndex = 5
        Me.Segundos.Text = "Segundos"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.Location = New System.Drawing.Point(130, 166)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(44, 13)
        Me.Minutos.TabIndex = 6
        Me.Minutos.Text = "Minutos"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(225, 215)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 7
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 310)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Convertir)
        Me.Controls.Add(Me.Horas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Horas As System.Windows.Forms.Label
    Friend WithEvents Convertir As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Segundos As System.Windows.Forms.Label
    Friend WithEvents Minutos As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Button

End Class
