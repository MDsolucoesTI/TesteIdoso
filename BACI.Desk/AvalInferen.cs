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
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace BACI.Desk
{
  public partial class AvalInferen : AvalBaseView
  {
    public SoundPlayer tocarSom;
    public AvalInferen()
    {
      InitializeComponent();
    }

    private void btnTocar_Click(object sender, EventArgs e)
    {
      tocarSom = new SoundPlayer(@"Som\Infer_Treino1.wav");
      tocarSom.Play();
    }

    private void btnParar_Click(object sender, EventArgs e)
    {
      tocarSom.Stop();
    }

    private void btnTocar02_Click(object sender, EventArgs e)
    {
      tocarSom = new SoundPlayer(@"Som\Infer_Treino2.wav");
      tocarSom.Play();
    }

    private void btnParar02_Click(object sender, EventArgs e)
    {
      tocarSom.Stop();
    }

    private void btnTocar03_Click(object sender, EventArgs e)
    {
      tocarSom = new SoundPlayer(@"Som\Infer_Seque.wav");
      tocarSom.Play();
    }

    private void btnParar03_Click(object sender, EventArgs e)
    {
      tocarSom.Stop();
    }

    private void btnFinaEvo_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
