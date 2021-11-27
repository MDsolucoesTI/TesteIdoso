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
  public class ProfissionalTest
  {
    private Profissional _objTeste;

    [TestInitialize]
    public void InicializaProfissional()
    {
      _objTeste = new Profissional();
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
    public void SetUserNameCorretoSoLetra()
    {
      string user = "FulanoSilva";
      _objTeste.UserName = user;
      Assert.AreEqual(_objTeste.UserName, user);
    }

    [TestMethod]
    public void SetUserNameCorretoLetraNum()
    {
      string user = "FulanoSilva2018";
      _objTeste.UserName = user;
      Assert.AreEqual(_objTeste.UserName, user);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetUserNameErradoCurto()
    {
      _objTeste.UserName = "Fula123";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetUserNameErradoLongo()
    {
      _objTeste.UserName = "Muitas Letras num Nome Atrapalha";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetUserNameErradoEspaco()
    {
      _objTeste.UserName = "            ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetUserNameErradoSoNum()
    {
      _objTeste.UserName = "1234567890";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetUserNameErradoVazio()
    {
      _objTeste.UserName = "";
    }

    [TestMethod]
    public void SetEmailCorretoCom()
    {
      string mail = "fulanosilva@gmail.com";
      _objTeste.EMail = mail;
      Assert.AreEqual(_objTeste.EMail, mail);
    }

    [TestMethod]
    public void SetEmailCorretoComBr()
    {
      string mail = "fulanosilva@gmail.com.br";
      _objTeste.EMail = mail;
      Assert.AreEqual(_objTeste.EMail, mail);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoTrocaArobaSemCom()
    {
      _objTeste.EMail = "fulano2018#gmail";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoTrocaAroba()
    {
      _objTeste.EMail = "fulano2018#gmail.com";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoSemCom()
    {
      _objTeste.EMail = "fulano2018@gmail";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoSemAroba()
    {
      _objTeste.EMail = "fulano2018gmail.com";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoSoCaracter()
    {
      _objTeste.EMail = "fulano2018";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoVazio()
    {
      _objTeste.EMail = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetMailErradoEspacos()
    {
      _objTeste.EMail = "        ";
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
    public void SetCelularCorretoCaracComNove()
    {
      string cel = "(12)92641.1234";
      _objTeste.Celular = cel;
      Assert.AreEqual(_objTeste.Celular, cel);
    }

    [TestMethod]
    public void SetCelularCorretoCaracSemNove()
    {
      string cel = "(12)2641.1234";
      _objTeste.Celular = cel;
      Assert.AreEqual(_objTeste.Celular, cel);
    }

    [TestMethod]
    public void SetCelularCorretoSoNum()
    {
      string cel = "12926411234";
      _objTeste.Celular = cel;
      Assert.AreEqual(_objTeste.Celular, cel);
    }

    [TestMethod]
    public void SetCelularCorretoCaracSemArea()
    {
      string cel = "92641.1234";
      _objTeste.Celular = cel;
      Assert.AreEqual(_objTeste.Celular, cel);
    }

    [TestMethod]
    public void SetCelularCorretoSoNumSemArea()
    {
      string cel = "926411234";
      _objTeste.Celular = cel;
      Assert.AreEqual(_objTeste.Celular, cel);
    }

    [TestMethod]
    public void SetCelularCorretoSoNumSemNove()
    {
      string cel = "26411234";
      _objTeste.Celular = cel;
      Assert.AreEqual(_objTeste.Celular, cel);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCelularErradoVazio()
    {
      _objTeste.Celular = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCelularErradoEspacos()
    {
      _objTeste.Celular = "           ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCelularErradoNumPequano()
    {
      _objTeste.Celular = "345678";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCelularErradoNumGrande()
    {
      _objTeste.Celular = "129876755443";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCelularErradoLetras()
    {
      _objTeste.Celular = "a3456908t";
    }

    [TestMethod]
    public void SetCrpVerificacao()
    {
      _objTeste.Crp = "123456";
      Assert.AreEqual(_objTeste.Crp, "123456");
    }

    [TestMethod]
    public void SetEnderecoVerificacao()
    {
      _objTeste.Endereco = "Rua Sei lá qual";
      Assert.AreEqual(_objTeste.Endereco, "Rua Sei lá qual");
    }

    [TestMethod]
    public void SetComplementoVerificacao()
    {
      _objTeste.Complemento = "Bloco o Prédio Z";
      Assert.AreEqual(_objTeste.Complemento, "Bloco o Prédio Z");
    }

    [TestMethod]
    public void SetCepCorretoSoNum()
    {
      string cep = "11700111";
      _objTeste.Cep = cep;
      Assert.AreEqual(_objTeste.Cep, cep);
    }

    [TestMethod]
    public void SetCepCorretoNumDash()
    {
      string cep = "11700-111";
      _objTeste.Cep = cep;
      Assert.AreEqual(_objTeste.Cep, cep);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCepErradoVazio()
    {
      _objTeste.Cep = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCepErradoEspacos()
    {
      _objTeste.Cep = "        ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCepErradoMuitosNum()
    {
      _objTeste.Cep = "111115568";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCepErradoPoucosNun()
    {
      _objTeste.Cep = "15789";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetCepErradoLetras()
    {
      _objTeste.Cep = "aa678904";
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
    public void SetGetNumEnd()
    {
      int valor = 10;
      _objTeste.NumEnd = valor;
      Assert.AreEqual(_objTeste.NumEnd, valor);
    }

    [TestMethod]
    public void SetGetEndereco()
    {
      string valor = "Rua Sem Nome";
      _objTeste.Endereco = valor;
      Assert.AreEqual(_objTeste.Endereco, valor);
    }

    [TestMethod]
    public void SetGetCrp()
    {
      string valor = "CRP123456";
      _objTeste.Crp = valor;
      Assert.AreEqual(_objTeste.Crp, valor);
    }

    [TestMethod]
    public void SetGetComplemento()
    {
      string valor = "Bloco A - 10º Andar";
      _objTeste.Complemento = valor;
      Assert.AreEqual(_objTeste.Complemento, valor);
    }

    [TestMethod]
    public void SetGetBairro()
    {
      string valor = "Bairro Novo";
      _objTeste.Bairro = valor;
      Assert.AreEqual(_objTeste.Bairro, valor);
    }

    [TestMethod]
    public void SetGetIniLibera()
    {
      DateTime valor = DateTime.Now;
      _objTeste.IniLibera = valor;
      Assert.AreEqual(_objTeste.IniLibera, valor);
    }

    [TestMethod]
    public void SetGetFimLibera()
    {
      DateTime valor = DateTime.Now;
      _objTeste.FimLibera = valor;
      Assert.AreEqual(_objTeste.FimLibera, valor);
    }

    [TestMethod]
    public void SetGetPassword()
    {
      string valor = "senha";
      _objTeste.Password = valor;
      Assert.AreEqual(_objTeste.Password, valor);
    }

    [TestMethod]
    public void SetBairroCorreto()
    {
      string name = "Morro Baixo";
      _objTeste.Bairro = name;
      Assert.AreEqual(_objTeste.Bairro, name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetBairroErradoNumero()
    {
      _objTeste.Bairro = "123";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetBairroErradoVazio()
    {
      _objTeste.Bairro = "";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetBairroErradoEspaco()
    {
      _objTeste.Bairro = "    ";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void SetBairroErradoLetraNum()
    {
      _objTeste.Bairro = "Morro 123 Alto";
    }

    [TestMethod]
    public void VerificaDataIni()
    {
      _objTeste.IniLibera = Convert.ToDateTime("10/10/2000");
      Assert.AreEqual(_objTeste.DataIni, "10/10/2000");
    }

    [TestMethod]
    public void VerificaDataFim()
    {
      _objTeste.FimLibera = Convert.ToDateTime("10/10/2000");
      Assert.AreEqual(_objTeste.DataFim, "10/10/2000");
    }
  }
}
