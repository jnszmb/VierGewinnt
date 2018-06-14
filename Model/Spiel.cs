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

        public Spiel()
        {
            con = new OleDbConnection(Properties.SettingsDB.Default.DBCon);
            LstSpieler = new ObservableCollection<Spieler>();
        }
        public void LoadSpieler()
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
    }
}
