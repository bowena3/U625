Public Class Form1
    Dim prnFile As String = <xml>^XA^CFE^FS
                            ^PRA^FS
                            ^MMP^FS
                            ^MNY^FS
                            ^LL0105^FS
                            ^FWR^FS
                            ^FO0100,0092^A0N,16^FD$PN$^FS
                            ^FO047,002^A0N,18^FD50968^FS
                            ^FO0150,0002^A0N,18^FDMM-DD-YY^FS
                            ^FO0170,0019^A0N,18^FDHH:MM:SS^FS
                            ^FO035,0019^A0N,18^FD MDM^FS
                            ^FO0060,0038^BY1.4^BCN,50,N,N,N^FDP$PN$^FS
                            ^FO0120,0019^A0N,18^FD $PACKER$^FS
                            ^FO085,0019^A0N,18^FD ID:^FS
                            ^XZ
                            </xml>.Value
    Dim pn = "pn101"
    Dim mmddyy As DateTime = DateTime.Now
    Dim hhmmss As DateTime = DateTime.Now
    Property Packer As String
        Get
            Return If(IsNothing(TextBox2), String.Empty, TextBox2.Text)
        End Get
        Set(value As String)
            TextBox2.Text = value
        End Set
    End Property
    Dim dict As Dictionary(Of String, String) = New Dictionary(Of String, String) From {{"$PN$", pn},
                                                                                        {"MM-DD-YY", mmddyy.ToString("MM-dd-yy")},
                                                                                        {"HH:MM:SS", hhmmss.ToString("HH:mm:ss")},
                                                                                        {"$PACKER$", Packer}}

    Public Sub New()
        InitializeComponent()
        txtDisp.Text = prnFile

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each key In dict.Keys
            prnFile = prnFile.Replace(key, dict(key))
        Next
        txtDisp.Text = prnFile
    End Sub
End Class
