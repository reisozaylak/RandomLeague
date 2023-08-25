using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        Random rastgeleSkor = new Random();
        Random rastgeleMaç = new Random();

        int gsPuan = 0;
        int bjkPuan = 0;
        int tsPuan = 0;
        int fbPuan = 0;
        int i = 1;
        string[] takimlar = { "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor" };
        private void button1_Click(object sender, EventArgs e)
        {
            i = i + 1;
            groupBox1.Text = "Week-" + "" + i.ToString();
            button1.Text = "Week-" + "" + i.ToString();

            int a = rastgeleSkor.Next(0, 5);
            int b = rastgeleSkor.Next(0, 5); // creates a random numbers 0 to 5 to insert into matches scores
            int c = rastgeleSkor.Next(0, 5);
            int d = rastgeleSkor.Next(0, 5);

            for (int i = 0; i < takimlar.Length; i += 2)  
            {
                int rastgeleIndex1 = rastgeleMaç.Next(takimlar.Length);
                int rastgeleIndex2;
                int rastgeleIndex3 = rastgeleMaç.Next(takimlar.Length);
                int rastegeleIndex4;

                do   // creates do while loop to check random generated teams are not the same if they are same generate again in while loop
                     // if its not the same write them into teams label.text
                {
                    rastgeleIndex2 = rastgeleMaç.Next(takimlar.Length);    
                    rastegeleIndex4 = rastgeleMaç.Next(takimlar.Length);
                }
                while (rastgeleIndex2 == rastgeleIndex1 || rastegeleIndex4 == rastgeleIndex3);

                string rastgeleTakim1 = takimlar[rastgeleIndex1];
                string rastgeleTakim2 = takimlar[rastgeleIndex2];
                label1.Text = rastgeleTakim1;
                label2.Text = rastgeleTakim2;

                string rastgeleTakim3 = takimlar[rastgeleIndex3];
                string rastgeleTakim4 = takimlar[rastegeleIndex4];
                label9.Text = rastgeleTakim3;
                label10.Text = rastgeleTakim4;
            }

            label4.Text = a.ToString();
            label5.Text = b.ToString(); // get scores as an int to create scoreboard  
            label6.Text = c.ToString();
            label7.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gsPuan = gsPuan + 3;
                labelgspuan.Text = gsPuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbPuan = fbPuan + 3;
                labelfbpuan.Text = fbPuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gsPuan = gsPuan + 1;
                fbPuan = fbPuan + 1;
                labelgspuan.Text = gsPuan.ToString();
                labelfbpuan.Text = fbPuan.ToString();
            }

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkPuan = bjkPuan + 3;
                labelbjkpuan.Text = bjkPuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                tsPuan = tsPuan + 3;
                labeltspuan.Text = tsPuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label7.Text))
            {
                bjkPuan = bjkPuan + 1;
                tsPuan = tsPuan + 1;
                labeltspuan.Text = tsPuan.ToString();
                labelbjkpuan.Text = bjkPuan.ToString();
            }

        }
    }
}
