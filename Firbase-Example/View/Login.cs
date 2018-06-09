using Firbase_Example.Controller;
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

        private void btn_Create_Click(object sender, EventArgs e)
        {

        }
    }
}
