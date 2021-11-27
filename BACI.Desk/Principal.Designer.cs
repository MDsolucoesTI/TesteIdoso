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
  partial class Principal
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
      this.toolStripPrincipal = new System.Windows.Forms.ToolStripContainer();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.btnCadProfissional = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.btnCadIdoso = new System.Windows.Forms.ToolStripButton();
      this.btnIniAvaliacao = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.btnSair = new System.Windows.Forms.ToolStripButton();
      this.menuPrincipal = new System.Windows.Forms.MenuStrip();
      this.mnCadastros = new System.Windows.Forms.ToolStripMenuItem();
      this.mnCadIdoso = new System.Windows.Forms.ToolStripMenuItem();
      this.mnCadProf = new System.Windows.Forms.ToolStripMenuItem();
      this.mnAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
      this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
      this.statusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarUser)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarDate)).BeginInit();
      this.toolStripPrincipal.ContentPanel.SuspendLayout();
      this.toolStripPrincipal.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.menuPrincipal.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusBar
      // 
      this.statusBar.Location = new System.Drawing.Point(0, 661);
      // 
      // toolStripPrincipal
      // 
      this.toolStripPrincipal.BottomToolStripPanelVisible = false;
      // 
      // toolStripPrincipal.ContentPanel
      // 
      this.toolStripPrincipal.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
      this.toolStripPrincipal.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.toolStripPrincipal.ContentPanel.Controls.Add(this.toolStrip1);
      this.toolStripPrincipal.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
      this.toolStripPrincipal.ContentPanel.Size = new System.Drawing.Size(988, 40);
      this.toolStripPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.toolStripPrincipal.LeftToolStripPanelVisible = false;
      this.toolStripPrincipal.Location = new System.Drawing.Point(0, 25);
      this.toolStripPrincipal.Margin = new System.Windows.Forms.Padding(0);
      this.toolStripPrincipal.Name = "toolStripPrincipal";
      this.toolStripPrincipal.RightToolStripPanelVisible = false;
      this.toolStripPrincipal.Size = new System.Drawing.Size(988, 40);
      this.toolStripPrincipal.TabIndex = 4;
      this.toolStripPrincipal.Text = "toolStripContainer1";
      this.toolStripPrincipal.TopToolStripPanelVisible = false;
      // 
      // toolStrip1
      // 
      this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadProfissional,
            this.toolStripSeparator1,
            this.btnCadIdoso,
            this.btnIniAvaliacao,
            this.toolStripSeparator2,
            this.btnSair});
      this.toolStrip1.Location = new System.Drawing.Point(1, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.toolStrip1.Size = new System.Drawing.Size(168, 39);
      this.toolStrip1.TabIndex = 0;
      // 
      // btnCadProfissional
      // 
      this.btnCadProfissional.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCadProfissional.Image = global::BACI.Desk.Properties.Resources.users;
      this.btnCadProfissional.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCadProfissional.Name = "btnCadProfissional";
      this.btnCadProfissional.Size = new System.Drawing.Size(36, 36);
      this.btnCadProfissional.ToolTipText = "Cadastro e Manuten��o de Profissionais";
      this.btnCadProfissional.Click += new System.EventHandler(this.CadProfissional);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
      // 
      // btnCadIdoso
      // 
      this.btnCadIdoso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCadIdoso.Image = global::BACI.Desk.Properties.Resources.Idosos;
      this.btnCadIdoso.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCadIdoso.Name = "btnCadIdoso";
      this.btnCadIdoso.Size = new System.Drawing.Size(36, 36);
      this.btnCadIdoso.ToolTipText = "Cadastro e Manuten��o de dados do Idoso";
      // 
      // btnIniAvaliacao
      // 
      this.btnIniAvaliacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnIniAvaliacao.Image = global::BACI.Desk.Properties.Resources.checklist;
      this.btnIniAvaliacao.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnIniAvaliacao.Name = "btnIniAvaliacao";
      this.btnIniAvaliacao.Size = new System.Drawing.Size(36, 36);
      this.btnIniAvaliacao.ToolTipText = "Efetuar uma avalia��o do idoso";
      this.btnIniAvaliacao.Click += new System.EventHandler(this.btnIniAvaliacao_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
      // 
      // btnSair
      // 
      this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSair.Image = global::BACI.Desk.Properties.Resources.Logout;
      this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(36, 36);
      this.btnSair.ToolTipText = "Deixar o Sistema BACI";
      this.btnSair.Click += new System.EventHandler(this.SairSistema);
      // 
      // menuPrincipal
      // 
      this.menuPrincipal.BackColor = System.Drawing.SystemColors.Control;
      this.menuPrincipal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastros,
            this.mnAvaliacao,
            this.mnSobre,
            this.sairToolStripMenuItem});
      this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
      this.menuPrincipal.Name = "menuPrincipal";
      this.menuPrincipal.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
      this.menuPrincipal.Size = new System.Drawing.Size(988, 25);
      this.menuPrincipal.TabIndex = 5;
      // 
      // mnCadastros
      // 
      this.mnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadIdoso,
            this.mnCadProf});
      this.mnCadastros.Name = "mnCadastros";
      this.mnCadastros.Size = new System.Drawing.Size(88, 21);
      this.mnCadastros.Text = "Cadastros";
      // 
      // mnCadIdoso
      // 
      this.mnCadIdoso.BackColor = System.Drawing.SystemColors.Control;
      this.mnCadIdoso.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
      this.mnCadIdoso.Name = "mnCadIdoso";
      this.mnCadIdoso.Size = new System.Drawing.Size(180, 22);
      this.mnCadIdoso.Text = "Idoso";
      // 
      // mnCadProf
      // 
      this.mnCadProf.BackColor = System.Drawing.SystemColors.Control;
      this.mnCadProf.Name = "mnCadProf";
      this.mnCadProf.Size = new System.Drawing.Size(180, 22);
      this.mnCadProf.Text = "Profissional";
      this.mnCadProf.Click += new System.EventHandler(this.CadProfissional);
      // 
      // mnAvaliacao
      // 
      this.mnAvaliacao.Name = "mnAvaliacao";
      this.mnAvaliacao.Size = new System.Drawing.Size(82, 21);
      this.mnAvaliacao.Text = "Avalia��o";
      // 
      // sairToolStripMenuItem
      // 
      this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
      this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
      this.sairToolStripMenuItem.Text = "Sair";
      this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairSistema);
      // 
      // panel1
      // 
      this.panel1.BackgroundImage = global::BACI.Desk.Properties.Resources.FundoTela;
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 65);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(988, 596);
      this.panel1.TabIndex = 6;
      // 
      // mnSobre
      // 
      this.mnSobre.Name = "mnSobre";
      this.mnSobre.Size = new System.Drawing.Size(59, 21);
      this.mnSobre.Text = "Sobre";
      // 
      // Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(988, 691);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStripPrincipal);
      this.Controls.Add(this.menuPrincipal);
      this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MainMenuStrip = this.menuPrincipal;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Principal";
      this.Opacity = 0D;
      this.Text = "Bateria de Avalia��o Computadorizada para Idosos";
      this.Controls.SetChildIndex(this.menuPrincipal, 0);
      this.Controls.SetChildIndex(this.toolStripPrincipal, 0);
      this.Controls.SetChildIndex(this.statusBar, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      ((System.ComponentModel.ISupportInitialize)(this.statusBar)).EndInit();
      this.statusBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.statusBarUser)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarDate)).EndInit();
      this.toolStripPrincipal.ContentPanel.ResumeLayout(false);
      this.toolStripPrincipal.ContentPanel.PerformLayout();
      this.toolStripPrincipal.ResumeLayout(false);
      this.toolStripPrincipal.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.menuPrincipal.ResumeLayout(false);
      this.menuPrincipal.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStripContainer toolStripPrincipal;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.MenuStrip menuPrincipal;
    private System.Windows.Forms.ToolStripMenuItem mnCadastros;
    private System.Windows.Forms.ToolStripMenuItem mnCadIdoso;
    private System.Windows.Forms.ToolStripMenuItem mnCadProf;
    private System.Windows.Forms.ToolStripMenuItem mnAvaliacao;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton btnCadProfissional;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btnCadIdoso;
    private System.Windows.Forms.ToolStripButton btnIniAvaliacao;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolStripMenuItem mnSobre;
  }
}