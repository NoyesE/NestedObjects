using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = "J. Doe";
            s.DateOfBirth = new DateTime(1980, 1, 1);

            s.AssignedAdviser.FullName = "Annemarie";
            s.AssignedAdviser.Email = "email@email.com";

            MessageBox.Show($"Hey {s.Name}\nYour Advisor is {s.AssignedAdviser.FullName}");
        }
    }
}
