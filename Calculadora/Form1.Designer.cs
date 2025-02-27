namespace Calculadora
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btSg = new System.Windows.Forms.Button();
            this.btLp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2";
            // 
            // lblOper
            // 
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(415, 83);
            this.lblOper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(68, 63);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "...";
            this.lblOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(116, 276);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(393, 70);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOper1
            // 
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.Location = new System.Drawing.Point(328, 26);
            this.numOper1.Margin = new System.Windows.Forms.Padding(4);
            this.numOper1.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(181, 41);
            this.numOper1.TabIndex = 5;
            // 
            // numOper2
            // 
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.Location = new System.Drawing.Point(328, 154);
            this.numOper2.Margin = new System.Windows.Forms.Padding(4);
            this.numOper2.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(181, 41);
            this.numOper2.TabIndex = 6;
            this.numOper2.ValueChanged += new System.EventHandler(this.numOper2_ValueChanged);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(115, 83);
            this.btSoma.Margin = new System.Windows.Forms.Padding(4);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(67, 63);
            this.btSoma.TabIndex = 7;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(190, 83);
            this.btSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(67, 63);
            this.btSub.TabIndex = 8;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(265, 83);
            this.btMult.Margin = new System.Windows.Forms.Padding(4);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(67, 63);
            this.btMult.TabIndex = 9;
            this.btMult.Text = "×";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.button3_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(340, 83);
            this.btDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(67, 63);
            this.btDiv.TabIndex = 10;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click_1);
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(116, 203);
            this.btIgual.Margin = new System.Windows.Forms.Padding(4);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(393, 69);
            this.btIgual.TabIndex = 11;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btSg
            // 
            this.btSg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSg.Location = new System.Drawing.Point(115, 349);
            this.btSg.Name = "btSg";
            this.btSg.Size = new System.Drawing.Size(159, 46);
            this.btSg.TabIndex = 12;
            this.btSg.Text = "Segue";
            this.btSg.UseVisualStyleBackColor = true;
            this.btSg.Click += new System.EventHandler(this.btSg_Click);
            // 
            // btLp
            // 
            this.btLp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLp.Location = new System.Drawing.Point(350, 349);
            this.btLp.Name = "btLp";
            this.btLp.Size = new System.Drawing.Size(159, 46);
            this.btLp.TabIndex = 13;
            this.btLp.Text = "Limpa";
            this.btLp.UseVisualStyleBackColor = true;
            this.btLp.Click += new System.EventHandler(this.btLp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 554);
            this.Controls.Add(this.btLp);
            this.Controls.Add(this.btSg);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btSg;
        private System.Windows.Forms.Button btLp;
    }
}

