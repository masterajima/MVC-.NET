Models: Classes that represent the data of the app. The model classes use validation logic to enforce business rules for that data. Typically, model objects retrieve and store model state in a database. In this tutorial, a Movie model retrieves movie data from a database, provides it to the view or updates it. Updated data is written to a database.
Views: Views are the components that display the app's user interface (UI). Generally, this UI displays the model data.
Controllers: Classes that:
Handle browser requests.
Retrieve model data.
Call view templates that return a response.
Currently the Index method returns a string with a message in the controller class. In the HelloWorldController class, replace the Index method
The preceding code:

Calls the controller's View method.
Uses a view template to generate an HTML response.
Replace the contents of the Views/HelloWorld/Index.cshtml Razor view file 
Navigate to https://localhost:{PORT}/HelloWorld:

The Index method in the HelloWorldController ran the statement return View();, which specified that the method should use a view template file to render a response to the browser.

A view template file name wasn't specified, so MVC defaulted to using the default view file. When the view file name isn't specified, the default view is returned. The default view has the same name as the action method, Index in this example. The view template /Views/HelloWorld/Index.cshtml is used.


Add Model
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
