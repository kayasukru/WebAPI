using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        public OgrenciController()
        {
        }

        [HttpGet]
        //Get requesti geldiğinde çalışacak fonksiyon
        public List<Ogrenci> Get()
        {
            //Veriler el ile tanımlanıyor
            List<Ders> dersGrubu_1 = new List<Ders>();
            dersGrubu_1.Add(new Ders { Id = 0, DersKodu = "I101", DersAdi = "Web Tasarımı", DersKontenjani = 20 });
            dersGrubu_1.Add(new Ders { Id = 1, DersKodu = "I102", DersAdi = "Internet Programlama", DersKontenjani = 15 });

            List<Ders> dersGrubu_2 = new List<Ders>();
            dersGrubu_2.Add(new Ders { Id = 0, DersKodu = "I103", DersAdi = "Nesne Yönelimli Programlama", DersKontenjani = 15 });

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci { Id = 0, OgrenciNo = "202401", Adi = "Selime", Soyadi = "Sayın", DogumTarihi = Convert.ToDateTime("25/10/2001"), AldigiDersler = dersGrubu_1 });
            ogrenciler.Add(new Ogrenci { Id = 1, OgrenciNo = "202402", Adi = "Seher", Soyadi = "Gülmez", DogumTarihi = Convert.ToDateTime("5/2/2002"), AldigiDersler = dersGrubu_1 });
            ogrenciler.Add(new Ogrenci { Id = 2, OgrenciNo = "202403", Adi = "Seyide", Soyadi = "Kara", DogumTarihi = Convert.ToDateTime("15/11/1999"), AldigiDersler = dersGrubu_2 });
            ogrenciler.Add(new Ogrenci { Id = 3, OgrenciNo = "202404", Adi = "Sait", Soyadi = "Can", DogumTarihi = Convert.ToDateTime("3/6/2003"), AldigiDersler = dersGrubu_2 });

            return ogrenciler;
        }
    }
}
