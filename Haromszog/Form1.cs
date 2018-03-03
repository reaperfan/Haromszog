using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszog
{
    public partial class MainForm : Form
    {
        string sor = "";
        List<DHarmoszog> list = new List<DHarmoszog>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_adatBetoltes_Click(object sender, EventArgs e)
        {
            
            try
            {
                int sorszam = 1;
               
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Szöveges állomány (.txt) | *.txt"
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    listBox_Dharomszog.Items.Clear();
                    listBox_Hiba.Items.Clear();
                    listBox_Kivalasztott.Items.Clear();
                    StreamReader sr = new StreamReader(ofd.FileName);
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            sor = sr.ReadLine();
                            DHarmoszog dHarmoszog = new DHarmoszog(sor, sorszam++);
                            list.Add(dHarmoszog);
                            listBox_Dharomszog.Items.Add(dHarmoszog);
                            
                        }
                        catch (Exception exp)
                        {
                            string[] hibaselem = sor.Split(' ');
                            listBox_Hiba.Items.Add(String.Format("{0}.sor : a={1}, b={2}, c={3}", sorszam-1, hibaselem[0], hibaselem[1], hibaselem[2]));
                            MessageBox.Show("Hiba: " +exp.Message.ToString());
                            
                        }
                    }
                    sr.Close();
                    
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show("Hiba: " + exp.Message.ToString());
            }
            
        }

        

        private void ListBox_Dharomszog_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Kivalasztott.Items.Clear();
            int index = listBox_Dharomszog.SelectedIndex;
            listBox_Kivalasztott.Items.Add("Kerület = "+list.ElementAt(index).Kerulet);
            listBox_Kivalasztott.Items.Add("Terület = "+list.ElementAt(index).Terulet);
        }
    }
}
