Imports MySql.Data.MySqlClient
Imports System.Data
Public Class administracion
    Private cmb As MySqlCommandBuilder
    Dim conexion1 As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador1 As New MySqlDataAdapter
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
            conexion1.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_administracion;user= root;password=;"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT *FROM bd_administracion"
            adaptador1 = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador1.Fill(datos, "bd_administracion")
            DgvPersonas.DataSource = datos
            DgvPersonas.DataMember = "bd_administracion"
            'MsgBox("Conectado Correctamente")

            'Dim costes As String = "SELECT * SUM(VALOR) FROM bd_administracion"
            'Dim adaptador5 As New MySqlDataAdapter(costes, conexion1)
            'Dim datos5 As New DataSet
            'adaptador5.Fill(datos5, "bd_administracion")
            'txt_costes.Text = datos5
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "bd_administracion")
        End Try
    End Sub
#End Region

#Region "Conectar base de actividades"
    Public Sub actividad()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "INICIO DE SESION"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "ADMINISTRACION"
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
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "bd_administracion")
        End Try
    End Sub
#End Region

#Region "Conectar actividades modificar de actividades"
    Public Sub actividadMo()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "ALTERACION DE DATOS"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "ADMINISTRACION"
        accion = "MODIFICACION"
        item = txt_codinv.Text


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
        departamento = "ADMINISTRACION"
        accion = "REGISTRO"
        item = txt_codinv.Text


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
        departamento = "ADMINISTRACION"
        accion = "ELIMINACION"
        item = txt_codinv.Text


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

#Region "REGISTRAR"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txt_cantidad.Text = "") Or (txt_codinv.Text = "") Or (txt_descripcion.Text = "") Then
            MsgBox("Campos Vacios", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                'Dim consulta5 As String = "SELECT * FROM bd_administracion WHERE COD_INVENTARIO = '" & txt_codinv.Text & "'"
                ' Dim ADAPTADORC As New MySqlDataAdapter(consulta5, conexion1)
                ' Dim datos As New DataSet
                ' ADAPTADORC.Fill(datos, "bd_administracion")
                ' lista = datos.Tables("bd_administracion").Rows.Count

                'If lista <> 0 Then
                ' MsgBox("Ya existe en la base de datos", MsgBoxStyle.Critical, "Error")
                '' 'BorrarCampos()
                'txt_orden.Text = ""
                ' txt_cantidad.Text = ""
                'txt_codinv.Text = ""
                'txt_descripcion.Text = ""
                'txt_marca.Text = ""
                'txt_modelo.Text = ""
                ' txt_serie.Text = ""
                ' txt_color.Text = ""
                'txt_valor.Text = ""
                'txt_estado.Text = ""
                ' txt_area.Text = ""
                ' txt_usuario.Text = ""
                'MostrarDatos()
                'Button1.Enabled = True
                'txt_orden.Enabled = True
                'Else
                Dim ENTRADA As String = "INSERT INTO bd_administracion (CANTIDAD, COD_INVENTARIO, DESCRIPCION, MARCA, MODELO, SERIE, COLOR, VALOR, ESTADO, AREA, USUARIO, OBSERVACION) VALUES ('" + txt_cantidad.Text + "', '" + txt_codinv.Text + "', '" + txt_descripcion.Text + "', '" + txt_marca.Text + "', '" + txt_modelo.Text + "', '" + txt_serie.Text + "', '" + txt_color.Text + "', '" + txt_valor.Text + "', '" + txt_estado.Text + "', '" + txt_area.Text + "', '" + txt_usuario.Text + "', '" + txt_observacion.Text + "')"
                Dim DT As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(ENTRADA, conexion1)
                ADAPTADOR.Fill(DT)
                conexion1.Close()
                MsgBox("Insercion correcta")
                actividadRe()
                'BorrarCampos()
                txt_orden.Text = ""
                txt_cantidad.Text = ""
                txt_codinv.Text = ""
                txt_descripcion.Text = ""
                txt_busqueda.Text = ""
                txt_marca.Text = ""
                txt_modelo.Text = ""
                txt_serie.Text = ""
                txt_color.Text = ""
                txt_valor.Text = ""
                txt_estado.Text = ""
                txt_area.Text = ""
                txt_usuario.Text = ""
                txt_observacion.Text = ""
                MostrarDatos()
                Button1.Enabled = True
                txt_orden.Enabled = True
                txt_orden.Enabled = False
                'End If
            Catch ex As Exception
                MsgBox("NO SE INSERTO EL DATO", MsgBoxStyle.Critical, "Error" + ex.Message)
            Finally
                conexion1.Dispose()

            End Try


        End If
    End Sub
#End Region

#Region "INICIALIZACION"
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Cargando Base de Datos" & vbNewLine & "Por favor espere.")

        Conectar()
        actividad()
        'costes()
        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
        End If
        txt_orden.Enabled = False
        alerta()
    End Sub
#End Region

#Region "Modificar Datos"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If

        If (txt_cantidad.Text = "") Or (txt_codinv.Text = "") Or (txt_descripcion.Text = "") Then
            MsgBox("Seleccione un registro", MsgBoxStyle.Information, "Confirmar")
        Else




            Dim comando As New MySqlCommand("UPDATE bd_administracion Set CANTIDAD = '" & txt_cantidad.Text & "', COD_INVENTARIO = '" & txt_codinv.Text & "', DESCRIPCION = '" & txt_descripcion.Text & "', MARCA = '" & txt_marca.Text & "',MODELO = '" & txt_modelo.Text & "', SERIE = '" & txt_serie.Text & "', COLOR = '" & txt_color.Text & "', VALOR = '" & txt_valor.Text & "', ESTADO = '" & txt_estado.Text & "', AREA = '" & txt_area.Text & "', USUARIO = '" & txt_usuario.Text & "', OBSERVACION = '" + txt_observacion.Text + "' WHERE ORDEN = '" & txt_orden.Text & "'", conexion1)
            comando.ExecuteNonQuery()
            MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information, "Confirmar")


            actividadMo()

            txt_orden.Text = ""
            txt_cantidad.Text = ""
            txt_codinv.Text = ""
            txt_descripcion.Text = ""
            txt_busqueda.Text = ""
            txt_marca.Text = ""
            txt_modelo.Text = ""
            txt_serie.Text = ""
            txt_estado.Text = ""
            txt_color.Text = ""
            txt_valor.Text = ""
            txt_estado.Text = ""
            txt_area.Text = ""
            txt_usuario.Text = ""
            txt_observacion.Text = ""
            Button1.Enabled = True
            txt_orden.Enabled = True
            txt_orden.Enabled = False
            MostrarDatos()


            








            If conexion1.State = ConnectionState.Open Then
                conexion1.Close()

            End If
        End If
    End Sub
#End Region

#Region "Mostrar Datos"

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        datos.Tables.Clear()
        adaptador1 = New MySqlDataAdapter(sql, conexion1)
        cmb = New MySqlCommandBuilder(adaptador1)
        adaptador1.Fill(datos, tabla)
    End Sub
    Public Sub MostrarDatos()
        consulta("SELECT * FROM bd_administracion", "bd_administracion")
        DgvPersonas.DataSource = datos.Tables("bd_administracion")
    End Sub

#End Region

#Region "Limpiar"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        txt_orden.Text = ""
        txt_cantidad.Text = ""
        txt_codinv.Text = ""
        txt_descripcion.Text = ""
        txt_busqueda.Text = ""
        txt_marca.Text = ""
        txt_modelo.Text = ""
        txt_serie.Text = ""
        txt_color.Text = ""
        txt_valor.Text = ""
        txt_estado.Text = ""
        txt_area.Text = ""
        txt_usuario.Text = ""
        txt_observacion.Text = ""
        MostrarDatos()



        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            Button1.Enabled = False

        Else



            Button1.Enabled = True
            txt_orden.Enabled = True
            txt_orden.Enabled = False
        End If


    End Sub
#End Region

#Region "Eliminar datos"
    Private Sub button4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        If (txt_cantidad.Text = "") Or (txt_codinv.Text = "") Or (txt_descripcion.Text = "") Then
            MsgBox("seleccione un registro", MsgBoxStyle.Information, "confirmar")
        Else

            Dim respuesta As String
            Dim respuesta2 As String
            respuesta = InputBox("Desea eliminar al registro: ", "ingrese clave")
            If respuesta = "123" Then
                respuesta2 = InputBox("Ingrese Razon por la que desea eliminar: ", "Ingresar")
                Dim ENTRADA1 As String = "INSERT INTO papelera_administracion (CANT, COD_INVENTARIO, DESCRIPCION, MARCA, MODELO, SERIE, COLOR, VALOR, ESTADO, AREA, USUARIO, OBSERVACION, MOTIVO) VALUES ('" + txt_cantidad.Text + "', '" + txt_codinv.Text + "', '" + txt_descripcion.Text + "', '" + txt_marca.Text + "', '" + txt_modelo.Text + "', '" + txt_serie.Text + "', '" + txt_color.Text + "', '" + txt_valor.Text + "', '" + txt_estado.Text + "', '" + txt_area.Text + "', '" + txt_usuario.Text + "', '" + txt_observacion.Text + "', '" + respuesta2 + "')"
                Dim DT1 As New DataTable
                Dim ADAPTADOR1 As New MySqlDataAdapter(ENTRADA1, conexion1)
                ADAPTADOR1.Fill(DT1)





                Dim comando As New MySqlCommand("delete from bd_administracion where orden ='" & txt_orden.Text & "'", conexion1)
                comando.ExecuteNonQuery()
                MsgBox("datos eliminados correctamente", MsgBoxStyle.Information, "confirmar")
                actividadEl()

                txt_orden.Text = ""
                txt_cantidad.Text = ""
                txt_codinv.Text = ""
                txt_descripcion.Text = ""
                txt_busqueda.Text = ""
                txt_marca.Text = ""
                txt_modelo.Text = ""
                txt_serie.Text = ""
                txt_color.Text = ""
                txt_valor.Text = ""
                txt_estado.Text = ""
                txt_area.Text = ""
                txt_usuario.Text = ""
                txt_observacion.Text = ""

                MostrarDatos()
                Button1.Enabled = True
                txt_orden.Enabled = True
                txt_orden.Enabled = False
                If conexion1.State = ConnectionState.Open Then
                    conexion1.Close()
                    txt_orden.Enabled = False
                End If

            End If
        End If

    End Sub
#End Region

#Region "Busqueda Codigo de Inventario"

    Private Sub CODINVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODINVToolStripMenuItem1.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_administracion WHERE COD_INVENTARIO LIKE '%" & txt_busqueda.Text & "%'"
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

#Region "Busqueda Descripcion"

    Private Sub DESCRIPCIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESCRIPCIONToolStripMenuItem1.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_administracion WHERE DESCRIPCION LIKE '%" & txt_busqueda.Text & "%'"
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

#Region "Datos hacia los txt"


    Private Sub DgvPersonas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPersonas.CellContentClick
        Dim i As Integer = DgvPersonas.CurrentRow.Index
        txt_orden.Text = DgvPersonas(0, i).Value
        txt_cantidad.Text = DgvPersonas(1, i).Value
        txt_codinv.Text = DgvPersonas(2, i).Value
        txt_descripcion.Text = DgvPersonas(3, i).Value
        txt_marca.Text = DgvPersonas(4, i).Value
        txt_modelo.Text = DgvPersonas(5, i).Value
        txt_serie.Text = DgvPersonas(6, i).Value
        txt_color.Text = DgvPersonas(7, i).Value
        txt_valor.Text = DgvPersonas(8, i).Value
        txt_estado.Text = DgvPersonas(9, i).Value
        txt_area.Text = DgvPersonas(10, i).Value
        txt_usuario.Text = DgvPersonas(11, i).Value
        txt_observacion.Text = DgvPersonas(12, i).Value



        

        Button1.Enabled = False
        txt_orden.Enabled = False

    End Sub
#End Region

#Region "HACIA LA PAPELERA"
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        papelera.Show()
        Me.Close()
    End Sub
#End Region

#Region "MENU PRINCIPAL"
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        principal.Show()
        Me.Close()

    End Sub
#End Region

#Region "Cerrar sesion"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        conexion1.Close()
        autenticacion.Show()
        Me.Close()
    End Sub
#End Region

#Region "REFRESCAR"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txt_orden.Text = ""
        txt_cantidad.Text = ""
        txt_codinv.Text = ""
        txt_descripcion.Text = ""
        txt_busqueda.Text = ""
        txt_marca.Text = ""
        txt_modelo.Text = ""
        txt_serie.Text = ""
        txt_color.Text = ""
        txt_valor.Text = ""
        txt_estado.Text = ""
        txt_area.Text = ""
        txt_usuario.Text = ""
        txt_observacion.Text = ""
        MostrarDatos()




        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
            txt_orden.Enabled = True
            txt_orden.Enabled = False
        End If

    End Sub
#End Region

#Region "BOTON REGRESAR"
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        principal.Show()
        Me.Close()
    End Sub
#End Region

#Region "BUSQUEDA POR AREA"
    Private Sub AREAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AREAToolStripMenuItem.Click

        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        Dim ENTRADA1 As String = "SELECT *FROM bd_administracion WHERE AREA LIKE '%" & txt_busqueda.Text & "%'"
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

#Region "Exportar Excel"
    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        llenarExcel(DgvPersonas)
    End Sub
#End Region

#Region "Alerta de seguridad"
    Public Sub alerta()
        enviarCorreos(emisor:="pruebaapp.2624@gmail.com", password:="jvmb pdrf bcfb zoaw", mensaje:="Se a detectado el ingreso del usuario " + autenticacion.txt_usuario.Text + "  Al departamento de Administracion ", asunto:="Mensaje de alerta sistema SIFPAPV", destinatario:="carmen.rivadeneiraa@ug.edu.ec, sadafatuly@hotmail.com, saadda.fatulya@ug.edu.ec, efrain.suarezm@ug.edu.ec")
    End Sub
#End Region

#Region "COSTO TOTAL DE BIENES"
    'Public Sub costes()
    '    Dim total As String = 0
    '    Dim fila3 As DataGridViewRow = New DataGridViewRow()

    '    For Each fila3 In DgvPersonas.Rows
    '        'total = total + fila3.Cells(13).Value
    '        'total = total + Convert.ToDouble(fila3.Cells(8).Value)
    '        total = total + "$" & FormatNumber(fila3.Cells(13).Value)

    '    Next
    '    txt_costes.Text = "$" & FormatNumber(total)

    '    'txt_costes.Text = Convert.ToDouble(total)
    '    'txt_costes.Text = total
    'End Sub
#End Region
    
End Class