using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Vaulty.Classes
{
    public class LocalServer
    {
        private HttpListener listener;

        public void Start(int port = 8888)
        {
            if (listener != null && listener.IsListening)
                return; // serveur déjà lancé → ne pas redémarrer

            listener = new HttpListener();
            listener.Prefixes.Add($"http://localhost:{port}/");
            listener.Start();

            Task.Run(() => ListenLoop());
        }

        private async Task ListenLoop()
        {
            while (listener.IsListening)
            {
                var ctx = await listener.GetContextAsync();
                var request = ctx.Request;
                var response = ctx.Response;

                if (request.Url.AbsolutePath == "/credentials")
                {
                    string site = request.QueryString["site"];
                    var entry = FindEntryForSite(site);

                    if (entry == null)
                    {
                        response.StatusCode = 404;
                        response.Close();
                        continue;
                    }

                    var obj = new
                    {
                        site = site,
                        username = entry.Username,
                        password = entry.Password
                    };

                    string json = JsonSerializer.Serialize(obj);
                    byte[] data = Encoding.UTF8.GetBytes(json);

                    response.ContentType = "application/json";
                    response.ContentLength64 = data.Length;
                    await response.OutputStream.WriteAsync(data, 0, data.Length);
                    response.Close();
                }
                else
                {
                    response.StatusCode = 404;
                    response.Close();
                }
            }
        }

        private Entry FindEntryForSite(string site)
        {
            var vault = Program.MainFormInstance.CurrentVault;

            foreach (var e in vault.Entries)
            {
                if (!string.IsNullOrEmpty(e.Url) && e.Url.Contains(site))
                    return e;
            }

            return null;
        }
        public void Stop()
        {
            if (listener != null && listener.IsListening)
            {
                listener.Stop();
                listener.Close();
            }
        }

    }
}
