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
using System.Text;
using System.Windows.Forms;
using BACI.Controller;
using BACI.Model;
using DateTime = System.DateTime;

namespace BACI.Desk
{
  public partial class IdosoView : BaseCadasView
  {
    private Idoso ido;
    private List<Idoso> idosos;
    public IdosoView()
    {
      InitializeComponent();
      ido = new Idoso();
      idosos = new List<Idoso>();
      idosos = IdosoController.GetIdosos();
      if (idosos.Count > 0)
      {
        this.PreencheCampos(idosos[0]);
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
      txtNomeCompleto.Clear();
      txtCPF.Clear();
      txtCidade.Clear();
      txtIdade.Clear();
      txtMedUtilizados.Clear();
      txtQualDefFis.Clear();
      txtQualDoenca.Clear();
      txtProfissao.Clear();
      txtUF.Text = "";
      txtDataNasc.Value = DateTime.Now;

      rbFem.Checked = false;
      rbMasc.Checked = false;
      rbCanhoto.Checked = false;
      rbDestro.Checked = false;
      rbEsco01.Checked = false;
      rbEsco02.Checked = false;
      rbEsco03.Checked = false;
      rbEsco04.Checked = false;
      rbTrab01.Checked = false;
      rbTrab02.Checked = false;
      rbTrab03.Checked = false;
      rbProbVisNao.Checked = false;
      rbProbVisSim.Checked = false;
      rbUsaOcuNao.Checked = false;
      rbUsaOcuSim.Checked = false;
      rbDefAudiNao.Checked = false;
      rbDefAudiSim.Checked = false;
      rbUsaEquiNao.Checked = false;
      rbUsaEquiSim.Checked = false;
      rbDefFisNao.Checked = false;
      rbDefFisSim.Checked = false;
      rbDoenDiagNao.Checked = false;
      rbDoenDiagSim.Checked = false;
      rbUsaMedNao.Checked = false;
      rbUsaMedSim.Checked = false;
      rbMedContNao.Checked = false;
      rbMedContSim.Checked = false;
    }

    private void HabilitaCampos()
    {
      gpNome.Enabled = true;
      gpSexo.Enabled = true;
      gpDataNasc.Enabled = true;
      gpLate.Enabled = true;
      gpCidade.Enabled = true;
      gpUF.Enabled = true;
      gpEscola.Enabled = true;
      gpProf.Enabled = true;
      gpTraba.Enabled = true;
      gpDefFis.Enabled = true;
      gpQualDefFis.Enabled = true;
      gpProbVisu.Enabled = true;
      gpUsaLente.Enabled = true;
      gpDefAudi.Enabled = true;
      gpUsaEqui.Enabled = true;
      gpDoeDiag.Enabled = true;
      gpQualDoen.Enabled = true;
      gpUsaMed.Enabled = true;
      gpUsoCont.Enabled = true;
      gpQualMed.Enabled = true;
    }

    private void DesabilitaCampos()
    {
      gpNome.Enabled = false;
      gpSexo.Enabled = false;
      gpCPF.Enabled = false;
      gpDataNasc.Enabled = false;
      gpLate.Enabled = false;
      gpCidade.Enabled = false;
      gpUF.Enabled = false;
      gpEscola.Enabled = false;
      gpProf.Enabled = false;
      gpTraba.Enabled = false;
      gpDefFis.Enabled = false;
      gpQualDefFis.Enabled = false;
      gpProbVisu.Enabled = false;
      gpUsaLente.Enabled = false;
      gpDefAudi.Enabled = false;
      gpUsaEqui.Enabled = false;
      gpDoeDiag.Enabled = false;
      gpQualDoen.Enabled = false;
      gpUsaMed.Enabled = false;
      gpUsoCont.Enabled = false;
      gpQualMed.Enabled = false;
    }

    private void PreencheCampos(Idoso doso)
    {
      txtNomeCompleto.Text = doso.FullName;
      rbMasc.Checked = (doso.Sexo == "M");
      rbFem.Checked = (doso.Sexo == "F");
      txtCPF.Text = doso.Cpf;
      txtDataNasc.Value = doso.DataNasc;
      rbDestro.Checked = doso.Destro;
      rbCanhoto.Checked = !doso.Destro;
      txtCidade.Text = doso.Cidade;
      txtUF.Text = doso.Estado;
      rbEsco01.Checked = (doso.Escolaridade == 1);
      rbEsco02.Checked = (doso.Escolaridade == 2);
      rbEsco03.Checked = (doso.Escolaridade == 3);
      rbEsco04.Checked = (doso.Escolaridade == 4);
      txtProfissao.Text = doso.Profissao;
      rbTrab01.Checked = (doso.TrabAtual == 1);
      rbTrab02.Checked = (doso.TrabAtual == 2);
      rbTrab03.Checked = (doso.TrabAtual == 3);
      rbDefFisSim.Checked = doso.DefFisica;
      rbDefFisNao.Checked = !doso.DefFisica;
      txtQualDefFis.Text = doso.QualDefFisica;
      rbProbVisSim.Checked = doso.DefVisual;
      rbProbVisNao.Checked = !doso.DefVisual;
      rbUsaOcuSim.Checked = doso.UsaLente;
      rbUsaOcuNao.Checked = !doso.UsaLente;
      rbDefAudiSim.Checked = doso.DefAuditi;
      rbDefAudiNao.Checked = !doso.DefAuditi;
      rbUsaEquiSim.Checked = doso.UsaEquipa;
      rbUsaEquiNao.Checked = !doso.UsaEquipa;
      rbDoenDiagSim.Checked = doso.DoenDiag;
      rbDoenDiagNao.Checked = !doso.DoenDiag;
      txtQualDoenca.Text = doso.QualDoenca;
      rbUsaMedSim.Checked = doso.UsaMedica;
      rbUsaMedNao.Checked = !doso.UsaMedica;
      rbMedContSim.Checked = doso.UsoConti;
      rbMedContNao.Checked = !doso.UsoConti;
      txtMedUtilizados.Text = doso.QualMedica;
    }

    private Idoso RecuperaCampos()
    {
      Idoso doso = new Idoso();

      try
      {
        doso.FullName = txtNomeCompleto.Text;
        doso.Sexo = (rbMasc.Checked ? "M" : "F");
        doso.Cpf = txtCPF.Text;
        doso.DataNasc = txtDataNasc.Value;
        doso.Destro = rbDestro.Checked;
        doso.Cidade = txtCidade.Text;
        doso.Estado = txtUF.Text;
        if (rbEsco01.Checked)
        {
          doso.Escolaridade = 1;
        }
        else if (rbEsco02.Checked)
        {
          doso.Escolaridade = 2;
        }
        else if (rbEsco03.Checked)
        {
          doso.Escolaridade = 3;
        }
        else if (rbEsco04.Checked)
        {
          doso.Escolaridade = 4;
        }
        doso.Profissao = txtProfissao.Text;
        if (rbTrab01.Checked)
        {
          doso.TrabAtual = 1;
        }
        else if (rbTrab02.Checked)
        {
          doso.TrabAtual = 2;
        }
        else if (rbTrab03.Checked)
        {
          doso.TrabAtual = 3;
        }
        doso.DefFisica = rbDefFisSim.Checked;
        doso.QualDefFisica = txtQualDefFis.Text;
        doso.DefVisual = rbProbVisSim.Checked;
        doso.UsaLente = rbUsaOcuSim.Checked;
        doso.DefAuditi = rbDefAudiSim.Checked;
        doso.UsaEquipa = rbUsaEquiSim.Checked;
        doso.DoenDiag = rbDoenDiagSim.Checked;
        doso.QualDoenca = txtQualDoenca.Text;
        doso.UsaMedica = rbUsaMedSim.Checked;
        doso.UsoConti = rbMedContSim.Checked;
        doso.QualMedica = txtMedUtilizados.Text;

        return doso;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, "Validando Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return null;
      }
    }

    private void txtDataNasc_ValueChanged(object sender, EventArgs e)
    {
      txtIdade.Text = Convert.ToString(DateTime.Now.Year - txtDataNasc.Value.Year);
    }

    private void btnPrimeiro_Click(object sender, EventArgs e)
    {
      if (this.pos != 0)
      {
        this.pos = 0;

        this.PreencheCampos(idosos[this.pos]);
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

        this.PreencheCampos(idosos[this.pos]);

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
      if (this.pos < (idosos.Count - 1))
      {
        this.pos += 1;

        this.PreencheCampos(idosos[this.pos]);

        if (pos == (idosos.Count - 1))
        {
          this.ChegouUltimo();
          this.SaiuPrimeiro();
        }
      }
      else if (this.pos == (idosos.Count - 1))
      {
        this.ChegouUltimo();
        this.SaiuPrimeiro();
      }
    }

    private void btnUltimo_Click(object sender, EventArgs e)
    {
      if (pos != (idosos.Count - 1))
      {
        this.pos = idosos.Count - 1;
        this.PreencheCampos(idosos[this.pos]);
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

      gpCPF.Enabled = true;
      txtNomeCompleto.Focus();
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
        this.PreencheCampos(this.idosos[this.pos]);
      }
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      this.ido = this.RecuperaCampos();
      if (ido != null)
      {
        if (this.novo)
        {
          if (IdosoController.Add(this.ido))
          {
            MessageBox.Show("Dados salvos com sucesso!!!", "Cadastrando Idoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Erro ao salvar dados, verifique e tente depois", "Cadastrando Idoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          this.idosos.Clear();
          this.idosos = IdosoController.GetIdosos();
          this.pos = this.idosos.Count - 1;
          PreencheCampos(this.idosos[this.pos]);
          this.HabilitaBotoes();
          this.DesabilitaCampos();
        }
        else
        {
          if (IdosoController.Update(this.ido))
          {
            MessageBox.Show("Dados alterados com sucesso!!!", "Manuten��o Idoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Erro ao salvar dados, verifique e tente depois", "Manuten��o Idoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          this.idosos.Clear();
          this.idosos = IdosoController.GetIdosos();
          PreencheCampos(this.idosos[this.pos]);
          this.HabilitaBotoes();
          this.DesabilitaCampos();
        }
      }
      else
      {
        if (novo)
        {
          txtNomeCompleto.Focus();
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
      res = MessageBox.Show("Tem certeza que deseja excluir o Idoso?", "Manuten��o Idoso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        if (IdosoController.Delete(txtCPF.Text))
        {
          MessageBox.Show("Idoso excluido com sucesso!!!", "Manuten��o Idoso", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
        }
        else
        {
          MessageBox.Show("Erro ao excluir idoso, verifique e tente depois", "Manuten��o Idoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        this.idosos = IdosoController.GetIdosos();
        this.pos = this.idosos.Count - 1;
        PreencheCampos(this.idosos[this.pos]);
        this.HabilitaBotoes();
        this.DesabilitaCampos();
      }
    }
  }
}
