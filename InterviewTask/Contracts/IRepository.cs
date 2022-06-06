﻿using InterviewTask.Models;

namespace InterviewTask.Contracts
{
    public interface IRepository<Packet>
    {
        public void SendPacket(Packet packet);
        public List<Packet> GetPackets();
        public List<Packet> GetPacketsResult();
    }
}
