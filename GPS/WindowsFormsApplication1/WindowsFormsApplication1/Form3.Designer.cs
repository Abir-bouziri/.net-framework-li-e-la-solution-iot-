namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.véhicule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.immatricule = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Déconnexion = new System.Windows.Forms.Button();
            this.trajet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(431, 529);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 7D;
            // 
            // véhicule
            // 
            this.véhicule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.véhicule.Location = new System.Drawing.Point(461, 67);
            this.véhicule.Name = "véhicule";
            this.véhicule.Size = new System.Drawing.Size(191, 20);
            this.véhicule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "id véhicule:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Immatricule:";
            // 
            // immatricule
            // 
            this.immatricule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.immatricule.Location = new System.Drawing.Point(461, 156);
            this.immatricule.Name = "immatricule";
            this.immatricule.Size = new System.Drawing.Size(191, 20);
            this.immatricule.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date:";
            // 
            // Déconnexion
            // 
            this.Déconnexion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Déconnexion.Location = new System.Drawing.Point(461, 464);
            this.Déconnexion.Name = "Déconnexion";
            this.Déconnexion.Size = new System.Drawing.Size(192, 33);
            this.Déconnexion.TabIndex = 7;
            this.Déconnexion.Text = "Déconnexion";
            this.Déconnexion.UseVisualStyleBackColor = true;
            this.Déconnexion.Click += new System.EventHandler(this.Déconnexion_Click);
            // 
            // trajet
            // 
            this.trajet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trajet.Location = new System.Drawing.Point(461, 308);
            this.trajet.Name = "trajet";
            this.trajet.Size = new System.Drawing.Size(190, 33);
            this.trajet.TabIndex = 8;
            this.trajet.Text = "Déterminer le trajet";
            this.trajet.UseVisualStyleBackColor = true;
            this.trajet.Click += new System.EventHandler(this.trajet_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(461, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Détermiener sa position actuelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // supprimer
            // 
            this.supprimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.supprimer.Location = new System.Drawing.Point(461, 425);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(192, 33);
            this.supprimer.TabIndex = 10;
            this.supprimer.Text = "Supprimer le trajet du basse ";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(461, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Supprimer le trajet du map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trajet);
            this.Controls.Add(this.Déconnexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.immatricule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.véhicule);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form3";
            this.Text = "Form3";
           this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox véhicule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox immatricule;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Déconnexion;
        private System.Windows.Forms.Button trajet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button button1;


    }
}