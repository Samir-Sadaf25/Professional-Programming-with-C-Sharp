string type = "";
int result = 0;
// old switch statement
switch(type)
{
    case "A":
        result = 1;
        break;
    case "B":
        result = 2;
        break;
    default:
        result = 0;
        break;
}

// new switch statement 
result = type switch
{
    "A" => 1,
    "B" => 2,
    _ => 0
};

Person p = new Person { Name = "Jalal", age = 44 };
string p = p switch
{
    { name: "jalal"} => "Match",
    { name: "hasan", age: 31} => "Match",
    { name: _ , age: _} = > "No Match"

};
