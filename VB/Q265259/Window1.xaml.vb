Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports Northwind
Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace Q265259
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			LoadData()
		End Sub

		Private session As Session
		Private products As XPCollection(Of Product)
		Private Sub LoadData()
			session = New Session()
			products = New XPCollection(Of Product)(session)
			products.DisplayableProperties = "ProductName;QuantityPerUnit;UnitPrice;UnitsInStock"
			productsGrid.DataSource = products
			productsGrid.PopulateColumns()
		End Sub

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If products IsNot Nothing Then
				products.Dispose()
				products = Nothing
			End If
			If session IsNot Nothing Then
				session.Dispose()
				session = Nothing
			End If
		End Sub
	End Class
End Namespace
