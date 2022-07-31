using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace Login_Sample
{
    public partial class Register : Form
    {

        private static Settings pub = new Settings();

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "HIyNsQjhgU5nAiB9tWQ6W5DIHOr9NHqK6QgRzMvP",
            BasePath = "https://realtime-test-46b84-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Register()
        {
            InitializeComponent();
        }



        Random r = new Random();
        int x, y;
        bool Higlighted = false;
        Point ilkkonum;

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
       

        }
    
        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() != "")
            {
                if (email.Text.Trim() != "")
                {
                    if (password.Text.Trim() != "")
                    {
                        if (repassword.Text.Trim() != "")
                        {
                          
                                if (password.Text == repassword.Text)
                                {
                                  
                                        // UserRegister(username.Text, email.Text, password.Text, repassword.Text);                                       
                                        fireRegister(username.Text, email.Text, password.Text, repassword.Text);
                                 
                                }
                                else
                                {
                                    MessageBox.Show(pub.Warning(8), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               
                                }

                        }
                        else
                        {
                            MessageBox.Show(pub.Warning(12), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     
                        }
                    }
                    else
                    {
                        MessageBox.Show(pub.Warning(12), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      
                    }

                }
                else
                {

                    MessageBox.Show(pub.Warning(10), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   
                }
            }
            else
            {
                MessageBox.Show(pub.Warning(9), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.Id = 0;
            Properties.Settings.Default.Online = 0;
            Properties.Settings.Default.Save();
            Application.Exit();
        }


        private void fireRegister(String UserName, String Email, String Password, String REepassword)
        {

            MyUser user = new MyUser()
            {
                Username = UserName,
                Password = Password,
                Email = Email
            };
            Ping ping = new Ping();
            PingReply pingStatus = ping.Send(IPAddress.Parse("8.8.8.8"));
            if (pingStatus.Status == IPStatus.Success)
            {
                SetResponse set = client.Set(@"Users_Test/" + UserName, user);

                Properties.Settings.Default.Loged_In = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("Successfully registered!");

                this.Close();
                Loading loading = new Loading();
                loading.Show();

            }
            else
            {
                MessageBox.Show("Check Internet Connectivity", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



 

        private void timer1_Tick(object sender, EventArgs e)
        {
            int c = 0;
            Point l = this.Location;

            while (c < 50)
            {
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);

                this.Location = new Point(l.X + x, l.Y + y);
                Thread.Sleep(20); 
                c++;
            }

            this.Location = l;
            timer1.Stop();
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            Higlighted = true; 
            this.Cursor = Cursors.SizeAll; 
            ilkkonum = e.Location; 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Higlighted) 
            {
                this.Left = e.X + this.Left - (ilkkonum.X);
                 this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Higlighted = false; 
            this.Cursor = Cursors.Default;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            frm1.Show();
            this.Close();
            
        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void repassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}