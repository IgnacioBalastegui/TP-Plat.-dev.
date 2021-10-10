
namespace TP
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(88, 92);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(102, 29);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(196, 101);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(133, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Location = new System.Drawing.Point(196, 147);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(133, 20);
            this.textBoxContrasenia.TabIndex = 2;
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenia.Location = new System.Drawing.Point(48, 138);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(142, 29);
            this.labelContrasenia.TabIndex = 3;
            this.labelContrasenia.Text = "Contraseña:";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(146, 216);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(113, 42);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 295);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Name = "Form1";
            this.Text = "Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Button buttonIngresar;
    }
}

