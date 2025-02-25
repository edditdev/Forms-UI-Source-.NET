Imports System.Text

Module Server

    '# Server details
    Public server_login = "ZWRkaXQ="
    Public server_password = "QWxlTWx5bjEyMyFAIw=="

    '# User input details
    Public saved_username As String
    Public saved_password As String





    '# Decodin function
    Public Function DecodeBase64(encodedText As String) As String
        Dim bytes() As Byte = Convert.FromBase64String(encodedText)
        Return Encoding.UTF8.GetString(bytes)
    End Function

End Module

