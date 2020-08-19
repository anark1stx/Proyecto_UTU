Module mdlArmarQueries

    Public Function USEREXISTS(usr As String) As String
        Return String.Format("SELECT USER FROM mysql.user WHERE user = '{0}'", usr)
    End Function

    Public Function CREATEUSER(usr As String, pwd As String, role As String) As String
        Return String.Format("CREATE USER '{0}'@'localhost' IDENTIFIED BY '{1}' DEFAULT ROLE '{2}'@'localhost'", usr, pwd, role)
    End Function

    Public Function GRANTROLE(usr As String, role As String) As String
        Return String.Format("GRANT '{0}'@'localhost' TO '{1}'@'localhost';", role, usr)
    End Function

    Public Function INSERTUSUARIO(usr As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion_calle As String, direccion_nroPuerta As String, correo As String, foto As Byte())
        Return String.Format("INSERT INTO usuario (CI,nombre1,nombre2,apellido1,apellido2,direccion_calle,direccion_nroPuerta,activo,correo,foto) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", usr, nombre1, nombre2, apellido1, apellido2, direccion_calle, direccion_nroPuerta, 1, correo, foto)
    End Function

    Public Function INSERTTELEFONO(usr As String, tel As String) As String
        Return String.Format("INSERT INTO usuario_tel (CI,telefono) VALUES ({0},{1})", usr, tel)
    End Function

    Public Function INSERTPACIENTE(usr As String, fecha As String, etapa As String, e_civil As String, ocupacion As String, sexo As String) As String
        Return String.Format("INSERT INTO paciente (CI,fecha_nac,etapa,e_civil,ocupacion,sexo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", usr, fecha, "a", e_civil, ocupacion, sexo)
    End Function

    Public Function INSERTMEDICO(usr As String) As String
        Return String.Format("INSERT INTO medico (CI) VALUES ('{0}')", usr)
    End Function

    Public Function INSERTMEDICO_especialidad(usr As String, especialidad As String) As String
        Return String.Format("INSERT INTO medico_especialidad (CI,especialidad) VALUES ('{0}','{1}')", usr, especialidad)
    End Function


End Module
