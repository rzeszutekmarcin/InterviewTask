using InterviewTask.Models;
using System.Collections.Generic;

namespace InterviewTask.Contracts
{
    public interface IPacketGenerator
    {
        public List<Packet> GeneratePackets();
    }
}
