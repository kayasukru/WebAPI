namespace WebAPI.Models
{
    public class Ogrenci : Kisi
    {
        public string OgrenciNo { get; set; }
        public ICollection<Ders> AldigiDersler { get; set; }
    }
}
