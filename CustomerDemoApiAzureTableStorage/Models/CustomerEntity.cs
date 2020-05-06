﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace CustomerDemoApiAzureTableStorage.Models
{
    public class CustomerEntity:TableEntity
    {
        public CustomerEntity()
        {

        }
        public CustomerEntity(Customer customer)
        {
            this.PartitionKey = "category";
            this.RowKey= customer.Id;
        }
    }
}