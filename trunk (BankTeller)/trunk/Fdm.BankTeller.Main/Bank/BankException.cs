using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fdm.BankTeller.Main;

namespace Fdm.BankTeller.Main
{
    public class BankException : Exception
    {
        private String text;
        
        public BankException(String text)
        {
            this.text = text;
        }
        
        public String getText()
        {
            return text;
        }
    }
}
