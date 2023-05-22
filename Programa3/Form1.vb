Imports System.Globalization

Public Class Form1
    Public num1, num2, cont As Integer
    Public Terminado As Boolean
    Public ListaMultiplos As New List(Of MCMFila)()
    Public Class MCMFila
        Public Resultado1, Resultado2 As Integer
        Public Multiplo As String
        Public Sub New(multiplo As String, res1 As Integer, res2 As Integer)
            Me.Multiplo = multiplo
            Me.Resultado1 = res1
            Me.Resultado2 = res2
        End Sub
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Terminado = False
        cont = 1

        Try
            num1 = Integer.Parse(TextBox1.Text)
            num2 = Integer.Parse(tbNumero.Text)
            If Not (num1 = num2) Then
                While Not Terminado
                    ListaMultiplos.Add(New MCMFila("Múltiplo " & cont, num1 * cont, num2 * cont))
                    For i = 0 To cont - 1
                        For j = 0 To cont - 1
                            If ListaMultiplos(i).Resultado1 = ListaMultiplos(j).Resultado2 Then
                                Terminado = True
                                MsgBox("Mínimo comun múltiplo encontrado: " & ListaMultiplos(i).Resultado1, MsgBoxStyle.Information, "Operación Completada!")
                                Exit For
                            End If
                        Next
                        If Terminado Then
                            Exit For
                        End If
                    Next
                    If Terminado Then
                        Exit While
                    Else
                        cont += 1
                    End If
                End While

                ListView1.Columns.Add("Múltiplo")
                ListView1.Columns.Add("Resultado 1")
                ListView1.Columns.Add("Resultado 2")

                For Each objeto As MCMFila In ListaMultiplos
                    Dim item As New ListViewItem(objeto.Multiplo)
                    item.SubItems.Add(objeto.Resultado1.ToString)
                    item.SubItems.Add(objeto.Resultado2.ToString)
                    ListView1.Items.Add(item)
                Next

                ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

                Button1.Enabled = False
                Button2.Enabled = True
            Else
                MsgBox("No se pueden repetir los números", MsgBoxStyle.Critical, "Operación Fallida!")
            End If
        Catch ex As FormatException
            MsgBox("Los datos erróneos no son del tipo entero, no ingrese letras o símbolos", MsgBoxStyle.Critical, "Operación Fallida!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        tbNumero.Text = String.Empty
        cont = 1
        Terminado = False

        ListView1.Clear()
        ListaMultiplos.Clear()

        Button1.Enabled = True
        Button2.Enabled = False

    End Sub
End Class
