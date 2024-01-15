Imports System.IO
Imports System.Net
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports testomrequest.om

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CLI As String = "0708241038"
        Dim SiteID As String = "XZY-122"
        Dim Status As String = "Cells partially locked"

        Dim add As New OMInterfaceSM.om
        Dim result As String = add.AddRequest("http://demolemicce:12615/OpenMediaService", 10, "Caller Number|SiteID|Status", CLI + "|" + SiteID + "|" + Status)
        If result = "ok" Then
        Else

        End If
        Debug.Print(result)
        'Dim om As New om.OpenMediaService
        'Dim add As New om.AddOpenMediaRequest
        'Dim ivr(0 To 0) As IVRInformation
        'add.ServiceGroupID = 10
        'ivr(0) = New IVRInformation
        'ivr(0).Label = "Info"
        'ivr(0).Data = "nån data"
        'add.IVRInfo = ivr
        'add.ServiceGroupIDSpecified = True
        ''add.IVRInfo(0).Label = "Info"
        ''add.IVRInfo(0).Data = "test"
        'If om.AddRequest(add).RequestStatus = 0 Then
        '    Debug.Print("ok")
        'Else
        '    Debug.Print("nok")
        'End If
        'Dim Request As HttpWebRequest
        'Dim Response As HttpWebResponse
        'Dim DataStream As Stream
        'Dim Reader As StreamReader
        'Dim SoapByte() As Byte
        'Dim SoapStr As String
        'Dim pSuccess As Boolean = True

        'SoapStr = "<?xml version=""1.0"" encoding=""utf-8""?>"
        'SoapStr = SoapStr & "<soapenv:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"
        ''SoapStr = SoapStr & " xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">" & vbCrLf
        ''SoapStr = SoapStr & " xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"
        ''SoapStr = SoapStr & "<soapenv:Header/>"

        'SoapStr = SoapStr & "<soap:Body>"
        'SoapStr = SoapStr & "<AddRequest "
        'SoapStr = SoapStr & "xmlns=""http://tempuri.org/"">"
        'SoapStr = SoapStr & "<request>"
        'SoapStr = SoapStr & "<ForceToPreferredAgent "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "false"
        'SoapStr = SoapStr & "</ForceToPreferredAgent>"
        'SoapStr = SoapStr & "<IVRInfo "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "<IVRInformation>"
        'SoapStr = SoapStr & "<Data>"
        'SoapStr = SoapStr & "from scriptmanager"
        'SoapStr = SoapStr & "</Data>"
        'SoapStr = SoapStr & "<Label>"
        'SoapStr = SoapStr & "Info"
        'SoapStr = SoapStr & "</Label>"
        'SoapStr = SoapStr & "</IVRInformation>"
        'SoapStr = SoapStr & "<IVRInformation>"
        'SoapStr = SoapStr & "<Data/>"
        'SoapStr = SoapStr & "<Label/>"
        'SoapStr = SoapStr & "</IVRInformation>"
        'SoapStr = SoapStr & "<IVRInformation>"
        'SoapStr = SoapStr & "<Data/>"
        'SoapStr = SoapStr & "<Label/>"
        'SoapStr = SoapStr & "</IVRInformation>"
        'SoapStr = SoapStr & "</IVRInfo>"
        'SoapStr = SoapStr & "<PreferredAgentID "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "0"
        'SoapStr = SoapStr & "</PreferredAgentID>"
        'SoapStr = SoapStr & "<PreferredAgentLogonID "
        'SoapStr = SoapStr & "xsi:nil=""true"" "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts""/>"
        'SoapStr = SoapStr & "<PrivateData "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts""/>"
        'SoapStr = SoapStr & "<QueueStartTime "
        'SoapStr = SoapStr & "xsi:nil=""true"" "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts""/>"
        'SoapStr = SoapStr & "<ServiceGroupID "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "10"
        'SoapStr = SoapStr & "</ServiceGroupID>"
        'SoapStr = SoapStr & "<ServiceGroupName "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts""/>"
        'SoapStr = SoapStr & "<SessionPriority "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "0"
        'SoapStr = SoapStr & "</SessionPriority>"
        'SoapStr = SoapStr & "<TenantID "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "-1"
        'SoapStr = SoapStr & "</TenantID>"
        'SoapStr = SoapStr & "<TypeOfSession "
        'SoapStr = SoapStr & "xmlns=""http://schemas.datacontract.org/2004/07/Solidus.OpenMedia.Contracts.DataContracts"">"
        'SoapStr = SoapStr & "0"
        'SoapStr = SoapStr & "</TypeOfSession>"
        'SoapStr = SoapStr & "</request>"
        'SoapStr = SoapStr & "</AddRequest>"
        'SoapStr = SoapStr & "</soap:Body>"

        ''SoapStr = SoapStr & "<soapenv:Body>"
        ''SoapStr = SoapStr & "<ns:getAuth> <delisId>id</delisId> <password>pass</password> <messageLanguage>de_DE</messageLanguage> </ns:getAuth>"
        ''SoapStr = SoapStr & "</soapenv:Body>"
        'SoapStr = SoapStr & "</soapenv:Envelope>"

        'Debug.Print(SoapStr)
        'Try
        '    SoapByte = System.Text.Encoding.UTF8.GetBytes(SoapStr)

        '    Request = WebRequest.Create("http://demolemicce:12615/OpenMediaService")
        '    Request.UserAgent = "Mozilla/ 4.0(compatible; MSIE 6.0; MS Web Services Client Protocol 2.0.50727.9171)"
        '    Request.ContentType = "text/xml; charset=utf-8"
        '    Request.Headers.Add("SOAPAction", """http://tempuri.org/IOpenMediaService/AddRequest""")
        '    Request.ContentLength = SoapByte.Length
        '    Request.Method = "POST"

        '    DataStream = Request.GetRequestStream()
        '    DataStream.Write(SoapByte, 0, SoapByte.Length)
        '    DataStream.Close()

        '    Response = Request.GetResponse()
        '    DataStream = Response.GetResponseStream()
        '    Reader = New StreamReader(DataStream)
        '    Dim SD2Request As String = Reader.ReadToEnd()
        '    Debug.Print(SD2Request)
        '    DataStream.Close()
        '    Reader.Close()
        '    Response.Close()

        'Catch ex As WebException
        '    MsgBox(ex.ToString())
        'End Try
    End Sub
End Class
