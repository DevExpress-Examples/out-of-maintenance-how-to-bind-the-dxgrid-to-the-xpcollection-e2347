Imports System
Imports DevExpress.Xpo
Namespace Northwind

    <Persistent("Products")> _
    Public Class Product
        Inherits XPLiteObject

        Private fProductID As Integer
        <Key(True)> _
        Public Property ProductID() As Integer
            Get
                Return fProductID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ProductID", fProductID, value)
            End Set
        End Property
        Private fProductName As String
        <Size(40)> _
        Public Property ProductName() As String
            Get
                Return fProductName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ProductName", fProductName, value)
            End Set
        End Property
        Private fQuantityPerUnit As String
        <Size(20)> _
        Public Property QuantityPerUnit() As String
            Get
                Return fQuantityPerUnit
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("QuantityPerUnit", fQuantityPerUnit, value)
            End Set
        End Property
        Private fUnitPrice As Decimal
        Public Property UnitPrice() As Decimal
            Get
                Return fUnitPrice
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("UnitPrice", fUnitPrice, value)
            End Set
        End Property
        Private fUnitsInStock As Short
        Public Property UnitsInStock() As Short
            Get
                Return fUnitsInStock
            End Get
            Set(ByVal value As Short)
                SetPropertyValue(Of Short)("UnitsInStock", fUnitsInStock, value)
            End Set
        End Property
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

End Namespace
