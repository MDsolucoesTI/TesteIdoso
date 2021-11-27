//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BACI.Controller;
using BACI.Model;

namespace BACI.Test
{
  [TestClass]
  public class ProfissionalControllerTest
  {
    private Profissional _objTeste1;
    private Profissional _objTeste2;
    private Profissional _objTeste3;
    private Profissional _objTeste4;

    [TestInitialize]
    public void InicializaProfissional()
    {
      _objTeste1 = new Profissional();
      _objTeste2 = new Profissional();
      _objTeste3 = new Profissional();
      _objTeste4 = new Profissional();

      //Profissional 01
      _objTeste1.Id = Guid.NewGuid().ToString();

      _objTeste1.FullName = "Fulano de Tal da Silva Prado";
      _objTeste1.Cpf = "012.123.123-25";
      _objTeste1.Crp = "CRP01234";
      _objTeste1.EMail = "fulano.prado@gmail.com";
      _objTeste1.UserName = "fulanopradro";
      _objTeste1.Password = "Teste123";
      _objTeste1.Celular = "(11)11111-1111";

      _objTeste1.Acesso = 0;

      _objTeste1.IniLibera = Convert.ToDateTime("10/05/2018");
      _objTeste1.FimLibera = Convert.ToDateTime("10/10/2018");

      //Profissional 02
      _objTeste2.Id = Guid.NewGuid().ToString();

      _objTeste2.FullName = "Beltrano de Oliveira";
      _objTeste2.Cpf = "134.012.321-50";
      _objTeste2.Crp = "CRP56789";
      _objTeste2.EMail = "beltranooliveira@gmail.com";
      _objTeste2.UserName = "Beloliveira";
      _objTeste2.Password = "Teste123";
      _objTeste2.Celular = "(22)2222-1111";

      _objTeste2.Acesso = 1;

      _objTeste2.IniLibera = Convert.ToDateTime("10/05/2018");
      _objTeste2.FimLibera = Convert.ToDateTime("10/10/2018");

      //Profissional 03
      _objTeste3.Id = Guid.NewGuid().ToString();

      _objTeste3.FullName = "Ciclano da Silva";
      _objTeste3.Cpf = "077.643.219-23";
      _objTeste3.Crp = "CRP97541";
      _objTeste3.EMail = "ciclanosilva@gmail.com";
      _objTeste3.UserName = "Ciclanosilva";
      _objTeste3.Password = "Teste123";
      _objTeste3.Celular = "(32)33232-3311";

      _objTeste3.Acesso = 1;

      _objTeste3.IniLibera = Convert.ToDateTime("10/05/2018");
      _objTeste3.FimLibera = Convert.ToDateTime("10/10/2018");

    }

    [TestMethod]
    public void InserirDadosProf()
    {
      bool teste = ProfissionalController.Add(_objTeste1);
      Assert.IsTrue(teste);
    }

    [TestMethod]
    public void InserirEVerificarDadosProf()
    {
      string crp = _objTeste2.Crp;

      bool teste = ProfissionalController.Add(_objTeste2);

      _objTeste4 = ProfissionalController.GetProfissional(crp);

      Assert.AreEqual(_objTeste2.Id, _objTeste4.Id);
    }

    [TestMethod]
    public void LocalizaUser()
    {
      string user = _objTeste1.UserName;

      _objTeste4 = ProfissionalController.GetUser(user);

      Assert.AreEqual(_objTeste1.UserName, _objTeste4.UserName);
    }

    [TestMethod]
    public void AlteraDadosProf01()
    {
      _objTeste4 = _objTeste2;
      _objTeste4.FullName = "Teste de Alteracao";

      bool teste = ProfissionalController.Update(_objTeste4);

      Assert.IsTrue(teste);
    }

    [TestMethod]
    public void AlteraDadosProf02()
    {
      string nome = "Teste de Alteracao";
      string crp = _objTeste2.Crp;

      _objTeste4 = ProfissionalController.GetProfissional(crp);

      Assert.AreEqual(_objTeste4.FullName, nome);
    }

    [TestMethod]
    public void VerificaListaProfs()
    {
      ProfissionalController.Add(_objTeste3);
      List<Profissional> lista = ProfissionalController.GetProfissionais();

      Assert.AreEqual(lista[0].FullName, _objTeste1.FullName);
      Assert.AreNotEqual(lista[1].FullName, _objTeste2.FullName);
    }

    [TestMethod]
    public void VerificaExclusao01()
    {
      bool teste = ProfissionalController.Delete(_objTeste1.Crp);

      Assert.IsTrue(teste);
    }

    [TestMethod]
    public void VerificaExclusao02()
    {
      _objTeste4 = ProfissionalController.GetProfissional(_objTeste1.Crp);

      Assert.IsNull(_objTeste4);
    }

    [TestMethod]
    public void VerificaExclusao03()
    {
      bool teste1 = ProfissionalController.Delete(_objTeste2.Crp);
      bool teste2 = ProfissionalController.Delete(_objTeste3.Crp);

      Assert.IsTrue(teste1);
      Assert.IsTrue(teste2);
    }
  }
}
