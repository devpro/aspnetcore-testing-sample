# aspnetcore-testing-sample

[![Build Status](https://dev.azure.com/devprofr/demo/_apis/build/status/demo-aspnetcore-testing-CI?branchName=master)](https://dev.azure.com/devprofr/demo/_build/latest?definitionId=11&branchName=master)

Example of integration testing on an ASP.NET Core application.

## Dependencies

- [.NET Core 3.1 SDK](dot.net)
- MongoDB 4.2 database
  - [MongoDB Atlas](https://cloud.mongodb.com/) cluster
  - Local server
  - Docker

  ```bash
  docker run --name mongodb422 -d -p 27017:27017 mongo
  ```

## Client code packing

```bash
cd src/WebApp
npx webpack --config webpack.config.js --mode=production
```
