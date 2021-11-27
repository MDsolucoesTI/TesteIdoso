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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BACI.Desk
{
  public partial class Principal : BaseView
  {
    private string _user;
    private string _nivelAcesso;

    private int _nivelCod;

    private Login telaLogin;

    public Principal()
    {
      InitializeComponent();
      this.telaLogin = new Login();

      this.telaLogin.ShowDialog();

      this._user = telaLogin.userName.Text;
      this._nivelCod = telaLogin.NivelUser;

      this._nivelAcesso = (this._nivelCod == 0 ? "Administrador" : "Avaliador");

      this.Opacity = 100;

      this.statusBarDate.Text = Convert.ToString(DateTime.Now.Date).Substring(0, 10);
      this.statusBarUser.Text = this._user;

      if (this._nivelCod != 0)
      {
        this.btnCadProfissional.Enabled = false;
        this.mnCadProf.Enabled = false;
      }
    }

    #region Methods

    //Saida do sistema
    private void SairSistema(object sender, EventArgs e)
    {
      this.Close();
    }

    //Cadastro e manuten��o de Profissional
    private void CadProfissional(object sender, EventArgs e)
    {
      ProfissionalView cadPro = new ProfissionalView();

      cadPro.statusBarUser.Text = this._user;
      cadPro.statusBarDate.Text = Convert.ToString(DateTime.Now.Date).Substring(0, 10);

      cadPro.ShowDialog();
    }

    #endregion

    private void btnIniAvaliacao_Click(object sender, EventArgs e)
    {
      AvalControlView avaliacao = new AvalControlView();
      avaliacao.ShowDialog();
    }
  }
}
