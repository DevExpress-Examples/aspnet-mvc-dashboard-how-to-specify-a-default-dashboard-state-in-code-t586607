﻿Imports System.Web.Mvc

Namespace MvcDashboard_DefaultDashboardState
    Public Class FilterConfig
        Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
            filters.Add(New HandleErrorAttribute())
        End Sub
    End Class
End Namespace