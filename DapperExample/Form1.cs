using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace DapperExample
{
    public partial class Form1 : Form
    {
        private readonly UserRepository _repository;

        public Form1()
        {
            InitializeComponent();
            _repository = new UserRepository();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _repository.GetAllUsers();
            dataGridView1.DataSource = users.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            _repository.AddUser(user);
            LoadUsers();
            

            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var users = _repository.GetAllUsers();
            dataGridView1.DataSource = users.ToList();
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }
    }
}
