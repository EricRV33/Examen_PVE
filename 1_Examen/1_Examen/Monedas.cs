using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Examen
{
    public partial class Monedas : Form
    {   Conversion Conversion { get; set; }
        public bool MX2 { get; set; } 
        public bool USA2 { get; set; } 
        public bool CAN2 { get; set; } 
        public bool EUR2 { get; set; } 
        public bool JAP2 { get; set; }

        string checador { get; set; }

        public Monedas(string seleccionador)
        {
            InitializeComponent();
            Conversion = new Conversion();
            lblayuda.Text = seleccionador;
            lblayuda.Visible=false;
            MX2 = false;
            USA2 = false;
            CAN2 = false;
            EUR2 = false;
            JAP2 = false;
            checador= seleccionador;


            boxEua.Visible = false;
            box_mxn.Visible = false;
            box_cad.Visible = false;
            boxeur.Visible = false;
            boxjpy.Visible = false;



        }
       
        public void button2_Click(object sender, EventArgs e)
        {

            if (box_mxn.Checked == true)
            {
                MX2= true;
            }
            else
            {
                MX2= false;
            }
            if (boxEua.Checked == true)
            {
                USA2= true;

            }
            else
            {
                USA2= false;
            }
          
            if (box_cad.Checked == true)
            {
                CAN2 = true;
            }
            else
            {
                CAN2 = false;
            }
            if (boxeur.Checked == true)
            {
                EUR2 = true;
            }
            else
            {
                EUR2 = false;
            }
            if (boxjpy.Checked == true)
            {
                JAP2 = true;
            }
            else
            {
                JAP2 = false;
            }
          

            DialogResult =DialogResult.OK;
            Close();




        }

        private void Monedas_Load(object sender, EventArgs e)
        {


            if (checador== "USD - Dólar estadounidense")
            {

                box_mxn.Visible = true;
                box_cad.Visible = true;
                boxeur.Visible = true;
                boxjpy.Visible = true;
            }
            if (checador == "MXN-Peso Mexicano")
            {

                boxEua.Visible = true;
                box_cad.Visible = true;
                boxeur.Visible = true;
                boxjpy.Visible = true;

            }
            if (checador == "CAD - Dólar canadiense")
            {

                boxEua.Visible = true;
                box_mxn.Visible = true;
                boxeur.Visible = true;
                boxjpy.Visible = true;
            }
            if (checador == "Eur-Euros")
            {

                boxEua.Visible = true;
                box_cad.Visible = true;
                box_mxn.Visible = true;
                boxjpy.Visible = true;
            }
            if (checador == "JYP-Yen Japones")
            {

                boxEua.Visible = true;
                box_cad.Visible = true;
                boxeur.Visible = true;
                box_mxn.Visible = true;
            }

            /*   Form1 form1 = new Form1();


               MX2 = form1.MX;


               if (MX2 == true)
               {
                   box_mxn.Visible = false;

               }
               else
               {
                   box_mxn.Visible = true;
               }/*
               /*  if ()
                 {  
                     boxEua.Visible=false;

                 }
                 else
                 {
                     boxEua.Visible = true;
                 }*/
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
