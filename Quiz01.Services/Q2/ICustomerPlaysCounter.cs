namespace Quiz01.Services.Q2
{
    public interface ICustomerPlaysCounter
    {
        int GetPlaysCountRandomly(int minGames, int maxGames);
    }
}