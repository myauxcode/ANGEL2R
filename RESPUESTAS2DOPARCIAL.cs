/////  Pregunta 1

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




        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(pregunta1(textBox1.Text));
        }