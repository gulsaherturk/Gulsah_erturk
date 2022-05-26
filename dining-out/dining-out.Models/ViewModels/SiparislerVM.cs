using System;
using System.Collections.Generic;

namespace dining_out.Models.ViewModels
{
    public class SiparislerVM
    {
        public SiparislerVM()
        {
            newOrderedItems = new List<BookTableOrderedItemVM>();
            servicedOrderedItems = new List<BookTableOrderedItemVM>();
            otherOrderedItems = new List<BookTableOrderedItemVM>();
            SiparisDurumlar = new List<string>();
        }

        public List<BookTableOrderedItemVM> newOrderedItems { get; set; }
        public List<BookTableOrderedItemVM> servicedOrderedItems { get; set; }
        public List<BookTableOrderedItemVM> otherOrderedItems { get; set; }
        public List<string> SiparisDurumlar { get; set; }
    }
}
