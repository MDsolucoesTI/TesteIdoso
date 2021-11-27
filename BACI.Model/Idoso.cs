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
using System.Threading.Tasks;
using BACI.Lib;

namespace BACI.Model
{
  public class Idoso
  {
    #region Fields


    private string _fullName;
    private string _cpf;
    private string _cidade;
    private string _estado;
    private string _profissao;
    private string _sexo;
    private string _qualDefFisica;
    private string _qualDoenca;
    private string _qualMedica;

    private int _escolaridade;
    private int _trabAtual;

    private bool _destro;
    private bool _defFisica;
    private bool _defVisual;
    private bool _usaLente;
    private bool _defAuditi;
    private bool _usaEquipa;
    private bool _doenDiag;
    private bool _usaMedica;
    private bool _usoConti;


    private DateTime _dataNasc;

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

    /// <summary>
    /// Cidade - Nome da cidade  de origem do idoso, só admite letras e espaço
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - Nome da Cidade de origem do Idoso</returns>
    public string Cidade
    {
      get => _cidade;
      set
      {
        if (value.Trim().Length > 0)
        {
          if (Validacao.SoLetras(value))
          {
            _cidade = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos letras e espaços para cidade");
          }
        }
        else
        {
          throw new ArgumentException("É obrigatório informar uma cidade");
        }
      }
    }

    /// <summary>
    /// Estado - Sigla do Estado origem do idoso, só admite letras
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - Sigla do Estado rigem do idoso</returns>
    public string Estado
    {
      get => _estado;
      set
      {
        if (Validacao.ValidaUf(value))
        {
          _estado = value;
        }
        else
        {
          throw new ArgumentException("É obrigatório informar um Estado válido");
        }
      }
    }

    /// <summary>
    /// Profissao - Profissão exercida pelo idoso, só admite letras e espaço
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - Profissão exercida pelo Idoso</returns>
    public string Profissao
    {
      get => _profissao;
      set
      {
        if (value.Trim().Length > 0)
        {
          if (Validacao.SoLetras(value))
          {
            _profissao = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos letras e espaços para profissão");
          }
        }
        else
        {
          throw new ArgumentException("É obrigatório informar uma profissão");
        }
      }
    }

    /// <summary>
    /// QualDefFisica - A deficiëcnia física visível do idoso, só admite letras e espaço
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - A deficiëcnia física visível do idoso</returns>
    public string QualDefFisica
    {
      get => _qualDefFisica;
      set
      {
        if (value.Trim().Length > 0)
        {
          if (Validacao.SoLetras(value))
          {
            _qualDefFisica = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos letras e espaços para a deficiência física visível");
          }
        }
        else
        {
          _qualDefFisica = "NR";
        }
      }
    }

    /// <summary>
    /// Sexo - O sexo do idoso, só admite letras: M ou F
    /// </summary>
    /// <remarks>
    /// Recebe uma string, valida através de Expressões Regulares.
    /// Não é admitido uma string vazia ou somente com espaços.
    /// </remarks>
    /// <returns>string - O sexo do idoso</returns>
    public string Sexo
    {
      get => _sexo;
      set
      {
        if (value.Trim().Length > 0)
        {
          if ((value.ToUpper() == "M") || (value.ToUpper() == "F"))
          {
            _sexo = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos as letras M ou F");
          }
        }
        else
        {
          throw new ArgumentException("É obrigatório informar um sexo");
        }
      }
    }

    /// <summary>
    /// Escolaridade - Escolaridade do idoso
    /// </summary>
    /// <remarks>
    /// Recebe um número inteiro entre 1 e 4.
    /// </remarks>
    /// <returns>int - Escolaridade do idoso</returns>
    public int Escolaridade
    {
      get => _escolaridade;
      set
      {
        if ((value > 0) && (value <= 4))
        {
          _escolaridade = value;
        }
        else
        {
          throw new ArgumentException("É obrigatório informar a escolaridade");
        }
      }
    }

    /// <summary>
    /// TrabAtual - Situação de trabalho do idoso
    /// </summary>
    /// <remarks>
    /// Recebe um número inteiro entre 1 e 3.
    /// </remarks>
    /// <returns>int - Situação de trabalho do idoso</returns>
    public int TrabAtual
    {
      get => _trabAtual;
      set
      {
        if ((value > 0) && (value <= 3))
        {
          _trabAtual = value;
        }
        else
        {
          throw new ArgumentException("É obrigatório informar a situação de trabalho");
        }
      }
    }

    /// <summary>
    /// DefFisica - Se o idoso possui deficiência física visível
    /// </summary>
    /// <remarks>
    /// Recebe um valor verdadeiro ou falso.
    /// </remarks>
    /// <returns>bool - Idoso possui deficiência física visível</returns>
    public bool DefFisica
    {
      get => _defFisica;
      set => _defFisica = value;
    }

    /// <summary>
    /// DefFisica - Se o idoso possui deficiência visual
    /// </summary>
    /// <remarks>
    /// Recebe um valor verdadeiro ou falso.
    /// </remarks>
    /// <returns>bool - Idoso possui deficiência visual</returns>
    public bool DefVisual
    {
      get => _defVisual;
      set => _defVisual = value;
    }

    /// <summary>
    /// DefAuditi - Se o idoso possui deficiência auditiva
    /// </summary>
    /// <remarks>
    /// Recebe um valor verdadeiro ou falso.
    /// </remarks>
    /// <returns>bool - Idoso possui deficiência auditiva</returns>
    public bool DefAuditi
    {
      get => _defAuditi;
      set => _defAuditi = value;
    }

    /// <summary>
    /// DataNasc - data de nascimento do idoso
    /// </summary>
    /// <remarks>
    /// Recebe um valor verdadeiro ou falso.
    /// </remarks>
    /// <returns>DateTime - Data de nascimento do Idoso</returns>
    public DateTime DataNasc
    {
      get => _dataNasc;
      set
      {
        _dataNasc = value;
        DataAni = _dataNasc.ToString().Substring(0, 10);
      }
    }

    public bool UsaLente
    {
      get => _usaLente;
      set => _usaLente = value;
    }

    public bool UsaEquipa
    {
      get => _usaEquipa;
      set => _usaEquipa = value;
    }

    public bool DoenDiag
    {
      get => _doenDiag;
      set => _doenDiag = value;
    }

    public string QualDoenca
    {
      get => _qualDoenca;
      set
      {
        if (value.Trim().Length > 0)
        {
          if (Validacao.SoLetras(value))
          {
            _qualDoenca = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos letras e espaços para a doença diagnosticada");
          }
        }
        else
        {
          _qualDoenca = "NR";
        }
      }
    }

    public bool UsaMedica
    {
      get => _usaMedica;
      set => _usaMedica = value;
    }

    public bool UsoConti
    {
      get => _usoConti;
      set => _usoConti = value;
    }

    public bool Destro
    {
      get => _destro;
      set => _destro = value;
    }

    public string QualMedica
    {
      get => _qualMedica;
      set
      {
        if (value.Trim().Length > 0)
        {
          if (Validacao.SoLetras(value))
          {
            _qualMedica = value;
          }
          else
          {
            throw new ArgumentException("Só é aceitos letras e espaços para a medicamentos");
          }
        }
        else
        {
          _qualMedica = "NR";
        }
      }
    }

    public string DataAni { get; set; } //Melhor controle visual e de banco de dados

    public string Id { get; set; }

    #endregion

    #region Methods

    public Idoso()
    {
      this.Id = Guid.NewGuid().ToString();
    }

    #endregion

  }
}
