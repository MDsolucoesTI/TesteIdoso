//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BACI.Lib;

namespace BACI.Model
{
  public class Profissional
  {
    #region Fields


    private string _fullName;
    private string _cpf;
    private string _crp;
    private string _eMail;
    private string _userName; //nome do usuário contendo letras e números, sem espaços ou caracteres especiais
    private string _password; //Gerada através de código hash pelo sistema
    private string _celular;

    private int _acesso;

    private DateTime _iniLibera;
    private DateTime _fimLibera;

    #endregion

    #region Properties

    /// <summary>
    /// FullName - Nome completo do profissional, só admite letras e espaço
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - Nome Completo do Profissional</returns>
    public string FullName
    {
      get => _fullName;
      set
      {
        if (value.Trim().Length > 0)
        {
          if (Validacao.SoLetras(value))
          {
            _fullName = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos letras e espaços para nome");
          }
        }
        else
        {
          throw new ArgumentException("É obrigatório informar um nome");
        }
      }
    }

    /// <summary>
    /// CPF - CPF do profissional
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// Faz validação do CPF.
    /// </remarks>
    /// <returns>string - CPF do Profissional</returns>
    public string Cpf
    {
      get => _cpf;
      set
      {
        if (Validacao.SoNumero(value))
        {
          if (Validacao.ValidaCpf(value))
          {
            _cpf = value.Trim();
          }
          else
          {
            throw new ArgumentException("CPF invalido");
          }
        }
        else
        {
          throw new ArgumentException("CPF: Só é aceito números");
        }
      }
    }

    public string Crp
    {
      get => _crp;
      set => _crp = value;
    }

    /// <summary>
    /// EMail - eMail do profissional
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - eMail do Profissional</returns>
    public string EMail
    {
      get => _eMail;
      set
      {
        if (Validacao.ValMail(value))
        {
          _eMail = value;
        }
        else
        {
          throw new ArgumentException("E-Mail inválido");
        }
      }
    }

    /// <summary>
    /// UserName - Nome de usuário do profissional, só admite letras, no mínimo 4 iniciais e números
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - Nome de Usuário do Profissional</returns>
    public string UserName
    {
      get => _userName;
      set
      {
        int tam = value.Length;
        if ((tam >= 8) && (tam <= 20))
        {
          if (Validacao.SemEspaEspe(value))
          {
            _userName = value;
          }
          else
          {
            throw new ArgumentException("Usuário: Não é permitido espaços ou simbolos");
          }
        }
        else
        {
          throw new ArgumentException("Nome do Usuário deve ter entre 8 e 20 caracteres");
        }
      }
    }

    public string Password
    {
      get => _password;
      set => _password = value;
    }

    /// <summary>
    /// Celular - Número do Celular do profissional
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - Número do Celular do Profissional</returns>
    public string Celular
    {
      get => _celular;
      set
      {
        int tam = Validacao.LimpaNum(value).Length;
        if ((tam >= 8) && (tam <= 11))
        {
          if (Validacao.SoNumero(value))
          {
            _celular = value;
          }
          else
          {
            throw new ArgumentException("Número de Celular inválido");
          }
        }
        else
        {
          throw new ArgumentException("Celular: Só é aceito números");
        }
      }
    }

    public int Acesso
    {
      get => _acesso;
      set
      {
        if (Validacao.SoNumero(value.ToString()))
        {
          _acesso = value;
        }
        else
        {
          throw new ArgumentException("Nível de Acesso: Só é aceito números");
        }
      }
    }

    public DateTime IniLibera
    {
      get => _iniLibera;
      set
      {
        _iniLibera = value;
        DataIni = _iniLibera.ToString().Substring(0, 10);
      }
    }

    public DateTime FimLibera
    {
      get => _fimLibera;
      set
      {
        _fimLibera = value;
        DataFim = _fimLibera.ToString().Substring(0, 10);
      }
    }

    public string DataIni { get; set; } //Melhor controle visual e de banco de dados

    public string DataFim { get; set; } //Melhor controle visual e de banco de dados

    public string Id { get; set; }
    #endregion

    #region Methods

    public Profissional()
    {
      this.Id = Guid.NewGuid().ToString();
    }

    #endregion

  }
}
