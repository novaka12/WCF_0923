using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_0923_szerver.Models;

namespace WCF_0923_szerver.Interfaces
{
    [ServiceContract]
    public interface IJogosultsagok
    {
        [OperationContract]
        List<Jogosultsagok> JogosultsagokLista_CS();

        
        [OperationContract]
        string JogosultsagokAdd_CS(Jogosultsagok jog);

        
        [OperationContract]
        string JogosultsagokUpdate_CS(Jogosultsagok jog);

        
        [OperationContract]
        string JogosultsagokDelete_CS(int Id);
    }
}
