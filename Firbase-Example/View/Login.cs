using Firbase_Example.Controller;
using Firbase_Example.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firbase_Example
{
    public partial class Login : Form
    {
        private FirebaseController _Firebase;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Firebase = new FirebaseController();
            if (_Firebase.Client())
            {
                MessageBox.Show("Conectado", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Conectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Create_ClickAsync(object sender, EventArgs e)
        {
            await _Firebase.CreateUser(new User(txt_Email.Text, txt_Password.Text));
        }
    }
}
