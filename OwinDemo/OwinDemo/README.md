- Middleware Class - for readability and organization, middlewares are kept in separate classes with a `constructor` and an `Invoke` method
- Middleware Extensions - static classes that can be use instead of using ```app.Use<ExtensionName>()``` middlewares can be used as ```app.UseExtensionName()```
- Middleware Options - classes for Middleware parameters
- Modules - third party middleware

