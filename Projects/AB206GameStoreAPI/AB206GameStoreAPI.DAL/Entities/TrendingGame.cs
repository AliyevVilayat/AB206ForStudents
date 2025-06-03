namespace AB206GameStoreAPI.DAL.Entities;

public class TrendingGame : BaseEntity
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public string ImgUrl { get; set; }
}
