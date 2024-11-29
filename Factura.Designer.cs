
namespace lab1Asi_VH23107
{
    partial class Factura
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbdSalidaCliente = new System.Windows.Forms.Label();
            this.lbd3 = new System.Windows.Forms.Label();
            this.lbd1 = new System.Windows.Forms.Label();
            this.lbd2 = new System.Windows.Forms.Label();
            this.lbdSalidaSubmarino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdSalidaIngredientes = new System.Windows.Forms.Label();
            this.lbd5 = new System.Windows.Forms.Label();
            this.lbdSalidaTotal = new System.Windows.Forms.Label();
            this.lbdFactura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(152, 241);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lbdSalidaCliente
            // 
            this.lbdSalidaCliente.AutoSize = true;
            this.lbdSalidaCliente.Location = new System.Drawing.Point(209, 84);
            this.lbdSalidaCliente.Name = "lbdSalidaCliente";
            this.lbdSalidaCliente.Size = new System.Drawing.Size(10, 13);
            this.lbdSalidaCliente.TabIndex = 2;
            this.lbdSalidaCliente.Text = " ";
            // 
            // lbd3
            // 
            this.lbd3.AutoSize = true;
            this.lbd3.Location = new System.Drawing.Point(90, 142);
            this.lbd3.Name = "lbd3";
            this.lbd3.Size = new System.Drawing.Size(85, 13);
            this.lbd3.TabIndex = 3;
            this.lbd3.Text = "Ingrdientes extra";
            // 
            // lbd1
            // 
            this.lbd1.AutoSize = true;
            this.lbd1.Location = new System.Drawing.Point(90, 84);
            this.lbd1.Name = "lbd1";
            this.lbd1.Size = new System.Drawing.Size(39, 13);
            this.lbd1.TabIndex = 4;
            this.lbd1.Text = "Cliente";
            // 
            // lbd2
            // 
            this.lbd2.AutoSize = true;
            this.lbd2.Location = new System.Drawing.Point(90, 112);
            this.lbd2.Name = "lbd2";
            this.lbd2.Size = new System.Drawing.Size(94, 13);
            this.lbd2.TabIndex = 5;
            this.lbd2.Text = "Tipo de submarino";
            // 
            // lbdSalidaSubmarino
            // 
            this.lbdSalidaSubmarino.AutoSize = true;
            this.lbdSalidaSubmarino.Location = new System.Drawing.Point(209, 112);
            this.lbdSalidaSubmarino.Name = "lbdSalidaSubmarino";
            this.lbdSalidaSubmarino.Size = new System.Drawing.Size(10, 13);
            this.lbdSalidaSubmarino.TabIndex = 5;
            this.lbdSalidaSubmarino.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lbdSalidaIngredientes
            // 
            this.lbdSalidaIngredientes.AutoSize = true;
            this.lbdSalidaIngredientes.Location = new System.Drawing.Point(209, 142);
            this.lbdSalidaIngredientes.Name = "lbdSalidaIngredientes";
            this.lbdSalidaIngredientes.Size = new System.Drawing.Size(10, 13);
            this.lbdSalidaIngredientes.TabIndex = 3;
            this.lbdSalidaIngredientes.Text = " ";
            // 
            // lbd5
            // 
            this.lbd5.AutoSize = true;
            this.lbd5.Location = new System.Drawing.Point(90, 171);
            this.lbd5.Name = "lbd5";
            this.lbd5.Size = new System.Drawing.Size(31, 13);
            this.lbd5.TabIndex = 3;
            this.lbd5.Text = "Total";
            // 
            // lbdSalidaTotal
            // 
            this.lbdSalidaTotal.AutoSize = true;
            this.lbdSalidaTotal.Location = new System.Drawing.Point(208, 171);
            this.lbdSalidaTotal.Name = "lbdSalidaTotal";
            this.lbdSalidaTotal.Size = new System.Drawing.Size(10, 13);
            this.lbdSalidaTotal.TabIndex = 3;
            this.lbdSalidaTotal.Text = " ";
            // 
            // lbdFactura
            // 
            this.lbdFactura.AutoSize = true;
            this.lbdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdFactura.Location = new System.Drawing.Point(167, 32);
            this.lbdFactura.Name = "lbdFactura";
            this.lbdFactura.Size = new System.Drawing.Size(60, 16);
            this.lbdFactura.TabIndex = 6;
            this.lbdFactura.Text = "Factura";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.lbdFactura);
            this.Controls.Add(this.lbdSalidaTotal);
            this.Controls.Add(this.lbdSalidaIngredientes);
            this.Controls.Add(this.lbd5);
            this.Controls.Add(this.lbd3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdSalidaSubmarino);
            this.Controls.Add(this.lbd1);
            this.Controls.Add(this.lbd2);
            this.Controls.Add(this.lbdSalidaCliente);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbdSalidaCliente;
        private System.Windows.Forms.Label lbd3;
        private System.Windows.Forms.Label lbd1;
        private System.Windows.Forms.Label lbd2;
        private System.Windows.Forms.Label lbdSalidaSubmarino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdSalidaIngredientes;
        private System.Windows.Forms.Label lbd5;
        private System.Windows.Forms.Label lbdSalidaTotal;
        private System.Windows.Forms.Label lbdFactura;
    }
}