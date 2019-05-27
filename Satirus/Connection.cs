using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

public class Connection
{

    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public Connection()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        string connStr = "server=localhost;user=root;port=3306;password=;";
        using (var conn = new MySqlConnection(connStr))
        using (var cmd = conn.CreateCommand())
        {
            try
            {
                conn.Open();
                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `satirus`;";
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(MySqlException ex)
            {
                MessageBox.Show("We could't connect to the local database, check if your XAMPP is properly configured and try again!","Database Error!");
                Application.Exit();
            }
        }
        server = "localhost";
        database = "satirus";
        uid = "root";
        password = "";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }


    //open connection to database
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {

            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }
    //Insert statement
    public void Insert(string table, string data, string values)
    {
        string query = "INSERT INTO " + table + " (" + data + ") VALUES(" + values + ")";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
    public void Insertignore(string table, string data, string values)
    {
        string query = "INSERT IGNORE INTO " + table + " (" + data + ") VALUES(" + values + ")";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }


    //Delete statement
    public void Delete(string table, string colname, string value)
    {
        string query = "DELETE FROM " + table + " WHERE " + colname + "=" + value + "";

        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }
    }
    //Select statement
    public List<string>[] SelectPJList()
    {
        string query = "SELECT * FROM pj";
        //Create a list to store the result
        List<string>[] list = new List<string>[20];
        list[0] = new List<string>();
        list[1] = new List<string>();
        list[2] = new List<string>();
        list[3] = new List<string>();
        list[4] = new List<string>();
        list[5] = new List<string>();
        list[6] = new List<string>();
        list[7] = new List<string>();
        list[8] = new List<string>();
        list[9] = new List<string>();
        list[10] = new List<string>();
        list[11] = new List<string>();
        list[12] = new List<string>();
        list[13] = new List<string>();
        list[14] = new List<string>();
        list[15] = new List<string>();
        list[16] = new List<string>();
        list[17] = new List<string>();
        list[18] = new List<string>();
        list[19] = new List<string>();


        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list

            while (dataReader.Read())
            {
                list[0].Add(dataReader["id"] + "");
                list[1].Add(dataReader["name"] + "");
                list[2].Add(dataReader["level"] + "");
                list[3].Add(dataReader["race"] + "");
                list[4].Add(dataReader["order"] + "");
                list[5].Add(dataReader["karma"] + "");
                list[6].Add(dataReader["exp"] + "");
                list[7].Add(dataReader["str"] + "");
                list[8].Add(dataReader["int"] + "");
                list[9].Add(dataReader["res"] + "");
                list[10].Add(dataReader["agi"] + "");
                list[11].Add(dataReader["cha"] + "");
                list[12].Add(dataReader["luc"] + "");
                list[13].Add(dataReader["bstr"] + "");
                list[14].Add(dataReader["bint"] + "");
                list[15].Add(dataReader["bres"] + "");
                list[16].Add(dataReader["bagi"] + "");
                list[17].Add(dataReader["bcha"] + "");
                list[18].Add(dataReader["bluc"] + "");
                list[19].Add(dataReader["hp"] + "");


            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;
        }
        else
        {
            return list;
        }
    }
    public List<string>[] SelectItems(string owner, bool magic)
    {

        string query = "SELECT * FROM inventory where owner = " + owner;

        if (magic)
        {
            query = "SELECT * FROM spellbook where owner = " + owner;
        }

        //Create a list to store the result
        List<string>[] list = new List<string>[2];
        list[0] = new List<string>();
        list[1] = new List<string>();
        

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list

            while (dataReader.Read())
            {
                if(magic)
                    list[0].Add(dataReader["spell"] + "");
                else
                    list[0].Add(dataReader["item"] + "");
                list[1].Add(dataReader["description"] + "");            
            }
            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;
        }
        else
        {
            return list;
        }
    }
    public List<string> getPJ(string id)
    {
        string query = "SELECT * FROM pj WHERE id = '" + id + "'";
        List<string> res = new List<string>();


        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                res.Insert(0, dataReader["id"] + "");
                res.Insert(1, dataReader["name"] + "");
                res.Insert(2, dataReader["level"] + "");
                res.Insert(3, dataReader["race"] + "");
                res.Insert(4, dataReader["order"] + "");
                res.Insert(5, dataReader["karma"] + "");
                res.Insert(6, dataReader["exp"] + "");
                res.Insert(7, dataReader["str"] + "");
                res.Insert(8, dataReader["int"] + "");
                res.Insert(9, dataReader["res"] + "");
                res.Insert(10, dataReader["agi"] + "");
                res.Insert(11, dataReader["cha"] + "");
                res.Insert(12, dataReader["luc"] + "");
                res.Insert(13, dataReader["bstr"] + "");
                res.Insert(14, dataReader["bint"] + "");
                res.Insert(15, dataReader["bres"] + "");
                res.Insert(16, dataReader["bagi"] + "");
                res.Insert(17, dataReader["bcha"] + "");
                res.Insert(18, dataReader["bluc"] + "");
                res.Insert(19, dataReader["hp"] + "");
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed


            return res;
        }
        else
        {
            return res;
        }
    }
    public string getID(string pjName)
    {
        string query = "SELECT * FROM pj WHERE name = '" + pjName + "'";
        string res = "";


        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                res = (dataReader["id"] + "");
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed


            return res;
        }
        else
        {
            return res;
        }
    }
    public void createdatabase()
    {



        string query1 =
   "CREATE TABLE IF NOT EXISTS `order` (" +
   "`id` int(3) unsigned NOT NULL AUTO_INCREMENT," +
   "`order` varchar(50) NOT NULL," +
   "PRIMARY KEY(`id`)" +
   " ) ENGINE = InnoDB DEFAULT CHARSET = latin1 ROW_FORMAT = COMPACT;";
        string query2 =
   "CREATE TABLE IF NOT EXISTS `karma` (" +
   "`id` int(3) unsigned NOT NULL AUTO_INCREMENT," +
   "`karma` varchar(50) NOT NULL," +
   " PRIMARY KEY(`id`)" +
   ") ENGINE = InnoDB DEFAULT CHARSET = latin1;";
        string query3 =
"CREATE TABLE IF NOT EXISTS `pj` (" +
"`id` int(11) unsigned NOT NULL AUTO_INCREMENT," +
"`name` varchar(50) DEFAULT NULL," +
"`level` tinyint(3) unsigned NOT NULL DEFAULT '1'," +
"`race` varchar(50) DEFAULT NULL," +
"`order` int(3) unsigned NOT NULL," +
"`karma` int(3) unsigned NOT NULL," +
"`exp` int(11) unsigned DEFAULT NULL," +
"`str` int(11) DEFAULT NULL," +
"`int` int(11) DEFAULT NULL," +
"`res` int(11) DEFAULT NULL," +
"`agi` int(11) DEFAULT NULL," +
"`cha` int(11) DEFAULT NULL," +
"`luc` int(11) DEFAULT NULL," +
"`bstr` int(11) DEFAULT NULL," +
"`bint` int(11) DEFAULT NULL," +
"`bres` int(11) DEFAULT NULL," +
"`bagi` int(11) DEFAULT NULL," +
"`bcha` int(11) DEFAULT NULL," +
"`bluc` int(11) DEFAULT NULL," +
"`hp` int(11) DEFAULT NULL," +
"PRIMARY KEY(`id`)," +
"KEY `FKorder` (`order`)," +
"KEY `FKkarma` (`karma`)," +
"CONSTRAINT `FKkarma` FOREIGN KEY (`karma`) REFERENCES `karma` (`id`) ON DELETE CASCADE ON UPDATE CASCADE," +
"CONSTRAINT `FKorder` FOREIGN KEY (`order`) REFERENCES `order` (`id`) ON DELETE CASCADE ON UPDATE CASCADE" +
") ENGINE = InnoDB DEFAULT CHARSET = latin1;";
        string query4 =
"CREATE TABLE IF NOT EXISTS `inventory` (" +
"`id` int(10) unsigned NOT NULL AUTO_INCREMENT," +
"`owner` int(11) unsigned NOT NULL," +
"`item` varchar(50) DEFAULT NULL," +
"`description` varchar(50) DEFAULT NULL," +
"PRIMARY KEY(`id`)," +
"KEY `FKownerBCKPCK` (`owner`)," +
"CONSTRAINT `FKownerBCKPCK` FOREIGN KEY (`owner`) REFERENCES `pj` (`id`) ON DELETE CASCADE ON UPDATE CASCADE" +
")ENGINE = InnoDB DEFAULT CHARSET = latin1;";
        string query5 =
"        CREATE TABLE IF NOT EXISTS `spellbook` (" +
"  `id` int(10) unsigned NOT NULL AUTO_INCREMENT," +
"   `owner` int(11) unsigned NOT NULL," +
"   `spell` varchar(50) DEFAULT NULL," +
"   `description` varchar(50) DEFAULT NULL," +
"   PRIMARY KEY(`id`)," +
"   KEY `FKownerSPLLBK` (`owner`)," +
"   CONSTRAINT `FKownerSPLLBK` FOREIGN KEY (`owner`) REFERENCES `pj` (`id`) ON DELETE CASCADE ON UPDATE CASCADE" +
" ) ENGINE = InnoDB DEFAULT CHARSET = latin1 ROW_FORMAT = COMPACT;";

        executequery(query1);
        executequery(query2);
        executequery(query3);
        executequery(query4);
        executequery(query5);
        Insertignore("satirus.order", "`id`,`order`", "1, 'lawful'");
        Insertignore("satirus.order", "`id`,`order`", "2, 'neutral'");
        Insertignore("satirus.order", "`id`,`order`", "3, 'chaotic'");
        Insertignore("satirus.karma", "`id`,`karma`", "1, 'good'");
        Insertignore("satirus.karma", "`id`,`karma`", "2, 'neutral'");
        Insertignore("satirus.karma", "`id`,`karma`", "3, 'bad'");

    }


    public void executequery(string query)
    {
        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            this.CloseConnection();

            //return list to be displayed
        }
    }
}