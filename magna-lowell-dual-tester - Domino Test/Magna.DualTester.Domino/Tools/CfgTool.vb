Imports System.IO
Imports System.Xml.Serialization
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data

Public Interface ICfgDomino
    Inherits ICfg

    Overloads Function ReadConfig() As DominoCfg

    Function WriteConfig(cfg As DominoCfg) As Boolean

End Interface

Public Class CfgTool
    Implements ICfgDomino

    ''' <summary>
    ''' This is the name of the file the settings will be saved to.
    ''' </summary>
    ''' <remarks>Might be a better idea to store and load this string in the app.config</remarks>
    Private Shared ReadOnly Property FileName As String = "TesterSettings.cfg"

    Private Shared Property SettingsPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "DualTester")
    Private Shared Property FilePath As String = Path.Combine(SettingsPath, FileName)
    Private Shared _cfg As DominoCfg

    Private ReadOnly _stringdefaults As IStringDefaults

    Public Sub New(stringdefaults As IStringDefaults)
        _stringdefaults = stringdefaults

    End Sub

    Private Function CreateNewCfg() As DominoCfg
        CheckDir()
        Dim c = New DominoCfg(_stringdefaults)
        WriteConfig(c)
        _cfg = c
        Return _cfg
    End Function

    Private Shared Sub CheckDir()
        If Not Directory.Exists(SettingsPath) Then
            Directory.CreateDirectory(SettingsPath)
        End If
    End Sub

    Public Function ReadConfig() As DominoCfg Implements ICfgDomino.ReadConfig
        If File.Exists(FilePath) Then
            Using sr As New StreamReader(FilePath)
                Dim s As New XmlSerializer(GetType(DominoCfg))
                _cfg = CType(s.Deserialize(sr), DominoCfg)
            End Using
            Return _cfg
        Else
            Return CreateNewCfg()
        End If
    End Function

    Public Function WriteConfig(cfg As DominoCfg) As Boolean Implements ICfgDomino.WriteConfig
        Try
            Using sw As New StreamWriter(FilePath, False)
                Dim s As New XmlSerializer(cfg.GetType)
                s.Serialize(sw, cfg)
            End Using
        Catch ex As Exception
            Return False
        End Try
        _cfg = cfg
        Return True
    End Function

    Private Function ICfg_ReadConfig() As CfgSettings Implements ICfg.ReadConfig
        Return ReadConfig()
    End Function

End Class

'Public Class DebugCfgTool
'    Inherits DebugCfgInterface
'    Implements ICfgDomino

'    Public Sub New(stringdefaults As IStringDefaults)
'        MyBase.New(stringdefaults)

'    End Sub

'    Public Overrides Function ReadConfig() As DominoCfg Implements ICfgDomino.ReadConfig
'        Return MyBase.ReadConfig()
'    End Function

'    Public Overrides Function WriteConfig(cfg As DominoCfg) As Boolean Implements ICfgDomino.WriteConfig
'        Return MyBase.WriteConfig(cfg)
'    End Function
'End Class