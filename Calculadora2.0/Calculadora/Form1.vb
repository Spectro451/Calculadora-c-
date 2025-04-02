Imports System.Media

Public Class Form1

    Dim A, B, Resultado As Long
    Public Sub validar()
        'valida que txt1 o txt2 son distintos de vacio
        If TxtDato1.Text <> "" Or TxtDato2.Text <> "" Then
            'habilita btn limpiar
            BtnLimpiar.Enabled = True
            'si txt1 o txt2 son distintos de vacio
            If TxtDato1.Text <> "" And TxtDato2.Text <> "" Then
                'entonces habilitia los chk
                ChkSuma.Enabled = True
                ChkResta.Enabled = True
                ChkMultiplicacion.Enabled = True
                ChkDivision.Enabled = True
            Else
                ChkSuma.Enabled = False
                ChkResta.Enabled = False
                ChkMultiplicacion.Enabled = False
                ChkDivision.Enabled = False
            End If
        Else
            BtnLimpiar.Enabled = False

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtmCalcular.Click
        'da un mensaje lindo en un boton inutil
        MsgBox("Ya me vengo bb")








    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'cierra el programa y le da un bello mensaje uwu
        MsgBox("Hasta luego Precioso")
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuma.CheckedChanged
        'check suma y desactivar cuando eligo uno


        If ChkSuma.Checked Then

            LblOpera.Text = "+"
            ChkDivision.Checked = False
            ChkMultiplicacion.Checked = False
            ChkResta.Checked = False
            'suma dato 1 y 2
            A = TxtDato1.Text
            B = TxtDato2.Text
            TxtResultado.Text = (A + B)



        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'limpia los txt
        TxtDato1().Clear()
        TxtDato2().Clear()
        TxtResultado().Clear()
        LblOpera().Text = ""
        'desactiva los chk 
        ChkSuma.Checked = False
        ChkResta.Checked = False
        ChkMultiplicacion.Checked = False
        ChkDivision.Checked = False

        'desabilita los chk
        ChkSuma.Enabled = False
        ChkResta.Enabled = False
        ChkMultiplicacion.Enabled = False
        ChkDivision.Enabled = False
        BtnLimpiar.Enabled = False
    End Sub

    Private Sub ChkMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMultiplicacion.CheckedChanged
        'multplica si esta activado y desactiva los demas
        If ChkMultiplicacion.Checked Then
            LblOpera.Text = "*"
            ChkDivision.Checked = False
            ChkSuma.Checked = False
            ChkResta.Checked = False
            A = TxtDato1.Text
            B = TxtDato2.Text
            TxtResultado.Text = (A * B)

        End If
    End Sub

    Private Sub LblOpera_Click(sender As Object, e As EventArgs) Handles LblOpera.Click

    End Sub

    Private Sub TxtDato1_TextChanged(sender As Object, e As EventArgs) Handles TxtDato1.TextChanged
        'llama validar si existe un cambio en los txt
        validar()
    End Sub

    Private Sub TxtDato2_TextChanged(sender As Object, e As EventArgs) Handles TxtDato2.TextChanged
        validar()
    End Sub

    Private Sub ChkResta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResta.CheckedChanged
        'resta si esta activado y desactiva los demas
        If ChkResta.Checked Then
            LblOpera.Text = "-"
            ChkDivision.Checked = False
            ChkMultiplicacion.Checked = False
            ChkSuma.Checked = False
            A = TxtDato1.Text
            B = TxtDato2.Text
            TxtResultado.Text = (A - B)

        End If
    End Sub

    Private Sub ChkDivision_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDivision.CheckedChanged
        'divide si el chk division esta activado y desactiva los demas de ser asi
        If ChkDivision.Checked Then
            LblOpera.Text = "/"
            ChkSuma.Checked = False
            ChkMultiplicacion.Checked = False
            ChkResta.Checked = False
            A = TxtDato1.Text
            B = TxtDato2.Text
            TxtResultado.Text = (A / B)

        End If
    End Sub

    Private Sub TxtDato1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDato1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            SystemSounds.Exclamation.Play()
            MessageBox.Show("Porfavor ingrese solo numeros bb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub
    Private Sub TxtDato2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDato1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            SystemSounds.Exclamation.Play()
            MessageBox.Show("Porfavor ingrese solo numeros bb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub
End Class
