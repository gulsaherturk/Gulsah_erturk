using System;
namespace dining_out.Models.ViewModels
{
    public class MasaRezervasyonVM
    {
        public MasaRezervasyonVM(int restaurantId)
        {
            this.RestaurantId = restaurantId;
        }

        public MasaRezervasyonVM()
        {
        }

        public int RestaurantId { get; set; }
        public int KisiSayisi { get; set; }
        public string IsimSoyisim { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Aciklama { get; set; }
    }
}
