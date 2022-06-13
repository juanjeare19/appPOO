
namespace appPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labTipo = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.labDoc = new System.Windows.Forms.Label();
            this.labCont = new System.Windows.Forms.Label();
            this.comboTip = new System.Windows.Forms.ComboBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textApe = new System.Windows.Forms.TextBox();
            this.textDoc = new System.Windows.Forms.TextBox();
            this.comboCont = new System.Windows.Forms.ComboBox();
            this.butGuardar = new System.Windows.Forms.Button();
            this.labCat = new System.Windows.Forms.Label();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.dataGridDatos2 = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatos.Controls.Add(this.butLimpiar);
            this.groupBoxDatos.Controls.Add(this.comboCat);
            this.groupBoxDatos.Controls.Add(this.labCat);
            this.groupBoxDatos.Controls.Add(this.butGuardar);
            this.groupBoxDatos.Controls.Add(this.comboCont);
            this.groupBoxDatos.Controls.Add(this.textDoc);
            this.groupBoxDatos.Controls.Add(this.textApe);
            this.groupBoxDatos.Controls.Add(this.textNom);
            this.groupBoxDatos.Controls.Add(this.comboTip);
            this.groupBoxDatos.Controls.Add(this.labCont);
            this.groupBoxDatos.Controls.Add(this.labDoc);
            this.groupBoxDatos.Controls.Add(this.labNom);
            this.groupBoxDatos.Controls.Add(this.labTipo);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(340, 227);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.BackColor = System.Drawing.Color.Yellow;
            this.labTipo.Location = new System.Drawing.Point(6, 41);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(32, 13);
            this.labTipo.TabIndex = 0;
            this.labTipo.Text = "Tipo";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.BackColor = System.Drawing.Color.Yellow;
            this.labNom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labNom.Location = new System.Drawing.Point(6, 72);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(54, 13);
            this.labNom.TabIndex = 1;
            this.labNom.Text = "Nombre ";
            // 
            // labDoc
            // 
            this.labDoc.AutoSize = true;
            this.labDoc.BackColor = System.Drawing.Color.Yellow;
            this.labDoc.Location = new System.Drawing.Point(6, 102);
            this.labDoc.Name = "labDoc";
            this.labDoc.Size = new System.Drawing.Size(71, 13);
            this.labDoc.TabIndex = 2;
            this.labDoc.Text = "Documento";
            // 
            // labCont
            // 
            this.labCont.AutoSize = true;
            this.labCont.Location = new System.Drawing.Point(10, 131);
            this.labCont.Name = "labCont";
            this.labCont.Size = new System.Drawing.Size(55, 13);
            this.labCont.TabIndex = 3;
            this.labCont.Text = "Contrato";
            // 
            // comboTip
            // 
            this.comboTip.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTip.FormattingEnabled = true;
            this.comboTip.Items.AddRange(new object[] {
            "Cliente",
            "Empleado"});
            this.comboTip.Location = new System.Drawing.Point(83, 38);
            this.comboTip.Name = "comboTip";
            this.comboTip.Size = new System.Drawing.Size(121, 21);
            this.comboTip.TabIndex = 4;
            this.comboTip.SelectedIndexChanged += new System.EventHandler(this.comboTip_SelectedIndexChanged);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(83, 69);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 5;
            this.textNom.TextChanged += new System.EventHandler(this.textNom_TextChanged);
            // 
            // textApe
            // 
            this.textApe.Location = new System.Drawing.Point(189, 69);
            this.textApe.Name = "textApe";
            this.textApe.Size = new System.Drawing.Size(100, 20);
            this.textApe.TabIndex = 6;
            this.textApe.TextChanged += new System.EventHandler(this.textApe_TextChanged);
            // 
            // textDoc
            // 
            this.textDoc.Location = new System.Drawing.Point(83, 99);
            this.textDoc.Name = "textDoc";
            this.textDoc.Size = new System.Drawing.Size(100, 20);
            this.textDoc.TabIndex = 7;
            // 
            // comboCont
            // 
            this.comboCont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCont.FormattingEnabled = true;
            this.comboCont.Items.AddRange(new object[] {
            "Junior",
            "Medium",
            "Senior"});
            this.comboCont.Location = new System.Drawing.Point(83, 125);
            this.comboCont.Name = "comboCont";
            this.comboCont.Size = new System.Drawing.Size(121, 21);
            this.comboCont.TabIndex = 8;
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(169, 177);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(75, 23);
            this.butGuardar.TabIndex = 9;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // labCat
            // 
            this.labCat.AutoSize = true;
            this.labCat.BackColor = System.Drawing.Color.Yellow;
            this.labCat.Location = new System.Drawing.Point(6, 131);
            this.labCat.Name = "labCat";
            this.labCat.Size = new System.Drawing.Size(61, 13);
            this.labCat.TabIndex = 10;
            this.labCat.Text = "Categoria";
            // 
            // comboCat
            // 
            this.comboCat.AccessibleName = "";
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Items.AddRange(new object[] {
            "Premium VIP",
            "Premium",
            "Normal"});
            this.comboCat.Location = new System.Drawing.Point(83, 125);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(121, 21);
            this.comboCat.TabIndex = 11;
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Location = new System.Drawing.Point(371, 23);
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.Size = new System.Drawing.Size(534, 150);
            this.dataGridDatos.TabIndex = 1;
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(248, 177);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 12;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // dataGridDatos2
            // 
            this.dataGridDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos2.Location = new System.Drawing.Point(371, 23);
            this.dataGridDatos2.Name = "dataGridDatos2";
            this.dataGridDatos2.Size = new System.Drawing.Size(534, 150);
            this.dataGridDatos2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appPOO.Properties.Resources.pngtree_corporate_culture_background_wall_background_template_image_194394;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 261);
            this.Controls.Add(this.dataGridDatos2);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.groupBoxDatos);
            this.Name = "Form1";
            this.Text = "Formulario POO";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.ComboBox comboTip;
        private System.Windows.Forms.Label labCont;
        private System.Windows.Forms.Label labDoc;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.ComboBox comboCont;
        private System.Windows.Forms.TextBox textDoc;
        private System.Windows.Forms.TextBox textApe;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Label labCat;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.DataGridView dataGridDatos2;
    }
}

