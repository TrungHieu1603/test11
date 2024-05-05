using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuatToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mahoa_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn_giaima_Click(object sender, EventArgs e)
        {
           
        }

        private string CaesarEncrypt(string plaintext, int shift)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char encryptedChar = (char)((((c - baseChar) + shift) % 26) + baseChar);
                    encryptedText.Append(encryptedChar);
                    txt_bangma.ForeColor = System.Drawing.Color.Green;
                    
                }
                else
                {
                    encryptedText.Append(c);
                }
            }

            return encryptedText.ToString();
        }

        private string CaesarDecrypt(string ciphertext, int shift)
        {
            txt_bangro.ForeColor = System.Drawing.Color.Red;

            return CaesarEncrypt(ciphertext, 26 - shift);
            
        }

        private string AffineEncrypt(string plaintext, int m, int b)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char encryptedChar = (char)((((m * (c - baseChar) + b) % 26) + 26) % 26 + baseChar);
                    encryptedText.Append(encryptedChar);
                }
                else
                {
                    encryptedText.Append(c);
                }
            }

            return encryptedText.ToString();
        }

        private string AffineDecrypt(string ciphertext, int m, int b)
        {
            int mInverse = Modinverse(m, 26); 
            StringBuilder decryptedText = new StringBuilder();

            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char decryptedChar = (char)((((mInverse * (c - baseChar - b) + 26) % 26) + 26) % 26 + baseChar);
                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    decryptedText.Append(c);
                }
            }

            return decryptedText.ToString();
        }



        private string VigenereEncrypt(string plaintext, string key)
        {
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i++)
            {
                char c = plaintext[i];
                char keyChar = key[i % key.Length];

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    int shift = char.ToUpper(keyChar) - 'A';
                    char encryptedChar = (char)((((c - baseChar) + shift) % 26) + baseChar);
                    encryptedText.Append(encryptedChar);
                }
                else
                {
                    encryptedText.Append(c);
                }
            }

            return encryptedText.ToString();
        }
       
        private string VigenereDecrypt(string ciphertext, string key)
        {
            StringBuilder decryptedText = new StringBuilder();

            for (int i = 0; i < ciphertext.Length; i++)
            {
                char c = ciphertext[i];
                char keyChar = key[i % key.Length];

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    int shift = char.ToUpper(keyChar) - 'A';
                    char decryptedChar = (char)((((c - baseChar) - shift + 26) % 26) + baseChar);
                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    decryptedText.Append(c);
                }
            }

            return decryptedText.ToString();
        }
      

        private int Modinverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                {
                    return x;
                }
            }
            throw new Exception("Modular multiplicative inverse does not exist.");
        }
     
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            
        }

        private void rdb_Ceasar_CheckedChanged(object sender, EventArgs e)
        {
            txt_khoak2.Visible = false;
            txt_nhapm.Visible = false;
            txtlbK.Text = "Nhập Khóa K";
            rdb_Ceasar.ForeColor = System.Drawing.Color.DarkRed;
            rdb_Affine.ForeColor = System.Drawing.Color.Black;
            rdb_Vigenere.ForeColor = System.Drawing.Color.Black;


        }

        private void rdb_Affine_CheckedChanged(object sender, EventArgs e)
        {
            txt_nhapm.Visible = false;
            txt_khoak2.Visible = true;
            txt_khoak1.Visible = true;
            txtlbK.Text = "Nhập a b";
            rdb_Ceasar.ForeColor = System.Drawing.Color.Black;
            rdb_Affine.ForeColor = System.Drawing.Color.DarkRed;
            rdb_Vigenere.ForeColor = System.Drawing.Color.Black;
        }

        private void rdb_Vigenere_CheckedChanged(object sender, EventArgs e)
        {
            txt_khoak2.Visible = false;
            txt_nhapm.Visible = true;
            txt_khoak1.Visible = true;
            txtlbK.Text = "Nhập Khóa K";
            rdb_Affine.ForeColor = System.Drawing.Color.Black;
            rdb_Ceasar.ForeColor = System.Drawing.Color.Black;
            rdb_Vigenere.ForeColor = System.Drawing.Color.DarkRed;

        }

        private void btn_nhaplai_Click_1(object sender, EventArgs e)
        {
            txt_bangro.Clear();
            txt_khoak1.Clear();
            txt_khoak2.Clear();
            txt_bangma.Clear();
            txt_nhapm.Clear();
            rdb_Ceasar.Checked = false;
            rdb_Affine.Checked = false;
            rdb_Vigenere.Checked = false;
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mahoa_Click_1(object sender, EventArgs e)
        {
            string plaintext = txt_bangro.Text.ToUpper();
            string key = txt_khoak1.Text.ToUpper();
            string ciphertext = "";

            if (rdb_Ceasar.Checked)
            {
                int shift = Convert.ToInt32(key);
                ciphertext = CaesarEncrypt(plaintext, shift);
            }
            else if (rdb_Affine.Checked)
            {
                int m = Convert.ToInt32(key);
                int b = Convert.ToInt32(txt_khoak2.Text);
                ciphertext = AffineEncrypt(plaintext, m, b);
            }
            else if (rdb_Vigenere.Checked)
            {
                ciphertext = VigenereEncrypt(plaintext, key);
            }

            txt_bangma.Text = ciphertext;
        }

        private void btn_giaima_Click_1(object sender, EventArgs e)
        {
            string ciphertext = txt_bangma.Text.ToUpper();
            string key = txt_khoak1.Text.ToUpper();
            string plaintext = "";

            if (rdb_Ceasar.Checked)
            {
                int shift = Convert.ToInt32(key);
                plaintext = CaesarDecrypt(ciphertext, shift);
            }
            else if (rdb_Affine.Checked)
            {
                int m = Convert.ToInt32(key);
                int b = Convert.ToInt32(txt_khoak2.Text);
                plaintext = AffineDecrypt(ciphertext, m, b);
            }
            else if (rdb_Vigenere.Checked)
            {
                plaintext = VigenereDecrypt(ciphertext, key);
            }

            txt_bangro.Text = plaintext;
        }

        private void btn_mahoa_MouseHover(object sender, EventArgs e)
        {
           /* Random random = new Random();
            int newX = random.Next(0, this.ClientSize.Width - btn_mahoa.Width);
            int newY = random.Next(0, this.ClientSize.Height - btn_mahoa.Height);

            newX = Math.Max(newX, 0);
            newY = Math.Max(newY, 0);
            newX = Math.Min(newX, this.ClientSize.Width - btn_mahoa.Width);
            newY = Math.Min(newY, this.ClientSize.Height - btn_mahoa.Height);

            btn_mahoa.Location = new Point(newX, newY);*/
        }
    }
}
