# E2E testing with Selenium and .NET

## Purpose

This project is a micro framework for automation testing with the following patterns:

* Data driven testing
* POM (Page Object Model) testing
* AAA (Arrange Act Assert) testing

This patterns provide us:

* Easy to maintenance tests
* Easy extendable tests
* High code reusability

## Prerequisites

* .NET Framework ^4.5
* Data Connectivity Components - https://www.microsoft.com/en-us/download/details.aspx?id=23734

This project will restore the following NuGet packages:

* Dapper
* NLog
* NLog.Config
* NLog.Schema
* NUnit
* NUnit3TestAdapter
* Selenium.Support
* Selenium.WebDriver
* Selenium.WebDriver.ChromeDriver
* Selenium.WebDriver.GeckoDriver

## Tips and tricks

* The DataSource.xlsx sheet names should equals the model class names (e.g. Sheet1 is named RegistrationUser which equals the name of the model)
* The first column should contains test method names
* Other column names should equals the model properties in order to be mapped by Dapper

## Further help

To get more help on:

* NUnit - https://github.com/nunit/docs/wiki
* Selenium - https://www.seleniumhq.org/docs/03_webdriver.jsp
