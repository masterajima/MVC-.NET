Models: Classes that represent the data of the app. The model classes use validation logic to enforce business rules for that data. Typically, model objects retrieve and store model state in a database. In this tutorial, a Movie model retrieves movie data from a database, provides it to the view or updates it. Updated data is written to a database.
Views: Views are the components that display the app's user interface (UI). Generally, this UI displays the model data.
Controllers: Classes that:
Handle browser requests.
Retrieve model data.
Call view templates that return a response.
