'Imports System.Media'

Public Class Form1

    Dim A, B, Resultado As Long 'define las variables
    Public Sub validar()

        If TxtDato1.Text <> "" Or TxtDato2.Text <> "" Then 'valida que txt1 o txt2 son distintos de vacio

            BtnLimpiar.Enabled = True 'habilita btn limpiar

            If TxtDato1.Text <> "" And TxtDato2.Text <> "" Then 'si txt1 y txt2 son distintos de vacio

                ChkSuma.Enabled = True 'habilita chk suma
                ChkResta.Enabled = True 'habilita chk resta
                ChkMultiplicacion.Enabled = True 'habilita chk multiplicacion
                ChkDivision.Enabled = True 'habilita el chk division
            Else
                'sino 
                ChkSuma.Enabled = False 'desactiva chk suma
                ChkResta.Enabled = False 'desactiva chk resta
                ChkMultiplicacion.Enabled = False 'desactiva chk multiplicacion
                ChkDivision.Enabled = False 'desactiva chk division
            End If
        Else
            'mantiene desactivado el btnlimpiar sino se cumple la primera condicion
            BtnLimpiar.Enabled = False

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtmCalcular.Click
        'da un mensaje lindo en un boton inutil y reproduce un audio desde los recursos
        My.Computer.Audio.Play(My.Resources.buenas, AudioPlayMode.Background)
        MsgBox("Ya me vengo bb")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llama a validar y reproduce un sonido al inicar el programa
        validar()
        My.Computer.Audio.Play(My.Resources.hola, AudioPlayMode.Background) 'reproduce el audio hola de la lista de recursos
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'cierra el programa y le da un bello mensaje uwu
        My.Computer.Audio.Play(My.Resources.goku, AudioPlayMode.Background) 'reproduce el audio goku de la lista de recursos
        MsgBox("Hasta luego Precioso") 'envia un lindo mensaje uwu
        End 'cierra el programa
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuma.CheckedChanged
        'si chk suma esa marcado, desactiva los otros y cambia lbloperador al requerido
        If ChkSuma.Checked Then

            LblOpera.Text = "+" 'cambia el lblopera a un +
            ChkDivision.Checked = False 'desactiva chk division
            ChkMultiplicacion.Checked = False 'desactiva chk multiplicacion
            ChkResta.Checked = False 'desactiva chk resta

            A = TxtDato1.Text 'asigna a la variable A el dato ingresado en el txtdato1
            B = TxtDato2.Text 'asigna a la variable B el dato ingresado en el txtdato2
            TxtResultado.Text = (A + B) 'suma dato 1 y 2 e ingresa el resultado en el txtresultado

        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        'limpia los txt
        TxtDato1().Clear() 'limpia el txtdato1
        TxtDato2().Clear() 'limpia el txtdato2
        TxtResultado().Clear() 'limpia el txtresultado
        LblOpera().Text = "" 'limpia el lblopera
        'desmarca los chk 
        ChkSuma.Checked = False 'desmarca el chksuma
        ChkResta.Checked = False 'desmarca el chkresta
        ChkMultiplicacion.Checked = False 'desmarca el chkmultiplicacion
        ChkDivision.Checked = False 'desmarca el chkdivision
        My.Computer.Audio.Play(My.Resources.peo, AudioPlayMode.Background) 'reproduce el audio peo desde los recursos
        'desabilita los chk
        ChkSuma.Enabled = False 'desabilita el chksuma
        ChkResta.Enabled = False 'desabilita el chkresta
        ChkMultiplicacion.Enabled = False 'desabilita el chkmultiplica
        ChkDivision.Enabled = False 'desabilita el chkdivision
        BtnLimpiar.Enabled = False 'desabilita el btnlimpiar

    End Sub

    Private Sub ChkMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMultiplicacion.CheckedChanged

        If ChkMultiplicacion.Checked Then 'si el chkmultiplicacion esta marcado, entonces
            LblOpera.Text = "*" 'cambia el lblopera a un *
            ChkDivision.Checked = False 'desmarca el chkdivision
            ChkSuma.Checked = False 'desmarca el chksuma
            ChkResta.Checked = False 'desmarca el chkresta
            'multiplica a y b
            A = TxtDato1.Text 'asigna a la variable A el dato ingresado en el txtdato1
            B = TxtDato2.Text 'asigna a la variable B el dato ingresado en el txtdato2
            TxtResultado.Text = (A * B) 'multiplica A*B e ingresa el resultado en el txtresultado

        End If
    End Sub

    Private Sub LblOpera_Click(sender As Object, e As EventArgs) Handles LblOpera.Click

    End Sub

    Private Sub TxtDato1_TextChanged(sender As Object, e As EventArgs) Handles TxtDato1.TextChanged
        'llama validar si existe un cambio en los txt
        validar()
    End Sub

    Private Sub TxtDato2_TextChanged(sender As Object, e As EventArgs) Handles TxtDato2.TextChanged
        'llama validar si existe un cambio en los txt
        validar()
    End Sub

    Private Sub ChkResta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResta.CheckedChanged
        'resta si esta activado y desactiva los demas
        If ChkResta.Checked Then 'si chkresta esta marcado entoces
            LblOpera.Text = "-" 'cambia el lblopera a un -
            ChkDivision.Checked = False 'desmarca el chkdivision
            ChkMultiplicacion.Checked = False 'desmarca el chkmultiplicacion
            ChkSuma.Checked = False 'desmarca el chksuma

            A = TxtDato1.Text 'asigna a la variable A el dato ingresado en el txtdato1
            B = TxtDato2.Text 'asigna a la variable B el dato ingresado en el txtdato2
            TxtResultado.Text = (A - B) 'resta A-B e ingresa el resultado en el txtresultado

        End If
    End Sub

    Private Sub ChkDivision_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDivision.CheckedChanged
        'divide si el chk division esta activado y desactiva los demas de ser asi
        If ChkDivision.Checked Then 'si el chk division esta activado, entoces
            LblOpera.Text = "/" 'cambia el lblopera a /
            ChkSuma.Checked = False 'desmarca el chksuma
            ChkMultiplicacion.Checked = False 'desmarca el chkmultiplicacion
            ChkResta.Checked = False 'desmarca el chkresta

            A = TxtDato1.Text 'asigna a la variable A el dato ingresado en el txtdato1
            B = TxtDato2.Text 'asigna a la variable B el dato ingresado en el txtdato2
            TxtResultado.Text = (A / B) 'realiza la operacion A/B e ingresa el resultado en el txtresultado

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'easter egg
        My.Computer.Audio.Play(My.Resources.pipe, AudioPlayMode.Background) 'reproduce el audio pipe dentro de los recursos asignados cuando #####
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub TxtDato1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDato1.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then 'si el dato ingresado en txtdato1 no es un caracter de control o un caracter numerico entonces
            My.Computer.Audio.Play(My.Resources.classic_hurt, AudioPlayMode.Background) 'reproduce el audio classic_hurt de la lista de recursos
            MessageBox.Show("Porfavor ingrese solo numeros bb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'aparece un mensaje de error explicando el problema
            e.Handled = True 'mantiene el evento activado hasta que se de en aceptar
        End If
    End Sub
    Private Sub TxtDato2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDato2.KeyPress
        'si lo ingresado en l txt2 no es numerico reproduce un audio de error y envia un mensaje
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then 'si el dato ingresado en txtdato2 no es un caracter de control o un caracter numerico entonces
            My.Computer.Audio.Play(My.Resources.classic_hurt, AudioPlayMode.Background) 'reproduce el audio classic_hurt de la lista de recursos
            MessageBox.Show("Porfavor ingrese solo numeros bb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'aparece un mensaje de error explicando el problema
            e.Handled = True 'mantiene el evento activado hasta que se de en aceptar
        End If
    End Sub
End Class
