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
        Me.CheckIngles = New System.Windows.Forms.CheckBox()
        Me.CheckFrance = New System.Windows.Forms.CheckBox()
        Me.CheckEspaniol = New System.Windows.Forms.CheckBox()
        Me.ButtonEje1 = New System.Windows.Forms.Button()
        Me.Idioma = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckIngles
        '
        Me.CheckIngles.AutoSize = True
        Me.CheckIngles.Location = New System.Drawing.Point(49, 48)
        Me.CheckIngles.Name = "CheckIngles"
        Me.CheckIngles.Size = New System.Drawing.Size(54, 17)
        Me.CheckIngles.TabIndex = 0
        Me.CheckIngles.Text = "Ingles"
        Me.CheckIngles.UseVisualStyleBackColor = True
        '
        'CheckFrance
        '
        Me.CheckFrance.AutoSize = True
        Me.CheckFrance.Location = New System.Drawing.Point(49, 95)
        Me.CheckFrance.Name = "CheckFrance"
        Me.CheckFrance.Size = New System.Drawing.Size(64, 17)
        Me.CheckFrance.TabIndex = 1
        Me.CheckFrance.Text = "Frances"
        Me.CheckFrance.UseVisualStyleBackColor = True
        '
        'CheckEspaniol
        '
        Me.CheckEspaniol.AutoSize = True
        Me.CheckEspaniol.Location = New System.Drawing.Point(49, 145)
        Me.CheckEspaniol.Name = "CheckEspaniol"
        Me.CheckEspaniol.Size = New System.Drawing.Size(64, 17)
        Me.CheckEspaniol.TabIndex = 2
        Me.CheckEspaniol.Text = "Español"
        Me.CheckEspaniol.UseVisualStyleBackColor = True
        '
        'ButtonEje1
        '
        Me.ButtonEje1.Location = New System.Drawing.Point(49, 190)
        Me.ButtonEje1.Name = "ButtonEje1"
        Me.ButtonEje1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEje1.TabIndex = 3
        Me.ButtonEje1.Text = "Ejecutar"
        Me.ButtonEje1.UseVisualStyleBackColor = True
        '
        'Idioma
        '
        Me.Idioma.AutoSize = True
        Me.Idioma.Location = New System.Drawing.Point(184, 52)
        Me.Idioma.Name = "Idioma"
        Me.Idioma.Size = New System.Drawing.Size(38, 13)
        Me.Idioma.TabIndex = 4
        Me.Idioma.Text = "Idioma"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(332, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(27, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(27, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 365)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Idioma)
        Me.Controls.Add(Me.ButtonEje1)
        Me.Controls.Add(Me.CheckEspaniol)
        Me.Controls.Add(Me.CheckFrance)
        Me.Controls.Add(Me.CheckIngles)
        Me.Name = "Form1"
        Me.Text = "Programa Checkbox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIngles As System.Windows.Forms.CheckBox
    Friend WithEvents CheckFrance As System.Windows.Forms.CheckBox
    Friend WithEvents CheckEspaniol As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonEje1 As System.Windows.Forms.Button
    Friend WithEvents Idioma As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
