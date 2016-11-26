using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public const int Modulo = 1000000007;
        public Form1()
        {
            InitializeComponent();
        }
        int Kombinasi(int n, int k)
        {
            int _terbesar, _terkecil, _faktorial1, _faktorial2;
            int[] _arr1, _arr2;

            _faktorial1 = _faktorial2 = 1;
            n = n + k - 1;
            _terbesar = n - k;
            _terkecil = k;
            _arr1 = new int[n - _terbesar];
            _arr2 = new int[k];
            //inisiasi array faktorial
            for (int _i = n, _j = 0; _i > _terbesar; _i--, _j++) _arr1[_j] = _i;
            for (int _i = k, _j = 0; _i > 0; _i--, _j++) _arr2[_j] = _i;
            //penyederhanaan array faktorial
            for (int _i = 0; _i < _arr1.Length; _i++) 
            {
                for (int _j = 0; _j < _arr2.Length; _j++) 
                {
                    if (_arr2[_j] != 1 && (_arr1[_i] % _arr2[_j] == 0))
                    {
                        _arr1[_i] = _arr1[_i] / _arr2[_j];
                        _arr2[_j] = 1;
                        break;
                    }
                    else 
                    {
                        continue;
                    }
                }
            }
            //hitung faktorial
            for (int _i = 0; _i < _arr1.Length; _i++) _faktorial1 *= _arr1[_i];
            for (int _i = 0; _i < _arr2.Length; _i++) _faktorial2 *= _arr2[_i];
            
            return _faktorial1/_faktorial2;            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int nA = int.Parse(Txt1.Text);
            int nB = int.Parse(Txt2.Text);
            if (nA < nB) 
            {
                int _temp = nA;
                nA = nB;
                nB = _temp;
            }
            long hasil = 0;
            if (!(nA == 25 && nB < 24) || (nA >= 26 && nB == nA - 2)) { hasil = 0; }
            else 
            {
                if (nA >= 26)
                {
                    hasil = Kombinasi(24, 24);
                    nA -= 24; nB -= 24;
                    hasil ^= Kombinasi(nA, nB);
                }
                else { hasil = Kombinasi(nA, nB); }
            }
            if ( hasil > Modulo) { hasil %= Modulo;}
            TxtHasil.Text = hasil + "";
        }
    }
}