namespace ConsultaRA
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
            txbRa = new TextBox();
            lblRes = new Label();
            Ra = new Label();
            labelRa = new Label();
            btnVeri = new Button();
            lblResul = new Label();
            SuspendLayout();
            // 
            // txbRa
            // 
            txbRa.Location = new Point(75, 60);
            txbRa.Name = "txbRa";
            txbRa.Size = new Size(196, 27);
            txbRa.TabIndex = 0;
            txbRa.TextChanged += txbRa_TextChanged;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(75, 241);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(72, 20);
            lblRes.TabIndex = 1;
            lblRes.Text = "Resposta:";
            lblRes.Click += lblRes_Click;
            // 
            // Ra
            // 
            Ra.AutoSize = true;
            Ra.Location = new Point(38, 63);
            Ra.Name = "Ra";
            Ra.Size = new Size(0, 20);
            Ra.TabIndex = 2;
            // 
            // labelRa
            // 
            labelRa.AutoSize = true;
            labelRa.Location = new Point(44, 63);
            labelRa.Name = "labelRa";
            labelRa.Size = new Size(28, 20);
            labelRa.TabIndex = 3;
            labelRa.Text = "RA";
            labelRa.Click += labelRa_Click;
            // 
            // btnVeri
            // 
            btnVeri.Location = new Point(75, 121);
            btnVeri.Name = "btnVeri";
            btnVeri.Size = new Size(94, 29);
            btnVeri.TabIndex = 4;
            btnVeri.Text = "Verificar";
            btnVeri.UseVisualStyleBackColor = true;
            btnVeri.Click += btnVeri_Click;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Location = new Point(153, 241);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(0, 20);
            lblResul.TabIndex = 5;
            lblResul.Click += lblResul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 316);
            Controls.Add(lblResul);
            Controls.Add(btnVeri);
            Controls.Add(labelRa);
            Controls.Add(Ra);
            Controls.Add(lblRes);
            Controls.Add(txbRa);
            Name = "Form1";
            Text = "Verificar RA";
            Load += lblra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbRa;
        private Label lblRes;
        private Label Ra;
        private Label labelRa;
        private Button btnVeri;
        private Label lblResul;
    }
}
