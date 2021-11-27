//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BACI.Model;

namespace BACI.Test
{
  [TestClass]
  public class IdosoTest
  {
    private Idoso _objTeste;

    [TestInitialize]
    public void InicializaProfissional()
    {
      _objTeste = new Idoso();
    }

    [TestMethod]
    public void SetFullNameCorreto()
    {
      string name = "Fulano de Tal";
      _objTeste.FullName = name;
      Assert.AreEqual(_objTeste.FullName, name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetFullNameErradoNumero()
    {
      _objTeste.FullName = "123";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetFullNameErradoVazio()
    {
      _objTeste.FullName = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetFullNameErradoEspaco()
    {
      _objTeste.FullName = "    ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetFullNameErradoLetraNum()
    {
      _objTeste.FullName = "Fulano 123 da Silva";
    }

    [TestMethod]
    public void SetCpfCorretoSoNumero()
    {
      string cpf = "01212312325";
      _objTeste.Cpf = cpf;
      Assert.AreEqual(_objTeste.Cpf, cpf);
    }

    [TestMethod]
    public void SetCpfCorretoNumeroCaracter()
    {
      string cpf = "012.123.123-25";
      _objTeste.Cpf = cpf;
      Assert.AreEqual(_objTeste.Cpf, cpf);
    }

    [TestMethod]
    public void SetCpfCorretoNumDigiZero()
    {
      string cpf = "134.012.321-50";
      _objTeste.Cpf = cpf;
      Assert.AreEqual(_objTeste.Cpf, cpf);
    }

    [TestMethod]
    public void SetCpfCorretoNumDigiAlto()
    {
      string cpf = "169.746.549-87";
      _objTeste.Cpf = cpf;
      Assert.AreEqual(_objTeste.Cpf, cpf);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoVazio()
    {
      _objTeste.Cpf = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoEspacos()
    {
      _objTeste.Cpf = "           ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoSequencia()
    {
      _objTeste.Cpf = "12345678900";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoRepeticao()
    {
      _objTeste.Cpf = "11111111111";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoSquanciaCarac()
    {
      _objTeste.Cpf = "123.456.789-00";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoRepeticaoCarac()
    {
      _objTeste.Cpf = "111.111.111-11";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoSegundoDigi()
    {
      _objTeste.Cpf = "134.012.321-55";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCpfErradoNumMeio()
    {
      _objTeste.Cpf = "134.120.321-50";
    }

    [TestMethod]
    public void SetCidadeCorreto()
    {
      string name = "Alto do Pariso";
      _objTeste.Cidade = name;
      Assert.AreEqual(_objTeste.Cidade, name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCidadeErradoNumero()
    {
      _objTeste.Cidade = "123";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCidadeErradoVazio()
    {
      _objTeste.Cidade = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCidadeErradoEspaco()
    {
      _objTeste.Cidade = "    ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCidadeErradoLetraNum()
    {
      _objTeste.Cidade = "Alto 123 do Paraiso";
    }

    [TestMethod]
    public void SetEstadoCorreto()
    {
      string name = "RJ";
      _objTeste.Estado = name;
      Assert.AreEqual(_objTeste.Estado, name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetEstadoErrado()
    {
      _objTeste.Estado = "SF";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetEstadoErradoNumero()
    {
      _objTeste.Estado = "12";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetEstadoErradoVazio()
    {
      _objTeste.Estado = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetEstadoErradoEspaco()
    {
      _objTeste.Estado = "  ";
    }

    [TestMethod]
    public void SetProfissaoCorreto()
    {
      string name = "Engenheiro Civil";
      _objTeste.Profissao = name;
      Assert.AreEqual(_objTeste.Profissao, name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetProfissaoErradoNumero()
    {
      _objTeste.Profissao = "123";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetProfissaoErradoVazio()
    {
      _objTeste.Profissao = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetProfissaoErradoEspaco()
    {
      _objTeste.Profissao = "    ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetProfissaoErradoLetraNum()
    {
      _objTeste.Profissao = "Engenheiro 123 Civil";
    }

    [TestMethod]
    public void SetQualDefFisicaCorreto()
    {
      string name = "Atrofia Braço";
      _objTeste.QualDefFisica = name;
      Assert.AreEqual(_objTeste.QualDefFisica, name);
    }

    [TestMethod]
    public void SetQualDefFisicaCorretoVazio()
    {
      string name = "";
      _objTeste.QualDefFisica = name;
      Assert.AreEqual(_objTeste.QualDefFisica, name);
    }

    [TestMethod]
    public void SetQualDefFisicaCorretoEspaco()
    {
      string name = "     ";
      _objTeste.QualDefFisica = name;
      Assert.AreEqual(_objTeste.QualDefFisica, name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetQualDefFisicaErradoNumero()
    {
      _objTeste.QualDefFisica = "123";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetQualDefFisicaErradoLetraNum()
    {
      _objTeste.QualDefFisica = "Atrafia 123 Braço";
    }

    [TestMethod]
    public void SetSexoCorretoF()
    {
      string valor = "F";
      _objTeste.Sexo = valor;
      Assert.AreEqual(_objTeste.Sexo, valor);
    }

    [TestMethod]
    public void SetSexoCorretof()
    {
      string valor = "f";
      _objTeste.Sexo = valor;
      Assert.AreEqual(_objTeste.Sexo, valor);
    }

    [TestMethod]
    public void SetSexoCorretoM()
    {
      string valor = "M";
      _objTeste.Sexo = valor;
      Assert.AreEqual(_objTeste.Sexo, valor);
    }

    [TestMethod]
    public void SetSexoCorretom()
    {
      string valor = "m";
      _objTeste.Sexo = valor;
      Assert.AreEqual(_objTeste.Sexo, valor);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetSexoErrado()
    {
      _objTeste.Sexo = "X";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetSexoErradoVazio()
    {
      _objTeste.Sexo = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetSexoErradoEspaco()
    {
      _objTeste.Sexo = " ";
    }

    [TestMethod]
    public void SetEscolaridadeCorreto()
    {
      int valor = 2;
      _objTeste.Escolaridade = valor;
      Assert.AreEqual(_objTeste.Escolaridade, valor);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetEscolaridadeErradoAbaixo()
    {
      _objTeste.Escolaridade = 0;
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetEscolaridadeErradoAcima()
    {
      _objTeste.Escolaridade = 5;
    }

    [TestMethod]
    public void SetTrabAtualCorreto()
    {
      int valor = 2;
      _objTeste.TrabAtual = valor;
      Assert.AreEqual(_objTeste.TrabAtual, valor);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetTrabAtualErradoAbaixo()
    {
      _objTeste.TrabAtual = 0;
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetTrabAtualErradoAcima()
    {
      _objTeste.TrabAtual = 5;
    }

    [TestMethod]
    public void SetDefFisicaCorretoTrue()
    {
      bool valor = true;
      _objTeste.DefFisica = valor;
      Assert.IsTrue(_objTeste.DefFisica);
    }

    [TestMethod]
    public void SetDefFisicaCorretoFalse()
    {
      bool valor = false;
      _objTeste.DefFisica = valor;
      Assert.IsFalse(_objTeste.DefFisica);
    }

    [TestMethod]
    public void SetDefVisualCorretoTrue()
    {
      bool valor = true;
      _objTeste.DefVisual = valor;
      Assert.IsTrue(_objTeste.DefVisual);
    }

    [TestMethod]
    public void SetDefVisualCorretoFalse()
    {
      bool valor = false;
      _objTeste.DefVisual = valor;
      Assert.IsFalse(_objTeste.DefVisual);
    }

    [TestMethod]
    public void SetDefAuditiCorretoTrue()
    {
      bool valor = true;
      _objTeste.DefAuditi = valor;
      Assert.IsTrue(_objTeste.DefAuditi);
    }

    [TestMethod]
    public void SetDefAuditiCorretoFalse()
    {
      bool valor = false;
      _objTeste.DefAuditi = valor;
      Assert.IsFalse(_objTeste.DefAuditi);
    }
  }
}
