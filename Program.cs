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
OwnCollection<int> ownCollection = new OwnCollection<int>(54,443,324,2343,532523,123123,425523,2343,54,54,53,54);
ownCollection.Append(12);
foreach (int j in ownCollection)
{
    Console.Write(j + " ");
}
ownCollection.DeleteItem(54);
Console.WriteLine();
foreach (int j in ownCollection)
{
    Console.Write(j + " ");
}
