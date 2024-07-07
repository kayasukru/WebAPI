namespace WebAPI.Models
{
    public class OgretimElemani : Kisi
    {
        public string SicilNo { get; set; }
        public ICollection<Ders> VerdigiDersler { get; set; }
    }
}
