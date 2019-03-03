namespace Gabinett
{
    partial class Pacjenci
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.imieNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Gabinett.DatabaseDataSet();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtImieNazwisko = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPesel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumerTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAdres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnZapisz = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAnuluj = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdytuj = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDodaj = new MaterialSkin.Controls.MaterialFlatButton();
            this.pacjenciTableAdapter = new Gabinett.DatabaseDataSetTableAdapters.PacjenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieNazwiskoDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.numerTelefonuDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.pacjenciBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 253);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(779, 140);
            this.dataGridView.TabIndex = 3;
            // 
            // imieNazwiskoDataGridViewTextBoxColumn
            // 
            this.imieNazwiskoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imieNazwiskoDataGridViewTextBoxColumn.DataPropertyName = " Imie Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn.HeaderText = " Imie Nazwisko";
            this.imieNazwiskoDataGridViewTextBoxColumn.Name = "imieNazwiskoDataGridViewTextBoxColumn";
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            // 
            // numerTelefonuDataGridViewTextBoxColumn
            // 
            this.numerTelefonuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerTelefonuDataGridViewTextBoxColumn.DataPropertyName = "Numer Telefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.HeaderText = "Numer Telefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.Name = "numerTelefonuDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // pacjenciBindingSource
            // 
            this.pacjenciBindingSource.DataMember = "Pacjenci";
            this.pacjenciBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Imie Nazwisko";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Pesel";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 141);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Numer Telefonu";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 174);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Adres";
            // 
            // txtImieNazwisko
            // 
            this.txtImieNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, " Imie Nazwisko", true));
            this.txtImieNazwisko.Depth = 0;
            this.txtImieNazwisko.Hint = "";
            this.txtImieNazwisko.Location = new System.Drawing.Point(175, 75);
            this.txtImieNazwisko.MaxLength = 32767;
            this.txtImieNazwisko.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImieNazwisko.Name = "txtImieNazwisko";
            this.txtImieNazwisko.PasswordChar = '\0';
            this.txtImieNazwisko.SelectedText = "";
            this.txtImieNazwisko.SelectionLength = 0;
            this.txtImieNazwisko.SelectionStart = 0;
            this.txtImieNazwisko.Size = new System.Drawing.Size(310, 23);
            this.txtImieNazwisko.TabIndex = 0;
            this.txtImieNazwisko.TabStop = false;
            this.txtImieNazwisko.UseSystemPasswordChar = false;
            // 
            // txtPesel
            // 
            this.txtPesel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, "Pesel", true));
            this.txtPesel.Depth = 0;
            this.txtPesel.Hint = "";
            this.txtPesel.Location = new System.Drawing.Point(175, 104);
            this.txtPesel.MaxLength = 32767;
            this.txtPesel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.PasswordChar = '\0';
            this.txtPesel.SelectedText = "";
            this.txtPesel.SelectionLength = 0;
            this.txtPesel.SelectionStart = 0;
            this.txtPesel.Size = new System.Drawing.Size(310, 23);
            this.txtPesel.TabIndex = 1;
            this.txtPesel.TabStop = false;
            this.txtPesel.UseSystemPasswordChar = false;
            // 
            // txtNumerTel
            // 
            this.txtNumerTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, "Numer Telefonu", true));
            this.txtNumerTel.Depth = 0;
            this.txtNumerTel.Hint = "";
            this.txtNumerTel.Location = new System.Drawing.Point(175, 137);
            this.txtNumerTel.MaxLength = 32767;
            this.txtNumerTel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumerTel.Name = "txtNumerTel";
            this.txtNumerTel.PasswordChar = '\0';
            this.txtNumerTel.SelectedText = "";
            this.txtNumerTel.SelectionLength = 0;
            this.txtNumerTel.SelectionStart = 0;
            this.txtNumerTel.Size = new System.Drawing.Size(310, 23);
            this.txtNumerTel.TabIndex = 2;
            this.txtNumerTel.TabStop = false;
            this.txtNumerTel.UseSystemPasswordChar = false;
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, "Adres", true));
            this.txtAdres.Depth = 0;
            this.txtAdres.Hint = "";
            this.txtAdres.Location = new System.Drawing.Point(177, 170);
            this.txtAdres.MaxLength = 32767;
            this.txtAdres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.SelectedText = "";
            this.txtAdres.SelectionLength = 0;
            this.txtAdres.SelectionStart = 0;
            this.txtAdres.Size = new System.Drawing.Size(310, 23);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.TabStop = false;
            this.txtAdres.UseSystemPasswordChar = false;
            // 
            // btnZapisz
            // 
            this.btnZapisz.AutoSize = true;
            this.btnZapisz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZapisz.Depth = 0;
            this.btnZapisz.Icon = null;
            this.btnZapisz.Location = new System.Drawing.Point(719, 402);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnZapisz.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Primary = false;
            this.btnZapisz.Size = new System.Drawing.Size(68, 36);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.AutoSize = true;
            this.btnAnuluj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnuluj.Depth = 0;
            this.btnAnuluj.Icon = null;
            this.btnAnuluj.Location = new System.Drawing.Point(648, 402);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnuluj.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Primary = false;
            this.btnAnuluj.Size = new System.Drawing.Size(63, 36);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Auluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.AutoSize = true;
            this.btnEdytuj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdytuj.Depth = 0;
            this.btnEdytuj.Icon = null;
            this.btnEdytuj.Location = new System.Drawing.Point(569, 402);
            this.btnEdytuj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdytuj.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Primary = false;
            this.btnEdytuj.Size = new System.Drawing.Size(71, 36);
            this.btnEdytuj.TabIndex = 6;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDodaj.Depth = 0;
            this.btnDodaj.Icon = null;
            this.btnDodaj.Location = new System.Drawing.Point(496, 402);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDodaj.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Primary = false;
            this.btnDodaj.Size = new System.Drawing.Size(65, 36);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pacjenciTableAdapter
            // 
            this.pacjenciTableAdapter.ClearBeforeFill = true;
            // 
            // Pacjenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNumerTel);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtImieNazwisko);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Pacjenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacjenci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pacjenci_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImieNazwisko;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumerTel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdres;
        private MaterialSkin.Controls.MaterialFlatButton btnZapisz;
        private MaterialSkin.Controls.MaterialFlatButton btnAnuluj;
        private MaterialSkin.Controls.MaterialFlatButton btnEdytuj;
        private MaterialSkin.Controls.MaterialFlatButton btnDodaj;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pacjenciBindingSource;
        private DatabaseDataSetTableAdapters.PacjenciTableAdapter pacjenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}