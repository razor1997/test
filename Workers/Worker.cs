using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Workers
{
    public class Worker
    {
        private string name;
        private string secondName;
        // private int age;
        private int hoursInThisMonth;
        private int yearsInWork;
        public Worker()
        {
            name = "Kazik";
            secondName = "Nosacz";
            hoursInThisMonth = 100;
            yearsInWork = 1;
        }
            public Worker(string name, string secondName, int hoursInThisMonth, int yearsInWork)
        {
            this.name = name;
            this.secondName = secondName;
            this.yearsInWork = yearsInWork;
            this.hoursInThisMonth = hoursInThisMonth;
        }
        public void Wyswietl ()
        {
            if(yearsInWork>4)
                MessageBox.Show("Pracownik " + name + " " + secondName + " zarabia " + hoursInThisMonth*30 + " miesięcznie" );
            else
            {
                MessageBox.Show("Pracownik " + name + " " + secondName + " zarabia " + hoursInThisMonth * 15 + " miesięcznie");
                MessageBox.Show("Niech weźmie się za robotę");
            }


        }
        int pricePerHour = 10;
        public void Price(string name,int hoursInThisMonth)
        {
            int salary = pricePerHour * hoursInThisMonth;
            MessageBox.Show("Pracownik"+ name+" zarobił w tym miesiącu " + salary + " oraz przepracował " + hoursInThisMonth + " godzin\n");
            if (hoursInThisMonth > 160)
            {
                MessageBox.Show("Należy mu się premia");
            }
            else
                MessageBox.Show("Musi dać z siebie więcej");
        }
        
    }
}
