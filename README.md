# AdventureWorksSoapSvc
Sample .NET WCF service backed by the AdventureWorks MSSQL DB.

This project serves two purposes:

1. To provide a reference project upon which to build and/or experiment with .NET WCF Web Services.

2. To provide material for "real-world" coding interviews. Qualified candidates should be able to complete a 
solution in which a SOAP request is made to return a list of products belonging to a specific category.

#Requirements
Setting up this project will require VisualStudio 2015, IIS7 or greater and MS SQLServer 2008R2 or greater.

#Setup
After cloning the project into a local repo, Attach the `App_Data\AdventureWorksDW2008R2_Data.mdf` file to a local instance of MS
SQLServer.

The project is configured to serve the service via IIS at `http://localhost:8081/ProductService.svc` You'll need to set up IIS accordingly.

Once everything is configured correctly, you should be able to build and run the solution and navigate to the above url to see 
the service's help page.
