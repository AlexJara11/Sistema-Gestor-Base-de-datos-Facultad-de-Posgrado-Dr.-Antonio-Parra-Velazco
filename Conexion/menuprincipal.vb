Public Class principal
#Region "INICIALIZACION"
    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If autenticacion.txt_usuario.Text = "DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            BT_ADMINISTRACION.Enabled = True
            BT_BIBLIOTECA.Enabled = True
            BT_SECRETARIA.Enabled = True
            BT_DECANATO.Enabled = True
        ElseIf autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            BT_ADMINISTRACION.Enabled = True
            BT_BIBLIOTECA.Enabled = True
            BT_SECRETARIA.Enabled = True
            BT_DECANATO.Enabled = True
        ElseIf autenticacion.txt_usuario.Text = "SECRETARIA GENERAL" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            BT_ADMINISTRACION.Enabled = False
            BT_BIBLIOTECA.Enabled = False
            BT_DECANATO.Enabled = False
            BT_SECRETARIA.Enabled = True
        ElseIf autenticacion.txt_usuario.Text = "ADMINISTRACION" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            BT_ADMINISTRACION.Enabled = True
            BT_DECANATO.Enabled = False
            BT_BIBLIOTECA.Enabled = False
            BT_SECRETARIA.Enabled = False
        ElseIf autenticacion.txt_usuario.Text = "BIBLIOTECA" Or autenticacion.txt_usuario.Text = "ASISTENTE DECANATO" Then
            BT_ADMINISTRACION.Enabled = False
            BT_BIBLIOTECA.Enabled = True
            BT_SECRETARIA.Enabled = False
            BT_DECANATO.Enabled = False
        End If

    End Sub
#End Region

#Region "BOTON ADMINISTRACION"
    Private Sub BT_ADMINISTRACION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADMINISTRACION.Click
        administracion.Show()
        Me.Close()
    End Sub
#End Region

#Region "BOTON SECRETARIA"
    Private Sub BT_SECRETARIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SECRETARIA.Click
        secretaria.Show()
        Me.Close()
    End Sub
#End Region

#Region "BOTON BIBLIOTECA"
    Private Sub BT_BIBLIOTECA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_BIBLIOTECA.Click
        biblioteca.Show()
        Me.Close()
    End Sub
#End Region

#Region "CERRAR SESION"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        autenticacion.Show()
        Me.Close()
    End Sub
#End Region

#Region "Boton Actividades"
    Private Sub BT_ACTIVIDAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ACTIVIDAD.Click
        seguridad.Show()
        Me.Close()
    End Sub
#End Region


#Region "BOTON DECANATO"
    Private Sub BT_DECANATO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DECANATO.Click
        decanato.Show()
        Me.Close()
    End Sub
#End Region

End Class