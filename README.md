# HomiTagTest
How to Start?
1) Restore the Database HomiTagDB.BAK through SqlServer
2) Open the project level Web.config file and update the connectionstring by entering your Server name. In my case it is HASSAM34
```
 <connectionStrings>
    <add name="Entities" connectionString="metadata=res://*/Models.HomiTagDB.csdl|res://*/Models.HomiTagDB.ssdl|res://*/Models.HomiTagDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=HASSAM34;initial catalog=HomiTagTest;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```
3) Build the Project
4) You are ready to Run the project now
5) Run The Project
6) Open Postman and Import the postman collection https://www.postman.com/collections/8bbaa8a8503297b12b9e , All the API documentation is given in this collection. It will help you to understand the project.
7) Ready for the Test !


Note:
1) The Postman Collection is https://www.postman.com/collections/8bbaa8a8503297b12b9e
2) The DataBase .BAK file is attached named as HomiTagDB.BAK in the main folder
