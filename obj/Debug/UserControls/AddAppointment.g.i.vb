﻿#ExternalChecksum("..\..\..\UserControls\AddAppointment.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","6EF022815F668FBB729F879607729E6EC056581939AC417B06674E8DE338BB65")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports QuickWPFMonthCalendar
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell
Imports Xceed.Wpf.Toolkit
Imports Xceed.Wpf.Toolkit.Chromes
Imports Xceed.Wpf.Toolkit.Converters
Imports Xceed.Wpf.Toolkit.Core
Imports Xceed.Wpf.Toolkit.Core.Converters
Imports Xceed.Wpf.Toolkit.Core.Input
Imports Xceed.Wpf.Toolkit.Core.Media
Imports Xceed.Wpf.Toolkit.Core.Utilities
Imports Xceed.Wpf.Toolkit.Mag.Converters
Imports Xceed.Wpf.Toolkit.Panels
Imports Xceed.Wpf.Toolkit.Primitives
Imports Xceed.Wpf.Toolkit.PropertyGrid
Imports Xceed.Wpf.Toolkit.PropertyGrid.Attributes
Imports Xceed.Wpf.Toolkit.PropertyGrid.Commands
Imports Xceed.Wpf.Toolkit.PropertyGrid.Converters
Imports Xceed.Wpf.Toolkit.PropertyGrid.Editors
Imports Xceed.Wpf.Toolkit.Zoombox


'''<summary>
'''AddAppointment
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class AddAppointment
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txb_subject As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",31)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmb_categories As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",36)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents dtp_endTime As Xceed.Wpf.Toolkit.DateTimePicker
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",38)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents dtp_startTime As Xceed.Wpf.Toolkit.DateTimePicker
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",41)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_addAppointment As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",42)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_addCategory As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/QuickWPFMonthCalendar;component/usercontrols/addappointment.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.txb_subject = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 2) Then
            Me.cmb_categories = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",32)
            AddHandler Me.cmb_categories.DropDownOpened, New System.EventHandler(AddressOf Me.cmb_categories_DropDownOpened)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.dtp_endTime = CType(target,Xceed.Wpf.Toolkit.DateTimePicker)
            
            #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",35)
            AddHandler Me.dtp_endTime.ValueChanged, New System.Windows.RoutedPropertyChangedEventHandler(Of Object)(AddressOf Me.dtp_startTime_ValueChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.dtp_startTime = CType(target,Xceed.Wpf.Toolkit.DateTimePicker)
            Return
        End If
        If (connectionId = 5) Then
            Me.btn_addAppointment = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",41)
            AddHandler Me.btn_addAppointment.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_addAppointment_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.btn_addCategory = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\UserControls\AddAppointment.xaml",42)
            AddHandler Me.btn_addCategory.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_addCategory_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
