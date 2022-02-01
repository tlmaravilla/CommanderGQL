using CommanderGQL.Data;
using CommanderGQL.Extensions;
using CommanderGQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderGQL.GraphQL;

public class Query
{
    [UseApplicationDbContextAttribute]
    public Task<List<Platform>> GetPlatforms([ScopedService] ApplicationDbContext context) =>
           context.Platforms.ToListAsync();
}
