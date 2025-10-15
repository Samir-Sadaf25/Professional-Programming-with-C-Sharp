using AdoDotNet_Example;

var connectionString = "Server=;Database=CshrapB21;User Id=cshrapb21;Password=samirsadaf25 ;Trust Server Certificate = True";

using var sqlUtility = new SqlUtility(connectionString);

var name = "Tanvir";
var dateOfBirth = new DateTime(2002, 1, 24);
var cgpa = 3.34;
var sql = "insert into Student([Name],Cgpa,DateOfBirth) values(@name,@cgpa,@dob);";

Dictionary<string, object> sqlParameters = new Dictionary<string, object>()
{
    {"name" , name},
    {"cgpa" , cgpa},
    {"dob",dateOfBirth}
};

//sqlUtility.executeSql(sql,sqlParameters);
Console.WriteLine("completed");

Dictionary<string, object> sqlParameters2 = new Dictionary<string, object>()
{

    {"cgpa" , cgpa},
};

var query = "select Name,Cgpa from Student where Cgpa > @cgpa";
var data = sqlUtility.exicuteSqlQuery(query, sqlParameters2);


foreach (var item in data) // item is a Dictionary for one row
{
    foreach (var key in item.Keys) // iterate column names for that row
    {
        Console.Write($"{key}: {item[key]}  "); // print "ColumnName: Value"
    }
    Console.WriteLine();
}