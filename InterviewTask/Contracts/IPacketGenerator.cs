using InterviewTask.Models;

namespace InterviewTask.Contracts
{
    public interface IPacketGenerator
    {
        public List<Packet> GeneratePackets();
    }
}
