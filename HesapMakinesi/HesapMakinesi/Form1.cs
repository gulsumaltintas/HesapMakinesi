using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekranTemizleneceMi;
        private int _ilkSayi;
        int sonuc;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleneceMi)
            {
                ekranLabel.Text = "";
                _ekranTemizleneceMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizleneceMi = true;
           
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);

             


        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
             
            
            ekranLabel.Text = Convert.ToString(sonuc);
            
            sonuc = Convert.ToInt32(ekranLabel.Text) + sonuc;

        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizleneceMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text) - _ilkSayi;
        }

        private void carpımButton_Click(object sender, EventArgs e)
        {
            

            _islem = '*';
            _ekranTemizleneceMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text) ;
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizleneceMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text) ;

        }

        private void temizlemeButton_Click(object sender, EventArgs e)
        {

            ekranLabel.Text = "0";
            
        }
    }
}
