﻿using Topping.Core.Proxy.Local.Client;
using TopMachine.Desktop.Controls.Sound;
namespace TopMachine.Topping.Frontend
{
    partial class ToppingRooms
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
            base.Dispose(disposing);

            if (disposing && (components != null))
            {
                components.Dispose();

                if (timer1 != null)
                {
                    timer1.Enabled = false;
                    timer1.Dispose();
                    timer1 = null;
                }
            }

        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGlobal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConfigs = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chatControl1 = new TopMachine.Topping.Frontend.Chat.ChatControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.listPlayersGlobal = new TopMachine.Topping.Frontend.Controls.ListPlayers();
            this.tabPlayersRoom = new System.Windows.Forms.TabPage();
            this.listPlayersRoom = new TopMachine.Topping.Frontend.Controls.ListPlayers();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.friendsList1 = new TopMachine.Topping.Frontend.Controls.FriendsList();
            this.configGameDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlGlobal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabPlayersRoom.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configGameDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGlobal
            // 
            this.pnlGlobal.Controls.Add(this.panel1);
            this.pnlGlobal.Controls.Add(this.splitter1);
            this.pnlGlobal.Controls.Add(this.tabControl1);
            this.pnlGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlobal.Location = new System.Drawing.Point(0, 0);
            this.pnlGlobal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGlobal.Name = "pnlGlobal";
            this.pnlGlobal.Size = new System.Drawing.Size(1108, 602);
            this.pnlGlobal.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlConfigs);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 602);
            this.panel1.TabIndex = 10;
            // 
            // pnlConfigs
            // 
            this.pnlConfigs.AutoScroll = true;
            this.pnlConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfigs.Location = new System.Drawing.Point(0, 32);
            this.pnlConfigs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlConfigs.Name = "pnlConfigs";
            this.pnlConfigs.Size = new System.Drawing.Size(756, 570);
            this.pnlConfigs.TabIndex = 8;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewGame.Location = new System.Drawing.Point(0, 0);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(756, 32);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Nouvelle partie";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(756, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 602);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPlayers);
            this.tabControl1.Controls.Add(this.tabPlayersRoom);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(764, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 602);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.chatControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(336, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat";
            // 
            // chatControl1
            // 
            this.chatControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatControl1.Location = new System.Drawing.Point(4, 4);
            this.chatControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chatControl1.Name = "chatControl1";
            this.chatControl1.Size = new System.Drawing.Size(328, 562);
            this.chatControl1.TabIndex = 0;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.listPlayersGlobal);
            this.tabPlayers.Location = new System.Drawing.Point(4, 28);
            this.tabPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Size = new System.Drawing.Size(336, 570);
            this.tabPlayers.TabIndex = 1;
            this.tabPlayers.Text = "Joueurs";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // listPlayersGlobal
            // 
            this.listPlayersGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPlayersGlobal.friendsList = null;
            this.listPlayersGlobal.Location = new System.Drawing.Point(0, 0);
            this.listPlayersGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPlayersGlobal.Name = "listPlayersGlobal";
            this.listPlayersGlobal.Size = new System.Drawing.Size(333, 566);
            this.listPlayersGlobal.TabIndex = 0;
            // 
            // tabPlayersRoom
            // 
            this.tabPlayersRoom.Controls.Add(this.listPlayersRoom);
            this.tabPlayersRoom.Location = new System.Drawing.Point(4, 28);
            this.tabPlayersRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPlayersRoom.Name = "tabPlayersRoom";
            this.tabPlayersRoom.Size = new System.Drawing.Size(336, 570);
            this.tabPlayersRoom.TabIndex = 2;
            this.tabPlayersRoom.Text = "Joueurs dans la salle";
            this.tabPlayersRoom.UseVisualStyleBackColor = true;
            // 
            // listPlayersRoom
            // 
            this.listPlayersRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPlayersRoom.friendsList = null;
            this.listPlayersRoom.Location = new System.Drawing.Point(0, 0);
            this.listPlayersRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPlayersRoom.Name = "listPlayersRoom";
            this.listPlayersRoom.Size = new System.Drawing.Size(333, 566);
            this.listPlayersRoom.TabIndex = 0;
            this.listPlayersRoom.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.friendsList1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(336, 570);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Mes amis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // friendsList1
            // 
            this.friendsList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsList1.Location = new System.Drawing.Point(4, 4);
            this.friendsList1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.friendsList1.Name = "friendsList1";
            this.friendsList1.Size = new System.Drawing.Size(325, 559);
            this.friendsList1.TabIndex = 0;
            // 
            // configGameDtoBindingSource
            // 
            this.configGameDtoBindingSource.DataSource = typeof(TopMachine.Topping.Dto.ConfigGameDto);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ToppingRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGlobal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ToppingRooms";
            this.Size = new System.Drawing.Size(1108, 602);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlGlobal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayersRoom.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configGameDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource configGameDtoBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlGlobal;
        private System.Windows.Forms.Panel pnlConfigs;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Chat.ChatControl chatControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabPlayersRoom;
        private System.Windows.Forms.Timer timer1;
        private Controls.ListPlayers listPlayersGlobal;
        private Controls.ListPlayers listPlayersRoom;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.FriendsList friendsList1;
    }
}
