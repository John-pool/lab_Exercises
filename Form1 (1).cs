using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelimsTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rands;

        //array of words
        string[] words =
        {
        "computer",
        "information",
        "hello",
        "programming",
        };

        string word;
        int word_order;

        public void load_word() //method
        {
            if (word_order < words.Length)
            {
                //to conver string to uppercase
                word = words[word_order].ToUpper();
                int word_length = word.Length;
                StringBuilder maskedWord = new StringBuilder(word_length);
                int mask = word_length / 2;
                ArrayList letter_mask = new ArrayList();

                for (int i = 0; i < mask; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rands.Next(word_length);
                        if (!letter_mask.Contains(rand_num))
                        {
                            letter_mask.Add(rand_num);
                            can_loop = false;

                        }
                    } while (can_loop);
                }
                //to output the ?? for clue in the game
                for (int i = 0; i < word_length; i++)
                {
                    if (letter_mask.Contains(i))
                    {
                        maskedWord.Append("?");
                    }
                    else
                    {
                        maskedWord.Append(word[i]);
                    }
                }

                lb_mask_word.Text = maskedWord.ToString();

            }
            else
            {
                refresh_words();
                load_word();
            }
        }
        public void refresh_words() //method
        {
            //to shuffle the words
            words = words.OrderBy(x => rands.Next()).ToArray();
            word_order = 0;
        }




        private void button1_Click(object sender, EventArgs e) //method
        {
            //to determine the game process
          /*  if (guess.Text.Equals("Play again"))
            {
                word_order++;
                load_word();
                guess.Text = "Guess";
                list.Items.Clear();
            }

            if (!answer.Text.Equals(""))
            {
                if (answer.Text.ToUpper().Equals(word))
                {
                    //to show if the user finished
                    lb_mask_word.Text = word;
                    guess.Text = "Play again";

                    MessageBox.Show("Correct guess");
                }
                else
                {
                    list.Items.Add(answer.Text);

                    MessageBox.Show("Wrong guess");
                }
                answer.Text = "  ";
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rands = new Random();

            refresh_words();
            load_word();
        }

        private void guess_Click(object sender, EventArgs e)
        {
            //to determine the game process
            if (guess.Text.Equals("Play again"))
            {
                word_order++;
                load_word();
                guess.Text = "Guess";
                list.Items.Clear();
            }

            if (!answer.Text.Equals(""))
            {
                if (answer.Text.ToUpper().Equals(word))
                {
                    //to show if the user finished
                    lb_mask_word.Text = word;
                    guess.Text = "Play again";

                    MessageBox.Show("Correct guess");
                }
                else
                {
                    list.Items.Add(answer.Text);

                    MessageBox.Show("Wrong guess");
                }
                answer.Text = "  ";
            }
        }
    }
}