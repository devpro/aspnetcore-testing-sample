# aspnetcore-testing-sample

[![Build Status](https://dev.azure.com/devprofr/demo/_apis/build/status/demo-aspnetcore-testing-CI?branchName=master)](https://dev.azure.com/devprofr/demo/_build/latest?definitionId=11&branchName=master)

Example of testing an ASP.NET Core application.

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
npm init
npm install --save-dev webpack
npm install bootstrap@4.1.3
npm install jquery@3.3.1
npm install jquery-validation@1.17.0
npm install jquery-validation-unobtrusive@3.2.11
npm run build
```
