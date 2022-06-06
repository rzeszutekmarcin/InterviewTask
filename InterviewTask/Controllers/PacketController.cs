using InterviewTask.Models;
using Microsoft.AspNetCore.Mvc;
using InterviewTask.Contracts;
using InterviewTask.DTO;

namespace InterviewTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacketController : ControllerBase
    {
        private IRepository<Packet> repository;

        public PacketController(IRepository<Packet> repository)
        {
            this.repository = repository;
        }


        [HttpGet("GetPackets")]
        public IActionResult Get()
        {
            var result = repository.GetPackets();
            return Ok(result);
        }

        [HttpPost(Name = "Packet/{packet}")]
        public IActionResult Post([FromBody] Packet packettest)
        {
            Random randomInput = new Random();
            Packet packet = new Packet(DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), randomInput.Next(0, 2));
            repository.SendPacket(packet);
            return Ok(packet.timestamp);
        }

        [HttpGet("GetPacketsResult")]
        public IActionResult GetPacketsResult()
        {
            var result = repository.GetPacketsResult();
            return Ok(result);
        }

        // method to input packets from input stream 

        //[HttpPost(Name = "Packet/{packet}")]
        //public IActionResult Post([FromBody] PacketDTO packetDTO)
        //{
        //    Packet packet = new Packet();
        //    packet.timestamp = packetDTO.timestamp;
        //    packet.input = packetDTO.input;
        //    repository.SendPacket(packet);
        //    return Ok(packet.timestamp);
        //}


        // async method to test

        //[HttpGet("GetResult")]
        //public async Task<ActionResult<List<Packet>>> GetPacketsResult()
        //{
        //    var result = await repository.GetPacketsResult();
        //    return result;
        //}

    }

}
