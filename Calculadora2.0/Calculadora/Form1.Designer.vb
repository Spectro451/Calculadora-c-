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
        Me.SuspendLayout()
        '
        'BtmCalcular
        '
        Me.BtmCalcular.Location = New System.Drawing.Point(12, 386)
        Me.BtmCalcular.Name = "BtmCalcular"
        Me.BtmCalcular.Size = New System.Drawing.Size(105, 52)
        Me.BtmCalcular.TabIndex = 0
        Me.BtmCalcular.Text = "Iniciar"
        Me.BtmCalcular.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Red
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(689, 386)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(109, 52)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LblDato1
        '
        Me.LblDato1.AutoSize = True
        Me.LblDato1.Location = New System.Drawing.Point(24, 130)
        Me.LblDato1.Name = "LblDato1"
        Me.LblDato1.Size = New System.Drawing.Size(77, 13)
        Me.LblDato1.TabIndex = 2
        Me.LblDato1.Text = "Ingrese Dato 1"
        '
        'TxtDato1
        '
        Me.TxtDato1.Location = New System.Drawing.Point(122, 127)
        Me.TxtDato1.Name = "TxtDato1"
        Me.TxtDato1.Size = New System.Drawing.Size(100, 20)
        Me.TxtDato1.TabIndex = 3
        '
        'LblDato2
        '
        Me.LblDato2.AutoSize = True
        Me.LblDato2.Location = New System.Drawing.Point(24, 191)
        Me.LblDato2.Name = "LblDato2"
        Me.LblDato2.Size = New System.Drawing.Size(77, 13)
        Me.LblDato2.TabIndex = 4
        Me.LblDato2.Text = "Ingrese Dato 2"
        '
        'TxtDato2
        '
        Me.TxtDato2.Location = New System.Drawing.Point(122, 188)
        Me.TxtDato2.Name = "TxtDato2"
        Me.TxtDato2.Size = New System.Drawing.Size(100, 20)
        Me.TxtDato2.TabIndex = 5
        '
        'LblPoto
        '
        Me.LblPoto.AutoSize = True
        Me.LblPoto.Location = New System.Drawing.Point(3, 266)
        Me.LblPoto.Name = "LblPoto"
        Me.LblPoto.Size = New System.Drawing.Size(114, 13)
        Me.LblPoto.TabIndex = 6
        Me.LblPoto.Text = "Su Resultado precioso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 67)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Calculadora"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkSuma
        '
        Me.ChkSuma.AutoSize = True
        Me.ChkSuma.Enabled = False
        Me.ChkSuma.Location = New System.Drawing.Point(288, 126)
        Me.ChkSuma.Name = "ChkSuma"
        Me.ChkSuma.Size = New System.Drawing.Size(53, 17)
        Me.ChkSuma.TabIndex = 13
        Me.ChkSuma.Text = "Suma"
        Me.ChkSuma.UseVisualStyleBackColor = True
        '
        'ChkDivision
        '
        Me.ChkDivision.AutoSize = True
        Me.ChkDivision.Enabled = False
        Me.ChkDivision.Location = New System.Drawing.Point(288, 248)
        Me.ChkDivision.Name = "ChkDivision"
        Me.ChkDivision.Size = New System.Drawing.Size(63, 17)
        Me.ChkDivision.TabIndex = 14
        Me.ChkDivision.Text = "Division"
        Me.ChkDivision.UseVisualStyleBackColor = True
        '
        'ChkMultiplicacion
        '
        Me.ChkMultiplicacion.AutoSize = True
        Me.ChkMultiplicacion.Enabled = False
        Me.ChkMultiplicacion.Location = New System.Drawing.Point(288, 208)
        Me.ChkMultiplicacion.Name = "ChkMultiplicacion"
        Me.ChkMultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.ChkMultiplicacion.TabIndex = 15
        Me.ChkMultiplicacion.Text = "Multiplicacion"
        Me.ChkMultiplicacion.UseVisualStyleBackColor = True
        '
        'ChkResta
        '
        Me.ChkResta.AutoSize = True
        Me.ChkResta.Enabled = False
        Me.ChkResta.Location = New System.Drawing.Point(288, 166)
        Me.ChkResta.Name = "ChkResta"
        Me.ChkResta.Size = New System.Drawing.Size(54, 17)
        Me.ChkResta.TabIndex = 16
        Me.ChkResta.Text = "Resta"
        Me.ChkResta.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(123, 263)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ReadOnly = True
        Me.TxtResultado.Size = New System.Drawing.Size(100, 20)
        Me.TxtResultado.TabIndex = 17
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(133, 386)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(111, 52)
        Me.BtnLimpiar.TabIndex = 18
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'LblOpera
        '
        Me.LblOpera.AutoSize = True
        Me.LblOpera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpera.Location = New System.Drawing.Point(160, 162)
        Me.LblOpera.Name = "LblOpera"
        Me.LblOpera.Size = New System.Drawing.Size(13, 20)
        Me.LblOpera.TabIndex = 19
        Me.LblOpera.Text = " "
        '
        'LblIgual
        '
        Me.LblIgual.AutoSize = True
        Me.LblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIgual.Location = New System.Drawing.Point(160, 224)
        Me.LblIgual.Name = "LblIgual"
        Me.LblIgual.Size = New System.Drawing.Size(21, 24)
        Me.LblIgual.TabIndex = 20
        Me.LblIgual.Text = "="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.descarga__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
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
End Class
