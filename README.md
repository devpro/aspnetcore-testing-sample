# aspnetcore-testing-sample

[![Build Status](https://dev.azure.com/devprofr/demo/_apis/build/status/demo-aspnetcore-testing-CI?branchName=master)](https://dev.azure.com/devprofr/demo/_build/latest?definitionId=11&branchName=master)

Example of testing an ASP.NET Core application.

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
