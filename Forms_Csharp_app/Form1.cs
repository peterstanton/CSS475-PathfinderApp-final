using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Controls;

namespace Forms_Csharp_app {
    public partial class Form1 : Form {

        const String CONN_STR = "server=pathfinder.chpcq7i3yggs.us-west-2.rds.amazonaws.com;user id=visualstudio;password=12345;database=PathfinderApp";
        MySqlConnection CONN = new MySqlConnection(CONN_STR);

        public Form1() {
            InitializeComponent();
            GLOBAL_USER_ID.Text = "12345";
        }

        private String processReader(ref MySqlDataReader fromDatabase) {
            String storage = "";
            for (int i = 0; i < fromDatabase.FieldCount; i++) {
                storage += fromDatabase.GetName(i) + "    ";
            }
            storage += "\n";
            while (fromDatabase.Read()) {
                for (int i = 0; i < fromDatabase.FieldCount; i++) {
                    storage += fromDatabase.GetString(i) + "    ";
                }
                storage += "\n";
            }
            fromDatabase.Close();
            return storage;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                /*CONN.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * from PINPOINT", CONN);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows) {
                    listView1.Items.Add(dr["Name"].ToString());
                    //listView2.Items.Add(dr["Description"].ToString());
                }
                CONN.Close();*/

                updatePinpointDescription();
            } catch (Exception es) {
                MessageBox.Show(es.Message);
            }
        }


        void updatePinpointDescription() {
            // CHECK VALID
            if (!(UPD_Description.Text != "" && int.Parse(PINPOINT_ID.Text) != 0))
                return;

            // CHECK IS OWNER
            CONN.Open();
            String permQ = "SELECT UID from PINPOINT WHERE ID=" + int.Parse(PINPOINT_ID.Text);
            MySqlCommand permC = new MySqlCommand(permQ, CONN);
            MySqlDataReader dr = permC.ExecuteReader();
            int UID = 12345;
            while (dr.Read())
                UID = int.Parse(dr.GetString(0));
            CONN.Close();

            // CHECK IS ADMIN
            CONN.Open();
            bool isAdmin = GLOBAL_USER_INFO.Text.Contains("True");
            CONN.Close();

            if(isAdmin || UID == int.Parse(GLOBAL_USER_ID.Text)) {
                // UPDATE QUERY
                CONN.Open();
                String query = "UPDATE PINPOINT SET description = '" + UPD_Description.Text + "' WHERE ID = " + int.Parse(PINPOINT_ID.Text);
                MySqlCommand cmd = new MySqlCommand(query, CONN);
                cmd.ExecuteNonQuery();
                CONN.Close();


                // CONFIRMATION
                displayRelation("PINPOINT");
            } else {
                MessageBox.Show("ERROR: Must be Pinpoint owner OR admin.");
            }
        }

        void displayRelation(String r) {
            r = r.ToUpper();
            ConnectionState connState = CONN.State;
            bool shouldConnect = (ConnectionState.Open != CONN.State);
            if(shouldConnect)
                CONN.Open();
            String queryConf = "SELECT * from " + r;
            MySqlCommand cmdConf = new MySqlCommand(queryConf, CONN);
            MySqlDataReader dr = cmdConf.ExecuteReader();
            String str = "";
            for (int i = 0; i < dr.FieldCount; i++) {
                str += dr.GetName(i) + "\t";
            }
            str += "\n";
            while (dr.Read()) {
                for (int i = 0; i < dr.FieldCount; i++) {
                    str += dr.GetString(i) + "\t";
                }
                str += "\n";
            }
            dr.Close();
            MessageBox.Show(str, r);
            if(shouldConnect)
                CONN.Close();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void GLOBAL_USER_ID_TextChanged(object sender, EventArgs e) {

            int userID;
            if(int.TryParse(GLOBAL_USER_ID.Text, out userID)) {
                CONN.Open();

                String queryConf = "SELECT * from USER";
                MySqlCommand cmdConf = new MySqlCommand(queryConf, CONN);
                MySqlDataReader dr = cmdConf.ExecuteReader();
                while (dr.Read()) {
                    bool grabData = false;
                    for (int i = 0; i < dr.FieldCount; i++) {
                        if (dr.GetName(i).ToLower().Equals("id")) {
                            if (int.Parse(dr.GetString(i)) == int.Parse(GLOBAL_USER_ID.Text)) {
                                grabData = true;
                            }
                        }
                    }
                    if (grabData) {
                        String newUserData = "";
                        for (int i = 0; i < dr.FieldCount; i++) {
                            newUserData += dr.GetName(i) + ": " + dr.GetString(i) + "    ";
                        }
                        GLOBAL_USER_INFO.Text = newUserData;
                    }
                }
                dr.Close();

                CONN.Close();
            } else {
                GLOBAL_USER_INFO.Text = "USER_ID is invalid";
            }
        }

        private void UPD_ListPinpoints_Click(object sender, EventArgs e) {
            displayRelation("PINPOINT");
        }

        private void GLOBAL_LIST_USERS_Click(object sender, EventArgs e) {
            displayRelation("USER");
        }



        /////////// MAP ////////////
        /*
        private void mapButton_click(object sender, EventArgs e) {
            try {
                String query = "select * from MAP";
                MySqlCommand cmd = new MySqlCommand(query, CONN);
                CONN.Open();
                if (CONN.State == ConnectionState.Open) {
                    MessageBox.Show("Connected");
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    String storage = "";
                    for (int i = 0; i < rdr.FieldCount; i++) {
                        storage += rdr.GetName(i) + "    ";
                    }
                    storage += "\n";
                    while (rdr.Read()) {
                        for (int i = 0; i < rdr.FieldCount; i++) {
                            storage += rdr.GetString(i) + "    ";
                        }
                        storage += "\n";
                    }
                    rdr.Close();
                    MessageBox.Show(storage);
                } else
                    MessageBox.Show("Disconnected");
                CONN.Close();
            } catch (Exception es) {
                MessageBox.Show(es.Message);
            }
        }

        private void usersButton_Click(object sender, EventArgs e) {
            try {
                String query = "select * from USER";
                MySqlCommand cmd = new MySqlCommand(query, CONN);
                CONN.Open();
                if (CONN.State == ConnectionState.Open) {
                    MessageBox.Show("Connected");
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    String storage = processReader(ref rdr);
                    rdr.Close();
                    MessageBox.Show(storage);
                } else
                    MessageBox.Show("Disconnected");
                CONN.Close();
            } catch (Exception es) {
                MessageBox.Show(es.Message);
            }
        }

        private void submitUser_Click(object sender, EventArgs e) {
            String query = "insert into USER values (" + int.Parse(UA_UserIDBox.Text) + ", " +
                (adminCheckBox.Checked) + ", \'" + fnameBox.Text + "\', \'" + lnameBox.Text + "\');";
            String query2 = "insert into RANK values (" + int.Parse(UA_UserIDBox.Text) + ", \'Newbie\', 0);";
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlCommand cmd2 = new MySqlCommand(query2, CONN);
            CONN.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            CONN.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            String query = "SELECT * FROM USER_RATING WHERE USER_RATING.UID = " + int.Parse(UA_UserIDBox.Text);
            if (!string.IsNullOrWhiteSpace(UA_UserIDBox.Text)) {
                MySqlCommand cmd = new MySqlCommand(query, CONN);
                CONN.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                String storage = processReader(ref rdr);
                CONN.Close();
                MessageBox.Show(storage);
            } else {
                MessageBox.Show("You need to enter a user ID...");
            }
        }

        private void listRefresh_Click(object sender, EventArgs e) {
            mapviewListBox.Items.Clear();
            string query = "SELECT * FROM MAP;";
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader reader;
            mapviewListBox.Items.Add("<Select Map>");
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                ListBoxItem newItem = new ListBoxItem();
                newItem = new ListBoxItem();
                newItem.Content = reader["ID"].ToString();
                String[] temp = newItem.ToString().Split(':');
                mapviewListBox.Items.Add(int.Parse(temp[1])); //this still prints crap.
            }
            reader.Close();
            CONN.Close();
        }

        private void grabLandscapesButton_Click(object sender, EventArgs e) {
            if (mapviewListBox.Items.Count < 1) {
                MessageBox.Show("Please refresh the list of maps first");
                return;
            }
            String text = mapviewListBox.GetItemText(mapviewListBox.SelectedItem);
            if (text == "<Select Map>") {
                MessageBox.Show("You need to select a valid option.");
                return;
            }
            String query = "SELECT * FROM LANDSCAPE WHERE LANDSCAPE.MID = " + int.Parse(text);
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            rdr.Close();
            MessageBox.Show(storage);
        }

        private void getRankButton_click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(UA_UserIDBox.Text.ToString())) {
                MessageBox.Show("You must enter a valid user ID");
                return;
            }
            String query = "SELECT USER.ID, USER.fname, USER.lname, RANK.level, RANK.participation_score FROM USER RIGHT JOIN RANK ON USER.ID = RANK.UID WHERE USER.ID = " +
                int.Parse(UA_UserIDBox.Text) + ";";
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            CONN.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            MessageBox.Show(storage);

        }

        private void GrabTopFiveButton_Click(object sender, EventArgs e) {
            String query = "SELECT USER.fname, USER.lname, RANK.participation_score FROM USER, RANK WHERE USER.ID = RANK.UID AND USER.admin = false ORDER BY RANK.participation_score;";
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            rdr.Close();
            CONN.Close();
            MessageBox.Show(storage);
        }
        */

        private void UA_FetchUserRatings_Click(object sender, EventArgs e) {
            String query = "SELECT * FROM USER_RATING WHERE USER_RATING.UID = " + int.Parse(UA_UserIDBox.Text);
            if (!string.IsNullOrWhiteSpace(UA_UserIDBox.Text)) {
                MySqlCommand cmd = new MySqlCommand(query, CONN);
                CONN.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                String storage = processReader(ref rdr);
                CONN.Close();
                MessageBox.Show(storage);
            } else {
                MessageBox.Show("You need to enter a user ID...");
            }
        }

        private void UA_CreateUser_Click(object sender, EventArgs e) {
            String query = "insert into USER values (" + int.Parse(UA_UserIDBox.Text) + ", " +
                (UA_isAdminCheck.Checked) + ", \'" + UA_FnameBox.Text + "\', \'" + UA_LnameBox.Text + "\');";
            String query2 = "insert into RANK values (" + int.Parse(UA_UserIDBox.Text) + ", \'Newbie\', 0);";
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlCommand cmd2 = new MySqlCommand(query2, CONN);
            CONN.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            CONN.Close();
        }

        private void UA_FetchRank_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(UA_UserIDBox.Text.ToString())) {
                MessageBox.Show("You must enter a valid user ID");
                return;
            }
            String query = "SELECT USER.ID, USER.fname, USER.lname, RANK.level, RANK.participation_score FROM USER RIGHT JOIN RANK ON USER.ID = RANK.UID WHERE USER.ID = " +
                int.Parse(UA_UserIDBox.Text) + ";";
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            CONN.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            MessageBox.Show(storage);
        }

        private void button3_Click(object sender, EventArgs e) {
            MI_listBox.Items.Clear();
            string query = "SELECT * FROM MAP;";
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader reader;
            MI_listBox.Items.Add("<Select Map>");
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                ListBoxItem newItem = new ListBoxItem();
                newItem = new ListBoxItem();
                newItem.Content = reader["ID"].ToString();
                String[] temp = newItem.ToString().Split(':');
                MI_listBox.Items.Add(int.Parse(temp[1])); //this still prints crap.
            }
            reader.Close();
            CONN.Close();
        }

        private void MI_listBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void MI_ListLands_Click(object sender, EventArgs e) {
            if (MI_listBox.Items.Count < 1) {
                MessageBox.Show("Please refresh the list of maps first");
                return;
            }
            String text = MI_listBox.GetItemText(MI_listBox.SelectedItem);
            if (text == "<Select Map>") {
                MessageBox.Show("You need to select a valid option.");
                return;
            }
            String query = "SELECT * FROM LANDSCAPE WHERE LANDSCAPE.MID = " + int.Parse(text);
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            rdr.Close();
            MessageBox.Show(storage);
        }

        private void button2_Click(object sender, EventArgs e) {
            if (MI_listBox.Items.Count < 1) {
                MessageBox.Show("Please refresh the list of maps first");
                return;
            }
            String text = MI_listBox.GetItemText(MI_listBox.SelectedItem);
            if (text == "<Select Map>") {
                MessageBox.Show("You need to select a valid option.");
                return;
            }
            String query = "SELECT * FROM LANDSCAPE WHERE LANDSCAPE.MID = " + int.Parse(text);
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            rdr.Close();
            MessageBox.Show(storage);
        }

        private void G_Top5_Click(object sender, EventArgs e) {
            String query = "SELECT USER.fname, USER.lname, RANK.participation_score FROM USER, RANK WHERE USER.ID = RANK.UID AND USER.admin = false ORDER BY RANK.participation_score DESC limit 5;";
            CONN.Open();
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            MessageBox.Show(storage);
        }

        private void button5_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(UA_UserIDBox.Text.ToString())) {
                MessageBox.Show("Please enter a valid user ID");
                return;
            }
            String query = "UPDATE RANK SET RANK.participation_score = RANK.participation_score + 5 WHERE RANK.uid = " + int.Parse(UA_UserIDBox.Text) + ";";
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            CONN.Open();
            cmd.ExecuteNonQuery();
            CONN.Close();
        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void MA_FindPolys_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(MA_LandscapeID.Text.ToString())) {
                MessageBox.Show("Enter a valid landscape ID.");
                return;
            }
            String query = "SELECT LANDSCAPE.name, Count(LANDSCAPE_POLYGON_POINTS.point_ID) AS 'Count of polygon points' FROM LANDSCAPE INNER JOIN LANDSCAPE_POLYGON_POINTS ON LANDSCAPE.ID = LANDSCAPE_POLYGON_POINTS.landscape_ID WHERE LANDSCAPE_POLYGON_POINTS.landscape_ID = " + int.Parse(MA_LandscapeID.Text) + " ORDER BY LANDSCAPE.ID;";
            //MessageBox.Show(query);
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            CONN.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            MessageBox.Show(storage);
        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e) {
            displayRelation("USER_RATING");
        }

        private void button1_Click_1(object sender, EventArgs e) {
            String query = "SELECT PINPOINT.name, COUNT(USER_RATING.PID) FROM PINPOINT, USER_RATING WHERE PINPOINT.ID = USER_RATING.PID AND USER_RATING.PID NOT IN(SELECT USER_RATING.PID FROM USER_RATING WHERE USER_RATING.rating = false) GROUP BY PINPOINT.ID ORDER BY -COUNT(USER_RATING.PID);";
            MySqlCommand cmd = new MySqlCommand(query, CONN);
            CONN.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            String storage = processReader(ref rdr);
            CONN.Close();
            MessageBox.Show(storage);
        }

        private void button6_Click(object sender, EventArgs e) {

            bool isAdmin = GLOBAL_USER_INFO.Text.Contains("True");
            if(isAdmin) {
                if (String.IsNullOrWhiteSpace(UA_UserIDBox.Text.ToString())) {
                    MessageBox.Show("Enter a valid user ID to delete their ratings");
                    return;
                }
                String query = "DELETE FROM USER_RATING WHERE USER_RATING.UID = " + int.Parse(UA_UserIDBox.Text) + ";";
                MySqlCommand cmd = new MySqlCommand(query, CONN);
                CONN.Open();
                cmd.ExecuteNonQuery();
                CONN.Close();
            } else {
                MessageBox.Show("Must be admin for this action!");
            }


            
        }



        ///////// END MAP //////////

    }
}
