namespace PokeCatch
{
    partial class FormJoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partidaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPartidaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiSomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPokemon1 = new System.Windows.Forms.PictureBox();
            this.pbPokemon2 = new System.Windows.Forms.PictureBox();
            this.comptTemps = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPunts = new System.Windows.Forms.Label();
            this.pbPokeball = new System.Windows.Forms.PictureBox();
            this.comptImatge1 = new System.Windows.Forms.Timer(this.components);
            this.comptImatge2 = new System.Windows.Forms.Timer(this.components);
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.btnPlayPauseMenu = new System.Windows.Forms.Button();
            this.btnPlayMenu = new System.Windows.Forms.Button();
            this.btnStopMenu = new System.Windows.Forms.Button();
            this.btnRestartMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoBTN = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidaMenuItem,
            this.dificultatMenuItem,
            this.ajudaMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partidaMenuItem
            // 
            this.partidaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaMenuItem,
            this.pausarMenuItem,
            this.reiniciarMenuItem,
            this.pararMenuItem});
            this.partidaMenuItem.Name = "partidaMenuItem";
            this.partidaMenuItem.Size = new System.Drawing.Size(56, 20);
            this.partidaMenuItem.Text = "Partida";
            // 
            // novaMenuItem
            // 
            this.novaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPartidaMenuItem});
            this.novaMenuItem.Name = "novaMenuItem";
            this.novaMenuItem.Size = new System.Drawing.Size(119, 22);
            this.novaMenuItem.Text = "Nova";
            // 
            // novaPartidaMenuItem
            // 
            this.novaPartidaMenuItem.Name = "novaPartidaMenuItem";
            this.novaPartidaMenuItem.Size = new System.Drawing.Size(111, 22);
            this.novaPartidaMenuItem.Text = "Partida";
            this.novaPartidaMenuItem.Click += new System.EventHandler(this.novaPartida_Click);
            // 
            // pausarMenuItem
            // 
            this.pausarMenuItem.Name = "pausarMenuItem";
            this.pausarMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pausarMenuItem.Text = "Pausar";
            this.pausarMenuItem.Visible = false;
            this.pausarMenuItem.Click += new System.EventHandler(this.pausarJoc_Click);
            // 
            // reiniciarMenuItem
            // 
            this.reiniciarMenuItem.Name = "reiniciarMenuItem";
            this.reiniciarMenuItem.Size = new System.Drawing.Size(119, 22);
            this.reiniciarMenuItem.Text = "Reiniciar";
            this.reiniciarMenuItem.Visible = false;
            this.reiniciarMenuItem.Click += new System.EventHandler(this.reiniciarJoc_Click);
            // 
            // pararMenuItem
            // 
            this.pararMenuItem.Name = "pararMenuItem";
            this.pararMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pararMenuItem.Text = "Parar";
            this.pararMenuItem.Visible = false;
            this.pararMenuItem.Click += new System.EventHandler(this.pararJoc_Click);
            // 
            // dificultatMenuItem
            // 
            this.dificultatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilMenuItem,
            this.intermigMenuItem,
            this.dificilMenuItem});
            this.dificultatMenuItem.Name = "dificultatMenuItem";
            this.dificultatMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dificultatMenuItem.Text = "Dificultat";
            // 
            // facilMenuItem
            // 
            this.facilMenuItem.CheckOnClick = true;
            this.facilMenuItem.Image = global::PokeCatch.Properties.Resources.pokeball;
            this.facilMenuItem.Name = "facilMenuItem";
            this.facilMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facilMenuItem.Text = "Fàcil";
            this.facilMenuItem.Click += new System.EventHandler(this.facilMenuItem_Click);
            // 
            // intermigMenuItem
            // 
            this.intermigMenuItem.CheckOnClick = true;
            this.intermigMenuItem.Image = global::PokeCatch.Properties.Resources.superball;
            this.intermigMenuItem.Name = "intermigMenuItem";
            this.intermigMenuItem.Size = new System.Drawing.Size(180, 22);
            this.intermigMenuItem.Text = "Intermig";
            this.intermigMenuItem.Click += new System.EventHandler(this.intermigMenuItem_Click);
            // 
            // dificilMenuItem
            // 
            this.dificilMenuItem.CheckOnClick = true;
            this.dificilMenuItem.Image = global::PokeCatch.Properties.Resources.ultraball;
            this.dificilMenuItem.Name = "dificilMenuItem";
            this.dificilMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dificilMenuItem.Text = "Difícil";
            this.dificilMenuItem.Click += new System.EventHandler(this.dificilMenuItem_Click);
            // 
            // ajudaMenuItem
            // 
            this.ajudaMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quiSomMenuItem});
            this.ajudaMenuItem.Name = "ajudaMenuItem";
            this.ajudaMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaMenuItem.Text = "Ajuda";
            // 
            // quiSomMenuItem
            // 
            this.quiSomMenuItem.Name = "quiSomMenuItem";
            this.quiSomMenuItem.Size = new System.Drawing.Size(124, 22);
            this.quiSomMenuItem.Text = "Qui som?";
            this.quiSomMenuItem.Click += new System.EventHandler(this.quiSomMenuItem_Click);
            // 
            // pbPokemon1
            // 
            this.pbPokemon1.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon1.BackgroundImage = global::PokeCatch.Properties.Resources.Pikachu;
            this.pbPokemon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPokemon1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbPokemon1.Location = new System.Drawing.Point(786, 446);
            this.pbPokemon1.MaximumSize = new System.Drawing.Size(78, 102);
            this.pbPokemon1.MinimumSize = new System.Drawing.Size(78, 102);
            this.pbPokemon1.Name = "pbPokemon1";
            this.pbPokemon1.Size = new System.Drawing.Size(78, 102);
            this.pbPokemon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokemon1.TabIndex = 1;
            this.pbPokemon1.TabStop = false;
            this.pbPokemon1.Visible = false;
            this.pbPokemon1.Click += new System.EventHandler(this.pbPpokemon1_Click);
            // 
            // pbPokemon2
            // 
            this.pbPokemon2.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon2.BackgroundImage = global::PokeCatch.Properties.Resources.Charmander;
            this.pbPokemon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPokemon2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbPokemon2.Location = new System.Drawing.Point(63, 184);
            this.pbPokemon2.Name = "pbPokemon2";
            this.pbPokemon2.Size = new System.Drawing.Size(78, 102);
            this.pbPokemon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokemon2.TabIndex = 2;
            this.pbPokemon2.TabStop = false;
            this.pbPokemon2.Visible = false;
            this.pbPokemon2.Click += new System.EventHandler(this.pbPokemon2_Click);
            // 
            // comptTemps
            // 
            this.comptTemps.Interval = 1000;
            this.comptTemps.Tick += new System.EventHandler(this.comptTemps_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Green;
            this.lblTime.Location = new System.Drawing.Point(928, 571);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(44, 31);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "60";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Visible = false;
            // 
            // lblPunts
            // 
            this.lblPunts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPunts.AutoSize = true;
            this.lblPunts.BackColor = System.Drawing.Color.Transparent;
            this.lblPunts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunts.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPunts.Location = new System.Drawing.Point(12, 571);
            this.lblPunts.Name = "lblPunts";
            this.lblPunts.Size = new System.Drawing.Size(29, 31);
            this.lblPunts.TabIndex = 8;
            this.lblPunts.Text = "0";
            this.lblPunts.Visible = false;
            // 
            // pbPokeball
            // 
            this.pbPokeball.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPokeball.BackColor = System.Drawing.Color.Transparent;
            this.pbPokeball.BackgroundImage = global::PokeCatch.Properties.Resources.pokeball;
            this.pbPokeball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPokeball.Location = new System.Drawing.Point(799, 548);
            this.pbPokeball.Name = "pbPokeball";
            this.pbPokeball.Size = new System.Drawing.Size(85, 72);
            this.pbPokeball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokeball.TabIndex = 9;
            this.pbPokeball.TabStop = false;
            this.pbPokeball.Visible = false;
            // 
            // comptImatge1
            // 
            this.comptImatge1.Interval = 3000;
            this.comptImatge1.Tick += new System.EventHandler(this.comptImatge1_Tick);
            // 
            // comptImatge2
            // 
            this.comptImatge2.Interval = 1500;
            this.comptImatge2.Tick += new System.EventHandler(this.comptImatge2_Tick);
            // 
            // pbPlay
            // 
            this.pbPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay.BackgroundImage = global::PokeCatch.Properties.Resources.play;
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Location = new System.Drawing.Point(468, 512);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(81, 89);
            this.pbPlay.TabIndex = 13;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.novaPartida_Click);
            // 
            // btnPlayPauseMenu
            // 
            this.btnPlayPauseMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayPauseMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPlayPauseMenu.BackgroundImage = global::PokeCatch.Properties.Resources.pause;
            this.btnPlayPauseMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayPauseMenu.FlatAppearance.BorderSize = 0;
            this.btnPlayPauseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPauseMenu.Location = new System.Drawing.Point(889, 0);
            this.btnPlayPauseMenu.Name = "btnPlayPauseMenu";
            this.btnPlayPauseMenu.Size = new System.Drawing.Size(33, 23);
            this.btnPlayPauseMenu.TabIndex = 14;
            this.btnPlayPauseMenu.UseVisualStyleBackColor = false;
            this.btnPlayPauseMenu.Visible = false;
            this.btnPlayPauseMenu.Click += new System.EventHandler(this.pausarJoc_Click);
            // 
            // btnPlayMenu
            // 
            this.btnPlayMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPlayMenu.BackgroundImage = global::PokeCatch.Properties.Resources.play_menu;
            this.btnPlayMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayMenu.FlatAppearance.BorderSize = 0;
            this.btnPlayMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMenu.Location = new System.Drawing.Point(889, 0);
            this.btnPlayMenu.Name = "btnPlayMenu";
            this.btnPlayMenu.Size = new System.Drawing.Size(33, 23);
            this.btnPlayMenu.TabIndex = 15;
            this.btnPlayMenu.UseVisualStyleBackColor = false;
            this.btnPlayMenu.Click += new System.EventHandler(this.novaPartida_Click);
            // 
            // btnStopMenu
            // 
            this.btnStopMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnStopMenu.BackgroundImage = global::PokeCatch.Properties.Resources.stop;
            this.btnStopMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopMenu.FlatAppearance.BorderSize = 0;
            this.btnStopMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMenu.Location = new System.Drawing.Point(850, 0);
            this.btnStopMenu.Name = "btnStopMenu";
            this.btnStopMenu.Size = new System.Drawing.Size(33, 23);
            this.btnStopMenu.TabIndex = 16;
            this.btnStopMenu.UseVisualStyleBackColor = false;
            this.btnStopMenu.Visible = false;
            this.btnStopMenu.Click += new System.EventHandler(this.pararJoc_Click);
            // 
            // btnRestartMenu
            // 
            this.btnRestartMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRestartMenu.BackgroundImage = global::PokeCatch.Properties.Resources.restart;
            this.btnRestartMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestartMenu.FlatAppearance.BorderSize = 0;
            this.btnRestartMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartMenu.Location = new System.Drawing.Point(812, 0);
            this.btnRestartMenu.Name = "btnRestartMenu";
            this.btnRestartMenu.Size = new System.Drawing.Size(33, 23);
            this.btnRestartMenu.TabIndex = 17;
            this.btnRestartMenu.UseVisualStyleBackColor = false;
            this.btnRestartMenu.Visible = false;
            this.btnRestartMenu.Click += new System.EventHandler(this.reiniciarJoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "© Mark Ruiz";
            // 
            // FormJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PokeCatch.Properties.Resources.Pokemon_Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestartMenu);
            this.Controls.Add(this.btnStopMenu);
            this.Controls.Add(this.btnPlayMenu);
            this.Controls.Add(this.btnPlayPauseMenu);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.pbPokeball);
            this.Controls.Add(this.lblPunts);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbPokemon2);
            this.Controls.Add(this.pbPokemon1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormJoc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gotta catch \'em all!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partidaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPartidaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificultatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificilMenuItem;
        private System.Windows.Forms.PictureBox pbPokemon1;
        private System.Windows.Forms.PictureBox pbPokemon2;
        private System.Windows.Forms.Timer comptTemps;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPunts;
        private System.Windows.Forms.PictureBox pbPokeball;
        private System.Windows.Forms.Timer comptImatge1;
        private System.Windows.Forms.Timer comptImatge2;
        private System.Windows.Forms.ToolStripMenuItem ajudaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiSomMenuItem;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.Button btnPlayPauseMenu;
        private System.Windows.Forms.Button btnPlayMenu;
        private System.Windows.Forms.Button btnStopMenu;
        private System.Windows.Forms.Button btnRestartMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip infoBTN;
    }
}