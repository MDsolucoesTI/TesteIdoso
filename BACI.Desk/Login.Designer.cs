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
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.userGroup = new System.Windows.Forms.GroupBox();
      this.userName = new System.Windows.Forms.TextBox();
      this.passGroup = new System.Windows.Forms.GroupBox();
      this.password = new System.Windows.Forms.TextBox();
      this.btnLogout = new Syncfusion.Windows.Forms.ButtonAdv();
      this.btnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
      this.userGroup.SuspendLayout();
      this.passGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // userGroup
      // 
      this.userGroup.Controls.Add(this.userName);
      this.userGroup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userGroup.Location = new System.Drawing.Point(12, 12);
      this.userGroup.Name = "userGroup";
      this.userGroup.Size = new System.Drawing.Size(225, 60);
      this.userGroup.TabIndex = 0;
      this.userGroup.TabStop = false;
      this.userGroup.Text = " Nome do Usu�rio ";
      // 
      // userName
      // 
      this.userName.ForeColor = System.Drawing.Color.Navy;
      this.userName.Location = new System.Drawing.Point(7, 26);
      this.userName.Name = "userName";
      this.userName.Size = new System.Drawing.Size(212, 26);
      this.userName.TabIndex = 0;
      // 
      // passGroup
      // 
      this.passGroup.Controls.Add(this.password);
      this.passGroup.Location = new System.Drawing.Point(12, 78);
      this.passGroup.Name = "passGroup";
      this.passGroup.Size = new System.Drawing.Size(225, 60);
      this.passGroup.TabIndex = 1;
      this.passGroup.TabStop = false;
      this.passGroup.Text = " Senha ";
      // 
      // password
      // 
      this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.password.ForeColor = System.Drawing.Color.Navy;
      this.password.Location = new System.Drawing.Point(7, 20);
      this.password.Name = "password";
      this.password.Size = new System.Drawing.Size(212, 26);
      this.password.TabIndex = 0;
      this.password.UseSystemPasswordChar = true;
      // 
      // btnLogout
      // 
      this.btnLogout.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnLogout.BackColor = System.Drawing.Color.Thistle;
      this.btnLogout.BackgroundImage = global::BACI.Desk.Properties.Resources.Logout;
      this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLogout.BeforeTouchSize = new System.Drawing.Size(48, 48);
      this.btnLogout.ForeColor = System.Drawing.Color.White;
      this.btnLogout.IsBackStageButton = false;
      this.btnLogout.Location = new System.Drawing.Point(268, 85);
      this.btnLogout.MetroColor = System.Drawing.Color.MediumSeaGreen;
      this.btnLogout.Name = "btnLogout";
      this.btnLogout.Size = new System.Drawing.Size(48, 48);
      this.btnLogout.TabIndex = 3;
      this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
      // 
      // btnLogin
      // 
      this.btnLogin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
      this.btnLogin.BackColor = System.Drawing.Color.Honeydew;
      this.btnLogin.BackgroundImage = global::BACI.Desk.Properties.Resources.Login;
      this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLogin.BeforeTouchSize = new System.Drawing.Size(48, 48);
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.IsBackStageButton = false;
      this.btnLogin.Location = new System.Drawing.Point(268, 22);
      this.btnLogin.MetroColor = System.Drawing.Color.MediumSeaGreen;
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(48, 48);
      this.btnLogin.TabIndex = 2;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CaptionBarColor = System.Drawing.Color.MediumSeaGreen;
      this.CaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CaptionForeColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(338, 163);
      this.ControlBox = false;
      this.Controls.Add(this.btnLogout);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.passGroup);
      this.Controls.Add(this.userGroup);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(350, 200);
      this.MetroColor = System.Drawing.Color.MediumSeaGreen;
      this.MinimumSize = new System.Drawing.Size(350, 200);
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Entrada do Sistema";
      this.userGroup.ResumeLayout(false);
      this.userGroup.PerformLayout();
      this.passGroup.ResumeLayout(false);
      this.passGroup.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox userGroup;
    private System.Windows.Forms.GroupBox passGroup;
    private Syncfusion.Windows.Forms.ButtonAdv btnLogin;
    private Syncfusion.Windows.Forms.ButtonAdv btnLogout;
    private System.Windows.Forms.TextBox password;
    public System.Windows.Forms.TextBox userName;
  }
}