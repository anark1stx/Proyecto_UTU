Public Class Medico
    Inherits Usuario

    Protected _especialidades As List(Of String)

    Sub New()
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _contrasena = ""
        _telefonosLista = New List(Of String)
        _cedula = ""
        _direccion = New List(Of String)
        _especialidades = New List(Of String)
        _imagen = {}
    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As List(Of String), telefonosLista As List(Of String), correo As String, contrasena As String, especialidades As List(Of String), imagen As Byte())
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _cedula = cedula
        _direccion = direccion
        _especialidades = especialidades
        _imagen = imagen
    End Sub

    Property Especialidad() As List(Of String)
        Get
            Return (_especialidades)
        End Get
        Set(ByVal value As List(Of String))
            _especialidades = value
        End Set
    End Property

    Function checkDatosMed() As Boolean
        Dim esps_count As Integer = 0

        If _especialidades.Count = 1 Then
            If _especialidades(0) = "" Then
                MessageBox.Show("Especialidad: Ingrese al menos 1 especialidad", "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                optMsg = "Ingrese una especialidad"
                Return 0
            End If

        End If

        For Each especialidad As String In Me._especialidades
            If Not check_Largo(especialidad, 5, 30, True) Then
                Return 0
                MessageBox.Show(MensajeDeErrorEspecialidad(especialidad) & MensajeDeErrorLongitud(5, 30), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                esps_count += 1
            End If
        Next
        Return 1
    End Function

    Overrides Function buscarPorCI() As Integer
        Conectar()

        Dim sql As String = String.Format("SELECT * FROM usuario,usuario_tel,medico where usuario.CI={0} AND medico.CI={0}", _cedula)

        Try
            rs.Open(sql, conn)
        Catch ex As Exception
            rs.Close()
            MsgBox(ex.Message)
            Return 0
        End Try

        If rs.RecordCount = 1 Then

            If rs("activo").Value = 0 Then
                Return 5 'El usuario fue dado de baja
            End If

            _cedula = rs("CI").Value.ToString()
            _nombre1 = rs("nombre1").Value
            _nombre2 = rs("nombre2").Value
            _apellido1 = rs("apellido1").Value
            _apellido2 = rs("apellido2").Value

            _telefonosLista.Clear()
            _telefonosLista.Add(rs("telefono").Value)

            _direccion.Clear()
            _direccion.Add(rs("direccion_calle").Value)
            _direccion.Add(rs("direccion_nroPuerta").Value)
            _especialidades.Add(rs("especialidad").Value)

        End If

        rs.Close()

    End Function

    Function buscarPorEspecialidad()
        Conectar()

        Dim sql As String = String.Format("SELECT * FROM medico, medico_especialidad where medico_especialidad.especialidad={0}", _especialidades(0))

        Try
            rs.Open(sql, conn)
        Catch ex As Exception
            rs.Close()
            MsgBox(ex.Message)
            Return 0
        End Try

        If rs.RecordCount = 1 Then

            If rs("activo").Value = 0 Then
                Return 5 'El usuario fue dado de baja
            End If

            _cedula = rs("CI").Value.ToString()
            _nombre1 = rs("nombre1").Value
            _nombre2 = rs("nombre2").Value
            _apellido1 = rs("apellido1").Value
            _apellido2 = rs("apellido2").Value

            _telefonosLista.Clear()
            _telefonosLista.Add(rs("telefono").Value)

            _direccion.Clear()
            _direccion.Add(rs("direccion_calle").Value)
            _direccion.Add(rs("direccion_nroPuerta").Value)
            _especialidades.Add(rs("especialidad").Value)

        End If

        rs.Close()

    End Function




End Class
