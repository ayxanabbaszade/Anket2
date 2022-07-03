using Newtonsoft.Json;

namespace WinFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbtn_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{ftxt.Text.ToUpper()}.json"))
            {
                var user = new User();
                var jsonStr = File.ReadAllText($"{ftxt.Text}.json");
                user = JsonConvert.DeserializeObject<User>(jsonStr);

                ntxt.Text = user?.Name;
                stxt.Text = user?.SurName;
                etxt.Text = user?.Email;
                ptxt.Text = user?.Pnumber;
            
            
            
            
            
            
            
            
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = ntxt.Text,
                SurName = stxt.Text,
                Email = etxt.Text,
                Pnumber = ptxt.Text
            };
            var nuser  = JsonConvert.SerializeObject(user,Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText($"{ntxt.Text}.json", nuser);

        }
    }
}