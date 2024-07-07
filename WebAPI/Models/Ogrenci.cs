namespace WebAPI.Models
{
    public class Ogrenci : Kisi
    {
        public string OgrenciNo { get; set; }
        public List<Ders> AldigiDersler { get; set; }
    }
}
