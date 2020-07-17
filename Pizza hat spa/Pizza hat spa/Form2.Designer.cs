namespace Pizza_hat_spa
{
    partial class Form2
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
            this.Pizzas = new System.Windows.Forms.Label();
            this.Cantidad_P = new System.Windows.Forms.Label();
            this.Familiar_P = new System.Windows.Forms.CheckBox();
            this.Mediana_P = new System.Windows.Forms.CheckBox();
            this.Individual_P = new System.Windows.Forms.CheckBox();
            this.Bebidas = new System.Windows.Forms.Label();
            this.Cantidad_B = new System.Windows.Forms.Label();
            this.Individual_B = new System.Windows.Forms.CheckBox();
            this.Familiar_B = new System.Windows.Forms.CheckBox();
            this.Agregar_Pedido = new System.Windows.Forms.Button();
            this.Cerrar_Caja = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.Total_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Pizza hat spa.\"";
            // 
            // Pizzas
            // 
            this.Pizzas.AutoSize = true;
            this.Pizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizzas.Location = new System.Drawing.Point(101, 88);
            this.Pizzas.Name = "Pizzas";
            this.Pizzas.Size = new System.Drawing.Size(53, 16);
            this.Pizzas.TabIndex = 1;
            this.Pizzas.Text = "Pizzas";
            this.Pizzas.Click += new System.EventHandler(this.Pizzas_Click);
            // 
            // Cantidad_P
            // 
            this.Cantidad_P.AutoSize = true;
            this.Cantidad_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad_P.Location = new System.Drawing.Point(104, 122);
            this.Cantidad_P.Name = "Cantidad_P";
            this.Cantidad_P.Size = new System.Drawing.Size(70, 16);
            this.Cantidad_P.TabIndex = 2;
            this.Cantidad_P.Text = "Cantidad";
            this.Cantidad_P.Click += new System.EventHandler(this.Cantidad_P_Click);
            // 
            // Familiar_P
            // 
            this.Familiar_P.AutoSize = true;
            this.Familiar_P.Location = new System.Drawing.Point(128, 150);
            this.Familiar_P.Name = "Familiar_P";
            this.Familiar_P.Size = new System.Drawing.Size(103, 17);
            this.Familiar_P.TabIndex = 3;
            this.Familiar_P.Text = "Familiar $22.000";
            this.Familiar_P.UseVisualStyleBackColor = true;
            this.Familiar_P.CheckedChanged += new System.EventHandler(this.Familiar_P_CheckedChanged);
            // 
            // Mediana_P
            // 
            this.Mediana_P.AutoSize = true;
            this.Mediana_P.Location = new System.Drawing.Point(128, 184);
            this.Mediana_P.Name = "Mediana_P";
            this.Mediana_P.Size = new System.Drawing.Size(109, 17);
            this.Mediana_P.TabIndex = 4;
            this.Mediana_P.Text = "Mediana $12.000";
            this.Mediana_P.UseVisualStyleBackColor = true;
            this.Mediana_P.CheckedChanged += new System.EventHandler(this.Mediana_P_CheckedChanged);
            // 
            // Individual_P
            // 
            this.Individual_P.AutoSize = true;
            this.Individual_P.Location = new System.Drawing.Point(128, 219);
            this.Individual_P.Name = "Individual_P";
            this.Individual_P.Size = new System.Drawing.Size(107, 17);
            this.Individual_P.TabIndex = 5;
            this.Individual_P.Text = "Individual $8.000";
            this.Individual_P.UseVisualStyleBackColor = true;
            this.Individual_P.CheckedChanged += new System.EventHandler(this.Individual_P_CheckedChanged);
            // 
            // Bebidas
            // 
            this.Bebidas.AutoSize = true;
            this.Bebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bebidas.Location = new System.Drawing.Point(473, 87);
            this.Bebidas.Name = "Bebidas";
            this.Bebidas.Size = new System.Drawing.Size(66, 16);
            this.Bebidas.TabIndex = 6;
            this.Bebidas.Text = "Bebidas";
            this.Bebidas.Click += new System.EventHandler(this.Bebidas_Click);
            // 
            // Cantidad_B
            // 
            this.Cantidad_B.AutoSize = true;
            this.Cantidad_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad_B.Location = new System.Drawing.Point(476, 121);
            this.Cantidad_B.Name = "Cantidad_B";
            this.Cantidad_B.Size = new System.Drawing.Size(70, 16);
            this.Cantidad_B.TabIndex = 7;
            this.Cantidad_B.Text = "Cantidad";
            this.Cantidad_B.Click += new System.EventHandler(this.Cantidad_B_Click);
            // 
            // Individual_B
            // 
            this.Individual_B.AutoSize = true;
            this.Individual_B.Location = new System.Drawing.Point(488, 150);
            this.Individual_B.Name = "Individual_B";
            this.Individual_B.Size = new System.Drawing.Size(107, 17);
            this.Individual_B.TabIndex = 8;
            this.Individual_B.Text = "Individual $1.500";
            this.Individual_B.UseVisualStyleBackColor = true;
            this.Individual_B.CheckedChanged += new System.EventHandler(this.Individual_B_CheckedChanged);
            // 
            // Familiar_B
            // 
            this.Familiar_B.AutoSize = true;
            this.Familiar_B.Location = new System.Drawing.Point(488, 184);
            this.Familiar_B.Name = "Familiar_B";
            this.Familiar_B.Size = new System.Drawing.Size(97, 17);
            this.Familiar_B.TabIndex = 9;
            this.Familiar_B.Text = "Familiar $5.000";
            this.Familiar_B.UseVisualStyleBackColor = true;
            this.Familiar_B.CheckedChanged += new System.EventHandler(this.Familiar_B_CheckedChanged);
            // 
            // Agregar_Pedido
            // 
            this.Agregar_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_Pedido.Location = new System.Drawing.Point(128, 290);
            this.Agregar_Pedido.Name = "Agregar_Pedido";
            this.Agregar_Pedido.Size = new System.Drawing.Size(130, 34);
            this.Agregar_Pedido.TabIndex = 10;
            this.Agregar_Pedido.Text = "Agregar pedido";
            this.Agregar_Pedido.UseVisualStyleBackColor = true;
            this.Agregar_Pedido.Click += new System.EventHandler(this.Agregar_Pedido_Click);
            // 
            // Cerrar_Caja
            // 
            this.Cerrar_Caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar_Caja.Location = new System.Drawing.Point(476, 290);
            this.Cerrar_Caja.Name = "Cerrar_Caja";
            this.Cerrar_Caja.Size = new System.Drawing.Size(109, 34);
            this.Cerrar_Caja.TabIndex = 11;
            this.Cerrar_Caja.Text = "Cerrar Caja";
            this.Cerrar_Caja.UseVisualStyleBackColor = true;
            this.Cerrar_Caja.Click += new System.EventHandler(this.Cerrar_Caja_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(201, 405);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(47, 15);
            this.Total.TabIndex = 12;
            this.Total.Text = "Total :";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // Total_TextBox
            // 
            this.Total_TextBox.Location = new System.Drawing.Point(245, 405);
            this.Total_TextBox.Name = "Total_TextBox";
            this.Total_TextBox.Size = new System.Drawing.Size(148, 20);
            this.Total_TextBox.TabIndex = 13;
            this.Total_TextBox.TextChanged += new System.EventHandler(this.Total_TextBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total_TextBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Cerrar_Caja);
            this.Controls.Add(this.Agregar_Pedido);
            this.Controls.Add(this.Familiar_B);
            this.Controls.Add(this.Individual_B);
            this.Controls.Add(this.Cantidad_B);
            this.Controls.Add(this.Bebidas);
            this.Controls.Add(this.Individual_P);
            this.Controls.Add(this.Mediana_P);
            this.Controls.Add(this.Familiar_P);
            this.Controls.Add(this.Cantidad_P);
            this.Controls.Add(this.Pizzas);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pizzas;
        private System.Windows.Forms.Label Cantidad_P;
        private System.Windows.Forms.CheckBox Familiar_P;
        private System.Windows.Forms.CheckBox Mediana_P;
        private System.Windows.Forms.CheckBox Individual_P;
        private System.Windows.Forms.Label Bebidas;
        private System.Windows.Forms.Label Cantidad_B;
        private System.Windows.Forms.CheckBox Individual_B;
        private System.Windows.Forms.CheckBox Familiar_B;
        private System.Windows.Forms.Button Agregar_Pedido;
        private System.Windows.Forms.Button Cerrar_Caja;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox Total_TextBox;
    }
}