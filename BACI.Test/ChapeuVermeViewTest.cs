//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BACI.Desk;

namespace BACI.Test
{
  [TestClass]
  public class ChapeuVermeViewTest
  {
    private ChapeuVermeView tela;

    [TestInitialize]
    public void InicializaTelaChapeuVerme()
    {
      tela = new ChapeuVermeView();
    }

    [TestMethod]
    public void DeterminaLetraA()
    {
      Assert.AreEqual(tela.Letra(0), "A");
    }

    [TestMethod]
    public void DeterminaLetraS()
    {
      Assert.AreEqual(tela.Letra(1), "S");
    }

    [TestMethod]
    public void DeterminaLetraD()
    {
      Assert.AreEqual(tela.Letra(2), "D");
    }

    [TestMethod]
    public void DeterminaLetraF()
    {
      Assert.AreEqual(tela.Letra(3), "F");
    }

    [TestMethod]
    public void DeterminaLetraErrado()
    {
      Assert.AreEqual(tela.Letra(6), "");
    }

    [TestMethod]
    public void VerificaNumAle()
    {
      int num = tela.NumAle();
      Assert.IsTrue((num >= 1) && (num <= 23));
    }


  }
}
