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
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.DataSet1TableAdapters;
using administrateur;
namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
       
        public Form4()
        { //initialisation à GMAP
            InitializeComponent();
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(35.035439, 9.483939);
            gMapControl1.ShowCenter = false;
        }
        //Ajouter une position marquées:
        private void addmarker(float latt, float longti, string a)
        { 
            gMapControl1.Position = new GMap.NET.PointLatLng(latt, longti);
            gMapControl1.ShowCenter = false;
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            //marker une position 
            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle
                   (new GMap.NET.PointLatLng(latt, longti), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
            gMapControl1.Zoom = 10;
            if (a != "a")
            {
                marker.ToolTipText = a;
                gMapControl1.Zoom = 15;
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                marker.ToolTipMode = MarkerTooltipMode.Always;
            }


        }
        //afficher des données voulues:
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=gps_db;uid=root;pwd=''";
            cnn = new MySqlConnection(connetionString);


            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
               // string req1 = "SELECT * FROM `gps` where gps_time=(select max(gps_time) from gps where `gps_date`=(SELECT max(gps_date) from gps ))";
               // string req1 = "select id,id_véhicule,immatricule,lattitude,longtitude,max(gps_time),max(gps_date) from gps group by immatricule";
             //  string req1="select id,id_véhicule,immatricule,lattitude,longtitude,max(gps_time),gps_date from gps where gps_date=@date group by immatricule";
               string req1="select id,id_véhicule,immatricule,lattitude,longtitude,max(gps_time),gps_date from gps where gps_date=CURRENT_DATE group by immatricule";
                MySqlCommand cmd1 = new MySqlCommand(req1, cnn);
                //cmd1.Parameters.AddWithValue("date",);
                var reader = cmd1.ExecuteReader();
                while (reader.Read())
                {

                    var latt = float.Parse(reader.GetString(3));
                    var longti = float.Parse(reader.GetString(4));
                    var id_véhicule = reader.GetString(1);
                    var im = reader.GetString(2);
                    var time = reader.GetString(5);
                    var date=reader.GetString(6);
                    string détails = "Idvéhicule :" + id_véhicule + "\n" + "Immatricule:" + im + "\n" +"Time:"+time +"\n"+"Date"+date;
                    addmarker(latt, longti, détails);
                    gMapControl1.Zoom = 5;


                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed ! "+ex);
            }
        }
        // button revenez
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }
        //button quitter (Déconnexion):
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
        // détermier les positions de chaque véhicules en court;
        private void button3_Click(object sender, EventArgs e)
        {
           this.Hide();
            Form4 f = new Form4();
            f.Show();


         
        }

        
    }
}
