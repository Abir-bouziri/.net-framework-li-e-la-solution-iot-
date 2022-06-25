using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.DataSet1TableAdapters;
using administrateur;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
       public string id_véhicule;
        public string id_matricule;
        public string date;

        public Form5()
        {
            InitializeComponent();
           
             
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = id_véhicule;
            label2.Text = id_matricule;
            label3.Text = date;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=gps_db;uid=root;pwd=''";
            cnn = new MySqlConnection(connetionString);
         /*   try
            {*/
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                string req1 = "SELECT lattitude from gps where id_véhicule="+id_véhicule+" and immatricule="+"'"+id_matricule+"'"+" and gps_date="+"'"+date+"'";
                MessageBox.Show(req1);
            MySqlCommand cmd1 = new MySqlCommand(req1, cnn);
                var reader = cmd1.ExecuteReader();
                gpsTableAdapter a = new gpsTableAdapter();
                decimal k = Convert.ToDecimal(a.ScalarQuery(Convert.ToDateTime(date),Convert.ToDecimal(id_véhicule),id_matricule));
                int i = 0;
                if (k != 1)
                {
                    string[] latttab = new string[500];
                    string[] longtitab = new string[500];
                    while (reader.Read() && i < k + 1)
                    {


                        latttab[i] = reader.GetString(0);
                        i++;

                    }

                    int m = 0;
                    double result = 0;
                    cnn.Close();
                    cnn.Open();
                    string req2 = "SELECT longtitude from gps where id_véhicule=" + id_véhicule + " and immatricule=" + "'" + id_matricule + "'" + " and gps_date=" + "'" + date + "'";

                    MySqlCommand cmd2 = new MySqlCommand(req2, cnn);
                    var reader1 = cmd2.ExecuteReader();
                    int p = 0;
                    while (reader1.Read() && p < k + 1)
                    {


                        longtitab[p] = reader1.GetString(0);
                        /*MessageBox.Show("frf"+p);
                        MessageBox.Show(longtitab[p]);*/
                        p++;

                    }



                    int l = 0;
                    while (l < k + 1 && m < k+1)
                    {
                        MessageBox.Show("t[" + m + "]");
                        MessageBox.Show(latttab[m]);

                        MessageBox.Show("t[" + m + 1 + "]");
                        MessageBox.Show(latttab[m + 1]);
                        MessageBox.Show("tlongtimax[" + l + "]");
                        MessageBox.Show(longtitab[l]);

                        MessageBox.Show("tlongtimax[" + l + 1 + "]");
                        MessageBox.Show(longtitab[l + 1]);

                        admi admo = new admi();

                        MessageBox.Show("t[" + m + "]" + Convert.ToString(Math.Abs(admo.distance(Convert.ToDouble(latttab[m]), Convert.ToDouble(latttab[m + 1]), Convert.ToDouble(longtitab[l]), Convert.ToDouble(longtitab[l + 1])))));
                        result = result + Math.Abs(admo.distance(Convert.ToDouble(latttab[m]), Convert.ToDouble(latttab[m + 1]), Convert.ToDouble(longtitab[l]), Convert.ToDouble(longtitab[l + 1])));
                        MessageBox.Show("result" + Convert.ToString(result));
                        l++;
                        m++;
                           if (m+1==k && l+1==k)
                            { break; }
                            else
                            {

                            }

                    }
                    MessageBox.Show(Convert.ToString(result));
                    label4.Text = Convert.ToString(result + " " + "km");
                    admi ess = new admi();
                    string t = Convert.ToString(ess.consommation(result));
                    label5.Text = t +" Litres";
                    cnn.Close();
                    /*   }

                       catch (Exception)
                       {
                           MessageBox.Show("Connection Failed ! ");
                       }*/
                }
                else
                {
                    label4.Text = "0 Km";
                    label5.Text = "0 Litres";
                }
        
}




        
       
       
        
    }
}
