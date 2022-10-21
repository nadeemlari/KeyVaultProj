using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

var credential = new DefaultAzureCredential( new DefaultAzureCredentialOptions
{
     ManagedIdentityClientId = "c1dd26a4-63fb-4231-b082-d54b271be2c9"
});
var client = new SecretClient(new Uri("https://mnlkv.vault.azure.net/"), credential);
var secret = await client.GetSecretAsync("Test");
string actualSecret = secret.Value.Value;
Console.WriteLine( "done");
