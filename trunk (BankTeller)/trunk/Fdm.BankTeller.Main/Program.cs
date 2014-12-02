using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace Fdm.BankTeller.Main.Storage
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            String DATABASE = "DatabaseStorage";
            String XML_DATABASE = "XMLStorage"; 

            //AppSettingsReader appReader = new AppSettingsReader();

            //string datastore = (string)appReader.GetValue(DATASELECTION, typeof(string));
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StorageFactory storageFactory = new StorageFactory();
            IBankController controller = new BankController(new AccountManager(new AccountFactory(), storageFactory.createStorage(XML_DATABASE)));
            Application.Run(new BankForm(controller));
        }
    }
}
