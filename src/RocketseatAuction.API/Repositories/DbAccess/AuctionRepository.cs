namespace RocketseatAuction.API.Repositories.DbAccess;

public class AuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;
    public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;


}
