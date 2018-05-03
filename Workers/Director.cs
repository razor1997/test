using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workers
{
    enum peopleInWork
     {
        Kazik,
        Sławek,
        Maniek,
        Paweł
    }
    public class Director : IRespons
    {
        private int age;
        private float price;
        
        public Director()
        {

        }
        public Director(int age, float price)
        {
            this.age = age;
            this.price = price;
        }
        public void Zwolnij()
        {
            MessageBox.Show("Czy na pewno chcesz zwolnić pracownika?");
            MessageBox.Show("Pracownik został zwiolniony");
        }
        public void howWork()
        {
            MessageBox.Show("");
        }

    }
}
