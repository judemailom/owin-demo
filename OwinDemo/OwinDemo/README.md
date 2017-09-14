- Middleware Class - for readability and organization, middlewares are kept in separate classes with a `constructor` and an `Invoke` method
- Middleware Extensions - static classes that can be use instead of using ```app.Use<ExtensionName>()``` middlewares can be used as ```app.UseExtensionName()```
- Middleware Options - classes for Middleware parameters
- Modules - third party middleware

- app.UseWebApi()
- note the ```BuildApiResponse()``` method that builds the response on all request
	- try getting ```content``` via ```TryGetContentValue()``` return as generic ```object```
	- otherwise, cast ```content``` as ```HttpError```
- data access wrapped by Quino returns a generic list of object depending on the data
- For Controllers, note the ff methods specific to Quino:
	- ```HandleReadState``` - get
	- ```HandleCreatState``` - post
	- ```HandleUpdateState``` - patch
	- ```GetRepository``` - initializes db access???

