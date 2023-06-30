 //EJERCICIO 1

        /////  Pregunta 1 ////////////////////////////////////////////////////////
        public string pregunta1(string s)
        {
            string sr = "";
            char caracterAnterior = '\0';
            for (int i = 1; i <= s.Length; i++)
            {
                if ((s[i - 1]) != caracterAnterior)
                {
                    sr = sr + (s[i - 1]);
                }
                caracterAnterior = (s[i - 1]);

            }

            return sr;
        }



        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(pregunta1(textBox1.Text));
        }


        //EJERCICIO 2 ////////////////////////////////////////////////////////////////


        public string ejercicio2(string s)
        {

            string sr = "";
            string s2 = "";
            string saux = s;
            int c = 0;
            s = s + ' ';
            for (int i = 1; i <= s.Length; i++)
            {
                sr = sr + s[i - 1];

                if (VerifVoc(s[i - 1]) == true)
                {
                    c++;


                }

                if (s[i - 1 ] == ' ')
                {
                    if (c == 5)
                    {
                        s2 = s2 + sr;
                        sr = "";
                        c = 0;

                    }
                    else
                    {
                        sr = "";
                        c = 0;
                    }

                }
             


            }
            s = saux;
            return s2;

        }

        public bool VerifVoc(char car)
        {
            const string VOCALES = "AEIOU";
            bool b;
            int i, n;
            b = false;
            i = 1;
            n = VOCALES.Length;
            car = RetMayus(car);
            while ((i <= n) && (b == false))
            {
                if (car == VOCALES[i - 1])
                {
                    b = true;

                }
                i++;
            }
            return b;
        }

        public char RetMayus(char car)
        {
            return char.ToUpper(car); // ToUpper(car) Metodo que convierte un caracter a Mayuscula
        }

        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(ejercicio2(textBox1.Text));
        }