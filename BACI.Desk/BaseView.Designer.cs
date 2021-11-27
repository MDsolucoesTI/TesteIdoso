//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BACI.Desk
{
  partial class BaseView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseView));
      this.statusBar = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
      this.statusBarUser = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
      this.statusBarDate = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
      ((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
      this.statusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarUser)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarDate)).BeginInit();
      this.SuspendLayout();
      // 
      // statusBar
      // 
      this.statusBar.BeforeTouchSize = new System.Drawing.Size(988, 30);
      this.statusBar.Controls.Add(this.statusBarUser);
      this.statusBar.Controls.Add(this.statusBarDate);
      this.statusBar.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
      this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.statusBar.Location = new System.Drawing.Point(0, 663);
      this.statusBar.Name = "statusBar";
      this.statusBar.Padding = new System.Windows.Forms.Padding(3);
      this.statusBar.Size = new System.Drawing.Size(988, 30);
      this.statusBar.Spacing = new System.Drawing.Size(2, 2);
      this.statusBar.TabIndex = 0;
      // 
      // statusBarUser
      // 
      this.statusBarUser.BeforeTouchSize = new System.Drawing.Size(300, 22);
      this.statusBarUser.Location = new System.Drawing.Point(0, 2);
      this.statusBarUser.Margin = new System.Windows.Forms.Padding(0);
      this.statusBarUser.Name = "statusBarUser";
      this.statusBarUser.Size = new System.Drawing.Size(300, 22);
      this.statusBarUser.TabIndex = 0;
      this.statusBarUser.Text = null;
      // 
      // statusBarDate
      // 
      this.statusBarDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.statusBarDate.BeforeTouchSize = new System.Drawing.Size(100, 22);
      this.statusBarDate.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
      this.statusBarDate.Location = new System.Drawing.Point(867, 2);
      this.statusBarDate.Margin = new System.Windows.Forms.Padding(0);
      this.statusBarDate.Name = "statusBarDate";
      this.statusBarDate.Size = new System.Drawing.Size(100, 22);
      this.statusBarDate.TabIndex = 1;
      this.statusBarDate.Text = null;
      // 
      // BaseView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CaptionBarColor = System.Drawing.Color.MediumSeaGreen;
      this.CaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CaptionForeColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(988, 693);
      this.Controls.Add(this.statusBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(1000, 730);
      this.MetroColor = System.Drawing.Color.MediumSeaGreen;
      this.MinimumSize = new System.Drawing.Size(1000, 730);
      this.Name = "BaseView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Titulo";
      ((System.ComponentModel.ISupportInitialize)(this.statusBar)).EndInit();
      this.statusBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.statusBarUser)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarDate)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    public Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBar;
    public Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarUser;
    public Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarDate;
  }
}