namespace juegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ti = new Button();
            pi = new Button();
            pa = new Button();
            pelea = new Button();
            button5 = new Button();
            button6 = new Button();
            papel = new PictureBox();
            piedra = new PictureBox();
            tijera = new PictureBox();
            papel2 = new PictureBox();
            piedra2 = new PictureBox();
            tijera2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)papel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piedra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tijera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)papel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piedra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tijera2).BeginInit();
            SuspendLayout();
            // 
            // ti
            // 
            ti.Location = new Point(422, 583);
            ti.Name = "ti";
            ti.Size = new Size(112, 34);
            ti.TabIndex = 0;
            ti.Text = "Tijera";
            ti.UseVisualStyleBackColor = true;
            ti.Click += ti_Click;
            // 
            // pi
            // 
            pi.Location = new Point(235, 583);
            pi.Name = "pi";
            pi.Size = new Size(112, 34);
            pi.TabIndex = 1;
            pi.Text = "Piedra";
            pi.UseVisualStyleBackColor = true;
            pi.Click += pi_Click;
            // 
            // pa
            // 
            pa.Location = new Point(69, 583);
            pa.Name = "pa";
            pa.Size = new Size(112, 34);
            pa.TabIndex = 2;
            pa.Text = "Papel";
            pa.UseVisualStyleBackColor = true;
            pa.Click += button3_Click;
            // 
            // pelea
            // 
            pelea.Location = new Point(116, 686);
            pelea.Name = "pelea";
            pelea.Size = new Size(112, 34);
            pelea.TabIndex = 3;
            pelea.Text = "A luchar";
            pelea.UseVisualStyleBackColor = true;
            pelea.Click += pelea_Click;
            // 
            // button5
            // 
            button5.Location = new Point(540, 686);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "Nuevo intento";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(950, 686);
            button6.Name = "button6";
            button6.Size = new Size(187, 34);
            button6.TabIndex = 5;
            button6.Text = "Salir del juego";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // papel
            // 
            papel.BackgroundImage = (Image)resources.GetObject("papel.BackgroundImage");
            papel.BackgroundImageLayout = ImageLayout.Stretch;
            papel.Location = new Point(172, 325);
            papel.Name = "papel";
            papel.Size = new Size(271, 204);
            papel.TabIndex = 6;
            papel.TabStop = false;
            papel.Visible = false;
            // 
            // piedra
            // 
            piedra.BackgroundImage = (Image)resources.GetObject("piedra.BackgroundImage");
            piedra.BackgroundImageLayout = ImageLayout.Stretch;
            piedra.Location = new Point(172, 325);
            piedra.Name = "piedra";
            piedra.Size = new Size(271, 204);
            piedra.TabIndex = 7;
            piedra.TabStop = false;
            piedra.Visible = false;
            // 
            // tijera
            // 
            tijera.BackgroundImage = (Image)resources.GetObject("tijera.BackgroundImage");
            tijera.BackgroundImageLayout = ImageLayout.Stretch;
            tijera.Location = new Point(172, 325);
            tijera.Name = "tijera";
            tijera.Size = new Size(271, 204);
            tijera.TabIndex = 8;
            tijera.TabStop = false;
            tijera.Visible = false;
            // 
            // papel2
            // 
            papel2.BackgroundImage = (Image)resources.GetObject("papel2.BackgroundImage");
            papel2.BackgroundImageLayout = ImageLayout.Stretch;
            papel2.Location = new Point(853, 325);
            papel2.Name = "papel2";
            papel2.Size = new Size(271, 204);
            papel2.TabIndex = 9;
            papel2.TabStop = false;
            papel2.Visible = false;
            // 
            // piedra2
            // 
            piedra2.BackgroundImage = (Image)resources.GetObject("piedra2.BackgroundImage");
            piedra2.BackgroundImageLayout = ImageLayout.Stretch;
            piedra2.Location = new Point(853, 325);
            piedra2.Name = "piedra2";
            piedra2.Size = new Size(271, 204);
            piedra2.TabIndex = 10;
            piedra2.TabStop = false;
            piedra2.Visible = false;
            // 
            // tijera2
            // 
            tijera2.BackgroundImage = (Image)resources.GetObject("tijera2.BackgroundImage");
            tijera2.BackgroundImageLayout = ImageLayout.Stretch;
            tijera2.Location = new Point(853, 325);
            tijera2.Name = "tijera2";
            tijera2.Size = new Size(271, 204);
            tijera2.TabIndex = 11;
            tijera2.TabStop = false;
            tijera2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 48);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 12;
            label1.Text = "Ha jugar ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 91);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 13;
            label2.Text = "Elije a tu peleador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 168);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(824, 138);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 192);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 764);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tijera2);
            Controls.Add(piedra2);
            Controls.Add(papel2);
            Controls.Add(tijera);
            Controls.Add(piedra);
            Controls.Add(papel);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pelea);
            Controls.Add(pa);
            Controls.Add(pi);
            Controls.Add(ti);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)papel).EndInit();
            ((System.ComponentModel.ISupportInitialize)piedra).EndInit();
            ((System.ComponentModel.ISupportInitialize)tijera).EndInit();
            ((System.ComponentModel.ISupportInitialize)papel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)piedra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tijera2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ti;
        private Button pi;
        private Button pa;
        private Button pelea;
        private Button button5;
        private Button button6;
        private PictureBox papel;
        private PictureBox piedra;
        private PictureBox tijera;
        private PictureBox papel2;
        private PictureBox piedra2;
        private PictureBox tijera2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
