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
  public class PrincipalTest
  {
    [TestMethod]
    public void CriandoTelaInicial()
    {
      Principal telaIni = new Principal();
      Assert.IsNotNull(telaIni);
    }
  }
}
