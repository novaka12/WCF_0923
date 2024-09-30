using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_0923_szerver.Controllers;
using WCF_0923_szerver.Interfaces;
using WCF_0923_szerver.Models;

namespace WCF_0923_szerver
{

    public class Service1 : IService1
    {
        public string FelhasznaloAdd_CS(Felhasznalok felhasznalo)
        {
            FelhasznalokController controller = new FelhasznalokController();
            return controller.Insert(felhasznalo);
        }

        public string FelhasznaloDelete_CS(int Id)
        {
            FelhasznalokController controller = new FelhasznalokController();
            string valasz = controller.Delete(Id);
            return valasz;
        }

        public List<Felhasznalok> FelhasznalokLista_CS()
        {
            FelhasznalokController controller = new FelhasznalokController();
            List<Record> rekordok = controller.Select();
            List<Felhasznalok> ujlista=new List<Felhasznalok>();
            foreach (Record r in rekordok)
            {
                ujlista.Add(r as Felhasznalok);
            }
            return ujlista;
            /*List<Felhasznalok> felhlista=new List<Felhasznalok>();
            Felhasznalok f1= new Felhasznalok()
            {
                Id=1,
                LoginNev="pimpike",
                HASH="sadfagfb",
                SALT="KJDBUBAI",
                Nev="Bojtos Pimpike",
                Jog= 1,
                Aktiv=true,
                Email="pimpike@alza.sk",
                Profilkep="pimpike.jpg"
            };
            felhlista.Add(f1);
            return felhlista;*/
        }

        public string FelhasznaloUpdate_CS(Felhasznalok felhasznalo)
        {
            throw new NotImplementedException();
        }

        public List<Jogosultsagok> JogosultsagokLista_CS()
        {
            JogosultsagokController controller =new JogosultsagokController();
            List<Record> rekordok = controller.Select();
            List<Jogosultsagok> ujlista = new List<Jogosultsagok>();
            foreach (Record r in rekordok)
            {
                ujlista.Add(r as Jogosultsagok);
            }
            return ujlista;

        }
        public string JogosultsagokAdd_CS(Jogosultsagok jog)
        {
            throw new NotImplementedException();
        }
        public string JogosultsagokDelete_CS(int id)
        {
            throw new NotImplementedException();
        }
        public string JogosultsagokUpdate_CS(Jogosultsagok jog)
        {
            throw new NotImplementedException();
        }
    }
}
