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
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BACI.Lib
{
  public static class Validacao
  {
    #region Methods

    /// <summary>
    /// Validação do número do CPF do Profissional
    /// </summary>
    /// <remarks>
    /// Recebe o número do CPF do Profissional. Valida conforme dados da Receita Federal.
    /// O número é verifica quanto a repetições, que mascaram a validação e sequências.
    /// O digito  verificar é recalculado para confronto.
    /// Caracteres literais, se houver, são retirados. 
    /// </remarks>
    /// <param name="vrCpf">Tipo string - Número do CPF do Profissional</param>
    /// <returns>bool - Informando da validade, ou não, do CPF</returns>
    public static bool ValidaCpf(string vrCpf)
    {
      //retirada de literais & espaços
      string valor = vrCpf.Trim();
      valor = valor.Replace(".", "");
      valor = valor.Replace("-", "");
      //verifica comprimento padrão
      if (valor.Length != 11)
      {
        return false;
      }
      //verifica repetição de valores
      bool igual = true;
      for (int i = 1; i < 11 && igual; i++)
      {
        if (valor[i] != valor[0])
        {
          igual = false;
        }
      }
      //invalida repetição e sequência
      if (igual || valor == "12345678909")
      {
        return false;
      }
      //extração de valores para calculo de digito
      int[] numeros = new int[11];
      for (int i = 0; i < 11; i++)
      {
        numeros[i] = int.Parse(valor[i].ToString());
      }
      //calcula 1º digito
      int soma = 0;
      for (int i = 0; i < 9; i++)
      {
        soma += (10 - i) * numeros[i];
      }
      //valida 1º digito
      int resultado = soma % 11;
      if (resultado == 1 || resultado == 0)
      {
        if (numeros[9] != 0)
        {
          return false;
        }
      }
      else if (numeros[9] != 11 - resultado)
      {
        return false;
      }
      //calcula 2º digito
      soma = 0;
      for (int i = 0; i < 10; i++)
      {
        soma += (11 - i) * numeros[i];
      }
      //valida 2º digito
      resultado = soma % 11;
      if (resultado == 1 || resultado == 0)
      {
        if (numeros[10] != 0)
        {
          return false;
        }
      }
      else if (numeros[10] != 11 - resultado)
      {
        return false;
      }
      //se CPF ok
      return true;
    }

    /// <summary>
    /// Verifica se a string só contém números
    /// </summary>
    /// <remarks>
    /// Através de Expressão Regular é verificado a ocorrência de números 
    /// em uma string. Não é suportado espaços ou caracteres especiais. 
    /// </remarks>
    /// <param name="valor">Tipo string - número informado</param>
    /// <returns>bool - se o valor informado é numérico ou não</returns>
    public static bool SoNumero(string valor)
    {
      const string num = @"^[0-9]+$";
      //Retira literais
      valor = Validacao.LimpaNum(valor);
      Match rex = Regex.Match(valor, num);
      return rex.Success;
    }

    /// <summary>
    /// Verifica se a string contém e-mail valido
    /// </summary>
    /// <remarks>
    /// Através de Expressão Regular é verificado a ocorrência de caracteres 
    /// em uma string que formam um e-mail. Não é suportado espaços. 
    /// </remarks>
    /// <param name="valor">Tipo string - e-mail informado</param>
    /// <returns>bool - se o valor informado é um e-mail ou não</returns>
    public static bool ValMail(string valor)
    {
      const string mail = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";

      Match rex = Regex.Match(valor, mail);
      return rex.Success;
    }

    /// <summary>
    /// Verifica se a string contém apenas letras, no mínimo 4 iniciais, e números, sem espaços e caracteres especiais
    /// </summary>
    /// <remarks>
    /// Através de Expressão Regular é verificado a ocorrência de letras e números 
    /// em uma string. Não é suportado espaços e caracteres especiais. 
    /// </remarks>
    /// <param name="valor">Tipo string - valor informado</param>
    /// <returns>bool - se o valor informado só contém letras e números ou não</returns>
    public static bool SemEspaEspe(string valor)
    {
      const string nom = @"^[a-zA-Z]{4}[a-zA-Z0-9]+$";

      Match rex = Regex.Match(valor, nom);
      return rex.Success;
    }

    /// <summary>
    /// Verifica se a string contém apenas letras e espaços
    /// </summary>
    /// <remarks>
    /// Através de Expressão Regular é verificado a ocorrência de letras e espaços 
    /// em uma string. Não é suportado caracteres especiais. 
    /// </remarks>
    /// <param name="valor">Tipo string - valor informado</param>
    /// <returns>bool - se o valor informado só contém letras e espaços ou não</returns>
    public static bool SoLetras(string valor)
    {
      const string nom = @"^[aA-zZáéíóúàèìòùâêîôûãõç]+((\s[aA-zZáéíóúàèìòùâêîôûãõç]+)+)?$";

      Match rex = Regex.Match(valor, nom);
      return rex.Success;
    }

    //verificar se o campo é um CEP valido
    /// <summary>
    /// Verifica se a string contém um CEP valido
    /// </summary>
    /// <remarks>
    /// Através de Expressão Regular é verificado a ocorrência de números 
    /// em uma string que formam um CEP. Não é suportado espaços e caracteres especiais. 
    /// </remarks>
    /// <param name="valor">Tipo string - CEP informado</param>
    /// <returns>bool - se o valor informado é um CEP ou não</returns>
    public static bool ValCep(string valor)
    {
      const string nom = @"^\d{5}\-?\d{3}$";

      Match rex = Regex.Match(valor, nom);
      return rex.Success;
    }

    /// <summary>
    /// Retira caracteres especiais da string numérica
    /// </summary>
    /// <remarks>
    /// Através de troca e substituição (Replace) da string numérica 
    /// os caracteres especiais "().-" são removido. 
    /// </remarks>
    /// <param name="valor">Tipo string - string numérica informada</param>
    /// <returns>string - string númerica só com os números</returns>
    public static string LimpaNum(string valor)
    {
      valor = valor.Trim();
      valor = valor.Replace(".", "");
      valor = valor.Replace("-", "");
      valor = valor.Replace("(", "");
      valor = valor.Replace(")", "");

      return valor;
    }

    /// <summary>
    /// Verifica se a string é uma UF válida
    /// </summary>
    /// <remarks>
    /// Através de troca e substituição (Replace) da string numérica 
    /// os caracteres especiais "().-" são removido. 
    /// </remarks>
    /// <param name="valor">Tipo string - string numérica informada</param>
    /// <returns>string - string númerica só com os números</returns>
    public static bool ValidaUf(string valor)
    {
      bool valido = false;
      string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
      valido = estados.Contains(valor);

      return valido;
    }



    #endregion
  }
}
