//namespace Practica_Telefonos
//{
//    partial class Buscar
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lblBuscar = new System.Windows.Forms.Label();
//            this.lblIdentidad = new System.Windows.Forms.Label();
//            this.txtIdentidad = new System.Windows.Forms.TextBox();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.btnAceptar = new System.Windows.Forms.Button();
//            this.btnBuscar = new System.Windows.Forms.Button();
//            this.btnCancelar = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // lblBuscar
//            // 
//            this.lblBuscar.AutoSize = true;
//            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblBuscar.Location = new System.Drawing.Point(218, 21);
//            this.lblBuscar.Name = "lblBuscar";
//            this.lblBuscar.Size = new System.Drawing.Size(74, 24);
//            this.lblBuscar.TabIndex = 0;
//            this.lblBuscar.Text = "Buscar";
//            // 
//            // lblIdentidad
//            // 
//            this.lblIdentidad.AutoSize = true;
//            this.lblIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblIdentidad.Location = new System.Drawing.Point(21, 81);
//            this.lblIdentidad.Name = "lblIdentidad";
//            this.lblIdentidad.Size = new System.Drawing.Size(132, 16);
//            this.lblIdentidad.TabIndex = 1;
//            this.lblIdentidad.Text = "Doc.Identificacion";
//            // 
//            // txtIdentidad
//            // 
//            this.txtIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtIdentidad.Location = new System.Drawing.Point(159, 75);
//            this.txtIdentidad.Name = "txtIdentidad";
//            this.txtIdentidad.Size = new System.Drawing.Size(266, 22);
//            this.txtIdentidad.TabIndex = 2;
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
//            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Location = new System.Drawing.Point(41, 197);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.Size = new System.Drawing.Size(461, 105);
//            this.dataGridView1.TabIndex = 4;
//            // 
//            // btnAceptar
//            // 
//            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnAceptar.Location = new System.Drawing.Point(41, 323);
//            this.btnAceptar.Name = "btnAceptar";
//            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
//            this.btnAceptar.TabIndex = 5;
//            this.btnAceptar.Text = "Aceptar";
//            this.btnAceptar.UseVisualStyleBackColor = true;
//            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
//            // 
//            // btnBuscar
//            // 
//            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnBuscar.Location = new System.Drawing.Point(207, 134);
//            this.btnBuscar.Name = "btnBuscar";
//            this.btnBuscar.Size = new System.Drawing.Size(108, 37);
//            this.btnBuscar.TabIndex = 3;
//            this.btnBuscar.Text = "Bsucar";
//            this.btnBuscar.UseVisualStyleBackColor = true;
//            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
//            // 
//            // btnCancelar
//            // 
//            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnCancelar.Location = new System.Drawing.Point(394, 325);
//            this.btnCancelar.Name = "btnCancelar";
//            this.btnCancelar.Size = new System.Drawing.Size(108, 37);
//            this.btnCancelar.TabIndex = 6;
//            this.btnCancelar.Text = "Cancelar";
//            this.btnCancelar.UseVisualStyleBackColor = true;
//            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
//            // 
//            // Buscar
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(535, 403);
//            this.Controls.Add(this.btnCancelar);
//            this.Controls.Add(this.btnBuscar);
//            this.Controls.Add(this.btnAceptar);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.txtIdentidad);
//            this.Controls.Add(this.lblIdentidad);
//            this.Controls.Add(this.lblBuscar);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
//            this.Name = "Buscar";
//            this.Text = "Buscar";
//            this.Load += new System.EventHandler(this.Buscar_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label lblBuscar;
//        private System.Windows.Forms.Label lblIdentidad;
//        private System.Windows.Forms.TextBox txtIdentidad;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Button btnAceptar;
//        private System.Windows.Forms.Button btnBuscar;
//        private System.Windows.Forms.Button btnCancelar;
//    }
//}