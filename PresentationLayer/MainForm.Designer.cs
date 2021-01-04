namespace PresentationLayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabCities = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxLon = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFavorites = new System.Windows.Forms.TabPage();
            this.dataGridViewFavorites = new System.Windows.Forms.DataGridView();
            this.favorite_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favorite_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favorite_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favorite_lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favorite_lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage.SuspendLayout();
            this.tabCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.tabFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabCities);
            this.tabPage.Controls.Add(this.tabFavorites);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Multiline = true;
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(800, 450);
            this.tabPage.TabIndex = 0;
            // 
            // tabCities
            // 
            this.tabCities.Controls.Add(this.buttonSearch);
            this.tabCities.Controls.Add(this.textBoxLat);
            this.tabCities.Controls.Add(this.labelCountry);
            this.tabCities.Controls.Add(this.textBoxLon);
            this.tabCities.Controls.Add(this.textBoxCountry);
            this.tabCities.Controls.Add(this.textBoxCity);
            this.tabCities.Controls.Add(this.labelLat);
            this.tabCities.Controls.Add(this.labelLon);
            this.tabCities.Controls.Add(this.labelCity);
            this.tabCities.Controls.Add(this.numericUpDownId);
            this.tabCities.Controls.Add(this.labelId);
            this.tabCities.Controls.Add(this.dataGridViewCities);
            this.tabCities.Location = new System.Drawing.Point(4, 22);
            this.tabCities.Name = "tabCities";
            this.tabCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabCities.Size = new System.Drawing.Size(792, 424);
            this.tabCities.TabIndex = 0;
            this.tabCities.Text = "Cities";
            this.tabCities.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(615, 252);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(86, 34);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(653, 226);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(100, 20);
            this.textBoxLat.TabIndex = 21;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(561, 174);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(82, 24);
            this.labelCountry.TabIndex = 15;
            this.labelCountry.Text = "Country";
            // 
            // textBoxLon
            // 
            this.textBoxLon.Location = new System.Drawing.Point(653, 202);
            this.textBoxLon.Name = "textBoxLon";
            this.textBoxLon.Size = new System.Drawing.Size(100, 20);
            this.textBoxLon.TabIndex = 20;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(653, 178);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 19;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(653, 152);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 18;
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLat.Location = new System.Drawing.Point(561, 222);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(37, 24);
            this.labelLat.TabIndex = 17;
            this.labelLat.Text = "Lat";
            // 
            // labelLon
            // 
            this.labelLon.AutoSize = true;
            this.labelLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLon.Location = new System.Drawing.Point(561, 198);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(45, 24);
            this.labelLon.TabIndex = 16;
            this.labelLon.Text = "Lon";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(561, 150);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(44, 24);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.AutoSize = true;
            this.numericUpDownId.Location = new System.Drawing.Point(653, 126);
            this.numericUpDownId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownId.TabIndex = 13;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(561, 126);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 24);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "ID";
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.city,
            this.country,
            this.lon,
            this.lat});
            this.dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewCities.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.Size = new System.Drawing.Size(540, 418);
            this.dataGridViewCities.TabIndex = 0;
            this.dataGridViewCities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCities_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // city
            // 
            this.city.DataPropertyName = "cityName";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // country
            // 
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            // 
            // lon
            // 
            this.lon.DataPropertyName = "lon";
            this.lon.HeaderText = "Lon";
            this.lon.Name = "lon";
            // 
            // lat
            // 
            this.lat.DataPropertyName = "lat";
            this.lat.HeaderText = "Lat";
            this.lat.Name = "lat";
            // 
            // tabFavorites
            // 
            this.tabFavorites.Controls.Add(this.dataGridViewFavorites);
            this.tabFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabFavorites.Name = "tabFavorites";
            this.tabFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.tabFavorites.Size = new System.Drawing.Size(792, 424);
            this.tabFavorites.TabIndex = 1;
            this.tabFavorites.Text = "Favorites";
            this.tabFavorites.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFavorites
            // 
            this.dataGridViewFavorites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavorites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.favorite_id,
            this.favorite_city,
            this.favorite_country,
            this.favorite_lon,
            this.favorite_lat});
            this.dataGridViewFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFavorites.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFavorites.Name = "dataGridViewFavorites";
            this.dataGridViewFavorites.Size = new System.Drawing.Size(786, 418);
            this.dataGridViewFavorites.TabIndex = 0;
            this.dataGridViewFavorites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFavorites_CellContentClick);
            // 
            // favorite_id
            // 
            this.favorite_id.DataPropertyName = "id";
            this.favorite_id.HeaderText = "Id";
            this.favorite_id.Name = "favorite_id";
            // 
            // favorite_city
            // 
            this.favorite_city.DataPropertyName = "cityName";
            this.favorite_city.HeaderText = "City";
            this.favorite_city.Name = "favorite_city";
            // 
            // favorite_country
            // 
            this.favorite_country.DataPropertyName = "country";
            this.favorite_country.HeaderText = "Country";
            this.favorite_country.Name = "favorite_country";
            // 
            // favorite_lon
            // 
            this.favorite_lon.DataPropertyName = "lon";
            this.favorite_lon.HeaderText = "Lon";
            this.favorite_lon.Name = "favorite_lon";
            // 
            // favorite_lat
            // 
            this.favorite_lat.DataPropertyName = "lat";
            this.favorite_lat.HeaderText = "Lat";
            this.favorite_lat.Name = "favorite_lat";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage.ResumeLayout(false);
            this.tabCities.ResumeLayout(false);
            this.tabCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.tabFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabCities;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.TabPage tabFavorites;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxLon;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLon;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataGridViewFavorites;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn favorite_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn favorite_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn favorite_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn favorite_lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn favorite_lat;
    }
}

