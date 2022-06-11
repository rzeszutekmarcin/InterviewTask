namespace InterviewTask.Contracts
{
    public interface IRepository<Entity>
    {
        public void SendPacket(Entity packet);
        public List<Entity> GetPackets();
        public Task<List<Entity>> GetPacketsResultsAsync();
    }
}
