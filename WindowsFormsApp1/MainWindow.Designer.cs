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
            this.Label_Destination = new System.Windows.Forms.Label();
            this.combobox_origin = new System.Windows.Forms.ComboBox();
            this.combobox_destination = new System.Windows.Forms.ComboBox();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 626);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Destination
            // 
            this.Label_Destination.AutoSize = true;
            this.Label_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Destination.Location = new System.Drawing.Point(859, 172);
            this.Label_Destination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Destination.Name = "Label_Destination";
            this.Label_Destination.Size = new System.Drawing.Size(92, 25);
            this.Label_Destination.TabIndex = 2;
            this.Label_Destination.Text = "Destino";
            // 
            // combobox_origin
            // 
            this.combobox_origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_origin.FormattingEnabled = true;
            this.combobox_origin.Location = new System.Drawing.Point(844, 108);
            this.combobox_origin.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_origin.Name = "combobox_origin";
            this.combobox_origin.Size = new System.Drawing.Size(124, 21);
            this.combobox_origin.TabIndex = 3;
            // 
            // combobox_destination
            // 
            this.combobox_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_destination.FormattingEnabled = true;
            this.combobox_destination.Location = new System.Drawing.Point(844, 199);
            this.combobox_destination.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_destination.Name = "combobox_destination";
            this.combobox_destination.Size = new System.Drawing.Size(124, 21);
            this.combobox_destination.TabIndex = 4;
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Image = ((System.Drawing.Image)(resources.GetObject("buttonDijkstra.Image")));
            this.buttonDijkstra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDijkstra.Location = new System.Drawing.Point(835, 287);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonDijkstra.Size = new System.Drawing.Size(146, 34);
            this.buttonDijkstra.TabIndex = 5;
            this.buttonDijkstra.Text = "Aceptar";
            this.buttonDijkstra.UseCompatibleTextRendering = true;
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(859, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Origen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.combobox_destination);
            this.Controls.Add(this.combobox_origin);
            this.Controls.Add(this.Label_Destination);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Algoritmia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Destination;
        private System.Windows.Forms.ComboBox combobox_origin;
        private System.Windows.Forms.ComboBox combobox_destination;
        private System.Windows.Forms.Button buttonDijkstra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

