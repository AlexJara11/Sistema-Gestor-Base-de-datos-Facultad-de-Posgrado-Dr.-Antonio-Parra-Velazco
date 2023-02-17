Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class autenticacion
    Dim conexion1 As New MySqlConnection

#Region "CONECTAR"
    Public Sub Conectar1()
        Try
            conexion1.ConnectionString = "server=10.87.130.30;port=8089;database=autenticacion;user= root;password=;"
            conexion1.Open()
            'MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox("Error al abrir conexion: " + ex.Message, MsgBoxStyle.Critical, "SIFAPV")
        End Try
    End Sub
#End Region

#Region "INICIALIZACION"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Estableciendo conexion con el Servidor." & vbNewLine & "Por favor espere.")
        txt_clave.PasswordChar = "*"
        Conectar1()
    End Sub
#End Region

#Region "BOTON LOGIN"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If conexion1.State = ConnectionState.Closed Then
                conexion1.Open()
            End If
            Dim query As String = String.Empty
            query = "SELECT *FROM au_usuario WHERE USUARIO='" & txt_usuario.Text & "' AND CLAVE='" & txt_clave.Text & "'"

            Dim mysqlcommand As MySqlCommand
            mysqlcommand = New MySqlCommand(query, conexion1)
            Dim tabla As MySqlDataReader
            tabla = mysqlcommand.ExecuteReader
            Dim cantidad As Integer = 0

            While tabla.Read
                cantidad += 1

            End While


            If cantidad = 1 Then
                MsgBox("USUARIO Y CONTRASEÑA CORRECTAS")
                principal.Show()

                Me.Hide()

            ElseIf cantidad > 1 Then
                MsgBox("ERROR: HAY DATOS DUPLICADOS")
            ElseIf txt_usuario.Text = "" Or txt_clave.Text = "" Then
                MsgBox("CAMPOS VACIOS")
            Else
                MsgBox("ERROR: USUARIO Y CONTRASEÑA NO VALIDOS")



            End If
            conexion1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion1.Dispose()
        End Try
    End Sub
#End Region

#Region "SALIR"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conexion1.Close()
        Me.Close()

    End Sub
#End Region

#Region "MAYUSCULAS"
    Private Sub txt_usuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_usuario.TextChanged
        txt_usuario.CharacterCasing = CharacterCasing.Upper
        txt_clave.CharacterCasing = CharacterCasing.Upper
    End Sub
#End Region

#Region "MOSTRAR CLAVE"
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_clave.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            txt_clave.PasswordChar = "*"

        End If
    End Sub
#End Region

End Class
