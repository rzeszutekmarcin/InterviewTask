using InterviewTask.Contracts;
using System.Collections.Generic;

namespace InterviewTask.Models
{
    public class InMemoryRepository : IRepository<Packet>
    {
        private List<Packet> packets=new List<Packet>();
        private List<Packet> sortedPackets=new List<Packet>();
        public List<Packet> GetPackets()
        {
            return packets;
        }

        public List<Packet> GetPacketsResult()
        {
            sortedPackets.Add(packets[0]);
            for (int i = 1; i < packets.Count; i++)
            {
                if (packets[i].input != packets[i - 1].input)
                {
                    sortedPackets.Add(packets[i]);
                }
            }
            return sortedPackets;
        }

        public void SendPacket(Packet packet)
        {
            packets.Add(packet);
        }
    }
}
