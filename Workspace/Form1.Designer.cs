namespace Workspace
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
            this.Cnombre = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Chola = new System.Windows.Forms.Label();
            this.Cselecciona = new System.Windows.Forms.Label();
            this.boton2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.Csalario = new System.Windows.Forms.Label();
            this.boton3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSize = true;
            this.Cnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cnombre.Location = new System.Drawing.Point(263, 188);
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.Size = new System.Drawing.Size(278, 32);
            this.Cnombre.TabIndex = 0;
            this.Cnombre.Text = "Cual es tu nombre?";
            this.Cnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            this.input1.AcceptsTab = true;
            this.input1.Font = new System.Drawing.Font("San Francisco Text Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(269, 251);
            this.input1.Margin = new System.Windows.Forms.Padding(30);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(272, 23);
            this.input1.TabIndex = 1;
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(332, 289);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(140, 45);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "Aceptar";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Chola
            // 
            this.Chola.AutoSize = true;
            this.Chola.Font = new System.Drawing.Font("San Francisco Text Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Chola.Location = new System.Drawing.Point(202, 24);
            this.Chola.Name = "Chola";
            this.Chola.Size = new System.Drawing.Size(75, 34);
            this.Chola.TabIndex = 5;
            this.Chola.Text = "Hola";
            this.Chola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chola.Visible = false;
            // 
            // Cselecciona
            // 
            this.Cselecciona.AutoSize = true;
            this.Cselecciona.Font = new System.Drawing.Font("San Francisco Text Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cselecciona.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cselecciona.Location = new System.Drawing.Point(202, 68);
            this.Cselecciona.Name = "Cselecciona";
            this.Cselecciona.Size = new System.Drawing.Size(438, 34);
            this.Cselecciona.TabIndex = 6;
            this.Cselecciona.Text = "Selecciona para calcular salario";
            this.Cselecciona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cselecciona.Visible = false;
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(332, 146);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(140, 25);
            this.boton2.TabIndex = 7;
            this.boton2.Text = "Aceptar";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Visible = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Profesores",
            "Profesores 1-10",
            "Profesores +10"});
            this.comboBox1.Location = new System.Drawing.Point(298, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // input2
            // 
            this.input2.AcceptsTab = true;
            this.input2.Font = new System.Drawing.Font("San Francisco Text Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(39, 146);
            this.input2.Margin = new System.Windows.Forms.Padding(30);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(153, 23);
            this.input2.TabIndex = 9;
            this.input2.Visible = false;
            // 
            // Csalario
            // 
            this.Csalario.AutoSize = true;
            this.Csalario.Location = new System.Drawing.Point(36, 124);
            this.Csalario.Name = "Csalario";
            this.Csalario.Size = new System.Drawing.Size(50, 16);
            this.Csalario.TabIndex = 10;
            this.Csalario.Text = "Salario";
            this.Csalario.Visible = false;
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(43, 181);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(148, 39);
            this.boton3.TabIndex = 11;
            this.boton3.Text = "aceptar";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Visible = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 268);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // botonImprimir
            // 
            this.botonImprimir.Location = new System.Drawing.Point(44, 235);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(148, 39);
            this.botonImprimir.TabIndex = 13;
            this.botonImprimir.Text = "imprimir";
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Visible = false;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(614, 357);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(148, 39);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.Csalario);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.Cselecciona);
            this.Controls.Add(this.Chola);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.Cnombre);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cnombre;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Chola;
        private System.Windows.Forms.Label Cselecciona;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label Csalario;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.Button btnRegresar;
    }
}

