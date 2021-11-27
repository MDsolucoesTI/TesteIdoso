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
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BACI.Controller;
using BACI.Model;

namespace BACI.Desk
{
  public partial class ProfissionalView : BaseCadasView
  {
    private Profissional pro;
    private List<Profissional> profs;
    public ProfissionalView()
    {
      InitializeComponent();
      pro = new Profissional();
      profs = new List<Profissional>();
      profs = ProfissionalController.GetProfissionais();
      if (profs.Count > 0)
      {

        this.PreencheCampos(profs[0]);
        this.ChegouPrimeiro();

        this.pos = 0;
      }
      else
      {
        this.DesabilitaBotoes();
        this.SemDados();

        btnOk.Enabled = false;
        btnCancela.Enabled = false;

        this.pos = -1;
      }
    }

    private void LimpaCampos()
    {
      txtCRP.Clear();
      txtNomeCompleto.Clear();
      txtCPF.Clear();
      txtEMail.Clear();
      txtUserName.Clear();
      txtPassword.Clear();
      txtConfPassword.Clear();
      txtCelular.Clear();

      txtNivelAcesso.Text = txtNivelAcesso.Items[1].ToString();

      txtDataInicio.Value = DateTime.Now;
      txtDataFinal.Value = DateTime.Now;
    }

    private void HabilitaCampos()
    {
      txtNomeCompleto.Enabled = true;
      txtNivelAcesso.Enabled = true;
      txtCPF.Enabled = true;
      txtEMail.Enabled = true;
      txtUserName.Enabled = true;
      txtCelular.Enabled = true;
    }

    private void DesabilitaCampos()
    {
      txtCRP.Enabled = false;
      txtNomeCompleto.Enabled = false;
      txtNivelAcesso.Enabled = false;
      txtCPF.Enabled = false;
      txtEMail.Enabled = false;
      txtUserName.Enabled = false;
      txtCelular.Enabled = false;
      txtPassword.Enabled = false;
      txtConfPassword.Enabled = false;
      txtDataInicio.Enabled = false;
      txtDataFinal.Enabled = false;
    }

    private void PreencheCampos(Profissional prf)
    {
      txtCRP.Text = prf.Crp;
      txtNomeCompleto.Text = prf.FullName;
      txtCPF.Text = prf.Cpf;
      txtEMail.Text = prf.EMail;
      txtUserName.Text = prf.UserName;
      txtCelular.Text = prf.Celular;

      txtNivelAcesso.SelectedIndex = prf.Acesso;

      if (prf.Acesso == 0)
      {
        txtPassword.Text = prf.Password;
      }
      else if (prf.Acesso == 1)
      {
        txtDataInicio.Value = prf.IniLibera;
        txtDataFinal.Value = prf.FimLibera;
      }
    }

    private Profissional RecuperaCampos()
    {
      Profissional prf = new Profissional();

      try
      {
        prf.Crp = txtCRP.Text;
        prf.FullName = txtNomeCompleto.Text;
        prf.Cpf = txtCPF.Text;
        prf.EMail = txtEMail.Text;
        prf.UserName = txtUserName.Text;
        prf.Celular = txtCelular.Text;
        prf.Acesso = txtNivelAcesso.SelectedIndex;
        prf.IniLibera = txtDataInicio.Value;
        prf.FimLibera = txtDataFinal.Value;

        if (prf.Acesso == 0)
        {
          prf.Password = txtPassword.Text;
        }
        else
        {
          prf.Password = "teste123";
        }

        return prf;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, "Validando Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return null;
      }
    }

    private void txtNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.novo || this.alte)
      {
        if (txtNivelAcesso.SelectedIndex == 0)
        {
          txtPassword.Enabled = true;
          txtConfPassword.Enabled = true;

          txtDataInicio.Enabled = false;
          txtDataFinal.Enabled = false;
        }
        else if (txtNivelAcesso.SelectedIndex == 1)
        {
          txtDataInicio.Enabled = true;
          txtDataFinal.Enabled = true;

          txtPassword.Enabled = false;
          txtConfPassword.Enabled = false;
        }
      }
    }

    private void btnPrimeiro_Click(object sender, EventArgs e)
    {
      if (this.pos != 0)
      {
        this.pos = 0;

        this.PreencheCampos(profs[this.pos]);
        this.ChegouPrimeiro();
        this.SaiuUltimo();
      }
      else
      {
        this.ChegouPrimeiro();
        this.SaiuUltimo();
      }
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
      if (this.pos > 0)
      {
        this.pos -= 1;

        this.PreencheCampos(profs[this.pos]);

        if (pos == 0)
        {
          this.ChegouPrimeiro();
          this.SaiuUltimo();
        }
      }
      else if (this.pos == 0)
      {
        this.ChegouPrimeiro();
        this.SaiuUltimo();
      }
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
      if (this.pos < (profs.Count - 1))
      {
        this.pos += 1;

        this.PreencheCampos(profs[this.pos]);

        if (pos == (profs.Count - 1))
        {
          this.ChegouUltimo();
          this.SaiuPrimeiro();
        }
      }
      else if (this.pos == (profs.Count - 1))
      {
        this.ChegouUltimo();
        this.SaiuPrimeiro();
      }
    }

    private void btnUltimo_Click(object sender, EventArgs e)
    {
      if (pos != (profs.Count - 1))
      {
        this.pos = profs.Count - 1;
        this.PreencheCampos(profs[this.pos]);
        this.ChegouUltimo();
        this.SaiuPrimeiro();
      }
      else
      {
        this.ChegouUltimo();
        this.SaiuPrimeiro();
      }
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      this.DesabilitaBotoes();
      this.LimpaCampos();
      this.HabilitaCampos();

      this.novo = true;
      this.alte = false;

      txtCRP.Enabled = true;
      txtCRP.Focus();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      this.DesabilitaBotoes();
      this.HabilitaCampos();

      this.novo = false;
      this.alte = true;

      txtNomeCompleto.Focus();
    }

    private void btnCancela_Click(object sender, EventArgs e)
    {
      this.LimpaCampos();
      this.DesabilitaCampos();
      this.HabilitaBotoes();
      if (this.pos >= 0)
      {
        this.PreencheCampos(this.profs[this.pos]);
      }
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      this.pro = this.RecuperaCampos();
      if (pro != null)
      {
        if (this.novo)
        {
          if (ProfissionalController.Add(this.pro))
          {
            MessageBox.Show("Dados salvos com sucesso!!!", "Cadastrando Profissional", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Erro ao salvar dados, verifique e tente depois", "Cadastrando Profissional", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          this.profs.Clear();
          this.profs = ProfissionalController.GetProfissionais();
          this.pos = this.profs.Count - 1;
          PreencheCampos(this.profs[this.pos]);
          this.HabilitaBotoes();
          this.DesabilitaCampos();
        }
        else
        {
          if (ProfissionalController.Update(this.pro))
          {
            MessageBox.Show("Dados alterados com sucesso!!!", "Manuten��o Profissional", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Erro ao salvar dados, verifique e tente depois", "Manuten��o Profissional", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          this.profs.Clear();
          this.profs = ProfissionalController.GetProfissionais();
          PreencheCampos(this.profs[this.pos]);
          this.HabilitaBotoes();
          this.DesabilitaCampos();
        }
      }
      else
      {
        if (novo)
        {
          txtCRP.Focus();
        }
        else
        {
          txtNomeCompleto.Focus();
        }
      }
    }

    private void btnDeletar_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.DialogResult res;
      res = MessageBox.Show("Tem certeza que deseja excluir o profissional?", "Manuten��o Profissional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        if (ProfissionalController.Delete(txtCRP.Text))
        {
          MessageBox.Show("Profissional excluido com sucesso!!!", "Manuten��o Profissional", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
        }
        else
        {
          MessageBox.Show("Erro ao excluir profissional, verifique e tente depois", "Manuten��o Profissional", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        this.profs = ProfissionalController.GetProfissionais();
        this.pos = this.profs.Count - 1;
        PreencheCampos(this.profs[this.pos]);
        this.HabilitaBotoes();
        this.DesabilitaCampos();
      }
    }

    private void txtConfPassword_Leave(object sender, EventArgs e)
    {
      if (txtPassword.Text != txtConfPassword.Text)
      {
        MessageBox.Show("As senhas devem ser iguais!!!", "Validando senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtConfPassword.Clear();
        txtPassword.Clear();
        txtPassword.Focus();
      }
    }
  }
}
