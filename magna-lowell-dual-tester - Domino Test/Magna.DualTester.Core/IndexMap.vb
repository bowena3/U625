Imports System.Xml.Serialization

Public MustInherit Class IndexMap(Of T)
    Public Property Index As Integer
    Public Property Value As T

    <XmlIgnore()>
    Public Property IndexOutOfRange As Boolean


    'Public Shadows Function Equals(cm As IndexMap) As Boolean
    '    Return Index = cm.Index
    'End Function
End Class