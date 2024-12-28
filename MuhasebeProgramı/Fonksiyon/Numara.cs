using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeProgramı.Fonksiyon
{
    internal class Numara
    {
        DataClasses1DataContext DB = new DataClasses1DataContext();
        Mesajlar Mesajlar = new Mesajlar();
        public string StokKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_STOKLARs
                                        orderby s.ID descending
                                        select s).First().STOKKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception EX)
            {
                return "0000001";
            }
        }

        public string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_CARILERs
                                        orderby s.ID descending
                                        select s).First().CARIKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception EX)
            {
                return "0000001";
            }
        }

        public string KasaKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_KASALARs
                                        orderby s.ID descending
                                        select s).First().KASAKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception EX)
            {
                return "0000001";
            }
        }




    }
}
