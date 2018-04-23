Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace Q265259
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			MyBase.OnStartup(e)
			InitializeDataLayer()
		End Sub

		Private Sub InitializeDataLayer()
			XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString("..\..\nwind.mdb")
		End Sub
	End Class
End Namespace
