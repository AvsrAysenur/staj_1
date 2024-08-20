using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using staj_1.models;
using staj_1.Services;
using staj_1.models;
using System.Net;

namespace staj_1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    


    public class DoorController : ControllerBase
    {
        //db service yapısıyla bağlantı kurmak için
        IDoorService _dbService;
        public DoorController(IDoorService dbService)
        {
            _dbService = dbService;
        }



      //  DoorService _dbService = new DoorService();

        [HttpPost]
        public void Add(Door kapı)
        {
            _dbService.Add(kapı);

        }

        [HttpGet]
        public List<Door> GetAll()
        {
            return _dbService.GetAll();

        }


        [HttpGet("{id}")]
        public Door GetOneDoor(int id)
        {
            return _dbService.GetOneDoor(id);

        }


        [HttpPut]
        public void Update(Door NewDoor)
        {
            _dbService.Update(NewDoor);

        }


        [HttpDelete("{dışardanId}")]
        public void Delete(int dışardanId)
        {
            _dbService.Delete(dışardanId);


        }
        
    }
}

