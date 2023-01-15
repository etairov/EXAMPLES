Console.WriteLine("Введите ваше имя!");
string username = Console.ReadLine();

if(username.ToLower() == "женя")
{
Console.WriteLine("УРА!!! Это же Женя!!!");
}
else
{
Console.WriteLine("Привет, ");
Console.WriteLine(username);
}