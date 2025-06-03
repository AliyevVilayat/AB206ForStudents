namespace AB206GameStoreAPI.BL.Exceptions;

public class TrendingGameException : Exception
{
    public TrendingGameException() : base("Default message")
    {

    }
    public TrendingGameException(string message) : base(message)
    {

    }
}
