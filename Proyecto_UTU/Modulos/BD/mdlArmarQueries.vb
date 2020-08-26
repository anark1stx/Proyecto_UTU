Module mdlArmarQueries

    Public Function USEREXISTS(usr As String) As String
        Return String.Format("SELECT USER FROM mysql.user WHERE user = '{0}'", usr)
    End Function

    Public Function CREATEUSER(usr As String, pwd As String, role As String) As String
        Return String.Format("CREATE USER '{0}'@'localhost' IDENTIFIED BY '{1}' DEFAULT ROLE '{2}'", usr, pwd, role)
    End Function

    Public Function GRANTROLE(usr As String, role As String) As String
        Return String.Format("GRANT '{0}'@'localhost' TO '{1}';", role, usr)
    End Function

    Public Function INSERTUSUARIO(usr As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion_calle As String, direccion_nroPuerta As String, correo As String) As String
        Return String.Format("INSERT INTO usuario (CI,nombre1,nombre2,apellido1,apellido2,direccion_calle,direccion_nroPuerta,activo,correo,foto) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','')", usr, nombre1, nombre2, apellido1, apellido2, direccion_calle, direccion_nroPuerta, 1, correo)
    End Function

    Public Function INSERTTELEFONO(usr As String, tel As String) As String
        Return String.Format("INSERT INTO usuario_tel (CI,telefono) VALUES ({0},{1})", usr, tel)
    End Function

    Public Function INSERTPACIENTE(usr As String, fecha As String, e_civil As String, ocupacion As String, sexo As String) As String
        Return String.Format("INSERT INTO paciente (CI,fecha_nac,etapa,e_civil,ocupacion,sexo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", usr, fecha, "a", e_civil, ocupacion, sexo)
    End Function

    Public Function INSERTMEDICO(usr As String) As String
        Return String.Format("INSERT INTO medico (CI) VALUES ('{0}')", usr)
    End Function

    Public Function INSERTMEDICO_especialidad(usr As String, especialidad As String) As String
        Return String.Format("INSERT INTO medico_especialidad (CI,especialidad) VALUES ('{0}','{1}')", usr, especialidad)
    End Function

    Public Function SELECTSIBIMUSUARIO(usr As String) As String
        Return String.Format("SELECT * FROM sibim.usuario WHERE CI = '{0}'", usr)
    End Function

    Public Function INSERTENFERMEDAD(nombre As String, descripcion As String)
        Return String.Format("INSERT INTO Enfermedad (nombre,descripcion) VALUES ('{0}','{1}')", nombre, descripcion)
    End Function

    Public Function INSERTENFERMEDAD_Categoria(nombre As String, descripcion As String)
        Return String.Format("INSERT INTO Categoria(nombre,descripcion) VALUES ('{0}','{1}')", nombre, descripcion)
    End Function

    Public Function INSERTENFERMEDAD_SubCategoria(cat_padre As String, nombre As String, descripcion As String)
        Return String.Format("INSERT INTO Categoria(categoriaPadre,nombre,descripcion) VALUES ('{0}','{1}','{2}')", cat_padre, nombre, descripcion)
    End Function

    Public Function INSERTENFERMEDAD_Clasificacion(nombre As String, categoria As String)
        Return String.Format("INSERT INTO Categoria(nombre_enfermedad,categoria) VALUES ('{0}','{1}')", nombre, categoria)
    End Function

    Public Function INSERTTRATAMIENTO(nombre As String, descripcion As String) As String
        Return String.Format("INSERT INTO tratamiento (nombre,tratamiento) VALUES ('{0}','{1}')", nombre, descripcion)
    End Function

    Public Function INSERTTRATAMIENTO_SIGUE(ci_p As String, id_t As Integer, f_ini As Date, f_fin As Date) As String
        Return String.Format("INSERT INTO sigue VALUES (CI_paciente,ID_tratamiento,fecha_inicio,fecha_fin,resultado) VALUES ('{0}','{1}','{2}','{3}','{4}')", ci_p, id_t, f_ini, f_fin, "''")
    End Function
    Public Function UPDATETRATAMIENTO_SIGUE_res(ci_p As String, id_t As Integer, f_ini As Date, res As String) As String
        Return String.Format("UPDATE sigue SET resultado='{0}' WHERE sigue.CI_paciente='{1}' AND sigue.ID_tratamiento='{2}' AND sigue.fecha_inicio='{3}'", res, ci_p, id_t, f_ini)
    End Function

    Public Function INSERTTRATAMIENTO_SIGUE_SEGUIMIENTO(id_t As Integer, ci_p As String, fecha As Date, descripcion As String) As String
        Return String.Format("INSERT INTO seguimiento VALUES ('{0}','{1}','{2}','{3}')", id_t, ci_p, fecha, descripcion)
    End Function

    Public Function INSERTANALISIS(nombre As String) As String
        Return String.Format("INSERT INTO analisis (nombre) VALUES ('{0}')", nombre)
    End Function

    Public Function INSERTINDICACION(id_analisis As Integer, nombre As String, indicacion As String) As String
        Return String.Format("INSERT INTO analisis_indicacion (ID_analisis,nombre_i,indicacion) VALUES ('{0}','{1}','{2}')", id_analisis, nombre, indicacion)
    End Function

    Public Function INSERTPARAMETRO(nombre As String, unidad As String, min As Double, max As Double) As String
        Return String.Format("INSERT INTO parametro (nombre,unidad,referencia_min,referencia_max) VALUES ('{0}','{1}','{2}','{3}')", nombre, unidad, min, max)
    End Function

    Public Function INSERT_ANALISISTIENEPARAMETRO(id_p, id_a)
        Return String.Format("INSERT INTO tiene (ID_parametro,ID_analisis) VALUES ('{0}','{1}')", id_p, id_a)
    End Function




End Module
