
namespace lab1Asi_VH23107
{
    partial class frmPrincipal
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.rbtPequeno = new System.Windows.Forms.RadioButton();
            this.gbxTamaños = new System.Windows.Forms.GroupBox();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbdCliente = new System.Windows.Forms.Label();
            this.lbd1 = new System.Windows.Forms.Label();
            this.lbdTitulo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtIngredientesExtra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTamaños.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(127, 385);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rbtPequeno
            // 
            this.rbtPequeno.AutoSize = true;
            this.rbtPequeno.Location = new System.Drawing.Point(35, 28);
            this.rbtPequeno.Name = "rbtPequeno";
            this.rbtPequeno.Size = new System.Drawing.Size(84, 17);
            this.rbtPequeno.TabIndex = 2;
            this.rbtPequeno.TabStop = true;
            this.rbtPequeno.Text = "15 cm $5.00";
            this.rbtPequeno.UseVisualStyleBackColor = true;
            // 
            // gbxTamaños
            // 
            this.gbxTamaños.Controls.Add(this.rbtGrande);
            this.gbxTamaños.Controls.Add(this.rbtPequeno);
            this.gbxTamaños.Location = new System.Drawing.Point(127, 111);
            this.gbxTamaños.Name = "gbxTamaños";
            this.gbxTamaños.Size = new System.Drawing.Size(262, 68);
            this.gbxTamaños.TabIndex = 3;
            this.gbxTamaños.TabStop = false;
            this.gbxTamaños.Text = "Tamaños disponibles";
            // 
            // rbtGrande
            // 
            this.rbtGrande.AutoSize = true;
            this.rbtGrande.Location = new System.Drawing.Point(151, 28);
            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Size = new System.Drawing.Size(84, 17);
            this.rbtGrande.TabIndex = 2;
            this.rbtGrande.TabStop = true;
            this.rbtGrande.Text = "30 cm $7.00";
            this.rbtGrande.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(220, 385);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(314, 385);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbdCliente
            // 
            this.lbdCliente.AutoSize = true;
            this.lbdCliente.Location = new System.Drawing.Point(139, 68);
            this.lbdCliente.Name = "lbdCliente";
            this.lbdCliente.Size = new System.Drawing.Size(39, 13);
            this.lbdCliente.TabIndex = 1;
            this.lbdCliente.Text = "Cliente";
            // 
            // lbd1
            // 
            this.lbd1.AutoSize = true;
            this.lbd1.Location = new System.Drawing.Point(141, 200);
            this.lbd1.Name = "lbd1";
            this.lbd1.Size = new System.Drawing.Size(91, 13);
            this.lbd1.TabIndex = 1;
            this.lbd1.Text = "Ingredientes extra";
            // 
            // lbdTitulo
            // 
            this.lbdTitulo.AutoSize = true;
            this.lbdTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdTitulo.Location = new System.Drawing.Point(178, 20);
            this.lbdTitulo.Name = "lbdTitulo";
            this.lbdTitulo.Size = new System.Drawing.Size(149, 16);
            this.lbdTitulo.TabIndex = 1;
            this.lbdTitulo.Text = "Restaurante Karen´s";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(251, 65);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // txtIngredientesExtra
            // 
            this.txtIngredientesExtra.Location = new System.Drawing.Point(253, 193);
            this.txtIngredientesExtra.Name = "txtIngredientesExtra";
            this.txtIngredientesExtra.Size = new System.Drawing.Size(100, 20);
            this.txtIngredientesExtra.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(102, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio por ingredientes extra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Submarino 30cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "5 o mas. $0.25";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "4. $0.50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "3. $0.25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "2. $1.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "3. $0.75";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "1. $1.50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "2. $0.75";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1. $1.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Submarino 15 cm";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.txtIngredientesExtra);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxTamaños);
            this.Controls.Add(this.lbd1);
            this.Controls.Add(this.lbdTitulo);
            this.Controls.Add(this.lbdCliente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmPrincipal";
            this.Text = "Bienvenido";
            this.gbxTamaños.ResumeLayout(false);
            this.gbxTamaños.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.RadioButton rbtPequeno;
        private System.Windows.Forms.GroupBox gbxTamaños;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbdCliente;
        private System.Windows.Forms.Label lbd1;
        private System.Windows.Forms.Label lbdTitulo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtIngredientesExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

