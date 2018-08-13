namespace AlphabetTypingGame
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.textBoxLetterInput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFastestTimeLabel = new System.Windows.Forms.Label();
            this.lblFastestTime = new System.Windows.Forms.Label();
            this.btnBackToStart = new System.Windows.Forms.Button();
            this.btnSaveToHighScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLetterInput
            // 
            this.textBoxLetterInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxLetterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxLetterInput.Location = new System.Drawing.Point(115, 132);
            this.textBoxLetterInput.MaxLength = 26;
            this.textBoxLetterInput.Name = "textBoxLetterInput";
            this.textBoxLetterInput.ShortcutsEnabled = false;
            this.textBoxLetterInput.Size = new System.Drawing.Size(377, 31);
            this.textBoxLetterInput.TabIndex = 1;
            this.textBoxLetterInput.TextChanged += new System.EventHandler(this.textBoxLetterInput_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(214, 90);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(167, 25);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Time: 00.000";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 16.125F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(133)))));
            this.btnReset.Location = new System.Drawing.Point(248, 169);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 43);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFastestTimeLabel
            // 
            this.lblFastestTimeLabel.AutoSize = true;
            this.lblFastestTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblFastestTimeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastestTimeLabel.Location = new System.Drawing.Point(405, 9);
            this.lblFastestTimeLabel.Name = "lblFastestTimeLabel";
            this.lblFastestTimeLabel.Size = new System.Drawing.Size(118, 18);
            this.lblFastestTimeLabel.TabIndex = 7;
            this.lblFastestTimeLabel.Text = "Fastest time:";
            // 
            // lblFastestTime
            // 
            this.lblFastestTime.AutoSize = true;
            this.lblFastestTime.BackColor = System.Drawing.Color.Transparent;
            this.lblFastestTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblFastestTime.Location = new System.Drawing.Point(529, 9);
            this.lblFastestTime.Name = "lblFastestTime";
            this.lblFastestTime.Size = new System.Drawing.Size(15, 18);
            this.lblFastestTime.TabIndex = 8;
            this.lblFastestTime.Text = "-";
            // 
            // btnBackToStart
            // 
            this.btnBackToStart.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBackToStart.FlatAppearance.BorderSize = 0;
            this.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToStart.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnBackToStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(133)))));
            this.btnBackToStart.Location = new System.Drawing.Point(13, 9);
            this.btnBackToStart.Name = "btnBackToStart";
            this.btnBackToStart.Size = new System.Drawing.Size(103, 25);
            this.btnBackToStart.TabIndex = 9;
            this.btnBackToStart.Text = "Back to menu";
            this.btnBackToStart.UseVisualStyleBackColor = false;
            this.btnBackToStart.Click += new System.EventHandler(this.btnBackToStart_Click);
            // 
            // btnSaveToHighScore
            // 
            this.btnSaveToHighScore.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSaveToHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToHighScore.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(133)))));
            this.btnSaveToHighScore.Location = new System.Drawing.Point(210, 218);
            this.btnSaveToHighScore.Name = "btnSaveToHighScore";
            this.btnSaveToHighScore.Size = new System.Drawing.Size(187, 32);
            this.btnSaveToHighScore.TabIndex = 10;
            this.btnSaveToHighScore.Text = "Save to High Scores";
            this.btnSaveToHighScore.UseVisualStyleBackColor = false;
            this.btnSaveToHighScore.Visible = false;
            this.btnSaveToHighScore.Click += new System.EventHandler(this.btnSaveToHighScore_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 281);
            this.Controls.Add(this.btnSaveToHighScore);
            this.Controls.Add(this.btnBackToStart);
            this.Controls.Add(this.lblFastestTime);
            this.Controls.Add(this.lblFastestTimeLabel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.textBoxLetterInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.Text = "Alphabet Typing Game";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLetterInput_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLetterInput;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFastestTimeLabel;
        private System.Windows.Forms.Label lblFastestTime;
        private System.Windows.Forms.Button btnBackToStart;
        private System.Windows.Forms.Button btnSaveToHighScore;
    }
}