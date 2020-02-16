# aspnetcore-testing-sample

[![Build Status](https://dev.azure.com/devprofr/open-source/_apis/build/status/devpro.aspnetcore-testing-sample?branchName=master)](https://dev.azure.com/devprofr/open-source/_build/latest?definitionId=29&branchName=master)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=devpro.aspnet-testing-sample&metric=alert_status)](https://sonarcloud.io/dashboard?id=devpro.aspnet-testing-sample)

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
