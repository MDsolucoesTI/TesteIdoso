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
  public partial class AvalFiguAgru : AvalBaseView
  {
    public AvalFiguAgru()
    {
      InitializeComponent();
    }

    private void MostraTela(AvalBaseView tela)
    {
      if (Screen.AllScreens.Length > 1)
      {
        int posX;
        int posY;
        int largura;
        int altura;

        tela.StartPosition = FormStartPosition.Manual;
        Screen screen = GetSecondaryScreen();

        largura = screen.WorkingArea.Width;
        altura = screen.WorkingArea.Height;
        posX = (largura - tela.Width) / 2;
        posY = (altura - tela.Height) / 2;

        tela.Location = screen.WorkingArea.Location;
        tela.Left = screen.WorkingArea.Left + posX;
        tela.Top = screen.WorkingArea.Top + posY;
        tela.Show();
      }
    }
    private Screen GetSecondaryScreen()
    {
      if (Screen.AllScreens.Length == 1)
      {
        return null;
      }

      foreach (Screen screen in Screen.AllScreens)
      {
        if (screen.Primary == false)
        {
          return screen;
        }
      }

      return null;
    }
  }
}
