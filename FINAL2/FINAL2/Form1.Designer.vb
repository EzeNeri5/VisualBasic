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
        Me.TBProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNAniadir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboLocal = New System.Windows.Forms.ComboBox()
        Me.ComboSucursal = New System.Windows.Forms.ComboBox()
        Me.ComboPais = New System.Windows.Forms.ComboBox()
        Me.TextBoxLocal = New System.Windows.Forms.TextBox()
        Me.TextBoxSucursal = New System.Windows.Forms.TextBox()
        Me.TextBoxPais = New System.Windows.Forms.TextBox()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.ComboBoxPorveedores = New System.Windows.Forms.ComboBox()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBProveedor
        '
        Me.TBProveedor.Location = New System.Drawing.Point(202, 69)
        Me.TBProveedor.Name = "TBProveedor"
        Me.TBProveedor.Size = New System.Drawing.Size(121, 26)
        Me.TBProveedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Local"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pais"
        '
        'BTNAniadir
        '
        Me.BTNAniadir.Location = New System.Drawing.Point(126, 364)
        Me.BTNAniadir.Name = "BTNAniadir"
        Me.BTNAniadir.Size = New System.Drawing.Size(130, 63)
        Me.BTNAniadir.TabIndex = 8
        Me.BTNAniadir.Text = "AÑADIR"
        Me.BTNAniadir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 63)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboLocal
        '
        Me.ComboLocal.FormattingEnabled = True
        Me.ComboLocal.Location = New System.Drawing.Point(202, 135)
        Me.ComboLocal.Name = "ComboLocal"
        Me.ComboLocal.Size = New System.Drawing.Size(121, 28)
        Me.ComboLocal.TabIndex = 10
        '
        'ComboSucursal
        '
        Me.ComboSucursal.FormattingEnabled = True
        Me.ComboSucursal.Location = New System.Drawing.Point(202, 217)
        Me.ComboSucursal.Name = "ComboSucursal"
        Me.ComboSucursal.Size = New System.Drawing.Size(121, 28)
        Me.ComboSucursal.TabIndex = 11
        '
        'ComboPais
        '
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Location = New System.Drawing.Point(202, 288)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(121, 28)
        Me.ComboPais.TabIndex = 12
        '
        'TextBoxLocal
        '
        Me.TextBoxLocal.Location = New System.Drawing.Point(452, 135)
        Me.TextBoxLocal.Name = "TextBoxLocal"
        Me.TextBoxLocal.Size = New System.Drawing.Size(130, 26)
        Me.TextBoxLocal.TabIndex = 14
        '
        'TextBoxSucursal
        '
        Me.TextBoxSucursal.Location = New System.Drawing.Point(452, 217)
        Me.TextBoxSucursal.Name = "TextBoxSucursal"
        Me.TextBoxSucursal.Size = New System.Drawing.Size(130, 26)
        Me.TextBoxSucursal.TabIndex = 15
        '
        'TextBoxPais
        '
        Me.TextBoxPais.Location = New System.Drawing.Point(452, 288)
        Me.TextBoxPais.Name = "TextBoxPais"
        Me.TextBoxPais.Size = New System.Drawing.Size(130, 26)
        Me.TextBoxPais.TabIndex = 16
        '
        'BTNSALIR
        '
        Me.BTNSALIR.Location = New System.Drawing.Point(245, 541)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(195, 41)
        Me.BTNSALIR.TabIndex = 17
        Me.BTNSALIR.Text = "SALIR"
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'ComboBoxPorveedores
        '
        Me.ComboBoxPorveedores.FormattingEnabled = True
        Me.ComboBoxPorveedores.Location = New System.Drawing.Point(452, 69)
        Me.ComboBoxPorveedores.Name = "ComboBoxPorveedores"
        Me.ComboBoxPorveedores.Size = New System.Drawing.Size(130, 28)
        Me.ComboBoxPorveedores.TabIndex = 18
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Location = New System.Drawing.Point(452, 454)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(130, 52)
        Me.BTNEliminar.TabIndex = 19
        Me.BTNEliminar.Text = "ELIMINAR"
        Me.BTNEliminar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 609)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.ComboBoxPorveedores)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.TextBoxPais)
        Me.Controls.Add(Me.TextBoxSucursal)
        Me.Controls.Add(Me.TextBoxLocal)
        Me.Controls.Add(Me.ComboPais)
        Me.Controls.Add(Me.ComboSucursal)
        Me.Controls.Add(Me.ComboLocal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNAniadir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBProveedor)
        Me.Name = "Form1"
        Me.Text = "AÑADIR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNAniadir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboLocal As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents ComboPais As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxLocal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSucursal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPais As System.Windows.Forms.TextBox
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents ComboBoxPorveedores As System.Windows.Forms.ComboBox
    Friend WithEvents BTNEliminar As System.Windows.Forms.Button

End Class
