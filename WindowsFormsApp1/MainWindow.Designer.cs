namespace WindowsFormsApp1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Origin = new System.Windows.Forms.Label();
            this.Label_Destination = new System.Windows.Forms.Label();
            this.combobox_origin = new System.Windows.Forms.ComboBox();
            this.combobox_destination = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 517);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Origin
            // 
            this.Label_Origin.AutoSize = true;
            this.Label_Origin.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Origin.Location = new System.Drawing.Point(675, 12);
            this.Label_Origin.Name = "Label_Origin";
            this.Label_Origin.Size = new System.Drawing.Size(67, 23);
            this.Label_Origin.TabIndex = 1;
            this.Label_Origin.Text = "Origen";
            this.Label_Origin.Visible = false;
            // 
            // Label_Destination
            // 
            this.Label_Destination.AutoSize = true;
            this.Label_Destination.Location = new System.Drawing.Point(675, 143);
            this.Label_Destination.Name = "Label_Destination";
            this.Label_Destination.Size = new System.Drawing.Size(56, 17);
            this.Label_Destination.TabIndex = 2;
            this.Label_Destination.Text = "Destino";
            // 
            // combobox_origin
            // 
            this.combobox_origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_origin.FormattingEnabled = true;
            this.combobox_origin.Location = new System.Drawing.Point(678, 38);
            this.combobox_origin.Name = "combobox_origin";
            this.combobox_origin.Size = new System.Drawing.Size(121, 24);
            this.combobox_origin.TabIndex = 3;
            this.combobox_origin.SelectedIndexChanged += new System.EventHandler(this.combobox_origin_SelectedIndexChanged);
            // 
            // combobox_destination
            // 
            this.combobox_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_destination.FormattingEnabled = true;
            this.combobox_destination.Location = new System.Drawing.Point(678, 172);
            this.combobox_destination.Name = "combobox_destination";
            this.combobox_destination.Size = new System.Drawing.Size(121, 24);
            this.combobox_destination.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(307, 162);
            this.button1.TabIndex = 5;
            this.button1.Text = "Boton";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 107);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(566, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 165);
            this.panel1.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combobox_destination);
            this.Controls.Add(this.combobox_origin);
            this.Controls.Add(this.Label_Destination);
            this.Controls.Add(this.Label_Origin);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Algoritmia";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Origin;
        private System.Windows.Forms.Label Label_Destination;
        private System.Windows.Forms.ComboBox combobox_origin;
        private System.Windows.Forms.ComboBox combobox_destination;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}

