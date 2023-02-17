Imports MySql.Data.MySqlClient
Imports System.Data
Public Class oficiodecanato
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
            conexion1.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_asistente_decanato;user= root;password=;"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT *FROM oficio_sifpapv"
            adaptador = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador.Fill(datos, "oficio_sifpapv")
            DgvPersonas.DataSource = datos
            DgvPersonas.DataMember = "oficio_sifpapv"
            'MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "SIFAPV")
        End Try
    End Sub
#End Region

#Region "Conectar base de actividades"
    Public Sub actividad()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "INICIO DE SESION"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "OFICIO_FACULTAD"
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
        departamento = "OFICIO_FACULTAD"
        accion = "MODIFICACION"
        item = txt_noficio.Text


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


#Region "Conectar actividades registro de actividades"
    Public Sub actividadRe()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "INGRESO DE DATOS"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "OFICIO_FACULTAD"
        accion = "REGISTRO"
        item = txt_noficio.Text


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

#Region "Conectar actividades eliminacion de actividades"
    Public Sub actividadEl()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "ELIMINACION DE REGISTRO"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "OFICIO_FACULTAD"
        accion = "ELIMINACION"
        item = txt_noficio.Text


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

#Region "BOTON CERRAR SESION"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        conexion1.Close()
        autenticacion.Show()
        Me.Close()
    End Sub
#End Region


#Region "INICIALIZACION"
    Private Sub oficiodecanato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Cargando Base de Datos" & vbNewLine & "Por favor espere.")
        Conectar()
        actividad()
        txt_numero.Enabled = False
        alerta()
    End Sub
#End Region

#Region "DATOS A LAS CAJAS DE TEXTO"
    Private Sub DgvPersonas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPersonas.CellContentClick
        Dim i As Integer = DgvPersonas.CurrentRow.Index
        txt_numero.Text = DgvPersonas(0, i).Value
        txt_noficio.Text = DgvPersonas(1, i).Value
        txt_dirigido.Text = DgvPersonas(2, i).Value
        txt_cargo.Text = DgvPersonas(3, i).Value
        txt_asunto.Text = DgvPersonas(4, i).Value
        txt_firma.Text = DgvPersonas(5, i).Value
        txt_fecha.Text = DgvPersonas(6, i).Value
        txt_solicitado.Text = DgvPersonas(7, i).Value

        Button1.Enabled = False
        txt_numero.Enabled = False
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
        consulta("SELECT * FROM oficio_sifpapv", "oficio_sifpapv")
        DgvPersonas.DataSource = datos.Tables("oficio_sifpapv")
    End Sub
#End Region


#Region "Alerta de seguridad"
    Public Sub alerta()
        enviarCorreos(emisor:="pruebaapp.2624@gmail.com", password:="jvmb pdrf bcfb zoaw", mensaje:="Se a detectado el ingreso del usuario " + autenticacion.txt_usuario.Text + "  Al departamento de OFICIO FACULTAD", asunto:="Mensaje de alerta sistema SIFPAPV", destinatario:="carmen.rivadeneiraa@ug.edu.ec, sadafatuly@hotmail.com, saadda.fatulya@ug.edu.ec")
    End Sub
#End Region

#Region "REGISTRAR"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txt_asunto.Text = "") Or (txt_noficio.Text = "") Or (txt_fecha.Text = "") Then
            MsgBox("Campos Vacios", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta5 As String = "SELECT * FROM oficio_sifpapv WHERE NUMERO_OFICIO = '" & txt_noficio.Text & "'"
                Dim ADAPTADORC As New MySqlDataAdapter(consulta5, conexion1)
                Dim datos As New DataSet
                ADAPTADORC.Fill(datos, "oficio_sifpapv")
                lista = datos.Tables("oficio_sifpapv").Rows.Count
                If lista <> 0 Then
                    MsgBox("EL CODIGO " & txt_noficio.Text & " YA EXISTE EN LA BASE DE DATOS", MsgBoxStyle.Critical, "Error")
                    'BorrarCampos()
                    txt_numero.Text = ""
                    txt_noficio.Text = ""
                    txt_asunto.Text = ""
                    txt_dirigido.Text = ""
                    txt_solicitado.Text = ""
                    txt_fecha.Text = ""


                    MostrarDatos()
                    Button1.Enabled = True
                    txt_numero.Enabled = True
                    txt_numero.Enabled = False

                Else
                    Dim ENTRADA As String = "INSERT INTO oficio_sifpapv (NUMERO_OFICIO, DIRIGIDO, CARGO, ASUNTO, FIRMADO_POR, FECHA, SOLICITADO_POR) VALUES ('" + txt_noficio.Text + "', '" + txt_dirigido.Text + "', '" + txt_cargo.Text + "', '" + txt_asunto.Text + "', '" + txt_firma.Text + "', '" + txt_fecha.Text + "', '" + txt_solicitado.Text + "')"
                    Dim DT As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(ENTRADA, conexion1)
                    ADAPTADOR.Fill(DT)
                    conexion1.Close()
                    MsgBox("Insercion correcta")
                    actividadRe()

                    'BorrarCampos()
                    txt_numero.Text = ""
                    txt_noficio.Text = ""
                    txt_dirigido.Text = ""
                    txt_cargo.Text = ""
                    txt_asunto.Text = ""
                    txt_firma.Text = ""
                    txt_fecha.Text = ""
                    txt_solicitado.Text = ""


                    MostrarDatos()
                    Button1.Enabled = True
                    txt_numero.Enabled = True
                    txt_numero.Enabled = False
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
        If (txt_asunto.Text = "") Or (txt_noficio.Text = "") Or (txt_fecha.Text = "") Then
            MsgBox("Seleccione un registro", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("UPDATE oficio_sifpapv Set NUMERO_OFICIO = '" & txt_noficio.Text & "', DIRIGIDO = '" & txt_dirigido.Text & "', CARGO = '" & txt_cargo.Text & "', ASUNTO = '" & txt_asunto.Text & "', FIRMADO_POR = '" & txt_firma.Text & "', FECHA = '" & txt_fecha.Text & "', SOLICITADO_POR = '" & txt_solicitado.Text & "' WHERE NUMERO = '" & txt_numero.Text & "'", conexion1)

            comando.ExecuteNonQuery()

            MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information, "Confirmar")
            actividadMo()

            txt_numero.Text = ""
            txt_noficio.Text = ""
            txt_dirigido.Text = ""
            txt_cargo.Text = ""
            txt_asunto.Text = ""
            txt_firma.Text = ""
            txt_fecha.Text = ""
            txt_solicitado.Text = ""

            Button1.Enabled = True
            txt_numero.Enabled = True
            txt_numero.Enabled = False
            MostrarDatos()
            If conexion1.State = ConnectionState.Open Then
                conexion1.Close()
            End If
        End If
    End Sub
#End Region

#Region "BOTON ELIMINAR"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        If (txt_asunto.Text = "") Or (txt_noficio.Text = "") Or (txt_fecha.Text = "") Then
            MsgBox("Seleccione un registro", MsgBoxStyle.Information, "Confirmar")
        Else

            Dim respuesta As String
            respuesta = InputBox("Desea Eliminar al registro: ", "Ingrese Clave")

            If respuesta = "123" Then
                Dim comando As New MySqlCommand("DELETE FROM oficio_sifpapv WHERE NUMERO ='" & txt_numero.Text & "'", conexion1)
                comando.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", MsgBoxStyle.Information, "Confirmar")
                actividadEl()
                txt_numero.Text = ""
                txt_noficio.Text = ""
                txt_dirigido.Text = ""
                txt_cargo.Text = ""
                txt_asunto.Text = ""
                txt_firma.Text = ""
                txt_fecha.Text = ""
                txt_solicitado.Text = ""

                Button1.Enabled = True
                txt_numero.Enabled = True
                txt_numero.Enabled = False
                MostrarDatos()
                If conexion1.State = ConnectionState.Open Then
                    conexion1.Close()
                    txt_numero.Enabled = False
                End If

            End If
        End If
    End Sub
#End Region

#Region "REFRESCAR"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txt_numero.Text = ""
        txt_noficio.Text = ""
        txt_dirigido.Text = ""
        txt_cargo.Text = ""
        txt_asunto.Text = ""
        txt_firma.Text = ""
        txt_fecha.Text = ""
        txt_solicitado.Text = ""

        MostrarDatos()

        Button1.Enabled = True
        txt_numero.Enabled = True
        txt_numero.Enabled = False
    End Sub
#End Region

#Region "LIMPIAR"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt_numero.Text = ""
        txt_noficio.Text = ""
        txt_dirigido.Text = ""
        txt_cargo.Text = ""
        txt_asunto.Text = ""
        txt_firma.Text = ""
        txt_fecha.Text = ""
        txt_solicitado.Text = ""

        MostrarDatos()

        Button1.Enabled = True
        txt_numero.Enabled = True
        txt_numero.Enabled = False
    End Sub
#End Region

#Region "MENU DECANATO"
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        decanato.Show()
        Me.Close()
    End Sub
#End Region

#Region "EXPORTAR EXCEL"
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        llenarExcel(DgvPersonas)
    End Sub
#End Region

#Region "BUSQUEDA POR ASUNTO"
    Private Sub NOMBREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMBREToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM oficio_sifpapv WHERE ASUNTO LIKE '%" & txt_busqueda.Text & "%'"
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

#Region "BUSQUEDA POR NUMERO DE OFICIO"
    Private Sub NUMERODEOFICIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUMERODEOFICIOToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM oficio_sifpapv WHERE NUMERO_OFICIO LIKE '%" & txt_busqueda.Text & "%'"
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

    Private Sub txt_busqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busqueda.TextChanged

    End Sub

    Private Sub txt_firma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_firma.TextChanged

    End Sub
End Class