using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace practise01
{
    
    public partial class Form1 : Form
    {
        public const int MAXNUM = 12;

        struct STU
        {
            public int id { get; set; }//學號
            public string name { get; set; }//姓名
            public string gender { get; set; }//性別
            public string cla { get; set; }//班級
            public float height { get; set; }//身高
            public float weight { get; set; }//體重
        }
        STU[] stud = new STU[MAXNUM];
        int stuNum, stuNumA, stuNumB, stuNumC;
        

        public Form1()
        {
            InitializeComponent();
            Initial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stuNum + 1 > MAXNUM)
            {
                MessageBox.Show("總人數已滿");
            }
            else
            {
                Add();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvgClass(stud, "A班");
            AvgClass(stud, "B班");
            AvgClass(stud, "C班");

            AvgGender(stud, "男性");
            AvgGender(stud, "女性");
        }
        
        /// <summary>
        /// 初始化
        /// </summary>
        void Initial()
        {
            stuNum = 0;
            stuNumA = 0;
            stuNumB = 0;
            stuNumC = 0;

            for (int i = 0; i < MAXNUM; i++)
            {
                stud[i].id = i + 1;
                stud[i].name = "";
                stud[i].gender = "";
                stud[i].cla = "";
                stud[i].height = 0;
                stud[i].weight = 0;
            }
        }

        /// <summary>
        /// 清除
        /// </summary>
        void Clear()
        {
            NameTextBox.Text = "";
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            GenderComboBox.SelectedIndex = 0;
            ClassComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 新增
        /// </summary>
        void Add()
        {
            stud[stuNum].id = stuNum + 1;
            stud[stuNum].name = NameTextBox.Text;
            stud[stuNum].gender = GenderComboBox.Text;
            stud[stuNum].cla = ClassComboBox.Text;
            stud[stuNum].height = Convert.ToInt32(HeightTextBox.Text);
            stud[stuNum].weight = Convert.ToInt32(WeightTextBox.Text);
            if (stud[stuNum].cla == "A班")
            {
                if (stuNumA < 4)
                {
                    stuNumA++;
                    IdLabel.Text = stud[stuNum].id.ToString();
                    stuNum++;
                    ShowData(stuNum);
                }
                else
                {
                    MessageBox.Show("A班人數已滿");
                }
            }
            if (stud[stuNum].cla == "B班")
            {
                if (stuNumB < 3)
                {
                    stuNumB++;
                    IdLabel.Text = stud[stuNum].id.ToString();
                    stuNum++;
                    ShowData(stuNum);
                }
                else
                {
                    MessageBox.Show("B班人數已滿");
                }
            }
            if (stud[stuNum].cla == "C班")
            {
                if (stuNumC < 5)
                {
                    stuNumC++;
                    IdLabel.Text = stud[stuNum].id.ToString();
                    stuNum++;
                    ShowData(stuNum);
                }
                else
                {
                    MessageBox.Show("C班人數已滿");
                }
            }
        }


        /// <summary>
        /// 顯示資料
        /// </summary>
        /// <param name="no">人數</param>
        void ShowData(int no)
        {
            string str = "";
            no--;
            str = String.Format("[新增] 學號:{0}，姓名:{1}，" + "性別:{2}， 班級:{3}， 身高:{4}， 體重:{5} \r\n",
                stud[no].id, stud[no].name, stud[no].gender, stud[no].cla, stud[no].height, stud[no].weight);

            ShowTextBox.AppendText(str);
        }

        /// <summary>
        /// 計算班級平均身高&體重
        /// </summary>
        /// <param name="stud">學生陣列</param>
        /// <param name="className">班級名稱</param>
        void AvgClass(STU[] stud, string className)
        {
            string str = "";
            var studClass = stud.Where(s => s.cla == className);
            if (studClass.Any())
            {
                float avgH = studClass.Average(s => s.height);
                float avgW = studClass.Average(s => s.weight);
                str = String.Format("{0} : 平均身高= {1:###.##}， 平均體重= {2:###.##}",className, avgH, avgW);
                ShowTextBox.AppendText(str + "\r\n");
            }
            else
            {
                ShowTextBox.AppendText(className + "沒有學生數據 \r\n");
            }
        }

        /// <summary>
        /// 計算性別平均身高&體重
        /// </summary>
        /// <param name="stud">學生陣列</param>
        /// <param name="gender">性別</param>
        void AvgGender(STU[] stud, string gender)
        {
            string str = "";
            var studGender = stud.Where(g => g.gender == gender);
            if (studGender.Any())
            {
                float avgH = studGender.Average(g => g.height);
                float avgW = studGender.Average(g => g.weight);
                str = String.Format("{0} : 平均身高= {1:###.##}， 平均體重= {2:###.##}",gender, avgH, avgW);
                ShowTextBox.AppendText(str + "\r\n");
            }
            else
            {
                ShowTextBox.AppendText(gender + "沒有學生數據 \r\n");
            }
        }
    }
}
