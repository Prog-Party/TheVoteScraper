using System.Collections.Generic;

namespace VoteScraper.NordVpn
{
    public class NordVpnServer
    {
        public string Country { get; set; }

        private List<int> Numbers = new List<int>();

        public NordVpnServer(string country)
        {
            Country = country;
        }

        public void AddServerNumbers(int serverId)
        {
            Numbers.Add(serverId);
        }
        public void AddServerNumbers(int serverIdFrom, int serverIdTo)
        {
            for(int i = serverIdFrom; i <= serverIdTo; i++)
                Numbers.Add(i);
        }

        public List<int> GetServerNumbers()
            => Numbers;
    }
}
