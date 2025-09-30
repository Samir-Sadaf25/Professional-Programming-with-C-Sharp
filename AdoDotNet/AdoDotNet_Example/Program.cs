using AdoDotNet_Example;

var connectionString = "Server= ;Database=CshrapB21;User Id=cshrapb21;Password= ;Trust Server Certificate = True";

var sqlUtility = new SqlUtility(connectionString);

var sql = "insert into Students([Name],Cgpa,DateOfBirth) values('abdul',3.40,'3/3/2006');";
sqlUtility.executeSql(sql);
Console.WriteLine("completed");

var query = "select Name,Cgpa from Students where Cgpa > 3.40";
var data = sqlUtility.exicuteSqlQuery(query);


foreach (var item in data) // item is a Dictionary for one row
{
    foreach (var key in item.Keys) // iterate column names for that row
    {
        Console.Write($"{key}: {item[key]}  "); // print "ColumnName: Value"
    }
    Console.WriteLine();   
}