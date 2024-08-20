using staj_1.ContextSQL;
using staj_1.models;
using staj_1.models;

namespace staj_1.Services
{
    public class DoorService : IDoorService
    {
        //door listesi oluşturuluyor
        //Model ile bağlantı kurmak için

        private static readonly List<Door> _door = new List<Door>();



        public void Add(Door door)
        {

            _door.Add(new Door()
            {


                X = door.X,
                Y = door.Y,

            });

        }



        public List<Door> GetAll()
        {
            return _door;
        }

        public Door getOneDoor(int Id)
        {

            Door searchingDoor = _door.FirstOrDefault(door => door.Id == Id);


            return searchingDoor;
        }


        public void Update(Door NewDoor)
        {

            Door UpdatedDoor = _door.FirstOrDefault(door => door.Id == NewDoor.Id);


            UpdatedDoor.X = NewDoor.X;
            UpdatedDoor.Y = NewDoor.Y;

        }


        public void Delete(int dışardanId)
        {


            Door DeletedDoor = _door.FirstOrDefault(door => door.Id == dışardanId);
            _door.Remove(DeletedDoor);
        }

        public void add(Door kapı)
        {
            throw new NotImplementedException();
        }



        public Door getonedoor(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Door NewDoor)
        {
            throw new NotImplementedException();
        }

        public void delete(int dışardanıd)
        {
            throw new NotImplementedException();
        }



        List<Door> IDoorService.GetAll()
        {
            throw new NotImplementedException();
        }

        Door IDoorService.GetOneDoor(int id)
        {
            throw new NotImplementedException();
        }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
     
    }
}
