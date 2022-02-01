using CommanderGQL.Data;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Mutation
    {
        public async Task<AddPlatformPayload> AddPlatformAsync(
            AddPlatformInput input,
            [Service] ApplicationDbContext context)
        {
            Platform platform = new ()
            {
                Name = input.Name,
            };

            context.Platforms.Add(platform);
            await context.SaveChangesAsync();

            return new AddPlatformPayload(platform);
        }
    }
}