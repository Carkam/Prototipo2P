namespace CapaVista
{
    partial class EliminarProducto
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
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbIdProducto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(109, 54);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 24);
            this.cmbProducto.TabIndex = 0;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // cmbIdProducto
            // 
            this.cmbIdProducto.FormattingEnabled = true;
            this.cmbIdProducto.Location = new System.Drawing.Point(301, 54);
            this.cmbIdProducto.Name = "cmbIdProducto";
            this.cmbIdProducto.Size = new System.Drawing.Size(121, 24);
            this.cmbIdProducto.TabIndex = 1;
            this.cmbIdProducto.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbIdProducto);
            this.Controls.Add(this.cmbProducto);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbIdProducto;
        private System.Windows.Forms.Button button1;
    }
}