using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using WindowsFormsApplication1.DataSet1TableAdapters;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            comboBoxEdit1.Text = "--veuillez saisir l' id du véhicule--";
            comboBoxEdit2.Text = "--veuillez saisir l'immatricule--";
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;



            gMapControl1.Position = new GMap.NET.PointLatLng(35.035439, 9.483939);
            gMapControl1.ShowCenter = false;
        }
        private void addmarker(float latt, float longti)
        {
            gMapControl1.Position = new GMap.NET.PointLatLng(latt, longti);
            gMapControl1.ShowCenter = false;
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            //marker une position 
            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle
                   (new GMap.NET.PointLatLng(latt, longti), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }
        private void mécanicien_Click(object sender, EventArgs e)
        {       string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=mecanicien_db;uid=root;pwd=''";
            cnn = new MySqlConnection(connetionString);



                cnn.Open();
                MessageBox.Show("Connection Open ! ");



                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM mecanicien ", cnn);
                var reader = cmd1.ExecuteReader();
                while (reader.Read())
                {

                    var latt = float.Parse(reader.GetString(1));
                    var longti = float.Parse(reader.GetString(2));
                    var nom=reader.GetString(3);
                    var num = reader.GetString(4);
                 /*   MessageBox.Show("latt");
                    MessageBox.Show(reader.GetString(3));*/

                    gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                    GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;


                    gMapControl1.Position = new GMap.NET.PointLatLng(latt, longti);
                    gMapControl1.ShowCenter = false;
                    GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
                    //marker une position 
                    GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle
                           (new GMap.NET.PointLatLng(latt, longti), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
                    markers.Markers.Add(marker);
                    gMapControl1.Overlays.Add(markers);
                    marker.ToolTipText = "Nom du mécanicien:"+" "+ nom +""+"\nTéléphone"+":"+ num ;
                    gMapControl1.Zoom = 8;

                }
                cnn.Close();

            
        }

      /*  private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            


            gMapControl1.Position = new GMap.NET.PointLatLng(35.035439, 9.483939);
            gMapControl1.ShowCenter = false;
 
        }*/
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }

        

        private void position_maintenance_Click(object sender, EventArgs e)
        {
            string id = comboBoxEdit1.Text;
            string im = comboBoxEdit2.Text;
           // MessageBox.Show(id);
         //   MessageBox.Show(im);
            if(id=="" && im=="")
            { MessageBox.Show("veuillez insérer  vos données"); }
            else if (id == "" && im!="")
            { MessageBox.Show("veuillez insérer  votre id de véhicule"); }
            else if (id != "" && im == "")
            { MessageBox.Show("veuillez insérer  votre immatricule"); }
            else
            {
                try
                {
                    decimal i = Convert.ToDecimal(id);
                    gpsTableAdapter gps = new gpsTableAdapter();
                    String longti = Convert.ToString(gps.longtitudemax(i, im));
                    MessageBox.Show(longti);
                    String latt= Convert.ToString(gps.lattitudemax(i, im));
                    MessageBox.Show(latt);
                    if (latt == "" || longti == "")
                    {
                        MessageBox.Show("des données ne sont pas compatibles");
                    }
                    else
                    {
                        addmarker(float.Parse(latt),float.Parse(longti));
                        gMapControl1.Zoom = 10;
                    }
                }
                catch (FormatException)
                {  
                    MessageBox.Show("Veuillez saisir des valeurs correctes");
                }

                }

            
            }

        
        private void remove_Click(object sender, EventArgs e)
        { 
            this.Hide();
            form2 x = new form2();
            x.Show();

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        }

        

        

       
        

        
        



        

        



    }

