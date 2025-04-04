<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora_3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblIgual = New System.Windows.Forms.Label()
        Me.LblOpera = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.ChkResta = New System.Windows.Forms.CheckBox()
        Me.ChkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.ChkDivision = New System.Windows.Forms.CheckBox()
        Me.ChkSuma = New System.Windows.Forms.CheckBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblPoto = New System.Windows.Forms.Label()
        Me.TxtDato2 = New System.Windows.Forms.TextBox()
        Me.LblDato2 = New System.Windows.Forms.Label()
        Me.TxtDato1 = New System.Windows.Forms.TextBox()
        Me.LblDato1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtmCalcular = New System.Windows.Forms.Button()
        Me.LblOpera2 = New System.Windows.Forms.Label()
        Me.TxtDato3 = New System.Windows.Forms.TextBox()
        Me.LblDato3 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnultimo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblIgual
        '
        Me.LblIgual.AutoSize = True
        Me.LblIgual.BackColor = System.Drawing.Color.Transparent
        Me.LblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIgual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblIgual.Location = New System.Drawing.Point(230, 308)
        Me.LblIgual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIgual.Name = "LblIgual"
        Me.LblIgual.Size = New System.Drawing.Size(27, 29)
        Me.LblIgual.TabIndex = 36
        Me.LblIgual.Text = "="
        '
        'LblOpera
        '
        Me.LblOpera.AutoSize = True
        Me.LblOpera.BackColor = System.Drawing.Color.Transparent
        Me.LblOpera.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblOpera.Location = New System.Drawing.Point(236, 151)
        Me.LblOpera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblOpera.Name = "LblOpera"
        Me.LblOpera.Size = New System.Drawing.Size(21, 32)
        Me.LblOpera.TabIndex = 35
        Me.LblOpera.Text = " "
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(191, 432)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(148, 64)
        Me.BtnLimpiar.TabIndex = 34
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(180, 341)
        Me.TxtResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ReadOnly = True
        Me.TxtResultado.Size = New System.Drawing.Size(132, 22)
        Me.TxtResultado.TabIndex = 33
        '
        'ChkResta
        '
        Me.ChkResta.AutoSize = True
        Me.ChkResta.BackColor = System.Drawing.Color.Transparent
        Me.ChkResta.Enabled = False
        Me.ChkResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ChkResta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkResta.Location = New System.Drawing.Point(363, 174)
        Me.ChkResta.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkResta.Name = "ChkResta"
        Me.ChkResta.Size = New System.Drawing.Size(75, 24)
        Me.ChkResta.TabIndex = 32
        Me.ChkResta.Text = "Resta"
        Me.ChkResta.UseVisualStyleBackColor = False
        '
        'ChkMultiplicacion
        '
        Me.ChkMultiplicacion.AutoSize = True
        Me.ChkMultiplicacion.BackColor = System.Drawing.Color.Transparent
        Me.ChkMultiplicacion.Enabled = False
        Me.ChkMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ChkMultiplicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkMultiplicacion.Location = New System.Drawing.Point(363, 226)
        Me.ChkMultiplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkMultiplicacion.Name = "ChkMultiplicacion"
        Me.ChkMultiplicacion.Size = New System.Drawing.Size(133, 24)
        Me.ChkMultiplicacion.TabIndex = 31
        Me.ChkMultiplicacion.Text = "Multiplicacion"
        Me.ChkMultiplicacion.UseVisualStyleBackColor = False
        '
        'ChkDivision
        '
        Me.ChkDivision.AutoSize = True
        Me.ChkDivision.BackColor = System.Drawing.Color.Transparent
        Me.ChkDivision.Enabled = False
        Me.ChkDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ChkDivision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkDivision.Location = New System.Drawing.Point(363, 275)
        Me.ChkDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkDivision.Name = "ChkDivision"
        Me.ChkDivision.Size = New System.Drawing.Size(91, 24)
        Me.ChkDivision.TabIndex = 30
        Me.ChkDivision.Text = "Division"
        Me.ChkDivision.UseVisualStyleBackColor = False
        '
        'ChkSuma
        '
        Me.ChkSuma.AutoSize = True
        Me.ChkSuma.BackColor = System.Drawing.Color.Transparent
        Me.ChkSuma.Enabled = False
        Me.ChkSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSuma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkSuma.Location = New System.Drawing.Point(363, 125)
        Me.ChkSuma.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkSuma.Name = "ChkSuma"
        Me.ChkSuma.Size = New System.Drawing.Size(74, 24)
        Me.ChkSuma.TabIndex = 29
        Me.ChkSuma.Text = "Suma"
        Me.ChkSuma.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitulo.Location = New System.Drawing.Point(166, 9)
        Me.LblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(617, 84)
        Me.LblTitulo.TabIndex = 28
        Me.LblTitulo.Text = "Calculadora 3 digitos"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblPoto
        '
        Me.LblPoto.AutoSize = True
        Me.LblPoto.BackColor = System.Drawing.Color.Transparent
        Me.LblPoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPoto.Location = New System.Drawing.Point(18, 344)
        Me.LblPoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPoto.Name = "LblPoto"
        Me.LblPoto.Size = New System.Drawing.Size(144, 16)
        Me.LblPoto.TabIndex = 27
        Me.LblPoto.Text = "Su Resultado precioso"
        '
        'TxtDato2
        '
        Me.TxtDato2.Location = New System.Drawing.Point(180, 200)
        Me.TxtDato2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDato2.Name = "TxtDato2"
        Me.TxtDato2.Size = New System.Drawing.Size(132, 22)
        Me.TxtDato2.TabIndex = 26
        '
        'LblDato2
        '
        Me.LblDato2.AutoSize = True
        Me.LblDato2.BackColor = System.Drawing.Color.Transparent
        Me.LblDato2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblDato2.Location = New System.Drawing.Point(49, 204)
        Me.LblDato2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDato2.Name = "LblDato2"
        Me.LblDato2.Size = New System.Drawing.Size(94, 16)
        Me.LblDato2.TabIndex = 25
        Me.LblDato2.Text = "Ingrese Dato 2"
        '
        'TxtDato1
        '
        Me.TxtDato1.Location = New System.Drawing.Point(180, 125)
        Me.TxtDato1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDato1.Name = "TxtDato1"
        Me.TxtDato1.Size = New System.Drawing.Size(132, 22)
        Me.TxtDato1.TabIndex = 24
        '
        'LblDato1
        '
        Me.LblDato1.AutoSize = True
        Me.LblDato1.BackColor = System.Drawing.Color.Transparent
        Me.LblDato1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblDato1.Location = New System.Drawing.Point(49, 129)
        Me.LblDato1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDato1.Name = "LblDato1"
        Me.LblDato1.Size = New System.Drawing.Size(94, 16)
        Me.LblDato1.TabIndex = 23
        Me.LblDato1.Text = "Ingrese Dato 1"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Red
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(785, 425)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(145, 64)
        Me.BtnCerrar.TabIndex = 22
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtmCalcular
        '
        Me.BtmCalcular.Location = New System.Drawing.Point(21, 432)
        Me.BtmCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.BtmCalcular.Name = "BtmCalcular"
        Me.BtmCalcular.Size = New System.Drawing.Size(140, 64)
        Me.BtmCalcular.TabIndex = 21
        Me.BtmCalcular.Text = "Iniciar"
        Me.BtmCalcular.UseVisualStyleBackColor = True
        '
        'LblOpera2
        '
        Me.LblOpera2.AutoSize = True
        Me.LblOpera2.BackColor = System.Drawing.Color.Transparent
        Me.LblOpera2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpera2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblOpera2.Location = New System.Drawing.Point(238, 238)
        Me.LblOpera2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblOpera2.Name = "LblOpera2"
        Me.LblOpera2.Size = New System.Drawing.Size(21, 32)
        Me.LblOpera2.TabIndex = 39
        Me.LblOpera2.Text = " "
        '
        'TxtDato3
        '
        Me.TxtDato3.Location = New System.Drawing.Point(180, 271)
        Me.TxtDato3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDato3.Name = "TxtDato3"
        Me.TxtDato3.Size = New System.Drawing.Size(132, 22)
        Me.TxtDato3.TabIndex = 38
        '
        'LblDato3
        '
        Me.LblDato3.AutoSize = True
        Me.LblDato3.BackColor = System.Drawing.Color.Transparent
        Me.LblDato3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblDato3.Location = New System.Drawing.Point(49, 275)
        Me.LblDato3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDato3.Name = "LblDato3"
        Me.LblDato3.Size = New System.Drawing.Size(94, 16)
        Me.LblDato3.TabIndex = 37
        Me.LblDato3.Text = "Ingrese Dato 3"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(609, 425)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(145, 64)
        Me.BtnSalir.TabIndex = 40
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'btnultimo
        '
        Me.btnultimo.Location = New System.Drawing.Point(372, 432)
        Me.btnultimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnultimo.Name = "btnultimo"
        Me.btnultimo.Size = New System.Drawing.Size(148, 64)
        Me.btnultimo.TabIndex = 41
        Me.btnultimo.Text = "borrar ultimo valor"
        Me.btnultimo.UseVisualStyleBackColor = True
        '
        'Calculadora_3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.CQ775WSRHZJAZENBXXFNXAERHQ
        Me.ClientSize = New System.Drawing.Size(936, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnultimo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblOpera2)
        Me.Controls.Add(Me.TxtDato3)
        Me.Controls.Add(Me.LblDato3)
        Me.Controls.Add(Me.LblIgual)
        Me.Controls.Add(Me.LblOpera)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.ChkResta)
        Me.Controls.Add(Me.ChkMultiplicacion)
        Me.Controls.Add(Me.ChkDivision)
        Me.Controls.Add(Me.ChkSuma)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblPoto)
        Me.Controls.Add(Me.TxtDato2)
        Me.Controls.Add(Me.LblDato2)
        Me.Controls.Add(Me.TxtDato1)
        Me.Controls.Add(Me.LblDato1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtmCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Calculadora_3"
        Me.Text = "Calculadora_3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIgual As Label
    Friend WithEvents LblOpera As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents ChkResta As CheckBox
    Friend WithEvents ChkMultiplicacion As CheckBox
    Friend WithEvents ChkDivision As CheckBox
    Friend WithEvents ChkSuma As CheckBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblPoto As Label
    Friend WithEvents TxtDato2 As TextBox
    Friend WithEvents LblDato2 As Label
    Friend WithEvents TxtDato1 As TextBox
    Friend WithEvents LblDato1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtmCalcular As Button
    Friend WithEvents LblOpera2 As Label
    Friend WithEvents TxtDato3 As TextBox
    Friend WithEvents LblDato3 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents btnultimo As Button
End Class
