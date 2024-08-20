using staj_1 .models;


namespace staj_1.Services
{
    public interface IDoorService
    {


        void Add(Door kapı);

        List<Door> GetAll();

        Door GetOneDoor(int id);

        void Update(Door NewDoor);

        void Delete(int dışardanıd);

        //Response<List<Door>> GetAll();
        //Response<Door> GetOneDoor(int id);
        //Response<Door> Add(Door kapı);
        //Response<Door> Update(int id, Door güncelKapı);
        //Response<bool> Delete(int dışarıdanid);





    }
}
