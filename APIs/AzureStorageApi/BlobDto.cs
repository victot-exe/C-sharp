using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureStorageApi
{
    public class BlobDto//Dto = Data transfer Object
    {
        public string Nome{ get; set; }
        public string Tipo{ get; set; }
        public string Uri{ get; set; }
    }
}