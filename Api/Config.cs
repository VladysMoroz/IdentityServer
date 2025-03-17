using IdentityServer4.Models;

namespace Api
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>
            {
            new ApiResource("myresourceapi", "My Resource API")
            {
                Scopes = { "apiscope" }
            }
            };

        public static IEnumerable<ApiScope> GetApiScopes() =>
            new List<ApiScope>
            {
            new ApiScope("apiscope", "API Scope")
            };

        public static IEnumerable<Client> GetClients() =>
            new List<Client>
            {
            new Client
            {
                ClientId = "secret_client_id",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("secret".Sha256()) },
                AllowedScopes = { "apiscope" }
            }
            };

        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>
            {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
            };
    }
}
