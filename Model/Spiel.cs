using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections.ObjectModel;

namespace Model
{
    public class Spiel
    {
        OleDbConnection con = new OleDbConnection();
        ObservableCollection<Spieler> lstSpieler;
        String best;

        public ObservableCollection<Spieler> LstSpieler
        {
            get
            {
                return lstSpieler;
            }

            set
            {
                lstSpieler = value;
            }
        }

        public string Best
        {
            get
            {
                return best;
            }

            set
            {
                best = value;
            }
        }

        public Spiel()
        {
            con = new OleDbConnection(Properties.SettingsDB.Default.DBCon);
            LstSpieler = new ObservableCollection<Spieler>();
        }
        public void LoadSpieler() // Spieler werden aus der Datenbank geladen
        {
            
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "tSpieler";
            cmd.CommandType = System.Data.CommandType.TableDirect;
            OpenConnection();
            OleDbDataReader reader = cmd.ExecuteReader();
            LstSpieler.Clear();
            while(reader.Read())
            {
                Spieler sp = new Spieler {Id=reader.GetInt32(0), Name = reader.GetString(1), Punktzahl = reader.GetInt32(2) };
                LstSpieler.Add(sp);
            }
            reader.Close();
            
        }

        private void OpenConnection()
        {
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void BesterSpieler()
        {
            for (int i = 1; i < LstSpieler.Count; i++)
            {
                if (LstSpieler[i].Punktzahl > LstSpieler[i - 1].Punktzahl)
                {
                    Best = "       1." + LstSpieler[i].Name + " : " + LstSpieler[i].Punktzahl;
                }
            }
        }
        public Spieler Registrieren(String name)
        {
            Spieler s = null;
           
                s = new Spieler();
                s.Name = name;
                s.Punktzahl = 0;
                this.SpeichernSP(s);
                LstSpieler.Add(s);
        
            return s;


        }
        public void SpeichernSP(Spieler s)
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.Parameters.AddWithValue("Name", s.Name);
            cmd.Parameters.AddWithValue("Punkte", s.Punktzahl);
            cmd.CommandText = "Insert into tSpieler(Spielername,Punktestand)Values(Name,Punkte)";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@identity from tSpieler";
            int id = (int)cmd.ExecuteScalar();
            s.Id = id;
        }
        public void Speichern()
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.Parameters.Add("Punkte", OleDbType.Integer);
            cmd.Parameters.Add("Key", OleDbType.Integer);
            cmd.CommandText = "Update tSpieler set Punktestand = Punkte where SpielerID = Key";
            foreach(Spieler sp in LstSpieler)
            {
                cmd.Parameters["Punkte"].Value = sp.Punktzahl;
                cmd.Parameters["Key"].Value = sp.Id;
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void Starten(String name)
        {
            
        }

    }
}
