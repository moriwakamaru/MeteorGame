﻿namespace MeteorGame
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pTitle = new System.Windows.Forms.PictureBox();
            this.pPlayer = new System.Windows.Forms.PictureBox();
            this.pMsg = new System.Windows.Forms.PictureBox();
            this.pGameover = new System.Windows.Forms.PictureBox();
            this.pExp = new System.Windows.Forms.PictureBox();
            this.pBase = new System.Windows.Forms.PictureBox();
            this.pMeteor = new System.Windows.Forms.PictureBox();
            this.pBG = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.Image = global::MeteorGame.Properties.Resources.p_title;
            this.pTitle.Location = new System.Drawing.Point(68, 157);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(100, 50);
            this.pTitle.TabIndex = 8;
            this.pTitle.TabStop = false;
            // 
            // pPlayer
            // 
            this.pPlayer.Image = global::MeteorGame.Properties.Resources.p_player;
            this.pPlayer.Location = new System.Drawing.Point(86, 32);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(100, 50);
            this.pPlayer.TabIndex = 7;
            this.pPlayer.TabStop = false;
            // 
            // pMsg
            // 
            this.pMsg.Image = global::MeteorGame.Properties.Resources.p_msg;
            this.pMsg.Location = new System.Drawing.Point(258, 200);
            this.pMsg.Name = "pMsg";
            this.pMsg.Size = new System.Drawing.Size(100, 50);
            this.pMsg.TabIndex = 6;
            this.pMsg.TabStop = false;
            // 
            // pGameover
            // 
            this.pGameover.Image = global::MeteorGame.Properties.Resources.p_gameover;
            this.pGameover.Location = new System.Drawing.Point(128, 176);
            this.pGameover.Name = "pGameover";
            this.pGameover.Size = new System.Drawing.Size(100, 50);
            this.pGameover.TabIndex = 4;
            this.pGameover.TabStop = false;
            // 
            // pExp
            // 
            this.pExp.Image = global::MeteorGame.Properties.Resources.p_explosion;
            this.pExp.Location = new System.Drawing.Point(175, 88);
            this.pExp.Name = "pExp";
            this.pExp.Size = new System.Drawing.Size(100, 50);
            this.pExp.TabIndex = 3;
            this.pExp.TabStop = false;
            // 
            // pBase
            // 
            this.pBase.Location = new System.Drawing.Point(-31, -9);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(548, 353);
            this.pBase.TabIndex = 2;
            this.pBase.TabStop = false;
            this.pBase.Click += new System.EventHandler(this.pBase_Click);
            // 
            // pMeteor
            // 
            this.pMeteor.Image = global::MeteorGame.Properties.Resources.p_meteor;
            this.pMeteor.Location = new System.Drawing.Point(323, 72);
            this.pMeteor.Name = "pMeteor";
            this.pMeteor.Size = new System.Drawing.Size(71, 73);
            this.pMeteor.TabIndex = 1;
            this.pMeteor.TabStop = false;
            // 
            // pBG
            // 
            this.pBG.Image = global::MeteorGame.Properties.Resources.p_bg;
            this.pBG.Location = new System.Drawing.Point(-70, -52);
            this.pBG.Name = "pBG";
            this.pBG.Size = new System.Drawing.Size(345, 222);
            this.pBG.TabIndex = 0;
            this.pBG.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.pMsg);
            this.Controls.Add(this.pGameover);
            this.Controls.Add(this.pExp);
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.pMeteor);
            this.Controls.Add(this.pBG);
            this.Name = "Form1";
            this.Text = "MeteorGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBG;
        private System.Windows.Forms.PictureBox pMeteor;
        private System.Windows.Forms.PictureBox pBase;
        private System.Windows.Forms.PictureBox pExp;
        private System.Windows.Forms.PictureBox pGameover;
        private System.Windows.Forms.PictureBox pMsg;
        private System.Windows.Forms.PictureBox pPlayer;
        private System.Windows.Forms.PictureBox pTitle;
        private System.Windows.Forms.Timer timer1;
    }
}

