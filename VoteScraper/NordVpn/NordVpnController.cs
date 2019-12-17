using System.Collections.Generic;
using System.Linq;

namespace VoteScraper.NordVpn
{
    public class NordVpnController
    {
        private List<NordVpnServer> Servers { get; } = new List<NordVpnServer>();
        private IEnumerator<string> Enumerator { get; set; }

        private NordVpnController() { }

        public static NordVpnController Initialize()
        {
            var controller = new NordVpnController();
            var netherlands = new NordVpnServer("Netherlands");
            netherlands.AddServerNumbers(104, 108);
            netherlands.AddServerNumbers(112, 127);
            //netherlands.AddServerNumbers(120, 127);
            netherlands.AddServerNumbers(265);
            netherlands.AddServerNumbers(352, 373);
            netherlands.AddServerNumbers(375, 376);
            netherlands.AddServerNumbers(378, 385);
            netherlands.AddServerNumbers(396, 408);
            netherlands.AddServerNumbers(410, 417);
            netherlands.AddServerNumbers(426, 429);
            netherlands.AddServerNumbers(430, 432);
            netherlands.AddServerNumbers(434, 435);
            netherlands.AddServerNumbers(438, 439);
            netherlands.AddServerNumbers(441, 460);
            netherlands.AddServerNumbers(463, 504);
            netherlands.AddServerNumbers(506);
            netherlands.AddServerNumbers(508, 526);
            netherlands.AddServerNumbers(533, 543);
            netherlands.AddServerNumbers(545, 556);
            netherlands.AddServerNumbers(576, 580);
            netherlands.AddServerNumbers(584, 614);
            netherlands.AddServerNumbers(619, 633);
            netherlands.AddServerNumbers(68, 79);
            netherlands.AddServerNumbers(92, 95);

            var belgium = new NordVpnServer("Belgium");
            belgium.AddServerNumbers(27, 30);
            belgium.AddServerNumbers(59, 71);
            belgium.AddServerNumbers(75, 146);

            var germany = new NordVpnServer("Germany");
            germany.AddServerNumbers(119, 122);
            germany.AddServerNumbers(415, 450);
            germany.AddServerNumbers(453, 458);
            germany.AddServerNumbers(463);
            germany.AddServerNumbers(467, 478);
            germany.AddServerNumbers(487, 549);
            germany.AddServerNumbers(551, 555);
            germany.AddServerNumbers(558, 559);
            germany.AddServerNumbers(561);
            germany.AddServerNumbers(563, 565);
            germany.AddServerNumbers(568, 589);
            germany.AddServerNumbers(592, 611);
            germany.AddServerNumbers(616, 625);
            germany.AddServerNumbers(628, 665);
            germany.AddServerNumbers(675);
            germany.AddServerNumbers(677, 691);


            var lux = new NordVpnServer("Luxembourg");
            lux.AddServerNumbers(48);
            lux.AddServerNumbers(58, 61);
            lux.AddServerNumbers(68, 73);

            //var  = new NordVpnServer("");
            //.AddServerNumbers();

            controller.Servers.Add(netherlands);
            controller.Servers.Add(belgium);
            controller.Servers.Add(germany);
            controller.Servers.Add(lux);

            var total = controller.GetEnumerable().Count();

            controller.Enumerator = controller.GetEnumerable().GetEnumerator();
            return controller;
        }

        public string GetNext()
        {
            if (!Enumerator.MoveNext())
            {
                Enumerator = GetEnumerable().GetEnumerator();
                Enumerator.MoveNext();
            }

            return Enumerator.Current;
        }

        private IEnumerable<string> GetEnumerable()
        {
            foreach (var server in Servers)
            {
                foreach (var serverId in server.GetServerNumbers())
                {
                    yield return ConstructServerName(server, serverId);
                }
            }
        }

        private string ConstructServerName(NordVpnServer server, int serverId)
            => $"{server.Country} #{serverId}";
    }
}
