Imports System
Imports System.Windows
Imports Northwind
Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace XPCollectionSample
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            vm = New MyViewModel()
            DataContext = vm

        End Sub
        Private vm As MyViewModel


        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            vm.Close()
        End Sub
    End Class

    Public Class MyViewModel
        Public Sub New()
            LoadData()
        End Sub
        Private session As Session
        Public Property Orders() As XPCollection(Of Order)
        Private Sub LoadData()
            session = New Session()
            Orders = New XPCollection(Of Order)(session)
            Orders.DeleteObjectOnRemove = True
            Orders.DisplayableProperties = "ShipName;ShipAddress"
        End Sub

        Public Sub Close()
            If Orders IsNot Nothing Then
                Orders.Dispose()
                Orders = Nothing
            End If
        End Sub
    End Class
End Namespace
