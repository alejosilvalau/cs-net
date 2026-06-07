namespace UTN.DotNet.EjAsync
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
            btnSync = new Button();
            btnAsync = new Button();
            btnAsyncP = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado1 = new Label();
            lblResultado2 = new Label();
            lblResultado3 = new Label();
            label4 = new Label();
            lblTiempoTotal = new Label();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Location = new Point(410, 404);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(112, 34);
            btnSync.TabIndex = 0;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += this.btnSync_Click;
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(544, 404);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(112, 34);
            btnAsync.TabIndex = 1;
            btnAsync.Text = "Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += this.btnAsync_Click;
            // 
            // btnAsyncP
            // 
            btnAsyncP.Location = new Point(676, 404);
            btnAsyncP.Name = "btnAsyncP";
            btnAsyncP.Size = new Size(112, 34);
            btnAsyncP.TabIndex = 2;
            btnAsyncP.Text = "Async P";
            btnAsyncP.UseVisualStyleBackColor = true;
            btnAsyncP.Click += this.btnAsyncP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 3;
            label1.Text = "Resultado 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 65);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 4;
            label2.Text = "Resultado 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 106);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 5;
            label3.Text = "Resultado 3:";
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado1.Location = new Point(136, 24);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(26, 25);
            lblResultado1.TabIndex = 6;
            lblResultado1.Text = "--";
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado2.Location = new Point(136, 65);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(26, 25);
            lblResultado2.TabIndex = 7;
            lblResultado2.Text = "--";
            // 
            // lblResultado3
            // 
            lblResultado3.AutoSize = true;
            lblResultado3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado3.Location = new Point(136, 106);
            lblResultado3.Name = "lblResultado3";
            lblResultado3.Size = new Size(26, 25);
            lblResultado3.TabIndex = 8;
            lblResultado3.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(519, 65);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "Tiempo total:";
            // 
            // lblTiempoTotal
            // 
            lblTiempoTotal.AutoSize = true;
            lblTiempoTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiempoTotal.Location = new Point(651, 65);
            lblTiempoTotal.Name = "lblTiempoTotal";
            lblTiempoTotal.Size = new Size(26, 25);
            lblTiempoTotal.TabIndex = 10;
            lblTiempoTotal.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(lblTiempoTotal);
            this.Controls.Add(label4);
            this.Controls.Add(lblResultado3);
            this.Controls.Add(lblResultado2);
            this.Controls.Add(lblResultado1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(btnAsyncP);
            this.Controls.Add(btnAsync);
            this.Controls.Add(btnSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnSync;
        private Button btnAsync;
        private Button btnAsyncP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado1;
        private Label lblResultado2;
        private Label lblResultado3;
        private Label label4;
        private Label lblTiempoTotal;
    }
}