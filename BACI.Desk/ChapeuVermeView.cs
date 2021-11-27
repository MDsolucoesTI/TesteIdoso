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
  public partial class ChapeuVermeView : AvalBaseView
  {
    private short[] _coord = { 2, 248, 494, 740 };
    private int[] _posAtu = new int[4];

    enum Painel
    {
      pA,
      pB,
      pC,
      pD
    };

    public ChapeuVermeView()
    {
      InitializeComponent();

      Posicao(NumAle());

      titPa.Text = Letra(_posAtu[0]);
      titPb.Text = Letra(_posAtu[1]);
      titPc.Text = Letra(_posAtu[2]);
      titPd.Text = Letra(_posAtu[3]);

      pA.Tag = _posAtu[0];
      pB.Tag = _posAtu[1];
      pC.Tag = _posAtu[2];
      pD.Tag = _posAtu[3];

      pA.Location = new Point(_coord[_posAtu[0]], 12);
      pB.Location = new Point(_coord[_posAtu[1]], 12);
      pC.Location = new Point(_coord[_posAtu[2]], 12);
      pD.Location = new Point(_coord[_posAtu[3]], 12);

    }

    public int NumAle()
    {
      Random posRnd = new Random(DateTime.Now.Millisecond);
      return posRnd.Next(1, 23);
    }

    public void Posicao(int posVer)
    {
      switch (posVer)
      {
        case 1:
          _posAtu[0] = 0;
          _posAtu[1] = 1;
          _posAtu[2] = 3;
          _posAtu[3] = 2;
          break;
        case 2:
          _posAtu[0] = 0;
          _posAtu[1] = 2;
          _posAtu[2] = 1;
          _posAtu[3] = 3;
          break;
        case 3:
          _posAtu[0] = 0;
          _posAtu[1] = 2;
          _posAtu[2] = 3;
          _posAtu[3] = 1;
          break;
        case 4:
          _posAtu[0] = 0;
          _posAtu[1] = 3;
          _posAtu[2] = 1;
          _posAtu[3] = 2;
          break;
        case 5:
          _posAtu[0] = 0;
          _posAtu[1] = 3;
          _posAtu[2] = 2;
          _posAtu[3] = 1;
          break;
        case 6:
          _posAtu[0] = 1;
          _posAtu[1] = 0;
          _posAtu[2] = 2;
          _posAtu[3] = 3;
          break;
        case 7:
          _posAtu[0] = 1;
          _posAtu[1] = 0;
          _posAtu[2] = 3;
          _posAtu[3] = 2;
          break;
        case 8:
          _posAtu[0] = 1;
          _posAtu[1] = 2;
          _posAtu[2] = 0;
          _posAtu[3] = 3;
          break;
        case 9:
          _posAtu[0] = 1;
          _posAtu[1] = 2;
          _posAtu[2] = 3;
          _posAtu[3] = 0;
          break;
        case 10:
          _posAtu[0] = 1;
          _posAtu[1] = 3;
          _posAtu[2] = 0;
          _posAtu[3] = 2;
          break;
        case 11:
          _posAtu[0] = 1;
          _posAtu[1] = 3;
          _posAtu[2] = 2;
          _posAtu[3] = 0;
          break;
        case 12:
          _posAtu[0] = 2;
          _posAtu[1] = 0;
          _posAtu[2] = 1;
          _posAtu[3] = 3;
          break;
        case 13:
          _posAtu[0] = 2;
          _posAtu[1] = 0;
          _posAtu[2] = 3;
          _posAtu[3] = 1;
          break;
        case 14:
          _posAtu[0] = 2;
          _posAtu[1] = 1;
          _posAtu[2] = 0;
          _posAtu[3] = 3;
          break;
        case 15:
          _posAtu[0] = 2;
          _posAtu[1] = 1;
          _posAtu[2] = 3;
          _posAtu[3] = 0;
          break;
        case 16:
          _posAtu[0] = 2;
          _posAtu[1] = 3;
          _posAtu[2] = 0;
          _posAtu[3] = 1;
          break;
        case 17:
          _posAtu[0] = 2;
          _posAtu[1] = 3;
          _posAtu[2] = 1;
          _posAtu[3] = 0;
          break;
        case 18:
          _posAtu[0] = 3;
          _posAtu[1] = 0;
          _posAtu[2] = 1;
          _posAtu[3] = 2;
          break;
        case 19:
          _posAtu[0] = 3;
          _posAtu[1] = 0;
          _posAtu[2] = 2;
          _posAtu[3] = 1;
          break;
        case 20:
          _posAtu[0] = 3;
          _posAtu[1] = 1;
          _posAtu[2] = 0;
          _posAtu[3] = 2;
          break;
        case 21:
          _posAtu[0] = 3;
          _posAtu[1] = 1;
          _posAtu[2] = 2;
          _posAtu[3] = 0;
          break;
        case 22:
          _posAtu[0] = 3;
          _posAtu[1] = 2;
          _posAtu[2] = 0;
          _posAtu[3] = 1;
          break;
        case 23:
          _posAtu[0] = 3;
          _posAtu[1] = 2;
          _posAtu[2] = 1;
          _posAtu[3] = 0;
          break;
      }
    }

    public string Letra(int valor)
    {
      string letra = "";

      switch (valor)
      {
        case 0:
          letra = "A";
          break;
        case 1:
          letra = "S";
          break;
        case 2:
          letra = "D";
          break;
        case 3:
          letra = "F";
          break;
      }

      return letra;
    }

    private void ChapeuVermeView_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    public void ChapeuVermeView_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.A)
      {
        titPa.BackColor = Color.White;
        titPb.BackColor = Color.White;
        titPc.BackColor = Color.White;
        titPd.BackColor = Color.White;

        titPa.Tag = 0;
        titPb.Tag = 0;
        titPc.Tag = 0;
        titPd.Tag = 0;

        if (pA.Tag.ToString() == "0")
        {
          titPa.BackColor = Color.MediumSeaGreen;
          titPa.Tag = 1;
        }
        else if (pB.Tag.ToString() == "0")
        {
          titPb.BackColor = Color.MediumSeaGreen;
          titPb.Tag = 1;
        }
        else if (pC.Tag.ToString() == "0")
        {
          titPc.BackColor = Color.MediumSeaGreen;
          titPc.Tag = 1;
        }
        else if (pD.Tag.ToString() == "0")
        {
          titPd.BackColor = Color.MediumSeaGreen;
          titPd.Tag = 1;
        }
      }
      else if (e.KeyData == Keys.S)
      {
        titPa.BackColor = Color.White;
        titPb.BackColor = Color.White;
        titPc.BackColor = Color.White;
        titPd.BackColor = Color.White;

        titPa.Tag = 0;
        titPb.Tag = 0;
        titPc.Tag = 0;
        titPd.Tag = 0;

        if (pA.Tag.ToString() == "1")
        {
          titPa.BackColor = Color.MediumSeaGreen;
          titPa.Tag = 1;
        }
        else if (pB.Tag.ToString() == "1")
        {
          titPb.BackColor = Color.MediumSeaGreen;
          titPb.Tag = 1;
        }
        else if (pC.Tag.ToString() == "1")
        {
          titPc.BackColor = Color.MediumSeaGreen;
          titPc.Tag = 1;
        }
        else if (pD.Tag.ToString() == "1")
        {
          titPd.BackColor = Color.MediumSeaGreen;
          titPd.Tag = 1;
        }
      }
      else if (e.KeyData == Keys.D)
      {
        titPa.BackColor = Color.White;
        titPb.BackColor = Color.White;
        titPc.BackColor = Color.White;
        titPd.BackColor = Color.White;

        titPa.Tag = 0;
        titPb.Tag = 0;
        titPc.Tag = 0;
        titPd.Tag = 0;

        if (pA.Tag.ToString() == "2")
        {
          titPa.BackColor = Color.MediumSeaGreen;
          titPa.Tag = 1;
        }
        else if (pB.Tag.ToString() == "2")
        {
          titPb.BackColor = Color.MediumSeaGreen;
          titPb.Tag = 1;
        }
        else if (pC.Tag.ToString() == "2")
        {
          titPc.BackColor = Color.MediumSeaGreen;
          titPc.Tag = 1;
        }
        else if (pD.Tag.ToString() == "2")
        {
          titPd.BackColor = Color.MediumSeaGreen;
          titPd.Tag = 1;
        }
      }
      else if (e.KeyData == Keys.F)
      {
        titPa.BackColor = Color.White;
        titPb.BackColor = Color.White;
        titPc.BackColor = Color.White;
        titPd.BackColor = Color.White;

        titPa.Tag = 0;
        titPb.Tag = 0;
        titPc.Tag = 0;
        titPd.Tag = 0;

        if (pA.Tag.ToString() == "3")
        {
          titPa.BackColor = Color.MediumSeaGreen;
          titPa.Tag = 1;
        }
        else if (pB.Tag.ToString() == "3")
        {
          titPb.BackColor = Color.MediumSeaGreen;
          titPb.Tag = 1;
        }
        else if (pC.Tag.ToString() == "3")
        {
          titPc.BackColor = Color.MediumSeaGreen;
          titPc.Tag = 1;
        }
        else if (pD.Tag.ToString() == "3")
        {
          titPd.BackColor = Color.MediumSeaGreen;
          titPd.Tag = 1;
        }
      }
      else if (e.KeyData == Keys.Right)
      {
        if (titPa.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[0];

          if (aux == 3)
          {
            _posAtu[0] = 0;
            _posAtu[1] = _posAtu[1] + 1;
            _posAtu[2] = _posAtu[2] + 1;
            _posAtu[3] = _posAtu[3] + 1;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux + 1))
              {
                _posAtu[0] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
        else if (titPb.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[1];

          if (aux == 3)
          {
            _posAtu[0] = _posAtu[0] + 1;
            _posAtu[1] = 0;
            _posAtu[2] = _posAtu[2] + 1;
            _posAtu[3] = _posAtu[3] + 1;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux + 1))
              {
                _posAtu[1] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
        else if (titPc.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[2];

          if (aux == 3)
          {
            _posAtu[0] = _posAtu[0] + 1;
            _posAtu[1] = _posAtu[1] + 1;
            _posAtu[2] = 0;
            _posAtu[3] = _posAtu[3] + 1;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux + 1))
              {
                _posAtu[2] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
        else if (titPd.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[3];

          if (aux == 3)
          {
            _posAtu[0] = _posAtu[0] + 1;
            _posAtu[1] = _posAtu[1] + 1;
            _posAtu[2] = _posAtu[3] + 1;
            _posAtu[3] = 0;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux + 1))
              {
                _posAtu[3] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
      }
      else if (e.KeyData == Keys.Left)
      {
        if (titPa.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[0];

          if (aux == 0)
          {
            _posAtu[0] = 3;
            _posAtu[1] = _posAtu[1] - 1;
            _posAtu[2] = _posAtu[2] - 1;
            _posAtu[3] = _posAtu[3] - 1;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux - 1))
              {
                _posAtu[0] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
        else if (titPb.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[1];

          if (aux == 0)
          {
            _posAtu[0] = _posAtu[0] - 1;
            _posAtu[1] = 3;
            _posAtu[2] = _posAtu[2] - 1;
            _posAtu[3] = _posAtu[3] - 1;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux - 1))
              {
                _posAtu[1] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
        else if (titPc.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[2];

          if (aux == 0)
          {
            _posAtu[0] = _posAtu[0] - 1;
            _posAtu[1] = _posAtu[1] - 1;
            _posAtu[2] = 3;
            _posAtu[3] = _posAtu[3] - 1;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux - 1))
              {
                _posAtu[2] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
        else if (titPd.Tag.ToString() == "1")
        {
          int aux;
          aux = _posAtu[3];

          if (aux == 0)
          {
            _posAtu[0] = _posAtu[0] - 1;
            _posAtu[1] = _posAtu[1] - 1;
            _posAtu[2] = _posAtu[3] - 1;
            _posAtu[3] = 3;
          }
          else
          {
            for (int i = 0; i < 4; i++)
            {
              if (_posAtu[i] == (aux - 1))
              {
                _posAtu[3] = _posAtu[i];
                _posAtu[i] = aux;
                break;
              }
            }
          }
          pA.Location = new Point(_coord[_posAtu[0]], 12);
          pB.Location = new Point(_coord[_posAtu[1]], 12);
          pC.Location = new Point(_coord[_posAtu[2]], 12);
          pD.Location = new Point(_coord[_posAtu[3]], 12);
        }
      }
    }
  }
}
