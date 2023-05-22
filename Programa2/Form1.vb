Public Class Form1
    Public Valor, Limite As Integer
    Public ListaResultados As New List(Of ColumnaResultado)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Valor = Integer.Parse(TextBox1.Text)
            Limite = Integer.Parse(tbNumero.Text)

            ListView1.Columns.Add("Operación")
            ListView1.Columns.Add("Valor")

            For i = 0 To Limite
                ListaResultados.Add(New ColumnaResultado(Valor & " x " & i & "", Valor * i))
            Next

            For Each objeto As ColumnaResultado In ListaResultados
                Dim item As New ListViewItem(objeto.OperacionCadena)
                item.SubItems.Add(objeto.ResultadoCadena.ToString())
                ListView1.Items.Add(item)
            Next

            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            Button1.Enabled = False
            Button2.Enabled = True

        Catch ex As FormatException
            MsgBox("Los datos ingresados no son enteros, no ingrese letras o símbolos", MsgBoxStyle.Critical,
                   "Operación Fallida")
        End Try


    End Sub
    Public Class ColumnaResultado
        Public OperacionCadena As String
        Public ResultadoCadena As Integer

        Public Sub New(opCadena As String, resCadena As Integer)
            Me.OperacionCadena = opCadena
            Me.ResultadoCadena = resCadena
        End Sub

    End Class
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = String.Empty
        tbNumero.Text = String.Empty

        ListView1.Clear()
        ListaResultados.Clear()

        Button1.Enabled = True
        Button2.Enabled = False

    End Sub
End Class
