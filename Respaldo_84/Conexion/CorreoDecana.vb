﻿Imports System.Net
Imports System.Net.Mail
Module CorreoDecana
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Sub enviarCorreos(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String)
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)


            'Datos importantes no modificables para tener acceso a las cuentas
            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True
            envios.Send(correos)

            MsgBox("El mensaje fue enviado correctamente", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
