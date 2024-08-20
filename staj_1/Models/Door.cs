using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace staj_1.models
{
    //sınıfımızın özelliklerini tanımlıyoruz
    public class Door
    {
        //constructor
        public Door()
        {

            Random rastgele = new Random();

            Id = GenerateRandomId();
        }
        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }



        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

    }
}
