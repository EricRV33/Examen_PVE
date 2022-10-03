using System.Drawing;

namespace _1_Examen
{
    public partial class Form1 : Form
    {
       public Conversion Conversion { get; set; }
        public bool MX { get; set; }
        public bool USA { get; set; }
        public bool CAN { get; set; }
        public bool EUR { get; set; }
        public bool JAP { get; set; }
    
        public Form1()
        {
            InitializeComponent();
            Conversion = new Conversion();
           
            MX = false;
            USA = false;
            CAN = false;
            EUR = false;
            JAP = false;
            mextext.Visible=false;
            lblMex.Visible=false;
           usatext.Visible=false;
            lblUsa.Visible=false;
            cadtext.Visible = false;
            lblCad.Visible=false;
            eurtext.Visible=false;
            lblEur.Visible=false;
            japtext.Visible = false;
            lblJap.Visible=false;
        }
     
        public void Form1_Load(object sender, EventArgs e)
        {

            




        }

        public void btncalcular_Click(object sender, EventArgs e)
        {   
            Monedas monedas = new Monedas(txtmonedas.Text);
         
            if (txtmonedas.Text == "" && txtMonto.Text == ""|| txtmonedas.Text == "" ||  txtMonto.Text == "")
            {
                MessageBox.Show("Error Pleve asigna un valor");

              return;
            }
            monedas.ShowDialog();
            Conversion.Monto =double.Parse(txtMonto.Text);
            MX = monedas.MX2;
            USA = monedas.USA2;
            CAN=monedas.CAN2;
            EUR=monedas.EUR2;
            JAP = monedas.JAP2;
            mextext.Visible = MX;
            lblMex.Visible = MX;
            usatext.Visible = USA;
            lblUsa.Visible = USA;
            cadtext.Visible = CAN;
            lblCad.Visible = CAN;
            eurtext.Visible = EUR;
            lblEur.Visible = EUR;
            japtext.Visible = JAP;
            lblJap.Visible = JAP;




            Conversion.Conv = Conversion.Monto;
           
             
                if (txtmonedas.SelectedIndex == 0)
                {


                    mextext.Text = (("$" + Conversion.Conv * 20.25).ToString());
                    cadtext.Text = (("$" + Conversion.Conv * 1.36).ToString());
                    eurtext.Text = (("€" + Conversion.Conv * 1.03).ToString());
                    japtext.Text =(("¥"+Conversion.Conv * 144.33).ToString());

                }
                if (txtmonedas.SelectedIndex == 1)
                {
                                                                                

                    usatext.Text = (("$" + Conversion.Conv * 0.05).ToString());
                    cadtext.Text = (("$" + Conversion.Conv * 0.07).ToString());
                    eurtext.Text = (("€" + Conversion.Conv * 0.05).ToString());
                    japtext.Text = (("¥" + Conversion.Conv * 7.13).ToString());
                }
                if (txtmonedas.SelectedIndex == 2)//CANADA
                {

                    usatext.Text = (("$"+Conversion.Conv * 0.73).ToString());
                    mextext.Text = (("$" + Conversion.Conv * 14.84).ToString());
                    eurtext.Text = (("€" + Conversion.Conv * 0.76).ToString());
                    japtext.Text = (("¥"+Conversion.Conv * 105.74).ToString());
                }
                if (txtmonedas.SelectedIndex == 3)//EURO
                {


                    usatext.Text = (("$" + Conversion.Conv * 0.97).ToString());
                    mextext.Text = (("$" + Conversion.Conv * 19.62).ToString());
                    cadtext.Text = (("$" + Conversion.Conv * 1.32).ToString());
                    japtext.Text = (("¥"+Conversion.Conv * 139.89).ToString());
                }
                if (txtmonedas.SelectedIndex == 4)//JAPAN
                {

                    usatext.Text = (("$" + Conversion.Conv * 0.01).ToString());
                    mextext.Text = (("$" + Conversion.Conv * 0.14).ToString());
                    cadtext.Text = (("$" + Conversion.Conv * 0.01).ToString());
                    eurtext.Text =(("€" + Conversion.Conv * 0.01).ToString());


                }



            





          
            
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dvgconversion_Enter(object sender, EventArgs e)
        {

        }
    }
}