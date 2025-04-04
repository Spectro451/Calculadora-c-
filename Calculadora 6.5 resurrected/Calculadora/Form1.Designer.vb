<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtmCalcular = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblDato1 = New System.Windows.Forms.Label()
        Me.TxtDato1 = New System.Windows.Forms.TextBox()
        Me.LblDato2 = New System.Windows.Forms.Label()
        Me.TxtDato2 = New System.Windows.Forms.TextBox()
        Me.LblPoto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkSuma = New System.Windows.Forms.CheckBox()
        Me.ChkDivision = New System.Windows.Forms.CheckBox()
        Me.ChkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.ChkResta = New System.Windows.Forms.CheckBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.LblOpera = New System.Windows.Forms.Label()
        Me.LblIgual = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtmCalcular
        '
        Me.BtmCalcular.Location = New System.Drawing.Point(16, 475)
        Me.BtmCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.BtmCalcular.Name = "BtmCalcular"
        Me.BtmCalcular.Size = New System.Drawing.Size(140, 64)
        Me.BtmCalcular.TabIndex = 0
        Me.BtmCalcular.Text = "Iniciar"
        Me.BtmCalcular.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Red
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(919, 475)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(145, 64)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LblDato1
        '
        Me.LblDato1.AutoSize = True
        Me.LblDato1.BackColor = System.Drawing.Color.Transparent
        Me.LblDato1.Location = New System.Drawing.Point(32, 160)
        Me.LblDato1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDato1.Name = "LblDato1"
        Me.LblDato1.Size = New System.Drawing.Size(94, 16)
        Me.LblDato1.TabIndex = 2
        Me.LblDato1.Text = "Ingrese Dato 1"
        '
        'TxtDato1
        '
        Me.TxtDato1.Location = New System.Drawing.Point(163, 156)
        Me.TxtDato1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDato1.Name = "TxtDato1"
        Me.TxtDato1.Size = New System.Drawing.Size(132, 22)
        Me.TxtDato1.TabIndex = 3
        '
        'LblDato2
        '
        Me.LblDato2.AutoSize = True
        Me.LblDato2.BackColor = System.Drawing.Color.Transparent
        Me.LblDato2.Location = New System.Drawing.Point(32, 235)
        Me.LblDato2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDato2.Name = "LblDato2"
        Me.LblDato2.Size = New System.Drawing.Size(94, 16)
        Me.LblDato2.TabIndex = 4
        Me.LblDato2.Text = "Ingrese Dato 2"
        '
        'TxtDato2
        '
        Me.TxtDato2.Location = New System.Drawing.Point(163, 231)
        Me.TxtDato2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDato2.Name = "TxtDato2"
        Me.TxtDato2.Size = New System.Drawing.Size(132, 22)
        Me.TxtDato2.TabIndex = 5
        '
        'LblPoto
        '
        Me.LblPoto.AutoSize = True
        Me.LblPoto.BackColor = System.Drawing.Color.Transparent
        Me.LblPoto.Location = New System.Drawing.Point(4, 327)
        Me.LblPoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPoto.Name = "LblPoto"
        Me.LblPoto.Size = New System.Drawing.Size(144, 16)
        Me.LblPoto.TabIndex = 6
        Me.LblPoto.Text = "Su Resultado precioso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 84)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Calculadora"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkSuma
        '
        Me.ChkSuma.AutoSize = True
        Me.ChkSuma.BackColor = System.Drawing.Color.Transparent
        Me.ChkSuma.Enabled = False
        Me.ChkSuma.Location = New System.Drawing.Point(384, 155)
        Me.ChkSuma.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkSuma.Name = "ChkSuma"
        Me.ChkSuma.Size = New System.Drawing.Size(64, 20)
        Me.ChkSuma.TabIndex = 13
        Me.ChkSuma.Text = "Suma"
        Me.ChkSuma.UseVisualStyleBackColor = False
        '
        'ChkDivision
        '
        Me.ChkDivision.AutoSize = True
        Me.ChkDivision.BackColor = System.Drawing.Color.Transparent
        Me.ChkDivision.Enabled = False
        Me.ChkDivision.Location = New System.Drawing.Point(384, 305)
        Me.ChkDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkDivision.Name = "ChkDivision"
        Me.ChkDivision.Size = New System.Drawing.Size(77, 20)
        Me.ChkDivision.TabIndex = 14
        Me.ChkDivision.Text = "Division"
        Me.ChkDivision.UseVisualStyleBackColor = False
        '
        'ChkMultiplicacion
        '
        Me.ChkMultiplicacion.AutoSize = True
        Me.ChkMultiplicacion.BackColor = System.Drawing.Color.Transparent
        Me.ChkMultiplicacion.Enabled = False
        Me.ChkMultiplicacion.Location = New System.Drawing.Point(384, 256)
        Me.ChkMultiplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkMultiplicacion.Name = "ChkMultiplicacion"
        Me.ChkMultiplicacion.Size = New System.Drawing.Size(110, 20)
        Me.ChkMultiplicacion.TabIndex = 15
        Me.ChkMultiplicacion.Text = "Multiplicacion"
        Me.ChkMultiplicacion.UseVisualStyleBackColor = False
        '
        'ChkResta
        '
        Me.ChkResta.AutoSize = True
        Me.ChkResta.BackColor = System.Drawing.Color.Transparent
        Me.ChkResta.Enabled = False
        Me.ChkResta.Location = New System.Drawing.Point(384, 204)
        Me.ChkResta.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkResta.Name = "ChkResta"
        Me.ChkResta.Size = New System.Drawing.Size(65, 20)
        Me.ChkResta.TabIndex = 16
        Me.ChkResta.Text = "Resta"
        Me.ChkResta.UseVisualStyleBackColor = False
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(164, 324)
        Me.TxtResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ReadOnly = True
        Me.TxtResultado.Size = New System.Drawing.Size(132, 22)
        Me.TxtResultado.TabIndex = 17
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(177, 475)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(148, 64)
        Me.BtnLimpiar.TabIndex = 18
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'LblOpera
        '
        Me.LblOpera.AutoSize = True
        Me.LblOpera.BackColor = System.Drawing.Color.Transparent
        Me.LblOpera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpera.Location = New System.Drawing.Point(213, 199)
        Me.LblOpera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblOpera.Name = "LblOpera"
        Me.LblOpera.Size = New System.Drawing.Size(17, 25)
        Me.LblOpera.TabIndex = 19
        Me.LblOpera.Text = " "
        '
        'LblIgual
        '
        Me.LblIgual.AutoSize = True
        Me.LblIgual.BackColor = System.Drawing.Color.Transparent
        Me.LblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIgual.Location = New System.Drawing.Point(213, 276)
        Me.LblIgual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIgual.Name = "LblIgual"
        Me.LblIgual.Size = New System.Drawing.Size(27, 29)
        Me.LblIgual.TabIndex = 20
        Me.LblIgual.Text = "="
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(746, 473)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(145, 64)
        Me.BtnSalir.TabIndex = 21
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.descarga__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblIgual)
        Me.Controls.Add(Me.LblOpera)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.ChkResta)
        Me.Controls.Add(Me.ChkMultiplicacion)
        Me.Controls.Add(Me.ChkDivision)
        Me.Controls.Add(Me.ChkSuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPoto)
        Me.Controls.Add(Me.TxtDato2)
        Me.Controls.Add(Me.LblDato2)
        Me.Controls.Add(Me.TxtDato1)
        Me.Controls.Add(Me.LblDato1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtmCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Chayannica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtmCalcular As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblDato1 As Label
    Friend WithEvents TxtDato1 As TextBox
    Friend WithEvents LblDato2 As Label
    Friend WithEvents TxtDato2 As TextBox
    Friend WithEvents LblPoto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkSuma As CheckBox
    Friend WithEvents ChkDivision As CheckBox
    Friend WithEvents ChkMultiplicacion As CheckBox
    Friend WithEvents ChkResta As CheckBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents LblOpera As Label
    Friend WithEvents LblIgual As Label
    Friend WithEvents BtnSalir As Button
End Class
