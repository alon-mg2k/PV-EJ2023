Public Class Form1
    Public Shared Acertados, Fallidos, Omitidos As Integer
    Public FormularioPregunta As Form2
    Private Sub AbrirNuevaPregunta(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "Button1"
                FormularioPregunta = New Form2(cbDificultad.Text, Button1.Text, Integer.Parse(cbTiempo.Text) * 1000)
            Case "Button2"
                FormularioPregunta = New Form2(cbDificultad.Text, Button2.Text, Integer.Parse(cbTiempo.Text) * 1000)
            Case "Button3"
                FormularioPregunta = New Form2(cbDificultad.Text, Button3.Text, Integer.Parse(cbTiempo.Text) * 1000)
            Case "Button4"
                FormularioPregunta = New Form2(cbDificultad.Text, Button4.Text, Integer.Parse(cbTiempo.Text) * 1000)
            Case "Button5"
                FormularioPregunta = New Form2(cbDificultad.Text, Button5.Text, Integer.Parse(cbTiempo.Text) * 1000)
            Case "Button6"
                FormularioPregunta = New Form2(cbDificultad.Text, Button6.Text, Integer.Parse(cbTiempo.Text) * 1000)
        End Select
        FormularioPregunta.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Acertados = 0
        Fallidos = 0
        Omitidos = 0

        tbIntentosExitosos.Text = Acertados
        tbIntentosFallidos.Text = Fallidos
        tbIntentosOmitidos.Text = Omitidos

        cbDificultad.SelectedIndex = 0
        cbTiempo.SelectedIndex = 3
    End Sub

    Private Sub CerrarFormulario(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class
