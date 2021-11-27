//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BACI.Controller;

namespace BACI.Test
{
  [TestClass]
  public class ConectionFactoryTest
  {
    [TestMethod]
    public void VerificaCriandoBanco()
    {
      bool teste = ConectionFactory.CriarBanco();

      Assert.IsTrue(teste);
    }

    [TestMethod]
    public void VerificaCriandoTabelas()
    {
      bool teste = ConectionFactory.CriarTabelas();

      Assert.IsTrue(teste);
    }
  }
}
