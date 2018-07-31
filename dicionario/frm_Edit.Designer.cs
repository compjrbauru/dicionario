namespace dicionario
{
    partial class frm_Edit
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
            this.components = new System.ComponentModel.Container();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.textCultura = new System.Windows.Forms.TextBox();
            this.txtGramatica = new System.Windows.Forms.TextBox();
            this.txtAcepcao = new System.Windows.Forms.TextBox();
            this.ComboGenero = new System.Windows.Forms.ComboBox();
            this.ComboIdioma = new System.Windows.Forms.ComboBox();
            this.ComboCatGram = new System.Windows.Forms.ComboBox();
            this.comboFiltroIdiomas = new System.Windows.Forms.ComboBox();
            this.label_palavra = new System.Windows.Forms.Label();
            this.label_ref = new System.Windows.Forms.Label();
            this.label_cult = new System.Windows.Forms.Label();
            this.label_grammar = new System.Windows.Forms.Label();
            this.label_acep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_catgrama = new System.Windows.Forms.Label();
            this.txtEquiv = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ComboRubrica = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.menu_barra = new System.Windows.Forms.MenuStrip();
            this.acessoRápidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaGramaticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeGramaticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tip_Dicas = new System.Windows.Forms.ToolTip(this.components);
            this.numAcepcao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.timerCtg = new System.Windows.Forms.Timer(this.components);
            this.timerClg = new System.Windows.Forms.Timer(this.components);
            this.timerRub = new System.Windows.Forms.Timer(this.components);
            this.comboRef = new System.Windows.Forms.ComboBox();
            this.timerRef = new System.Windows.Forms.Timer(this.components);
            this.ComboFiltroPrecisao = new System.Windows.Forms.ComboBox();
            this.chkHeterossemantico = new System.Windows.Forms.CheckBox();
            this.chkHeterotonico = new System.Windows.Forms.CheckBox();
            this.chkHeterogenerico = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExemplo = new System.Windows.Forms.TextBox();
            this.txtExemploT = new System.Windows.Forms.TextBox();
            this.menu_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAcepcao)).BeginInit();
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
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(45, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(179, 26);
            this.searchBox.TabIndex = 13;
            this.searchBox.Text = "Buscar...";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(671, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 28);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Procurar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Lema",
            "Código"});
            this.filterComboBox.Location = new System.Drawing.Point(396, 58);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(110, 28);
            this.filterComboBox.TabIndex = 15;
            this.filterComboBox.Text = "Filtro";
            // 
            // txtpalavra
            // 
            this.txtpalavra.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtpalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalavra.Location = new System.Drawing.Point(45, 152);
            this.txtpalavra.Multiline = true;
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(248, 28);
            this.txtpalavra.TabIndex = 16;
            // 
            // textCultura
            // 
            this.textCultura.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.textCultura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textCultura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textCultura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCultura.Location = new System.Drawing.Point(45, 549);
            this.textCultura.Multiline = true;
            this.textCultura.Name = "textCultura";
            this.textCultura.Size = new System.Drawing.Size(385, 120);
            this.textCultura.TabIndex = 18;
            this.tip_Dicas.SetToolTip(this.textCultura, "Informe aqui quais as informações culturais envolvendo este lema");
            // 
            // txtGramatica
            // 
            this.txtGramatica.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtGramatica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGramatica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGramatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGramatica.Location = new System.Drawing.Point(436, 549);
            this.txtGramatica.Multiline = true;
            this.txtGramatica.Name = "txtGramatica";
            this.txtGramatica.Size = new System.Drawing.Size(375, 120);
            this.txtGramatica.TabIndex = 19;
            // 
            // txtAcepcao
            // 
            this.txtAcepcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcepcao.Location = new System.Drawing.Point(45, 204);
            this.txtAcepcao.Multiline = true;
            this.txtAcepcao.Name = "txtAcepcao";
            this.txtAcepcao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAcepcao.Size = new System.Drawing.Size(766, 107);
            this.txtAcepcao.TabIndex = 20;
            // 
            // ComboGenero
            // 
            this.ComboGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboGenero.FormattingEnabled = true;
            this.ComboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Neutro"});
            this.ComboGenero.Location = new System.Drawing.Point(652, 152);
            this.ComboGenero.Name = "ComboGenero";
            this.ComboGenero.Size = new System.Drawing.Size(159, 28);
            this.ComboGenero.TabIndex = 21;
            this.ComboGenero.SelectedIndexChanged += new System.EventHandler(this.ComboClasseGram_SelectedIndexChanged);
            this.ComboGenero.TextUpdate += new System.EventHandler(this.ComboClasseGram_TextUpdate);
            // 
            // ComboIdioma
            // 
            this.ComboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboIdioma.FormattingEnabled = true;
            this.ComboIdioma.Items.AddRange(new object[] {
            "Português",
            "Espanhol",
            "Inglês"});
            this.ComboIdioma.Location = new System.Drawing.Point(344, 152);
            this.ComboIdioma.Name = "ComboIdioma";
            this.ComboIdioma.Size = new System.Drawing.Size(137, 28);
            this.ComboIdioma.TabIndex = 22;
            // 
            // ComboCatGram
            // 
            this.ComboCatGram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboCatGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCatGram.FormattingEnabled = true;
            this.ComboCatGram.Location = new System.Drawing.Point(487, 152);
            this.ComboCatGram.Name = "ComboCatGram";
            this.ComboCatGram.Size = new System.Drawing.Size(159, 28);
            this.ComboCatGram.TabIndex = 23;
            this.ComboCatGram.SelectedIndexChanged += new System.EventHandler(this.ComboCatGram_SelectedIndexChanged);
            this.ComboCatGram.TextUpdate += new System.EventHandler(this.ComboCatGram_TextUpdate);
            // 
            // comboFiltroIdiomas
            // 
            this.comboFiltroIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltroIdiomas.FormattingEnabled = true;
            this.comboFiltroIdiomas.Items.AddRange(new object[] {
            "Qualquer",
            "BR",
            "EN",
            "ES"});
            this.comboFiltroIdiomas.Location = new System.Drawing.Point(251, 58);
            this.comboFiltroIdiomas.Name = "comboFiltroIdiomas";
            this.comboFiltroIdiomas.Size = new System.Drawing.Size(110, 28);
            this.comboFiltroIdiomas.TabIndex = 25;
            this.comboFiltroIdiomas.Text = "Idiomas";
            // 
            // label_palavra
            // 
            this.label_palavra.AutoSize = true;
            this.label_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_palavra.Location = new System.Drawing.Point(42, 131);
            this.label_palavra.Name = "label_palavra";
            this.label_palavra.Size = new System.Drawing.Size(45, 18);
            this.label_palavra.TabIndex = 26;
            this.label_palavra.Text = "Lema";
            // 
            // label_ref
            // 
            this.label_ref.AutoSize = true;
            this.label_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_ref.Location = new System.Drawing.Point(42, 378);
            this.label_ref.Name = "label_ref";
            this.label_ref.Size = new System.Drawing.Size(79, 18);
            this.label_ref.TabIndex = 27;
            this.label_ref.Text = "Referência";
            // 
            // label_cult
            // 
            this.label_cult.AutoSize = true;
            this.label_cult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_cult.Location = new System.Drawing.Point(42, 528);
            this.label_cult.Name = "label_cult";
            this.label_cult.Size = new System.Drawing.Size(110, 18);
            this.label_cult.TabIndex = 28;
            this.label_cult.Text = "Notas Culturais";
            // 
            // label_grammar
            // 
            this.label_grammar.AutoSize = true;
            this.label_grammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_grammar.Location = new System.Drawing.Point(433, 528);
            this.label_grammar.Name = "label_grammar";
            this.label_grammar.Size = new System.Drawing.Size(132, 18);
            this.label_grammar.TabIndex = 29;
            this.label_grammar.Text = "Notas Gramaticais";
            // 
            // label_acep
            // 
            this.label_acep.AutoSize = true;
            this.label_acep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_acep.Location = new System.Drawing.Point(42, 183);
            this.label_acep.Name = "label_acep";
            this.label_acep.Size = new System.Drawing.Size(70, 18);
            this.label_acep.TabIndex = 30;
            this.label_acep.Text = "Definição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(42, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Equivalente";
            // 
            // label_catgrama
            // 
            this.label_catgrama.AutoSize = true;
            this.label_catgrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_catgrama.Location = new System.Drawing.Point(484, 131);
            this.label_catgrama.Name = "label_catgrama";
            this.label_catgrama.Size = new System.Drawing.Size(148, 18);
            this.label_catgrama.TabIndex = 34;
            this.label_catgrama.Text = "Categoria Gramatical";
            // 
            // txtEquiv
            // 
            this.txtEquiv.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtEquiv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEquiv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEquiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquiv.Location = new System.Drawing.Point(45, 341);
            this.txtEquiv.Multiline = true;
            this.txtEquiv.Name = "txtEquiv";
            this.txtEquiv.Size = new System.Drawing.Size(179, 28);
            this.txtEquiv.TabIndex = 37;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblGenero.Location = new System.Drawing.Point(649, 131);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(58, 18);
            this.lblGenero.TabIndex = 38;
            this.lblGenero.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(341, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Idioma";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(868, 202);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 40;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ComboRubrica
            // 
            this.ComboRubrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboRubrica.FormattingEnabled = true;
            this.ComboRubrica.Location = new System.Drawing.Point(436, 400);
            this.ComboRubrica.Name = "ComboRubrica";
            this.ComboRubrica.Size = new System.Drawing.Size(179, 28);
            this.ComboRubrica.TabIndex = 41;
            this.ComboRubrica.SelectedIndexChanged += new System.EventHandler(this.ComboRubrica_SelectedIndexChanged);
            this.ComboRubrica.TextUpdate += new System.EventHandler(this.ComboRubrica_TextUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Rubrica";
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(868, 238);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 33);
            this.btnSalva.TabIndex = 43;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApaga.Location = new System.Drawing.Point(868, 277);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(75, 32);
            this.btnApaga.TabIndex = 44;
            this.btnApaga.Text = "Excluir";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // menu_barra
            // 
            this.menu_barra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoRápidoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menu_barra.Location = new System.Drawing.Point(0, 0);
            this.menu_barra.Name = "menu_barra";
            this.menu_barra.Size = new System.Drawing.Size(1008, 29);
            this.menu_barra.TabIndex = 46;
            this.menu_barra.Text = "menuStrip1";
            // 
            // acessoRápidoToolStripMenuItem
            // 
            this.acessoRápidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaGramaticalToolStripMenuItem,
            this.classeGramaticalToolStripMenuItem,
            this.rubricaToolStripMenuItem,
            this.referênciasToolStripMenuItem,
            this.toolStripSeparator1,
            this.importarToolStripMenuItem});
            this.acessoRápidoToolStripMenuItem.Name = "acessoRápidoToolStripMenuItem";
            this.acessoRápidoToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.acessoRápidoToolStripMenuItem.Text = "Acesso Rápido";
            // 
            // categoriaGramaticalToolStripMenuItem
            // 
            this.categoriaGramaticalToolStripMenuItem.Name = "categoriaGramaticalToolStripMenuItem";
            this.categoriaGramaticalToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.categoriaGramaticalToolStripMenuItem.Text = "Categoria Gramatical";
            this.categoriaGramaticalToolStripMenuItem.Click += new System.EventHandler(this.categoriaGramaticalToolStripMenuItem_Click);
            // 
            // classeGramaticalToolStripMenuItem
            // 
            this.classeGramaticalToolStripMenuItem.Name = "classeGramaticalToolStripMenuItem";
            this.classeGramaticalToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.classeGramaticalToolStripMenuItem.Text = "Classe Gramatical";
            this.classeGramaticalToolStripMenuItem.Click += new System.EventHandler(this.classeGramaticalToolStripMenuItem_Click);
            // 
            // rubricaToolStripMenuItem
            // 
            this.rubricaToolStripMenuItem.Name = "rubricaToolStripMenuItem";
            this.rubricaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.rubricaToolStripMenuItem.Text = "Rubrica";
            this.rubricaToolStripMenuItem.Click += new System.EventHandler(this.rubricaToolStripMenuItem_Click);
            // 
            // referênciasToolStripMenuItem
            // 
            this.referênciasToolStripMenuItem.Name = "referênciasToolStripMenuItem";
            this.referênciasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.referênciasToolStripMenuItem.Text = "Referências";
            this.referênciasToolStripMenuItem.Click += new System.EventHandler(this.referênciasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.importarToolStripMenuItem.Text = "Importar...";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // numAcepcao
            // 
            this.numAcepcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAcepcao.Location = new System.Drawing.Point(299, 154);
            this.numAcepcao.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numAcepcao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAcepcao.Name = "numAcepcao";
            this.numAcepcao.Size = new System.Drawing.Size(39, 26);
            this.numAcepcao.TabIndex = 47;
            this.numAcepcao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nº Ac.";
            // 
            // timerCtg
            // 
            this.timerCtg.Interval = 700;
            this.timerCtg.Tick += new System.EventHandler(this.timerCtg_Tick);
            // 
            // timerClg
            // 
            this.timerClg.Interval = 700;
            this.timerClg.Tick += new System.EventHandler(this.timerClg_Tick);
            // 
            // timerRub
            // 
            this.timerRub.Interval = 700;
            this.timerRub.Tick += new System.EventHandler(this.timerRub_Tick);
            // 
            // comboRef
            // 
            this.comboRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRef.FormattingEnabled = true;
            this.comboRef.Location = new System.Drawing.Point(45, 400);
            this.comboRef.Name = "comboRef";
            this.comboRef.Size = new System.Drawing.Size(385, 28);
            this.comboRef.TabIndex = 49;
            this.comboRef.SelectedIndexChanged += new System.EventHandler(this.comboRef_SelectedIndexChanged);
            this.comboRef.TextUpdate += new System.EventHandler(this.comboRef_TextUpdate);
            // 
            // timerRef
            // 
            this.timerRef.Interval = 700;
            this.timerRef.Tick += new System.EventHandler(this.timerRef_Tick);
            // 
            // ComboFiltroPrecisao
            // 
            this.ComboFiltroPrecisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFiltroPrecisao.FormattingEnabled = true;
            this.ComboFiltroPrecisao.Items.AddRange(new object[] {
            "Exatamente",
            "Contém"});
            this.ComboFiltroPrecisao.Location = new System.Drawing.Point(530, 58);
            this.ComboFiltroPrecisao.Name = "ComboFiltroPrecisao";
            this.ComboFiltroPrecisao.Size = new System.Drawing.Size(121, 28);
            this.ComboFiltroPrecisao.TabIndex = 50;
            this.ComboFiltroPrecisao.Text = "Precisão";
            // 
            // chkHeterossemantico
            // 
            this.chkHeterossemantico.AutoSize = true;
            this.chkHeterossemantico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeterossemantico.Location = new System.Drawing.Point(521, 343);
            this.chkHeterossemantico.Name = "chkHeterossemantico";
            this.chkHeterossemantico.Size = new System.Drawing.Size(158, 24);
            this.chkHeterossemantico.TabIndex = 51;
            this.chkHeterossemantico.Text = "Heterossemântico";
            this.chkHeterossemantico.UseVisualStyleBackColor = true;
            // 
            // chkHeterotonico
            // 
            this.chkHeterotonico.AutoSize = true;
            this.chkHeterotonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeterotonico.Location = new System.Drawing.Point(395, 343);
            this.chkHeterotonico.Name = "chkHeterotonico";
            this.chkHeterotonico.Size = new System.Drawing.Size(120, 24);
            this.chkHeterotonico.TabIndex = 52;
            this.chkHeterotonico.Text = "Heterotônico";
            this.chkHeterotonico.UseVisualStyleBackColor = true;
            // 
            // chkHeterogenerico
            // 
            this.chkHeterogenerico.AutoSize = true;
            this.chkHeterogenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeterogenerico.Location = new System.Drawing.Point(251, 343);
            this.chkHeterogenerico.Name = "chkHeterogenerico";
            this.chkHeterogenerico.Size = new System.Drawing.Size(138, 24);
            this.chkHeterogenerico.TabIndex = 53;
            this.chkHeterogenerico.Text = "Heterogenérico";
            this.chkHeterogenerico.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Exemplo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Exemplo traduzido";
            // 
            // txtExemplo
            // 
            this.txtExemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemplo.Location = new System.Drawing.Point(45, 481);
            this.txtExemplo.Name = "txtExemplo";
            this.txtExemplo.Size = new System.Drawing.Size(385, 26);
            this.txtExemplo.TabIndex = 56;
            // 
            // txtExemploT
            // 
            this.txtExemploT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemploT.Location = new System.Drawing.Point(439, 481);
            this.txtExemploT.Name = "txtExemploT";
            this.txtExemploT.Size = new System.Drawing.Size(372, 26);
            this.txtExemploT.TabIndex = 57;
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.txtExemploT);
            this.Controls.Add(this.txtExemplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHeterogenerico);
            this.Controls.Add(this.chkHeterotonico);
            this.Controls.Add(this.chkHeterossemantico);
            this.Controls.Add(this.ComboFiltroPrecisao);
            this.Controls.Add(this.comboRef);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numAcepcao);
            this.Controls.Add(this.menu_barra);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboRubrica);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtEquiv);
            this.Controls.Add(this.label_catgrama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_acep);
            this.Controls.Add(this.label_grammar);
            this.Controls.Add(this.label_cult);
            this.Controls.Add(this.label_ref);
            this.Controls.Add(this.label_palavra);
            this.Controls.Add(this.comboFiltroIdiomas);
            this.Controls.Add(this.ComboCatGram);
            this.Controls.Add(this.ComboIdioma);
            this.Controls.Add(this.ComboGenero);
            this.Controls.Add(this.txtAcepcao);
            this.Controls.Add(this.txtGramatica);
            this.Controls.Add(this.textCultura);
            this.Controls.Add(this.txtpalavra);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.MainMenuStrip = this.menu_barra;
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "frm_Edit";
            this.Text = "Edição de entradas";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.menu_barra.ResumeLayout(false);
            this.menu_barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAcepcao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.TextBox textCultura;
        private System.Windows.Forms.TextBox txtGramatica;
        private System.Windows.Forms.TextBox txtAcepcao;
        private System.Windows.Forms.ComboBox ComboGenero;
        private System.Windows.Forms.ComboBox ComboIdioma;
        private System.Windows.Forms.ComboBox ComboCatGram;
        private System.Windows.Forms.ComboBox comboFiltroIdiomas;
        private System.Windows.Forms.Label label_palavra;
        private System.Windows.Forms.Label label_ref;
        private System.Windows.Forms.Label label_cult;
        private System.Windows.Forms.Label label_grammar;
        private System.Windows.Forms.Label label_acep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_catgrama;
        private System.Windows.Forms.TextBox txtEquiv;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox ComboRubrica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.MenuStrip menu_barra;
        private System.Windows.Forms.ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaGramaticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeGramaticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolTip tip_Dicas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numAcepcao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerCtg;
        private System.Windows.Forms.Timer timerClg;
        private System.Windows.Forms.Timer timerRub;
        private System.Windows.Forms.ComboBox comboRef;
        private System.Windows.Forms.Timer timerRef;
        private System.Windows.Forms.ComboBox ComboFiltroPrecisao;
        private System.Windows.Forms.CheckBox chkHeterossemantico;
        private System.Windows.Forms.CheckBox chkHeterotonico;
        private System.Windows.Forms.CheckBox chkHeterogenerico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExemplo;
        private System.Windows.Forms.TextBox txtExemploT;
    }
}