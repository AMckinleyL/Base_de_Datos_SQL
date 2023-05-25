namespace Usuarios
{
    partial class frmconsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvconsultas = new System.Windows.Forms.DataGridView();
            this.lblfilas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(284, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTAS";
            // 
            // btntotal
            // 
            this.btntotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotal.Location = new System.Drawing.Point(482, 76);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(288, 38);
            this.btntotal.TabIndex = 1;
            this.btntotal.Text = "Consultar Empadronados";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnregresar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(608, 383);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(162, 55);
            this.btnregresar.TabIndex = 5;
            this.btnregresar.Text = "Regresar Menu Principal";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(25, 83);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(383, 26);
            this.txtbuscar.TabIndex = 6;
            // 
            // dgvconsultas
            // 
            this.dgvconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultas.Location = new System.Drawing.Point(25, 120);
            this.dgvconsultas.Name = "dgvconsultas";
            this.dgvconsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvconsultas.Size = new System.Drawing.Size(745, 231);
            this.dgvconsultas.TabIndex = 7;
            // 
            // lblfilas
            // 
            this.lblfilas.AutoSize = true;
            this.lblfilas.BackColor = System.Drawing.Color.Transparent;
            this.lblfilas.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilas.ForeColor = System.Drawing.Color.IndianRed;
            this.lblfilas.Location = new System.Drawing.Point(19, 383);
            this.lblfilas.Name = "lblfilas";
            this.lblfilas.Size = new System.Drawing.Size(376, 33);
            this.lblfilas.TabIndex = 8;
            this.lblfilas.Text = "Cantidad de Empadronados";
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Usuarios.Properties.Resources.FondoBDD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfilas);
            this.Controls.Add(this.dgvconsultas);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Empadronados";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvconsultas;
        private System.Windows.Forms.Label lblfilas;
    }
}