<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Final
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
        Me.TBCodArticulo = New System.Windows.Forms.TextBox()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.BTNAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BNTBuscar = New System.Windows.Forms.Button()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxCod = New System.Windows.Forms.TextBox()
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TBCodArticulo
        '
        Me.TBCodArticulo.Location = New System.Drawing.Point(192, 57)
        Me.TBCodArticulo.Name = "TBCodArticulo"
        Me.TBCodArticulo.Size = New System.Drawing.Size(100, 26)
        Me.TBCodArticulo.TabIndex = 0
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(192, 132)
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(100, 26)
        Me.TBDescripcion.TabIndex = 1
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(192, 213)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(100, 26)
        Me.TBCantidad.TabIndex = 2
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(192, 300)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(100, 26)
        Me.TBPrecio.TabIndex = 3
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Location = New System.Drawing.Point(192, 393)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(100, 45)
        Me.BTNAgregar.TabIndex = 4
        Me.BTNAgregar.Text = "Agregar"
        Me.BTNAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cod_Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Valor Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(386, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Descripcion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cod_Articulo"
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(527, 468)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(100, 39)
        Me.BTNEliminar.TabIndex = 15
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'BNTBuscar
        '
        Me.BNTBuscar.Location = New System.Drawing.Point(527, 393)
        Me.BNTBuscar.Name = "BNTBuscar"
        Me.BNTBuscar.Size = New System.Drawing.Size(100, 45)
        Me.BNTBuscar.TabIndex = 14
        Me.BNTBuscar.Text = "Buscar"
        Me.BNTBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Location = New System.Drawing.Point(527, 300)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxValor.TabIndex = 13
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(527, 213)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxCantidad.TabIndex = 12
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(527, 132)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxDescripcion.TabIndex = 11
        '
        'TextBoxCod
        '
        Me.TextBoxCod.Location = New System.Drawing.Point(527, 57)
        Me.TextBoxCod.Name = "TextBoxCod"
        Me.TextBoxCod.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxCod.TabIndex = 10
        '
        'TextBoxConsulta
        '
        Me.TextBoxConsulta.Location = New System.Drawing.Point(390, 393)
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        Me.TextBoxConsulta.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxConsulta.TabIndex = 20
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(390, 468)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 21
        '
        'Final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 610)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxConsulta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.BNTBuscar)
        Me.Controls.Add(Me.TextBoxValor)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.TextBoxCod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNAgregar)
        Me.Controls.Add(Me.TBPrecio)
        Me.Controls.Add(Me.TBCantidad)
        Me.Controls.Add(Me.TBDescripcion)
        Me.Controls.Add(Me.TBCodArticulo)
        Me.Name = "Final"
        Me.Text = "Eliminar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TBDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TBCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TBPrecio As System.Windows.Forms.TextBox
    Friend WithEvents BTNAgregar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button
    Friend WithEvents BNTBuscar As System.Windows.Forms.Button
    Friend WithEvents TextBoxValor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCod As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxConsulta As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
