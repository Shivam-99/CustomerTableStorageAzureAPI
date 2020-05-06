using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerDemoApiAzureTableStorage.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
//using Microsoft.Azure.Cosmos.Table;

namespace CustomerDemoApiAzureTableStorage.Services
{
    public class CustomerTableStorageDbHandler : ICustomer
    {
        static CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            "DefaultEndpointsProtocol=https;AccountName=storageactesting;AccountKey=gJ+9DQC0+bx5w783jt/YxcuZXDV2rTt7h22b31qbHEZGEEwNfylmuJCiIe2qPddzLpcuH2+2JKmI/6v0+qUvmg==;EndpointSuffix=core.windows.net");
        
        static CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
        static CloudTable customertable = tableClient.GetTableReference("CustomersTable");

        public IEnumerable<Customer> GetAllCustomers()
        {
            TableQuery<CustomerEntity> getQuery = new TableQuery<CustomerEntity>();
            return customertable.ExecuteQuery(getQuery);
            //return new List<Customer>();
        }

        public void InsertCustomer(Customer customer)
        {
            CustomerEntity customerEntity = new CustomerEntity(customer);
            TableOperation insertOperation = TableOperation.Insert(customerEntity);
            customertable.ExecuteAsync(insertOperation);
        }
    }
}
