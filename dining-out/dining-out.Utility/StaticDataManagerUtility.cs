using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using dining_out.Models.ViewModels;
using dining_out.Models.DbModels;


namespace dining_out.Utility
{
    public class StaticDataManagerUtility
    {
        public static List<KeyValueVM> kisiSayisiListesi() {
            List<KeyValueVM> kisiler = new List<KeyValueVM>();
            for (int i = 1; i <= 20; ++i)
            {
                kisiler.Add(new KeyValueVM(i.ToString(), i.ToString()));
            }
            return kisiler;
        }

        public static void sehirleriDoldur(Controller controller)
        {   
            controller.ViewBag.CitiesData = sehirler();
        }

        public static void IlceleriDoldur(Controller controller, string cityId)
        {
            controller.ViewBag.DistrictiesData = StaticDataManagerUtility.ilceler()[cityId];
        }

        public static List<KeyValueVM> sehirler()
        {
            List<KeyValueVM> cities = new List<KeyValueVM>();
            cities.Add(new KeyValueVM("01", "Adana"));
            cities.Add(new KeyValueVM("06", "Ankara"));
            cities.Add(new KeyValueVM("26", "Eskişehir"));
            cities.Add(new KeyValueVM("34", "İstanbul"));
            return cities;
        }

        public static Dictionary<string,List<KeyValueVM>> ilceler()
        {
            var map = new Dictionary<string, List<KeyValueVM>>();

            List<KeyValueVM> istanbulIlceler = new List<KeyValueVM>();
            istanbulIlceler.Add(new KeyValueVM("01", "Adalar"));
            istanbulIlceler.Add(new KeyValueVM("02", "Arnavutköy"));
            istanbulIlceler.Add(new KeyValueVM("03", "Ataşehir"));
            istanbulIlceler.Add(new KeyValueVM("04", "Avcılar"));
            istanbulIlceler.Add(new KeyValueVM("05", "Bağcılar"));
            istanbulIlceler.Add(new KeyValueVM("06", "Bahçelievler"));
            istanbulIlceler.Add(new KeyValueVM("07", "Bakırköy"));
            istanbulIlceler.Add(new KeyValueVM("08", "Başakşehir"));
            istanbulIlceler.Add(new KeyValueVM("09", "Bayrampaşa"));
            istanbulIlceler.Add(new KeyValueVM("10", "Beşiktaş"));
            istanbulIlceler.Add(new KeyValueVM("11", "Beykoz"));
            istanbulIlceler.Add(new KeyValueVM("12", "Beylikdüzü"));
            istanbulIlceler.Add(new KeyValueVM("13", "Büyükçekmece"));
            istanbulIlceler.Add(new KeyValueVM("14", "Çatalca"));
            istanbulIlceler.Add(new KeyValueVM("15", "Çekmeköy"));
            istanbulIlceler.Add(new KeyValueVM("16", "Esenler"));
            istanbulIlceler.Add(new KeyValueVM("17", "Esenyurt"));
            istanbulIlceler.Add(new KeyValueVM("18", "Eyüpsultan"));
            istanbulIlceler.Add(new KeyValueVM("19", "Fatih"));
            istanbulIlceler.Add(new KeyValueVM("20", "Gaziosmanpaşa"));
            istanbulIlceler.Add(new KeyValueVM("21", "Güngören"));
            istanbulIlceler.Add(new KeyValueVM("22", "Kadıköy"));
            istanbulIlceler.Add(new KeyValueVM("23", "Kağıthane"));
            istanbulIlceler.Add(new KeyValueVM("24", "Kartal"));
            istanbulIlceler.Add(new KeyValueVM("25", "Küçükçekmece"));
            istanbulIlceler.Add(new KeyValueVM("26", "Maltepe"));
            istanbulIlceler.Add(new KeyValueVM("27", "Pendik"));
            istanbulIlceler.Add(new KeyValueVM("28", "Sancaktepe"));
            istanbulIlceler.Add(new KeyValueVM("29", "Sarıyer"));
            istanbulIlceler.Add(new KeyValueVM("30", "Silivri"));
            istanbulIlceler.Add(new KeyValueVM("31", "Sultangazi"));
            istanbulIlceler.Add(new KeyValueVM("32", "Şile"));
            istanbulIlceler.Add(new KeyValueVM("33", "Şişli"));
            istanbulIlceler.Add(new KeyValueVM("34", "Tuzla"));
            istanbulIlceler.Add(new KeyValueVM("35", "Ümraniye"));
            istanbulIlceler.Add(new KeyValueVM("36", "Üsküdar"));
            istanbulIlceler.Add(new KeyValueVM("37", "Zeytinburnu"));

            List<KeyValueVM> adanaIlceler = new List<KeyValueVM>();
            adanaIlceler.Add(new KeyValueVM("01", "Aladağ"));
            adanaIlceler.Add(new KeyValueVM("02", "Ceyhan"));
            adanaIlceler.Add(new KeyValueVM("03", "Çukurova"));
            adanaIlceler.Add(new KeyValueVM("04", "Feke"));
            adanaIlceler.Add(new KeyValueVM("05", "İmamoğlu"));
            adanaIlceler.Add(new KeyValueVM("06", "Karaisalı"));
            adanaIlceler.Add(new KeyValueVM("07", "Karataş"));
            adanaIlceler.Add(new KeyValueVM("08", "Kozan‎"));
            adanaIlceler.Add(new KeyValueVM("09", "Pozantı‎"));
            adanaIlceler.Add(new KeyValueVM("10", "Saimbeyli"));
            adanaIlceler.Add(new KeyValueVM("11", "Sarıçam"));
            adanaIlceler.Add(new KeyValueVM("12", "Seyhan"));
            adanaIlceler.Add(new KeyValueVM("13", "Tufanbeyli‎"));
            adanaIlceler.Add(new KeyValueVM("14", "Yumurtalık‎"));
            adanaIlceler.Add(new KeyValueVM("15", "Yüreğir"));

            List<KeyValueVM> ankaraIlceler = new List<KeyValueVM>();
            ankaraIlceler.Add(new KeyValueVM("01", "Akyurt"));
            ankaraIlceler.Add(new KeyValueVM("02", "Altındağ"));
            ankaraIlceler.Add(new KeyValueVM("03", "Ayaş"));
            ankaraIlceler.Add(new KeyValueVM("04", "Balâ"));
            ankaraIlceler.Add(new KeyValueVM("05", "Beypazarı"));
            ankaraIlceler.Add(new KeyValueVM("06", "Çamlıdere"));
            ankaraIlceler.Add(new KeyValueVM("07", "Çankaya"));
            ankaraIlceler.Add(new KeyValueVM("08", "Çubuk"));
            ankaraIlceler.Add(new KeyValueVM("09", "Elmadağ"));
            ankaraIlceler.Add(new KeyValueVM("10", "Etimesgut"));
            ankaraIlceler.Add(new KeyValueVM("11", "Evren"));
            ankaraIlceler.Add(new KeyValueVM("12", "Gölbaşı"));
            ankaraIlceler.Add(new KeyValueVM("13", "Güdül"));
            ankaraIlceler.Add(new KeyValueVM("14", "Haymana"));
            ankaraIlceler.Add(new KeyValueVM("15", "Kahramankazan"));
            ankaraIlceler.Add(new KeyValueVM("16", "Kalecik"));
            ankaraIlceler.Add(new KeyValueVM("17", "Keçiören"));
            ankaraIlceler.Add(new KeyValueVM("18", "Kızılcahamam"));
            ankaraIlceler.Add(new KeyValueVM("19", "Mamak"));
            ankaraIlceler.Add(new KeyValueVM("20", "Nallıhan"));
            ankaraIlceler.Add(new KeyValueVM("21", "Polatlı"));
            ankaraIlceler.Add(new KeyValueVM("22", "Pursaklar"));
            ankaraIlceler.Add(new KeyValueVM("23", "Sincan"));
            ankaraIlceler.Add(new KeyValueVM("24", "Şereflikoçhisar"));
            ankaraIlceler.Add(new KeyValueVM("25", "Yenimahalle"));

            List<KeyValueVM> eskisehirIlceler = new List<KeyValueVM>();
            eskisehirIlceler.Add(new KeyValueVM("01", "Alpu"));
            eskisehirIlceler.Add(new KeyValueVM("02", "Beylikova"));
            eskisehirIlceler.Add(new KeyValueVM("03", "Çifteler"));
            eskisehirIlceler.Add(new KeyValueVM("04", "Günyüzü"));
            eskisehirIlceler.Add(new KeyValueVM("05", "Han"));
            eskisehirIlceler.Add(new KeyValueVM("06", "İnönü"));
            eskisehirIlceler.Add(new KeyValueVM("07", "Mahmudiye"));
            eskisehirIlceler.Add(new KeyValueVM("08", "Mihalgazi"));
            eskisehirIlceler.Add(new KeyValueVM("09", "Mihalıççık"));
            eskisehirIlceler.Add(new KeyValueVM("10", "Odunpazarı"));
            eskisehirIlceler.Add(new KeyValueVM("11", "Sarıcakaya"));
            eskisehirIlceler.Add(new KeyValueVM("12", "Seyitgazi"));
            eskisehirIlceler.Add(new KeyValueVM("13", "Sivrihisar"));
            eskisehirIlceler.Add(new KeyValueVM("14", "Tepebaşı"));

            map.Add("01", adanaIlceler);
            map.Add("06", ankaraIlceler);
            map.Add("26", eskisehirIlceler);
            map.Add("34", istanbulIlceler);

            return map;
        }

        public static KeyValueVM sehirBul(String cityKey)
        {
            foreach(KeyValueVM keyValueVM in sehirler())
            {
                if (keyValueVM.Key.Equals(cityKey))
                {
                    return keyValueVM;
                }
            }
            return null;
        }

        public static KeyValueVM ilceBul(string cityId, string distrinctId)
        {
            foreach(KeyValueVM keyValueVm in StaticDataManagerUtility.ilceler()[cityId])
            {
                if (keyValueVm.Key.Equals(distrinctId))
                {
                    return keyValueVm;
                }
            }
            return null;
        }

        public static List<KeyValueVM> ilceBul(string cityId)
        {
           return ilceler()[cityId];
        }
    }
}
