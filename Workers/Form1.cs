using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Workers
{
    public partial class Form1 : Form
    {
        Worker[] worker;
        Manager[] manager;
        List<Director> director = new List<Director>();

        public Form1()
        {
            InitializeComponent();
            worker = new Worker[10];
            worker[0]=new Worker("Andrzej","Kowalski",234,4);
            worker[1] = new Worker("Roman", "Polańczyk", 202, 5);
            worker[2] = new Worker("Janusz", "Nosacz", 120, 6);
            worker[3] = new Worker("Waldemar", "Kiepski", 60, 8);
            worker[4] = new Worker("Katarzyna", "Niewiejaka", 160, 1);
            worker[5] = new Worker("Grzegorz", "Paździoch", 140, 3);
            worker[6] = new Worker((string)NameText.Text, (string)SecondNameText.Text, (int)HoursInWorkNumeric.Value, (int)yearsInCorpo.Value);
            worker[7] = new Worker((string)NameText.Text, (string)SecondNameText.Text, (int)HoursInWorkNumeric.Value, (int)yearsInCorpo.Value);
            worker[8] = new Worker();
            worker[9] = new Worker();

            manager = new Manager[3];
            manager[0] = new Manager((string)NameText.Text, (string)SecondNameText.Text, (int)HoursInWorkNumeric.Value, (int)yearsInCorpo.Value,7);
            manager[1] = new Manager((string)NameText.Text, (string)SecondNameText.Text, (int)HoursInWorkNumeric.Value, (int)yearsInCorpo.Value, 5);
            manager[2] = new Manager((string)NameText.Text, (string)SecondNameText.Text, (int)HoursInWorkNumeric.Value, (int)yearsInCorpo.Value, 3);
            
            for(int i = 0; i<worker.Length;i++)
            {
                    worker[i].Wyswietl();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckWorkers.Checked)
                worker[0].Price("Andrzej" ,234);
            else if (CheckManager.Checked)
                manager[0].Price(NameText.Text,SecondNameText.Text,(int)numericOfPeople.Value,(int)HoursInWorkNumeric.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Director> director = new List<Director>();
            director.Add(new Director(543, 234) { });
            director[0].Zwolnij();
            foreach(Worker workers in worker)
            {
                workers.Wyswietl();
            }
        }
    }
}
