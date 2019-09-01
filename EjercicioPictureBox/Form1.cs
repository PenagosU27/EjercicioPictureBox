﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtimagen.Focus();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            string numeroimagen = txtimagen.Text;

            switch (numeroimagen) {

                case "1":
                    ptbimagen1.Visible = false;
                    break;

                case "2":
                    ptbimagen2.Visible = false;
                    break;

                case "3":
                    ptbimagen3.Visible = false;
                    break;

                case "4":
                    ptbimagen4.Visible = false;
                    break;

                case "5":
                    ptbimagen5.Visible = false;
                    break;

                default:
                    MessageBox.Show("Valor incorrecto");
                    txtimagen.Focus();
                    break;
            }


        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string numeroimagen = txtimagen.Text;

            switch (numeroimagen)
            {

                case "1":
                    ptbimagen1.Visible = true;
                    break;

                case "2":
                    ptbimagen2.Visible = true;
                    break;

                case "3":
                    ptbimagen3.Visible = true;
                    break;

                case "4":
                    ptbimagen4.Visible = true;
                    break;

                case "5":
                    ptbimagen5.Visible = true;
                    break;

                default:
                    MessageBox.Show("Valor incorrecto");
                    txtimagen.Focus();
                    break;


            }
            restablecerCampo();
        }
        private void restablecerCampo() {
            txtimagen.Text = "";
            txtimagen.Focus();

        }

        private void ptbimagen1_DoubleClick(object sender, EventArgs e)
        {
            ptbimagen1.Visible = false;
            abrirUrl("https://www.clubcolombia.com.co/agegate?destination=/");
        }

        private void abrirUrl(string pagina) 
        { 
        System.Diagnostics.Process.Start(pagina);
        }

        private void ptbimagen2_DoubleClick(object sender, EventArgs e)
        {
            ptbimagen2.Visible = false;
        }

        private void ptbimagen3_DoubleClick(object sender, EventArgs e)
        {
            ptbimagen3.Visible = false;
        }

        private void ptbimagen4_DoubleClick(object sender, EventArgs e)
        {
            ptbimagen4.Visible = false;
        }

        private void ptbimagen5_DoubleClick(object sender, EventArgs e)
        {
            ptbimagen5.Visible = false;
        }

        private void btnmostrartodos_Click(object sender, EventArgs e)
        {
            ptbimagen1.Visible = true;
            ptbimagen2.Visible = true;
            ptbimagen3.Visible = true;
            ptbimagen4.Visible = true;
            ptbimagen5.Visible = true;
        }
    }
}