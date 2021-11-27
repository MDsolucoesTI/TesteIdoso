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
  partial class Vid01View
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vid01View));
      this.VideoPlay = new AxWMPLib.AxWindowsMediaPlayer();
      ((System.ComponentModel.ISupportInitialize)(this.VideoPlay)).BeginInit();
      this.SuspendLayout();
      // 
      // VideoPlay
      // 
      this.VideoPlay.Dock = System.Windows.Forms.DockStyle.Fill;
      this.VideoPlay.Enabled = true;
      this.VideoPlay.Location = new System.Drawing.Point(0, 0);
      this.VideoPlay.Name = "VideoPlay";
      this.VideoPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlay.OcxState")));
      this.VideoPlay.Size = new System.Drawing.Size(988, 693);
      this.VideoPlay.TabIndex = 0;
      // 
      // Vid01View
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(988, 693);
      this.Controls.Add(this.VideoPlay);
      this.Name = "Vid01View";
      this.Text = "V�deo 01";
      this.Load += new System.EventHandler(this.Vid01View_Load);
      ((System.ComponentModel.ISupportInitialize)(this.VideoPlay)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    public AxWMPLib.AxWindowsMediaPlayer VideoPlay;
  }
}