namespace WebAPI.Models
{
    public class OgretimElemani : Kisi
    {
        public string SicilNo { get; set; }
        public List<Ders> VerdigiDersler { get; set; }
    }
}
