Imports MySql.Data.MySqlClient
Public Class papelera
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

    Dim v_orden As String
    Dim v_cantidad As String
    Dim v_codiv As String
    Dim v_descripcion As String
    Dim v_marca As String
    Dim v_modelo As String
    Dim v_serie As String
    Dim v_color As String
    Dim v_valor As String
    Dim v_estado As String
    Dim v_area As String
    Dim v_usuario As String
    Dim v_observacion As String
    Dim v_razon As String

#Region "Conectar"
    Public Sub Conectar1()
        Try
            conexion1.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_administracion;user= root;password=;"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT *FROM papelera_administracion"
            adaptador1 = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador1.Fill(datos, "papelera_administracion")
            DgvPersonas.DataSource = datos
            DgvPersonas.DataMember = "papelera_administracion"
            'MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "papelera_administracion")
        End Try
    End Sub
#End Region

#Region "Conectar base de actividades"
    Public Sub actividad()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "INICIO DE SESION"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "PAPELERA ADMINISTRACION"
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

#Region "Conectar actividades restauracion de actividades"
    Public Sub actividadReS()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "RESTAURACION DE REGISTRO"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "PAPELERA ADMINISTRACION"
        accion = "RESTAURACION"
        item = v_codiv
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

#Region "Conectar actividades eliminacion deifinitiva de actividades"
    Public Sub actividadElD()
        hora1 = TimeOfDay.TimeOfDay.ToString
        fecha1 = Date.Today
        mensaje = "ELIMINACION PERMANENTE DE REGISTRO"
        usuario4 = autenticacion.txt_usuario.Text
        departamento = "PAPELERA ADMINISTRACION"
        accion = "ELIMINACION DEFINITIVA"
        item = v_codiv


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

#Region "BOTON ATRAS"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conexion1.Close()
        administracion.Show()
        Me.Close()
    End Sub
#End Region

#Region "INICIALIZACION"
    Private Sub papelera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Cargando Base de Datos" & vbNewLine & "Por favor espere.")

        Conectar1()
        actividad()
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

#Region "BOTON REGRESAR"
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        principal.Show()
        Me.Close()
    End Sub
#End Region

#Region "REFRESCAR"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MostrarDatos()
    End Sub
#End Region

#Region "MOSTRAR DATOS"
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        datos.Tables.Clear()
        adaptador1 = New MySqlDataAdapter(sql, conexion1)
        cmb = New MySqlCommandBuilder(adaptador1)
        adaptador1.Fill(datos, tabla)
    End Sub
    Public Sub MostrarDatos()
        consulta("SELECT * FROM papelera_administracion", "papelera_administracion")
        DgvPersonas.DataSource = datos.Tables("papelera_administracion")
    End Sub
#End Region

#Region "DATOS HACIAS LAS VARIABLES"
    Private Sub DgvPersonas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPersonas.CellContentClick
        Dim i As Integer = DgvPersonas.CurrentRow.Index
        v_orden = DgvPersonas(0, i).Value
        v_cantidad = DgvPersonas(1, i).Value
        v_codiv = DgvPersonas(2, i).Value
        v_descripcion = DgvPersonas(3, i).Value
        v_marca = DgvPersonas(4, i).Value
        v_modelo = DgvPersonas(5, i).Value
        v_serie = DgvPersonas(6, i).Value
        v_color = DgvPersonas(7, i).Value
        v_valor = DgvPersonas(8, i).Value
        v_estado = DgvPersonas(9, i).Value
        v_area = DgvPersonas(10, i).Value
        v_usuario = DgvPersonas(11, i).Value
        v_observacion = DgvPersonas(12, i).Value
        v_razon = DgvPersonas(13, i).Value





    End Sub
#End Region

#Region "RESTAURAR DATOS"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        If (v_cantidad = "") Or (v_codiv = "") Or (v_descripcion = "") Then
            MsgBox("seleccione un registro", MsgBoxStyle.Information, "confirmar")
        Else
            Try
                Dim consulta5 As String = "SELECT * FROM bd_administracion WHERE COD_INVENTARIO = '" & v_codiv & "'"
                Dim ADAPTADORC As New MySqlDataAdapter(consulta5, conexion1)
                Dim datos As New DataSet
                ADAPTADORC.Fill(datos, "bd_administracion")
                lista = datos.Tables("bd_administracion").Rows.Count
                If lista <> 0 Then
                    MsgBox("Ya existe en la base de datos", MsgBoxStyle.Critical, "Error")
                Else
                    Dim ENTRADA As String = "INSERT INTO bd_administracion (CANTIDAD, COD_INVENTARIO, DESCRIPCION, MARCA, MODELO, SERIE, COLOR, VALOR, ESTADO, AREA, USUARIO, OBSERVACION) VALUES ('" + v_cantidad + "', '" + v_codiv + "', '" + v_descripcion + "', '" + v_marca + "', '" + v_modelo + "', '" + v_serie + "', '" + v_color + "', '" + v_valor + "', '" + v_estado + "', '" + v_area + "', '" + v_usuario + "', '" + v_observacion + "')"
                    Dim DT As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(ENTRADA, conexion1)
                    ADAPTADOR.Fill(DT)




                    Dim comando As New MySqlCommand("delete from papelera_administracion where orden ='" & v_orden & "'", conexion1)
                    comando.ExecuteNonQuery()
                    MsgBox("Datos Restaurados Correctamente", MsgBoxStyle.Information, "confirmar")

                    actividadReS()


                    MostrarDatos()
                    conexion1.Close()
                End If


            Catch ex As Exception

                MsgBox("NO SE RESTAURO EL DATO EL DATO", MsgBoxStyle.Critical, "Error" + ex.Message)
            Finally
                conexion1.Dispose()

            End Try
        End If

    End Sub
#End Region

#Region "ELIMINAR DEFINITIVAMENTE"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        If (v_cantidad = "") Or (v_codiv = "") Or (v_descripcion = "") Then
            MsgBox("seleccione un registro", MsgBoxStyle.Information, "confirmar")
        Else

            Dim respuesta As String

            respuesta = InputBox("Desea eliminar permanentemente el registro: ", "ingrese clave")
            If respuesta = "123" Then


                Dim comando As New MySqlCommand("delete from papelera_administracion where orden ='" & v_orden & "'", conexion1)
                comando.ExecuteNonQuery()
                MsgBox("datos eliminados correctamente", MsgBoxStyle.Information, "confirmar")
                actividadElD()


                MostrarDatos()

                If conexion1.State = ConnectionState.Open Then
                    conexion1.Close()

                End If

            End If
        End If
    End Sub
#End Region
End Class