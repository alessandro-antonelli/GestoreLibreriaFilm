﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funzionalità di salvataggio automatico My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LibreriaPercorso() As String
            Get
                Return CType(Me("LibreriaPercorso"),String)
            End Get
            Set
                Me("LibreriaPercorso") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("LargeIcon")>  _
        Public Property VistaIcone() As Global.System.Windows.Forms.View
            Get
                Return CType(Me("VistaIcone"),Global.System.Windows.Forms.View)
            End Get
            Set
                Me("VistaIcone") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("200, 100")>  _
        Public Property FinestraPosizione() As Global.System.Drawing.Point
            Get
                Return CType(Me("FinestraPosizione"),Global.System.Drawing.Point)
            End Get
            Set
                Me("FinestraPosizione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property FinestraMassimizzata() As Boolean
            Get
                Return CType(Me("FinestraMassimizzata"),Boolean)
            End Get
            Set
                Me("FinestraMassimizzata") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("800, 600")>  _
        Public Property FinestraDimensione() As Global.System.Drawing.Size
            Get
                Return CType(Me("FinestraDimensione"),Global.System.Drawing.Size)
            End Get
            Set
                Me("FinestraDimensione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PannelloSxChiuso() As Boolean
            Get
                Return CType(Me("PannelloSxChiuso"),Boolean)
            End Get
            Set
                Me("PannelloSxChiuso") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PannelloDxChiuso() As Boolean
            Get
                Return CType(Me("PannelloDxChiuso"),Boolean)
            End Get
            Set
                Me("PannelloDxChiuso") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("150")>  _
        Public Property PannelloSxDimensione() As UShort
            Get
                Return CType(Me("PannelloSxDimensione"),UShort)
            End Get
            Set
                Me("PannelloSxDimensione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property PannelloDxDimensione() As UShort
            Get
                Return CType(Me("PannelloDxDimensione"),UShort)
            End Get
            Set
                Me("PannelloDxDimensione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PannelloSchermataChiuso() As Boolean
            Get
                Return CType(Me("PannelloSchermataChiuso"),Boolean)
            End Get
            Set
                Me("PannelloSchermataChiuso") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("150")>  _
        Public Property PannelloSchermataDimensione() As UShort
            Get
                Return CType(Me("PannelloSchermataDimensione"),UShort)
            End Get
            Set
                Me("PannelloSchermataDimensione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property OrdinamentoIcone() As Byte
            Get
                Return CType(Me("OrdinamentoIcone"),Byte)
            End Get
            Set
                Me("OrdinamentoIcone") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CategoriaPredefinita() As Byte
            Get
                Return CType(Me("CategoriaPredefinita"),Byte)
            End Get
            Set
                Me("CategoriaPredefinita") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LibreriaIncludiSottocartelle() As Boolean
            Get
                Return CType(Me("LibreriaIncludiSottocartelle"),Boolean)
            End Get
            Set
                Me("LibreriaIncludiSottocartelle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property PreferisciIconePoster() As Boolean
            Get
                Return CType(Me("PreferisciIconePoster"),Boolean)
            End Get
            Set
                Me("PreferisciIconePoster") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PannelloPosterChiuso() As Boolean
            Get
                Return CType(Me("PannelloPosterChiuso"),Boolean)
            End Get
            Set
                Me("PannelloPosterChiuso") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CategorieOrdinamento() As Byte
            Get
                Return CType(Me("CategorieOrdinamento"),Byte)
            End Get
            Set
                Me("CategorieOrdinamento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CategorieInfo() As Byte
            Get
                Return CType(Me("CategorieInfo"),Byte)
            End Get
            Set
                Me("CategorieInfo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CategorieFormatoNomi() As Byte
            Get
                Return CType(Me("CategorieFormatoNomi"),Byte)
            End Get
            Set
                Me("CategorieFormatoNomi") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property TemaColori() As Byte
            Get
                Return CType(Me("TemaColori"),Byte)
            End Get
            Set
                Me("TemaColori") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.GestoreLibreriaFilm.My.MySettings
            Get
                Return Global.GestoreLibreriaFilm.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
