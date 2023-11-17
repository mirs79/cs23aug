using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace FormsPostgre
{
    public partial class Form1 : Form
    {
        List<Actor> actors = new List<Actor>();
        String connString = "Host=localhost;Username=postgres;Password=123;Database=dvdrental";
        public Form1()
        {
            InitializeComponent();  
            
         using ( var conn= new NpgsqlConnection(connString))
            {   conn.Open();
                using (var cmd = new NpgsqlCommand("select actor_id, first_name, last_name, last_update from actor", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Actor current = new Actor();
                        current.actor_id = reader.GetInt32(0);
                        current.first_name = reader.GetString(1);
                        current.last_name = reader.GetString(2);
                        current.last_update = reader.GetDateTime(3);
                        actors.Add(current);
                    }  // listFilms

                }
                lstActors.DataSource = actors;

            }
          //  

        }

        private void lstActors_SelectedIndexChanged(object sender, EventArgs e)
        {
              label1.Text = lstActors.SelectedItem.ToString();
            //  label1.Text = lstActors.Items[lstActors.SelectedIndex];

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select film_id, title, release_year from film where film_id in ( select film_id from film_actor where actor_id = 1 )", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    { Film current = new Film();
                        current.film_id = reader.GetInt32(0);
                        current.title = reader.GetString(1);
                        current.release_year = reader.GetInt32(3);
                    }
                    listFilms.DataSource = Film;

                }
        }
}
