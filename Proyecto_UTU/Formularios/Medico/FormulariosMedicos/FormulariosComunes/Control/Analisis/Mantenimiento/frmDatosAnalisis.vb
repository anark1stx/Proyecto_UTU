Imports Negocio
Imports Entidades
Imports Utilidades
Public Class frmDatosAnalisis ' NOMBRE | VALOR | UNIDAD | MINIMO | MAXIMO
    Protected _modo As Modo
    Protected _a As New E_Analisis
    Protected _ci_paciente As Integer
    Private valueList As New List(Of NumericUpDown)
    Dim na As New N_Analisis
    Property CI_Paciente As Integer
        Get
            Return _ci_paciente
        End Get
        Set(value As Integer)
            _ci_paciente = value
        End Set
    End Property

    Public Enum Modo
        Ingreso
        Consulta
    End Enum

    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
        End Set
    End Property

    Property AnalisisACargar As E_Analisis
        Get
            Return _a
        End Get
        Set(value As E_Analisis)
            _a = value
        End Set
    End Property

    Private Sub frmDatosAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rowIndex As Integer = 0

        lblTitulo.Text = String.Format("{0} - Paciente: {1}", AnalisisACargar.Nombre, _ci_paciente)

        For Each p As E_Analisis.Parametro In AnalisisACargar.Parametros
            Dim colCount As Integer = 0
            Dim nomParametro As New Label With {
                    .Text = p.Nombre,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Anchor = AnchorStyles.Top
            }

            tblParametros.Controls.Add(nomParametro)

            If MiModo = Modo.Consulta Then
                Dim valorParametro As New Label With {
                    .Text = p.Valor,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Anchor = AnchorStyles.Top
                }

                tblParametros.Controls.Add(valorParametro)
            Else 'modo.ingreso
                Dim valorParametro As New NumericUpDown With {
                    .Font = New Font("Arial", 14, FontStyle.Regular),
                    .AutoSize = True,
                    .Dock = DockStyle.Fill,
                    .Maximum = 99999999,
                    .DecimalPlaces = 2
                }
                tblParametros.Controls.Add(valorParametro)
                valueList.Add(valorParametro)
            End If

            Dim unidadParametro As New Label With {
                    .Text = p.Unidad,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Anchor = AnchorStyles.Top
            }

            tblParametros.Controls.Add(unidadParametro)

            Dim valorParametroMin As New Label With {
                    .Text = p.ValorMinimo,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Anchor = AnchorStyles.Top
            }

            tblParametros.Controls.Add(valorParametroMin)

            Dim valorParametroMax As New Label With {
                    .Text = p.ValorMaximo,
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .AutoSize = True,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Anchor = AnchorStyles.Top
            }

            tblParametros.Controls.Add(valorParametroMax)

            rowIndex += 1

        Next
        For i = 0 To tblParametros.RowStyles.Count - 1
            tblParametros.RowStyles(i).SizeType = SizeType.AutoSize
        Next
        Me.ControlBox = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        For Each t As NumericUpDown In valueList
            If String.IsNullOrWhiteSpace(t.Text) Then
                MessageBox.Show(String.Format("Asigne un valor para el parámetro {0}", AnalisisACargar.Parametros(valueList.IndexOf(t)).Nombre), "Falta proporcionar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        For Each p As E_Analisis.Parametro In AnalisisACargar.Parametros
            p.Valor = valueList(AnalisisACargar.Parametros.IndexOf(p)).Value
        Next

        Dim r = na.AltaAnalisisResultados(AnalisisACargar)
        Select Case r
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case 1
                MessageBox.Show("Alta de resultados de análisis exitosa", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
        End Select
    End Sub
End Class



