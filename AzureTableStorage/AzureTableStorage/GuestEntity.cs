using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTableStorage
{
    class GuestEntity : TableEntity
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public GuestEntity()
        {

        }
        public GuestEntity(string PartitionKey,string RowKey)
        {
            this.PartitionKey = PartitionKey;
            this.RowKey = RowKey;
        }
           
    }
}
