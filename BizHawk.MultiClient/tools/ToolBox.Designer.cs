﻿namespace BizHawk.MultiClient
{
    partial class ToolBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBox));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.HexEditor = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.NESDebugger = new System.Windows.Forms.ToolStripButton();
			this.NESPPU = new System.Windows.Forms.ToolStripButton();
			this.NESNameTable = new System.Windows.Forms.ToolStripButton();
			this.NESGameGenie = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.HexEditor,
            this.toolStripButton5,
            this.NESDebugger,
            this.NESPPU,
            this.NESNameTable,
            this.NESGameGenie,
            this.toolStripButton6});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.toolStrip1.Location = new System.Drawing.Point(9, 27);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(86, 272);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.TabStop = true;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::BizHawk.MultiClient.Properties.Resources.Freeze;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(61, 20);
			this.toolStripButton1.Text = "Cheats";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = global::BizHawk.MultiClient.Properties.Resources.FindHS;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(82, 20);
			this.toolStripButton2.Text = "Ram Watch";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Image = global::BizHawk.MultiClient.Properties.Resources.search;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(84, 20);
			this.toolStripButton3.Text = "Ram Search";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Image = global::BizHawk.MultiClient.Properties.Resources.poke;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(74, 20);
			this.toolStripButton4.Text = "Ram Poke";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
			// 
			// HexEditor
			// 
			this.HexEditor.Image = global::BizHawk.MultiClient.Properties.Resources.poke;
			this.HexEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.HexEditor.Name = "HexEditor";
			this.HexEditor.Size = new System.Drawing.Size(77, 20);
			this.HexEditor.Text = "Hex Editor";
			this.HexEditor.Click += new System.EventHandler(this.HexEditor_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.Image = global::BizHawk.MultiClient.Properties.Resources.textdoc;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(85, 20);
			this.toolStripButton5.Text = "Lua Console";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
			// 
			// NESDebugger
			// 
			this.NESDebugger.Image = global::BizHawk.MultiClient.Properties.Resources.NESControllerIcon;
			this.NESDebugger.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NESDebugger.Name = "NESDebugger";
			this.NESDebugger.Size = new System.Drawing.Size(74, 20);
			this.NESDebugger.Text = "Debugger";
			this.NESDebugger.Click += new System.EventHandler(this.NESDebugger_Click);
			// 
			// NESPPU
			// 
			this.NESPPU.Image = global::BizHawk.MultiClient.Properties.Resources.NESControllerIcon;
			this.NESPPU.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NESPPU.Name = "NESPPU";
			this.NESPPU.Size = new System.Drawing.Size(46, 20);
			this.NESPPU.Text = "PPU";
			this.NESPPU.Click += new System.EventHandler(this.NESPPU_Click);
			// 
			// NESNameTable
			// 
			this.NESNameTable.Image = global::BizHawk.MultiClient.Properties.Resources.NESControllerIcon;
			this.NESNameTable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NESNameTable.Name = "NESNameTable";
			this.NESNameTable.Size = new System.Drawing.Size(78, 20);
			this.NESNameTable.Text = "Nametable";
			this.NESNameTable.Click += new System.EventHandler(this.NESNameTable_Click);
			// 
			// NESGameGenie
			// 
			this.NESGameGenie.Image = global::BizHawk.MultiClient.Properties.Resources.NESControllerIcon;
			this.NESGameGenie.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NESGameGenie.Name = "NESGameGenie";
			this.NESGameGenie.Size = new System.Drawing.Size(84, 20);
			this.NESGameGenie.Text = "Game Genie";
			this.NESGameGenie.Click += new System.EventHandler(this.NESGameGenie_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.Image = global::BizHawk.MultiClient.Properties.Resources.calculator;
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(63, 20);
			this.toolStripButton6.Text = "Keypad";
			this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
			// 
			// ToolBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(123, 297);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ToolBox";
			this.Text = "Tool Box";
			this.Load += new System.EventHandler(this.ToolBox_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton HexEditor;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton NESPPU;
        private System.Windows.Forms.ToolStripButton NESDebugger;
        private System.Windows.Forms.ToolStripButton NESGameGenie;
        private System.Windows.Forms.ToolStripButton NESNameTable;
        private System.Windows.Forms.ToolStripButton toolStripButton6;

    }
}