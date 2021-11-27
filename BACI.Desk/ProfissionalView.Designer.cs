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
  partial class ProfissionalView
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtNomeCompleto = new System.Windows.Forms.TextBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.txtEMail = new System.Windows.Forms.TextBox();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.txtCPF = new System.Windows.Forms.MaskedTextBox();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.txtCRP = new System.Windows.Forms.TextBox();
      this.groupBox16 = new System.Windows.Forms.GroupBox();
      this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
      this.groupBox17 = new System.Windows.Forms.GroupBox();
      this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
      this.groupBox18 = new System.Windows.Forms.GroupBox();
      this.txtCelular = new System.Windows.Forms.MaskedTextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtConfPassword = new System.Windows.Forms.TextBox();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.txtNivelAcesso = new System.Windows.Forms.ComboBox();
      this.pnCampos.SuspendLayout();
      this.pnBotoes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.statusBar)).BeginInit();
      this.statusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarUser)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarDate)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox16.SuspendLayout();
      this.groupBox17.SuspendLayout();
      this.groupBox18.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnCampos
      // 
      this.pnCampos.Controls.Add(this.groupBox5);
      this.pnCampos.Controls.Add(this.groupBox2);
      this.pnCampos.Controls.Add(this.groupBox18);
      this.pnCampos.Controls.Add(this.groupBox17);
      this.pnCampos.Controls.Add(this.groupBox16);
      this.pnCampos.Controls.Add(this.groupBox8);
      this.pnCampos.Controls.Add(this.groupBox7);
      this.pnCampos.Controls.Add(this.groupBox6);
      this.pnCampos.Controls.Add(this.groupBox4);
      this.pnCampos.Controls.Add(this.groupBox3);
      this.pnCampos.Controls.Add(this.groupBox1);
      // 
      // btnPrimeiro
      // 
      this.btnPrimeiro.FlatAppearance.BorderSize = 0;
      this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
      // 
      // btnAnterior
      // 
      this.btnAnterior.FlatAppearance.BorderSize = 0;
      this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
      // 
      // btnProximo
      // 
      this.btnProximo.FlatAppearance.BorderSize = 0;
      this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
      // 
      // btnUltimo
      // 
      this.btnUltimo.FlatAppearance.BorderSize = 0;
      this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.FlatAppearance.BorderSize = 0;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.FlatAppearance.BorderSize = 0;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnOk
      // 
      this.btnOk.Enabled = false;
      this.btnOk.FlatAppearance.BorderSize = 0;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancela
      // 
      this.btnCancela.Enabled = false;
      this.btnCancela.FlatAppearance.BorderSize = 0;
      this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
      // 
      // btnDeletar
      // 
      this.btnDeletar.FlatAppearance.BorderSize = 0;
      this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtNomeCompleto);
      this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox1.Location = new System.Drawing.Point(251, 30);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(616, 60);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = " Nome Completo ";
      // 
      // txtNomeCompleto
      // 
      this.txtNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNomeCompleto.Enabled = false;
      this.txtNomeCompleto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNomeCompleto.ForeColor = System.Drawing.Color.Black;
      this.txtNomeCompleto.Location = new System.Drawing.Point(12, 21);
      this.txtNomeCompleto.Name = "txtNomeCompleto";
      this.txtNomeCompleto.Size = new System.Drawing.Size(592, 26);
      this.txtNomeCompleto.TabIndex = 1;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtUserName);
      this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox3.Location = new System.Drawing.Point(31, 150);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(306, 60);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = " Nome de Usu�rio ";
      // 
      // txtUserName
      // 
      this.txtUserName.Enabled = false;
      this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.ForeColor = System.Drawing.Color.Black;
      this.txtUserName.Location = new System.Drawing.Point(12, 21);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(283, 26);
      this.txtUserName.TabIndex = 5;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.txtPassword);
      this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox4.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox4.Location = new System.Drawing.Point(345, 150);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(302, 60);
      this.groupBox4.TabIndex = 6;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = " Senha ";
      // 
      // txtPassword
      // 
      this.txtPassword.Enabled = false;
      this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.ForeColor = System.Drawing.Color.Black;
      this.txtPassword.Location = new System.Drawing.Point(12, 21);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(278, 26);
      this.txtPassword.TabIndex = 6;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.txtEMail);
      this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox6.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox6.Location = new System.Drawing.Point(389, 90);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(541, 60);
      this.groupBox6.TabIndex = 4;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = " e-Mail ";
      // 
      // txtEMail
      // 
      this.txtEMail.Enabled = false;
      this.txtEMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEMail.ForeColor = System.Drawing.Color.Black;
      this.txtEMail.Location = new System.Drawing.Point(13, 20);
      this.txtEMail.Name = "txtEMail";
      this.txtEMail.Size = new System.Drawing.Size(516, 26);
      this.txtEMail.TabIndex = 4;
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.txtCPF);
      this.groupBox7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox7.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox7.Location = new System.Drawing.Point(226, 90);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(155, 60);
      this.groupBox7.TabIndex = 3;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = " CPF ";
      // 
      // txtCPF
      // 
      this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      this.txtCPF.Enabled = false;
      this.txtCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCPF.Location = new System.Drawing.Point(12, 21);
      this.txtCPF.Mask = "999.999.999-99";
      this.txtCPF.Name = "txtCPF";
      this.txtCPF.Size = new System.Drawing.Size(128, 26);
      this.txtCPF.TabIndex = 3;
      this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.txtCRP);
      this.groupBox8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox8.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox8.Location = new System.Drawing.Point(31, 30);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(213, 60);
      this.groupBox8.TabIndex = 0;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = " CRP ";
      // 
      // txtCRP
      // 
      this.txtCRP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCRP.Enabled = false;
      this.txtCRP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCRP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
      this.txtCRP.Location = new System.Drawing.Point(13, 20);
      this.txtCRP.Name = "txtCRP";
      this.txtCRP.Size = new System.Drawing.Size(186, 26);
      this.txtCRP.TabIndex = 0;
      // 
      // groupBox16
      // 
      this.groupBox16.Controls.Add(this.txtDataInicio);
      this.groupBox16.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox16.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox16.Location = new System.Drawing.Point(193, 210);
      this.groupBox16.Name = "groupBox16";
      this.groupBox16.Size = new System.Drawing.Size(137, 60);
      this.groupBox16.TabIndex = 18;
      this.groupBox16.TabStop = false;
      this.groupBox16.Text = " In�cio Libera��o ";
      // 
      // txtDataInicio
      // 
      this.txtDataInicio.CalendarForeColor = System.Drawing.Color.Black;
      this.txtDataInicio.Enabled = false;
      this.txtDataInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.txtDataInicio.Location = new System.Drawing.Point(12, 21);
      this.txtDataInicio.Name = "txtDataInicio";
      this.txtDataInicio.Size = new System.Drawing.Size(113, 26);
      this.txtDataInicio.TabIndex = 16;
      // 
      // groupBox17
      // 
      this.groupBox17.Controls.Add(this.txtDataFinal);
      this.groupBox17.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox17.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox17.Location = new System.Drawing.Point(338, 210);
      this.groupBox17.Name = "groupBox17";
      this.groupBox17.Size = new System.Drawing.Size(137, 60);
      this.groupBox17.TabIndex = 19;
      this.groupBox17.TabStop = false;
      this.groupBox17.Text = " Final Libera��o ";
      // 
      // txtDataFinal
      // 
      this.txtDataFinal.CalendarForeColor = System.Drawing.Color.Black;
      this.txtDataFinal.Enabled = false;
      this.txtDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.txtDataFinal.Location = new System.Drawing.Point(12, 22);
      this.txtDataFinal.Name = "txtDataFinal";
      this.txtDataFinal.Size = new System.Drawing.Size(113, 26);
      this.txtDataFinal.TabIndex = 17;
      // 
      // groupBox18
      // 
      this.groupBox18.Controls.Add(this.txtCelular);
      this.groupBox18.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox18.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox18.Location = new System.Drawing.Point(31, 210);
      this.groupBox18.Name = "groupBox18";
      this.groupBox18.Size = new System.Drawing.Size(155, 60);
      this.groupBox18.TabIndex = 17;
      this.groupBox18.TabStop = false;
      this.groupBox18.Text = " Celular ";
      // 
      // txtCelular
      // 
      this.txtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      this.txtCelular.Enabled = false;
      this.txtCelular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCelular.Location = new System.Drawing.Point(13, 22);
      this.txtCelular.Mask = "(99)09999-9999";
      this.txtCelular.Name = "txtCelular";
      this.txtCelular.Size = new System.Drawing.Size(128, 26);
      this.txtCelular.TabIndex = 15;
      this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtConfPassword);
      this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox2.Location = new System.Drawing.Point(655, 150);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(302, 60);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = " Confirmar Senha ";
      // 
      // txtConfPassword
      // 
      this.txtConfPassword.Enabled = false;
      this.txtConfPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtConfPassword.ForeColor = System.Drawing.Color.Black;
      this.txtConfPassword.Location = new System.Drawing.Point(12, 21);
      this.txtConfPassword.Name = "txtConfPassword";
      this.txtConfPassword.Size = new System.Drawing.Size(278, 26);
      this.txtConfPassword.TabIndex = 7;
      this.txtConfPassword.UseSystemPasswordChar = true;
      this.txtConfPassword.Leave += new System.EventHandler(this.txtConfPassword_Leave);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.txtNivelAcesso);
      this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox5.ForeColor = System.Drawing.Color.MediumSeaGreen;
      this.groupBox5.Location = new System.Drawing.Point(31, 90);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(188, 60);
      this.groupBox5.TabIndex = 2;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "  N�vel de Acesso";
      // 
      // txtNivelAcesso
      // 
      this.txtNivelAcesso.Enabled = false;
      this.txtNivelAcesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNivelAcesso.FormattingEnabled = true;
      this.txtNivelAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Avaliador"});
      this.txtNivelAcesso.Location = new System.Drawing.Point(14, 21);
      this.txtNivelAcesso.Name = "txtNivelAcesso";
      this.txtNivelAcesso.Size = new System.Drawing.Size(163, 26);
      this.txtNivelAcesso.TabIndex = 2;
      this.txtNivelAcesso.SelectedIndexChanged += new System.EventHandler(this.txtNivelAcesso_SelectedIndexChanged);
      // 
      // ProfissionalView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(988, 693);
      this.Name = "ProfissionalView";
      this.Text = "Manuten��o de Dados - Profissional";
      this.pnCampos.ResumeLayout(false);
      this.pnBotoes.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.statusBar)).EndInit();
      this.statusBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.statusBarUser)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarDate)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox16.ResumeLayout(false);
      this.groupBox17.ResumeLayout(false);
      this.groupBox18.ResumeLayout(false);
      this.groupBox18.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.TextBox txtCRP;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.MaskedTextBox txtCPF;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.TextBox txtEMail;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtNomeCompleto;
    private System.Windows.Forms.GroupBox groupBox17;
    private System.Windows.Forms.GroupBox groupBox16;
    private System.Windows.Forms.GroupBox groupBox18;
    private System.Windows.Forms.MaskedTextBox txtCelular;
    private System.Windows.Forms.DateTimePicker txtDataFinal;
    private System.Windows.Forms.DateTimePicker txtDataInicio;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.ComboBox txtNivelAcesso;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtConfPassword;
  }
}