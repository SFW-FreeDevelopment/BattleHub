using BattleHub.DataAccess.Models;
using MongoDB.Driver;

namespace BattleHub.DataAccess.Repositories;

public class GameRepository : MongoRepository<Game>
{
    public GameRepository(IMongoClient mongoClient) : base(mongoClient) { CollectionName = "games"; }
}