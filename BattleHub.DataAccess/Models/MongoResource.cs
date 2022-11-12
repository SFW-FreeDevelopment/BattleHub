﻿using MongoDB.Bson.Serialization.Attributes;

namespace BattleHub.DataAccess.Models;

public abstract class MongoResource
{
    [BsonId]
    public string Id { get; set; }

    public string Name { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}