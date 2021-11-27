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
  public partial class VidaDiariaView : AvalBaseView
  {
    public VidaDiariaView()
    {
      InitializeComponent();
    }

    public void RespQuestao01(object sender, EventArgs e)
    {
      q01Nao.Checked = false;
      q01SimAju.Checked = false;
      q01Sim.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao02(object sender, EventArgs e)
    {
      q02Nao.Checked = false;
      q02SimAju.Checked = false;
      q02Sim.Checked = false;
      q02Nunca.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao03(object sender, EventArgs e)
    {
      q03Nao.Checked = false;
      q03SimAju.Checked = false;
      q03Sim.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao04(object sender, EventArgs e)
    {
      q04Nao.Checked = false;
      q04SimAju.Checked = false;
      q04Sim.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao05(object sender, EventArgs e)
    {
      q05Nao.Checked = false;
      q05SimAju.Checked = false;
      q05Sim.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao06(object sender, EventArgs e)
    {
      q06Nao.Checked = false;
      q06SimAju.Checked = false;
      q06Sim.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao07(object sender, EventArgs e)
    {
      q07Nao.Checked = false;
      q07SimAju.Checked = false;
      q07Sim.Checked = false;
      q07Nunca.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao08(object sender, EventArgs e)
    {
      q08Nao.Checked = false;
      q08SimAju.Checked = false;
      q08Sim.Checked = false;
      q08Nunca.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao09(object sender, EventArgs e)
    {
      q09Nao.Checked = false;
      q09SimAju.Checked = false;
      q09Sim.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao10(object sender, EventArgs e)
    {
      q10Nao.Checked = false;
      q10SimAju.Checked = false;
      q10Sim.Checked = false;
      q10Nunca.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao11(object sender, EventArgs e)
    {
      q11Nao.Checked = false;
      q11SimAju.Checked = false;
      q11Sim.Checked = false;
      q11Nunca.Checked = false;

      (sender as RadioButton).Checked = true;
    }

    public void RespQuestao12(object sender, EventArgs e)
    {
      q12Nao.Checked = false;
      q12SimAju.Checked = false;
      q12Sim.Checked = false;
      q12Nunca.Checked = false;

      (sender as RadioButton).Checked = true;
    }
  }
}
