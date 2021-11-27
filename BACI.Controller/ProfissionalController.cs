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
  public class ProfissionalController
  {
    public static List<Profissional> GetProfissionais()
    {
      List<Profissional> profs = new List<Profissional>();

      SQLiteDataAdapter da = null;
      DataSet dt = new DataSet();
      try
      {
        string sqlCommand = "SELECT * FROM Profissionais";
        da = new SQLiteDataAdapter(sqlCommand, ConectionFactory.DbConnection());
        da.Fill(dt, "Profissionais");
        for (int col = 0; col < dt.Tables[0].Rows.Count; col++)
        {
          Profissional pro = new Profissional
          {
            Id = Convert.ToString(dt.Tables[0].Rows[col]["Id"]),
            FullName = Convert.ToString(dt.Tables[0].Rows[col]["Nome"]),
            Cpf = Convert.ToString(dt.Tables[0].Rows[col]["Cpf"]),
            Crp = Convert.ToString(dt.Tables[0].Rows[col]["Crp"]),
            EMail = Convert.ToString(dt.Tables[0].Rows[col]["Email"]),
            UserName = Convert.ToString(dt.Tables[0].Rows[col]["Usuario"]),
            Password = Convert.ToString(dt.Tables[0].Rows[col]["Senha"]),
            Celular = Convert.ToString(dt.Tables[0].Rows[col]["Celular"]),

            Acesso = Convert.ToInt32(dt.Tables[0].Rows[col]["Acesso"]),

            IniLibera = Convert.ToDateTime(dt.Tables[0].Rows[col]["DataIni"]),
            FimLibera = Convert.ToDateTime(dt.Tables[0].Rows[col]["DataFim"]),
          };
          profs.Add(pro);
        }

        return profs;
      }
      catch (Exception e)
      {
        return null;
      }
    }


    public static Profissional GetProfissional(string crp)
    {
      Profissional pro = new Profissional();
      SQLiteDataAdapter da = null;
      DataSet dt = new DataSet();
      try
      {
        string sqlCommand = "SELECT * FROM Profissionais WHERE Crp = '" + crp + "'";
        da = new SQLiteDataAdapter(sqlCommand, ConectionFactory.DbConnection());
        da.Fill(dt, "Profissionais");

        pro.Id = Convert.ToString(dt.Tables[0].Rows[0]["Id"]);
        pro.FullName = Convert.ToString(dt.Tables[0].Rows[0]["Nome"]);
        pro.Cpf = Convert.ToString(dt.Tables[0].Rows[0]["Cpf"]);
        pro.Crp = Convert.ToString(dt.Tables[0].Rows[0]["Crp"]);
        pro.EMail = Convert.ToString(dt.Tables[0].Rows[0]["Email"]);
        pro.UserName = Convert.ToString(dt.Tables[0].Rows[0]["Usuario"]);
        pro.Password = Convert.ToString(dt.Tables[0].Rows[0]["Senha"]);
        pro.Celular = Convert.ToString(dt.Tables[0].Rows[0]["Celular"]);

        pro.Acesso = Convert.ToInt32(dt.Tables[0].Rows[0]["Acesso"]);

        pro.IniLibera = Convert.ToDateTime(dt.Tables[0].Rows[0]["DataIni"]);
        pro.FimLibera = Convert.ToDateTime(dt.Tables[0].Rows[0]["DataFim"]);

        return pro;
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public static Profissional GetUser(string username)
    {
      Profissional pro = new Profissional();
      SQLiteDataAdapter da = null;
      DataSet dt = new DataSet();
      try
      {
        string sqlCommand = "SELECT * FROM Profissionais WHERE Usuario = '" + username + "'";
        da = new SQLiteDataAdapter(sqlCommand, ConectionFactory.DbConnection());
        da.Fill(dt);

        pro.Id = Convert.ToString(dt.Tables[0].Rows[0]["Id"]);
        pro.FullName = Convert.ToString(dt.Tables[0].Rows[0]["Nome"]);
        pro.Cpf = Convert.ToString(dt.Tables[0].Rows[0]["Cpf"]);
        pro.Crp = Convert.ToString(dt.Tables[0].Rows[0]["Crp"]);
        pro.EMail = Convert.ToString(dt.Tables[0].Rows[0]["Email"]);
        pro.UserName = Convert.ToString(dt.Tables[0].Rows[0]["Usuario"]);
        pro.Password = Convert.ToString(dt.Tables[0].Rows[0]["Senha"]);
        pro.Celular = Convert.ToString(dt.Tables[0].Rows[0]["Celular"]);

        pro.Acesso = Convert.ToInt32(dt.Tables[0].Rows[0]["Acesso"]);

        pro.IniLibera = Convert.ToDateTime(dt.Tables[0].Rows[0]["DataIni"]);
        pro.FimLibera = Convert.ToDateTime(dt.Tables[0].Rows[0]["DataFim"]);

        return pro;
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public static bool Add(Profissional profissional)
    {
      try
      {
        using (var cmd = ConectionFactory.DbConnection().CreateCommand())
        {
          cmd.CommandText = "INSERT INTO Profissionais(" +
                    "Id, " +
                    "Nome, " +
                    "Cpf, " +
                    "Crp, " +
                    "Email, " +
                    "Usuario, " +
                    "Senha, " +
                    "Celular, " +
                    "Acesso, " +
                    "DataIni, " +
                    "DataFim)" +
                  " values (" +
                    "@Id, " +
                    "@Nome, " +
                    "@Cpf, " +
                    "@Crp, " +
                    "@Email, " +
                    "@Usuario, " +
                    "@Senha, " +
                    "@Celular, " +
                    "@Acesso, " +
                    "@DataIni, " +
                    "@DataFim)";

          cmd.Parameters.AddWithValue("@Id", profissional.Id);
          cmd.Parameters.AddWithValue("@Nome", profissional.FullName);
          cmd.Parameters.AddWithValue("@Cpf", profissional.Cpf);
          cmd.Parameters.AddWithValue("@Crp", profissional.Crp);
          cmd.Parameters.AddWithValue("@Email", profissional.EMail);
          cmd.Parameters.AddWithValue("@Usuario", profissional.UserName);
          cmd.Parameters.AddWithValue("@Senha", profissional.Password);
          cmd.Parameters.AddWithValue("@Celular", profissional.Celular);
          cmd.Parameters.AddWithValue("@Acesso", profissional.Acesso);
          cmd.Parameters.AddWithValue("@DataIni", profissional.DataIni);
          cmd.Parameters.AddWithValue("@DataFim", profissional.DataFim);

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

    public static bool Update(Profissional profissional)
    {
      try
      {
        using (var cmd = ConectionFactory.DbConnection().CreateCommand())
        {
          cmd.CommandText = "UPDATE Profissionais SET " +
                    "Nome" + " = @Nome" + ", " +
                    "Cpf" + " = @Cpf" + ", " +
                    "Email" + " = @Email" + ", " +
                    "Usuario" + " = @Usuario" + ", " +
                    "Senha" + " = @Senha" + ", " +
                    "Celular" + " = @Celular" + ", " +
                    "Acesso" + " = @Acesso" + ", " +
                    "DataIni" + " = @DataIni" + ", " +
                    "DataFim" + " = @DataFim" +
                    " WHERE Crp = @Crp";

          cmd.Parameters.AddWithValue("@Nome", profissional.FullName);
          cmd.Parameters.AddWithValue("@Cpf", profissional.Cpf);
          cmd.Parameters.AddWithValue("@Crp", profissional.Crp);
          cmd.Parameters.AddWithValue("@Email", profissional.EMail);
          cmd.Parameters.AddWithValue("@Usuario", profissional.UserName);
          cmd.Parameters.AddWithValue("@Senha", profissional.Password);
          cmd.Parameters.AddWithValue("@Celular", profissional.Celular);
          cmd.Parameters.AddWithValue("@Acesso", profissional.Acesso);
          cmd.Parameters.AddWithValue("@DataIni", profissional.DataIni);
          cmd.Parameters.AddWithValue("@DataFim", profissional.DataFim);

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

    public static bool Delete(string crp)
    {
      try
      {
        using (var cmd = ConectionFactory.DbConnection().CreateCommand())
        {
          cmd.CommandText = "DELETE FROM Profissionais WHERE Crp = '" + crp + "'";

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
