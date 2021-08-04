# Test project

In this project you will be evaluated on several topics:
- Entity Framework Core
- HTML, CSS, JavaScript
- .NET 5

## Some info to begin if
- Architecture- MVC (Model-View-Controller)
- Database- [ Microsoft SQL Server Express LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15), please, be prepared to install it
- To get data from the DB, please, use EF Core ORM
- Models with context location: ../Models
- Views location: ../Views
- Controllers location: ../Controllers

## Tasks

1. Create a table in ../Views/User/Index.cshtml, 
* populate it with users data from the database,
* create a table filter input,
* make table sortable (if I click on column Name, table should be sorted alphabetically [A-Z] or vice-versa [Z-A]
* Table should have columns: 

| Name | Surname | User Title |
|-|-|-|

2. Create a table in ../Views/Time/Index.cshtml, 
* determine how much time user worked in a day (formula: In/Out time difference - 1 hour, hh.mm precision),
* populate it with relevant times data from the database,
* create a table filter input,
* make table sortable (if I click on column Name, table should be sorted alphabetically [A-Z] or vice-versa [Z-A] or if click on Total worked time- sorted min-max or max-min,
* Table should have columns: 

| Name | Surname | User title | Date | In time | Out time | Inside times | Total worked time |
|-|-|-|-|-|-|-|-|

3. Create 2 graphs in ../Views/Graph/Index.cshtml, 
* First graph shows individual worker total worked time (X axis - name, surname, Y axis - total worked time),
* Second graph shows how much time all workers worked in a day (X axis- day, Y- total worked time in a day)
* Recommending [ChartJS](https://www.chartjs.org/)

4. Nice to have things
* Use Bootstrap to enchance UI, make it responsive.
* If you ar not familiar with it, you can use any other UI library or framework, for example: [Tailwind CSS](https://tailwindcss.com/)

## Remark

For frontend development, you can even use React, Vue, Angular or any other frameworks, libraries, etc.
Then you are done, create a new repo and send the link to povilas.pockevicius@peikko.com or pockeviciuspovilas@gmail.com

If you have questions about tasks or any other problems, feel free to ask me. Good luck! 
