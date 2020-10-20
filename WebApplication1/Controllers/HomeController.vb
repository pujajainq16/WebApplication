Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"
        //added test comment tttt
        Return View()
    End Function
End Class
