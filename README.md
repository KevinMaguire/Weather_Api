Weather_Api


The idea behind this project was a challenge to consume the public test API "https://www.metaweather.com" Instead of calling it directly, the idea was to pretend it was a vital service which was part of an overal SOA / infrastructure.

So the imaginary problem could be that 100 applications are all calling this service independantly and therefor creating their own implementations to solve the same problem - call the service to get weather results.

So the idea is to make a centralized microserice to consume this weather api and build on the SOA approach to making all our systems work in harmony.

This is a solution consisting of 2 projects :

(1) .Net Core Api - Exibits examples of good practice including action filters, dependency injection, interfaces, ( useful in mocking for unit tests) , and an attempt to get Azure AD B2C integrated with both the API and UI.

(2) .Net core React application which is basically the out of the box solution template provided by microsoft. Some stuff has simply been stripped away and again the intention was to integrate with Azure AD - all settings in the appsettings file have been anonymized. The idea was to use this template and tweak the .js file to call our Azure API instead of the controller included in the example, all the redundant boiler plate code was deleted.

Next step is to prove out that authentication using an out of the box solution like auth0, AzureAD or MS Identity ( previously Membership ASPNETdb) can be implemented successfully but also to create a build pipline and release pipeline in azure devops to enable continuous deployments.

A few things you will notice in the code is that there are some items which can be done better - I purely took the happy path here and can tidy these things up in the future.

These include :

(1) No Async Tasks to save server side memory and threadpool threads (2) Keys stored in appsettings.json (3) Aniforgery token validation on controllers - although depends on design, if consuming applications send one then we validate and if not then we create and send. (4) Cors - This is enabled purely for the demonstration of a working app.
