Public Class decanato

#Region "BOTON CERRAR SESION"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        autenticacion.Show()
        Me.Close()
    End Sub
#End Region
#Region "MENU PRINCIPAL"
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        principal.Show()
        Me.Close()
    End Sub
#End Region
#Region "BOTON CIRCULAR"
    Private Sub BT_CIRCULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CIRCULAR.Click
        circular.Show()
        Me.Close()
    End Sub
#End Region
#Region "BOTON OFICIO"
    Private Sub BT_OFICIOQX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_OFICIOQX.Click
        oficioquipux.Show()
        Me.Close()
    End Sub
#End Region
#Region "BOTON OFICIO FACULTAD"
    Private Sub BT_OFICIOF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_OFICIOF.Click
        oficiodecanato.Show()
        Me.Close()
    End Sub
#End Region
#Region "BOTON MEMORANDUN"
    Private Sub BT_MEMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MEMO.Click
        memorandum.Show()
        Me.Close()
    End Sub
#End Region

    Private Sub decanato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class