using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.DataSet1TableAdapters;
using administrateur;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(35.035439, 9.483939);
            gMapControl1.ShowCenter = false;
        }
       
        private void addmarker(float latt, float longti,string a)
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
            { marker.ToolTipText = a;
            gMapControl1.Zoom = 15;
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            }
          
            
        }
        
         private void addmarkermax(string id,string im,string date1, string a )
        {
            gpsTableAdapter t1 = new gpsTableAdapter();
            string lattmax = Convert.ToString(t1.lattitudeselectdaymax(Convert.ToDecimal(id), im, Convert.ToDateTime(date1)));
            string longmax = Convert.ToString(t1.longtitudeselectdaymax(Convert.ToDecimal(id), im, Convert.ToDateTime(date1)));
        
           addmarker(float.Parse(lattmax),float.Parse(longmax),a);
           
        }
        private void addmarkermin(string id, string im,string date1,string b)
         {

             gpsTableAdapter t1 = new gpsTableAdapter();
             string lattmin = Convert.ToString(t1.lattitudeminselectday(Convert.ToDecimal(id), im, Convert.ToDateTime(date1)));
             string longmin = Convert.ToString(t1.longtitudeminselectday(Convert.ToDecimal(id), im, Convert.ToDateTime(date1)));
             addmarker(float.Parse(lattmin), float.Parse(longmin), b);
             /*gMapControl1.Position = new GMap.NET.PointLatLng(float.Parse(lattmin), float.Parse(longmin));
             gMapControl1.ShowCenter = false;
             GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
             //marker une position 
             GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle
                    (new GMap.NET.PointLatLng(float.Parse(lattmin), float.Parse(longmin)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
             markers.Markers.Add(marker);
             gMapControl1.Overlays.Add(markers);
             marker.ToolTipText = "Début du tajet";
             gMapControl1.Zoom = 15;
             marker.ToolTip.Fill = Brushes.Black;
             marker.ToolTip.Foreground = Brushes.White;
             marker.ToolTip.Stroke = Pens.Black;
             marker.ToolTip.TextPadding = new Size(20, 20);
             marker.ToolTipMode = MarkerTooltipMode.Always;*/
         }
     /*   private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(35.035439, 9.483939);
            gMapControl1.ShowCenter = false;
        }*/

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }

        private void trajet_Click(object sender, EventArgs e)
        {

            
            string id=véhicule.Text;
            string im=immatricule.Text;
            string date=dateTimePicker1.Text;
            MessageBox.Show(date);
            admi ad = new admi();
            string[] a = ad.split(date);
            string date1 = a[3] + '-' + ad.month(a[2]) + '-' + a[1];
            MessageBox.Show(date1);



            Form5 f = new Form5();
            f.id_matricule=im;
            f.id_véhicule=id;
            f.date=date1;
            







            string begin = "Fin trajet";
            string end = "Début trajet";
            string middle = "a";
            if (id == "" && im == "")
            { MessageBox.Show("veuillez insérer  vos données"); }
            else if (id == "" && im != "")
            { MessageBox.Show("veuillez insérer  votre id de véhicule"); }
            else if (id != "" && im == "")
            { MessageBox.Show("veuillez insérer  votre immatricule"); }
            else {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=gps_db;uid=root;pwd=''";
            cnn = new MySqlConnection(connetionString);
         //   try { 
            cnn.Open();
                MessageBox.Show("Connection Open ! ");
                string req1 = "select * from gps where immatricule="+"'"+im+"'"+" and id_véhicule="+id+" and gps_date="+"'"+date1+"'";
                MessageBox.Show(req1);
                MySqlCommand cmd1 = new MySqlCommand(req1, cnn);
                var reader = cmd1.ExecuteReader();
                gpsTableAdapter t1 = new gpsTableAdapter();
                int i = Convert.ToInt32(t1.countadmin(im,Convert.ToDecimal(id),Convert.ToDateTime(date1)));
                MessageBox.Show("i");
                MessageBox.Show(Convert.ToString(i));
                if (i > 0)
                {
                   
                        while (reader.Read())
                        {
                            var latt = float.Parse(reader.GetString(3));
                            var longti = float.Parse(reader.GetString(4));
                            if (i == 1)
                            { addmarker(latt, longti, middle); }
                            else
                            {
                                addmarkermax(id, im, date1, end);

                                addmarker(latt, longti, middle);

                                addmarkermin(id, im, date1, begin);
                            }
                        }

                        f.Show();
                    
                  
                }                  
                else
                {
                    MessageBox.Show("data not found");
                    int j = Convert.ToInt32(t1.countid(Convert.ToDecimal(id)));
                    int k = Convert.ToInt32(t1.countim(im));
                    int l = Convert.ToInt32(t1.countimid(Convert.ToDecimal(id),im));
                    if (j>0 && k>0)
                    {
                       if (l>0)
                       {
                           MessageBox.Show("Véhicule hors functions ce jours là");
                       }
                       else
                       { 
                       MessageBox.Show("Id_véhicule et Immatricule ne sont pas compatibles");
                       }
                    }
                    else
                    {
                        if (k == 0 && j>0)
                        {
                            MessageBox.Show("immatricule n'existe pass");
                        }
                        else if (j == 0 && k>0)
                        {
                            MessageBox.Show("id_véhicule n'existe pass");
                        }
                        else
                        { MessageBox.Show("Ni id_véhicule ni immatricule existe"); }
                    }
                  
                }
        
  
               cnn.Close();

          /*}
           catch (Exception)
            {
                MessageBox.Show("Connection Failed ! ");
                MessageBox.Show("l'id est faux , incompatible format");
            }*/
           
            
            
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 x = new Form3();
            x.Show();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            string id=véhicule.Text;
            string im=immatricule.Text;
            string date=dateTimePicker1.Text;
            MessageBox.Show(date);
            admi ad = new admi();
            string[] a = ad.split(date);
            string date1 = a[3] + '-' + ad.month(a[2]) + '-' + a[1];
            MessageBox.Show(date1);
            if (id == "" && im == "")
            { MessageBox.Show("veuillez insérer  vos données"); }
            else if (id == "" && im != "")
            { MessageBox.Show("veuillez insérer  votre id de véhicule"); }
            else if (id != "" && im == "")
            { MessageBox.Show("veuillez insérer  votre immatricule"); }
            else {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=gps_db;uid=root;pwd=''";
            cnn = new MySqlConnection(connetionString);
            try { 
                  cnn.Open();
                MessageBox.Show("Connection Open ! ");
                string req1 = "Delete from gps where immatricule=" + "'" + im + "'" + " and id_véhicule=" + id + " and gps_date=" + "'" + date1 + "'";
                MessageBox.Show(req1);
                
                gpsTableAdapter t1 = new gpsTableAdapter();
                
                int i = Convert.ToInt32(t1.countadmin(im,Convert.ToDecimal(id),Convert.ToDateTime(date1)));
                MessageBox.Show("i");
                MessageBox.Show(Convert.ToString(i));
                if (i > 0)
                {
                    MySqlCommand cmd1 = new MySqlCommand(req1, cnn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Suppression avec succés");
                }                  
                else
                {
                    MessageBox.Show("data not found");
                    int j = Convert.ToInt32(t1.countid(Convert.ToDecimal(id)));
                    int k = Convert.ToInt32(t1.countim(im));
                    int l = Convert.ToInt32(t1.countimid(Convert.ToDecimal(id),im));
                    if (j>0 && k>0)
                    {
                       if (l>0)
                       {
                           MessageBox.Show("Véhicule hors functions ce jours là");
                       }
                       else
                       { 
                       MessageBox.Show("Id_véhicule et Immatricule ne sont pas compatibles");
                       }
                    }
                    else
                    {
                        if (k == 0 && j>0)
                        {
                            MessageBox.Show("immatricule n'existe pass");
                        }
                        else if (j == 0 && k>0)
                        {
                            MessageBox.Show("id_véhicule n'existe pass");
                        }
                        else
                        { MessageBox.Show("Ni id_véhicule ni immatricule existe"); }
                    }
                  
                }
        
  
               cnn.Close();

          }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed ! ");
                MessageBox.Show("l'id est faux , incompatible format");
            }}
}

        private void button2_Click(object sender, EventArgs e)
        {


         /*   string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=gps_db;uid=root;pwd=''";
            cnn = new MySqlConnection(connetionString);


           try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");


                string req1 = "SELECT * FROM `gps` where gps_time=(select max(gps_time) from gps where `gps_date`=(SELECT max(gps_date) from gps ))";
                MySqlCommand cmd1 = new MySqlCommand(req1, cnn);
                var reader = cmd1.ExecuteReader();
                while (reader.Read())
                {

                    var latt = float.Parse(reader.GetString(3));
                    var longti = float.Parse(reader.GetString(4));
                    var id_véhicule = reader.GetString(1);
                    var im = reader.GetString(2);
                    string détails = "Idvéhicule :" + id_véhicule + "\n" + "Immatricule:" + im;
                    addmarker(latt, longti,détails);
                    gMapControl1.Zoom = 5;
                    
                 
                }
                cnn.Close();
             }
           catch (Exception)
            {
                MessageBox.Show("Connection Failed ! ");
            }*/
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        
                   
        }
    }