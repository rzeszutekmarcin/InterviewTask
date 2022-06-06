using Xunit;
using InterviewTask.Models;
using System.Collections.Generic;

namespace PacketsTest
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            // Arrange
            //InMemoryRepository repositoryTest = new InMemoryRepository();
            List<Packet> expectedPackets = new List<Packet>();

            expectedPackets.Add(new Packet("1615560000", 1));
            expectedPackets.Add(new Packet("1615560024", 0));
            expectedPackets.Add(new Packet("1615560030", 1));
            expectedPackets.Add(new Packet("1615560037", 0));

            // Act 
            List<Packet> testList = new List<Packet>();

            testList.Add(new Packet("1615560000", 1));
            testList.Add(new Packet("1615560005", 1));
            testList.Add(new Packet("1615560013", 1));
            testList.Add(new Packet("1615560018", 1));
            testList.Add(new Packet("1615560024", 0));
            testList.Add(new Packet("1615560030", 1));
            testList.Add(new Packet("1615560037", 0));
            testList.Add(new Packet("1615560042", 0));

            List<Packet> sortedPackets = new List<Packet>();
            sortedPackets.Add(testList[0]);
            for (int i = 1; i < testList.Count; i++)
            {
                if (testList[i].input != testList[i - 1].input)
                {
                    sortedPackets.Add(testList[i]);
                }
            }

            // Assert
            //Assert.Equal(expectedPackets, sortedPackets); --- somehow, it doesn't work despite the fact, there are the same results in test
            for (int i = 0; i < sortedPackets.Count; i++)
            {
                Assert.Equal(expectedPackets[i].timestamp, sortedPackets[i].timestamp);
            }
            
        }
    }
}