namespace Estructura_Cola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCola = new ListBox();
            label1 = new Label();
            txtOrden = new TextBox();
            cmdInsertar = new Button();
            SuspendLayout();
            // 
            // lstCola
            // 
            lstCola.FormattingEnabled = true;
            lstCola.ItemHeight = 28;
            lstCola.Location = new Point(28, 12);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(120, 228);
            lstCola.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 1;
            label1.Text = "Orden";
            // 
            // txtOrden
            // 
            txtOrden.Enabled = false;
            txtOrden.Location = new Point(232, 14);
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(100, 34);
            txtOrden.TabIndex = 2;
            // 
            // cmdInsertar
            // 
            cmdInsertar.Location = new Point(169, 64);
            cmdInsertar.Name = "cmdInsertar";
            cmdInsertar.Size = new Size(163, 39);
            cmdInsertar.TabIndex = 3;
            cmdInsertar.Text = "Insertar";
            cmdInsertar.UseVisualStyleBackColor = true;
            cmdInsertar.Click += cmdInsertar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 280);
            Controls.Add(cmdInsertar);
            Controls.Add(txtOrden);
            Controls.Add(label1);
            Controls.Add(lstCola);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCola;
        private Label label1;
        private TextBox txtOrden;
        private Button cmdInsertar;
    }
}