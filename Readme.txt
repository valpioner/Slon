

- Made by Valentyn Vasylevskyy for MediaMonks interview.

This is well organized n-layer back-end solution with Web API and simple UI to be able to see results.



How to run? 
1. Open Package Manager Console;
2. Select "Slon.DataAccess" as default project;
3. Run "update-database" command from console;
4. Run "Slon.API" in Visual Studio or IIS (or make is as Katana Self-hosted via console), 
	this is short and simple example, so it acts as Web Interface as well.
5. use 2 buttons to call WebAPI (/api/categories & /api/items)



Highlights:
- This solution clearly separated by logical layers, so it is well scalable;
- Entity Ftamework Code First approach is used to create initial database;
- Not testable at this point, need DI/IoC implementation (Unity || Ninject etc.);
- Used AutoMapping between EF Domain Model and UI Entities.



Please see my other projects that I've sent you to check out my AngularJS projects and front-end knowledge.