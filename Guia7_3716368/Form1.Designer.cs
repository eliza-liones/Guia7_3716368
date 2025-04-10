namespace Guia7_3716368
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
            this.label1 = new System.Windows.Forms.Label();
            this.textcod1 = new System.Windows.Forms.TextBox();
            this.buscar1 = new System.Windows.Forms.Button();
            this.textnom1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textapel1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textedad1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modificar1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textcod1
            // 
            this.textcod1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcod1.Location = new System.Drawing.Point(104, 31);
            this.textcod1.Name = "textcod1";
            this.textcod1.Size = new System.Drawing.Size(100, 22);
            this.textcod1.TabIndex = 1;
            // 
            // buscar1
            // 
            this.buscar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscar1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar1.Location = new System.Drawing.Point(240, 62);
            this.buscar1.Name = "buscar1";
            this.buscar1.Size = new System.Drawing.Size(97, 23);
            this.buscar1.TabIndex = 2;
            this.buscar1.Text = "BUSCAR";
            this.buscar1.UseVisualStyleBackColor = true;
            this.buscar1.Click += new System.EventHandler(this.buscar1_Click);
            // 
            // textnom1
            // 
            this.textnom1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnom1.Location = new System.Drawing.Point(104, 85);
            this.textnom1.Name = "textnom1";
            this.textnom1.Size = new System.Drawing.Size(100, 22);
            this.textnom1.TabIndex = 4;
            this.textnom1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // textapel1
            // 
            this.textapel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textapel1.Location = new System.Drawing.Point(103, 133);
            this.textapel1.Name = "textapel1";
            this.textapel1.Size = new System.Drawing.Size(100, 22);
            this.textapel1.TabIndex = 6;
            this.textapel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // textedad1
            // 
            this.textedad1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedad1.Location = new System.Drawing.Point(104, 183);
            this.textedad1.Name = "textedad1";
            this.textedad1.Size = new System.Drawing.Size(100, 22);
            this.textedad1.TabIndex = 8;
            this.textedad1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad:";
            // 
            // modificar1
            // 
            this.modificar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modificar1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar1.Location = new System.Drawing.Point(240, 109);
            this.modificar1.Name = "modificar1";
            this.modificar1.Size = new System.Drawing.Size(97, 23);
            this.modificar1.TabIndex = 9;
            this.modificar1.Text = "MODIFICAR";
            this.modificar1.UseVisualStyleBackColor = true;
            this.modificar1.Visible = false;
            this.modificar1.Click += new System.EventHandler(this.modificar1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(240, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 246);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.modificar1);
            this.Controls.Add(this.textedad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textapel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnom1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar1);
            this.Controls.Add(this.textcod1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcod1;
        private System.Windows.Forms.Button buscar1;
        private System.Windows.Forms.TextBox textnom1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textapel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textedad1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modificar1;
        private System.Windows.Forms.Button btnEliminar;
    }
}

