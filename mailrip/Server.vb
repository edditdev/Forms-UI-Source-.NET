Imports System.Text

Module Server
    Public server_login = "ZWRkaXQ="
    Public server_password = "QWxlTWx5bjEyMyFAIw=="


    '# Decodin function
    Public Function DecodeBase64(encodedText As String) As String
        Dim bytes() As Byte = Convert.FromBase64String(encodedText)
        Return Encoding.UTF8.GetString(bytes)
    End Function

End Module

