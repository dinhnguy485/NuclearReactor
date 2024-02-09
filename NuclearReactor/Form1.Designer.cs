namespace NuclearReactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Reactor1 = new System.Windows.Forms.Label();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.Reactorlabel1 = new System.Windows.Forms.Label();
            this.Reactorlabel2 = new System.Windows.Forms.Label();
            this.ReactorStableLabel = new System.Windows.Forms.Label();
            this.ActivateButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(85, 33);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1176, 157);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Tag = "Nuclear";
            this.TitleLabel.Text = "Nuclear Reactor";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reactor1
            // 
            this.Reactor1.BackColor = System.Drawing.Color.OliveDrab;
            this.Reactor1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1.Location = new System.Drawing.Point(84, 232);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(358, 215);
            this.Reactor1.TabIndex = 2;
            this.Reactor1.Tag = "Nuclear";
            this.Reactor1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reactor1.Click += new System.EventHandler(this.Reactor1_Click);
            // 
            // Reactor2
            // 
            this.Reactor2.BackColor = System.Drawing.Color.OliveDrab;
            this.Reactor2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2.Location = new System.Drawing.Point(887, 232);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(358, 215);
            this.Reactor2.TabIndex = 3;
            this.Reactor2.Tag = "Nuclear";
            this.Reactor2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reactorlabel1
            // 
            this.Reactorlabel1.BackColor = System.Drawing.Color.Khaki;
            this.Reactorlabel1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactorlabel1.Location = new System.Drawing.Point(110, 147);
            this.Reactorlabel1.Name = "Reactorlabel1";
            this.Reactorlabel1.Size = new System.Drawing.Size(321, 68);
            this.Reactorlabel1.TabIndex = 4;
            this.Reactorlabel1.Tag = "Nuclear";
            this.Reactorlabel1.Text = "Reactor 1";
            this.Reactorlabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reactorlabel2
            // 
            this.Reactorlabel2.BackColor = System.Drawing.Color.Khaki;
            this.Reactorlabel2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactorlabel2.Location = new System.Drawing.Point(908, 145);
            this.Reactorlabel2.Name = "Reactorlabel2";
            this.Reactorlabel2.Size = new System.Drawing.Size(321, 70);
            this.Reactorlabel2.TabIndex = 5;
            this.Reactorlabel2.Tag = "Nuclear";
            this.Reactorlabel2.Text = "Reactor 2";
            this.Reactorlabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReactorStableLabel
            // 
            this.ReactorStableLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.ReactorStableLabel.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorStableLabel.Location = new System.Drawing.Point(174, 656);
            this.ReactorStableLabel.Name = "ReactorStableLabel";
            this.ReactorStableLabel.Size = new System.Drawing.Size(994, 61);
            this.ReactorStableLabel.TabIndex = 6;
            this.ReactorStableLabel.Tag = "ReactorStable";
            this.ReactorStableLabel.Text = "Reactor Stable";
            this.ReactorStableLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ActivateButton1
            // 
            this.ActivateButton1.BackColor = System.Drawing.Color.Transparent;
            this.ActivateButton1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateButton1.Location = new System.Drawing.Point(492, 523);
            this.ActivateButton1.Name = "ActivateButton1";
            this.ActivateButton1.Size = new System.Drawing.Size(388, 66);
            this.ActivateButton1.TabIndex = 7;
            this.ActivateButton1.Text = "Activate Button";
            this.ActivateButton1.UseVisualStyleBackColor = false;
            this.ActivateButton1.Click += new System.EventHandler(this.ActivateButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1304, 785);
            this.Controls.Add(this.ActivateButton1);
            this.Controls.Add(this.ReactorStableLabel);
            this.Controls.Add(this.Reactorlabel2);
            this.Controls.Add(this.Reactorlabel1);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SpringFieldNuclear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Label Reactorlabel1;
        private System.Windows.Forms.Label Reactorlabel2;
        private System.Windows.Forms.Label ReactorStableLabel;
        private System.Windows.Forms.Button ActivateButton1;
    }
}

