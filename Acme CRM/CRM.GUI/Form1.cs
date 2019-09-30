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
        ArrayList MyCustomers = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Spara kund";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Spara kund
            //Var ska kunden sparas?
            //repository = "sparenhet" (ex: DB, fil, array etc)
            //vi vill göra det enkelt, vi väljer en ArrayList

            MyCustomers.Add(new Customer() {FirstName=textBox1.Text, LastName=textBox2.Text });

            //Visa för användaren att kunden är sparad

            textBox1.Text = ""; //detta är en tom sträng, men det ÄR en sträng!
            textBox2.Text = string.Empty; //detta tar ingen plats och är en logisk representation av tom sträng

            textBox1.Focus();

        }
    }
}
