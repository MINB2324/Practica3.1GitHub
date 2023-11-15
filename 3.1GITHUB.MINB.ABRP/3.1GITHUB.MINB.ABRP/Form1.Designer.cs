namespace _3._1GITHUB.MINB.ABRP_
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
            button1 = new Button();
            fdgg = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            txtTelegrama = new RichTextBox();
            cbUrgente = new RadioButton();
            cbOrdinario = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(493, 340);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fdgg
            // 
            fdgg.AutoSize = true;
            fdgg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fdgg.Location = new Point(247, 65);
            fdgg.Name = "fdgg";
            fdgg.Size = new Size(39, 15);
            fdgg.TabIndex = 1;
            fdgg.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(161, 348);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(247, 340);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(247, 95);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(321, 96);
            txtTelegrama.TabIndex = 5;
            txtTelegrama.Text = "";
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(176, 259);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(67, 19);
            cbUrgente.TabIndex = 6;
            cbUrgente.TabStop = true;
            cbUrgente.Text = "Urgente";
            cbUrgente.UseVisualStyleBackColor = true;
            // 
            // cbOrdinario
            // 
            cbOrdinario.AutoSize = true;
            cbOrdinario.Location = new Point(326, 259);
            cbOrdinario.Name = "cbOrdinario";
            cbOrdinario.Size = new Size(75, 19);
            cbOrdinario.TabIndex = 7;
            cbOrdinario.TabStop = true;
            cbOrdinario.Text = "Ordinario";
            cbOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbOrdinario);
            Controls.Add(cbUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(fdgg);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label fdgg;
        private Label label2;
        private TextBox txtPrecio;
        private RichTextBox txtTelegrama;
        private RadioButton cbUrgente;
        private RadioButton cbOrdinario;
    }
}