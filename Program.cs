using ConsoleApp;
using System.Collections.ObjectModel;

ObservableCollection<int> observableCollection = new ObservableCollection<int>();
/*try
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
}*/
int[] array = new int [15]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
OwnCollection<int> ownCollection = new OwnCollection<int>(1,2,3,4,5,6,7,8,9,0,10,3,2,1,344,231);
ownCollection.Append(12);
foreach (int j in ownCollection)
{
    Console.Write(j + " ");
}
