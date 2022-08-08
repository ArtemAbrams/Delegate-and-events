using System.ComponentModel.Design;

namespace ConsoleApp;

class Footballer
{
    public string name { get; set; }
    public byte number { get; set; }

    public Footballer(string name, byte number)
    {
        this.name = name;
        this.number = number;
    }
}

class FootballTeam
{
    public Footballer[] footballer;
    public FootballTeam(){}
    public FootballTeam(Footballer[] footballer) => this.footballer = footballer;

    public Footballer this[int index]
    {
        get
        {
            if (index >= 0 && index < 11)
            {
                return  footballer[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        set
        {
            if (index >= 0 && index < 11)
            {
                footballer[index] = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}