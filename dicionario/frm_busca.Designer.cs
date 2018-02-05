namespace dicionario
{
    partial class frm_busca
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.contactButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.editModeButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.extraFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.extraComboBox1 = new System.Windows.Forms.ComboBox();
            this.extraComboBox2 = new System.Windows.Forms.ComboBox();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic People\'s Republic of Korea (North Korea)",
            "Democratic Republic of the Cong",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic (Laos)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia (Federated States of)",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Korea (South Korea)",
            "Republic of Moldova",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom of Great Britain and Northern Ireland",
            "United Republic of Tanzania",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(45, 131);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(198, 26);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchLabel.Location = new System.Drawing.Point(45, 89);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(79, 29);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Busca";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(476, 130);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Procurar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 17;
            this.searchResultsListBox.Location = new System.Drawing.Point(44, 271);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(541, 72);
            this.searchResultsListBox.TabIndex = 3;
            this.searchResultsListBox.SelectedIndexChanged += new System.EventHandler(this.searchResultsListBox_SelectedIndexChanged);
            // 
            // contactButton
            // 
            this.contactButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactButton.Location = new System.Drawing.Point(126, 38);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(75, 30);
            this.contactButton.TabIndex = 5;
            this.contactButton.Text = "Contato";
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(208, 38);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 30);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "Ajuda";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // editModeButton
            // 
            this.editModeButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editModeButton.Location = new System.Drawing.Point(510, 38);
            this.editModeButton.Name = "editModeButton";
            this.editModeButton.Size = new System.Drawing.Size(75, 30);
            this.editModeButton.TabIndex = 7;
            this.editModeButton.Text = "Edição";
            this.editModeButton.UseVisualStyleBackColor = true;
            this.editModeButton.Click += new System.EventHandler(this.editModeButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(45, 38);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 30);
            this.homeButton.TabIndex = 8;
            this.homeButton.Text = "Busca";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Exatamente",
            "Contém na entrada",
            "Anagrama",
            "Contém no conteúdo",
            "Exemplo",
            "Heterogenérico",
            "Heterotônico"});
            this.filterComboBox.Location = new System.Drawing.Point(249, 131);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(153, 26);
            this.filterComboBox.TabIndex = 16;
            this.filterComboBox.Text = "Filtros";
            // 
            // extraFilterCheckBox
            // 
            this.extraFilterCheckBox.AutoSize = true;
            this.extraFilterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extraFilterCheckBox.Location = new System.Drawing.Point(45, 164);
            this.extraFilterCheckBox.Name = "extraFilterCheckBox";
            this.extraFilterCheckBox.Size = new System.Drawing.Size(107, 21);
            this.extraFilterCheckBox.TabIndex = 17;
            this.extraFilterCheckBox.Text = "Filtros extras";
            this.extraFilterCheckBox.UseVisualStyleBackColor = true;
            this.extraFilterCheckBox.CheckedChanged += new System.EventHandler(this.extraFilterCheckBox_CheckedChanged);
            // 
            // extraComboBox1
            // 
            this.extraComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraComboBox1.FormattingEnabled = true;
            this.extraComboBox1.Location = new System.Drawing.Point(249, 164);
            this.extraComboBox1.Name = "extraComboBox1";
            this.extraComboBox1.Size = new System.Drawing.Size(153, 24);
            this.extraComboBox1.TabIndex = 18;
            // 
            // extraComboBox2
            // 
            this.extraComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraComboBox2.FormattingEnabled = true;
            this.extraComboBox2.Location = new System.Drawing.Point(249, 191);
            this.extraComboBox2.Name = "extraComboBox2";
            this.extraComboBox2.Size = new System.Drawing.Size(153, 24);
            this.extraComboBox2.TabIndex = 19;
            // 
            // ConfigButton
            // 
            this.ConfigButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigButton.Location = new System.Drawing.Point(289, 38);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(100, 30);
            this.ConfigButton.TabIndex = 20;
            this.ConfigButton.Text = "Configuração";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // frm_busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.extraComboBox2);
            this.Controls.Add(this.extraComboBox1);
            this.Controls.Add(this.extraFilterCheckBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.editModeButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.contactButton);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Name = "frm_busca";
            this.Text = "Dicionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button editModeButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.CheckBox extraFilterCheckBox;
        private System.Windows.Forms.ComboBox extraComboBox1;
        private System.Windows.Forms.ComboBox extraComboBox2;
        private System.Windows.Forms.Button ConfigButton;
    }
}

