Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Tools
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Plc.Core.Tools

Public Class Bindings
    Inherits Ninject.Modules.NinjectModule

    Public Overrides Sub Load()

        If My.Application.CommandLineArgs.Contains("debug") Then
            'Bind(Of ICfgDomino).To(Of DebugCfgTool)()
            Bind(Of IUserWatch).To(Of DebugUserWatch).InSingletonScope()
        Else
            Bind(Of ICfgDomino, ICfg).To(Of CfgTool)()
            Bind(Of IUserWatch).To(Of UserWatch).InSingletonScope()
        End If
        Bind(Of IStringDefaults).To(Of StringDefaults).InSingletonScope()
        Bind(Of IAsTest).To(Of AsTest).InSingletonScope()
        Bind(Of IMessageAlertService, IPlcAlertService).To(Of MessageAlertService).InSingletonScope()
        Bind(Of IPlcCfgFactory).To(Of PlcCfgFactory).InSingletonScope()
        Bind(Of IPlc, IPlc(Of Udt_tester)).To(Of AsConnection(Of Udt_tester)).InSingletonScope()
        Bind(Of ILanguageWatch).To(Of LanguageWatch).InSingletonScope()
        'Bind(Of IPrint).To(Of PrintService).InSingletonScope()
        Bind(Of IBarcodeScanner).To(Of BarCodeScanner).InSingletonScope()
        Bind(Of IPlcFullRepo, IPlcDataRepo).To(Of PlcDataRepo).InSingletonScope()

        'Bind(Of TesterTranslate, ITranslate(Of Udt_tester, Model_tester)).To(Of TesterTranslate).InSingletonScope()
        'Bind(Of CountsTranslate, ITranslate(Of Udt_Tester_Counts, Model_Tester_Counts)).To(Of CountsTranslate).InSingletonScope()
        'Bind(Of PartinfoTranslate, ITranslate(Of Udt_PartInformation, Model_PartInformation)).To(Of PartinfoTranslate).InSingletonScope()
        'Bind(Of PartOptionsTranslate, ITranslate(Of Udt_PartOptions, Model_PartOptions)).To(Of PartOptionsTranslate).InSingletonScope()
        'Bind(Of GlassOptionsTranslate, ITranslate(Of Udt_GlassOptions, Model_GlassOptions)).To(Of GlassOptionsTranslate).InSingletonScope()
        'Bind(Of OptItemTranslate, ITranslate(Of Udt_Opt_Item, Model_Opt_Item)).To(Of OptItemTranslate).InSingletonScope()
        'Bind(Of SetpointsTranslate, ITranslate(Of Udt_Setpoints, Model_Setpoints)).To(Of SetpointsTranslate).InSingletonScope()
        'Bind(Of MinMaxTanslate, ITranslate(Of Udt_MinMax, Model_MinMax)).To(Of MinMaxTanslate).InSingletonScope()
        'Bind(Of NestTranslate, ITranslate(Of Udt_Nest, Model_Nest)).To(Of NestTranslate).InSingletonScope()
        'Bind(Of LogValuesTranslate, ITranslate(Of Udt_Logvalues, Model_Logvalues)).To(Of LogValuesTranslate).InSingletonScope()
        'Bind(Of LogItemTranslate, ITranslate(Of Udt_LogItem, Model_LogItem)).To(Of LogItemTranslate).InSingletonScope()
        'Bind(Of AnalogItemsTranslate, ITranslate(Of Udt_AnalogItems, Model_AnalogItems)).To(Of AnalogItemsTranslate).InSingletonScope()
        'Bind(Of AlgItemTranslate, ITranslate(Of Udt_AlgItem, Model_AlgItem)).To(Of AlgItemTranslate).InSingletonScope()
        'Bind(Of ManualOperatorsTranslate, ITranslate(Of Udt_Manual_Operators, Model_Manual_Operators)).To(Of ManualOperatorsTranslate).InSingletonScope()
        'Bind(Of McalTranslate, ITranslate(Of Udt_Mcal, Model_Mcal)).To(Of McalTranslate).InSingletonScope()
        'Bind(Of ModelScaleTranslate, ITranslate(Of Udt_Scale, Model_Scale)).To(Of ModelScaleTranslate).InSingletonScope()
        'Bind(Of HeartBeatTranslate, ITranslate(Of Udt_HeartBeat, Model_HeartBeat)).To(Of HeartBeatTranslate).InSingletonScope()
    End Sub

End Class