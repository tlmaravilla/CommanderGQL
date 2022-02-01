using CommanderGQL.Data;
using CommanderGQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderGQL.GraphQL;

public class Query
{

    public Task<List<Platform>> GetPlatforms([Service] ApplicationDbContext context) =>
           context.Platforms.ToListAsync();
}
