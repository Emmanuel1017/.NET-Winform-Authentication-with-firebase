using System;

namespace Login_Sample
{
    class Settings
    {


        public String __AuthSecret = "HIyNsQjhgU5nAiB9tWQ6W5DIHOr9NHqK6QgRzMvP";
        public String __BasePath = "https://realtime-test-46b84-default-rtdb.firebaseio.com/";

        public String __APPVERSION = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public String __SAAT = DateTime.Now.ToLongTimeString();
        public String __TARIH = DateTime.Now.ToShortDateString();


        public String Messege;
        public String Warning(int i)
        {
            if (i == 0) { Messege = "Password Has Been Modified"; }
            else if (i == 1) { Messege = "UserName Has Been Modified"; }
            else if (i == 2) { Messege = "Database Not Available"; }
            else if (i == 3) { Messege = "İnternet Error."; }
            else if (i == 4) { Messege = "Continue"; }
            else if (i == 5) { Messege = "Continue"; }
            else if (i == 6) { Messege = ""; }
            else if (i == 7) { Messege = ""; }
            else if (i == 8) { Messege = "Password Mismatch"; }
            else if (i == 9) { Messege = "User Name Cannot Be Empty"; }
            else if (i == 10) { Messege = "Email Cannot Be Empty"; }
            else if (i == 11) { Messege = " Cannot Be Empty"; }
            else if (i == 12) { Messege = "Password Cannot Be Empty"; }
            else if (i == 15) { Messege = "Unknown Error"; }
            else if (i == 16) { Messege = "Too many characters  fields."; }
            else if (i == 17) { Messege = "Status Set Online."; }


            else { Messege = "UNKOWN ERROR"; }
            return Messege;
        }
    }
}
 