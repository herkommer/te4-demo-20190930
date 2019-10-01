using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.GUI
{
    public partial class Form1 : Form
    {
        //Refactoring: vi ersätter ArrayList med en List<T>
        //Dvs en Generic, eller starkt typad lista
        List<Person> MyPersons = new List<Person>();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Spara kund";
            button2.Text = "Visa kunder";
            button3.Text = "Spara anställd";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Spara kund
            //Var ska kunden sparas?
            //repository = "sparenhet" (ex: DB, fil, array etc)
            //vi vill göra det enkelt, vi väljer en ArrayList

            MyPersons.Add(new Customer() { FirstName = textBox1.Text, LastName = textBox2.Text });

            //Visa för användaren att kunden är sparad

            UpdateUI();

        }

        private void UpdateUI()
        {
            textBox1.Text = ""; //detta är en tom sträng, men det ÄR en sträng!
            textBox2.Text = string.Empty; //detta tar ingen plats och är en logisk representation av tom sträng

            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Skriv ut alla kunder som ligger i repositoryt
            foreach (Person p in MyPersons)
            {
                listBox1.Items.Add(p); //vad kommer vi få se utskrivet?
                //OBS: använd INTE c.FirstName
                //hur ska vi då styra vad som ska visa?
                //funktionen heter .ToString() och alla har den
                //vi vill skriva om den funktionen!
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Spara anställd
            MyPersons.Add(new Employee() { FirstName = textBox1.Text, LastName = textBox2.Text });

            UpdateUI();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Här hamnar vi om vi väljer något i listan
            //klick eller piltangenter
            MessageBox.Show(string.Format("Jag är en {0}",listBox1.SelectedItem.GetType().Name));

            //specifik info beroende på vilken typ vi har att göra med
            if (listBox1.SelectedItem.GetType().Name == "Customer")
            {
                //Se till att object skärper sig, dvs explicit blir vad den är och alltid varit
                //en Customer igen, så vi kan prata egenskaper som VIP
                MessageBox.Show(string.Format("VIP status: {0}", ((Customer)listBox1.SelectedItem).VIP));
            }
        }
    }
}
