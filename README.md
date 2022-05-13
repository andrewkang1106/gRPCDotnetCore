# gRPCDotnetCore
This simple implementation was created during my process of learning gRPC, as well as C#.
This is a basic implementation of a gRPC service in C# using Grpc.Core


-The intial basic implementation served to basically establish a connection and greet the user. <br/>
-

<h2>To Run</h2>

<h2>Prerequisites</h2>

- The [.NET Core SDK](https://www.microsoft.com/net/core)

<h2>Build and Run</h2>

  ```
  > dotnet run -p GreeterServer
  ```

- Build and run the client

  ```
  > dotnet run --project Accounts
  > dotnet run --project Client
  ```



Download the project and open the solution to run. <br/>
Running this project when not on the solution will fail, because it will not have the necessary Nuget packages.
<br/><br/>

*For those other than me that are viewing this, feel free to ignore some comments I write as those were made to help me understand and remember things. 
They are not reflective of how I would comment in production.*