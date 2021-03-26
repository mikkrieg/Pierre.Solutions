# _Pierre's Treats_

#### _A project showcasing a many to many relationship with authentication_

#### By _**Michael Kriegel**_

##### This project is a practice project

## Technologies Used

* _.NET 5.0_
* _ASP.NET Core_
* _HTML/CSS_
* _Razor_
* _Bootstrap_
* _Entity Framework_
* _Identity_
* _MySQL_

## Description

This is a project that is a continuation of Pierre's Bakery. It includes a many to many relationship between Treats and Flavors that is create with the Entity framework migrations. Each class has full CRUD functionality. However only users who have created an account are able to access these capabilities. If a user does not want to create an account they are able to view all the treats and flavors and see any information about them. But they will not be able to create, edit or delete entries. This authorization is done with the use of Identity. Users can create an account, login and logout.

## Setup/Installation Requirements

### Local Machine
* _Clone this repository to your machine_
* _Navigate to the Pierre directory (project directory)_
* _In the terminal, within this directory, enter the terminal commands ```dotnet restore``` and ```dotnet build```_
* _Create an ```appsettings.json``` file within the Pierre directory_
* _Inside your ```appsettings.json```, create a connection to the database you will be using_
  * _It will look similar to this: ```{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=(database_name_here);uid=(user_name_here));pwd=(your_password_here);}}``` Leave out all parenthesis, they are for example purposes only_
* _Enter the command ```dotnet ef database update``` in the terminal, this will update the database with any existing migrations_
* _To run the program, navigate to the Pierre directory and enter the command "dotnet run" in the terminal_
  * _To run the program with a watcher, use the command ```dotnet watch run``` in the terminal_
* _Type the url localhost:5000 (or whatever port you have configured) in a browser to view the project_


## Known Bugs

* _Styling is incomplete and is not responsive_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright(c) 2021 Michael Kriegel

## Contact Information

Michael Kriegel: mikkrieg@gmail.com
