//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BACI.Lib;

namespace BACI.Test
{
  [TestClass]
  public class ValidacaoTest
  {
    [TestMethod]
    public void TestaCpfCorretoComLiteral()
    {
      string cpf = "134.012.321-50";
      Assert.IsTrue(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfCorretoSemLiteral()
    {
      string cpf = "13401232150";
      Assert.IsTrue(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfCorretoComEspaco()
    {
      string cpf = " 134.012.321-50 ";
      Assert.IsTrue(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfErradoComLiteral()
    {
      string cpf = "134.013.321-50";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfErradoSemLiteral()
    {
      string cpf = "13401332150";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfRepeticao()
    {
      string cpf = "11111111111";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfSequencia()
    {
      string cpf = "12345678909";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfCurto()
    {
      string cpf = "1340123215";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpfLongo()
    {
      string cpf = "134012321501";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpf1DigitoErrado()
    {
      string cpf = "13401232160";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpf2DigErradoNZero()
    {
      string cpf = "64177890048";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaCpf2DigErradoZero()
    {
      string cpf = "13401232155";
      Assert.IsFalse(Validacao.ValidaCpf(cpf));
    }

    [TestMethod]
    public void TestaSoNumComEspaco()
    {
      string num = " 123456 ";
      Assert.IsTrue(Validacao.SoNumero(num));
    }

    [TestMethod]
    public void TestaSoNumLiteral()
    {
      string num = "12.34-56";
      Assert.IsTrue(Validacao.SoNumero(num));
    }

    [TestMethod]
    public void TestaSoNumErrado()
    {
      string num = "12a34-56";
      Assert.IsFalse(Validacao.SoNumero(num));
    }

    [TestMethod]
    public void TestaValMailCorreto()
    {
      string mail = "teste@gmail.com";
      Assert.IsTrue(Validacao.ValMail(mail));
    }

    [TestMethod]
    public void TestaValMailCorreto2()
    {
      string mail = "teste@gmail.com.br";
      Assert.IsTrue(Validacao.ValMail(mail));
    }

    [TestMethod]
    public void TestaMailErrado()
    {
      string mail = "teste#gmail.com.br";
      Assert.IsFalse(Validacao.ValMail(mail));
    }

    [TestMethod]
    public void TestaSemEspaEspeCorreto()
    {
      string nom = "Fulano2018";
      Assert.IsTrue(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeCorreto1()
    {
      string nom = "Fula2018Silva";
      Assert.IsTrue(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeCorreto2()
    {
      string nom = "Fula2018Silva01";
      Assert.IsTrue(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeCorreto3()
    {
      string nom = "Fulano2018Silva01";
      Assert.IsTrue(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeErrado()
    {
      string nom = "Fulano 2018";
      Assert.IsFalse(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeErrado2()
    {
      string nom = "Fulano&2018";
      Assert.IsFalse(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeErrado3()
    {
      string nom = "Fulano& 2018";
      Assert.IsFalse(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSemEspaEspeErrado4()
    {
      string nom = "Ful2018Sil01";
      Assert.IsFalse(Validacao.SemEspaEspe(nom));
    }

    [TestMethod]
    public void TestaSoLetrasCorreto()
    {
      string nom = "Fulano Da Silva";
      Assert.IsTrue(Validacao.SoLetras(nom));
    }

    [TestMethod]
    public void TestaSoLetrasErradoNum()
    {
      string nom = "Fulano Da Silva 123";
      Assert.IsFalse(Validacao.SoLetras(nom));
    }

    [TestMethod]
    public void TestaSoLetrasErradoEspe()
    {
      string nom = "Fulano D@ Silva";
      Assert.IsFalse(Validacao.SoLetras(nom));
    }

    [TestMethod]
    public void TestaValCepCorreto()
    {
      string cep = "12200-100";
      Assert.IsTrue(Validacao.ValCep(cep));
    }

    [TestMethod]
    public void TestaValCepErrado()
    {
      string cep = "1200-100";
      Assert.IsFalse(Validacao.ValCep(cep));
    }

    [TestMethod]
    public void TestaValUfCorreto01()
    {
      string estado = "SP";
      Assert.IsTrue(Validacao.ValidaUf(estado));
    }

    [TestMethod]
    public void TestaValUfCorreto02()
    {
      string estado = "PE";
      Assert.IsTrue(Validacao.ValidaUf(estado));
    }

    [TestMethod]
    public void TestaValUfErrado01()
    {
      string estado = "UK";
      Assert.IsFalse(Validacao.ValidaUf(estado));
    }

    [TestMethod]
    public void TestaValUfErrado02()
    {
      string estado = "";
      Assert.IsFalse(Validacao.ValidaUf(estado));
    }

    [TestMethod]
    public void TestaValUfErrado03()
    {
      string estado = "  ";
      Assert.IsFalse(Validacao.ValidaUf(estado));
    }
  }
}
