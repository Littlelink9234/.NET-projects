using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fdm.BankTeller.Main.Storage
{
    public class StorageFactory
    {
        private static readonly String COLLECTION = "StorageCollection";
        private static readonly String DATABASE = "DatabaseStorage";
        private static readonly String XML_DATABASE = "XMLStorage";
        private static readonly String STORAGE_ERROR = "Error: Invalid Storage Type";

        public IStorage createStorage(String storageType)
        {
            if (storageType == COLLECTION)
            {
                return new StorageCollection();
            }
            
            if (storageType == DATABASE)
            {
                return new DatabaseStorage();
            }
            if (storageType == XML_DATABASE)
            {
                return new XMLStorage();
            }
            else
                throw new BankException(STORAGE_ERROR);
        }
    }
}
