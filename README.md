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




Craete a firebase project. Add Realtime DB and set rules to :

 {
  "rules": {
    ".read": true,
    ".write": true,
  }
}



open settings.cs file and add from firebase your Auth secret to __AuthSecret and basePath url to __BasePath.


Run thr e project and it will save user details to firebase using realtime DB
