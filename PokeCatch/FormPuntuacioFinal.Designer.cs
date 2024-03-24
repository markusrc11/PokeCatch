namespace PokeCatch
{
    partial class FormPuntuacioFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuntuacioFinal));
            this.lblPuntuacio = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNivell = new System.Windows.Forms.Label();
            this.lblPuntsMax = new System.Windows.Forms.Label();
            this.lPuntsMax = new System.Windows.Forms.Label();
            this.lblPunts = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.comboNivell = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPuntuacio
            // 
            this.lblPuntuacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntuacio.AutoSize = true;
            this.lblPuntuacio.Font = new System.Drawing.Font("Stencil", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacio.Location = new System.Drawing.Point(81, 124);
            this.lblPuntuacio.Name = "lblPuntuacio";
            this.lblPuntuacio.Size = new System.Drawing.Size(152, 16);
            this.lblPuntuacio.TabIndex = 0;
            this.lblPuntuacio.Text = "Pokémons capturats";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Location = new System.Drawing.Point(137, 158);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Acceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblNivell
            // 
            this.lblNivell.AutoSize = true;
            this.lblNivell.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivell.Location = new System.Drawing.Point(8, 9);
            this.lblNivell.Name = "lblNivell";
            this.lblNivell.Size = new System.Drawing.Size(130, 40);
            this.lblNivell.TabIndex = 3;
            this.lblNivell.Text = "Nivell";
            this.lblNivell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuntsMax
            // 
            this.lblPuntsMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntsMax.AutoSize = true;
            this.lblPuntsMax.Font = new System.Drawing.Font("Stencil", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntsMax.Location = new System.Drawing.Point(81, 90);
            this.lblPuntsMax.Name = "lblPuntsMax";
            this.lblPuntsMax.Size = new System.Drawing.Size(148, 16);
            this.lblPuntsMax.TabIndex = 4;
            this.lblPuntsMax.Text = "Rècord de Pokémons";
            // 
            // lPuntsMax
            // 
            this.lPuntsMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPuntsMax.AutoSize = true;
            this.lPuntsMax.Font = new System.Drawing.Font("Stencil", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPuntsMax.Location = new System.Drawing.Point(240, 86);
            this.lPuntsMax.Name = "lPuntsMax";
            this.lPuntsMax.Size = new System.Drawing.Size(0, 21);
            this.lPuntsMax.TabIndex = 6;
            // 
            // lblPunts
            // 
            this.lblPunts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPunts.AutoSize = true;
            this.lblPunts.Font = new System.Drawing.Font("Stencil", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunts.Location = new System.Drawing.Point(240, 119);
            this.lblPunts.Name = "lblPunts";
            this.lblPunts.Size = new System.Drawing.Size(0, 21);
            this.lblPunts.TabIndex = 7;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Stencil", 13F);
            this.lblRecord.Location = new System.Drawing.Point(100, 57);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(0, 21);
            this.lblRecord.TabIndex = 8;
            // 
            // comboNivell
            // 
            this.comboNivell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboNivell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivell.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNivell.FormattingEnabled = true;
            this.comboNivell.Items.AddRange(new object[] {
            "Fàcil",
            "Intermig",
            "Difícil"});
            this.comboNivell.Location = new System.Drawing.Point(139, 7);
            this.comboNivell.Name = "comboNivell";
            this.comboNivell.Size = new System.Drawing.Size(180, 47);
            this.comboNivell.TabIndex = 9;
            this.comboNivell.SelectedIndexChanged += new System.EventHandler(this.comboNivell_SelectedIndexChanged);
            // 
            // FormPuntuacioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(332, 194);
            this.Controls.Add(this.comboNivell);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblPunts);
            this.Controls.Add(this.lPuntsMax);
            this.Controls.Add(this.lblPuntsMax);
            this.Controls.Add(this.lblNivell);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPuntuacio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPuntuacioFinal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Puntuació";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuntuacio;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNivell;
        private System.Windows.Forms.Label lblPuntsMax;
        private System.Windows.Forms.Label lPuntsMax;
        private System.Windows.Forms.Label lblPunts;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ComboBox comboNivell;
    }
}

