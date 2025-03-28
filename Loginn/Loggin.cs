﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Loginn
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
      


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO") {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            
            
            }
            

                
            

            
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text=="")
            {
                txtusuario.Text="USUARIO";
                txtusuario.ForeColor = Color.DimGray;


            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {

            if (txtpass.Text=="CONTRASEÑA")
            {
               
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;


            }


        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012, 0);


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void butnlogin_Click(object sender, EventArgs e)
        {


           





                Formprincipal mainmenu = new Formprincipal();
                MessageBox.Show("Bienvenido " + txtusuario.Text + " ",
                 "Login Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainmenu.Show();
                this.Hide();

            

        


        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("Opcion No Disponible En Desarrollo", "INFORMACION",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Loggin_Load(object sender, EventArgs e)
        {

        }
    }
}
