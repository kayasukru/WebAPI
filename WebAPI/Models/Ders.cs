namespace WebAPI.Models
{
    public class Ders : Entity
    {
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int DersKontenjani { get; set; }

        public OgretimElemani DersiVerenOgretimElemani { get; set; }
        public ICollection<Ogrenci> DersiAlanOgrenciler { get; set; }
    }
}
