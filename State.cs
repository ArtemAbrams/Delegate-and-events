namespace ConsoleApp;

class State
{
    public int Population { get; set; }
    public int Area { get; set; }

    public State(int population, int area)
    {
        this.Population = population;
        this.Area = area;
    }

    public static State operator +(State state_1, State state_2)
    {
        return new State(state_1.Area + state_2.Area, state_1.Population + state_2.Population);
    }

    public static bool operator >(State state_1, State state_2)
    {
        return state_1.Population > state_2.Population;
    }
    public static bool operator <(State state_1, State state_2)
    {
        return state_1.Area < state_2.Area;
    }
}