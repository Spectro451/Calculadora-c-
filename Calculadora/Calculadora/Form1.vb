Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtmCalcular.Click





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        MsgBox("Hasta luego Precioso")
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuma.CheckedChanged
        If ChkSuma.Checked Then
            LblOpera.Text = "+"
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtDato1().Clear()
        TxtDato2().Clear()
        TxtResultado.Clear()
    End Sub

    Private Sub ChkMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMultiplicacion.CheckedChanged
        If ChkMultiplicacion.Checked Then
            LblOpera.Text = "*"
        End If
    End Sub

    Private Sub ChkResta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResta.CheckedChanged
        If ChkResta.Checked Then
            LblOpera.Text = "-"
        End If
    End Sub

    Private Sub ChkDivision_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDivision.CheckedChanged
        If ChkDivision.Checked Then
            LblOpera.Text = "/"
        End If
    End Sub
End Class
