using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace healthCalculator
{

    public partial class Form1 : Form
    {
        public const int MAXNUM = 12;

        #region 學生資料結構
        struct STU
        {
            public int id { get; set; }//學號
            public string name { get; set; }//姓名
            public string gender { get; set; }//性別
            public string cla { get; set; }//班級
            public float height { get; set; }//身高
            public float weight { get; set; }//體重
            public float bmi {  get; set; }//BMI
        }
        #endregion

        STU[] stud = new STU[MAXNUM];
        int stuNum, stuNumA, stuNumB, stuNumC;
        int classAMaxNum = 4, classBMaxNum = 3, classCMaxNum = 5;

        public Form1()
        {
            InitializeComponent();
            Initial();
        }
        
        /// <summary>
        /// 初始化
        /// </summary>
        private void Initial()
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
                stud[i].bmi = 0;
            }
        }

        /// <summary>
        /// 清除
        /// </summary>
        private void Clear()
        {
            NameTextBox.Text = "";
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            GenderComboBox.SelectedIndex = 0;
            ClassComboBox.SelectedIndex = 0;
        }

        #region 自訂邏輯區
        /// <summary>
        /// 新增
        /// </summary>
        private void Add()
        {
            stud[stuNum].id = stuNum + 1;
            stud[stuNum].name = NameTextBox.Text;
            stud[stuNum].gender = GenderComboBox.Text;
            stud[stuNum].cla = ClassComboBox.Text;
            stud[stuNum].height = Convert.ToInt32(HeightTextBox.Text);
            stud[stuNum].weight = Convert.ToInt32(WeightTextBox.Text);
            stud[stuNum].bmi = BMI(stud[stuNum].height, stud[stuNum].weight);

            DetermineClassNum(stud, "A班", stuNumA, classAMaxNum);
            DetermineClassNum(stud, "B班", stuNumB, classBMaxNum);
            DetermineClassNum(stud, "C班", stuNumC, classCMaxNum);
        }

        /// <summary>
        /// 判斷班級人數是否額滿
        /// </summary>
        /// <param name="stud">學生陣列</param>
        /// <param name="claaaName">班級名稱</param>
        /// <param name="classStuNum">現有班級人數</param>
        /// <param name="maxNum">滿額人數</param>
        private void DetermineClassNum(STU[] stud, string claaaName, int classStuNum, int maxNum)
        {
            if (stud[stuNum].cla == claaaName)
            {
                if (classStuNum < maxNum)
                {
                    classStuNum++;
                    IdLabel.Text = stud[stuNum].id.ToString();
                    stuNum++;
                    ShowData(stuNum);
                }
                else
                {
                    MessageBox.Show(claaaName + "人數已滿");
                }
            }
        }

        /// <summary>
        /// 計算BMI公式
        /// </summary>
        /// <param name="height">公分身高</param>
        /// <param name="weight">體重公斤</param>
        /// <returns>BMI</returns>
        private float BMI(float height, float weight)
        {
            float m = height / 100.0f;
            float bmi = weight / (m * m);
            return bmi;
        }

        /// <summary>
        /// 顯示資料
        /// </summary>
        /// <param name="no">人數</param>
        void ShowData(int no)
        {
            string str = "";
            no--;
            str = String.Format("[新增] 學號:{0}，姓名:{1}，" + "性別:{2}， 班級:{3}， 身高:{4}， 體重:{5}， BMI:{6:F2} \r\n",
                stud[no].id, stud[no].name, stud[no].gender, stud[no].cla, stud[no].height, stud[no].weight, stud[no].bmi);

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
                float avgBMI = studClass.Average(s => s.bmi);
                str = String.Format("{0} : 平均身高= {1:F2}， 平均體重= {2:F2}， 平均BMI= {3:F2}", className, avgH, avgW, avgBMI);
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
                float avgBMI = studGender.Average(g => g.bmi);
                str = String.Format("{0} : 平均身高= {1:F2}， 平均體重= {2:F2}，平均BMI= {3:F2}", gender, avgH, avgW, avgBMI);
                ShowTextBox.AppendText(str + "\r\n");
            }
            else
            {
                ShowTextBox.AppendText(gender + "沒有學生數據 \r\n");
            }
        }

        /// <summary>
        /// 計算所有平均並顯示
        /// </summary>
        private void Cipher()
        {
            AvgClass(stud, "A班");
            AvgClass(stud, "B班");
            AvgClass(stud, "C班");
            ShowTextBox.AppendText("-----班平均計算完畢-----\r\n");

            AvgGender(stud, "男性");
            AvgGender(stud, "女性");
            ShowTextBox.AppendText("-----性別平均計算完畢-----\r\n");
        }
        #endregion

        private void addButton_Click(object sender, EventArgs e)
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cipherButton_Click(object sender, EventArgs e)
        {
            Cipher();
        }


    }
}
