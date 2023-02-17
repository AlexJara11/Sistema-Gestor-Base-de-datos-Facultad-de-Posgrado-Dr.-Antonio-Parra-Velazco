

Imports MySql.Data.MySqlClient
Public Class seguridad
    Private cmb As MySqlCommandBuilder
    Dim conexion1 As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador1 As New MySqlDataAdapter
    Dim lista As Byte

#Region "Conectar"
    Public Sub Conectar1()
        Try
            conexion1.ConnectionString = "server=10.87.130.30;port=8089;database=dpto_seguridad;user= root;password=;"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT *FROM ingreso_usuarios"
            adaptador1 = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador1.Fill(datos, "ingreso_usuarios")
            DgvActividad.DataSource = datos
            DgvActividad.DataMember = "ingreso_usuarios"
            'MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "ingreso_usuarios")
        End Try
    End Sub
#End Region

#Region "Cerrar Sesion"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        autenticacion.Show()
        Me.Close()
    End Sub
#End Region
#Region "Inializacion"
    Private Sub seguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Cargando Base de Datos" & vbNewLine & "Por favor espere.")
        Conectar1()
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
        consulta("SELECT * FROM ingreso_usuarios", "ingreso_usuarios")
        DgvActividad.DataSource = datos.Tables("ingreso_usuarios")
    End Sub
#End Region

#Region "Refrescar"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MostrarDatos()
    End Sub
#End Region

#Region "Regresar"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conexion1.Close()
        principal.Show()
        Me.Close()
    End Sub
#End Region

#Region "Busqueda Secretaria General"
    Private Sub NOMBREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMBREToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM ingreso_usuarios WHERE DEPARTAMENTO LIKE '%" & "SECRETARIA GENERAL" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvActividad.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Busqueda Administracion"
    Private Sub APELLIDOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APELLIDOToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM ingreso_usuarios WHERE DEPARTAMENTO LIKE '%" & "ADMINISTRACION" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvActividad.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BIBLIOTECA"
    Private Sub VERSIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERSIONToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM ingreso_usuarios WHERE DEPARTAMENTO LIKE '%" & "BIBLIOTECA" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvActividad.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BUSQUEDA PAPELERA ADMINISTRACION"
    Private Sub PAPELERAADMINISTRACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAPELERAADMINISTRACIONToolStripMenuItem.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If


        Dim ENTRADA1 As String = "SELECT *FROM ingreso_usuarios WHERE DEPARTAMENTO LIKE '%" & "PAPELERA" & "%'"
        Dim ADAPTADOR2 As New MySqlDataAdapter(ENTRADA1, conexion1)
        datos = New DataSet
        ADAPTADOR2.Fill(datos)
        If conexion1.State = ConnectionState.Open Then
            conexion1.Close()
        End If
        Try
            DgvActividad.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub DgvActividad_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvActividad.CellContentClick

    End Sub
End Class