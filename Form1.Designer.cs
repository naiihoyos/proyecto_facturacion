﻿
namespace PROYECTO_POS_NHZ
{
    partial class Form1_logins_ini
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.texbusuario = new System.Windows.Forms.TextBox();
            this.textbcontrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F, System.Drawing.FontStyle.Bold);
            this.btn_ingresar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_ingresar.Location = new System.Drawing.Point(43, 153);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(106, 42);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(195, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // texbusuario
            // 
            this.texbusuario.BackColor = System.Drawing.Color.LightGreen;
            this.texbusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texbusuario.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F, System.Drawing.FontStyle.Bold);
            this.texbusuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.texbusuario.Location = new System.Drawing.Point(194, 20);
            this.texbusuario.Name = "texbusuario";
            this.texbusuario.Size = new System.Drawing.Size(100, 22);
            this.texbusuario.TabIndex = 4;
            // 
            // textbcontrasena
            // 
            this.textbcontrasena.BackColor = System.Drawing.Color.LightGreen;
            this.textbcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbcontrasena.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F, System.Drawing.FontStyle.Bold);
            this.textbcontrasena.ForeColor = System.Drawing.Color.DarkGreen;
            this.textbcontrasena.Location = new System.Drawing.Point(194, 85);
            this.textbcontrasena.Name = "textbcontrasena";
            this.textbcontrasena.PasswordChar = '*';
            this.textbcontrasena.Size = new System.Drawing.Size(100, 22);
            this.textbcontrasena.TabIndex = 5;
            // 
            // Form1_logins_ini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(310, 207);
            this.Controls.Add(this.textbcontrasena);
            this.Controls.Add(this.texbusuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1_logins_ini";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.Form1_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox texbusuario;
        private System.Windows.Forms.TextBox textbcontrasena;
    }
}

