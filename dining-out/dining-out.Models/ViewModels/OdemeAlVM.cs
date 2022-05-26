using System;
using System.Collections.Generic;

namespace dining_out.Models.ViewModels
{
    public class OdemeAlVM
    {
        public OdemeAlVM()
        {
            BookTableOrderedItemsVM = new List<BookTableOrderedItemVM>();
        }

        public int MasaRezervationId { get; set; }
        public decimal Toplam { get; set; }
        public string Promosyon { get; set; }
        public decimal PromosyonMiktari { get; set; }
        public string CartHolder { get; set; }
        public string CartNumber { get; set; }
        public string CardValidDate { get; set; }
        public string CardSecurityNumber { get; set; }
        public string CartType { get; set; }

        public List<BookTableOrderedItemVM> BookTableOrderedItemsVM { get; set; }
    } 
}
