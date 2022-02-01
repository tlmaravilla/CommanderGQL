using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class AddPlatformPayload
    {
        public AddPlatformPayload(Platform plateform)
        {
            Platform = plateform;
        }

        public Platform Platform { get; }
    }
}