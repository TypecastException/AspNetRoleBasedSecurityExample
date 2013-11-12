ASP.NET Role-Based Security Example
===================================

This is an example project to accompany a blog post describing a very basic implementation of Role-Based Security and Identity Account management using ASP.NET MVC 5. 

You will need to enable Nuget Package Restore in Visual Studio in order to download and restore Nuget packages during build. If you are not sure how to do this, see [Keep Nuget Packages Out of Source Control with Nuget Package Manager Restore][2]

You will also need to run Entity Framework Migrations `Update-Database` command per the article. The migration files are included in the repo, so you will NOT need to `Enable-Migrations` or run `Add-Migration Init`. 

The Blog article to accompany this code can be found at [Extending Identity Accounts and Implementing Role-Based Authentication in ASP.NET MVC 5][1]

[1]: http://www.typecastexception.com/post/2013/11/11/Extending-Identity-Accounts-and-Implementing-Role-Based-Authentication-in-ASPNET-MVC-5.aspx "Extending Identity Accounts and Implementing Role-Based Authentication in ASP.NET MVC 5"

[2]: http://www.typecastexception.com/post/2013/11/10/Keep-Nuget-Packages-Out-of-Source-Control-with-Nuget-Package-Manager-Restore.aspx "Keep Nuget Packages Out of Source Control with Nuget Package Manager Restore"
