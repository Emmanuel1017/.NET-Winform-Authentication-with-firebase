
![1_SFFbo8lkNxVQcmLrLDVRNw](https://user-images.githubusercontent.com/41972019/182037737-16e802c2-ef93-4c8f-b2ee-76fb2f77100c.png)

# .NET-Winform-Authentication-with-firebase
Authenticate win-forms with firebase real-time DB. A illustration of using firebase DB to Store user credentials and retrieve using C# with .NET
.
.
.
.
.
.
.



To use clone and run login.sln




Craete a firebase project. Add Realtime DB and set rules as below :

![Screenshot 2022-07-31 200752](https://user-images.githubusercontent.com/41972019/182037667-75c713bb-5007-429b-9733-0297503b526a.png)

Make sure Firesharp is installeg using nuget.
To install run from nuget CLI:


```
Install-Package FireSharp
```
 
open settings.cs file and add from firebase your Auth secret to __AuthSecret and basePath url to __BasePath.


Run the project and it will save user details to firebase using realtime DB.
