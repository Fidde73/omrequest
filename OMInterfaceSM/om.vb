Public Class om
    Public Function AddRequest(URL As String, ServiceGroupID As Integer, IVRLabel As String, IVRData As String) As String
        Try
            Dim aLabel As Array = IVRLabel.Split("|")
            Dim aData As Array = IVRData.Split("|")
            Dim om As New OpenMedia.OpenMediaService
            om.Url = URL
            Dim add As New OpenMedia.AddOpenMediaRequest
            Dim ivr(0 To aLabel.Length - 1) As OpenMedia.IVRInformation
            add.ServiceGroupID = ServiceGroupID
            'For Each i In ivr
            '    i = New OpenMedia.IVRInformation
            'Next
            For ix As Integer = 0 To aLabel.Length - 1
                ivr(ix) = New OpenMedia.IVRInformation
                ivr(ix).Label = aLabel(ix)
                ivr(ix).Data = aData(ix)
            Next

            'ivr(0) = New OpenMedia.IVRInformation
            'ivr(0).Label = IVRLabel
            'ivr(0).Data = IVRData
            add.IVRInfo = ivr
            add.ServiceGroupIDSpecified = True
            'add.IVRInfo(0).Label = "Info"
            'add.IVRInfo(0).Data = "test"
            Dim status As OpenMedia.AddOpenMediaResponse = om.AddRequest(add)
            If status.RequestStatus = 0 Then
                Return "ok"
            Else
                Return "Error: " + status.RequestStatus.ToString
            End If
        Catch ex As Exception
            Return "Error: " + ex.Message
        End Try
    End Function

End Class
