# Pierre's Bakery

#### A C# application to showcase MSTest fundamentals

#### By Alex Adamovic

## Technologies Used

* _C#_

### Dependencies

* _MSTest_

## Description

_This simple C# console application, styled as Pierre's Bakery, takes several user inputs and determines the total price of an order. The user enters the number of loaves of bread they would like to buy, followed by the number of pastries they would like to buy. User inputs are passed into objects of class "Bread" & "Pastry" as arguments, with custom methods then employed to determine total prices and discounts based on the input. MSTest is utilized to cover all functionality of each class and its respective methods. This application is meant to showcase proper testing fundamentals._

## Setup/Installation Requirements

* _clone repository from https://github.com/alexadamovic/Bakery.Solution_
* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory Bakery.Tests and enter ```dotnet restore``` to install project dependencies_
* _the project is now ready to test and run_

#### To Run MSTest

* _navigate to the subdirectory Bakery.Tests and enter ```dotnet test``` to run developer tests with MSTest_
* _all tests outlined in the BreadTests.cs and PastryTests.cs files in the Bakery.Tests/ModelTests folder will run_

#### To Run in Console

* _navigate to the subdirectory Bakery and enter ```dotnet run``` to run the console application_
* _console application will open in the your terminal/command line. The UI code is contained within in the Program.cs file in the Bakery subdirectory and the back end functionality code is contained in the Bread.cs and Pastry.cs files in the Bakery/Models subdirectory_

## Known Bugs

* _User must enter a positive integer when prompted otherwise the application will not work properly_

## License

_MIT License_

Copyright (c) _2022_ _Alex Adamovic_

## Contact Information

alexanderadamovic@gmail.com