namespace TowerOfHanoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfPiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threePiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourPiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fivePiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sixPiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevenPiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pole1Label = new System.Windows.Forms.Label();
            this.pole2Label = new System.Windows.Forms.Label();
            this.pole3Label = new System.Windows.Forms.Label();
            this.piece1Label = new System.Windows.Forms.Label();
            this.piece2Label = new System.Windows.Forms.Label();
            this.piece3Label = new System.Windows.Forms.Label();
            this.piece4Label = new System.Windows.Forms.Label();
            this.piece5Label = new System.Windows.Forms.Label();
            this.piece6Label = new System.Windows.Forms.Label();
            this.piece7Label = new System.Windows.Forms.Label();
            this.movesLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.numberOfPiecesToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // numberOfPiecesToolStripMenuItem
            // 
            this.numberOfPiecesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threePiecesToolStripMenuItem,
            this.fourPiecesToolStripMenuItem,
            this.fivePiecesToolStripMenuItem,
            this.sixPiecesToolStripMenuItem,
            this.sevenPiecesToolStripMenuItem});
            this.numberOfPiecesToolStripMenuItem.Name = "numberOfPiecesToolStripMenuItem";
            this.numberOfPiecesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numberOfPiecesToolStripMenuItem.Text = "Number of Pieces";
            // 
            // threePiecesToolStripMenuItem
            // 
            this.threePiecesToolStripMenuItem.Name = "threePiecesToolStripMenuItem";
            this.threePiecesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.threePiecesToolStripMenuItem.Text = "Three";
            this.threePiecesToolStripMenuItem.Click += new System.EventHandler(this.ThreePiecesToolStripMenuItem_Click);
            // 
            // fourPiecesToolStripMenuItem
            // 
            this.fourPiecesToolStripMenuItem.Name = "fourPiecesToolStripMenuItem";
            this.fourPiecesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fourPiecesToolStripMenuItem.Text = "Four";
            this.fourPiecesToolStripMenuItem.Click += new System.EventHandler(this.FourPiecesToolStripMenuItem_Click);
            // 
            // fivePiecesToolStripMenuItem
            // 
            this.fivePiecesToolStripMenuItem.Name = "fivePiecesToolStripMenuItem";
            this.fivePiecesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fivePiecesToolStripMenuItem.Text = "Five";
            this.fivePiecesToolStripMenuItem.Click += new System.EventHandler(this.FivePiecesToolStripMenuItem_Click);
            // 
            // sixPiecesToolStripMenuItem
            // 
            this.sixPiecesToolStripMenuItem.Name = "sixPiecesToolStripMenuItem";
            this.sixPiecesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sixPiecesToolStripMenuItem.Text = "Six";
            this.sixPiecesToolStripMenuItem.Click += new System.EventHandler(this.SixPiecesToolStripMenuItem_Click);
            // 
            // sevenPiecesToolStripMenuItem
            // 
            this.sevenPiecesToolStripMenuItem.Name = "sevenPiecesToolStripMenuItem";
            this.sevenPiecesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sevenPiecesToolStripMenuItem.Text = "Seven";
            this.sevenPiecesToolStripMenuItem.Click += new System.EventHandler(this.SevenPiecesToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.RulesToolStripMenuItem_Click);
            // 
            // pole1Label
            // 
            this.pole1Label.BackColor = System.Drawing.Color.Peru;
            this.pole1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pole1Label.Location = new System.Drawing.Point(140, 160);
            this.pole1Label.Name = "pole1Label";
            this.pole1Label.Size = new System.Drawing.Size(20, 180);
            this.pole1Label.TabIndex = 0;
            // 
            // pole2Label
            // 
            this.pole2Label.BackColor = System.Drawing.Color.Peru;
            this.pole2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pole2Label.Location = new System.Drawing.Point(380, 160);
            this.pole2Label.Name = "pole2Label";
            this.pole2Label.Size = new System.Drawing.Size(20, 180);
            this.pole2Label.TabIndex = 0;
            // 
            // pole3Label
            // 
            this.pole3Label.BackColor = System.Drawing.Color.Peru;
            this.pole3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pole3Label.Location = new System.Drawing.Point(620, 160);
            this.pole3Label.Name = "pole3Label";
            this.pole3Label.Size = new System.Drawing.Size(20, 180);
            this.pole3Label.TabIndex = 0;
            // 
            // piece1Label
            // 
            this.piece1Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece1Label.Location = new System.Drawing.Point(894, 269);
            this.piece1Label.Name = "piece1Label";
            this.piece1Label.Size = new System.Drawing.Size(200, 20);
            this.piece1Label.TabIndex = 0;
            this.piece1Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece1Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece1Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // piece2Label
            // 
            this.piece2Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece2Label.Location = new System.Drawing.Point(904, 249);
            this.piece2Label.Name = "piece2Label";
            this.piece2Label.Size = new System.Drawing.Size(180, 20);
            this.piece2Label.TabIndex = 0;
            this.piece2Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece2Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece2Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // piece3Label
            // 
            this.piece3Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece3Label.Location = new System.Drawing.Point(914, 229);
            this.piece3Label.Name = "piece3Label";
            this.piece3Label.Size = new System.Drawing.Size(160, 20);
            this.piece3Label.TabIndex = 0;
            this.piece3Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece3Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece3Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // piece4Label
            // 
            this.piece4Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece4Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece4Label.Location = new System.Drawing.Point(924, 209);
            this.piece4Label.Name = "piece4Label";
            this.piece4Label.Size = new System.Drawing.Size(140, 20);
            this.piece4Label.TabIndex = 0;
            this.piece4Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece4Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece4Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // piece5Label
            // 
            this.piece5Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece5Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece5Label.Location = new System.Drawing.Point(935, 189);
            this.piece5Label.Name = "piece5Label";
            this.piece5Label.Size = new System.Drawing.Size(120, 20);
            this.piece5Label.TabIndex = 0;
            this.piece5Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece5Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece5Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // piece6Label
            // 
            this.piece6Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece6Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece6Label.Location = new System.Drawing.Point(946, 169);
            this.piece6Label.Name = "piece6Label";
            this.piece6Label.Size = new System.Drawing.Size(100, 20);
            this.piece6Label.TabIndex = 0;
            this.piece6Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece6Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece6Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // piece7Label
            // 
            this.piece7Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.piece7Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piece7Label.Location = new System.Drawing.Point(955, 149);
            this.piece7Label.Name = "piece7Label";
            this.piece7Label.Size = new System.Drawing.Size(80, 20);
            this.piece7Label.TabIndex = 0;
            this.piece7Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseDown);
            this.piece7Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseMove);
            this.piece7Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pieces_MouseUp);
            // 
            // movesLabel
            // 
            this.movesLabel.BackColor = System.Drawing.Color.Transparent;
            this.movesLabel.Font = new System.Drawing.Font("Segoe UI", 240F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.movesLabel.Location = new System.Drawing.Point(0, -53);
            this.movesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(812, 393);
            this.movesLabel.TabIndex = 0;
            this.movesLabel.Text = "0";
            this.movesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.timerLabel.Location = new System.Drawing.Point(634, 24);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(118, 43);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(764, 340);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.piece7Label);
            this.Controls.Add(this.piece6Label);
            this.Controls.Add(this.piece5Label);
            this.Controls.Add(this.piece4Label);
            this.Controls.Add(this.piece3Label);
            this.Controls.Add(this.piece2Label);
            this.Controls.Add(this.piece1Label);
            this.Controls.Add(this.pole3Label);
            this.Controls.Add(this.pole2Label);
            this.Controls.Add(this.pole1Label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.movesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 379);
            this.MinimumSize = new System.Drawing.Size(780, 379);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Of Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfPiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threePiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourPiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fivePiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sixPiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sevenPiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.Label pole1Label;
        private System.Windows.Forms.Label pole2Label;
        private System.Windows.Forms.Label pole3Label;
        private System.Windows.Forms.Label piece1Label;
        private System.Windows.Forms.Label piece2Label;
        private System.Windows.Forms.Label piece3Label;
        private System.Windows.Forms.Label piece4Label;
        private System.Windows.Forms.Label piece5Label;
        private System.Windows.Forms.Label piece6Label;
        private System.Windows.Forms.Label piece7Label;
        private System.Windows.Forms.Label movesLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

