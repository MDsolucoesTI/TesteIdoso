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
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BACI.Controller;
using BACI.Model;

namespace BACI.Desk
{
  public partial class Login : Syncfusion.Windows.Forms.MetroForm
  {
    public int NivelUser;

    private int _tentativas;

    public Login()
    {
      InitializeComponent();
      _tentativas = 0;
      if (!ConectionFactory.CriarBanco())
      {
        MessageBox.Show("N�o foi poss�vel criar o banco de dados", "Preparando a Utiliza��o do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Exit();
      }

      if (!ConectionFactory.CriarTabelas())
      {
        MessageBox.Show("N�o foi poss[ivel criar as tabelas", "Preparando a Utiliza��o do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Exit();
      }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      Profissional pro = new Profissional();

      pro = ProfissionalController.GetUser(this.userName.Text);
      if (pro != null)
      {
        if ((this.userName.Text == pro.UserName) && (this.password.Text == pro.Password))
        {
          NivelUser = pro.Acesso;
          this.Close();
        }
        else
        {
          MessageBox.Show("Nome e/ou senha informados n�o conferem!", "Valida��o de Login", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
          _tentativas++;
          if (_tentativas >= 3)
          {
            MessageBox.Show("Voc� excedeu o n�mero de tentativas permitidas", "Valida��o de Login", MessageBoxButtons.OK,
              MessageBoxIcon.Stop);
            Application.Exit();
          }

          LimpaCampos();
          this.userName.Focus();
        }
      }
      else
      {
        if ((this.userName.Text == "FirstMDLogin") && (this.password.Text == "MD2018_Log"))
        {
          this.NivelUser = 0;
          this.Close();
        }
        else
        {
          MessageBox.Show("Nome e/ou senha informados n�o conferem!", "Valida��o de Login", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
          _tentativas++;
          if (_tentativas >= 3)
          {
            MessageBox.Show("Voc� excedeu o n�mero de tentativas permitidas", "Valida��o de Login", MessageBoxButtons.OK,
              MessageBoxIcon.Stop);
            Application.Exit();
          }
          LimpaCampos();
          this.userName.Focus();
        }
      }
    }

    private void LimpaCampos()
    {
      this.userName.Clear();
      this.password.Clear();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
