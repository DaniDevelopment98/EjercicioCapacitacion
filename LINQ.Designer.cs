
namespace EjemplosCapacitacion
{
    partial class LINQ
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
            this.btnMuestra = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMuestra
            // 
            this.btnMuestra.Location = new System.Drawing.Point(122, 231);
            this.btnMuestra.Name = "btnMuestra";
            this.btnMuestra.Size = new System.Drawing.Size(103, 23);
            this.btnMuestra.TabIndex = 0;
            this.btnMuestra.Text = "MuestraDatos";
            this.btnMuestra.UseVisualStyleBackColor = true;
            this.btnMuestra.Click += new System.EventHandler(this.btnMuestra_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 160);
            this.listBox1.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(89, 39);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(89, 20);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(149, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Ingrese un año del 2020-2022";
            // 
            // LINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMuestra);
            this.Name = "LINQ";
            this.Text = "iqueryable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMuestra;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblAño;
    }
}