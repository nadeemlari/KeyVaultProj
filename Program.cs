using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

var credential = new DefaultAzureCredential( new DefaultAzureCredentialOptions
{
     ManagedIdentityClientId = "c1dd26a4-63fb-4231-b082-d54b271be2c9"
});

var clientSecretCredential = new ClientSecretCredential(
    "ac11fdf6-cc10-4290-9f63-eaabb6cd0b33",
    "158cd9e8-9c5c-4d2e-bfdb-6ea7a5e81783",
    "L~Q8Q~ZS-3vHgNhInauh4GBdBwPSEOWRZi2.uaEF");


var client = new SecretClient(new Uri("https://mnlkv.vault.azure.net/"), credential);
var secret = await client.GetSecretAsync("Test");
string actualSecret = secret.Value.Value;

client = new SecretClient(new Uri("https://mnlkv.vault.azure.net/"), clientSecretCredential);
secret = await client.GetSecretAsync("Test");
actualSecret = secret.Value.Value;
Console.WriteLine( "done");
