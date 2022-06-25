namespace WindowsFormsApplication1
{
    partial class form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.position_maintenance = new System.Windows.Forms.Button();
            this.mécanicien = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id véhicule:";
            // 
            // position_maintenance
            // 
            this.position_maintenance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.position_maintenance.AutoSize = true;
            this.position_maintenance.Location = new System.Drawing.Point(458, 246);
            this.position_maintenance.Name = "position_maintenance";
            this.position_maintenance.Size = new System.Drawing.Size(195, 44);
            this.position_maintenance.TabIndex = 11;
            this.position_maintenance.Text = "Déterminer position";
            this.position_maintenance.UseVisualStyleBackColor = true;
            this.position_maintenance.Click += new System.EventHandler(this.position_maintenance_Click);
            // 
            // mécanicien
            // 
            this.mécanicien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mécanicien.AutoSize = true;
            this.mécanicien.Location = new System.Drawing.Point(458, 296);
            this.mécanicien.Name = "mécanicien";
            this.mécanicien.Size = new System.Drawing.Size(195, 44);
            this.mécanicien.TabIndex = 12;
            this.mécanicien.Text = "Les mécaniciens proches";
            this.mécanicien.UseVisualStyleBackColor = true;
            this.mécanicien.Click += new System.EventHandler(this.mécanicien_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(458, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxEdit1.Location = new System.Drawing.Point(458, 121);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "25"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(195, 20);
            this.comboBoxEdit1.TabIndex = 14;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxEdit2.Location = new System.Drawing.Point(458, 195);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "220_tunis_2013"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(195, 20);
            this.comboBoxEdit2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Immatricule:";
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remove.Location = new System.Drawing.Point(458, 346);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(195, 44);
            this.remove.TabIndex = 16;
            this.remove.Text = "Effacer les positions actuelles";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
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
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 5;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(431, 530);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 7D;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 528);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mécanicien);
            this.Controls.Add(this.position_maintenance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "form2";
            this.Text = "form2";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button position_maintenance;
        private System.Windows.Forms.Button mécanicien;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
       
     
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button remove;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        
    }
}