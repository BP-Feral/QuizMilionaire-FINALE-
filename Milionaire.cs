using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMilionaire
{
    public partial class Milionaire : Form
    {
        //  List<int> asked = new List<int>();

        private string option;
        public int ID;
        private int score = 0;
        private List<Question> questions = new List<Question>();
        Question question = new Question("template", "A", "B", "C", "D", "S");
        public Milionaire()
        {

            InitializeComponent();
            init_question();
            // 
            // marker
            // 
            ((System.ComponentModel.ISupportInitialize)(this.marker)).EndInit();
            marker.Image = Properties.Resources.mark;
            marker.Location = new System.Drawing.Point(860, 548);
            marker.Name = "marker";
            if (score < 15)
            {
                marker.Size = new System.Drawing.Size(38, 38);
            }       
            marker.TabIndex = 13;
            marker.TabStop = false;

            btn_option_A.Enabled = false;
            btn_option_B.Enabled = false;
            btn_option_C.Enabled = false;
            btn_option_D.Enabled = false;
            btn_validate.Enabled = false;
            btn_validate.Visible = false;
        }

        public void init_question()
        {
            questions = question.Init();
        }

       // public void check_if_asked(int ID)
       // {
       //     bool alreadyExist = asked.Contains(ID);
       //     if (alreadyExist)
       //     {
       //         Random random = new Random();
       //         ID = random.Next(1, Question.GetCounter() - 1);
       //         check_if_asked(ID);
       //     }
       //     else
       //     {
       //        asked.Add(ID);
       //     }
       // }
        public void get_question()
        {
            if(score < 15)
            {
                Random random = new Random();
                ID = random.Next(1, Question.GetCounter() - 1);

                //check_if_asked(ID);
                question_box.Text = questions[ID].GetQuestion();
                btn_option_A.Text = questions[ID].GetA();
                btn_option_B.Text = questions[ID].GetB();
                btn_option_C.Text = questions[ID].GetC();
                btn_option_D.Text = questions[ID].GetD();
            }
            else
            {
                question_box.Text = $"Game ended, you got maximum points";
                btn_validate.Visible = false;
                btn_validate.Enabled = false;
                btn_validate.BackgroundImage = Properties.Resources.button_back;
                btn_start.Text = "RESTART";
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_option_A.Enabled = false;
                btn_option_B.Enabled = false;
                btn_option_C.Enabled = false;
                btn_option_D.Enabled = false;
                score = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_validate.Visible = true;
            
            btn_start.Enabled = false;
            btn_start.Visible = false;

            btn_option_A.Enabled = true;
            btn_option_B.Enabled = true;
            btn_option_C.Enabled = true;
            btn_option_D.Enabled = true;
            btn_option_A.BackgroundImage = Properties.Resources.back; ;
            btn_option_B.BackgroundImage = Properties.Resources.back; ;
            btn_option_C.BackgroundImage = Properties.Resources.back; ;
            btn_option_D.BackgroundImage = Properties.Resources.back; ;
            get_question();
            marker.Image = Properties.Resources.mark;
            marker.Location = new System.Drawing.Point(860, 548);
        }

        private void btn_option_A_Click(object sender, EventArgs e)
        {
            option = "A";
            btn_validate.Enabled = true;
            btn_validate.BackgroundImage = Properties.Resources.button;
            btn_option_A.BackgroundImage = Properties.Resources.back_selected;
            btn_option_B.BackgroundImage = Properties.Resources.back;
            btn_option_C.BackgroundImage = Properties.Resources.back;
            btn_option_D.BackgroundImage = Properties.Resources.back;
        }

        private void btn_option_B_Click(object sender, EventArgs e)
        {
            option = "B";
            btn_validate.Enabled = true;
            btn_validate.BackgroundImage = Properties.Resources.button;
            btn_option_A.BackgroundImage = Properties.Resources.back;
            btn_option_B.BackgroundImage = Properties.Resources.back_selected;
            btn_option_C.BackgroundImage = Properties.Resources.back;
            btn_option_D.BackgroundImage = Properties.Resources.back;

        }

        private void btn_option_C_Click(object sender, EventArgs e)
        {
            option = "C";
            btn_validate.Enabled = true;
            btn_validate.BackgroundImage = Properties.Resources.button;
            btn_option_A.BackgroundImage = Properties.Resources.back;
            btn_option_B.BackgroundImage = Properties.Resources.back;
            btn_option_C.BackgroundImage = Properties.Resources.back_selected;
            btn_option_D.BackgroundImage = Properties.Resources.back;

        }

        private void btn_option_D_Click(object sender, EventArgs e)
        {
            option = "D";
            btn_validate.Enabled = true;
            btn_validate.BackgroundImage = Properties.Resources.button;
            btn_option_A.BackgroundImage = Properties.Resources.back;
            btn_option_B.BackgroundImage = Properties.Resources.back;
            btn_option_C.BackgroundImage = Properties.Resources.back;
            btn_option_D.BackgroundImage = Properties.Resources.back_selected;

        }
        private void btn_validate_Click(object sender, EventArgs e)
        {
            string result = questions[ID].GetSolution();
            if (option == result)
            {
                if(score < 14)
                marker.Location = new System.Drawing.Point(860, 548 - 38 - 38*score);

                option = "X";
                btn_validate.Enabled = false;
                btn_validate.BackgroundImage = Properties.Resources.button_back;
                btn_option_A.BackgroundImage = Properties.Resources.back;
                btn_option_B.BackgroundImage = Properties.Resources.back;
                btn_option_C.BackgroundImage = Properties.Resources.back;
                btn_option_D.BackgroundImage = Properties.Resources.back;
                score += 1;
                get_question();
            }
            else
            {
                question_box.Text = $"Game ended, you got {score} points";
                btn_validate.Visible = false;
                btn_validate.Enabled = false;
                marker.Image = Properties.Resources.mark_failed;
                btn_validate.BackgroundImage = Properties.Resources.button_back;
                btn_start.Text = "RESTART";
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_option_A.Enabled = false;
                btn_option_B.Enabled = false;
                btn_option_C.Enabled = false;
                btn_option_D.Enabled = false;
                score = 0;
            }
        }
    }
}
