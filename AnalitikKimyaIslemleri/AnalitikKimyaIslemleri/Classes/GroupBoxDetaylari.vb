Public Class GroupBoxDetaylari
#Region "LocalVariables"

    Private KonumX_ As Integer
    Private KonumY_ As Integer
    Private YukseklikH_ As Integer
    Private Durum_ As Boolean

#End Region

#Region "Properties"

    Public Property KonumX() As Integer
        Get
            Return Me.KonumX_
        End Get
        Set(ByVal value As Integer)
            Me.KonumX_ = value
        End Set
    End Property
    Public Property KonumY() As Integer
        Get
            Return Me.KonumY_
        End Get
        Set(ByVal value As Integer)
            Me.KonumY_ = value
        End Set
    End Property
    Public Property YukseklikH() As Integer
        Get
            Return Me.YukseklikH_
        End Get
        Set(ByVal value As Integer)
            Me.YukseklikH_ = value
        End Set
    End Property
    Public Property Durum() As Boolean
        Get
            Return Me.Durum_
        End Get
        Set(ByVal value As Boolean)
            Me.Durum_ = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal KonumX As Integer, ByVal KonumY As Integer, ByVal YukseklikH As Integer, ByVal Durum As Boolean)

        Me.KonumX_ = KonumX
        Me.KonumY_ = KonumY
        Me.YukseklikH_ = YukseklikH
        Me.Durum_ = Durum

    End Sub

#End Region
End Class
