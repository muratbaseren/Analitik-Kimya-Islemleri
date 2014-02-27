#Region "Imports"
Imports System
Imports System.windows
Imports System.windows.forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
#End Region

Public Class myTabPage
    Inherits System.Windows.Forms.TabPage

#Region "LocalVariables"

    Private MyTabPageAyarlari_ As myTabPageAyarlari
    Private DatabaseAyarlari_ As DatabaseAyarlari
    Private CrystalReportAyarlari_ As CrystalReportAyarlari

#End Region

#Region "Properties"

    Public Property MyTabPageAyarlari() As MyTabPageAyarlari
        Get
            Return Me.MyTabPageAyarlari_
        End Get
        Set(ByVal value As MyTabPageAyarlari)
            Me.MyTabPageAyarlari_ = value
        End Set
    End Property
    Public Property DatabaseAyarlari() As DatabaseAyarlari
        Get
            Return Me.DatabaseAyarlari_
        End Get
        Set(ByVal value As DatabaseAyarlari)
            Me.DatabaseAyarlari_ = value
        End Set
    End Property
    Public Property CrystalReportAyarlari() As CrystalReportAyarlari
        Get
            Return Me.CrystalReportAyarlari_
        End Get
        Set(ByVal value As CrystalReportAyarlari)
            Me.CrystalReportAyarlari_ = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal MyTabPageAyarlari As myTabPageAyarlari)
        Me.MyTabPageAyarlari_ = MyTabPageAyarlari
    End Sub

    Public Sub New(ByVal DatabaseAyarlari As DatabaseAyarlari)
        Me.DatabaseAyarlari_ = DatabaseAyarlari
    End Sub

    Public Sub New(ByVal CrystalReportAyarlari As CrystalReportAyarlari)
        Me.CrystalReportAyarlari_ = CrystalReportAyarlari
    End Sub

    Public Sub New(ByVal DatabaseAyarlari As DatabaseAyarlari, ByVal CrystalReportAyarlari As CrystalReportAyarlari)
        Me.DatabaseAyarlari_ = DatabaseAyarlari
        Me.CrystalReportAyarlari_ = CrystalReportAyarlari
    End Sub

    Public Sub New(ByVal MyTabPageAyarlari As MyTabPageAyarlari, ByVal DatabaseAyarlari As DatabaseAyarlari, ByVal CrystalReportAyarlari As CrystalReportAyarlari)
        Me.MyTabPageAyarlari_ = MyTabPageAyarlari
        Me.DatabaseAyarlari_ = DatabaseAyarlari
        Me.CrystalReportAyarlari_ = CrystalReportAyarlari
    End Sub

#End Region

End Class
Public Class myTabPageAyarlari

#Region "LocalVariables"

    Private TitrantIsmi_ As Textbox
    Private TitrantDerisimi_ As Textbox
    Private TitrantHacmi_ As Textbox
    Private TitrantTuru_ As MaddeTuru
    Private TitreEdilenIsmi_ As Textbox
    Private TitreEdilenDerisimi_ As Textbox
    Private TitreEdilenHacmi_ As Textbox
    Private TitreEdilenTuru_ As MaddeTuru
    Private RaporBasligi_ As Textbox
    Private DipNot_ As Textbox
    Private Imza_ As Textbox
    Private TesirDegeri_ As Textbox
    Private Artis_ As Textbox

#End Region

#Region "Properties"

    Public Property TitrantIsmi() As Textbox
        Get
            Return Me.TitrantIsmi_
        End Get
        Set(ByVal value As Textbox)
            Me.TitrantIsmi_ = value
        End Set
    End Property
    Public Property TitrantDerisimi() As Textbox
        Get
            Return Me.TitrantDerisimi_
        End Get
        Set(ByVal value As Textbox)
            Me.TitrantDerisimi_ = value
        End Set
    End Property
    Public Property TitrantHacmi() As Textbox
        Get
            Return Me.TitrantHacmi_
        End Get
        Set(ByVal value As Textbox)
            Me.TitrantHacmi_ = value
        End Set
    End Property
    Public Property TitrantTuru() As MaddeTuru
        Get
            Return Me.TitrantTuru_
        End Get
        Set(ByVal value As MaddeTuru)
            Me.TitrantTuru_ = value
        End Set
    End Property
    Public Property TitreEdilenIsmi() As Textbox
        Get
            Return Me.TitreEdilenIsmi_
        End Get
        Set(ByVal value As Textbox)
            Me.TitreEdilenIsmi_ = value
        End Set
    End Property
    Public Property TitreEdilenDerisimi() As Textbox
        Get
            Return Me.TitreEdilenDerisimi_
        End Get
        Set(ByVal value As Textbox)
            Me.TitreEdilenDerisimi_ = value
        End Set
    End Property
    Public Property TitreEdilenHacmi() As Textbox
        Get
            Return Me.TitreEdilenHacmi_
        End Get
        Set(ByVal value As Textbox)
            Me.TitreEdilenHacmi_ = value
        End Set
    End Property
    Public Property TitreEdilenTuru() As MaddeTuru
        Get
            Return Me.TitreEdilenTuru_
        End Get
        Set(ByVal value As MaddeTuru)
            Me.TitreEdilenTuru_ = value
        End Set
    End Property
    Public Property RaporBasligi() As Textbox
        Get
            Return Me.RaporBasligi_
        End Get
        Set(ByVal value As Textbox)
            Me.RaporBasligi_ = value
        End Set
    End Property
    Public Property DipNot() As Textbox
        Get
            Return Me.DipNot_
        End Get
        Set(ByVal value As Textbox)
            Me.DipNot_ = value
        End Set
    End Property
    Public Property Imza() As Textbox
        Get
            Return Me.Imza_
        End Get
        Set(ByVal value As Textbox)
            Me.Imza_ = value
        End Set
    End Property
    Public Property TesirDegeri() As Textbox
        Get
            Return Me.TesirDegeri_
        End Get
        Set(ByVal value As Textbox)
            Me.TesirDegeri_ = value
        End Set
    End Property
    Public Property Artis() As Textbox
        Get
            Return Me.Artis_
        End Get
        Set(ByVal value As Textbox)
            Me.Artis_ = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal TitrantIsmi As Textbox, ByVal TitrantDerisimi As Textbox, ByVal TitrantHacmi As Textbox, ByVal TitrantTuru As MaddeTuru, ByVal TitreEdilenIsmi As Textbox, ByVal TitreEdilenDerisimi As Textbox, ByVal TitreEdilenHacmi As Textbox, ByVal TitreEdilenTuru As MaddeTuru, ByVal RaporBasligi As Textbox, ByVal DipNot As Textbox, ByVal Imza As Textbox, ByVal TesirDegeri As Textbox, ByVal Artis As Textbox)

        Me.TitrantIsmi_ = TitrantIsmi
        Me.TitrantDerisimi_ = TitrantDerisimi
        Me.TitrantHacmi_ = TitrantHacmi
        Me.TitrantTuru_ = TitrantTuru
        Me.TitreEdilenIsmi_ = TitreEdilenIsmi
        Me.TitreEdilenDerisimi_ = TitreEdilenDerisimi
        Me.TitreEdilenHacmi_ = TitreEdilenHacmi
        Me.TitreEdilenTuru_ = TitreEdilenTuru
        Me.RaporBasligi_ = RaporBasligi
        Me.DipNot_ = DipNot
        Me.Imza_ = Imza
        Me.TesirDegeri_ = TesirDegeri
        Me.Artis_ = Artis

    End Sub

#End Region

End Class
Public Class DatabaseAyarlari

#Region "LocalVariables"
Private DatabaseIsmi_ As String
#End Region

#Region "Properties"
    Public Property DatabaseIsmi() As String
        Get
            Return Me.DatabaseIsmi_
        End Get
        Set(ByVal value As String)
            Me.DatabaseIsmi_ = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal DatabaseIsmi As String)
        Me.DatabaseIsmi_ = DatabaseIsmi
    End Sub

#End Region

End Class
Public Class CrystalReportAyarlari

#Region "LocalVariables"

    Private RaporInstance_ As CrystalReport2

#End Region

#Region "Properties"

    Public Property RaporInstance() As CrystalReport2
        Get
            Return Me.RaporInstance_
        End Get
        Set(ByVal value As CrystalReport2)
            Me.RaporInstance_ = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Me.RaporInstance = Nothing
    End Sub

    Public Sub New(ByVal RaporInstance As CrystalReport2)
        Me.RaporInstance_ = RaporInstance
    End Sub

#End Region

End Class
Public Enum MaddeTuru
    [Asit] = 0
    [Baz] = 1
    [Bos] = -1
End Enum
