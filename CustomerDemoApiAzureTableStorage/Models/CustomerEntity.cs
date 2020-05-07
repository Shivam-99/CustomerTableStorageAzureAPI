using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.Azure.Cosmos.Table;
namespace CustomerDemoApiAzureTableStorage.Models
{
    public class CustomerEntity:TableEntity
    {
        public CustomerEntity()
        {

        }
        public CustomerEntity(Customer customer)
        {
            this.PartitionKey = customer.Category;
            this.RowKey= customer.Id;
        }
    }
}
