using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workers
{
    public class Manager : Worker
    {
        private int quantityOfPeople;
        public Manager(string name, string secondName, int hoursInThisMonth,int yearsInWork, int quantityOfPeople) 
            : base(name,secondName,hoursInThisMonth,yearsInWork)
        {
            this.quantityOfPeople = quantityOfPeople;
        }
        public void Price(string name, string secondName, int quantityOfPeople,int hoursInThisMonth)
        {
            if (quantityOfPeople > 4)
                MessageBox.Show("Kierownik " + name + secondName + " powinien zarabiać " + hoursInThisMonth*30 + " netto");
            else
                MessageBox.Show("Kierownik " + name +" "+ secondName + " powinien zarabiać " + hoursInThisMonth * 25 + " netto");
        }
    }
}
