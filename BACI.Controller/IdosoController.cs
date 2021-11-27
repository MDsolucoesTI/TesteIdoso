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
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACI.Model;

namespace BACI.Controller
{
  public class IdosoController
  {
    public static List<Idoso> GetIdosos()
    {
      List<Idoso> idosos = new List<Idoso>();

      SQLiteDataAdapter da = null;
      DataSet dt = new DataSet();
      try
      {
        string sqlCommand = "SELECT * FROM Idosos";
        da = new SQLiteDataAdapter(sqlCommand, ConectionFactory.DbConnection());
        da.Fill(dt, "Idosos");
        for (int col = 0; col < dt.Tables[0].Rows.Count; col++)
        {
          Idoso ido = new Idoso
          {
            Id = Convert.ToString(dt.Tables[0].Rows[col]["Id"]),
            FullName = Convert.ToString(dt.Tables[0].Rows[col]["Nome"]),
            Cpf = Convert.ToString(dt.Tables[0].Rows[col]["Cpf"]),
            Cidade = Convert.ToString(dt.Tables[0].Rows[col]["Cidade"]),
            Estado = Convert.ToString(dt.Tables[0].Rows[col]["Estado"]),
            Profissao = Convert.ToString(dt.Tables[0].Rows[col]["Profissao"]),
            Destro = (Convert.ToString(dt.Tables[0].Rows[col]["Destro"]) == "S"),
            Sexo = Convert.ToString(dt.Tables[0].Rows[col]["Sexo"]),
            QualDefFisica = Convert.ToString(dt.Tables[0].Rows[col]["QualDefFisica"]),
            QualDoenca = Convert.ToString(dt.Tables[0].Rows[col]["QualDoenca"]),
            QualMedica = Convert.ToString(dt.Tables[0].Rows[col]["QualMedica"]),
            Escolaridade = Convert.ToInt32(dt.Tables[0].Rows[col]["Escola"]),
            TrabAtual = Convert.ToInt32(dt.Tables[0].Rows[col]["TrabAtua"]),
            DefFisica = (Convert.ToString(dt.Tables[0].Rows[col]["DefFisica"]) == "S"),
            DefVisual = (Convert.ToString(dt.Tables[0].Rows[col]["DefVisual"]) == "S"),
            DefAuditi = (Convert.ToString(dt.Tables[0].Rows[col]["DefAuditi"]) == "S"),
            UsaLente = (Convert.ToString(dt.Tables[0].Rows[col]["UsaLente"]) == "S"),
            UsaEquipa = (Convert.ToString(dt.Tables[0].Rows[col]["UsaEquipa"]) == "S"),
            DoenDiag = (Convert.ToString(dt.Tables[0].Rows[col]["DoenDiag"]) == "S"),
            UsaMedica = (Convert.ToString(dt.Tables[0].Rows[col]["UsaMedica"]) == "S"),
            UsoConti = (Convert.ToString(dt.Tables[0].Rows[col]["UsoConti"]) == "S"),
            DataNasc = Convert.ToDateTime(dt.Tables[0].Rows[col]["DataFim"]),
          };
          idosos.Add(ido);
        }

        return idosos;
      }
      catch (Exception e)
      {
        return null;
      }
    }


    public static Idoso GetIdoso(string cpf)
    {
      Idoso ido = new Idoso();
      SQLiteDataAdapter da = null;
      DataSet dt = new DataSet();
      try
      {
        string sqlCommand = "SELECT * FROM Idosos WHERE Cpf = '" + cpf + "'";
        da = new SQLiteDataAdapter(sqlCommand, ConectionFactory.DbConnection());
        da.Fill(dt, "Idosos");

        ido.Id = Convert.ToString(dt.Tables[0].Rows[0]["Id"]);
        ido.FullName = Convert.ToString(dt.Tables[0].Rows[0]["Nome"]);
        ido.Cpf = Convert.ToString(dt.Tables[0].Rows[0]["Cpf"]);
        ido.Cidade = Convert.ToString(dt.Tables[0].Rows[0]["Cidade"]);
        ido.Estado = Convert.ToString(dt.Tables[0].Rows[0]["Estado"]);
        ido.Profissao = Convert.ToString(dt.Tables[0].Rows[0]["Profissao"]);
        ido.Destro = (Convert.ToString(dt.Tables[0].Rows[0]["Destro"]) == "S");
        ido.Sexo = Convert.ToString(dt.Tables[0].Rows[0]["Sexo"]);
        ido.QualDefFisica = Convert.ToString(dt.Tables[0].Rows[0]["QualDefFisica"]);
        ido.QualDoenca = Convert.ToString(dt.Tables[0].Rows[0]["QualDoenca"]);
        ido.QualMedica = Convert.ToString(dt.Tables[0].Rows[0]["QualMedica"]);
        ido.Escolaridade = Convert.ToInt32(dt.Tables[0].Rows[0]["Escola"]);
        ido.TrabAtual = Convert.ToInt32(dt.Tables[0].Rows[0]["TrabAtua"]);
        ido.DefFisica = (Convert.ToString(dt.Tables[0].Rows[0]["DefFisica"]) == "S");
        ido.DefVisual = (Convert.ToString(dt.Tables[0].Rows[0]["DefVisual"]) == "S");
        ido.DefAuditi = (Convert.ToString(dt.Tables[0].Rows[0]["DefAuditi"]) == "S");
        ido.UsaLente = (Convert.ToString(dt.Tables[0].Rows[0]["UsaLente"]) == "S");
        ido.UsaEquipa = (Convert.ToString(dt.Tables[0].Rows[0]["UsaEquipa"]) == "S");
        ido.DoenDiag = (Convert.ToString(dt.Tables[0].Rows[0]["DoenDiag"]) == "S");
        ido.UsaMedica = (Convert.ToString(dt.Tables[0].Rows[0]["UsaMedica"]) == "S");
        ido.UsoConti = (Convert.ToString(dt.Tables[0].Rows[0]["UsoConti"]) == "S");
        ido.DataNasc = Convert.ToDateTime(dt.Tables[0].Rows[0]["DataFim"]);

        return ido;
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public static bool Add(Idoso ido)
    {
      try
      {
        using (var cmd = ConectionFactory.DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO Idosos(" +
                    "Id, " +
                    "Nome, " +
                    "Cpf, " +
                    "Cidade, " +
                    "Estado, " +
                    "Profissao, " +
                    "Destro" +
                    "Sexo, " +
                    "QualDefFisica, " +
                    "QualDoenca, " +
                    "QualMedica, " +
                    "Escola, " +
                    "TrabAtua, " +
                    "DefFisica, " +
                    "DefVisual, " +
                    "DefAuditi, " +
                    "UsaLente, " +
                    "UsaEquipa, " +
                    "DoenDiag, " +
                    "UsaMedica, " +
                    "UsoCont, " +
                    "DataAni)" +
                  " values (" +
                    "@Id, " +
                    "@Nome, " +
                    "@Cpf, " +
                    "@Cidade, " +
                    "@Estado, " +
                    "@Profissao, " +
                    "@Destro, " +
                    "@Sexo, " +
                    "@QualDefFisica, " +
                    "@QualDoenca, " +
                    "@QualMedica, " +
                    "@Escola, " +
                    "@TrabAtua, " +
                    "@DefFisica, " +
                    "@DefVisual, " +
                    "@DefAuditi, " +
                    "@UsaLente, " +
                    "@UsaEquipa, " +
                    "@DoenDiag, " +
                    "@UsaMedica, " +
                    "@UsoCont, " +
                    "@DataAni)";

          cmd.Parameters.AddWithValue("@Id, ", ido.Id);
          cmd.Parameters.AddWithValue("@Nome, ", ido.FullName);
          cmd.Parameters.AddWithValue("@Cpf, ", ido.Cpf);
          cmd.Parameters.AddWithValue("@Cidade, ", ido.Cidade);
          cmd.Parameters.AddWithValue("@Estado, ", ido.Estado);
          cmd.Parameters.AddWithValue("@Profissao, ", ido.Profissao);
          cmd.Parameters.AddWithValue("@Destro, ", ido.Destro ? "S" : "N");
          cmd.Parameters.AddWithValue("@Sexo, ", ido.Sexo);
          cmd.Parameters.AddWithValue("@QualDefFisica, ", ido.QualDefFisica);
          cmd.Parameters.AddWithValue("@QualDoenca, ", ido.QualDoenca);
          cmd.Parameters.AddWithValue("@QualMedica, ", ido.QualMedica);
          cmd.Parameters.AddWithValue("@Escola, ", ido.Escolaridade);
          cmd.Parameters.AddWithValue("@TrabAtua, ", ido.TrabAtual);
          cmd.Parameters.AddWithValue("@DefFisica, ", ido.DefFisica ? "S" : "N");
          cmd.Parameters.AddWithValue("@DefVisual, ", ido.DefVisual ? "S" : "N");
          cmd.Parameters.AddWithValue("@DefAuditi, ", ido.DefAuditi ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsaLente, ", ido.UsaLente ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsaEquipa, ", ido.UsaEquipa ? "S" : "N");
          cmd.Parameters.AddWithValue("@DoenDiag, ", ido.DoenDiag ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsaMedica, ", ido.UsaMedica ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsoCont, ", ido.UsoConti ? "S" : "N");
          cmd.Parameters.AddWithValue("@DataAni", ido.DataNasc);

          if (cmd.ExecuteNonQuery() == 0)
          {
            return false;
          }
        }

        return true;
      }
      catch (Exception e)
      {
        return false;
      }
    }

    public static bool Update(Idoso ido)
    {
      try
      {
        using (var cmd = ConectionFactory.DbConnection().CreateCommand())
        {
          cmd.CommandText = "UPDATE Idosos SET " +
                    "Id" + " = " + "@Id" + ", " +
                    "Nome" + " = " + "@Nome" + ", " +
                    "Cidade" + " = " + "@Cidade" + ", " +
                    "Estado" + " = " + "@Estado" + ", " +
                    "Destro" + " = " + "@Destro" + ", " +
                    "Profissao" + " = " + "@Profissao" + ", " +
                    "Sexo" + " = " + "@Sexo" + ", " +
                    "QualDefFisica" + " = " + "@QualDefFisica" + ", " +
                    "QualDoenca" + " = " + "@QualDoenca" + ", " +
                    "QualMedica" + " = " + "@QualMedica" + ", " +
                    "Escola" + " = " + "@Escola" + ", " +
                    "TrabAtua" + " = " + "@TrabAtua" + ", " +
                    "DefFisica" + " = " + "@DefFisica" + ", " +
                    "DefVisual" + " = " + "@DefVisual" + ", " +
                    "DefAuditi" + " = " + "@DefAuditi" + ", " +
                    "UsaLente" + " = " + "@UsaLente" + ", " +
                    "UsaEquipa" + " = " + "@UsaEquipa" + ", " +
                    "DoenDiag" + " = " + "@DoenDiag" + ", " +
                    "UsaMedica" + " = " + "@UsaMedica" + ", " +
                    "UsoCont" + " = " + "@UsoCont" + ", " +
                    "DataAni" + " = " + "@DataAni" +
                    " WHERE Cpf = @Cpf";

          cmd.Parameters.AddWithValue("@Id, ", ido.Id);
          cmd.Parameters.AddWithValue("@Nome, ", ido.FullName);
          cmd.Parameters.AddWithValue("@Cpf, ", ido.Cpf);
          cmd.Parameters.AddWithValue("@Cidade, ", ido.Cidade);
          cmd.Parameters.AddWithValue("@Estado, ", ido.Estado);
          cmd.Parameters.AddWithValue("@Profissao, ", ido.Profissao);
          cmd.Parameters.AddWithValue("@Destro, ", ido.Destro ? "S" : "N");
          cmd.Parameters.AddWithValue("@Sexo, ", ido.Sexo);
          cmd.Parameters.AddWithValue("@QualDefFisica, ", ido.QualDefFisica);
          cmd.Parameters.AddWithValue("@QualDoenca, ", ido.QualDoenca);
          cmd.Parameters.AddWithValue("@QualMedica, ", ido.QualMedica);
          cmd.Parameters.AddWithValue("@Escola, ", ido.Escolaridade);
          cmd.Parameters.AddWithValue("@TrabAtua, ", ido.TrabAtual);
          cmd.Parameters.AddWithValue("@DefFisica, ", ido.DefFisica ? "S" : "N");
          cmd.Parameters.AddWithValue("@DefVisual, ", ido.DefVisual ? "S" : "N");
          cmd.Parameters.AddWithValue("@DefAuditi, ", ido.DefAuditi ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsaLente, ", ido.UsaLente ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsaEquipa, ", ido.UsaEquipa ? "S" : "N");
          cmd.Parameters.AddWithValue("@DoenDiag, ", ido.DoenDiag ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsaMedica, ", ido.UsaMedica ? "S" : "N");
          cmd.Parameters.AddWithValue("@UsoCont, ", ido.UsoConti ? "S" : "N");
          cmd.Parameters.AddWithValue("@DataAni", ido.DataAni);

          if (cmd.ExecuteNonQuery() == 0)
          {
            return false;
          }
        }

        return true;
      }
      catch (Exception e)
      {
        return false;
      }
    }

    public static bool Delete(string cpf)
    {
      try
      {
        using (var cmd = ConectionFactory.DbConnection().CreateCommand())
        {
          cmd.CommandText = "DELETE FROM Idosos WHERE Cpf = '" + cpf + "'";

          if (cmd.ExecuteNonQuery() == 0)
          {
            return false;
          }
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
