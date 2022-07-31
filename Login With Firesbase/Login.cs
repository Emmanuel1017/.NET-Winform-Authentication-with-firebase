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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Login_Sample
{
    public partial class Login : Form
    {
        private static Settings pub = new Settings();

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = pub.__AuthSecret,
            BasePath = pub.__BasePath
        };

        IFirebaseClient client;

        public Login()
        {
            InitializeComponent();
        }

       
       
        Random r = new Random();
        int x, y;
        bool Higlighted = false;
        Point ilkkonum;
       


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

    

        private void Login_Load(object sender, EventArgs e)

        {
            AutoLoginCheckbox.Checked = Properties.Settings.Default.AutoLoginCheck;
            if (AutoLoginCheckbox.Checked == true)
            {
                username.Text = Properties.Settings.Default.UserName;
                password.Text = Properties.Settings.Default.Passsword;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Passsword = null;
                Properties.Settings.Default.AutoLoginCheck = false;
                Properties.Settings.Default.Save();
            }
            //if (Properties.Settings.Default.Online == 1)
            // { MessageBox.Show(pub.Warning(17),"Info!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); Application.Exit(); }

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch(Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }


     





        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.Id = 0;
            Properties.Settings.Default.Online = 0;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            //AutoLoginCheckbox.Checked = Properties.Settings.Default.AutoLoginCheck;
            if (AutoLoginCheckbox.Checked == true)
            {

                firebaseLogin(username.Text.ToString(), password.Text.ToString());

            }
            else
            {
                if (username.Text.Length < 255 || password.Text.Length < 255)
                {
                    if (username.Text.Trim() != "")
                    {
                        if (password.Text.Trim() != "")
                        {
                            // UserLogin(username.Text.ToString(), password.Text.ToString());
                            firebaseLogin(username.Text.ToString(), password.Text.ToString());
                        }
                        else
                        {
                            MessageBox.Show(pub.Warning(12), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(pub.Warning(9), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(pub.Warning(16), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        private void firebaseLogin(String UserName, String Password)
        {
            try
            {

                MyUser CurUser = new MyUser() // USER GIVEN INFO
                {
                    Username = UserName,
                    Password = Password
                };


                FirebaseResponse res = client.Get(@"Users_Test/" + UserName);
                MyUser ResUser = res.ResultAs<MyUser>();// database result


                if (MyUser.IsEqual(ResUser, CurUser))
                {
                    if (AutoLoginCheckbox.Checked == true)
                    {
                        Properties.Settings.Default.UserName = UserName.ToString();
                        Properties.Settings.Default.Passsword = Password.ToString();
                        Properties.Settings.Default.AutoLoginCheck = true;
                        Properties.Settings.Default.Loged_In = true;
                        Properties.Settings.Default.Save();


                    }
                    else
                    {
                        Properties.Settings.Default.UserName = null;
                        Properties.Settings.Default.Passsword = null;
                        Properties.Settings.Default.AutoLoginCheck = false;
                        Properties.Settings.Default.Loged_In = true;
                        Properties.Settings.Default.Save();
                    }
                    //
                    //Loading Awsome_Loader = new Loading();
                    // Awsome_Loader.Show();

                    /////////////////// All opened myForm instances//////////////////////
                    List<Form> forms = new List<Form>();
                    forms.Clear();
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "Dashboard")
                        {
                            forms.Add(f);
                            f.Show();
                            this.Hide();
                        }
                    }

                    if (forms.Count == 0)
                    {
                        Loading Awsome_Loader = new Loading();
                        Awsome_Loader.Show();
                        this.Hide();
                    }

                    ////////////////////////////////////////////////////////////////////////
                    ///

                }

                else
                {
                    MyUser.ShowError();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Higlighted= true; 
            this.Cursor = Cursors.SizeAll; 
            ilkkonum = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Higlighted) 
            {
                this.Left = e.X + this.Left - (ilkkonum.X);
                     this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Higlighted = false;
            this.Cursor = Cursors.Default; 
        }

         
    }
}