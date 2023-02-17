Imports MySql.Data.MySqlClient
Public Class secretaria
    Private cmb As MySqlCommandBuilder
    Dim conexion1 As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte

    Dim mensaje As String
    Dim usuario4 As String
    Dim departamento As String
   
    Dim accion As String
    Dim item As String

    Dim fecha1 As String
    Dim hora1 As String

#Region "CONECTAR"
    Public Sub Conectar()
        Try
            conexion1.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_secretaria_general;user= root;password=;"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT *FROM bd_secretaria_general"
            adaptador = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador.Fill(datos, "bd_secretaria_general")
            DgvPersonas.DataSource = datos
            DgvPersonas.DataMember = "bd_secretaria_general"
            'MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "bd_secretaria_general")
        End Try
    End Sub
#End Region

#Region "Conectar base de actividades"
    Public Sub actividad()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "INICIO DE SESION"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "SECRETARIA GENERAL"
        accion = "-"
        item = "-"
        Dim conexion4 As New MySqlConnection
        Dim datos4 As New DataSet
        Dim adaptador4 As New MySqlDataAdapter
        Try
            conexion4.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_seguridad;user= root;password=;"
            conexion4.Open()
            Dim consulta4 As String
            consulta4 = "SELECT *FROM ingreso_usuarios"
            adaptador4 = New MySqlDataAdapter(consulta4, conexion4)
            datos4 = New DataSet
            adaptador4.Fill(datos4, "ingreso_usuarios")
            Dim ENTRADA5 As String = "INSERT INTO ingreso_usuarios (MENSAJE_DE_ALERTA, USUARIO, DEPARTAMENTO, ACCION, ITEM, FECHA, HORA) VALUES ('" + mensaje + "', '" + usuario4 + "', '" + departamento + "','" + accion + "','" + item + "', '" + fecha1 + "', '" + hora1 + "')"
            Dim DT4 As New DataTable
            Dim ADAPTADOR5 As New MySqlDataAdapter(ENTRADA5, conexion4)
            ADAPTADOR5.Fill(DT4)

            conexion4.Close()
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "ingreso_usuarios")
        End Try
    End Sub
#End Region

#Region "Conectar actividades modificar de actividades"
    Public Sub actividadMo()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "ALTERACION DE DATOS"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "SECRETARIA GENERAL"
        accion = "MODIFICACION"
        item = txt_cedula.Text
        Dim conexion4 As New MySqlConnection
        Dim datos4 As New DataSet
        Dim adaptador4 As New MySqlDataAdapter
        Try
            conexion4.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_seguridad;user= root;password=;"
            conexion4.Open()
            Dim consulta4 As String
            consulta4 = "SELECT *FROM ingreso_usuarios"
            adaptador4 = New MySqlDataAdapter(consulta4, conexion4)
            datos4 = New DataSet
            adaptador4.Fill(datos4, "ingreso_usuarios")
            Dim ENTRADA5 As String = "INSERT INTO ingreso_usuarios (MENSAJE_DE_ALERTA, USUARIO, DEPARTAMENTO, ACCION, ITEM, FECHA, HORA) VALUES ('" + mensaje + "', '" + usuario4 + "', '" + departamento + "','" + accion + "','" + item + "', '" + fecha1 + "', '" + hora1 + "')"
            Dim DT4 As New DataTable
            Dim ADAPTADOR5 As New MySqlDataAdapter(ENTRADA5, conexion4)
            ADAPTADOR5.Fill(DT4)
            conexion4.Close()
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "bd_administracion")
        End Try
    End Sub
#End Region

#Region "Conectar actividades registro de actividades"
    Public Sub actividadRe()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "INGRESO DE DATOS"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "SECRETARIA GENERAL"
        accion = "REGISTRO"
        item = txt_cedula.Text
        Dim conexion4 As New MySqlConnection
        Dim datos4 As New DataSet
        Dim adaptador4 As New MySqlDataAdapter
        Try
            conexion4.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_seguridad;user= root;password=;"
            conexion4.Open()
            Dim consulta4 As String
            consulta4 = "SELECT *FROM ingreso_usuarios"
            adaptador4 = New MySqlDataAdapter(consulta4, conexion4)
            datos4 = New DataSet
            adaptador4.Fill(datos4, "ingreso_usuarios")
            Dim ENTRADA5 As String = "INSERT INTO ingreso_usuarios (MENSAJE_DE_ALERTA, USUARIO, DEPARTAMENTO, ACCION, ITEM, FECHA, HORA) VALUES ('" + mensaje + "', '" + usuario4 + "', '" + departamento + "','" + accion + "','" + item + "', '" + fecha1 + "', '" + hora1 + "')"
            Dim DT4 As New DataTable
            Dim ADAPTADOR5 As New MySqlDataAdapter(ENTRADA5, conexion4)
            ADAPTADOR5.Fill(DT4)
            conexion4.Close()
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "bd_administracion")
        End Try
    End Sub
#End Region

#Region "Conectar actividades eliminacion de actividades"
    Public Sub actividadEl()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "ELIMINACION DE REGISTRO"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "SECRETARIA GENERAL"
        accion = "ELIMINACION"
        item = txt_cedula.Text
        Dim conexion4 As New MySqlConnection
        Dim datos4 As New DataSet
        Dim adaptador4 As New MySqlDataAdapter
        Try
            conexion4.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_seguridad;user= root;password=;"
            conexion4.Open()
            Dim consulta4 As String
            consulta4 = "SELECT *FROM ingreso_usuarios"
            adaptador4 = New MySqlDataAdapter(consulta4, conexion4)
            datos4 = New DataSet
            adaptador4.Fill(datos4, "ingreso_usuarios")
            Dim ENTRADA5 As String = "INSERT INTO ingreso_usuarios (MENSAJE_DE_ALERTA, USUARIO, DEPARTAMENTO, ACCION, ITEM, FECHA, HORA) VALUES ('" + mensaje + "', '" + usuario4 + "', '" + departamento + "','" + accion + "','" + item + "', '" + fecha1 + "', '" + hora1 + "')"
            Dim DT4 As New DataTable
            Dim ADAPTADOR5 As New MySqlDataAdapter(ENTRADA5, conexion4)
            ADAPTADOR5.Fill(DT4)
            conexion4.Close()
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "bd_administracion")
        End Try
    End Sub
#End Region

#Region "Inicializar"
    Private Sub secretaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Cargando Base de Datos" & vbNewLine & "Por favor espere.")

        Conectar()
        actividad()
        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        txt_registro.Enabled = False
        alerta()
    End Sub
#End Region

#Region "MOSTRAR DATOS"
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        datos.Tables.Clear()
        adaptador = New MySqlDataAdapter(sql, conexion1)
        cmb = New MySqlCommandBuilder(adaptador)
        adaptador.Fill(datos, tabla)
    End Sub
    Public Sub MostrarDatos()
        consulta("SELECT * FROM bd_secretaria_general", "bd_secretaria_general")
        DgvPersonas.DataSource = datos.Tables("bd_secretaria_general")
    End Sub
#End Region

#Region "DATOS HACIA LOS TXT"
    Private Sub DgvPersonas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPersonas.CellContentClick
        Dim i As Integer = DgvPersonas.CurrentRow.Index
        txt_registro.Text = DgvPersonas(0, i).Value
        txt_cedula.Text = DgvPersonas(1, i).Value
        txt_apellido.Text = DgvPersonas(2, i).Value
        txt_nombre.Text = DgvPersonas(3, i).Value
        txt_version.Text = DgvPersonas(4, i).Value
        txt_gaveta.Text = DgvPersonas(5, i).Value
        txt_cajon.Text = DgvPersonas(6, i).Value
        txt_programa.Text = DgvPersonas(7, i).Value
        txt_inicio.Text = DgvPersonas(8, i).Value
        txt_fin.Text = DgvPersonas(9, i).Value
        txt_titulo.Text = DgvPersonas(10, i).Value
        txt_procedencia.Text = DgvPersonas(11, i).Value
        txt_direccion.Text = DgvPersonas(12, i).Value
        txt_telefono.Text = DgvPersonas(13, i).Value
        txt_correo.Text = DgvPersonas(14, i).Value
        txt_graduado.Text = DgvPersonas(15, i).Value
        txt_acta.Text = DgvPersonas(16, i).Value
        txt_fecha.Text = DgvPersonas(17, i).Value
        txt_trabajo.Text = DgvPersonas(18, i).Value
        txt_tutor.Text = DgvPersonas(19, i).Value

        Button1.Enabled = False
        txt_registro.Enabled = False
    End Sub
#End Region

#Region "LIMPIAR"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt_registro.Text = ""
        txt_cedula.Text = ""
        txt_apellido.Text = ""
        txt_nombre.Text = ""
        txt_acta.Text = ""
        txt_busqueda.Text = ""
        txt_cajon.Text = ""
        txt_correo.Text = ""
        txt_direccion.Text = ""
        txt_fecha.Text = ""
        txt_fin.Text = ""
        txt_gaveta.Text = ""
        txt_graduado.Text = ""
        txt_inicio.Text = ""
        txt_nombre.Text = ""
        txt_procedencia.Text = ""
        txt_programa.Text = ""
        txt_telefono.Text = ""
        txt_titulo.Text = ""
        txt_trabajo.Text = ""
        txt_tutor.Text = ""
        txt_version.Text = ""

        MostrarDatos()


        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
            txt_registro.Enabled = True
            txt_registro.Enabled = False
        End If


    End Sub
#End Region

#Region "REGISTRAR"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txt_cedula.Text = "") Or (txt_apellido.Text = "") Or (txt_nombre.Text = "") Then
            MsgBox("Campos Vacios", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta5 As String = "SELECT * FROM bd_secretaria_general WHERE CEDULA = '" & txt_cedula.Text & "'"
                Dim ADAPTADORC As New MySqlDataAdapter(consulta5, conexion1)
                Dim datos As New DataSet
                ADAPTADORC.Fill(datos, "bd_secretaria_general")
                lista = datos.Tables("bd_secretaria_general").Rows.Count
                If lista <> 0 Then
                    MsgBox("LA CEDULA INGRESA " & txt_cedula.Text & " YA EXISTE EN LA BASE DE DATOS", MsgBoxStyle.Critical, "Error")
                    'BorrarCampos()
                    txt_registro.Text = ""
                    txt_cedula.Text = ""
                    txt_apellido.Text = ""
                    txt_nombre.Text = ""
                    txt_acta.Text = ""
                    txt_busqueda.Text = ""
                    txt_cajon.Text = ""
                    txt_correo.Text = ""
                    txt_direccion.Text = ""
                    txt_fecha.Text = ""
                    txt_fin.Text = ""
                    txt_gaveta.Text = ""
                    txt_graduado.Text = ""
                    txt_inicio.Text = ""
                    txt_nombre.Text = ""
                    txt_procedencia.Text = ""
                    txt_programa.Text = ""
                    txt_telefono.Text = ""
                    txt_titulo.Text = ""
                    txt_trabajo.Text = ""
                    txt_tutor.Text = ""
                    txt_version.Text = ""
                    MostrarDatos()
                    Button1.Enabled = True
                    txt_registro.Enabled = True
                    txt_registro.Enabled = False

                Else
                    Dim lista2 As Byte
                    Dim consulta7 As String = "SELECT * FROM bd_secretaria_general WHERE APELLIDO = '" & txt_apellido.Text & "'"
                    Dim ADAPTADOR7 As New MySqlDataAdapter(consulta7, conexion1)
                    Dim datos2 As New DataSet
                    ADAPTADOR7.Fill(datos2, "bd_secretaria_general")
                    lista2 = datos2.Tables("bd_secretaria_general").Rows.Count
                    If lista2 <> 0 Then
                        MsgBox("COINCIDENCIA CON " + txt_apellido.Text + " DEL CAMPO APELLIDO", MsgBoxStyle.Critical, "Error")
                    End If

                    Dim lista3 As Byte
                    Dim consulta8 As String = "SELECT * FROM bd_secretaria_general WHERE NOMBRE = '" & txt_nombre.Text & "'"
                    Dim ADAPTADOR8 As New MySqlDataAdapter(consulta8, conexion1)
                    Dim datos3 As New DataSet
                    ADAPTADOR8.Fill(datos3, "bd_secretaria_general")
                    lista3 = datos3.Tables("bd_secretaria_general").Rows.Count
                    If lista3 <> 0 Then
                        MsgBox("COINCIDENCIA CON " + txt_nombre.Text + " DEL CAMPO NOMBRE", MsgBoxStyle.Critical, "Error")
                    End If

                    'Dim ENTRADA As String = "INSERT INTO sifap (CEDULA, APELLIDOS, NOMBRES, VERSION, GAVETA, CAJON, PROGRAMA, FECHA DE INICIO, FECHA DE FIN, TITULO DE TERCER NIVEL, PROCEDENCIA, DIRECCION, TELEFONO, CORREO, GRADUADO, NUMERO DE ACTA, FECHA, TRABAJO DE TITULACION, TUTOR DE TESIS) VALUES ('" + txt_cedula.Text + "', '" + txt_apellido.Text + "', '" + txt_nombre.Text + "', '" + txt_version.Text + "', '" + txt_gaveta.Text + "', '" + txt_cajon.Text + "', '" + txt_programa.Text + "', '" + txt_inicio.Text + "', '" + txt_fin.Text + "', '" + txt_titulo.Text + "', '" + txt_procedencia.Text + "', '" + txt_direccion.Text + "', '" + txt_telefono.Text + "', '" + txt_correo.Text + "', '" + txt_graduado.Text + "', '" + txt_acta.Text + "','" + txt_fecha.Text + "','" + txt_trabajo.Text + "', '" + txt_tutor.Text + "')"
                    Dim ENTRADA As String = "INSERT INTO bd_secretaria_general (CEDULA, APELLIDO, NOMBRE, VERSION, GAVETA, CAJON, PROGRAMA, FECHA_INICIO, FECHA_FIN, TITULO_DE_TERCER_NIVEL, PROCEDENCIA, DIRECCION, TELEFONO, CORREO, GRADUADO, NUMERO_DE_ACTA, FECHA, TRABAJO_DE_TITULACION, TUTOR) VALUES ('" + txt_cedula.Text + "', '" + txt_apellido.Text + "', '" + txt_nombre.Text + "', '" + txt_version.Text + "', '" + txt_gaveta.Text + "', '" + txt_cajon.Text + "', '" + txt_programa.Text + "', '" + txt_inicio.Text + "', '" + txt_fin.Text + "', '" + txt_titulo.Text + "', '" + txt_procedencia.Text + "', '" + txt_direccion.Text + "', '" + txt_telefono.Text + "', '" + txt_correo.Text + "', '" + txt_graduado.Text + "', '" + txt_acta.Text + "', '" + txt_fecha.Text + "', '" + txt_trabajo.Text + "', '" + txt_tutor.Text + "')"
                    Dim DT As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(ENTRADA, conexion1)
                    ADAPTADOR.Fill(DT)

                    MsgBox("Insercion correcta")
                    conexion1.Close()
                    actividadRe()
                    'BorrarCampos()
                    txt_registro.Text = ""
                    txt_cedula.Text = ""
                    txt_apellido.Text = ""
                    txt_nombre.Text = ""
                    txt_acta.Text = ""
                    txt_busqueda.Text = ""
                    txt_cajon.Text = ""
                    txt_correo.Text = ""
                    txt_direccion.Text = ""
                    txt_fecha.Text = ""
                    txt_fin.Text = ""
                    txt_gaveta.Text = ""
                    txt_graduado.Text = ""
                    txt_inicio.Text = ""
                    txt_nombre.Text = ""
                    txt_procedencia.Text = ""
                    txt_programa.Text = ""
                    txt_telefono.Text = ""
                    txt_titulo.Text = ""
                    txt_trabajo.Text = ""
                    txt_tutor.Text = ""
                    txt_version.Text = ""
                    MostrarDatos()
                    Button1.Enabled = True
                    txt_registro.Enabled = True
                    txt_registro.Enabled = False
                End If


            Catch ex As Exception

                MsgBox("NO SE INSERTO EL DATO", MsgBoxStyle.Critical, "Error" + ex.Message)
            Finally
                conexion1.Dispose()

            End Try


        End If
    End Sub
#End Region

#Region "MODIFICAR DATOS"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If

        If (txt_cedula.Text = "") Or (txt_apellido.Text = "") Or (txt_nombre.Text = "") Then
            MsgBox("Seleccione un registro", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("UPDATE bd_secretaria_general Set CEDULA = '" & txt_cedula.Text & "', APELLIDO = '" & txt_apellido.Text & "', NOMBRE = '" & txt_nombre.Text & "', VERSION = '" & txt_version.Text & "',GAVETA = '" & txt_gaveta.Text & "', CAJON = '" & txt_cajon.Text & "', PROGRAMA = '" & txt_programa.Text & "', FECHA_INICIO = '" & txt_inicio.Text & "', FECHA_FIN = '" & txt_fin.Text & "', TITULO_DE_TERCER_NIVEL = '" & txt_titulo.Text & "', PROCEDENCIA = '" & txt_procedencia.Text & "', DIRECCION = '" & txt_direccion.Text & "', TELEFONO = '" & txt_telefono.Text & "', CORREO = '" & txt_correo.Text & "', GRADUADO = '" & txt_graduado.Text & "', NUMERO_DE_ACTA = '" & txt_acta.Text & "', FECHA = '" & txt_fecha.Text & "', TRABAJO_DE_TITULACION = '" & txt_trabajo.Text & "', TUTOR = '" & txt_tutor.Text & "' WHERE REGISTRO = '" & txt_registro.Text & "'", conexion1)
            comando.ExecuteNonQuery()
            MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information, "Confirmar")

            actividadMo()

            txt_registro.Text = ""
            txt_cedula.Text = ""
            txt_apellido.Text = ""
            txt_nombre.Text = ""
            txt_acta.Text = ""
            txt_busqueda.Text = ""
            txt_cajon.Text = ""
            txt_correo.Text = ""
            txt_direccion.Text = ""
            txt_fecha.Text = ""
            txt_fin.Text = ""
            txt_gaveta.Text = ""
            txt_graduado.Text = ""
            txt_inicio.Text = ""
            txt_nombre.Text = ""
            txt_procedencia.Text = ""
            txt_programa.Text = ""
            txt_telefono.Text = ""
            txt_titulo.Text = ""
            txt_trabajo.Text = ""
            txt_tutor.Text = ""
            txt_version.Text = ""
            Button1.Enabled = True
            txt_registro.Enabled = True
            txt_registro.Enabled = False
            MostrarDatos()
            If conexion1.State = ConnectionState.Open Then
                conexion1.Close()
            End If
        End If
    End Sub
#End Region

#Region "ELIMINAR DATOS"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        If (txt_cedula.Text = "") Or (txt_apellido.Text = "") Or (txt_nombre.Text = "") Then
            MsgBox("Seleccione un registro", MsgBoxStyle.Information, "Confirmar")
        Else

            Dim respuesta As String
            respuesta = InputBox("Desea Eliminar al registro: ", "Ingrese Clave")

            If respuesta = "123" Then


                Dim comando As New MySqlCommand("DELETE FROM bd_secretaria_general WHERE REGISTRO ='" & txt_registro.Text & "'", conexion1)
                comando.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", MsgBoxStyle.Information, "Confirmar")
                actividadEl()
                txt_registro.Text = ""
                txt_cedula.Text = ""
                txt_apellido.Text = ""
                txt_nombre.Text = ""
                txt_acta.Text = ""
                txt_busqueda.Text = ""
                txt_cajon.Text = ""
                txt_correo.Text = ""
                txt_direccion.Text = ""
                txt_fecha.Text = ""
                txt_fin.Text = ""
                txt_gaveta.Text = ""
                txt_graduado.Text = ""
                txt_inicio.Text = ""
                txt_nombre.Text = ""
                txt_procedencia.Text = ""
                txt_programa.Text = ""
                txt_telefono.Text = ""
                txt_titulo.Text = ""
                txt_trabajo.Text = ""
                txt_tutor.Text = ""
                txt_version.Text = ""

                MostrarDatos()
                Button1.Enabled = True
                txt_registro.Enabled = True
                txt_registro.Enabled = False
                If conexion1.State = ConnectionState.Open Then
                    conexion1.Close()
                    txt_registro.Enabled = False
                End If

            End If
        End If

    End Sub
#End Region

#Region "BUSQUEDA CEDULA"
    Private Sub NOMBREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMBREToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE CEDULA LIKE '%" & txt_busqueda.Text & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA APELLIDO"
    Private Sub APELLIDOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APELLIDOToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE APELLIDO LIKE '%" & txt_busqueda.Text & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA VERSION"
    Private Sub VERSIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERSIONToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE VERSION LIKE '%" & txt_busqueda.Text & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA FECHA INICIO"
    Private Sub FECHAINICIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FECHAINICIOToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE FECHA_INICIO LIKE '%" & txt_busqueda.Text & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA PROGRAMA"
    Private Sub PROGRAMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROGRAMAToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE PROGRAMA LIKE '%" & txt_busqueda.Text & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA GRADUADO"
    Private Sub SIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GRADUADO LIKE '%" & "SI" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub NOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GRADUADO LIKE '%" & "NO" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA GAVETA"
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GAVETA LIKE '%" & "1" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GAVETA LIKE '%" & "2" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GAVETA LIKE '%" & "3" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GAVETA LIKE '%" & "4" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM bd_secretaria_general WHERE GAVETA LIKE '%" & "5" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvPersonas.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "MENU PRINCIPAL"
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        principal.Show()
        Me.Close()
    End Sub
#End Region

#Region "CERRAR SESION"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        conexion1.Close()
        autenticacion.Show()
        Me.Close()
    End Sub
#End Region

#Region "Refrescar"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txt_registro.Text = ""
        txt_cedula.Text = ""
        txt_apellido.Text = ""
        txt_nombre.Text = ""
        txt_acta.Text = ""
        txt_busqueda.Text = ""
        txt_cajon.Text = ""
        txt_correo.Text = ""
        txt_direccion.Text = ""
        txt_fecha.Text = ""
        txt_fin.Text = ""
        txt_gaveta.Text = ""
        txt_graduado.Text = ""
        txt_inicio.Text = ""
        txt_nombre.Text = ""
        txt_procedencia.Text = ""
        txt_programa.Text = ""
        txt_telefono.Text = ""
        txt_titulo.Text = ""
        txt_trabajo.Text = ""
        txt_tutor.Text = ""
        txt_version.Text = ""

        MostrarDatos()


        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
            txt_registro.Enabled = True
            txt_registro.Enabled = False
        End If

    End Sub
#End Region

#Region "BOTON REGRESAR"
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        principal.Show()
        Me.Close()
    End Sub
#End Region

#Region "Exportar"
    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        llenarExcel(DgvPersonas)
    End Sub
#End Region

#Region "Alerta de seguridad"
    Public Sub alerta()
        enviarCorreos(emisor:="pruebaapp.2624@gmail.com", password:="jvmb pdrf bcfb zoaw", mensaje:="Se ha detectado el ingreso del usuario " + autenticacion.txt_usuario.Text + "  al departamento de Secretaria General. ", asunto:="Mensaje de alerta sistema SIFPAPV", destinatario:="carmen.rivadeneiraa@ug.edu.ec, sadafatuly@hotmail.com, saadda.fatulya@ug.edu.ec, jonathan.rodriguezvi@ug.edu.ec")
    End Sub
#End Region
End Class