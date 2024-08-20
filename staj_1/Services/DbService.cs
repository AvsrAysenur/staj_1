using staj_1.ContextSQL;
using staj_1.models;

namespace staj_1.Services
{
    public class DbService : IDoorService
    {
        //database ile bağlantı kurmak için
        private readonly AplicationDbContext _dbContext;
        public DbService(AplicationDbContext DbContext)
        {
            _dbContext = DbContext;
        }



        //fonksiyonların iskeleti oluşturuluyor
        public void Add(Door door)
        {
            //ekleme işlemi yapılıyor
            _dbContext.Add(door);
            //değişiklikleri kaydetme işlemi yapılıyor
           // _dbContext.SaveChanges();

        }

        public void Delete(int dışardanId)
        {
            _dbContext.Remove(dışardanId);
            _dbContext.SaveChanges();
        }

        public List<Door> GetAll()
        {
            return _dbContext.doors.ToList();
        }

        public Door getOneDoor(int id)
        {
            return _dbContext.doors.FirstOrDefault(x => x.Id == id);
        }

        public Door GetOneDoor(int id)
        {
            
            return _dbContext.doors.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Door güncelKapı)
        {
            _dbContext.Update(güncelKapı);
        }



    }
}
