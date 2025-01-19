namespace GameOfLife
{
    partial class GameOfLife
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawField = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cellSizeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RandBox = new System.Windows.Forms.TextBox();
            this.startStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerationCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrawField
            // 
            this.DrawField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.DrawField.Location = new System.Drawing.Point(12, 12);
            this.DrawField.Name = "DrawField";
            this.DrawField.Size = new System.Drawing.Size(960, 537);
            this.DrawField.TabIndex = 0;
            this.DrawField.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cellSizeBox
            // 
            this.cellSizeBox.Location = new System.Drawing.Point(1014, 32);
            this.cellSizeBox.Name = "cellSizeBox";
            this.cellSizeBox.Size = new System.Drawing.Size(30, 20);
            this.cellSizeBox.TabIndex = 2;
            this.cellSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cellSizeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cellSizeBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cellsize";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(978, 470);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(978, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Draw";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(996, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Random%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RandBox
            // 
            this.RandBox.Location = new System.Drawing.Point(1014, 96);
            this.RandBox.Name = "RandBox";
            this.RandBox.Size = new System.Drawing.Size(30, 20);
            this.RandBox.TabIndex = 7;
            this.RandBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(978, 526);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(100, 23);
            this.startStop.TabIndex = 8;
            this.startStop.Text = "Start";
            this.startStop.UseVisualStyleBackColor = true;
            this.startStop.Click += new System.EventHandler(this.startStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(990, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Generation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GenerationCount
            // 
            this.GenerationCount.AutoSize = true;
            this.GenerationCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GenerationCount.Location = new System.Drawing.Point(989, 363);
            this.GenerationCount.MinimumSize = new System.Drawing.Size(80, 0);
            this.GenerationCount.Name = "GenerationCount";
            this.GenerationCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenerationCount.Size = new System.Drawing.Size(80, 15);
            this.GenerationCount.TabIndex = 10;
            this.GenerationCount.Text = " 0 ";
            this.GenerationCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerationCount.Click += new System.EventHandler(this.GenerationCount_Click);
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 561);
            this.Controls.Add(this.GenerationCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startStop);
            this.Controls.Add(this.RandBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cellSizeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrawField);
            this.Name = "GameOfLife";
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cellSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RandBox;
        private System.Windows.Forms.Button startStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GenerationCount;
    }
}

