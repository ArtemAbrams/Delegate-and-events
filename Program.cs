using ConsoleApp;
try
{
    string name;
   FootballTeam footballTeam = new FootballTeam(new Footballer[11]);
   for (int i = 0; i < 11; i++)
   {
       name = Console.ReadLine();
       footballTeam[i]= new Footballer(name, (byte)i);
   }

   for (int i = 0; i < 16; i++)
   {
       Console.Write(footballTeam[i].name + " ");
   }
}
catch (Exception ex)
{
    Console.WriteLine("Wrong " + ex.Message);
}