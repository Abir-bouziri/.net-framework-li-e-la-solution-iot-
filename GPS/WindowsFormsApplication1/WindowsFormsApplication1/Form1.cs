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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxEdit1.Text = "--Select--";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string utilisateur = textBox2.Text;
            string mot_passe = textBox1.Text;
           // MessageBox.Show(utilisateur);
           // MessageBox.Show(mot_passe);
            atooerp_userTableAdapter pass = new atooerp_userTableAdapter();
            String pwd = Convert.ToString(pass.password(utilisateur));
           // MessageBox.Show(pwd);
            if (utilisateur== "" && mot_passe == "")
            { MessageBox.Show("veuillez insérer  vos données"); }
            else if (utilisateur == "" && mot_passe !="")
            { MessageBox.Show("veuillez insérer  votre nom "); }
            else if (utilisateur!= "" && mot_passe == "")
            { MessageBox.Show("veuillez insérer  votre mot de passe"); }
            else{
                atooerp_userTableAdapter post = new atooerp_userTableAdapter();

            if (mot_passe == pwd)
            { 
                 if (comboBoxEdit1.Text == "Responsable maintenance")
                 {
                         this.Hide();
                         form2 x = new form2();
                         x.Show();
                 }
                 else if (comboBoxEdit1.Text == "Administrateur")
                 {

                     if (post.vérifposition(mot_passe) == "administrateur")
                     {
                         Form3 x = new Form3();
                         this.Hide();
                         x.Show();
                     }
                     else
                     { MessageBox.Show("Veuillez vérifier votre poste"); }
                 }
                 else
                 { MessageBox.Show("veuillez saisir votre poste"); }
            }

            else
            {
               if(pass.count(utilisateur)==0)
                { MessageBox.Show("Utilisateur n'existe pas"); }
               else
               {
                   MessageBox.Show("Mot de passe est incorrect");
               }
            }
            
        }
        }
        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
       
    }
}
