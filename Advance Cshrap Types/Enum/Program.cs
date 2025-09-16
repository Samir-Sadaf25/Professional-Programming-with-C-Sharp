using Enum;

var user = new UserService().getUser("samir sadaf");
if(user.Status == UserStatus.Active)
{

}
else if (user.Status == UserStatus.Inactive)
{

}
Console.WriteLine(UserStatus.Active.ToString());
int x = (int)UserStatus.Inactive;
Console.WriteLine(x);    