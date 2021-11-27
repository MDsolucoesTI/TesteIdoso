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

namespace BACI.Desk
{
  public partial class BaseCadasView : BaseView
  {
    protected int pos;
    protected bool novo;
    protected bool alte;
    public BaseCadasView()
    {
      InitializeComponent();
    }

    protected void DesaBotoesNavega()
    {
      btnPrimeiro.Enabled = false;
      btnAnterior.Enabled = false;
      btnProximo.Enabled = false;
      btnUltimo.Enabled = false;
    }

    protected void HabilitaBotoes()
    {
      btnPrimeiro.Enabled = true;
      btnAnterior.Enabled = true;
      btnProximo.Enabled = true;
      btnUltimo.Enabled = true;
      btnNovo.Enabled = true;
      btnEditar.Enabled = true;
      btnDeletar.Enabled = true;

      btnOk.Enabled = false;
      btnCancela.Enabled = false;
    }

    protected void DesabilitaBotoes()
    {
      DesaBotoesNavega();

      btnNovo.Enabled = false;
      btnEditar.Enabled = false;
      btnDeletar.Enabled = false;

      btnOk.Enabled = true;
      btnCancela.Enabled = true;
    }

    protected void SemDados()
    {
      DesaBotoesNavega();

      btnNovo.Enabled = true;

      btnEditar.Enabled = false;
      btnDeletar.Enabled = false;
    }

    protected void ChegouPrimeiro()
    {
      btnPrimeiro.Enabled = false;
      btnAnterior.Enabled = false;
    }

    protected void SaiuPrimeiro()
    {
      btnPrimeiro.Enabled = true;
      btnAnterior.Enabled = true;
    }

    protected void ChegouUltimo()
    {
      btnUltimo.Enabled = false;
      btnProximo.Enabled = false;
    }

    protected void SaiuUltimo()
    {
      btnUltimo.Enabled = true;
      btnProximo.Enabled = true;
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
