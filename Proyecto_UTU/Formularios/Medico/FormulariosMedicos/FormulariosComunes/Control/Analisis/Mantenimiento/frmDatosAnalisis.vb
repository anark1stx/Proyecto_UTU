Public Class frmDatosAnalisis ' NOMBRE | VALOR | UNIDAD | MINIMO | MAXIMO
    Public modo As Integer = 0 '0 = consulta, 1 = ingreso
    Public AnalisisACargar As New Analisis
    Public _paciente As New Paciente
    Private Sub frmDatosAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rowIndex As Integer = 0

        lblTitulo.Text = String.Format("{0} - Paciente: {1},{2}", AnalisisACargar.Nombre, _paciente.Nombre1, _paciente.Apellido1)

        For Each p As Analisis.Parametro In AnalisisACargar.Parametros
            Dim colCount As Integer = 0
            Dim nomParametro As New Label With {
                    .Text = p.Nombre,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True
            }

            tblParametros.Controls.Add(nomParametro)

            If modo = 0 Then
                Dim valorParametro As New Label With {
                    .Text = p.Valor,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True
                }

                tblParametros.Controls.Add(valorParametro)
            Else
                Dim valorParametro As New TextBox With {
                    .Font = New Font("Arial", 14, FontStyle.Regular),
                    .AutoSize = True
                }

                tblParametros.Controls.Add(valorParametro)
            End If

            Dim unidadParametro As New Label With {
                    .Text = p.Unidad,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True
            }

            tblParametros.Controls.Add(unidadParametro)

            Dim valorParametroMin As New Label With {
                    .Text = p.ValorMinimo,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True
            }

            tblParametros.Controls.Add(valorParametroMin)

            Dim valorParametroMax As New Label With {
                    .Text = p.ValorMaximo,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True
            }

            tblParametros.Controls.Add(valorParametroMax)

            rowIndex += 1

        Next

        For Each rowS As RowStyle In tblParametros.RowStyles
            rowS.SizeType = SizeType.AutoSize
        Next

    End Sub
End Class



