Console.Write("Введите свое имя ");
string username = Console.ReadLine();
  
if(username.ToLower() == "алексей")
{
  Console.Write("Ооо привет, Алексей");
}
else
{
  Console.Write("Привет, ");
  Console.Write(username);
}