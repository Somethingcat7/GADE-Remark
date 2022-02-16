
namespace Hein_Kroese_GADE6112_POE
{
    partial class frmGame
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
            this.lblMap = new System.Windows.Forms.Label();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblAttackNotif = new System.Windows.Forms.Label();
            this.cmbEnemies = new System.Windows.Forms.ComboBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShop1 = new System.Windows.Forms.Button();
            this.btnShop2 = new System.Windows.Forms.Button();
            this.btnShop3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(428, 9);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(177, 170);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "XXXXXXXXXXXXXX\r\nX......G.....X\r\nX......G.....X\r\nX............X\r\nX....G.G.....X\r\nX" +
    ".....GH.....X\r\nX............X\r\nXXXXXXXXXXXXXX ";
            this.lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeroStats.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroStats.Location = new System.Drawing.Point(12, 9);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(140, 20);
            this.lblHeroStats.TabIndex = 1;
            this.lblHeroStats.Text = "{Placeholder}";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(184, 213);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(12, 248);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 30);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Left";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(184, 248);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 30);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Right";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(93, 284);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(85, 30);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "Down";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(93, 213);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(85, 29);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "Up";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(93, 248);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(85, 30);
            this.btnAttack.TabIndex = 9;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblAttackNotif
            // 
            this.lblAttackNotif.AutoSize = true;
            this.lblAttackNotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttackNotif.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackNotif.Location = new System.Drawing.Point(167, 9);
            this.lblAttackNotif.Name = "lblAttackNotif";
            this.lblAttackNotif.Size = new System.Drawing.Size(140, 20);
            this.lblAttackNotif.TabIndex = 10;
            this.lblAttackNotif.Text = "{Placeholder}";
            this.lblAttackNotif.Visible = false;
            this.lblAttackNotif.Click += new System.EventHandler(this.lblAttackNotif_Click);
            // 
            // cmbEnemies
            // 
            this.cmbEnemies.FormattingEnabled = true;
            this.cmbEnemies.Location = new System.Drawing.Point(12, 139);
            this.cmbEnemies.Name = "cmbEnemies";
            this.cmbEnemies.Size = new System.Drawing.Size(285, 22);
            this.cmbEnemies.TabIndex = 11;
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(12, 185);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(285, 22);
            this.cmbItems.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enemies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Items";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Shop";
            // 
            // btnShop1
            // 
            this.btnShop1.Location = new System.Drawing.Point(12, 350);
            this.btnShop1.Name = "btnShop1";
            this.btnShop1.Size = new System.Drawing.Size(75, 23);
            this.btnShop1.TabIndex = 16;
            this.btnShop1.Text = "Buy";
            this.btnShop1.UseVisualStyleBackColor = true;
            this.btnShop1.Click += new System.EventHandler(this.btnShop1_Click);
            // 
            // btnShop2
            // 
            this.btnShop2.Location = new System.Drawing.Point(93, 350);
            this.btnShop2.Name = "btnShop2";
            this.btnShop2.Size = new System.Drawing.Size(75, 23);
            this.btnShop2.TabIndex = 16;
            this.btnShop2.Text = "Buy";
            this.btnShop2.UseVisualStyleBackColor = true;
            this.btnShop2.Click += new System.EventHandler(this.btnShop2_Click);
            // 
            // btnShop3
            // 
            this.btnShop3.Location = new System.Drawing.Point(174, 350);
            this.btnShop3.Name = "btnShop3";
            this.btnShop3.Size = new System.Drawing.Size(75, 23);
            this.btnShop3.TabIndex = 16;
            this.btnShop3.Text = "Buy";
            this.btnShop3.UseVisualStyleBackColor = true;
            this.btnShop3.Click += new System.EventHandler(this.btnShop3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(184, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(12, 284);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 29);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 440);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShop3);
            this.Controls.Add(this.btnShop2);
            this.Controls.Add(this.btnShop1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.cmbEnemies);
            this.Controls.Add(this.lblHeroStats);
            this.Controls.Add(this.lblAttackNotif);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMap);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblHeroStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblAttackNotif;
        private System.Windows.Forms.ComboBox cmbEnemies;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShop1;
        private System.Windows.Forms.Button btnShop2;
        private System.Windows.Forms.Button btnShop3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
    }
}

