using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public class NetScanner
    {
        private List<String[]> hostList;

        //private Dictionary<int, string> ok;
        private IPAddress[] ipRange;
        private Int32 ipCount;
        private Ping thePinger;
        private int MAX_IP_CLASS = 254;
        public TcpClient theProber;

        public Dictionary<String, int[]> osTable = new Dictionary<string,int[]>();
        
        public NetScanner()
        {
            thePinger = new Ping();
            ipCount = 1;

            osTable.Add("Linux (Kernel 2.4 and 2.6)", new int[] {64, 5840});
            osTable.Add("Google Linux", new int[] { 64, 5720 });
            osTable.Add("FreeBSD", new int[] { 64, 65535 });
            osTable.Add("Windows XP", new int[] { 128, 65535 });
            osTable.Add("Windows Vista and 7 (Server 2008)", new int[] { 128, 8192 });
            osTable.Add("iOS 12.4 (Cisco Routers)", new int[] { 255, 4128 });
        }

        public List<String[]> HostList
        {
            get
            {
                return hostList;
            }
        }

        public Int32 IpCount
        {
            set
            {
                ipCount = value;
            }
        }

        public void scan()
        {
            if (ipRange.Count() > 0)
            {
                hostList = new List<String[]>();
                foreach (IPAddress ip in ipRange)
                {
                    if (ip != null && pingHost(ip))
                    {
                        System.Net.IPHostEntry hostname = Dns.Resolve(ip.ToString());
                        hostList.Add(new String[] {ip.ToString(), hostname.HostName});
                    }
                }
            }
        }

        public void setIpRange(IPAddress firstIP, Int32 count)
        {
            int loopcount = 0;
            int hostAddress = firstIP.GetAddressBytes()[3];
            ipRange = new IPAddress[count];

            if (count > 254) loopcount = count / (int)MAX_IP_CLASS;

            for (int i = 1; count > i; i++)
            {
                byte[] ip = firstIP.GetAddressBytes();
                if (hostAddress == MAX_IP_CLASS)
                {
                    i = 1;
                    loopcount++;
                }

                if (loopcount > 0)
                {
                    int net = ip[2] + loopcount;
                    ip[2] = (byte)net;
                }
                
                ip[3] = (byte)hostAddress;
                ipRange[i] = (IPAddress.Parse(convertByteArrayToStringIP(ip)));
                hostAddress++;
            }

            Console.WriteLine("done");
        }

        private bool pingHost(IPAddress address)
        {
            byte[] pingdata = Encoding.ASCII.GetBytes("this is a pinger program very cool by lukas");
            PingReply reply = thePinger.Send(address,2,pingdata);
            return reply.Status == IPStatus.Success;            
        }

        public String convertByteArrayToStringIP(byte[] value)
        {
            return (String)value[0].ToString() + "." + value[1].ToString() + "." + value[2].ToString() + "." + value[3].ToString(); 
        }

        public bool validate(String value)
        {
            if (value != "") return true;
            return false;
        }
    }
}
