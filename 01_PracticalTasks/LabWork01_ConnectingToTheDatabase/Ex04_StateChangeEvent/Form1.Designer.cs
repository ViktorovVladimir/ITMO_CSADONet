﻿namespace Ex04_StateChangeEvent
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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
        this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 33);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "Menu";
        // 
        // menuToolStripMenuItem
        // 
        this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
        this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
        this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
        this.menuToolStripMenuItem.Text = "Menu";
        // 
        // connectToolStripMenuItem
        // 
        this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
        this.connectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        this.connectToolStripMenuItem.Text = "Connect";
        this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
        // 
        // disconnectToolStripMenuItem
        // 
        this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
        this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
        this.disconnectToolStripMenuItem.Text = "Disconnect";
        this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "Form1";
        this.Text = "Form1";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
}
}

