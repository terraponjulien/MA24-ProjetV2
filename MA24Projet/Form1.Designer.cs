namespace MA24Projet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChrono = new System.Windows.Forms.Label();
            this.timerChrono = new System.Windows.Forms.Timer(this.components);
            this.lblTemps = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chrono";
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChrono.Location = new System.Drawing.Point(100, 32);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(0, 25);
            this.lblChrono.TabIndex = 3;
            // 
            // timerChrono
            // 
            this.timerChrono.Interval = 1;
            this.timerChrono.Tick += new System.EventHandler(this.timerChrono_Tick);
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemps.Location = new System.Drawing.Point(17, 74);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(0, 25);
            this.lblTemps.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmdReset
            // 
            this.cmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.Location = new System.Drawing.Point(12, 112);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(85, 41);
            this.cmdReset.TabIndex = 5;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRestart.Location = new System.Drawing.Point(105, 112);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(95, 40);
            this.cmdRestart.TabIndex = 6;
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.UseVisualStyleBackColor = true;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 174);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.lblChrono);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.Timer timerChrono;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdRestart;
    }
}

