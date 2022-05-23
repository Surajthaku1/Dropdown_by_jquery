using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication53.ViewModel;

namespace WebApplication53.Models
{
    public class cascading
    {
        private DbConfig db = new DbConfig();

        public List<Entitybe> GetCountries()
        {
            SqlCommand cmd = new SqlCommand("sp_country",db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Entitybe> CountryList = new List<Entitybe>();
            while(reader.Read())
            {
                Entitybe obj = new Entitybe();
                obj.Id = (int)reader[0];
                obj.Name = reader[1].ToString();
                CountryList.Add(obj);
            }
            db.sql.Close();
            return CountryList;

        }

        public List<Entitybe> GetState(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_state", db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@id";
            parameter.Value = id;
            parameter.DbType = DbType.Int32;

            cmd.Parameters.Add(parameter);

            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Entitybe> StateList = new List<Entitybe>();
            while (reader.Read())
            {
                Entitybe obj = new Entitybe();
                obj.Id = (int)reader[0];
                obj.Name = reader[1].ToString();
               StateList.Add(obj);
            }
            db.sql.Close();
            return StateList;

        }

        public List<Entitybe> GetCity(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_city", db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@id";
            parameter.Value = id;
            parameter.DbType = DbType.Int32;

            cmd.Parameters.Add(parameter);

            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Entitybe> CityList = new List<Entitybe>();
            while (reader.Read())
            {
                Entitybe obj = new Entitybe();
                obj.Id = (int)reader[0];
                obj.Name = reader[1].ToString();
                CityList.Add(obj);
            }
            db.sql.Close();
            return CityList;

        }

    }
}