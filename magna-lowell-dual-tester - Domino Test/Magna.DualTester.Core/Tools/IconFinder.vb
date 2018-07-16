Imports System.Drawing
Imports System.IO

Public Class IconFinder


    Private ReadOnly Property DirectoryName As String
        Get
            Return Path.Combine(Environment.CurrentDirectory, "PartOptionIcons")
        End Get
    End Property

    Public Function GetImage(name As String) As Bitmap
        Dim img As Bitmap = Nothing
        If Not IO.Directory.Exists(DirectoryName) Then
            IO.Directory.CreateDirectory(DirectoryName)
        End If


        Dim files = IO.Directory.EnumerateFileSystemEntries(DirectoryName).ToList()

        Dim find = files.SingleOrDefault(Function(x) System.IO.Path.GetFileNameWithoutExtension(x).ToLower() = name.ToLower())

        If find IsNot Nothing Then
            img = New Bitmap(Image.FromFile(find))
        Else
            img = TryCast(My.Resources.ResourceManager.GetObject(name), Bitmap)
        End If
        Return img
    End Function


End Class
