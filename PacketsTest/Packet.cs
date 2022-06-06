using System;

namespace InterviewTask.Models
{
    public class Packet
    {
        public string timestamp { get; set; }
        public int input { get; set; }

        public Packet(string timestamp, int input)
        {
            this.timestamp = timestamp;
            this.input = input;
            Console.WriteLine(timestamp + " : " + input);
        }

        public Packet()
        {

        }
    }
}
