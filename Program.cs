using System.Threading.Tasks;
using System.Net.Http;

namespace Kerberos
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await Curl(args[0]);
        }

        private static async Task Curl(string url) {
            var msg = await client.GetStringAsync(url);
            System.Console.Write(msg);
        }
    }
}

/*

            var client = new KerberosClient();

            var kerbCred = new KerberosPasswordCredential("user@domain.com", "userP@ssw0rd!");

            await client.Authenticate(kerbCred);

            var ticket = await client.GetServiceTicket("host/appservice.corp.identityintervention.com");

*/