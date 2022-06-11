using InterviewTask.Contracts;
using InterviewTask.Models;

namespace Infrastructure
{
    public class InMemoryRepository : IRepository<Packet>
    {
        private List<Packet> packets = new List<Packet>();
        private List<Packet> sortedPackets = new List<Packet>();
        public List<Packet> GetPackets()
        {
            return packets;
        }

        public Task<List<Packet>> GetPacketsResult()
        {
            sortedPackets.Add(packets[0]);
            for (int i = 1; i < packets.Count; i++)
            {
                if (packets[i].input != packets[i - 1].input)
                {
                    sortedPackets.Add(packets[i]);
                }
            }
            // return sortedPackets;
            return Task.FromResult(sortedPackets);
        }

        public void SendPacket(Packet packet)
        {
            packets.Add(packet);
        }
    }
}
