//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2018
// Sistema...........: Bateria de Avaliação Computadorizada para Idosos
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACI.Controller
{
  public class ConectionFactory
  {
    private static SQLiteConnection sqliteConnection;

    public static SQLiteConnection DbConnection()
    {
      sqliteConnection = new SQLiteConnection("Data Source=c:\\Dados\\baci.sqlite; Version=3;");
      sqliteConnection.Open();
      return sqliteConnection;
    }

    public static bool CriarBanco()
    {
      FileInfo arq = new FileInfo(@"c:\Dados\baci.sqlite");
      try
      {
        if (!arq.Exists)
        {
          SQLiteConnection.CreateFile(@"c:\Dados\baci.sqlite");
        }

        return true;
      }
      catch (Exception e)
      {
        return false;
      }
    }

    public static bool CriarTabelas()
    {
      try
      {
        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "CREATE TABLE IF NOT EXISTS Profissionais" +
                  "(Id" + " Varchar(36)," +
                   "Nome" + " Varchar(60)," +
                   "Cpf" + " Varchar(11)," +
                   "Crp" + " Varchar(15)," +
                   "Email" + " Varchar(60)," +
                   "Usuario" + " Varchar(20)," +
                   "Senha" + " Varchar(512)," +
                   "Celular" + " Varchar(11)," +
                   "Acesso" + " int," +
                   "DataIni" + " Varchar(10)," +
                   "DataFim" + " Varchar(10)," +
                  "PRIMARY KEY(Id ASC))";
          cmd.ExecuteNonQuery();
        }

        using (var cmd = DbConnection().CreateCommand())
        {
          cmd.CommandText = "CREATE TABLE IF NOT EXISTS Idosos" +
                  "(Id" + " Varchar(36), " +
                  "Nome" + " Varchar(60), " +
                  "Cpf" + " Varchar(11), " +
                  "Cidade" + " Varchar(40), " +
                  "Estado" + " Varchar(2), " +
                  "Profissao" + " Varchar(40), " +
                  "Destro" + " Varchar(1), " +
                  "Sexo" + " Varchar(1), " +
                  "QualDefFisica" + " Varchar(60), " +
                  "QualDoenca" + " Varchar(60), " +
                  "QualMedica" + " Varchar(60), " +
                  "Escola" + " int, " +
                  "TrabAtua" + " int, " +
                  "DefFisica" + " Varchar(1), " +
                  "DefVisual" + " Varchar(1), " +
                  "DefAuditi" + " Varchar(1), " +
                  "UsaLente" + " Varchar(1), " +
                  "UsaEquipa" + " Varchar(1), " +
                  "DoenDiag" + " Varchar(1), " +
                  "UsaMedica" + " Varchar(1), " +
                  "UsoCont" + " Varchar(1), " +
                  "DataAni" + " Varchar(10), " +
                  "PRIMARY KEY(Id ASC))";
          cmd.ExecuteNonQuery();
        }

        return true;
      }
      catch (Exception e)
      {
        return false;
      }
    }
  }
}
