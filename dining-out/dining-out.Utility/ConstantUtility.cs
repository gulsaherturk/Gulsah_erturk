using System;
using System.Collections.Generic;

namespace dining_out.Utility
{
    public static class ConstantUtility
    {
        public enum RezervationStatus
        {
            NEW,APPROVED,CANCELLED,CLOSED
        }

        public static string textValueOfRezervationStatus(string rezervationStatus)
        {
            if (RezervationStatus.NEW.ToString().Equals(rezervationStatus))
            {
                return "Yeni";
            }
            if (RezervationStatus.APPROVED.ToString().Equals(rezervationStatus))
            {
                return "Onaylandı";
            }
            if (RezervationStatus.CANCELLED.ToString().Equals(rezervationStatus))
            {
                return "İptal";
            }
            if (RezervationStatus.CLOSED.ToString().Equals(rezervationStatus))
            {
                return "Kapandı";
            }
            return "";

        }

        public static bool IsRezervationStatusNEW(string rezervationStatus)
        {
            if (RezervationStatus.NEW.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public static bool IsRezervationStatusAPPROVED(string rezervationStatus)
        {
            if (RezervationStatus.APPROVED.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public static bool IsRezervationStatusCANCELLED(string rezervationStatus)
        {
            if (RezervationStatus.CANCELLED.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public static bool IsRezervationStatusCLOSED(string rezervationStatus)
        {
            if (RezervationStatus.CLOSED.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public enum UserType
        {
            CUSTOMER, RESTAURANT
        }

        public enum OrderedItemStatus
        {
            NEW,SERVICED,CANCELLED, PURCHASED
        }

        public static List<string> tumSiparisDurumlar()
        {
            List<string> tumSiparisDurumlar = new List<string>();
            tumSiparisDurumlar.Add(textValueOfOrderedItemStatus(OrderedItemStatus.NEW.ToString()));
            tumSiparisDurumlar.Add(textValueOfOrderedItemStatus(OrderedItemStatus.SERVICED.ToString()));
            tumSiparisDurumlar.Add(textValueOfOrderedItemStatus(OrderedItemStatus.CANCELLED.ToString()));
            tumSiparisDurumlar.Add(textValueOfOrderedItemStatus(OrderedItemStatus.PURCHASED.ToString()));
            return tumSiparisDurumlar;
        }


        public static string textValueOfOrderedItemStatus(string orderedItemStatus)
        {
            if (OrderedItemStatus.NEW.ToString().Equals(orderedItemStatus))
            {
                return "Yeni Sipariş";
            }
            if (OrderedItemStatus.SERVICED.ToString().Equals(orderedItemStatus))
            {
                return "Servis Edildi";
            }
            if (OrderedItemStatus.CANCELLED.ToString().Equals(orderedItemStatus))
            {
                return "İptal Edildi";
            }
            if (OrderedItemStatus.PURCHASED.ToString().Equals(orderedItemStatus))
            {
                return "Ödendi";
            }
            return "";
        }

        public static string enumValueOfOrderedItemStatus(string orderedItemStatus)
        {
            if ("Yeni Sipariş".Equals(orderedItemStatus))
            {
                return OrderedItemStatus.NEW.ToString();
            }
            if ("Servis Edildi".Equals(orderedItemStatus))
            {
                return OrderedItemStatus.SERVICED.ToString();
            }
            if ("İptal Edildi".Equals(orderedItemStatus))
            {
                return OrderedItemStatus.CANCELLED.ToString();
            }
            if ("Ödendi".Equals(orderedItemStatus))
            {
                return OrderedItemStatus.PURCHASED.ToString();
            }
            return "";

        }
    }
}
