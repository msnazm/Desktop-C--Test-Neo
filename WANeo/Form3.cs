using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WANeo;

namespace WFNeo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // var db = new DCNeoDataContext();
           // db.InsertNeorecord(radioButton1.Checked,
           //      radioButton4, radioButton15,
           //      radioButton2, radioButton3,
           //      radioButton9, radioButton8,
           //      radioButton6, radioButton7,
           //      radioButton5, radioButton14,
           //      radioButton13, radioButton11,
           //      radioButton12, radioButton10,
           //      radioButton20, radioButton19,
           //      radioButton17, radioButton18,
           //      radioButton16, radioButton25,
           //      radioButton24, radioButton22,
           //      radioButton23, radioButton21,
           //      radioButton30, radioButton29,
           //      radioButton27, radioButton28,
           //      radioButton26, radioButton35,
           //      radioButton34, radioButton32,
           //      radioButton33, radioButton31,
           //      radioButton40, radioButton39,
           //      radioButton37, radioButton38,
           //      radioButton36, radioButton45,
           //      radioButton44, radioButton42,
           //      radioButton43, radioButton41,
           //      radioButton50, radioButton49,
           //      radioButton47, radioButton48,
           //      radioButton46, radioButton85,
           //      radioButton84, radioButton82,
           //      radioButton83, radioButton81,
           //      radioButton80, radioButton79,
           //      radioButton77, radioButton78,
           //      radioButton76, radioButton75,
           //      radioButton74, radioButton72,
           //      radioButton73, radioButton71,
           //      radioButton100, radioButton99,
           //      radioButton97, radioButton98,
           //      radioButton96, radioButton95,
           //      radioButton94, radioButton92,
           //      radioButton93, radioButton91,
           //      radioButton90, radioButton89,
           //      radioButton87, radioButton88,
           //      radioButton86, radioButton55,
           //      radioButton54, radioButton52,
           //      radioButton53, radioButton51,
           //      radioButton60, radioButton59,
           //      radioButton57, radioButton58,
           //      radioButton56, radioButton70,
           //      radioButton69, radioButton67,
           //      radioButton68, radioButton66,
           //      radioButton65, radioButton64,
           //      radioButton62, radioButton63,
           //      radioButton61, radioButton134,
           //      radioButton133, radioButton131,
           //      radioButton132, radioButton130,
           //      radioButton110, radioButton109,
           //      radioButton107, radioButton108,
           //      radioButton106, radioButton105,
           //      radioButton104, radioButton103,
           //      radioButton102, radioButton101,
           //      radioButton119, radioButton118,
           //      radioButton116, radioButton117,
           //      radioButton115, radioButton129,
           //      radioButton128, radioButton126,
           //      radioButton127, radioButton125,
           //      radioButton124, radioButton123,
           //      radioButton121, radioButton122,
           //      radioButton120, radioButton140,
           //      radioButton139, radioButton137,
           //      radioButton138, radioButton136,
           //      radioButton145, radioButton144,
           //      radioButton142, radioButton143,
           //      radioButton141, radioButton135,
           //      radioButton114,
           //   radioButton112, radioButton113,
           //      radioButton111, radioButton150,
           //      radioButton149, radioButton147,
           //      radioButton148, radioButton146,
           //      radioButton155, radioButton154,
           //      radioButton152, radioButton153,
           //      radioButton151, radioButton168,
           //      radioButton157, radioButton178,
           //      radioButton162, radioButton156,
           //      radioButton180, radioButton161,
           //      radioButton159, radioButton160,
           //      radioButton158, radioButton172,
           //      radioButton175,
           //       radioButton170, radioButton171,
           //      radioButton169, radioButton177,
           //      radioButton179, radioButton174,
           //      radioButton176, radioButton173,
           //      radioButton167, radioButton166,
           //      radioButton164, radioButton165,
           //      radioButton163, radioButton190,
           //      radioButton189, radioButton187,
           //      radioButton188, radioButton186,
           //      radioButton185, radioButton184,
           //      radioButton182, radioButton183,
           //      radioButton181, radioButton200,
           //      radioButton199,
           //       radioButton197, radioButton198,
           //      radioButton196, radioButton195,
           //      radioButton194, radioButton192,
           //      radioButton193, radioButton191,
           //      radioButton205, radioButton204,
           //      radioButton202, radioButton203,
           //      radioButton201, radioButton218,
           //      radioButton207, radioButton228,
           //      radioButton212, radioButton206,
           //      radioButton230, radioButton211,
           //      radioButton209, radioButton210,
           //      radioButton208, radioButton222,
           //      radioButton225,
           //       radioButton220, radioButton221,
           //      radioButton219, radioButton227,
           //      radioButton229, radioButton224,
           //      radioButton226, radioButton223,
           //      radioButton217, radioButton216,
           //      radioButton214, radioButton215,
           //      radioButton213, radioButton240,
           //      radioButton239, radioButton237,
           //      radioButton238, radioButton236,
           //      radioButton235, radioButton234,
           //      radioButton232, radioButton233,
           //      radioButton231, radioButton250,
           //      radioButton249,
           //       radioButton247, radioButton248,
           //      radioButton246, radioButton245,
           //      radioButton244, radioButton242,
           //      radioButton243, radioButton241,
           //      radioButton255, radioButton254,
           //      radioButton252, radioButton253,
           //      radioButton251, radioButton268,
           //      radioButton257, radioButton278,
           //      radioButton262, radioButton256,
           //      radioButton280, radioButton261,
           //      radioButton259, radioButton260,
           //      radioButton258, radioButton272,
           //      radioButton275,
           //       radioButton270, radioButton271,
           //      radioButton269, radioButton277,
           //      radioButton279, radioButton274,
           //      radioButton276, radioButton273,
           //      radioButton267, radioButton266,
           //      radioButton264, radioButton265,
           //      radioButton263, radioButton290,
           //      radioButton289, radioButton287,
           //      radioButton288, radioButton286,
           //      radioButton285, radioButton284,
           //      radioButton282, radioButton283,
           //      radioButton281, radioButton300,
           //      radioButton299,
           //       radioButton297, radioButton298,
           //      radioButton296, radioButton295,
           //      radioButton294, radioButton292,
           //      radioButton293, radioButton291,
           //      txtName.Text.ToString, txtLastName.Text.ToString,
           //      txtDate.Text.ToString);

           //// dgTranse.DataSouce = db.tbl_Dics;
           //// txtOrginal.Text = "";
           // //txtTranse.Text = "";

           // var b = (from x in db.TB_Neos
           //          // where ((x.id_dic == x.id_dic))
           //          orderby (x.Id)
           //          select x).Count();
           // label121.Text = b.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = "4";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton4.Checked == true)
            {
                textBox1.Text = "3";
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton15.Checked == true)
            {
                textBox1.Text = "2";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                textBox1.Text = "1";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                textBox1.Text = "0";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton9.Checked == true)
            {
                textBox2.Text = "0";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                textBox2.Text = "1";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox2.Text = "2";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                textBox2.Text = "3";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox2.Text = "4";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                textBox3.Text = "4";
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                textBox3.Text = "3";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                textBox3.Text = "2";
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                textBox3.Text = "1";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                textBox3.Text = "0";
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {
                textBox4.Text = "4";
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                textBox4.Text = "3";
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                textBox4.Text = "2";
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                textBox4.Text = "1";
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                textBox4.Text = "0";
            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked == true)
            {
                textBox5.Text = "4";
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                textBox5.Text = "3";
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked == true)
            {
                textBox5.Text = "2";
            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked == true)
            {
                textBox5.Text = "1";
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
            {
                textBox5.Text = "0";
            }
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton30.Checked == true)
            {
                textBox6.Text = "4";
            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked == true)
            {
                textBox6.Text = "3";
            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked == true)
            {
                textBox6.Text = "2";
            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked == true)
            {
                textBox6.Text = "1";
            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
            {
                textBox6.Text = "0";
            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked == true)
            {
                textBox7.Text = "4";
            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked == true)
            {
                textBox7.Text = "3";
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked == true)
            {
                textBox7.Text = "2";
            }
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked == true)
            {
                textBox7.Text = "1";
            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked == true)
            {
                textBox7.Text = "0";
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton40.Checked == true)
            {
                textBox8.Text = "4";
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton39.Checked == true)
            {
                textBox8.Text = "3";
            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked == true)
            {
                textBox8.Text = "2";
            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked == true)
            {
                textBox8.Text = "1";
            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked == true)
            {
                textBox8.Text = "0";
            }
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton45.Checked == true)
            {
                textBox9.Text = "4";
            }
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton44.Checked == true)
            {
                textBox9.Text = "3";
            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton42.Checked == true)
            {
                textBox9.Text = "2";
            }
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton43.Checked == true)
            {
                textBox9.Text = "1";
            }
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton41.Checked == true)
            {
                textBox9.Text = "0";
            }
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton50.Checked == true)
            {
                textBox10.Text = "4";
            }
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton49.Checked == true)
            {
                textBox10.Text = "3";
            }
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton47.Checked == true)
            {
                textBox10.Text = "2";
            }
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton48.Checked == true)
            {
                textBox10.Text = "1";
            }
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton46.Checked == true)
            {
                textBox10.Text = "0";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
           
            
           // textBox61.Text.ToString = a + b + c + d;
        }

        private void radioButton85_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton85.Checked == true)
            {
                textBox11.Text = "4";
            }
        }

        private void radioButton84_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton84.Checked == true)
            {
                textBox11.Text = "3";
            }
        }

        private void radioButton82_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton82.Checked == true)
            {
                textBox11.Text = "2";
            }
        }

        private void radioButton83_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton83.Checked == true)
            {
                textBox11.Text = "1";
            }
        }

        private void radioButton81_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton81.Checked == true)
            {
                textBox11.Text = "0";
            }
        }

        private void radioButton80_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton80.Checked == true)
            {
                textBox12.Text = "4";
            }
        }

        private void radioButton79_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton79.Checked == true)
            {
                textBox12.Text = "3";
            }
        }

        private void radioButton77_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton77.Checked == true)
            {
                textBox12.Text = "2";
            }
        }

        private void radioButton78_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton78.Checked == true)
            {
                textBox12.Text = "1";
            }
        }

        private void radioButton76_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton76.Checked == true)
            {
                textBox12.Text = "0";
            }
        }

        private void radioButton75_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton75.Checked == true)
            {
                textBox13.Text = "4";
            }
        }

        private void radioButton74_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton74.Checked == true)
            {
                textBox13.Text = "3";
            }
        }

        private void radioButton72_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton72.Checked == true)
            {
                textBox13.Text = "2";
            }
        }

        private void radioButton73_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton73.Checked == true)
            {
                textBox13.Text = "1";
            }
        }

        private void radioButton71_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton71.Checked == true)
            {
                textBox13.Text = "0";
            }
        }

        private void radioButton100_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton100.Checked == true)
            {
                textBox14.Text = "4";
            }
        }

        private void radioButton99_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton99.Checked == true)
            {
                textBox14.Text = "3";
            }
        }

        private void radioButton97_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton97.Checked == true)
            {
                textBox14.Text = "2";
            }
        }

        private void radioButton98_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton98.Checked == true)
            {
                textBox14.Text = "1";
            }
        }

        private void radioButton96_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton96.Checked == true)
            {
                textBox14.Text = "0";
            }
        }

        private void radioButton95_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton95.Checked == true)
            {
                textBox15.Text = "4";
            }
        }

        private void radioButton94_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton94.Checked == true)
            {
                textBox15.Text = "3";
            }
        }

        private void radioButton92_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton92.Checked == true)
            {
                textBox15.Text = "2";
            }
        }

        private void radioButton93_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton93.Checked == true)
            {
                textBox15.Text = "1";
            }
        }

        private void radioButton91_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox15.Text = "0";
            }
        }

        private void radioButton90_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton90.Checked == true)
            {
                textBox16.Text = "4";
            }
        }

        private void radioButton89_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton89.Checked == true)
            {
                textBox16.Text = "3";
            }
        }

        private void radioButton87_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton87.Checked == true)
            {
                textBox16.Text = "2";
            }
        }

        private void radioButton88_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton88.Checked == true)
            {
                textBox16.Text = "1";
            }
        }

        private void radioButton86_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton86.Checked == true)
            {
                textBox16.Text = "0";
            }
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton55.Checked == true)
            {
                textBox17.Text = "4";
            }
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton54.Checked == true)
            {
                textBox17.Text = "3";
            }
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton52.Checked == true)
            {
                textBox17.Text = "2";
            }
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton53.Checked == true)
            {
                textBox17.Text = "1";
            }
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton51.Checked == true)
            {
                textBox17.Text = "0";
            }
        }

        private void radioButton60_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton60.Checked == true)
            {
                textBox18.Text = "4";
            }
        }

        private void radioButton59_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton59.Checked == true)
            {
                textBox18.Text = "3";
            }
        }

        private void radioButton57_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton57.Checked == true)
            {
                textBox18.Text = "2";
            }
        }

        private void radioButton58_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton58.Checked == true)
            {
                textBox18.Text = "1";
            }
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton56.Checked == true)
            {
                textBox18.Text = "0";
            }
        }

        private void radioButton70_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton70.Checked == true)
            {
                textBox19.Text = "4";
            }
        }

        private void radioButton69_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton69.Checked == true)
            {
                textBox19.Text = "3";
            }
        }

        private void radioButton67_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton67.Checked == true)
            {
                textBox19.Text = "2";
            }
        }

        private void radioButton68_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton68.Checked == true)
            {
                textBox19.Text = "1";
            }
        }

        private void radioButton66_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton66.Checked == true)
            {
                textBox19.Text = "0";
            }
        }

        private void radioButton65_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton65.Checked == true)
            {
                textBox20.Text = "4";
            }
        }

        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton64.Checked == true)
            {
                textBox20.Text = "3";
            }
        }

        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton62.Checked == true)
            {
                textBox20.Text = "2";
            }
        }

        private void radioButton63_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton63.Checked == true)
            {
                textBox20.Text = "1";
            }
        }

        private void radioButton61_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton61.Checked == true)
            {
                textBox20.Text = "0";
            }
        }

        private void radioButton134_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton134.Checked == true)
            {
                textBox21.Text = "4";
            }
        }

        private void radioButton133_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton133.Checked == true)
            {
                textBox21.Text = "3";
            }
        }

        private void radioButton131_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton131.Checked == true)
            {
                textBox21.Text = "2";
            }
        }

        private void radioButton132_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton132.Checked == true)
            {
                textBox21.Text = "1";
            }
        }

        private void radioButton130_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton130.Checked == true)
            {
                textBox21.Text = "0";
            }
        }

        private void radioButton110_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton110.Checked == true)
            {
                textBox22.Text = "4";
            }
        }

        private void radioButton109_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton109.Checked == true)
            {
                textBox22.Text = "3";
            }
        }

        private void radioButton107_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton107.Checked == true)
            {
                textBox22.Text = "2";
            }
        }

        private void radioButton108_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton108.Checked == true)
            {
                textBox22.Text = "1";
            }
        }

        private void radioButton106_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton106.Checked == true)
            {
                textBox22.Text = "0";
            }
        }

        private void radioButton105_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton105.Checked == true)
            {
                textBox23.Text = "4";
            }
        }

        private void radioButton104_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton104.Checked == true)
            {
                textBox23.Text = "3";
            }
        }

        private void radioButton103_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton103.Checked == true)
            {
                textBox23.Text = "2";
            }
        }

        private void radioButton102_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton102.Checked == true)
            {
                textBox23.Text = "1";
            }
        }

        private void radioButton101_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton101.Checked == true)
            {
                textBox23.Text = "0";
            }
        }

        private void radioButton119_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton119.Checked == true)
            {
                textBox24.Text = "4";
            }
        }

        private void radioButton118_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton118.Checked == true)
            {
                textBox24.Text = "3";
            }
        }

        private void radioButton116_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton116.Checked == true)
            {
                textBox24.Text = "2";
            }
        }

        private void radioButton117_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton117.Checked == true)
            {
                textBox24.Text = "1";
            }
        }

        private void radioButton115_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton115.Checked == true)
            {
                textBox24.Text = "0";
            }
        }

        private void radioButton129_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton129.Checked == true)
            {
                textBox25.Text = "4";
            }
        }

        private void radioButton128_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton128.Checked == true)
            {
                textBox25.Text = "3";
            }
        }

        private void radioButton126_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton126.Checked == true)
            {
                textBox25.Text = "2";
            }
        }

        private void radioButton127_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton127.Checked == true)
            {
                textBox25.Text = "1";
            }
        }

        private void radioButton125_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton125.Checked == true)
            {
                textBox25.Text = "0";
            }
        }

        private void radioButton124_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton124.Checked == true)
            {
                textBox26.Text = "4";
            }
        }

        private void radioButton123_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton123.Checked == true)
            {
                textBox26.Text = "3";
            }
        }

        private void radioButton121_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton121.Checked == true)
            {
                textBox26.Text = "2";
            }
        }

        private void radioButton122_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton122.Checked == true)
            {
                textBox26.Text = "1";
            }
        }

        private void radioButton120_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton120.Checked == true)
            {
                textBox26.Text = "0";
            }
        }

        private void radioButton140_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton140.Checked == true)
            {
                textBox27.Text = "4";
            }
        }

        private void radioButton139_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton139.Checked == true)
            {
                textBox27.Text = "3";
            }
        }

        private void radioButton137_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton137.Checked == true)
            {
                textBox27.Text = "2";
            }
        }

        private void radioButton138_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton138.Checked == true)
            {
                textBox27.Text = "1";
            }
        }

        private void radioButton136_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton136.Checked == true)
            {
                textBox27.Text = "0";
            }
        }

        private void radioButton145_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton145.Checked == true)
            {
                textBox28.Text = "4";
            }
        }

        private void radioButton144_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton144.Checked == true)
            {
                textBox28.Text = "3";
            }
        }

        private void radioButton142_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton142.Checked == true)
            {
                textBox28.Text = "2";
            }
        }

        private void radioButton143_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton143.Checked == true)
            {
                textBox28.Text = "1";
            }
        }

        private void radioButton141_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton141.Checked == true)
            {
                textBox28.Text = "0";
            }
        }

        private void radioButton135_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton135.Checked == true)
            {
                textBox29.Text = "4";
            }
        }

        private void radioButton114_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton114.Checked == true)
            {
                textBox29.Text = "3";
            }
        }

        private void radioButton112_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton112.Checked == true)
            {
                textBox29.Text = "2";
            }
        }

        private void radioButton113_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton113.Checked == true)
            {
                textBox29.Text = "1";
            }
        }

        private void radioButton111_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton111.Checked == true)
            {
                textBox29.Text = "0";
            }
        }

        private void radioButton150_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton150.Checked == true)
            {
                textBox30.Text = "4";
            }
        }

        private void radioButton149_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton149.Checked == true)
            {
                textBox30.Text = "3";
            }
        }

        private void radioButton147_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton147.Checked == true)
            {
                textBox30.Text = "2";
            }
        }

        private void radioButton148_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton148.Checked == true)
            {
                textBox30.Text = "1";
            }
        }

        private void radioButton146_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton146.Checked == true)
            {
                textBox30.Text = "0";
            }
        }

        private void radioButton155_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton155.Checked == true)
            {
                textBox31.Text = "4";
            }
        }

        private void radioButton154_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton154.Checked == true)
            {
                textBox31.Text = "3";
            }
        }

        private void radioButton152_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton152.Checked == true)
            {
                textBox31.Text = "2";
            }
        }

        private void radioButton153_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton153.Checked == true)
            {
                textBox31.Text = "1";
            }
        }

        private void radioButton151_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton155.Checked == true)
            {
                textBox31.Text = "4";
            }
        }

        private void radioButton168_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton168.Checked == true)
            {
                textBox32.Text = "4";
            }
        }

        private void radioButton157_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton157.Checked == true)
            {
                textBox32.Text = "3";
            }
        }

        private void radioButton178_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton178.Checked == true)
            {
                textBox32.Text = "2";
            }
        }

        private void radioButton162_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton162.Checked == true)
            {
                textBox32.Text = "1";
            }
        }

        private void radioButton156_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton156.Checked == true)
            {
                textBox32.Text = "0";
            }
        }

        private void radioButton180_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton180.Checked == true)
            {
                textBox33.Text = "4";
            }
        }

        private void radioButton161_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton161.Checked == true)
            {
                textBox33.Text = "3";
            }
        }

        private void radioButton159_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton159.Checked == true)
            {
                textBox33.Text = "2";
            }
        }

        private void radioButton160_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton160.Checked == true)
            {
                textBox33.Text = "1";
            }
        }

        private void radioButton158_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton158.Checked == true)
            {
                textBox33.Text = "0";
            }
        }

        private void radioButton172_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton172.Checked == true)
            {
                textBox34.Text = "4";
            }
        }

        private void radioButton175_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton175.Checked == true)
            {
                textBox34.Text = "3";
            }
        }

        private void radioButton170_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton170.Checked == true)
            {
                textBox34.Text = "2";
            }
        }

        private void radioButton171_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton171.Checked == true)
            {
                textBox34.Text = "1";
            }
        }

        private void radioButton169_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton169.Checked == true)
            {
                textBox34.Text = "0";
            }
        }

        private void radioButton177_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton177.Checked == true)
            {
                textBox35.Text = "4";
            }
        }

        private void radioButton179_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton179.Checked == true)
            {
                textBox35.Text = "3";
            }
        }

        private void radioButton174_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton174.Checked == true)
            {
                textBox35.Text = "2";
            }
        }

        private void radioButton176_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton176.Checked == true)
            {
                textBox35.Text = "1";
            }
        }

        private void radioButton173_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton173.Checked == true)
            {
                textBox35.Text = "0";
            }
        }

        private void radioButton167_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton167.Checked == true)
            {
                textBox36.Text = "4";
            }
        }

        private void radioButton166_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton166.Checked == true)
            {
                textBox36.Text = "3";
            }
        }

        private void radioButton164_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton164.Checked == true)
            {
                textBox36.Text = "2";
            }
        }

        private void radioButton165_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton165.Checked == true)
            {
                textBox36.Text = "1";
            }
        }

        private void radioButton163_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton163.Checked == true)
            {
                textBox36.Text = "0";
            }
        }

        private void radioButton190_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton190.Checked == true)
            {
                textBox37.Text = "4";
            }
        }

        private void radioButton189_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton189.Checked == true)
            {
                textBox37.Text = "3";
            }
        }

        private void radioButton187_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton187.Checked == true)
            {
                textBox37.Text = "2";
            }
        }

        private void radioButton188_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton188.Checked == true)
            {
                textBox37.Text = "1";
            }
        }

        private void radioButton186_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton186.Checked == true)
            {
                textBox37.Text = "0";
            }
        }

        private void radioButton185_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton185.Checked == true)
            {
                textBox38.Text = "4";
            }
        }

        private void radioButton184_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton184.Checked == true)
            {
                textBox38.Text = "3";
            }
        }

        private void radioButton182_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton182.Checked == true)
            {
                textBox38.Text = "2";
            }
        }

        private void radioButton183_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton183.Checked == true)
            {
                textBox38.Text = "1";
            }
        }

        private void radioButton181_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton181.Checked == true)
            {
                textBox38.Text = "0";
            }
        }

        private void radioButton200_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton200.Checked == true)
            {
                textBox39.Text = "4";
            }
        }

        private void radioButton199_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton199.Checked == true)
            {
                textBox39.Text = "3";
            }
        }

        private void radioButton197_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton197.Checked == true)
            {
                textBox39.Text = "2";
            }
        }

        private void radioButton198_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton198.Checked == true)
            {
                textBox39.Text = "1";
            }
        }

        private void radioButton196_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton196.Checked == true)
            {
                textBox39.Text = "0";
            }
        }

        private void radioButton195_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton195.Checked == true)
            {
                textBox40.Text = "4";
            }
        }

        private void radioButton194_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton194.Checked == true)
            {
                textBox40.Text = "3";
            }
        }

        private void radioButton192_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton192.Checked == true)
            {
                textBox40.Text = "2";
            }
        }

        private void radioButton193_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton193.Checked == true)
            {
                textBox40.Text = "1";
            }
        }

        private void radioButton191_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton191.Checked == true)
            {
                textBox40.Text = "0";
            }
        }

        private void radioButton205_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton205.Checked == true)
            {
                textBox41.Text = "4";
            }
        }

        private void radioButton204_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton204.Checked == true)
            {
                textBox41.Text = "3";
            }
        }

        private void radioButton202_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton202.Checked == true)
            {
                textBox41.Text = "2";
            }
        }

        private void radioButton203_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton203.Checked == true)
            {
                textBox41.Text = "1";
            }
        }

        private void radioButton201_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton201.Checked == true)
            {
                textBox41.Text = "0";
            }
        }

        private void radioButton218_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton218.Checked == true)
            {
                textBox42.Text = "4";
            }
        }

        private void radioButton207_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton207.Checked == true)
            {
                textBox42.Text = "3";
            }
        }

        private void radioButton228_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton228.Checked == true)
            {
                textBox42.Text = "2";
            }
        }

        private void radioButton212_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton212.Checked == true)
            {
                textBox42.Text = "1";
            }
        }

        private void radioButton206_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton206.Checked == true)
            {
                textBox42.Text = "0";
            }
        }

        private void radioButton230_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton230.Checked == true)
            {
                textBox43.Text = "4";
            }
        }

        private void radioButton211_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton211.Checked == true)
            {
                textBox43.Text = "3";
            }
        }

        private void radioButton209_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton209.Checked == true)
            {
                textBox43.Text = "2";
            }
        }

        private void radioButton210_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton210.Checked == true)
            {
                textBox43.Text = "1";
            }
        }

        private void radioButton208_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton208.Checked == true)
            {
                textBox43.Text = "0";
            }
        }

        private void radioButton222_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton222.Checked == true)
            {
                textBox44.Text = "4";
            }
        }

        private void radioButton225_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton225.Checked == true)
            {
                textBox44.Text = "3";
            }
        }

        private void radioButton220_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton220.Checked == true)
            {
                textBox44.Text = "2";
            }
        }

        private void radioButton221_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton221.Checked == true)
            {
                textBox44.Text = "1";
            }
        }

        private void radioButton219_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton219.Checked == true)
            {
                textBox44.Text = "0";
            }
        }

        private void radioButton227_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton227.Checked == true)
            {
                textBox45.Text = "4";
            }
        }

        private void radioButton229_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton229.Checked == true)
            {
                textBox45.Text = "3";
            }
        }

        private void radioButton224_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton224.Checked == true)
            {
                textBox45.Text = "2";
            }
        }

        private void radioButton226_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton226.Checked == true)
            {
                textBox45.Text = "1";
            }
        }

        private void radioButton223_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton223.Checked == true)
            {
                textBox45.Text = "0";
            }
        }

        private void radioButton217_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton217.Checked == true)
            {
                textBox46.Text = "4";
            }
        }

        private void radioButton216_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton216.Checked == true)
            {
                textBox46.Text = "3";
            }
        }

        private void radioButton214_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton214.Checked == true)
            {
                textBox46.Text = "2";
            }
        }

        private void radioButton215_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton215.Checked == true)
            {
                textBox46.Text = "1";
            }
        }

        private void radioButton213_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton213.Checked == true)
            {
                textBox46.Text = "0";
            }
        }

        private void radioButton240_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton240.Checked == true)
            {
                textBox47.Text = "4";
            }
        }

        private void radioButton239_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton239.Checked == true)
            {
                textBox47.Text = "3";
            }
        }

        private void radioButton237_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton237.Checked == true)
            {
                textBox47.Text = "2";
            }
        }

        private void radioButton238_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton238.Checked == true)
            {
                textBox47.Text = "1";
            }
        }

        private void radioButton236_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton236.Checked == true)
            {
                textBox47.Text = "0";
            }
        }

        private void radioButton235_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton235.Checked == true)
            {
                textBox48.Text = "4";
            }
        }

        private void radioButton234_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton234.Checked == true)
            {
                textBox48.Text = "3";
            }
        }

        private void radioButton232_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton232.Checked == true)
            {
                textBox48.Text = "2";
            }
        }

        private void radioButton233_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton233.Checked == true)
            {
                textBox48.Text = "1";
            }
        }

        private void radioButton231_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton231.Checked == true)
            {
                textBox48.Text = "0";
            }
        }

        private void radioButton250_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton250.Checked == true)
            {
                textBox49.Text = "4";
            }
        }

        private void radioButton249_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton249.Checked == true)
            {
                textBox49.Text = "3";
            }
        }

        private void radioButton247_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton247.Checked == true)
            {
                textBox49.Text = "2";
            }
        }

        private void radioButton248_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton248.Checked == true)
            {
                textBox49.Text = "1";
            }
        }

        private void radioButton246_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton246.Checked == true)
            {
                textBox49.Text = "0";
            }
        }

        private void radioButton245_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton245.Checked == true)
            {
                textBox50.Text = "4";
            }
        }

        private void radioButton244_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton244.Checked == true)
            {
                textBox50.Text = "3";
            }
        }

        private void radioButton242_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton242.Checked == true)
            {
                textBox50.Text = "2";
            }
        }

        private void radioButton243_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton243.Checked == true)
            {
                textBox50.Text = "1";
            }
        }

        private void radioButton241_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton241.Checked == true)
            {
                textBox50.Text = "0";
            }
        }

        private void radioButton255_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton255.Checked == true)
            {
                textBox51.Text = "4";
            }
        }

        private void radioButton254_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton254.Checked == true)
            {
                textBox51.Text = "3";
            }
        }

        private void radioButton252_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton252.Checked == true)
            {
                textBox51.Text = "2";
            }
        }

        private void radioButton253_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton253.Checked == true)
            {
                textBox51.Text = "1";
            }
        }

        private void radioButton251_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton251.Checked == true)
            {
                textBox51.Text = "0";
            }
        }

        private void radioButton268_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton268.Checked == true)
            {
                textBox52.Text = "4";
            }
        }

        private void radioButton257_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton257.Checked == true)
            {
                textBox52.Text = "3";
            }
        }

        private void radioButton278_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton278.Checked == true)
            {
                textBox52.Text = "2";
            }
        }

        private void radioButton262_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton262.Checked == true)
            {
                textBox52.Text = "1";
            }
        }

        private void radioButton256_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton256.Checked == true)
            {
                textBox52.Text = "0";
            }
        }

        private void radioButton280_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton280.Checked == true)
            {
                textBox53.Text = "4";
            }
        }

        private void radioButton261_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton261.Checked == true)
            {
                textBox53.Text = "3";
            }
        }

        private void radioButton259_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton259.Checked == true)
            {
                textBox53.Text = "2";
            }
        }

        private void radioButton260_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton260.Checked == true)
            {
                textBox53.Text = "1";
            }
        }

        private void radioButton258_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton258.Checked == true)
            {
                textBox53.Text = "0";
            }
        }

        private void radioButton272_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton272.Checked == true)
            {
                textBox54.Text = "4";
            }
        }

        private void radioButton275_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton275.Checked == true)
            {
                textBox54.Text = "3";
            }
        }

        private void radioButton270_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton270.Checked == true)
            {
                textBox54.Text = "2";
            }
        }

        private void radioButton271_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton271.Checked == true)
            {
                textBox54.Text = "1";
            }
        }

        private void radioButton269_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton269.Checked == true)
            {
                textBox54.Text = "0";
            }
        }

        private void radioButton277_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton277.Checked == true)
            {
                textBox55.Text = "4";
            }
        }

        private void radioButton279_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton279.Checked == true)
            {
                textBox55.Text = "3";
            }
        }

        private void radioButton274_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton274.Checked == true)
            {
                textBox55.Text = "2";
            }
        }

        private void radioButton276_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton276.Checked == true)
            {
                textBox55.Text = "1";
            }
        }

        private void radioButton273_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton273.Checked == true)
            {
                textBox55.Text = "0";
            }
        }

        private void radioButton267_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton267.Checked == true)
            {
                textBox56.Text = "4";
            }
        }

        private void radioButton266_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton266.Checked == true)
            {
                textBox56.Text = "3";
            }
        }

        private void radioButton264_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton264.Checked == true)
            {
                textBox56.Text = "2";
            }
        }

        private void radioButton265_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton265.Checked == true)
            {
                textBox56.Text = "1";
            }
        }

        private void radioButton263_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton263.Checked == true)
            {
                textBox56.Text = "0";
            }
        }

        private void radioButton290_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton290.Checked == true)
            {
                textBox57.Text = "4";
            }
        }

        private void radioButton289_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton289.Checked == true)
            {
                textBox57.Text = "3";
            }
        }

        private void radioButton287_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton287.Checked == true)
            {
                textBox57.Text = "2";
            }
        }

        private void radioButton288_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton288.Checked == true)
            {
                textBox57.Text = "1";
            }
        }

        private void radioButton286_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton286.Checked == true)
            {
                textBox57.Text = "0";
            }
        }

        private void radioButton285_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton285.Checked == true)
            {
                textBox58.Text = "4";
            }
        }

        private void radioButton284_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton284.Checked == true)
            {
                textBox58.Text = "3";
            }
        }

        private void radioButton282_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton282.Checked == true)
            {
                textBox58.Text = "2";
            }
        }

        private void radioButton283_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton283.Checked == true)
            {
                textBox58.Text = "1";
            }
        }

        private void radioButton281_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton281.Checked == true)
            {
                textBox58.Text = "0";
            }
        }

        private void radioButton300_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton300.Checked == true)
            {
                textBox59.Text = "4";
            }
        }

        private void radioButton299_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton299.Checked == true)
            {
                textBox59.Text = "3";
            }
        }

        private void radioButton297_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton297.Checked == true)
            {
                textBox59.Text = "2";
            }
        }

        private void radioButton298_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton298.Checked == true)
            {
                textBox59.Text = "1";
            }
        }

        private void radioButton296_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton296.Checked == true)
            {
                textBox59.Text = "0";
            }
        }

        private void radioButton295_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton295.Checked == true)
            {
                textBox60.Text = "4";
            }
        }

        private void radioButton294_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton294.Checked == true)
            {
                textBox60.Text = "3";
            }
        }

        private void radioButton292_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton292.Checked == true)
            {
                textBox60.Text = "2";
            }
        }

        private void radioButton293_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton293.Checked == true)
            {
                textBox60.Text = "1";
            }
        }

        private void radioButton291_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton291.Checked == true)
            {
                textBox60.Text = "0";
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            FillData();
        }

        private void FillData()
        {

        //    SqlDataAdapter da = new SqlDataAdapter("select * FROM TB_Neo where Name='" + txtName.Text + "'");
        //DataSet ds=new DataSet();
        //da.Fill(ds);
        //GridView1.DataSource=ds;
        //GridView1.DataBind();
             var db = new DCNeoDataContext();

            var q = from a in db.GetTable<TB_Neo>()
                    where ((a.Name == txtName.Text))

                    select a;



            DGNEO.DataSource = q;
            this.chartNeo.DataSource = q;
            this.chart1.DataSource = q;
           // this.NEO.DataBind = db.GetTable<TB_Neo>();
            this.chartNeo.DataBind();
            this.chart1.DataBind();
            //string sql = "";
            //sql += "SELECT * FROM TABLE WHERE txtName.Text.ToString()";
           
            //TB_NeoBindingSource.Contains(sql);
            
            //TB_NeoTableAdapter.Fill(DBNEODataSet.TB_Neo);
            //SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=AdventureWorksDW2008R2; Integrated Security=True");
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_Neo WHERE  (SOH.SalesOrderNumber = @SalesOrderNumber)", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            ////ds.Tables[0].TableName = "TB_Neo";
            this.tBNeoBindingSource.DataSource = q;
            //this.TB_NeoBindingSource.DataSource = ds;
           this.reportViewer1.RefreshReport();
            //Form1 frm1 = new Form1();
            //reportViewer1.DataBindings = q;
            //frm1.Show();
            
            //DGNEO.AutoResizeColumns();
            //var db = new DBNEODataSet();
            //NEO.DataSource = db.TB_Neo.Where(c => c.Name.).Select(c => c);
            //this.NEO.DataBind();

                //var q = from a in db.GetTable<TB_Neo>()
                //        where ((a.LastName == string(txtLastName.Text)))
                //        select a;
                //dgViewCertainDocument.DataSource = q;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNeoDataSet.TB_Neo' table. You can move, or remove it, as needed.
            this.tB_NeoTableAdapter.Fill(this.dbNeoDataSet.TB_Neo);
            // TODO: This line of code loads data into the 'DBNEODataSet.TB_Neo' table. You can move, or remove it, as needed.
            this.tB_NeoTableAdapter.Fill(this.dbNeoDataSet.TB_Neo);
            // TODO: This line of code loads data into the 'dBNEODataSet.TB_Neo' table. You can move, or remove it, as needed.
          //  this.tB_NeoTableAdapter.Fill(this.dBNEODataSet.TB_Neo);
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            DateTime dat = DateTime.Now;

            txtDate.Text = (pc.GetYear(dat) + "/" + pc.GetMonth(dat) + "/" + pc.GetDayOfMonth(dat));

            this.reportViewer1.RefreshReport();
            var db = new DCNeoDataContext();

            DGNEO.DataSource = db.TB_Neos;
            this.reportViewer2.RefreshReport();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ee = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox8.Text);
            int i = int.Parse(textBox9.Text);
            int j = int.Parse(textBox10.Text);
            int k = int.Parse(textBox11.Text);
            int l = int.Parse(textBox12.Text);
            int N = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtN.Text = N.ToString();
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox13.Text);
            int b = int.Parse(textBox14.Text);
            int c = int.Parse(textBox15.Text);
            int d = int.Parse(textBox16.Text);
            int ee = int.Parse(textBox17.Text);
            int f = int.Parse(textBox18.Text);
            int g = int.Parse(textBox19.Text);
            int h = int.Parse(textBox20.Text);
            int i = int.Parse(textBox21.Text);
            int j = int.Parse(textBox22.Text);
            int k = int.Parse(textBox23.Text);
            int l = int.Parse(textBox24.Text);
            int O = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtE.Text = O.ToString();
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox25.Text);
            int b = int.Parse(textBox26.Text);
            int c = int.Parse(textBox27.Text);
            int d = int.Parse(textBox28.Text);
            int ee = int.Parse(textBox29.Text);
            int f = int.Parse(textBox30.Text);
            int g = int.Parse(textBox31.Text);
            int h = int.Parse(textBox32.Text);
            int i = int.Parse(textBox33.Text);
            int j = int.Parse(textBox34.Text);
            int k = int.Parse(textBox35.Text);
            int l = int.Parse(textBox36.Text);
            int E = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtO.Text = E.ToString();
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox49.Text);
            int b = int.Parse(textBox50.Text);
            int c = int.Parse(textBox51.Text);
            int d = int.Parse(textBox52.Text);
            int ee = int.Parse(textBox53.Text);
            int f = int.Parse(textBox54.Text);
            int g = int.Parse(textBox55.Text);
            int h = int.Parse(textBox56.Text);
            int i = int.Parse(textBox57.Text);
            int j = int.Parse(textBox58.Text);
            int k = int.Parse(textBox59.Text);
            int l = int.Parse(textBox60.Text);
            int C = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtC.Text = C.ToString();
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox37.Text);
            int b = int.Parse(textBox38.Text);
            int c = int.Parse(textBox39.Text);
            int d = int.Parse(textBox40.Text);
            int ee = int.Parse(textBox41.Text);
            int f = int.Parse(textBox42.Text);
            int g = int.Parse(textBox43.Text);
            int h = int.Parse(textBox44.Text);
            int i = int.Parse(textBox45.Text);
            int j = int.Parse(textBox46.Text);
            int k = int.Parse(textBox47.Text);
            int l = int.Parse(textBox48.Text);
            int A = aa + b + c + d + ee + f + g + h + i + j + k + l;
            txtA.Text = A.ToString();
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);
           
            int A = aa + b + c + d + ee + f + g + h ;
            txtPA.Text = A.ToString();
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox40.Text);
            int bbb = int.Parse(comboBox39.Text);
            if (aaa + bbb != 5)
            {
                comboBox40.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tBNeoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNeoDataSet = new WANeo.DbNeoDataSet();
            this.TB_NeoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNameF = new System.Windows.Forms.TextBox();
            this.txtNumberSh = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.groupBox61 = new System.Windows.Forms.GroupBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label212 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.label213 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label130 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.txtAdressMK = new System.Windows.Forms.TextBox();
            this.txtAdressM = new System.Windows.Forms.TextBox();
            this.txtMeli = new System.Windows.Forms.TextBox();
            this.txtPhoneH = new System.Windows.Forms.TextBox();
            this.txtPhoneM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chartNeo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox62 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.groupBox63 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.groupBox64 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.groupBox65 = new System.Windows.Forms.GroupBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.groupBox66 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox73 = new System.Windows.Forms.GroupBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.label175 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.groupBox72 = new System.Windows.Forms.GroupBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.groupBox79 = new System.Windows.Forms.GroupBox();
            this.comboBox36 = new System.Windows.Forms.ComboBox();
            this.comboBox35 = new System.Windows.Forms.ComboBox();
            this.label200 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtPD = new System.Windows.Forms.TextBox();
            this.txtPJ = new System.Windows.Forms.TextBox();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.groupBox80 = new System.Windows.Forms.GroupBox();
            this.comboBox37 = new System.Windows.Forms.ComboBox();
            this.comboBox38 = new System.Windows.Forms.ComboBox();
            this.label203 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.groupBox81 = new System.Windows.Forms.GroupBox();
            this.comboBox39 = new System.Windows.Forms.ComboBox();
            this.comboBox40 = new System.Windows.Forms.ComboBox();
            this.label207 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.DGNEO = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peyvastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultNeoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.njDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ehDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ohDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNeoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberShDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loEshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pehDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pghDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pujDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoghlNextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox51 = new System.Windows.Forms.GroupBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.radioButton251 = new System.Windows.Forms.RadioButton();
            this.radioButton252 = new System.Windows.Forms.RadioButton();
            this.radioButton253 = new System.Windows.Forms.RadioButton();
            this.radioButton254 = new System.Windows.Forms.RadioButton();
            this.radioButton255 = new System.Windows.Forms.RadioButton();
            this.groupBox52 = new System.Windows.Forms.GroupBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.radioButton263 = new System.Windows.Forms.RadioButton();
            this.radioButton264 = new System.Windows.Forms.RadioButton();
            this.radioButton265 = new System.Windows.Forms.RadioButton();
            this.radioButton266 = new System.Windows.Forms.RadioButton();
            this.radioButton267 = new System.Windows.Forms.RadioButton();
            this.groupBox53 = new System.Windows.Forms.GroupBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.radioButton269 = new System.Windows.Forms.RadioButton();
            this.radioButton270 = new System.Windows.Forms.RadioButton();
            this.radioButton271 = new System.Windows.Forms.RadioButton();
            this.radioButton275 = new System.Windows.Forms.RadioButton();
            this.radioButton272 = new System.Windows.Forms.RadioButton();
            this.groupBox54 = new System.Windows.Forms.GroupBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.radioButton273 = new System.Windows.Forms.RadioButton();
            this.radioButton274 = new System.Windows.Forms.RadioButton();
            this.radioButton276 = new System.Windows.Forms.RadioButton();
            this.radioButton279 = new System.Windows.Forms.RadioButton();
            this.radioButton277 = new System.Windows.Forms.RadioButton();
            this.groupBox55 = new System.Windows.Forms.GroupBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.radioButton286 = new System.Windows.Forms.RadioButton();
            this.radioButton287 = new System.Windows.Forms.RadioButton();
            this.radioButton288 = new System.Windows.Forms.RadioButton();
            this.radioButton289 = new System.Windows.Forms.RadioButton();
            this.radioButton290 = new System.Windows.Forms.RadioButton();
            this.groupBox56 = new System.Windows.Forms.GroupBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.radioButton281 = new System.Windows.Forms.RadioButton();
            this.radioButton282 = new System.Windows.Forms.RadioButton();
            this.radioButton283 = new System.Windows.Forms.RadioButton();
            this.radioButton284 = new System.Windows.Forms.RadioButton();
            this.radioButton285 = new System.Windows.Forms.RadioButton();
            this.groupBox57 = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.radioButton291 = new System.Windows.Forms.RadioButton();
            this.radioButton292 = new System.Windows.Forms.RadioButton();
            this.radioButton293 = new System.Windows.Forms.RadioButton();
            this.radioButton294 = new System.Windows.Forms.RadioButton();
            this.radioButton295 = new System.Windows.Forms.RadioButton();
            this.groupBox58 = new System.Windows.Forms.GroupBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.radioButton256 = new System.Windows.Forms.RadioButton();
            this.radioButton278 = new System.Windows.Forms.RadioButton();
            this.radioButton262 = new System.Windows.Forms.RadioButton();
            this.radioButton257 = new System.Windows.Forms.RadioButton();
            this.radioButton268 = new System.Windows.Forms.RadioButton();
            this.groupBox59 = new System.Windows.Forms.GroupBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.radioButton258 = new System.Windows.Forms.RadioButton();
            this.radioButton259 = new System.Windows.Forms.RadioButton();
            this.radioButton260 = new System.Windows.Forms.RadioButton();
            this.radioButton261 = new System.Windows.Forms.RadioButton();
            this.radioButton280 = new System.Windows.Forms.RadioButton();
            this.groupBox60 = new System.Windows.Forms.GroupBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.radioButton296 = new System.Windows.Forms.RadioButton();
            this.radioButton297 = new System.Windows.Forms.RadioButton();
            this.radioButton298 = new System.Windows.Forms.RadioButton();
            this.radioButton299 = new System.Windows.Forms.RadioButton();
            this.radioButton300 = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.radioButton201 = new System.Windows.Forms.RadioButton();
            this.radioButton202 = new System.Windows.Forms.RadioButton();
            this.radioButton203 = new System.Windows.Forms.RadioButton();
            this.radioButton204 = new System.Windows.Forms.RadioButton();
            this.radioButton205 = new System.Windows.Forms.RadioButton();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.radioButton213 = new System.Windows.Forms.RadioButton();
            this.radioButton214 = new System.Windows.Forms.RadioButton();
            this.radioButton215 = new System.Windows.Forms.RadioButton();
            this.radioButton216 = new System.Windows.Forms.RadioButton();
            this.radioButton217 = new System.Windows.Forms.RadioButton();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.radioButton219 = new System.Windows.Forms.RadioButton();
            this.radioButton220 = new System.Windows.Forms.RadioButton();
            this.radioButton221 = new System.Windows.Forms.RadioButton();
            this.radioButton225 = new System.Windows.Forms.RadioButton();
            this.radioButton222 = new System.Windows.Forms.RadioButton();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.radioButton223 = new System.Windows.Forms.RadioButton();
            this.radioButton224 = new System.Windows.Forms.RadioButton();
            this.radioButton226 = new System.Windows.Forms.RadioButton();
            this.radioButton229 = new System.Windows.Forms.RadioButton();
            this.radioButton227 = new System.Windows.Forms.RadioButton();
            this.groupBox45 = new System.Windows.Forms.GroupBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.radioButton236 = new System.Windows.Forms.RadioButton();
            this.radioButton237 = new System.Windows.Forms.RadioButton();
            this.radioButton238 = new System.Windows.Forms.RadioButton();
            this.radioButton239 = new System.Windows.Forms.RadioButton();
            this.radioButton240 = new System.Windows.Forms.RadioButton();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.radioButton231 = new System.Windows.Forms.RadioButton();
            this.radioButton232 = new System.Windows.Forms.RadioButton();
            this.radioButton233 = new System.Windows.Forms.RadioButton();
            this.radioButton234 = new System.Windows.Forms.RadioButton();
            this.radioButton235 = new System.Windows.Forms.RadioButton();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.radioButton241 = new System.Windows.Forms.RadioButton();
            this.radioButton242 = new System.Windows.Forms.RadioButton();
            this.radioButton243 = new System.Windows.Forms.RadioButton();
            this.radioButton244 = new System.Windows.Forms.RadioButton();
            this.radioButton245 = new System.Windows.Forms.RadioButton();
            this.groupBox48 = new System.Windows.Forms.GroupBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.radioButton206 = new System.Windows.Forms.RadioButton();
            this.radioButton228 = new System.Windows.Forms.RadioButton();
            this.radioButton212 = new System.Windows.Forms.RadioButton();
            this.radioButton207 = new System.Windows.Forms.RadioButton();
            this.radioButton218 = new System.Windows.Forms.RadioButton();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.radioButton208 = new System.Windows.Forms.RadioButton();
            this.radioButton209 = new System.Windows.Forms.RadioButton();
            this.radioButton210 = new System.Windows.Forms.RadioButton();
            this.radioButton211 = new System.Windows.Forms.RadioButton();
            this.radioButton230 = new System.Windows.Forms.RadioButton();
            this.groupBox50 = new System.Windows.Forms.GroupBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.radioButton246 = new System.Windows.Forms.RadioButton();
            this.radioButton247 = new System.Windows.Forms.RadioButton();
            this.radioButton248 = new System.Windows.Forms.RadioButton();
            this.radioButton249 = new System.Windows.Forms.RadioButton();
            this.radioButton250 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.radioButton151 = new System.Windows.Forms.RadioButton();
            this.radioButton152 = new System.Windows.Forms.RadioButton();
            this.radioButton153 = new System.Windows.Forms.RadioButton();
            this.radioButton154 = new System.Windows.Forms.RadioButton();
            this.radioButton155 = new System.Windows.Forms.RadioButton();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.radioButton163 = new System.Windows.Forms.RadioButton();
            this.radioButton164 = new System.Windows.Forms.RadioButton();
            this.radioButton165 = new System.Windows.Forms.RadioButton();
            this.radioButton166 = new System.Windows.Forms.RadioButton();
            this.radioButton167 = new System.Windows.Forms.RadioButton();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.radioButton169 = new System.Windows.Forms.RadioButton();
            this.radioButton170 = new System.Windows.Forms.RadioButton();
            this.radioButton171 = new System.Windows.Forms.RadioButton();
            this.radioButton175 = new System.Windows.Forms.RadioButton();
            this.radioButton172 = new System.Windows.Forms.RadioButton();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.radioButton173 = new System.Windows.Forms.RadioButton();
            this.radioButton174 = new System.Windows.Forms.RadioButton();
            this.radioButton176 = new System.Windows.Forms.RadioButton();
            this.radioButton179 = new System.Windows.Forms.RadioButton();
            this.radioButton177 = new System.Windows.Forms.RadioButton();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.radioButton186 = new System.Windows.Forms.RadioButton();
            this.radioButton187 = new System.Windows.Forms.RadioButton();
            this.radioButton188 = new System.Windows.Forms.RadioButton();
            this.radioButton189 = new System.Windows.Forms.RadioButton();
            this.radioButton190 = new System.Windows.Forms.RadioButton();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.radioButton181 = new System.Windows.Forms.RadioButton();
            this.radioButton182 = new System.Windows.Forms.RadioButton();
            this.radioButton183 = new System.Windows.Forms.RadioButton();
            this.radioButton184 = new System.Windows.Forms.RadioButton();
            this.radioButton185 = new System.Windows.Forms.RadioButton();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.radioButton191 = new System.Windows.Forms.RadioButton();
            this.radioButton192 = new System.Windows.Forms.RadioButton();
            this.radioButton193 = new System.Windows.Forms.RadioButton();
            this.radioButton194 = new System.Windows.Forms.RadioButton();
            this.radioButton195 = new System.Windows.Forms.RadioButton();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.radioButton156 = new System.Windows.Forms.RadioButton();
            this.radioButton178 = new System.Windows.Forms.RadioButton();
            this.radioButton162 = new System.Windows.Forms.RadioButton();
            this.radioButton157 = new System.Windows.Forms.RadioButton();
            this.radioButton168 = new System.Windows.Forms.RadioButton();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.radioButton158 = new System.Windows.Forms.RadioButton();
            this.radioButton159 = new System.Windows.Forms.RadioButton();
            this.radioButton160 = new System.Windows.Forms.RadioButton();
            this.radioButton161 = new System.Windows.Forms.RadioButton();
            this.radioButton180 = new System.Windows.Forms.RadioButton();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.radioButton196 = new System.Windows.Forms.RadioButton();
            this.radioButton197 = new System.Windows.Forms.RadioButton();
            this.radioButton198 = new System.Windows.Forms.RadioButton();
            this.radioButton199 = new System.Windows.Forms.RadioButton();
            this.radioButton200 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.radioButton101 = new System.Windows.Forms.RadioButton();
            this.radioButton103 = new System.Windows.Forms.RadioButton();
            this.radioButton102 = new System.Windows.Forms.RadioButton();
            this.radioButton104 = new System.Windows.Forms.RadioButton();
            this.radioButton105 = new System.Windows.Forms.RadioButton();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.radioButton115 = new System.Windows.Forms.RadioButton();
            this.radioButton116 = new System.Windows.Forms.RadioButton();
            this.radioButton117 = new System.Windows.Forms.RadioButton();
            this.radioButton118 = new System.Windows.Forms.RadioButton();
            this.radioButton119 = new System.Windows.Forms.RadioButton();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.radioButton120 = new System.Windows.Forms.RadioButton();
            this.radioButton121 = new System.Windows.Forms.RadioButton();
            this.radioButton122 = new System.Windows.Forms.RadioButton();
            this.radioButton123 = new System.Windows.Forms.RadioButton();
            this.radioButton124 = new System.Windows.Forms.RadioButton();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.radioButton125 = new System.Windows.Forms.RadioButton();
            this.radioButton126 = new System.Windows.Forms.RadioButton();
            this.radioButton127 = new System.Windows.Forms.RadioButton();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.radioButton129 = new System.Windows.Forms.RadioButton();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.radioButton106 = new System.Windows.Forms.RadioButton();
            this.radioButton107 = new System.Windows.Forms.RadioButton();
            this.radioButton108 = new System.Windows.Forms.RadioButton();
            this.radioButton109 = new System.Windows.Forms.RadioButton();
            this.radioButton110 = new System.Windows.Forms.RadioButton();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.radioButton130 = new System.Windows.Forms.RadioButton();
            this.radioButton131 = new System.Windows.Forms.RadioButton();
            this.radioButton132 = new System.Windows.Forms.RadioButton();
            this.radioButton133 = new System.Windows.Forms.RadioButton();
            this.radioButton134 = new System.Windows.Forms.RadioButton();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.radioButton136 = new System.Windows.Forms.RadioButton();
            this.radioButton137 = new System.Windows.Forms.RadioButton();
            this.radioButton138 = new System.Windows.Forms.RadioButton();
            this.radioButton139 = new System.Windows.Forms.RadioButton();
            this.radioButton140 = new System.Windows.Forms.RadioButton();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.radioButton111 = new System.Windows.Forms.RadioButton();
            this.radioButton112 = new System.Windows.Forms.RadioButton();
            this.radioButton113 = new System.Windows.Forms.RadioButton();
            this.radioButton114 = new System.Windows.Forms.RadioButton();
            this.radioButton135 = new System.Windows.Forms.RadioButton();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.radioButton141 = new System.Windows.Forms.RadioButton();
            this.radioButton142 = new System.Windows.Forms.RadioButton();
            this.radioButton143 = new System.Windows.Forms.RadioButton();
            this.radioButton144 = new System.Windows.Forms.RadioButton();
            this.radioButton145 = new System.Windows.Forms.RadioButton();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.radioButton146 = new System.Windows.Forms.RadioButton();
            this.radioButton147 = new System.Windows.Forms.RadioButton();
            this.radioButton148 = new System.Windows.Forms.RadioButton();
            this.radioButton149 = new System.Windows.Forms.RadioButton();
            this.radioButton150 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.radioButton51 = new System.Windows.Forms.RadioButton();
            this.radioButton52 = new System.Windows.Forms.RadioButton();
            this.radioButton53 = new System.Windows.Forms.RadioButton();
            this.radioButton54 = new System.Windows.Forms.RadioButton();
            this.radioButton55 = new System.Windows.Forms.RadioButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.radioButton56 = new System.Windows.Forms.RadioButton();
            this.radioButton57 = new System.Windows.Forms.RadioButton();
            this.radioButton58 = new System.Windows.Forms.RadioButton();
            this.radioButton59 = new System.Windows.Forms.RadioButton();
            this.radioButton60 = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.radioButton61 = new System.Windows.Forms.RadioButton();
            this.radioButton62 = new System.Windows.Forms.RadioButton();
            this.radioButton63 = new System.Windows.Forms.RadioButton();
            this.radioButton64 = new System.Windows.Forms.RadioButton();
            this.radioButton65 = new System.Windows.Forms.RadioButton();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.radioButton66 = new System.Windows.Forms.RadioButton();
            this.radioButton67 = new System.Windows.Forms.RadioButton();
            this.radioButton68 = new System.Windows.Forms.RadioButton();
            this.radioButton69 = new System.Windows.Forms.RadioButton();
            this.radioButton70 = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.radioButton71 = new System.Windows.Forms.RadioButton();
            this.radioButton72 = new System.Windows.Forms.RadioButton();
            this.radioButton73 = new System.Windows.Forms.RadioButton();
            this.radioButton74 = new System.Windows.Forms.RadioButton();
            this.radioButton75 = new System.Windows.Forms.RadioButton();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.radioButton76 = new System.Windows.Forms.RadioButton();
            this.radioButton77 = new System.Windows.Forms.RadioButton();
            this.radioButton78 = new System.Windows.Forms.RadioButton();
            this.radioButton79 = new System.Windows.Forms.RadioButton();
            this.radioButton80 = new System.Windows.Forms.RadioButton();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.radioButton81 = new System.Windows.Forms.RadioButton();
            this.radioButton82 = new System.Windows.Forms.RadioButton();
            this.radioButton83 = new System.Windows.Forms.RadioButton();
            this.radioButton84 = new System.Windows.Forms.RadioButton();
            this.radioButton85 = new System.Windows.Forms.RadioButton();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.radioButton86 = new System.Windows.Forms.RadioButton();
            this.radioButton87 = new System.Windows.Forms.RadioButton();
            this.radioButton88 = new System.Windows.Forms.RadioButton();
            this.radioButton89 = new System.Windows.Forms.RadioButton();
            this.radioButton90 = new System.Windows.Forms.RadioButton();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.radioButton91 = new System.Windows.Forms.RadioButton();
            this.radioButton92 = new System.Windows.Forms.RadioButton();
            this.radioButton93 = new System.Windows.Forms.RadioButton();
            this.radioButton94 = new System.Windows.Forms.RadioButton();
            this.radioButton95 = new System.Windows.Forms.RadioButton();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.radioButton96 = new System.Windows.Forms.RadioButton();
            this.radioButton97 = new System.Windows.Forms.RadioButton();
            this.radioButton98 = new System.Windows.Forms.RadioButton();
            this.radioButton99 = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton46 = new System.Windows.Forms.RadioButton();
            this.radioButton47 = new System.Windows.Forms.RadioButton();
            this.radioButton48 = new System.Windows.Forms.RadioButton();
            this.radioButton49 = new System.Windows.Forms.RadioButton();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButton41 = new System.Windows.Forms.RadioButton();
            this.radioButton42 = new System.Windows.Forms.RadioButton();
            this.radioButton43 = new System.Windows.Forms.RadioButton();
            this.radioButton44 = new System.Windows.Forms.RadioButton();
            this.radioButton45 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButton36 = new System.Windows.Forms.RadioButton();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.radioButton38 = new System.Windows.Forms.RadioButton();
            this.radioButton39 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.groupBox74 = new System.Windows.Forms.GroupBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.label179 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.groupBox75 = new System.Windows.Forms.GroupBox();
            this.comboBox27 = new System.Windows.Forms.ComboBox();
            this.comboBox28 = new System.Windows.Forms.ComboBox();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.groupBox76 = new System.Windows.Forms.GroupBox();
            this.comboBox29 = new System.Windows.Forms.ComboBox();
            this.comboBox30 = new System.Windows.Forms.ComboBox();
            this.label187 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.groupBox77 = new System.Windows.Forms.GroupBox();
            this.comboBox31 = new System.Windows.Forms.ComboBox();
            this.comboBox32 = new System.Windows.Forms.ComboBox();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.groupBox78 = new System.Windows.Forms.GroupBox();
            this.comboBox33 = new System.Windows.Forms.ComboBox();
            this.comboBox34 = new System.Windows.Forms.ComboBox();
            this.label195 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.groupBox83 = new System.Windows.Forms.GroupBox();
            this.comboBox41 = new System.Windows.Forms.ComboBox();
            this.comboBox42 = new System.Windows.Forms.ComboBox();
            this.label216 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.groupBox84 = new System.Windows.Forms.GroupBox();
            this.comboBox43 = new System.Windows.Forms.ComboBox();
            this.comboBox44 = new System.Windows.Forms.ComboBox();
            this.label220 = new System.Windows.Forms.Label();
            this.label221 = new System.Windows.Forms.Label();
            this.label222 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.groupBox85 = new System.Windows.Forms.GroupBox();
            this.comboBox45 = new System.Windows.Forms.ComboBox();
            this.comboBox46 = new System.Windows.Forms.ComboBox();
            this.label224 = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.groupBox86 = new System.Windows.Forms.GroupBox();
            this.comboBox47 = new System.Windows.Forms.ComboBox();
            this.comboBox48 = new System.Windows.Forms.ComboBox();
            this.label228 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label231 = new System.Windows.Forms.Label();
            this.groupBox87 = new System.Windows.Forms.GroupBox();
            this.comboBox49 = new System.Windows.Forms.ComboBox();
            this.comboBox50 = new System.Windows.Forms.ComboBox();
            this.label232 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.groupBox82 = new System.Windows.Forms.GroupBox();
            this.radioButton302 = new System.Windows.Forms.RadioButton();
            this.radioButton301 = new System.Windows.Forms.RadioButton();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tB_NeoTableAdapter = new WANeo.DbNeoDataSetTableAdapters.TB_NeoTableAdapter();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBNeoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNeoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_NeoBindingSource)).BeginInit();
            this.groupBox61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.groupBox62.SuspendLayout();
            this.groupBox63.SuspendLayout();
            this.groupBox64.SuspendLayout();
            this.groupBox65.SuspendLayout();
            this.groupBox66.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox73.SuspendLayout();
            this.groupBox72.SuspendLayout();
            this.groupBox79.SuspendLayout();
            this.groupBox80.SuspendLayout();
            this.groupBox81.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGNEO)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox51.SuspendLayout();
            this.groupBox52.SuspendLayout();
            this.groupBox53.SuspendLayout();
            this.groupBox54.SuspendLayout();
            this.groupBox55.SuspendLayout();
            this.groupBox56.SuspendLayout();
            this.groupBox57.SuspendLayout();
            this.groupBox58.SuspendLayout();
            this.groupBox59.SuspendLayout();
            this.groupBox60.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox41.SuspendLayout();
            this.groupBox42.SuspendLayout();
            this.groupBox43.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox45.SuspendLayout();
            this.groupBox46.SuspendLayout();
            this.groupBox47.SuspendLayout();
            this.groupBox48.SuspendLayout();
            this.groupBox49.SuspendLayout();
            this.groupBox50.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.groupBox74.SuspendLayout();
            this.groupBox75.SuspendLayout();
            this.groupBox76.SuspendLayout();
            this.groupBox77.SuspendLayout();
            this.groupBox78.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.groupBox83.SuspendLayout();
            this.groupBox84.SuspendLayout();
            this.groupBox85.SuspendLayout();
            this.groupBox86.SuspendLayout();
            this.groupBox87.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox82.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBNeoBindingSource
            // 
            this.tBNeoBindingSource.DataMember = "TB_Neo";
            this.tBNeoBindingSource.DataSource = this.dbNeoDataSet;
            // 
            // dbNeoDataSet
            // 
            this.dbNeoDataSet.DataSetName = "DbNeoDataSet";
            this.dbNeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TB_NeoBindingSource
            // 
            this.TB_NeoBindingSource.DataMember = "TB_Neo";
            this.TB_NeoBindingSource.DataSource = this.dbNeoDataSet;
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtNameF
            // 
            resources.ApplyResources(this.txtNameF, "txtNameF");
            this.txtNameF.Name = "txtNameF";
            this.txtNameF.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtNumberSh
            // 
            resources.ApplyResources(this.txtNumberSh, "txtNumberSh");
            this.txtNumberSh.Name = "txtNumberSh";
            this.txtNumberSh.TextChanged += new System.EventHandler(this.txtNumberSh_TextChanged);
            // 
            // label121
            // 
            resources.ApplyResources(this.label121, "label121");
            this.label121.Name = "label121";
            // 
            // groupBox61
            // 
            this.groupBox61.Controls.Add(this.textBox66);
            this.groupBox61.Controls.Add(this.textBox65);
            this.groupBox61.Controls.Add(this.label212);
            this.groupBox61.Controls.Add(this.label211);
            this.groupBox61.Controls.Add(this.textBox61);
            this.groupBox61.Controls.Add(this.textBox62);
            this.groupBox61.Controls.Add(this.txtName);
            this.groupBox61.Controls.Add(this.label213);
            this.groupBox61.Controls.Add(this.label214);
            this.groupBox61.Controls.Add(this.label215);
            this.groupBox61.Controls.Add(this.label129);
            this.groupBox61.Controls.Add(this.label128);
            this.groupBox61.Controls.Add(this.label127);
            this.groupBox61.Controls.Add(this.label126);
            this.groupBox61.Controls.Add(this.txtDate);
            this.groupBox61.Controls.Add(this.label130);
            this.groupBox61.Controls.Add(this.label125);
            this.groupBox61.Controls.Add(this.label124);
            this.groupBox61.Controls.Add(this.label123);
            this.groupBox61.Controls.Add(this.label122);
            this.groupBox61.Controls.Add(this.label121);
            this.groupBox61.Controls.Add(this.txtNameF);
            this.groupBox61.Controls.Add(this.textBox70);
            this.groupBox61.Controls.Add(this.txtAdressMK);
            this.groupBox61.Controls.Add(this.txtAdressM);
            this.groupBox61.Controls.Add(this.txtMeli);
            this.groupBox61.Controls.Add(this.txtPhoneH);
            this.groupBox61.Controls.Add(this.txtPhoneM);
            this.groupBox61.Controls.Add(this.txtNumberSh);
            resources.ApplyResources(this.groupBox61, "groupBox61");
            this.groupBox61.Name = "groupBox61";
            this.groupBox61.TabStop = false;
            // 
            // textBox66
            // 
            resources.ApplyResources(this.textBox66, "textBox66");
            this.textBox66.Name = "textBox66";
            // 
            // textBox65
            // 
            resources.ApplyResources(this.textBox65, "textBox65");
            this.textBox65.Name = "textBox65";
            // 
            // label212
            // 
            resources.ApplyResources(this.label212, "label212");
            this.label212.Name = "label212";
            // 
            // label211
            // 
            resources.ApplyResources(this.label211, "label211");
            this.label211.Name = "label211";
            // 
            // textBox61
            // 
            resources.ApplyResources(this.textBox61, "textBox61");
            this.textBox61.Name = "textBox61";
            // 
            // textBox62
            // 
            resources.ApplyResources(this.textBox62, "textBox62");
            this.textBox62.Name = "textBox62";
            // 
            // label213
            // 
            resources.ApplyResources(this.label213, "label213");
            this.label213.Name = "label213";
            // 
            // label214
            // 
            resources.ApplyResources(this.label214, "label214");
            this.label214.Name = "label214";
            // 
            // label215
            // 
            resources.ApplyResources(this.label215, "label215");
            this.label215.Name = "label215";
            // 
            // label129
            // 
            resources.ApplyResources(this.label129, "label129");
            this.label129.Name = "label129";
            // 
            // label128
            // 
            resources.ApplyResources(this.label128, "label128");
            this.label128.Name = "label128";
            // 
            // label127
            // 
            resources.ApplyResources(this.label127, "label127");
            this.label127.Name = "label127";
            // 
            // label126
            // 
            resources.ApplyResources(this.label126, "label126");
            this.label126.Name = "label126";
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Name = "txtDate";
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label130
            // 
            resources.ApplyResources(this.label130, "label130");
            this.label130.Name = "label130";
            // 
            // label125
            // 
            resources.ApplyResources(this.label125, "label125");
            this.label125.Name = "label125";
            // 
            // label124
            // 
            resources.ApplyResources(this.label124, "label124");
            this.label124.Name = "label124";
            // 
            // label123
            // 
            resources.ApplyResources(this.label123, "label123");
            this.label123.Name = "label123";
            // 
            // label122
            // 
            resources.ApplyResources(this.label122, "label122");
            this.label122.Name = "label122";
            // 
            // textBox70
            // 
            resources.ApplyResources(this.textBox70, "textBox70");
            this.textBox70.Name = "textBox70";
            // 
            // txtAdressMK
            // 
            resources.ApplyResources(this.txtAdressMK, "txtAdressMK");
            this.txtAdressMK.Name = "txtAdressMK";
            // 
            // txtAdressM
            // 
            resources.ApplyResources(this.txtAdressM, "txtAdressM");
            this.txtAdressM.Name = "txtAdressM";
            // 
            // txtMeli
            // 
            resources.ApplyResources(this.txtMeli, "txtMeli");
            this.txtMeli.Name = "txtMeli";
            // 
            // txtPhoneH
            // 
            resources.ApplyResources(this.txtPhoneH, "txtPhoneH");
            this.txtPhoneH.Name = "txtPhoneH";
            // 
            // txtPhoneM
            // 
            resources.ApplyResources(this.txtPhoneM, "txtPhoneM");
            this.txtPhoneM.Name = "txtPhoneM";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartNeo
            // 
            this.chartNeo.AllowDrop = true;
            this.chartNeo.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.Name = "ChartArea1";
            this.chartNeo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNeo.Legends.Add(legend1);
            resources.ApplyResources(this.chartNeo, "chartNeo");
            this.chartNeo.Name = "chartNeo";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Label = "ثبات شخصیت بالا ثبات کم پایین ثبات بیشتر";
            series1.Legend = "Legend1";
            series1.Name = "N";
            series1.XValueMember = "Name";
            series1.YValueMembers = "N";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Label = "E";
            series2.Legend = "Legend1";
            series2.Name = "E";
            series2.YValueMembers = "E";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Label = "O";
            series3.Legend = "Legend1";
            series3.Name = "O";
            series3.YValueMembers = "O";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.Label = "A";
            series4.Legend = "Legend1";
            series4.Name = "A";
            series4.YValueMembers = "A";
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.IsXValueIndexed = true;
            series5.Label = "C";
            series5.Legend = "Legend1";
            series5.Name = "C";
            series5.YValueMembers = "C";
            this.chartNeo.Series.Add(series1);
            this.chartNeo.Series.Add(series2);
            this.chartNeo.Series.Add(series3);
            this.chartNeo.Series.Add(series4);
            this.chartNeo.Series.Add(series5);
            title1.Name = "NEO";
            this.chartNeo.Titles.Add(title1);
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MaximumAutoSize = 100F;
            chartArea2.AxisY.MaximumAutoSize = 100F;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.IsXValueIndexed = true;
            series6.Label = "الف";
            series6.Legend = "Legend1";
            series6.Name = "الف";
            series6.XValueMember = "Name";
            series6.YValueMembers = "PA";
            series7.ChartArea = "ChartArea1";
            series7.IsValueShownAsLabel = true;
            series7.IsXValueIndexed = true;
            series7.Label = "ب";
            series7.Legend = "Legend1";
            series7.Name = "ب";
            series7.YValueMembers = "PB";
            series8.ChartArea = "ChartArea1";
            series8.IsValueShownAsLabel = true;
            series8.IsXValueIndexed = true;
            series8.Label = "ج";
            series8.Legend = "Legend1";
            series8.Name = "ج";
            series8.YValueMembers = "PJ";
            series9.ChartArea = "ChartArea1";
            series9.IsValueShownAsLabel = true;
            series9.IsXValueIndexed = true;
            series9.Label = "د";
            series9.Legend = "Legend1";
            series9.Name = "د";
            series9.YValueMembers = "PD";
            series10.ChartArea = "ChartArea1";
            series10.IsValueShownAsLabel = true;
            series10.IsXValueIndexed = true;
            series10.Label = "ه";
            series10.Legend = "Legend1";
            series10.Name = "ه";
            series10.YValueMembers = "PH";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            title2.Name = "NEO";
            this.chart1.Titles.Add(title2);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox62);
            this.tabPage8.Controls.Add(this.groupBox63);
            this.tabPage8.Controls.Add(this.groupBox64);
            this.tabPage8.Controls.Add(this.groupBox65);
            this.tabPage8.Controls.Add(this.groupBox66);
            this.tabPage8.Controls.Add(this.btnSave);
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox62
            // 
            this.groupBox62.Controls.Add(this.comboBox1);
            this.groupBox62.Controls.Add(this.comboBox2);
            this.groupBox62.Controls.Add(this.label131);
            this.groupBox62.Controls.Add(this.label132);
            this.groupBox62.Controls.Add(this.label133);
            this.groupBox62.Controls.Add(this.label134);
            resources.ApplyResources(this.groupBox62, "groupBox62");
            this.groupBox62.Name = "groupBox62";
            this.groupBox62.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4")});
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // label131
            // 
            resources.ApplyResources(this.label131, "label131");
            this.label131.Name = "label131";
            // 
            // label132
            // 
            resources.ApplyResources(this.label132, "label132");
            this.label132.Name = "label132";
            // 
            // label133
            // 
            resources.ApplyResources(this.label133, "label133");
            this.label133.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label133.Name = "label133";
            // 
            // label134
            // 
            this.label134.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label134.AllowDrop = true;
            this.label134.AutoEllipsis = true;
            resources.ApplyResources(this.label134, "label134");
            this.label134.BackColor = System.Drawing.Color.Transparent;
            this.label134.ForeColor = System.Drawing.Color.DarkRed;
            this.label134.Name = "label134";
            this.label134.UseCompatibleTextRendering = true;
            // 
            // groupBox63
            // 
            this.groupBox63.Controls.Add(this.comboBox3);
            this.groupBox63.Controls.Add(this.comboBox4);
            this.groupBox63.Controls.Add(this.label135);
            this.groupBox63.Controls.Add(this.label136);
            this.groupBox63.Controls.Add(this.label137);
            this.groupBox63.Controls.Add(this.label138);
            resources.ApplyResources(this.groupBox63, "groupBox63");
            this.groupBox63.Name = "groupBox63";
            this.groupBox63.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            resources.GetString("comboBox4.Items1"),
            resources.GetString("comboBox4.Items2"),
            resources.GetString("comboBox4.Items3"),
            resources.GetString("comboBox4.Items4")});
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.Name = "comboBox4";
            // 
            // label135
            // 
            resources.ApplyResources(this.label135, "label135");
            this.label135.Name = "label135";
            // 
            // label136
            // 
            resources.ApplyResources(this.label136, "label136");
            this.label136.Name = "label136";
            // 
            // label137
            // 
            resources.ApplyResources(this.label137, "label137");
            this.label137.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label137.Name = "label137";
            // 
            // label138
            // 
            this.label138.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label138.AllowDrop = true;
            this.label138.AutoEllipsis = true;
            resources.ApplyResources(this.label138, "label138");
            this.label138.BackColor = System.Drawing.Color.Transparent;
            this.label138.ForeColor = System.Drawing.Color.DarkRed;
            this.label138.Name = "label138";
            this.label138.UseCompatibleTextRendering = true;
            // 
            // groupBox64
            // 
            this.groupBox64.Controls.Add(this.comboBox5);
            this.groupBox64.Controls.Add(this.comboBox6);
            this.groupBox64.Controls.Add(this.label139);
            this.groupBox64.Controls.Add(this.label140);
            this.groupBox64.Controls.Add(this.label141);
            this.groupBox64.Controls.Add(this.label142);
            resources.ApplyResources(this.groupBox64, "groupBox64");
            this.groupBox64.Name = "groupBox64";
            this.groupBox64.TabStop = false;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            resources.GetString("comboBox5.Items"),
            resources.GetString("comboBox5.Items1"),
            resources.GetString("comboBox5.Items2"),
            resources.GetString("comboBox5.Items3"),
            resources.GetString("comboBox5.Items4")});
            resources.ApplyResources(this.comboBox5, "comboBox5");
            this.comboBox5.Name = "comboBox5";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            resources.GetString("comboBox6.Items"),
            resources.GetString("comboBox6.Items1"),
            resources.GetString("comboBox6.Items2"),
            resources.GetString("comboBox6.Items3"),
            resources.GetString("comboBox6.Items4")});
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.Name = "comboBox6";
            // 
            // label139
            // 
            resources.ApplyResources(this.label139, "label139");
            this.label139.Name = "label139";
            // 
            // label140
            // 
            resources.ApplyResources(this.label140, "label140");
            this.label140.Name = "label140";
            // 
            // label141
            // 
            resources.ApplyResources(this.label141, "label141");
            this.label141.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label141.Name = "label141";
            // 
            // label142
            // 
            this.label142.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label142.AllowDrop = true;
            this.label142.AutoEllipsis = true;
            resources.ApplyResources(this.label142, "label142");
            this.label142.BackColor = System.Drawing.Color.Transparent;
            this.label142.ForeColor = System.Drawing.Color.DarkRed;
            this.label142.Name = "label142";
            this.label142.UseCompatibleTextRendering = true;
            // 
            // groupBox65
            // 
            this.groupBox65.Controls.Add(this.comboBox7);
            this.groupBox65.Controls.Add(this.comboBox8);
            this.groupBox65.Controls.Add(this.label143);
            this.groupBox65.Controls.Add(this.label144);
            this.groupBox65.Controls.Add(this.label145);
            this.groupBox65.Controls.Add(this.label146);
            resources.ApplyResources(this.groupBox65, "groupBox65");
            this.groupBox65.Name = "groupBox65";
            this.groupBox65.TabStop = false;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            resources.GetString("comboBox7.Items"),
            resources.GetString("comboBox7.Items1"),
            resources.GetString("comboBox7.Items2"),
            resources.GetString("comboBox7.Items3"),
            resources.GetString("comboBox7.Items4")});
            resources.ApplyResources(this.comboBox7, "comboBox7");
            this.comboBox7.Name = "comboBox7";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            resources.GetString("comboBox8.Items"),
            resources.GetString("comboBox8.Items1"),
            resources.GetString("comboBox8.Items2"),
            resources.GetString("comboBox8.Items3"),
            resources.GetString("comboBox8.Items4"),
            resources.GetString("comboBox8.Items5")});
            resources.ApplyResources(this.comboBox8, "comboBox8");
            this.comboBox8.Name = "comboBox8";
            // 
            // label143
            // 
            resources.ApplyResources(this.label143, "label143");
            this.label143.Name = "label143";
            // 
            // label144
            // 
            resources.ApplyResources(this.label144, "label144");
            this.label144.Name = "label144";
            // 
            // label145
            // 
            resources.ApplyResources(this.label145, "label145");
            this.label145.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label145.Name = "label145";
            // 
            // label146
            // 
            this.label146.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label146.AllowDrop = true;
            this.label146.AutoEllipsis = true;
            resources.ApplyResources(this.label146, "label146");
            this.label146.BackColor = System.Drawing.Color.Transparent;
            this.label146.ForeColor = System.Drawing.Color.DarkRed;
            this.label146.Name = "label146";
            this.label146.UseCompatibleTextRendering = true;
            // 
            // groupBox66
            // 
            this.groupBox66.Controls.Add(this.comboBox9);
            this.groupBox66.Controls.Add(this.comboBox10);
            this.groupBox66.Controls.Add(this.label147);
            this.groupBox66.Controls.Add(this.label148);
            this.groupBox66.Controls.Add(this.label149);
            this.groupBox66.Controls.Add(this.label150);
            resources.ApplyResources(this.groupBox66, "groupBox66");
            this.groupBox66.Name = "groupBox66";
            this.groupBox66.TabStop = false;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            resources.GetString("comboBox9.Items"),
            resources.GetString("comboBox9.Items1"),
            resources.GetString("comboBox9.Items2"),
            resources.GetString("comboBox9.Items3"),
            resources.GetString("comboBox9.Items4"),
            resources.GetString("comboBox9.Items5")});
            resources.ApplyResources(this.comboBox9, "comboBox9");
            this.comboBox9.Name = "comboBox9";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            resources.GetString("comboBox10.Items"),
            resources.GetString("comboBox10.Items1"),
            resources.GetString("comboBox10.Items2"),
            resources.GetString("comboBox10.Items3"),
            resources.GetString("comboBox10.Items4"),
            resources.GetString("comboBox10.Items5")});
            resources.ApplyResources(this.comboBox10, "comboBox10");
            this.comboBox10.Name = "comboBox10";
            // 
            // label147
            // 
            resources.ApplyResources(this.label147, "label147");
            this.label147.Name = "label147";
            // 
            // label148
            // 
            resources.ApplyResources(this.label148, "label148");
            this.label148.Name = "label148";
            // 
            // label149
            // 
            resources.ApplyResources(this.label149, "label149");
            this.label149.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label149.Name = "label149";
            // 
            // label150
            // 
            this.label150.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label150.AllowDrop = true;
            this.label150.AutoEllipsis = true;
            resources.ApplyResources(this.label150, "label150");
            this.label150.BackColor = System.Drawing.Color.Transparent;
            this.label150.ForeColor = System.Drawing.Color.DarkRed;
            this.label150.Name = "label150";
            this.label150.UseCompatibleTextRendering = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_2);
            // 
            // tabPage9
            // 
            resources.ApplyResources(this.tabPage9, "tabPage9");
            this.tabPage9.Controls.Add(this.groupBox73);
            this.tabPage9.Controls.Add(this.groupBox72);
            this.tabPage9.Controls.Add(this.groupBox79);
            this.tabPage9.Controls.Add(this.button8);
            this.tabPage9.Controls.Add(this.txtPH);
            this.tabPage9.Controls.Add(this.txtPD);
            this.tabPage9.Controls.Add(this.txtPJ);
            this.tabPage9.Controls.Add(this.txtPB);
            this.tabPage9.Controls.Add(this.txtPA);
            this.tabPage9.Controls.Add(this.groupBox80);
            this.tabPage9.Controls.Add(this.groupBox81);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox73
            // 
            this.groupBox73.Controls.Add(this.comboBox23);
            this.groupBox73.Controls.Add(this.comboBox24);
            this.groupBox73.Controls.Add(this.label175);
            this.groupBox73.Controls.Add(this.label176);
            this.groupBox73.Controls.Add(this.label177);
            this.groupBox73.Controls.Add(this.label178);
            resources.ApplyResources(this.groupBox73, "groupBox73");
            this.groupBox73.Name = "groupBox73";
            this.groupBox73.TabStop = false;
            // 
            // comboBox23
            // 
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Items.AddRange(new object[] {
            resources.GetString("comboBox23.Items"),
            resources.GetString("comboBox23.Items1"),
            resources.GetString("comboBox23.Items2"),
            resources.GetString("comboBox23.Items3"),
            resources.GetString("comboBox23.Items4")});
            resources.ApplyResources(this.comboBox23, "comboBox23");
            this.comboBox23.Name = "comboBox23";
            // 
            // comboBox24
            // 
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            resources.GetString("comboBox24.Items"),
            resources.GetString("comboBox24.Items1"),
            resources.GetString("comboBox24.Items2"),
            resources.GetString("comboBox24.Items3"),
            resources.GetString("comboBox24.Items4")});
            resources.ApplyResources(this.comboBox24, "comboBox24");
            this.comboBox24.Name = "comboBox24";
            // 
            // label175
            // 
            resources.ApplyResources(this.label175, "label175");
            this.label175.Name = "label175";
            // 
            // label176
            // 
            resources.ApplyResources(this.label176, "label176");
            this.label176.Name = "label176";
            // 
            // label177
            // 
            resources.ApplyResources(this.label177, "label177");
            this.label177.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label177.Name = "label177";
            // 
            // label178
            // 
            this.label178.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label178.AllowDrop = true;
            this.label178.AutoEllipsis = true;
            resources.ApplyResources(this.label178, "label178");
            this.label178.BackColor = System.Drawing.Color.Transparent;
            this.label178.ForeColor = System.Drawing.Color.DarkRed;
            this.label178.Name = "label178";
            this.label178.UseCompatibleTextRendering = true;
            // 
            // groupBox72
            // 
            this.groupBox72.Controls.Add(this.comboBox21);
            this.groupBox72.Controls.Add(this.comboBox22);
            this.groupBox72.Controls.Add(this.label171);
            this.groupBox72.Controls.Add(this.label172);
            this.groupBox72.Controls.Add(this.label173);
            this.groupBox72.Controls.Add(this.label174);
            resources.ApplyResources(this.groupBox72, "groupBox72");
            this.groupBox72.Name = "groupBox72";
            this.groupBox72.TabStop = false;
            // 
            // comboBox21
            // 
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            resources.GetString("comboBox21.Items"),
            resources.GetString("comboBox21.Items1"),
            resources.GetString("comboBox21.Items2"),
            resources.GetString("comboBox21.Items3"),
            resources.GetString("comboBox21.Items4")});
            resources.ApplyResources(this.comboBox21, "comboBox21");
            this.comboBox21.Name = "comboBox21";
            // 
            // comboBox22
            // 
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            resources.GetString("comboBox22.Items"),
            resources.GetString("comboBox22.Items1"),
            resources.GetString("comboBox22.Items2"),
            resources.GetString("comboBox22.Items3"),
            resources.GetString("comboBox22.Items4")});
            resources.ApplyResources(this.comboBox22, "comboBox22");
            this.comboBox22.Name = "comboBox22";
            // 
            // label171
            // 
            resources.ApplyResources(this.label171, "label171");
            this.label171.Name = "label171";
            // 
            // label172
            // 
            resources.ApplyResources(this.label172, "label172");
            this.label172.Name = "label172";
            // 
            // label173
            // 
            resources.ApplyResources(this.label173, "label173");
            this.label173.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label173.Name = "label173";
            // 
            // label174
            // 
            this.label174.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label174.AllowDrop = true;
            this.label174.AutoEllipsis = true;
            resources.ApplyResources(this.label174, "label174");
            this.label174.BackColor = System.Drawing.Color.Transparent;
            this.label174.ForeColor = System.Drawing.Color.DarkRed;
            this.label174.Name = "label174";
            this.label174.UseCompatibleTextRendering = true;
            // 
            // groupBox79
            // 
            this.groupBox79.Controls.Add(this.comboBox36);
            this.groupBox79.Controls.Add(this.comboBox35);
            this.groupBox79.Controls.Add(this.label200);
            this.groupBox79.Controls.Add(this.label201);
            this.groupBox79.Controls.Add(this.label202);
            this.groupBox79.Controls.Add(this.label206);
            resources.ApplyResources(this.groupBox79, "groupBox79");
            this.groupBox79.Name = "groupBox79";
            this.groupBox79.TabStop = false;
            // 
            // comboBox36
            // 
            this.comboBox36.FormattingEnabled = true;
            this.comboBox36.Items.AddRange(new object[] {
            resources.GetString("comboBox36.Items"),
            resources.GetString("comboBox36.Items1"),
            resources.GetString("comboBox36.Items2"),
            resources.GetString("comboBox36.Items3"),
            resources.GetString("comboBox36.Items4")});
            resources.ApplyResources(this.comboBox36, "comboBox36");
            this.comboBox36.Name = "comboBox36";
            // 
            // comboBox35
            // 
            this.comboBox35.FormattingEnabled = true;
            this.comboBox35.Items.AddRange(new object[] {
            resources.GetString("comboBox35.Items"),
            resources.GetString("comboBox35.Items1"),
            resources.GetString("comboBox35.Items2"),
            resources.GetString("comboBox35.Items3"),
            resources.GetString("comboBox35.Items4")});
            resources.ApplyResources(this.comboBox35, "comboBox35");
            this.comboBox35.Name = "comboBox35";
            // 
            // label200
            // 
            resources.ApplyResources(this.label200, "label200");
            this.label200.Name = "label200";
            // 
            // label201
            // 
            resources.ApplyResources(this.label201, "label201");
            this.label201.Name = "label201";
            // 
            // label202
            // 
            resources.ApplyResources(this.label202, "label202");
            this.label202.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label202.Name = "label202";
            // 
            // label206
            // 
            this.label206.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label206.AllowDrop = true;
            this.label206.AutoEllipsis = true;
            resources.ApplyResources(this.label206, "label206");
            this.label206.BackColor = System.Drawing.Color.Transparent;
            this.label206.ForeColor = System.Drawing.Color.DarkRed;
            this.label206.Name = "label206";
            this.label206.UseCompatibleTextRendering = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtPH
            // 
            resources.ApplyResources(this.txtPH, "txtPH");
            this.txtPH.Name = "txtPH";
            // 
            // txtPD
            // 
            resources.ApplyResources(this.txtPD, "txtPD");
            this.txtPD.Name = "txtPD";
            // 
            // txtPJ
            // 
            resources.ApplyResources(this.txtPJ, "txtPJ");
            this.txtPJ.Name = "txtPJ";
            // 
            // txtPB
            // 
            resources.ApplyResources(this.txtPB, "txtPB");
            this.txtPB.Name = "txtPB";
            // 
            // txtPA
            // 
            resources.ApplyResources(this.txtPA, "txtPA");
            this.txtPA.Name = "txtPA";
            // 
            // groupBox80
            // 
            this.groupBox80.Controls.Add(this.comboBox37);
            this.groupBox80.Controls.Add(this.comboBox38);
            this.groupBox80.Controls.Add(this.label203);
            this.groupBox80.Controls.Add(this.label204);
            this.groupBox80.Controls.Add(this.label205);
            this.groupBox80.Controls.Add(this.label199);
            resources.ApplyResources(this.groupBox80, "groupBox80");
            this.groupBox80.Name = "groupBox80";
            this.groupBox80.TabStop = false;
            // 
            // comboBox37
            // 
            this.comboBox37.FormattingEnabled = true;
            this.comboBox37.Items.AddRange(new object[] {
            resources.GetString("comboBox37.Items"),
            resources.GetString("comboBox37.Items1"),
            resources.GetString("comboBox37.Items2"),
            resources.GetString("comboBox37.Items3"),
            resources.GetString("comboBox37.Items4")});
            resources.ApplyResources(this.comboBox37, "comboBox37");
            this.comboBox37.Name = "comboBox37";
            // 
            // comboBox38
            // 
            this.comboBox38.FormattingEnabled = true;
            this.comboBox38.Items.AddRange(new object[] {
            resources.GetString("comboBox38.Items"),
            resources.GetString("comboBox38.Items1"),
            resources.GetString("comboBox38.Items2"),
            resources.GetString("comboBox38.Items3"),
            resources.GetString("comboBox38.Items4"),
            resources.GetString("comboBox38.Items5")});
            resources.ApplyResources(this.comboBox38, "comboBox38");
            this.comboBox38.Name = "comboBox38";
            // 
            // label203
            // 
            resources.ApplyResources(this.label203, "label203");
            this.label203.Name = "label203";
            // 
            // label204
            // 
            resources.ApplyResources(this.label204, "label204");
            this.label204.Name = "label204";
            // 
            // label205
            // 
            resources.ApplyResources(this.label205, "label205");
            this.label205.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label205.Name = "label205";
            // 
            // label199
            // 
            this.label199.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label199.AllowDrop = true;
            this.label199.AutoEllipsis = true;
            resources.ApplyResources(this.label199, "label199");
            this.label199.BackColor = System.Drawing.Color.Transparent;
            this.label199.ForeColor = System.Drawing.Color.DarkRed;
            this.label199.Name = "label199";
            this.label199.UseCompatibleTextRendering = true;
            // 
            // groupBox81
            // 
            this.groupBox81.Controls.Add(this.comboBox39);
            this.groupBox81.Controls.Add(this.comboBox40);
            this.groupBox81.Controls.Add(this.label207);
            this.groupBox81.Controls.Add(this.label208);
            this.groupBox81.Controls.Add(this.label209);
            this.groupBox81.Controls.Add(this.label210);
            resources.ApplyResources(this.groupBox81, "groupBox81");
            this.groupBox81.Name = "groupBox81";
            this.groupBox81.TabStop = false;
            // 
            // comboBox39
            // 
            this.comboBox39.FormattingEnabled = true;
            this.comboBox39.Items.AddRange(new object[] {
            resources.GetString("comboBox39.Items"),
            resources.GetString("comboBox39.Items1"),
            resources.GetString("comboBox39.Items2"),
            resources.GetString("comboBox39.Items3"),
            resources.GetString("comboBox39.Items4"),
            resources.GetString("comboBox39.Items5")});
            resources.ApplyResources(this.comboBox39, "comboBox39");
            this.comboBox39.Name = "comboBox39";
            this.comboBox39.SelectedIndexChanged += new System.EventHandler(this.comboBox39_SelectedIndexChanged);
            this.comboBox39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox39_KeyPress);
            // 
            // comboBox40
            // 
            this.comboBox40.FormattingEnabled = true;
            this.comboBox40.Items.AddRange(new object[] {
            resources.GetString("comboBox40.Items"),
            resources.GetString("comboBox40.Items1"),
            resources.GetString("comboBox40.Items2"),
            resources.GetString("comboBox40.Items3"),
            resources.GetString("comboBox40.Items4"),
            resources.GetString("comboBox40.Items5")});
            resources.ApplyResources(this.comboBox40, "comboBox40");
            this.comboBox40.Name = "comboBox40";
            this.comboBox40.SelectedIndexChanged += new System.EventHandler(this.comboBox40_SelectedIndexChanged);
            this.comboBox40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox40_KeyPress);
            // 
            // label207
            // 
            resources.ApplyResources(this.label207, "label207");
            this.label207.Name = "label207";
            // 
            // label208
            // 
            resources.ApplyResources(this.label208, "label208");
            this.label208.Name = "label208";
            // 
            // label209
            // 
            resources.ApplyResources(this.label209, "label209");
            this.label209.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label209.Name = "label209";
            // 
            // label210
            // 
            this.label210.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label210.AllowDrop = true;
            this.label210.AutoEllipsis = true;
            resources.ApplyResources(this.label210, "label210");
            this.label210.BackColor = System.Drawing.Color.Transparent;
            this.label210.ForeColor = System.Drawing.Color.DarkRed;
            this.label210.Name = "label210";
            this.label210.UseCompatibleTextRendering = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnRefresh);
            this.tabPage7.Controls.Add(this.btnDelete);
            this.tabPage7.Controls.Add(this.button9);
            this.tabPage7.Controls.Add(this.DGNEO);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DGNEO
            // 
            this.DGNEO.AutoGenerateColumns = false;
            this.DGNEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGNEO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.peyvastDataGridViewTextBoxColumn,
            this.resultNeoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nameFDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.naDataGridViewTextBoxColumn,
            this.nbDataGridViewTextBoxColumn,
            this.ncDataGridViewTextBoxColumn,
            this.ndDataGridViewTextBoxColumn,
            this.neDataGridViewTextBoxColumn,
            this.nfDataGridViewTextBoxColumn,
            this.ngDataGridViewTextBoxColumn,
            this.nhDataGridViewTextBoxColumn,
            this.niDataGridViewTextBoxColumn,
            this.njDataGridViewTextBoxColumn,
            this.nkDataGridViewTextBoxColumn,
            this.nlDataGridViewTextBoxColumn,
            this.eaDataGridViewTextBoxColumn,
            this.ebDataGridViewTextBoxColumn,
            this.ecDataGridViewTextBoxColumn,
            this.edDataGridViewTextBoxColumn,
            this.eeDataGridViewTextBoxColumn,
            this.efDataGridViewTextBoxColumn,
            this.egDataGridViewTextBoxColumn,
            this.ehDataGridViewTextBoxColumn,
            this.eiDataGridViewTextBoxColumn,
            this.ejDataGridViewTextBoxColumn,
            this.ekDataGridViewTextBoxColumn,
            this.elDataGridViewTextBoxColumn,
            this.oaDataGridViewTextBoxColumn,
            this.obDataGridViewTextBoxColumn,
            this.ocDataGridViewTextBoxColumn,
            this.odDataGridViewTextBoxColumn,
            this.oeDataGridViewTextBoxColumn,
            this.ofDataGridViewTextBoxColumn,
            this.ogDataGridViewTextBoxColumn,
            this.ohDataGridViewTextBoxColumn,
            this.oiDataGridViewTextBoxColumn,
            this.ojDataGridViewTextBoxColumn,
            this.okDataGridViewTextBoxColumn,
            this.olDataGridViewTextBoxColumn,
            this.aaDataGridViewTextBoxColumn,
            this.abDataGridViewTextBoxColumn,
            this.acDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.aeDataGridViewTextBoxColumn,
            this.afDataGridViewTextBoxColumn,
            this.agDataGridViewTextBoxColumn,
            this.ahDataGridViewTextBoxColumn,
            this.aiDataGridViewTextBoxColumn,
            this.ajDataGridViewTextBoxColumn,
            this.akDataGridViewTextBoxColumn,
            this.alDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.cbDataGridViewTextBoxColumn,
            this.ccDataGridViewTextBoxColumn,
            this.cdDataGridViewTextBoxColumn,
            this.ceDataGridViewTextBoxColumn,
            this.cfDataGridViewTextBoxColumn,
            this.cgDataGridViewTextBoxColumn,
            this.chDataGridViewTextBoxColumn,
            this.ciDataGridViewTextBoxColumn,
            this.cjDataGridViewTextBoxColumn,
            this.ckDataGridViewTextBoxColumn,
            this.clDataGridViewTextBoxColumn,
            this.dateNeoDataGridViewTextBoxColumn,
            this.meliDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneHDataGridViewTextBoxColumn,
            this.phoneMDataGridViewTextBoxColumn,
            this.numberShDataGridViewTextBoxColumn,
            this.loEshDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.pajDataGridViewTextBoxColumn,
            this.padDataGridViewTextBoxColumn,
            this.pbaDataGridViewTextBoxColumn,
            this.pbhDataGridViewTextBoxColumn,
            this.pcdDataGridViewTextBoxColumn,
            this.pchDataGridViewTextBoxColumn,
            this.pdbDataGridViewTextBoxColumn,
            this.pdjDataGridViewTextBoxColumn,
            this.pejDataGridViewTextBoxColumn,
            this.pehDataGridViewTextBoxColumn,
            this.pfaDataGridViewTextBoxColumn,
            this.pfbDataGridViewTextBoxColumn,
            this.pgjDataGridViewTextBoxColumn,
            this.pghDataGridViewTextBoxColumn,
            this.phaDataGridViewTextBoxColumn,
            this.phbDataGridViewTextBoxColumn,
            this.piaDataGridViewTextBoxColumn,
            this.pihDataGridViewTextBoxColumn,
            this.pjbDataGridViewTextBoxColumn,
            this.pjhDataGridViewTextBoxColumn,
            this.pkaDataGridViewTextBoxColumn,
            this.pkdDataGridViewTextBoxColumn,
            this.pldDataGridViewTextBoxColumn,
            this.plhDataGridViewTextBoxColumn,
            this.pmbDataGridViewTextBoxColumn,
            this.pmhDataGridViewTextBoxColumn,
            this.pnjDataGridViewTextBoxColumn,
            this.pndDataGridViewTextBoxColumn,
            this.ppbDataGridViewTextBoxColumn,
            this.ppdDataGridViewTextBoxColumn,
            this.poaDataGridViewTextBoxColumn,
            this.podDataGridViewTextBoxColumn,
            this.pqbDataGridViewTextBoxColumn,
            this.pqjDataGridViewTextBoxColumn,
            this.puaDataGridViewTextBoxColumn,
            this.pujDataGridViewTextBoxColumn,
            this.pwaDataGridViewTextBoxColumn,
            this.pwjDataGridViewTextBoxColumn,
            this.pxbDataGridViewTextBoxColumn,
            this.pxdDataGridViewTextBoxColumn,
            this.pADataGridViewTextBoxColumn,
            this.pBDataGridViewTextBoxColumn,
            this.pJDataGridViewTextBoxColumn,
            this.pDDataGridViewTextBoxColumn,
            this.pHDataGridViewTextBoxColumn,
            this.shoghlNextDataGridViewTextBoxColumn});
            this.DGNEO.DataSource = this.tBNeoBindingSource;
            resources.ApplyResources(this.DGNEO, "DGNEO");
            this.DGNEO.Name = "DGNEO";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            resources.ApplyResources(this.numberDataGridViewTextBoxColumn, "numberDataGridViewTextBoxColumn");
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // peyvastDataGridViewTextBoxColumn
            // 
            this.peyvastDataGridViewTextBoxColumn.DataPropertyName = "Peyvast";
            resources.ApplyResources(this.peyvastDataGridViewTextBoxColumn, "peyvastDataGridViewTextBoxColumn");
            this.peyvastDataGridViewTextBoxColumn.Name = "peyvastDataGridViewTextBoxColumn";
            // 
            // resultNeoDataGridViewTextBoxColumn
            // 
            this.resultNeoDataGridViewTextBoxColumn.DataPropertyName = "ResultNeo";
            resources.ApplyResources(this.resultNeoDataGridViewTextBoxColumn, "resultNeoDataGridViewTextBoxColumn");
            this.resultNeoDataGridViewTextBoxColumn.Name = "resultNeoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nameFDataGridViewTextBoxColumn
            // 
            this.nameFDataGridViewTextBoxColumn.DataPropertyName = "NameF";
            resources.ApplyResources(this.nameFDataGridViewTextBoxColumn, "nameFDataGridViewTextBoxColumn");
            this.nameFDataGridViewTextBoxColumn.Name = "nameFDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            resources.ApplyResources(this.commentDataGridViewTextBoxColumn, "commentDataGridViewTextBoxColumn");
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // naDataGridViewTextBoxColumn
            // 
            this.naDataGridViewTextBoxColumn.DataPropertyName = "na";
            resources.ApplyResources(this.naDataGridViewTextBoxColumn, "naDataGridViewTextBoxColumn");
            this.naDataGridViewTextBoxColumn.Name = "naDataGridViewTextBoxColumn";
            // 
            // nbDataGridViewTextBoxColumn
            // 
            this.nbDataGridViewTextBoxColumn.DataPropertyName = "nb";
            resources.ApplyResources(this.nbDataGridViewTextBoxColumn, "nbDataGridViewTextBoxColumn");
            this.nbDataGridViewTextBoxColumn.Name = "nbDataGridViewTextBoxColumn";
            // 
            // ncDataGridViewTextBoxColumn
            // 
            this.ncDataGridViewTextBoxColumn.DataPropertyName = "nc";
            resources.ApplyResources(this.ncDataGridViewTextBoxColumn, "ncDataGridViewTextBoxColumn");
            this.ncDataGridViewTextBoxColumn.Name = "ncDataGridViewTextBoxColumn";
            // 
            // ndDataGridViewTextBoxColumn
            // 
            this.ndDataGridViewTextBoxColumn.DataPropertyName = "nd";
            resources.ApplyResources(this.ndDataGridViewTextBoxColumn, "ndDataGridViewTextBoxColumn");
            this.ndDataGridViewTextBoxColumn.Name = "ndDataGridViewTextBoxColumn";
            // 
            // neDataGridViewTextBoxColumn
            // 
            this.neDataGridViewTextBoxColumn.DataPropertyName = "ne";
            resources.ApplyResources(this.neDataGridViewTextBoxColumn, "neDataGridViewTextBoxColumn");
            this.neDataGridViewTextBoxColumn.Name = "neDataGridViewTextBoxColumn";
            // 
            // nfDataGridViewTextBoxColumn
            // 
            this.nfDataGridViewTextBoxColumn.DataPropertyName = "nf";
            resources.ApplyResources(this.nfDataGridViewTextBoxColumn, "nfDataGridViewTextBoxColumn");
            this.nfDataGridViewTextBoxColumn.Name = "nfDataGridViewTextBoxColumn";
            // 
            // ngDataGridViewTextBoxColumn
            // 
            this.ngDataGridViewTextBoxColumn.DataPropertyName = "ng";
            resources.ApplyResources(this.ngDataGridViewTextBoxColumn, "ngDataGridViewTextBoxColumn");
            this.ngDataGridViewTextBoxColumn.Name = "ngDataGridViewTextBoxColumn";
            // 
            // nhDataGridViewTextBoxColumn
            // 
            this.nhDataGridViewTextBoxColumn.DataPropertyName = "nh";
            resources.ApplyResources(this.nhDataGridViewTextBoxColumn, "nhDataGridViewTextBoxColumn");
            this.nhDataGridViewTextBoxColumn.Name = "nhDataGridViewTextBoxColumn";
            // 
            // niDataGridViewTextBoxColumn
            // 
            this.niDataGridViewTextBoxColumn.DataPropertyName = "ni";
            resources.ApplyResources(this.niDataGridViewTextBoxColumn, "niDataGridViewTextBoxColumn");
            this.niDataGridViewTextBoxColumn.Name = "niDataGridViewTextBoxColumn";
            // 
            // njDataGridViewTextBoxColumn
            // 
            this.njDataGridViewTextBoxColumn.DataPropertyName = "nj";
            resources.ApplyResources(this.njDataGridViewTextBoxColumn, "njDataGridViewTextBoxColumn");
            this.njDataGridViewTextBoxColumn.Name = "njDataGridViewTextBoxColumn";
            // 
            // nkDataGridViewTextBoxColumn
            // 
            this.nkDataGridViewTextBoxColumn.DataPropertyName = "nk";
            resources.ApplyResources(this.nkDataGridViewTextBoxColumn, "nkDataGridViewTextBoxColumn");
            this.nkDataGridViewTextBoxColumn.Name = "nkDataGridViewTextBoxColumn";
            // 
            // nlDataGridViewTextBoxColumn
            // 
            this.nlDataGridViewTextBoxColumn.DataPropertyName = "nl";
            resources.ApplyResources(this.nlDataGridViewTextBoxColumn, "nlDataGridViewTextBoxColumn");
            this.nlDataGridViewTextBoxColumn.Name = "nlDataGridViewTextBoxColumn";
            // 
            // eaDataGridViewTextBoxColumn
            // 
            this.eaDataGridViewTextBoxColumn.DataPropertyName = "ea";
            resources.ApplyResources(this.eaDataGridViewTextBoxColumn, "eaDataGridViewTextBoxColumn");
            this.eaDataGridViewTextBoxColumn.Name = "eaDataGridViewTextBoxColumn";
            // 
            // ebDataGridViewTextBoxColumn
            // 
            this.ebDataGridViewTextBoxColumn.DataPropertyName = "eb";
            resources.ApplyResources(this.ebDataGridViewTextBoxColumn, "ebDataGridViewTextBoxColumn");
            this.ebDataGridViewTextBoxColumn.Name = "ebDataGridViewTextBoxColumn";
            // 
            // ecDataGridViewTextBoxColumn
            // 
            this.ecDataGridViewTextBoxColumn.DataPropertyName = "ec";
            resources.ApplyResources(this.ecDataGridViewTextBoxColumn, "ecDataGridViewTextBoxColumn");
            this.ecDataGridViewTextBoxColumn.Name = "ecDataGridViewTextBoxColumn";
            // 
            // edDataGridViewTextBoxColumn
            // 
            this.edDataGridViewTextBoxColumn.DataPropertyName = "ed";
            resources.ApplyResources(this.edDataGridViewTextBoxColumn, "edDataGridViewTextBoxColumn");
            this.edDataGridViewTextBoxColumn.Name = "edDataGridViewTextBoxColumn";
            // 
            // eeDataGridViewTextBoxColumn
            // 
            this.eeDataGridViewTextBoxColumn.DataPropertyName = "ee";
            resources.ApplyResources(this.eeDataGridViewTextBoxColumn, "eeDataGridViewTextBoxColumn");
            this.eeDataGridViewTextBoxColumn.Name = "eeDataGridViewTextBoxColumn";
            // 
            // efDataGridViewTextBoxColumn
            // 
            this.efDataGridViewTextBoxColumn.DataPropertyName = "ef";
            resources.ApplyResources(this.efDataGridViewTextBoxColumn, "efDataGridViewTextBoxColumn");
            this.efDataGridViewTextBoxColumn.Name = "efDataGridViewTextBoxColumn";
            // 
            // egDataGridViewTextBoxColumn
            // 
            this.egDataGridViewTextBoxColumn.DataPropertyName = "eg";
            resources.ApplyResources(this.egDataGridViewTextBoxColumn, "egDataGridViewTextBoxColumn");
            this.egDataGridViewTextBoxColumn.Name = "egDataGridViewTextBoxColumn";
            // 
            // ehDataGridViewTextBoxColumn
            // 
            this.ehDataGridViewTextBoxColumn.DataPropertyName = "eh";
            resources.ApplyResources(this.ehDataGridViewTextBoxColumn, "ehDataGridViewTextBoxColumn");
            this.ehDataGridViewTextBoxColumn.Name = "ehDataGridViewTextBoxColumn";
            // 
            // eiDataGridViewTextBoxColumn
            // 
            this.eiDataGridViewTextBoxColumn.DataPropertyName = "ei";
            resources.ApplyResources(this.eiDataGridViewTextBoxColumn, "eiDataGridViewTextBoxColumn");
            this.eiDataGridViewTextBoxColumn.Name = "eiDataGridViewTextBoxColumn";
            // 
            // ejDataGridViewTextBoxColumn
            // 
            this.ejDataGridViewTextBoxColumn.DataPropertyName = "ej";
            resources.ApplyResources(this.ejDataGridViewTextBoxColumn, "ejDataGridViewTextBoxColumn");
            this.ejDataGridViewTextBoxColumn.Name = "ejDataGridViewTextBoxColumn";
            // 
            // ekDataGridViewTextBoxColumn
            // 
            this.ekDataGridViewTextBoxColumn.DataPropertyName = "ek";
            resources.ApplyResources(this.ekDataGridViewTextBoxColumn, "ekDataGridViewTextBoxColumn");
            this.ekDataGridViewTextBoxColumn.Name = "ekDataGridViewTextBoxColumn";
            // 
            // elDataGridViewTextBoxColumn
            // 
            this.elDataGridViewTextBoxColumn.DataPropertyName = "el";
            resources.ApplyResources(this.elDataGridViewTextBoxColumn, "elDataGridViewTextBoxColumn");
            this.elDataGridViewTextBoxColumn.Name = "elDataGridViewTextBoxColumn";
            // 
            // oaDataGridViewTextBoxColumn
            // 
            this.oaDataGridViewTextBoxColumn.DataPropertyName = "oa";
            resources.ApplyResources(this.oaDataGridViewTextBoxColumn, "oaDataGridViewTextBoxColumn");
            this.oaDataGridViewTextBoxColumn.Name = "oaDataGridViewTextBoxColumn";
            // 
            // obDataGridViewTextBoxColumn
            // 
            this.obDataGridViewTextBoxColumn.DataPropertyName = "ob";
            resources.ApplyResources(this.obDataGridViewTextBoxColumn, "obDataGridViewTextBoxColumn");
            this.obDataGridViewTextBoxColumn.Name = "obDataGridViewTextBoxColumn";
            // 
            // ocDataGridViewTextBoxColumn
            // 
            this.ocDataGridViewTextBoxColumn.DataPropertyName = "oc";
            resources.ApplyResources(this.ocDataGridViewTextBoxColumn, "ocDataGridViewTextBoxColumn");
            this.ocDataGridViewTextBoxColumn.Name = "ocDataGridViewTextBoxColumn";
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "od";
            resources.ApplyResources(this.odDataGridViewTextBoxColumn, "odDataGridViewTextBoxColumn");
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            // 
            // oeDataGridViewTextBoxColumn
            // 
            this.oeDataGridViewTextBoxColumn.DataPropertyName = "oe";
            resources.ApplyResources(this.oeDataGridViewTextBoxColumn, "oeDataGridViewTextBoxColumn");
            this.oeDataGridViewTextBoxColumn.Name = "oeDataGridViewTextBoxColumn";
            // 
            // ofDataGridViewTextBoxColumn
            // 
            this.ofDataGridViewTextBoxColumn.DataPropertyName = "of";
            resources.ApplyResources(this.ofDataGridViewTextBoxColumn, "ofDataGridViewTextBoxColumn");
            this.ofDataGridViewTextBoxColumn.Name = "ofDataGridViewTextBoxColumn";
            // 
            // ogDataGridViewTextBoxColumn
            // 
            this.ogDataGridViewTextBoxColumn.DataPropertyName = "og";
            resources.ApplyResources(this.ogDataGridViewTextBoxColumn, "ogDataGridViewTextBoxColumn");
            this.ogDataGridViewTextBoxColumn.Name = "ogDataGridViewTextBoxColumn";
            // 
            // ohDataGridViewTextBoxColumn
            // 
            this.ohDataGridViewTextBoxColumn.DataPropertyName = "oh";
            resources.ApplyResources(this.ohDataGridViewTextBoxColumn, "ohDataGridViewTextBoxColumn");
            this.ohDataGridViewTextBoxColumn.Name = "ohDataGridViewTextBoxColumn";
            // 
            // oiDataGridViewTextBoxColumn
            // 
            this.oiDataGridViewTextBoxColumn.DataPropertyName = "oi";
            resources.ApplyResources(this.oiDataGridViewTextBoxColumn, "oiDataGridViewTextBoxColumn");
            this.oiDataGridViewTextBoxColumn.Name = "oiDataGridViewTextBoxColumn";
            // 
            // ojDataGridViewTextBoxColumn
            // 
            this.ojDataGridViewTextBoxColumn.DataPropertyName = "oj";
            resources.ApplyResources(this.ojDataGridViewTextBoxColumn, "ojDataGridViewTextBoxColumn");
            this.ojDataGridViewTextBoxColumn.Name = "ojDataGridViewTextBoxColumn";
            // 
            // okDataGridViewTextBoxColumn
            // 
            this.okDataGridViewTextBoxColumn.DataPropertyName = "ok";
            resources.ApplyResources(this.okDataGridViewTextBoxColumn, "okDataGridViewTextBoxColumn");
            this.okDataGridViewTextBoxColumn.Name = "okDataGridViewTextBoxColumn";
            // 
            // olDataGridViewTextBoxColumn
            // 
            this.olDataGridViewTextBoxColumn.DataPropertyName = "ol";
            resources.ApplyResources(this.olDataGridViewTextBoxColumn, "olDataGridViewTextBoxColumn");
            this.olDataGridViewTextBoxColumn.Name = "olDataGridViewTextBoxColumn";
            // 
            // aaDataGridViewTextBoxColumn
            // 
            this.aaDataGridViewTextBoxColumn.DataPropertyName = "aa";
            resources.ApplyResources(this.aaDataGridViewTextBoxColumn, "aaDataGridViewTextBoxColumn");
            this.aaDataGridViewTextBoxColumn.Name = "aaDataGridViewTextBoxColumn";
            // 
            // abDataGridViewTextBoxColumn
            // 
            this.abDataGridViewTextBoxColumn.DataPropertyName = "ab";
            resources.ApplyResources(this.abDataGridViewTextBoxColumn, "abDataGridViewTextBoxColumn");
            this.abDataGridViewTextBoxColumn.Name = "abDataGridViewTextBoxColumn";
            // 
            // acDataGridViewTextBoxColumn
            // 
            this.acDataGridViewTextBoxColumn.DataPropertyName = "ac";
            resources.ApplyResources(this.acDataGridViewTextBoxColumn, "acDataGridViewTextBoxColumn");
            this.acDataGridViewTextBoxColumn.Name = "acDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            resources.ApplyResources(this.adDataGridViewTextBoxColumn, "adDataGridViewTextBoxColumn");
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // aeDataGridViewTextBoxColumn
            // 
            this.aeDataGridViewTextBoxColumn.DataPropertyName = "ae";
            resources.ApplyResources(this.aeDataGridViewTextBoxColumn, "aeDataGridViewTextBoxColumn");
            this.aeDataGridViewTextBoxColumn.Name = "aeDataGridViewTextBoxColumn";
            // 
            // afDataGridViewTextBoxColumn
            // 
            this.afDataGridViewTextBoxColumn.DataPropertyName = "af";
            resources.ApplyResources(this.afDataGridViewTextBoxColumn, "afDataGridViewTextBoxColumn");
            this.afDataGridViewTextBoxColumn.Name = "afDataGridViewTextBoxColumn";
            // 
            // agDataGridViewTextBoxColumn
            // 
            this.agDataGridViewTextBoxColumn.DataPropertyName = "ag";
            resources.ApplyResources(this.agDataGridViewTextBoxColumn, "agDataGridViewTextBoxColumn");
            this.agDataGridViewTextBoxColumn.Name = "agDataGridViewTextBoxColumn";
            // 
            // ahDataGridViewTextBoxColumn
            // 
            this.ahDataGridViewTextBoxColumn.DataPropertyName = "ah";
            resources.ApplyResources(this.ahDataGridViewTextBoxColumn, "ahDataGridViewTextBoxColumn");
            this.ahDataGridViewTextBoxColumn.Name = "ahDataGridViewTextBoxColumn";
            // 
            // aiDataGridViewTextBoxColumn
            // 
            this.aiDataGridViewTextBoxColumn.DataPropertyName = "ai";
            resources.ApplyResources(this.aiDataGridViewTextBoxColumn, "aiDataGridViewTextBoxColumn");
            this.aiDataGridViewTextBoxColumn.Name = "aiDataGridViewTextBoxColumn";
            // 
            // ajDataGridViewTextBoxColumn
            // 
            this.ajDataGridViewTextBoxColumn.DataPropertyName = "aj";
            resources.ApplyResources(this.ajDataGridViewTextBoxColumn, "ajDataGridViewTextBoxColumn");
            this.ajDataGridViewTextBoxColumn.Name = "ajDataGridViewTextBoxColumn";
            // 
            // akDataGridViewTextBoxColumn
            // 
            this.akDataGridViewTextBoxColumn.DataPropertyName = "ak";
            resources.ApplyResources(this.akDataGridViewTextBoxColumn, "akDataGridViewTextBoxColumn");
            this.akDataGridViewTextBoxColumn.Name = "akDataGridViewTextBoxColumn";
            // 
            // alDataGridViewTextBoxColumn
            // 
            this.alDataGridViewTextBoxColumn.DataPropertyName = "al";
            resources.ApplyResources(this.alDataGridViewTextBoxColumn, "alDataGridViewTextBoxColumn");
            this.alDataGridViewTextBoxColumn.Name = "alDataGridViewTextBoxColumn";
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "ca";
            resources.ApplyResources(this.caDataGridViewTextBoxColumn, "caDataGridViewTextBoxColumn");
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            // 
            // cbDataGridViewTextBoxColumn
            // 
            this.cbDataGridViewTextBoxColumn.DataPropertyName = "cb";
            resources.ApplyResources(this.cbDataGridViewTextBoxColumn, "cbDataGridViewTextBoxColumn");
            this.cbDataGridViewTextBoxColumn.Name = "cbDataGridViewTextBoxColumn";
            // 
            // ccDataGridViewTextBoxColumn
            // 
            this.ccDataGridViewTextBoxColumn.DataPropertyName = "cc";
            resources.ApplyResources(this.ccDataGridViewTextBoxColumn, "ccDataGridViewTextBoxColumn");
            this.ccDataGridViewTextBoxColumn.Name = "ccDataGridViewTextBoxColumn";
            // 
            // cdDataGridViewTextBoxColumn
            // 
            this.cdDataGridViewTextBoxColumn.DataPropertyName = "cd";
            resources.ApplyResources(this.cdDataGridViewTextBoxColumn, "cdDataGridViewTextBoxColumn");
            this.cdDataGridViewTextBoxColumn.Name = "cdDataGridViewTextBoxColumn";
            // 
            // ceDataGridViewTextBoxColumn
            // 
            this.ceDataGridViewTextBoxColumn.DataPropertyName = "ce";
            resources.ApplyResources(this.ceDataGridViewTextBoxColumn, "ceDataGridViewTextBoxColumn");
            this.ceDataGridViewTextBoxColumn.Name = "ceDataGridViewTextBoxColumn";
            // 
            // cfDataGridViewTextBoxColumn
            // 
            this.cfDataGridViewTextBoxColumn.DataPropertyName = "cf";
            resources.ApplyResources(this.cfDataGridViewTextBoxColumn, "cfDataGridViewTextBoxColumn");
            this.cfDataGridViewTextBoxColumn.Name = "cfDataGridViewTextBoxColumn";
            // 
            // cgDataGridViewTextBoxColumn
            // 
            this.cgDataGridViewTextBoxColumn.DataPropertyName = "cg";
            resources.ApplyResources(this.cgDataGridViewTextBoxColumn, "cgDataGridViewTextBoxColumn");
            this.cgDataGridViewTextBoxColumn.Name = "cgDataGridViewTextBoxColumn";
            // 
            // chDataGridViewTextBoxColumn
            // 
            this.chDataGridViewTextBoxColumn.DataPropertyName = "ch";
            resources.ApplyResources(this.chDataGridViewTextBoxColumn, "chDataGridViewTextBoxColumn");
            this.chDataGridViewTextBoxColumn.Name = "chDataGridViewTextBoxColumn";
            // 
            // ciDataGridViewTextBoxColumn
            // 
            this.ciDataGridViewTextBoxColumn.DataPropertyName = "ci";
            resources.ApplyResources(this.ciDataGridViewTextBoxColumn, "ciDataGridViewTextBoxColumn");
            this.ciDataGridViewTextBoxColumn.Name = "ciDataGridViewTextBoxColumn";
            // 
            // cjDataGridViewTextBoxColumn
            // 
            this.cjDataGridViewTextBoxColumn.DataPropertyName = "cj";
            resources.ApplyResources(this.cjDataGridViewTextBoxColumn, "cjDataGridViewTextBoxColumn");
            this.cjDataGridViewTextBoxColumn.Name = "cjDataGridViewTextBoxColumn";
            // 
            // ckDataGridViewTextBoxColumn
            // 
            this.ckDataGridViewTextBoxColumn.DataPropertyName = "ck";
            resources.ApplyResources(this.ckDataGridViewTextBoxColumn, "ckDataGridViewTextBoxColumn");
            this.ckDataGridViewTextBoxColumn.Name = "ckDataGridViewTextBoxColumn";
            // 
            // clDataGridViewTextBoxColumn
            // 
            this.clDataGridViewTextBoxColumn.DataPropertyName = "cl";
            resources.ApplyResources(this.clDataGridViewTextBoxColumn, "clDataGridViewTextBoxColumn");
            this.clDataGridViewTextBoxColumn.Name = "clDataGridViewTextBoxColumn";
            // 
            // dateNeoDataGridViewTextBoxColumn
            // 
            this.dateNeoDataGridViewTextBoxColumn.DataPropertyName = "DateNeo";
            resources.ApplyResources(this.dateNeoDataGridViewTextBoxColumn, "dateNeoDataGridViewTextBoxColumn");
            this.dateNeoDataGridViewTextBoxColumn.Name = "dateNeoDataGridViewTextBoxColumn";
            // 
            // meliDataGridViewTextBoxColumn
            // 
            this.meliDataGridViewTextBoxColumn.DataPropertyName = "Meli";
            resources.ApplyResources(this.meliDataGridViewTextBoxColumn, "meliDataGridViewTextBoxColumn");
            this.meliDataGridViewTextBoxColumn.Name = "meliDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            resources.ApplyResources(this.adressDataGridViewTextBoxColumn, "adressDataGridViewTextBoxColumn");
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // phoneHDataGridViewTextBoxColumn
            // 
            this.phoneHDataGridViewTextBoxColumn.DataPropertyName = "PhoneH";
            resources.ApplyResources(this.phoneHDataGridViewTextBoxColumn, "phoneHDataGridViewTextBoxColumn");
            this.phoneHDataGridViewTextBoxColumn.Name = "phoneHDataGridViewTextBoxColumn";
            // 
            // phoneMDataGridViewTextBoxColumn
            // 
            this.phoneMDataGridViewTextBoxColumn.DataPropertyName = "PhoneM";
            resources.ApplyResources(this.phoneMDataGridViewTextBoxColumn, "phoneMDataGridViewTextBoxColumn");
            this.phoneMDataGridViewTextBoxColumn.Name = "phoneMDataGridViewTextBoxColumn";
            // 
            // numberShDataGridViewTextBoxColumn
            // 
            this.numberShDataGridViewTextBoxColumn.DataPropertyName = "NumberSh";
            resources.ApplyResources(this.numberShDataGridViewTextBoxColumn, "numberShDataGridViewTextBoxColumn");
            this.numberShDataGridViewTextBoxColumn.Name = "numberShDataGridViewTextBoxColumn";
            // 
            // loEshDataGridViewTextBoxColumn
            // 
            this.loEshDataGridViewTextBoxColumn.DataPropertyName = "LoEsh";
            resources.ApplyResources(this.loEshDataGridViewTextBoxColumn, "loEshDataGridViewTextBoxColumn");
            this.loEshDataGridViewTextBoxColumn.Name = "loEshDataGridViewTextBoxColumn";
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            resources.ApplyResources(this.nDataGridViewTextBoxColumn, "nDataGridViewTextBoxColumn");
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "E";
            resources.ApplyResources(this.eDataGridViewTextBoxColumn, "eDataGridViewTextBoxColumn");
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            resources.ApplyResources(this.oDataGridViewTextBoxColumn, "oDataGridViewTextBoxColumn");
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            resources.ApplyResources(this.aDataGridViewTextBoxColumn, "aDataGridViewTextBoxColumn");
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            resources.ApplyResources(this.cDataGridViewTextBoxColumn, "cDataGridViewTextBoxColumn");
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            // 
            // pajDataGridViewTextBoxColumn
            // 
            this.pajDataGridViewTextBoxColumn.DataPropertyName = "paj";
            resources.ApplyResources(this.pajDataGridViewTextBoxColumn, "pajDataGridViewTextBoxColumn");
            this.pajDataGridViewTextBoxColumn.Name = "pajDataGridViewTextBoxColumn";
            // 
            // padDataGridViewTextBoxColumn
            // 
            this.padDataGridViewTextBoxColumn.DataPropertyName = "pad";
            resources.ApplyResources(this.padDataGridViewTextBoxColumn, "padDataGridViewTextBoxColumn");
            this.padDataGridViewTextBoxColumn.Name = "padDataGridViewTextBoxColumn";
            // 
            // pbaDataGridViewTextBoxColumn
            // 
            this.pbaDataGridViewTextBoxColumn.DataPropertyName = "pba";
            resources.ApplyResources(this.pbaDataGridViewTextBoxColumn, "pbaDataGridViewTextBoxColumn");
            this.pbaDataGridViewTextBoxColumn.Name = "pbaDataGridViewTextBoxColumn";
            // 
            // pbhDataGridViewTextBoxColumn
            // 
            this.pbhDataGridViewTextBoxColumn.DataPropertyName = "pbh";
            resources.ApplyResources(this.pbhDataGridViewTextBoxColumn, "pbhDataGridViewTextBoxColumn");
            this.pbhDataGridViewTextBoxColumn.Name = "pbhDataGridViewTextBoxColumn";
            // 
            // pcdDataGridViewTextBoxColumn
            // 
            this.pcdDataGridViewTextBoxColumn.DataPropertyName = "pcd";
            resources.ApplyResources(this.pcdDataGridViewTextBoxColumn, "pcdDataGridViewTextBoxColumn");
            this.pcdDataGridViewTextBoxColumn.Name = "pcdDataGridViewTextBoxColumn";
            // 
            // pchDataGridViewTextBoxColumn
            // 
            this.pchDataGridViewTextBoxColumn.DataPropertyName = "pch";
            resources.ApplyResources(this.pchDataGridViewTextBoxColumn, "pchDataGridViewTextBoxColumn");
            this.pchDataGridViewTextBoxColumn.Name = "pchDataGridViewTextBoxColumn";
            // 
            // pdbDataGridViewTextBoxColumn
            // 
            this.pdbDataGridViewTextBoxColumn.DataPropertyName = "pdb";
            resources.ApplyResources(this.pdbDataGridViewTextBoxColumn, "pdbDataGridViewTextBoxColumn");
            this.pdbDataGridViewTextBoxColumn.Name = "pdbDataGridViewTextBoxColumn";
            // 
            // pdjDataGridViewTextBoxColumn
            // 
            this.pdjDataGridViewTextBoxColumn.DataPropertyName = "pdj";
            resources.ApplyResources(this.pdjDataGridViewTextBoxColumn, "pdjDataGridViewTextBoxColumn");
            this.pdjDataGridViewTextBoxColumn.Name = "pdjDataGridViewTextBoxColumn";
            // 
            // pejDataGridViewTextBoxColumn
            // 
            this.pejDataGridViewTextBoxColumn.DataPropertyName = "pej";
            resources.ApplyResources(this.pejDataGridViewTextBoxColumn, "pejDataGridViewTextBoxColumn");
            this.pejDataGridViewTextBoxColumn.Name = "pejDataGridViewTextBoxColumn";
            // 
            // pehDataGridViewTextBoxColumn
            // 
            this.pehDataGridViewTextBoxColumn.DataPropertyName = "peh";
            resources.ApplyResources(this.pehDataGridViewTextBoxColumn, "pehDataGridViewTextBoxColumn");
            this.pehDataGridViewTextBoxColumn.Name = "pehDataGridViewTextBoxColumn";
            // 
            // pfaDataGridViewTextBoxColumn
            // 
            this.pfaDataGridViewTextBoxColumn.DataPropertyName = "pfa";
            resources.ApplyResources(this.pfaDataGridViewTextBoxColumn, "pfaDataGridViewTextBoxColumn");
            this.pfaDataGridViewTextBoxColumn.Name = "pfaDataGridViewTextBoxColumn";
            // 
            // pfbDataGridViewTextBoxColumn
            // 
            this.pfbDataGridViewTextBoxColumn.DataPropertyName = "pfb";
            resources.ApplyResources(this.pfbDataGridViewTextBoxColumn, "pfbDataGridViewTextBoxColumn");
            this.pfbDataGridViewTextBoxColumn.Name = "pfbDataGridViewTextBoxColumn";
            // 
            // pgjDataGridViewTextBoxColumn
            // 
            this.pgjDataGridViewTextBoxColumn.DataPropertyName = "pgj";
            resources.ApplyResources(this.pgjDataGridViewTextBoxColumn, "pgjDataGridViewTextBoxColumn");
            this.pgjDataGridViewTextBoxColumn.Name = "pgjDataGridViewTextBoxColumn";
            // 
            // pghDataGridViewTextBoxColumn
            // 
            this.pghDataGridViewTextBoxColumn.DataPropertyName = "pgh";
            resources.ApplyResources(this.pghDataGridViewTextBoxColumn, "pghDataGridViewTextBoxColumn");
            this.pghDataGridViewTextBoxColumn.Name = "pghDataGridViewTextBoxColumn";
            // 
            // phaDataGridViewTextBoxColumn
            // 
            this.phaDataGridViewTextBoxColumn.DataPropertyName = "pha";
            resources.ApplyResources(this.phaDataGridViewTextBoxColumn, "phaDataGridViewTextBoxColumn");
            this.phaDataGridViewTextBoxColumn.Name = "phaDataGridViewTextBoxColumn";
            // 
            // phbDataGridViewTextBoxColumn
            // 
            this.phbDataGridViewTextBoxColumn.DataPropertyName = "phb";
            resources.ApplyResources(this.phbDataGridViewTextBoxColumn, "phbDataGridViewTextBoxColumn");
            this.phbDataGridViewTextBoxColumn.Name = "phbDataGridViewTextBoxColumn";
            // 
            // piaDataGridViewTextBoxColumn
            // 
            this.piaDataGridViewTextBoxColumn.DataPropertyName = "pia";
            resources.ApplyResources(this.piaDataGridViewTextBoxColumn, "piaDataGridViewTextBoxColumn");
            this.piaDataGridViewTextBoxColumn.Name = "piaDataGridViewTextBoxColumn";
            // 
            // pihDataGridViewTextBoxColumn
            // 
            this.pihDataGridViewTextBoxColumn.DataPropertyName = "pih";
            resources.ApplyResources(this.pihDataGridViewTextBoxColumn, "pihDataGridViewTextBoxColumn");
            this.pihDataGridViewTextBoxColumn.Name = "pihDataGridViewTextBoxColumn";
            // 
            // pjbDataGridViewTextBoxColumn
            // 
            this.pjbDataGridViewTextBoxColumn.DataPropertyName = "pjb";
            resources.ApplyResources(this.pjbDataGridViewTextBoxColumn, "pjbDataGridViewTextBoxColumn");
            this.pjbDataGridViewTextBoxColumn.Name = "pjbDataGridViewTextBoxColumn";
            // 
            // pjhDataGridViewTextBoxColumn
            // 
            this.pjhDataGridViewTextBoxColumn.DataPropertyName = "pjh";
            resources.ApplyResources(this.pjhDataGridViewTextBoxColumn, "pjhDataGridViewTextBoxColumn");
            this.pjhDataGridViewTextBoxColumn.Name = "pjhDataGridViewTextBoxColumn";
            // 
            // pkaDataGridViewTextBoxColumn
            // 
            this.pkaDataGridViewTextBoxColumn.DataPropertyName = "pka";
            resources.ApplyResources(this.pkaDataGridViewTextBoxColumn, "pkaDataGridViewTextBoxColumn");
            this.pkaDataGridViewTextBoxColumn.Name = "pkaDataGridViewTextBoxColumn";
            // 
            // pkdDataGridViewTextBoxColumn
            // 
            this.pkdDataGridViewTextBoxColumn.DataPropertyName = "pkd";
            resources.ApplyResources(this.pkdDataGridViewTextBoxColumn, "pkdDataGridViewTextBoxColumn");
            this.pkdDataGridViewTextBoxColumn.Name = "pkdDataGridViewTextBoxColumn";
            // 
            // pldDataGridViewTextBoxColumn
            // 
            this.pldDataGridViewTextBoxColumn.DataPropertyName = "pld";
            resources.ApplyResources(this.pldDataGridViewTextBoxColumn, "pldDataGridViewTextBoxColumn");
            this.pldDataGridViewTextBoxColumn.Name = "pldDataGridViewTextBoxColumn";
            // 
            // plhDataGridViewTextBoxColumn
            // 
            this.plhDataGridViewTextBoxColumn.DataPropertyName = "plh";
            resources.ApplyResources(this.plhDataGridViewTextBoxColumn, "plhDataGridViewTextBoxColumn");
            this.plhDataGridViewTextBoxColumn.Name = "plhDataGridViewTextBoxColumn";
            // 
            // pmbDataGridViewTextBoxColumn
            // 
            this.pmbDataGridViewTextBoxColumn.DataPropertyName = "pmb";
            resources.ApplyResources(this.pmbDataGridViewTextBoxColumn, "pmbDataGridViewTextBoxColumn");
            this.pmbDataGridViewTextBoxColumn.Name = "pmbDataGridViewTextBoxColumn";
            // 
            // pmhDataGridViewTextBoxColumn
            // 
            this.pmhDataGridViewTextBoxColumn.DataPropertyName = "pmh";
            resources.ApplyResources(this.pmhDataGridViewTextBoxColumn, "pmhDataGridViewTextBoxColumn");
            this.pmhDataGridViewTextBoxColumn.Name = "pmhDataGridViewTextBoxColumn";
            // 
            // pnjDataGridViewTextBoxColumn
            // 
            this.pnjDataGridViewTextBoxColumn.DataPropertyName = "pnj";
            resources.ApplyResources(this.pnjDataGridViewTextBoxColumn, "pnjDataGridViewTextBoxColumn");
            this.pnjDataGridViewTextBoxColumn.Name = "pnjDataGridViewTextBoxColumn";
            // 
            // pndDataGridViewTextBoxColumn
            // 
            this.pndDataGridViewTextBoxColumn.DataPropertyName = "pnd";
            resources.ApplyResources(this.pndDataGridViewTextBoxColumn, "pndDataGridViewTextBoxColumn");
            this.pndDataGridViewTextBoxColumn.Name = "pndDataGridViewTextBoxColumn";
            // 
            // ppbDataGridViewTextBoxColumn
            // 
            this.ppbDataGridViewTextBoxColumn.DataPropertyName = "ppb";
            resources.ApplyResources(this.ppbDataGridViewTextBoxColumn, "ppbDataGridViewTextBoxColumn");
            this.ppbDataGridViewTextBoxColumn.Name = "ppbDataGridViewTextBoxColumn";
            // 
            // ppdDataGridViewTextBoxColumn
            // 
            this.ppdDataGridViewTextBoxColumn.DataPropertyName = "ppd";
            resources.ApplyResources(this.ppdDataGridViewTextBoxColumn, "ppdDataGridViewTextBoxColumn");
            this.ppdDataGridViewTextBoxColumn.Name = "ppdDataGridViewTextBoxColumn";
            // 
            // poaDataGridViewTextBoxColumn
            // 
            this.poaDataGridViewTextBoxColumn.DataPropertyName = "poa";
            resources.ApplyResources(this.poaDataGridViewTextBoxColumn, "poaDataGridViewTextBoxColumn");
            this.poaDataGridViewTextBoxColumn.Name = "poaDataGridViewTextBoxColumn";
            // 
            // podDataGridViewTextBoxColumn
            // 
            this.podDataGridViewTextBoxColumn.DataPropertyName = "pod";
            resources.ApplyResources(this.podDataGridViewTextBoxColumn, "podDataGridViewTextBoxColumn");
            this.podDataGridViewTextBoxColumn.Name = "podDataGridViewTextBoxColumn";
            // 
            // pqbDataGridViewTextBoxColumn
            // 
            this.pqbDataGridViewTextBoxColumn.DataPropertyName = "pqb";
            resources.ApplyResources(this.pqbDataGridViewTextBoxColumn, "pqbDataGridViewTextBoxColumn");
            this.pqbDataGridViewTextBoxColumn.Name = "pqbDataGridViewTextBoxColumn";
            // 
            // pqjDataGridViewTextBoxColumn
            // 
            this.pqjDataGridViewTextBoxColumn.DataPropertyName = "pqj";
            resources.ApplyResources(this.pqjDataGridViewTextBoxColumn, "pqjDataGridViewTextBoxColumn");
            this.pqjDataGridViewTextBoxColumn.Name = "pqjDataGridViewTextBoxColumn";
            // 
            // puaDataGridViewTextBoxColumn
            // 
            this.puaDataGridViewTextBoxColumn.DataPropertyName = "pua";
            resources.ApplyResources(this.puaDataGridViewTextBoxColumn, "puaDataGridViewTextBoxColumn");
            this.puaDataGridViewTextBoxColumn.Name = "puaDataGridViewTextBoxColumn";
            // 
            // pujDataGridViewTextBoxColumn
            // 
            this.pujDataGridViewTextBoxColumn.DataPropertyName = "puj";
            resources.ApplyResources(this.pujDataGridViewTextBoxColumn, "pujDataGridViewTextBoxColumn");
            this.pujDataGridViewTextBoxColumn.Name = "pujDataGridViewTextBoxColumn";
            // 
            // pwaDataGridViewTextBoxColumn
            // 
            this.pwaDataGridViewTextBoxColumn.DataPropertyName = "pwa";
            resources.ApplyResources(this.pwaDataGridViewTextBoxColumn, "pwaDataGridViewTextBoxColumn");
            this.pwaDataGridViewTextBoxColumn.Name = "pwaDataGridViewTextBoxColumn";
            // 
            // pwjDataGridViewTextBoxColumn
            // 
            this.pwjDataGridViewTextBoxColumn.DataPropertyName = "pwj";
            resources.ApplyResources(this.pwjDataGridViewTextBoxColumn, "pwjDataGridViewTextBoxColumn");
            this.pwjDataGridViewTextBoxColumn.Name = "pwjDataGridViewTextBoxColumn";
            // 
            // pxbDataGridViewTextBoxColumn
            // 
            this.pxbDataGridViewTextBoxColumn.DataPropertyName = "pxb";
            resources.ApplyResources(this.pxbDataGridViewTextBoxColumn, "pxbDataGridViewTextBoxColumn");
            this.pxbDataGridViewTextBoxColumn.Name = "pxbDataGridViewTextBoxColumn";
            // 
            // pxdDataGridViewTextBoxColumn
            // 
            this.pxdDataGridViewTextBoxColumn.DataPropertyName = "pxd";
            resources.ApplyResources(this.pxdDataGridViewTextBoxColumn, "pxdDataGridViewTextBoxColumn");
            this.pxdDataGridViewTextBoxColumn.Name = "pxdDataGridViewTextBoxColumn";
            // 
            // pADataGridViewTextBoxColumn
            // 
            this.pADataGridViewTextBoxColumn.DataPropertyName = "PA";
            resources.ApplyResources(this.pADataGridViewTextBoxColumn, "pADataGridViewTextBoxColumn");
            this.pADataGridViewTextBoxColumn.Name = "pADataGridViewTextBoxColumn";
            // 
            // pBDataGridViewTextBoxColumn
            // 
            this.pBDataGridViewTextBoxColumn.DataPropertyName = "PB";
            resources.ApplyResources(this.pBDataGridViewTextBoxColumn, "pBDataGridViewTextBoxColumn");
            this.pBDataGridViewTextBoxColumn.Name = "pBDataGridViewTextBoxColumn";
            // 
            // pJDataGridViewTextBoxColumn
            // 
            this.pJDataGridViewTextBoxColumn.DataPropertyName = "PJ";
            resources.ApplyResources(this.pJDataGridViewTextBoxColumn, "pJDataGridViewTextBoxColumn");
            this.pJDataGridViewTextBoxColumn.Name = "pJDataGridViewTextBoxColumn";
            // 
            // pDDataGridViewTextBoxColumn
            // 
            this.pDDataGridViewTextBoxColumn.DataPropertyName = "PD";
            resources.ApplyResources(this.pDDataGridViewTextBoxColumn, "pDDataGridViewTextBoxColumn");
            this.pDDataGridViewTextBoxColumn.Name = "pDDataGridViewTextBoxColumn";
            // 
            // pHDataGridViewTextBoxColumn
            // 
            this.pHDataGridViewTextBoxColumn.DataPropertyName = "PH";
            resources.ApplyResources(this.pHDataGridViewTextBoxColumn, "pHDataGridViewTextBoxColumn");
            this.pHDataGridViewTextBoxColumn.Name = "pHDataGridViewTextBoxColumn";
            // 
            // shoghlNextDataGridViewTextBoxColumn
            // 
            this.shoghlNextDataGridViewTextBoxColumn.DataPropertyName = "ShoghlNext";
            resources.ApplyResources(this.shoghlNextDataGridViewTextBoxColumn, "shoghlNextDataGridViewTextBoxColumn");
            this.shoghlNextDataGridViewTextBoxColumn.Name = "shoghlNextDataGridViewTextBoxColumn";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.groupBox51);
            this.tabPage6.Controls.Add(this.groupBox52);
            this.tabPage6.Controls.Add(this.groupBox53);
            this.tabPage6.Controls.Add(this.groupBox54);
            this.tabPage6.Controls.Add(this.groupBox55);
            this.tabPage6.Controls.Add(this.groupBox56);
            this.tabPage6.Controls.Add(this.groupBox57);
            this.tabPage6.Controls.Add(this.groupBox58);
            this.tabPage6.Controls.Add(this.groupBox59);
            this.tabPage6.Controls.Add(this.groupBox60);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox51
            // 
            this.groupBox51.Controls.Add(this.textBox51);
            this.groupBox51.Controls.Add(this.label102);
            this.groupBox51.Controls.Add(this.label103);
            this.groupBox51.Controls.Add(this.radioButton251);
            this.groupBox51.Controls.Add(this.radioButton252);
            this.groupBox51.Controls.Add(this.radioButton253);
            this.groupBox51.Controls.Add(this.radioButton254);
            this.groupBox51.Controls.Add(this.radioButton255);
            resources.ApplyResources(this.groupBox51, "groupBox51");
            this.groupBox51.Name = "groupBox51";
            this.groupBox51.TabStop = false;
            // 
            // textBox51
            // 
            resources.ApplyResources(this.textBox51, "textBox51");
            this.textBox51.Name = "textBox51";
            this.textBox51.TextChanged += new System.EventHandler(this.textBox51_TextChanged);
            // 
            // label102
            // 
            resources.ApplyResources(this.label102, "label102");
            this.label102.Name = "label102";
            // 
            // label103
            // 
            resources.ApplyResources(this.label103, "label103");
            this.label103.Name = "label103";
            // 
            // radioButton251
            // 
            resources.ApplyResources(this.radioButton251, "radioButton251");
            this.radioButton251.Name = "radioButton251";
            this.radioButton251.TabStop = true;
            this.radioButton251.UseVisualStyleBackColor = true;
            this.radioButton251.CheckedChanged += new System.EventHandler(this.radioButton251_CheckedChanged);
            // 
            // radioButton252
            // 
            resources.ApplyResources(this.radioButton252, "radioButton252");
            this.radioButton252.Name = "radioButton252";
            this.radioButton252.TabStop = true;
            this.radioButton252.UseVisualStyleBackColor = true;
            this.radioButton252.CheckedChanged += new System.EventHandler(this.radioButton252_CheckedChanged);
            // 
            // radioButton253
            // 
            resources.ApplyResources(this.radioButton253, "radioButton253");
            this.radioButton253.Name = "radioButton253";
            this.radioButton253.TabStop = true;
            this.radioButton253.UseVisualStyleBackColor = true;
            this.radioButton253.CheckedChanged += new System.EventHandler(this.radioButton253_CheckedChanged);
            // 
            // radioButton254
            // 
            resources.ApplyResources(this.radioButton254, "radioButton254");
            this.radioButton254.Name = "radioButton254";
            this.radioButton254.TabStop = true;
            this.radioButton254.UseVisualStyleBackColor = true;
            this.radioButton254.CheckedChanged += new System.EventHandler(this.radioButton254_CheckedChanged);
            // 
            // radioButton255
            // 
            resources.ApplyResources(this.radioButton255, "radioButton255");
            this.radioButton255.Name = "radioButton255";
            this.radioButton255.TabStop = true;
            this.radioButton255.UseVisualStyleBackColor = true;
            this.radioButton255.CheckedChanged += new System.EventHandler(this.radioButton255_CheckedChanged);
            // 
            // groupBox52
            // 
            this.groupBox52.Controls.Add(this.textBox56);
            this.groupBox52.Controls.Add(this.label101);
            this.groupBox52.Controls.Add(this.label106);
            this.groupBox52.Controls.Add(this.radioButton263);
            this.groupBox52.Controls.Add(this.radioButton264);
            this.groupBox52.Controls.Add(this.radioButton265);
            this.groupBox52.Controls.Add(this.radioButton266);
            this.groupBox52.Controls.Add(this.radioButton267);
            resources.ApplyResources(this.groupBox52, "groupBox52");
            this.groupBox52.Name = "groupBox52";
            this.groupBox52.TabStop = false;
            // 
            // textBox56
            // 
            resources.ApplyResources(this.textBox56, "textBox56");
            this.textBox56.Name = "textBox56";
            this.textBox56.TextChanged += new System.EventHandler(this.textBox56_TextChanged);
            // 
            // label101
            // 
            resources.ApplyResources(this.label101, "label101");
            this.label101.Name = "label101";
            // 
            // label106
            // 
            resources.ApplyResources(this.label106, "label106");
            this.label106.Name = "label106";
            // 
            // radioButton263
            // 
            resources.ApplyResources(this.radioButton263, "radioButton263");
            this.radioButton263.Name = "radioButton263";
            this.radioButton263.TabStop = true;
            this.radioButton263.UseVisualStyleBackColor = true;
            this.radioButton263.CheckedChanged += new System.EventHandler(this.radioButton263_CheckedChanged);
            // 
            // radioButton264
            // 
            resources.ApplyResources(this.radioButton264, "radioButton264");
            this.radioButton264.Name = "radioButton264";
            this.radioButton264.TabStop = true;
            this.radioButton264.UseVisualStyleBackColor = true;
            this.radioButton264.CheckedChanged += new System.EventHandler(this.radioButton264_CheckedChanged);
            // 
            // radioButton265
            // 
            resources.ApplyResources(this.radioButton265, "radioButton265");
            this.radioButton265.Name = "radioButton265";
            this.radioButton265.TabStop = true;
            this.radioButton265.UseVisualStyleBackColor = true;
            this.radioButton265.CheckedChanged += new System.EventHandler(this.radioButton265_CheckedChanged);
            // 
            // radioButton266
            // 
            resources.ApplyResources(this.radioButton266, "radioButton266");
            this.radioButton266.Name = "radioButton266";
            this.radioButton266.TabStop = true;
            this.radioButton266.UseVisualStyleBackColor = true;
            this.radioButton266.CheckedChanged += new System.EventHandler(this.radioButton266_CheckedChanged);
            // 
            // radioButton267
            // 
            resources.ApplyResources(this.radioButton267, "radioButton267");
            this.radioButton267.Name = "radioButton267";
            this.radioButton267.TabStop = true;
            this.radioButton267.UseVisualStyleBackColor = true;
            this.radioButton267.CheckedChanged += new System.EventHandler(this.radioButton267_CheckedChanged);
            // 
            // groupBox53
            // 
            this.groupBox53.Controls.Add(this.textBox54);
            this.groupBox53.Controls.Add(this.label107);
            this.groupBox53.Controls.Add(this.label108);
            this.groupBox53.Controls.Add(this.radioButton269);
            this.groupBox53.Controls.Add(this.radioButton270);
            this.groupBox53.Controls.Add(this.radioButton271);
            this.groupBox53.Controls.Add(this.radioButton275);
            this.groupBox53.Controls.Add(this.radioButton272);
            resources.ApplyResources(this.groupBox53, "groupBox53");
            this.groupBox53.Name = "groupBox53";
            this.groupBox53.TabStop = false;
            // 
            // textBox54
            // 
            resources.ApplyResources(this.textBox54, "textBox54");
            this.textBox54.Name = "textBox54";
            this.textBox54.TextChanged += new System.EventHandler(this.textBox54_TextChanged);
            // 
            // label107
            // 
            resources.ApplyResources(this.label107, "label107");
            this.label107.Name = "label107";
            // 
            // label108
            // 
            resources.ApplyResources(this.label108, "label108");
            this.label108.Name = "label108";
            // 
            // radioButton269
            // 
            resources.ApplyResources(this.radioButton269, "radioButton269");
            this.radioButton269.Name = "radioButton269";
            this.radioButton269.TabStop = true;
            this.radioButton269.UseVisualStyleBackColor = true;
            this.radioButton269.CheckedChanged += new System.EventHandler(this.radioButton269_CheckedChanged);
            // 
            // radioButton270
            // 
            resources.ApplyResources(this.radioButton270, "radioButton270");
            this.radioButton270.Name = "radioButton270";
            this.radioButton270.TabStop = true;
            this.radioButton270.UseVisualStyleBackColor = true;
            this.radioButton270.CheckedChanged += new System.EventHandler(this.radioButton270_CheckedChanged);
            // 
            // radioButton271
            // 
            resources.ApplyResources(this.radioButton271, "radioButton271");
            this.radioButton271.Name = "radioButton271";
            this.radioButton271.TabStop = true;
            this.radioButton271.UseVisualStyleBackColor = true;
            this.radioButton271.CheckedChanged += new System.EventHandler(this.radioButton271_CheckedChanged);
            // 
            // radioButton275
            // 
            resources.ApplyResources(this.radioButton275, "radioButton275");
            this.radioButton275.Name = "radioButton275";
            this.radioButton275.TabStop = true;
            this.radioButton275.UseVisualStyleBackColor = true;
            this.radioButton275.CheckedChanged += new System.EventHandler(this.radioButton275_CheckedChanged);
            // 
            // radioButton272
            // 
            resources.ApplyResources(this.radioButton272, "radioButton272");
            this.radioButton272.Name = "radioButton272";
            this.radioButton272.TabStop = true;
            this.radioButton272.UseVisualStyleBackColor = true;
            this.radioButton272.CheckedChanged += new System.EventHandler(this.radioButton272_CheckedChanged);
            // 
            // groupBox54
            // 
            this.groupBox54.Controls.Add(this.textBox55);
            this.groupBox54.Controls.Add(this.label109);
            this.groupBox54.Controls.Add(this.label110);
            this.groupBox54.Controls.Add(this.radioButton273);
            this.groupBox54.Controls.Add(this.radioButton274);
            this.groupBox54.Controls.Add(this.radioButton276);
            this.groupBox54.Controls.Add(this.radioButton279);
            this.groupBox54.Controls.Add(this.radioButton277);
            resources.ApplyResources(this.groupBox54, "groupBox54");
            this.groupBox54.Name = "groupBox54";
            this.groupBox54.TabStop = false;
            // 
            // textBox55
            // 
            resources.ApplyResources(this.textBox55, "textBox55");
            this.textBox55.Name = "textBox55";
            this.textBox55.TextChanged += new System.EventHandler(this.textBox55_TextChanged);
            // 
            // label109
            // 
            resources.ApplyResources(this.label109, "label109");
            this.label109.Name = "label109";
            // 
            // label110
            // 
            resources.ApplyResources(this.label110, "label110");
            this.label110.Name = "label110";
            // 
            // radioButton273
            // 
            resources.ApplyResources(this.radioButton273, "radioButton273");
            this.radioButton273.Name = "radioButton273";
            this.radioButton273.TabStop = true;
            this.radioButton273.UseVisualStyleBackColor = true;
            this.radioButton273.CheckedChanged += new System.EventHandler(this.radioButton273_CheckedChanged);
            // 
            // radioButton274
            // 
            resources.ApplyResources(this.radioButton274, "radioButton274");
            this.radioButton274.Name = "radioButton274";
            this.radioButton274.TabStop = true;
            this.radioButton274.UseVisualStyleBackColor = true;
            this.radioButton274.CheckedChanged += new System.EventHandler(this.radioButton274_CheckedChanged);
            // 
            // radioButton276
            // 
            resources.ApplyResources(this.radioButton276, "radioButton276");
            this.radioButton276.Name = "radioButton276";
            this.radioButton276.TabStop = true;
            this.radioButton276.UseVisualStyleBackColor = true;
            this.radioButton276.CheckedChanged += new System.EventHandler(this.radioButton276_CheckedChanged);
            // 
            // radioButton279
            // 
            resources.ApplyResources(this.radioButton279, "radioButton279");
            this.radioButton279.Name = "radioButton279";
            this.radioButton279.TabStop = true;
            this.radioButton279.UseVisualStyleBackColor = true;
            this.radioButton279.CheckedChanged += new System.EventHandler(this.radioButton279_CheckedChanged);
            // 
            // radioButton277
            // 
            resources.ApplyResources(this.radioButton277, "radioButton277");
            this.radioButton277.Name = "radioButton277";
            this.radioButton277.TabStop = true;
            this.radioButton277.UseVisualStyleBackColor = true;
            this.radioButton277.CheckedChanged += new System.EventHandler(this.radioButton277_CheckedChanged);
            // 
            // groupBox55
            // 
            this.groupBox55.Controls.Add(this.textBox57);
            this.groupBox55.Controls.Add(this.label114);
            this.groupBox55.Controls.Add(this.label115);
            this.groupBox55.Controls.Add(this.radioButton286);
            this.groupBox55.Controls.Add(this.radioButton287);
            this.groupBox55.Controls.Add(this.radioButton288);
            this.groupBox55.Controls.Add(this.radioButton289);
            this.groupBox55.Controls.Add(this.radioButton290);
            resources.ApplyResources(this.groupBox55, "groupBox55");
            this.groupBox55.Name = "groupBox55";
            this.groupBox55.TabStop = false;
            // 
            // textBox57
            // 
            resources.ApplyResources(this.textBox57, "textBox57");
            this.textBox57.Name = "textBox57";
            this.textBox57.TextChanged += new System.EventHandler(this.textBox57_TextChanged);
            // 
            // label114
            // 
            resources.ApplyResources(this.label114, "label114");
            this.label114.Name = "label114";
            // 
            // label115
            // 
            resources.ApplyResources(this.label115, "label115");
            this.label115.Name = "label115";
            // 
            // radioButton286
            // 
            resources.ApplyResources(this.radioButton286, "radioButton286");
            this.radioButton286.Name = "radioButton286";
            this.radioButton286.TabStop = true;
            this.radioButton286.UseVisualStyleBackColor = true;
            this.radioButton286.CheckedChanged += new System.EventHandler(this.radioButton286_CheckedChanged);
            // 
            // radioButton287
            // 
            resources.ApplyResources(this.radioButton287, "radioButton287");
            this.radioButton287.Name = "radioButton287";
            this.radioButton287.TabStop = true;
            this.radioButton287.UseVisualStyleBackColor = true;
            this.radioButton287.CheckedChanged += new System.EventHandler(this.radioButton287_CheckedChanged);
            // 
            // radioButton288
            // 
            resources.ApplyResources(this.radioButton288, "radioButton288");
            this.radioButton288.Name = "radioButton288";
            this.radioButton288.TabStop = true;
            this.radioButton288.UseVisualStyleBackColor = true;
            this.radioButton288.CheckedChanged += new System.EventHandler(this.radioButton288_CheckedChanged);
            // 
            // radioButton289
            // 
            resources.ApplyResources(this.radioButton289, "radioButton289");
            this.radioButton289.Name = "radioButton289";
            this.radioButton289.TabStop = true;
            this.radioButton289.UseVisualStyleBackColor = true;
            this.radioButton289.CheckedChanged += new System.EventHandler(this.radioButton289_CheckedChanged);
            // 
            // radioButton290
            // 
            resources.ApplyResources(this.radioButton290, "radioButton290");
            this.radioButton290.Name = "radioButton290";
            this.radioButton290.TabStop = true;
            this.radioButton290.UseVisualStyleBackColor = true;
            this.radioButton290.CheckedChanged += new System.EventHandler(this.radioButton290_CheckedChanged);
            // 
            // groupBox56
            // 
            this.groupBox56.Controls.Add(this.textBox58);
            this.groupBox56.Controls.Add(this.label112);
            this.groupBox56.Controls.Add(this.label113);
            this.groupBox56.Controls.Add(this.radioButton281);
            this.groupBox56.Controls.Add(this.radioButton282);
            this.groupBox56.Controls.Add(this.radioButton283);
            this.groupBox56.Controls.Add(this.radioButton284);
            this.groupBox56.Controls.Add(this.radioButton285);
            resources.ApplyResources(this.groupBox56, "groupBox56");
            this.groupBox56.Name = "groupBox56";
            this.groupBox56.TabStop = false;
            // 
            // textBox58
            // 
            resources.ApplyResources(this.textBox58, "textBox58");
            this.textBox58.Name = "textBox58";
            this.textBox58.TextChanged += new System.EventHandler(this.textBox58_TextChanged);
            // 
            // label112
            // 
            resources.ApplyResources(this.label112, "label112");
            this.label112.Name = "label112";
            // 
            // label113
            // 
            resources.ApplyResources(this.label113, "label113");
            this.label113.Name = "label113";
            // 
            // radioButton281
            // 
            resources.ApplyResources(this.radioButton281, "radioButton281");
            this.radioButton281.Name = "radioButton281";
            this.radioButton281.TabStop = true;
            this.radioButton281.UseVisualStyleBackColor = true;
            this.radioButton281.CheckedChanged += new System.EventHandler(this.radioButton281_CheckedChanged);
            // 
            // radioButton282
            // 
            resources.ApplyResources(this.radioButton282, "radioButton282");
            this.radioButton282.Name = "radioButton282";
            this.radioButton282.TabStop = true;
            this.radioButton282.UseVisualStyleBackColor = true;
            this.radioButton282.CheckedChanged += new System.EventHandler(this.radioButton282_CheckedChanged);
            // 
            // radioButton283
            // 
            resources.ApplyResources(this.radioButton283, "radioButton283");
            this.radioButton283.Name = "radioButton283";
            this.radioButton283.TabStop = true;
            this.radioButton283.UseVisualStyleBackColor = true;
            this.radioButton283.CheckedChanged += new System.EventHandler(this.radioButton283_CheckedChanged);
            // 
            // radioButton284
            // 
            resources.ApplyResources(this.radioButton284, "radioButton284");
            this.radioButton284.Name = "radioButton284";
            this.radioButton284.TabStop = true;
            this.radioButton284.UseVisualStyleBackColor = true;
            this.radioButton284.CheckedChanged += new System.EventHandler(this.radioButton284_CheckedChanged);
            // 
            // radioButton285
            // 
            resources.ApplyResources(this.radioButton285, "radioButton285");
            this.radioButton285.Name = "radioButton285";
            this.radioButton285.TabStop = true;
            this.radioButton285.UseVisualStyleBackColor = true;
            this.radioButton285.CheckedChanged += new System.EventHandler(this.radioButton285_CheckedChanged);
            // 
            // groupBox57
            // 
            this.groupBox57.Controls.Add(this.txtC);
            this.groupBox57.Controls.Add(this.textBox60);
            this.groupBox57.Controls.Add(this.label116);
            this.groupBox57.Controls.Add(this.label117);
            this.groupBox57.Controls.Add(this.radioButton291);
            this.groupBox57.Controls.Add(this.radioButton292);
            this.groupBox57.Controls.Add(this.radioButton293);
            this.groupBox57.Controls.Add(this.radioButton294);
            this.groupBox57.Controls.Add(this.radioButton295);
            resources.ApplyResources(this.groupBox57, "groupBox57");
            this.groupBox57.Name = "groupBox57";
            this.groupBox57.TabStop = false;
            // 
            // txtC
            // 
            resources.ApplyResources(this.txtC, "txtC");
            this.txtC.Name = "txtC";
            // 
            // textBox60
            // 
            resources.ApplyResources(this.textBox60, "textBox60");
            this.textBox60.Name = "textBox60";
            this.textBox60.TextChanged += new System.EventHandler(this.textBox60_TextChanged);
            // 
            // label116
            // 
            resources.ApplyResources(this.label116, "label116");
            this.label116.Name = "label116";
            // 
            // label117
            // 
            resources.ApplyResources(this.label117, "label117");
            this.label117.Name = "label117";
            // 
            // radioButton291
            // 
            resources.ApplyResources(this.radioButton291, "radioButton291");
            this.radioButton291.Name = "radioButton291";
            this.radioButton291.TabStop = true;
            this.radioButton291.UseVisualStyleBackColor = true;
            this.radioButton291.CheckedChanged += new System.EventHandler(this.radioButton291_CheckedChanged);
            // 
            // radioButton292
            // 
            resources.ApplyResources(this.radioButton292, "radioButton292");
            this.radioButton292.Name = "radioButton292";
            this.radioButton292.TabStop = true;
            this.radioButton292.UseVisualStyleBackColor = true;
            this.radioButton292.CheckedChanged += new System.EventHandler(this.radioButton292_CheckedChanged);
            // 
            // radioButton293
            // 
            resources.ApplyResources(this.radioButton293, "radioButton293");
            this.radioButton293.Name = "radioButton293";
            this.radioButton293.TabStop = true;
            this.radioButton293.UseVisualStyleBackColor = true;
            this.radioButton293.CheckedChanged += new System.EventHandler(this.radioButton293_CheckedChanged);
            // 
            // radioButton294
            // 
            resources.ApplyResources(this.radioButton294, "radioButton294");
            this.radioButton294.Name = "radioButton294";
            this.radioButton294.TabStop = true;
            this.radioButton294.UseVisualStyleBackColor = true;
            this.radioButton294.CheckedChanged += new System.EventHandler(this.radioButton294_CheckedChanged);
            // 
            // radioButton295
            // 
            resources.ApplyResources(this.radioButton295, "radioButton295");
            this.radioButton295.Name = "radioButton295";
            this.radioButton295.TabStop = true;
            this.radioButton295.UseVisualStyleBackColor = true;
            this.radioButton295.CheckedChanged += new System.EventHandler(this.radioButton295_CheckedChanged);
            // 
            // groupBox58
            // 
            this.groupBox58.Controls.Add(this.textBox52);
            this.groupBox58.Controls.Add(this.label118);
            this.groupBox58.Controls.Add(this.label111);
            this.groupBox58.Controls.Add(this.radioButton256);
            this.groupBox58.Controls.Add(this.radioButton278);
            this.groupBox58.Controls.Add(this.radioButton262);
            this.groupBox58.Controls.Add(this.radioButton257);
            this.groupBox58.Controls.Add(this.radioButton268);
            resources.ApplyResources(this.groupBox58, "groupBox58");
            this.groupBox58.Name = "groupBox58";
            this.groupBox58.TabStop = false;
            // 
            // textBox52
            // 
            resources.ApplyResources(this.textBox52, "textBox52");
            this.textBox52.Name = "textBox52";
            this.textBox52.TextChanged += new System.EventHandler(this.textBox52_TextChanged);
            // 
            // label118
            // 
            resources.ApplyResources(this.label118, "label118");
            this.label118.Name = "label118";
            // 
            // label111
            // 
            resources.ApplyResources(this.label111, "label111");
            this.label111.Name = "label111";
            // 
            // radioButton256
            // 
            resources.ApplyResources(this.radioButton256, "radioButton256");
            this.radioButton256.Name = "radioButton256";
            this.radioButton256.TabStop = true;
            this.radioButton256.UseVisualStyleBackColor = true;
            this.radioButton256.CheckedChanged += new System.EventHandler(this.radioButton256_CheckedChanged);
            // 
            // radioButton278
            // 
            resources.ApplyResources(this.radioButton278, "radioButton278");
            this.radioButton278.Name = "radioButton278";
            this.radioButton278.TabStop = true;
            this.radioButton278.UseVisualStyleBackColor = true;
            this.radioButton278.CheckedChanged += new System.EventHandler(this.radioButton278_CheckedChanged);
            // 
            // radioButton262
            // 
            resources.ApplyResources(this.radioButton262, "radioButton262");
            this.radioButton262.Name = "radioButton262";
            this.radioButton262.TabStop = true;
            this.radioButton262.UseVisualStyleBackColor = true;
            this.radioButton262.CheckedChanged += new System.EventHandler(this.radioButton262_CheckedChanged);
            // 
            // radioButton257
            // 
            resources.ApplyResources(this.radioButton257, "radioButton257");
            this.radioButton257.Name = "radioButton257";
            this.radioButton257.TabStop = true;
            this.radioButton257.UseVisualStyleBackColor = true;
            this.radioButton257.CheckedChanged += new System.EventHandler(this.radioButton257_CheckedChanged);
            // 
            // radioButton268
            // 
            resources.ApplyResources(this.radioButton268, "radioButton268");
            this.radioButton268.Name = "radioButton268";
            this.radioButton268.TabStop = true;
            this.radioButton268.UseVisualStyleBackColor = true;
            this.radioButton268.CheckedChanged += new System.EventHandler(this.radioButton268_CheckedChanged);
            // 
            // groupBox59
            // 
            this.groupBox59.Controls.Add(this.textBox53);
            this.groupBox59.Controls.Add(this.label104);
            this.groupBox59.Controls.Add(this.label105);
            this.groupBox59.Controls.Add(this.radioButton258);
            this.groupBox59.Controls.Add(this.radioButton259);
            this.groupBox59.Controls.Add(this.radioButton260);
            this.groupBox59.Controls.Add(this.radioButton261);
            this.groupBox59.Controls.Add(this.radioButton280);
            resources.ApplyResources(this.groupBox59, "groupBox59");
            this.groupBox59.Name = "groupBox59";
            this.groupBox59.TabStop = false;
            // 
            // textBox53
            // 
            resources.ApplyResources(this.textBox53, "textBox53");
            this.textBox53.Name = "textBox53";
            this.textBox53.TextChanged += new System.EventHandler(this.textBox53_TextChanged);
            // 
            // label104
            // 
            resources.ApplyResources(this.label104, "label104");
            this.label104.Name = "label104";
            // 
            // label105
            // 
            resources.ApplyResources(this.label105, "label105");
            this.label105.Name = "label105";
            // 
            // radioButton258
            // 
            resources.ApplyResources(this.radioButton258, "radioButton258");
            this.radioButton258.Name = "radioButton258";
            this.radioButton258.TabStop = true;
            this.radioButton258.UseVisualStyleBackColor = true;
            this.radioButton258.CheckedChanged += new System.EventHandler(this.radioButton258_CheckedChanged);
            // 
            // radioButton259
            // 
            resources.ApplyResources(this.radioButton259, "radioButton259");
            this.radioButton259.Name = "radioButton259";
            this.radioButton259.TabStop = true;
            this.radioButton259.UseVisualStyleBackColor = true;
            this.radioButton259.CheckedChanged += new System.EventHandler(this.radioButton259_CheckedChanged);
            // 
            // radioButton260
            // 
            resources.ApplyResources(this.radioButton260, "radioButton260");
            this.radioButton260.Name = "radioButton260";
            this.radioButton260.TabStop = true;
            this.radioButton260.UseVisualStyleBackColor = true;
            this.radioButton260.CheckedChanged += new System.EventHandler(this.radioButton260_CheckedChanged);
            // 
            // radioButton261
            // 
            resources.ApplyResources(this.radioButton261, "radioButton261");
            this.radioButton261.Name = "radioButton261";
            this.radioButton261.TabStop = true;
            this.radioButton261.UseVisualStyleBackColor = true;
            this.radioButton261.CheckedChanged += new System.EventHandler(this.radioButton261_CheckedChanged);
            // 
            // radioButton280
            // 
            resources.ApplyResources(this.radioButton280, "radioButton280");
            this.radioButton280.Name = "radioButton280";
            this.radioButton280.TabStop = true;
            this.radioButton280.UseVisualStyleBackColor = true;
            this.radioButton280.CheckedChanged += new System.EventHandler(this.radioButton280_CheckedChanged);
            // 
            // groupBox60
            // 
            this.groupBox60.Controls.Add(this.textBox59);
            this.groupBox60.Controls.Add(this.label119);
            this.groupBox60.Controls.Add(this.label120);
            this.groupBox60.Controls.Add(this.radioButton296);
            this.groupBox60.Controls.Add(this.radioButton297);
            this.groupBox60.Controls.Add(this.radioButton298);
            this.groupBox60.Controls.Add(this.radioButton299);
            this.groupBox60.Controls.Add(this.radioButton300);
            resources.ApplyResources(this.groupBox60, "groupBox60");
            this.groupBox60.Name = "groupBox60";
            this.groupBox60.TabStop = false;
            // 
            // textBox59
            // 
            resources.ApplyResources(this.textBox59, "textBox59");
            this.textBox59.Name = "textBox59";
            this.textBox59.TextChanged += new System.EventHandler(this.textBox59_TextChanged);
            // 
            // label119
            // 
            resources.ApplyResources(this.label119, "label119");
            this.label119.Name = "label119";
            // 
            // label120
            // 
            resources.ApplyResources(this.label120, "label120");
            this.label120.Name = "label120";
            // 
            // radioButton296
            // 
            resources.ApplyResources(this.radioButton296, "radioButton296");
            this.radioButton296.Name = "radioButton296";
            this.radioButton296.TabStop = true;
            this.radioButton296.UseVisualStyleBackColor = true;
            this.radioButton296.CheckedChanged += new System.EventHandler(this.radioButton296_CheckedChanged);
            // 
            // radioButton297
            // 
            resources.ApplyResources(this.radioButton297, "radioButton297");
            this.radioButton297.Name = "radioButton297";
            this.radioButton297.TabStop = true;
            this.radioButton297.UseVisualStyleBackColor = true;
            this.radioButton297.CheckedChanged += new System.EventHandler(this.radioButton297_CheckedChanged);
            // 
            // radioButton298
            // 
            resources.ApplyResources(this.radioButton298, "radioButton298");
            this.radioButton298.Name = "radioButton298";
            this.radioButton298.TabStop = true;
            this.radioButton298.UseVisualStyleBackColor = true;
            this.radioButton298.CheckedChanged += new System.EventHandler(this.radioButton298_CheckedChanged);
            // 
            // radioButton299
            // 
            resources.ApplyResources(this.radioButton299, "radioButton299");
            this.radioButton299.Name = "radioButton299";
            this.radioButton299.TabStop = true;
            this.radioButton299.UseVisualStyleBackColor = true;
            this.radioButton299.CheckedChanged += new System.EventHandler(this.radioButton299_CheckedChanged);
            // 
            // radioButton300
            // 
            resources.ApplyResources(this.radioButton300, "radioButton300");
            this.radioButton300.Name = "radioButton300";
            this.radioButton300.TabStop = true;
            this.radioButton300.UseVisualStyleBackColor = true;
            this.radioButton300.CheckedChanged += new System.EventHandler(this.radioButton300_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.groupBox41);
            this.tabPage5.Controls.Add(this.groupBox42);
            this.tabPage5.Controls.Add(this.groupBox43);
            this.tabPage5.Controls.Add(this.groupBox44);
            this.tabPage5.Controls.Add(this.groupBox45);
            this.tabPage5.Controls.Add(this.groupBox46);
            this.tabPage5.Controls.Add(this.groupBox47);
            this.tabPage5.Controls.Add(this.groupBox48);
            this.tabPage5.Controls.Add(this.groupBox49);
            this.tabPage5.Controls.Add(this.groupBox50);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.textBox41);
            this.groupBox41.Controls.Add(this.label82);
            this.groupBox41.Controls.Add(this.label83);
            this.groupBox41.Controls.Add(this.radioButton201);
            this.groupBox41.Controls.Add(this.radioButton202);
            this.groupBox41.Controls.Add(this.radioButton203);
            this.groupBox41.Controls.Add(this.radioButton204);
            this.groupBox41.Controls.Add(this.radioButton205);
            resources.ApplyResources(this.groupBox41, "groupBox41");
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.TabStop = false;
            // 
            // textBox41
            // 
            resources.ApplyResources(this.textBox41, "textBox41");
            this.textBox41.Name = "textBox41";
            this.textBox41.TextChanged += new System.EventHandler(this.textBox41_TextChanged);
            // 
            // label82
            // 
            resources.ApplyResources(this.label82, "label82");
            this.label82.Name = "label82";
            // 
            // label83
            // 
            resources.ApplyResources(this.label83, "label83");
            this.label83.Name = "label83";
            // 
            // radioButton201
            // 
            resources.ApplyResources(this.radioButton201, "radioButton201");
            this.radioButton201.Name = "radioButton201";
            this.radioButton201.TabStop = true;
            this.radioButton201.UseVisualStyleBackColor = true;
            this.radioButton201.CheckedChanged += new System.EventHandler(this.radioButton201_CheckedChanged);
            // 
            // radioButton202
            // 
            resources.ApplyResources(this.radioButton202, "radioButton202");
            this.radioButton202.Name = "radioButton202";
            this.radioButton202.TabStop = true;
            this.radioButton202.UseVisualStyleBackColor = true;
            this.radioButton202.CheckedChanged += new System.EventHandler(this.radioButton202_CheckedChanged);
            // 
            // radioButton203
            // 
            resources.ApplyResources(this.radioButton203, "radioButton203");
            this.radioButton203.Name = "radioButton203";
            this.radioButton203.TabStop = true;
            this.radioButton203.UseVisualStyleBackColor = true;
            this.radioButton203.CheckedChanged += new System.EventHandler(this.radioButton203_CheckedChanged);
            // 
            // radioButton204
            // 
            resources.ApplyResources(this.radioButton204, "radioButton204");
            this.radioButton204.Name = "radioButton204";
            this.radioButton204.TabStop = true;
            this.radioButton204.UseVisualStyleBackColor = true;
            this.radioButton204.CheckedChanged += new System.EventHandler(this.radioButton204_CheckedChanged);
            // 
            // radioButton205
            // 
            resources.ApplyResources(this.radioButton205, "radioButton205");
            this.radioButton205.Name = "radioButton205";
            this.radioButton205.TabStop = true;
            this.radioButton205.UseVisualStyleBackColor = true;
            this.radioButton205.CheckedChanged += new System.EventHandler(this.radioButton205_CheckedChanged);
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.textBox46);
            this.groupBox42.Controls.Add(this.label81);
            this.groupBox42.Controls.Add(this.label86);
            this.groupBox42.Controls.Add(this.radioButton213);
            this.groupBox42.Controls.Add(this.radioButton214);
            this.groupBox42.Controls.Add(this.radioButton215);
            this.groupBox42.Controls.Add(this.radioButton216);
            this.groupBox42.Controls.Add(this.radioButton217);
            resources.ApplyResources(this.groupBox42, "groupBox42");
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.TabStop = false;
            // 
            // textBox46
            // 
            resources.ApplyResources(this.textBox46, "textBox46");
            this.textBox46.Name = "textBox46";
            this.textBox46.TextChanged += new System.EventHandler(this.textBox46_TextChanged);
            // 
            // label81
            // 
            resources.ApplyResources(this.label81, "label81");
            this.label81.Name = "label81";
            // 
            // label86
            // 
            resources.ApplyResources(this.label86, "label86");
            this.label86.Name = "label86";
            // 
            // radioButton213
            // 
            resources.ApplyResources(this.radioButton213, "radioButton213");
            this.radioButton213.Name = "radioButton213";
            this.radioButton213.TabStop = true;
            this.radioButton213.UseVisualStyleBackColor = true;
            this.radioButton213.CheckedChanged += new System.EventHandler(this.radioButton213_CheckedChanged);
            // 
            // radioButton214
            // 
            resources.ApplyResources(this.radioButton214, "radioButton214");
            this.radioButton214.Name = "radioButton214";
            this.radioButton214.TabStop = true;
            this.radioButton214.UseVisualStyleBackColor = true;
            this.radioButton214.CheckedChanged += new System.EventHandler(this.radioButton214_CheckedChanged);
            // 
            // radioButton215
            // 
            resources.ApplyResources(this.radioButton215, "radioButton215");
            this.radioButton215.Name = "radioButton215";
            this.radioButton215.TabStop = true;
            this.radioButton215.UseVisualStyleBackColor = true;
            this.radioButton215.CheckedChanged += new System.EventHandler(this.radioButton215_CheckedChanged);
            // 
            // radioButton216
            // 
            resources.ApplyResources(this.radioButton216, "radioButton216");
            this.radioButton216.Name = "radioButton216";
            this.radioButton216.TabStop = true;
            this.radioButton216.UseVisualStyleBackColor = true;
            this.radioButton216.CheckedChanged += new System.EventHandler(this.radioButton216_CheckedChanged);
            // 
            // radioButton217
            // 
            resources.ApplyResources(this.radioButton217, "radioButton217");
            this.radioButton217.Name = "radioButton217";
            this.radioButton217.TabStop = true;
            this.radioButton217.UseVisualStyleBackColor = true;
            this.radioButton217.CheckedChanged += new System.EventHandler(this.radioButton217_CheckedChanged);
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.textBox44);
            this.groupBox43.Controls.Add(this.label87);
            this.groupBox43.Controls.Add(this.label88);
            this.groupBox43.Controls.Add(this.radioButton219);
            this.groupBox43.Controls.Add(this.radioButton220);
            this.groupBox43.Controls.Add(this.radioButton221);
            this.groupBox43.Controls.Add(this.radioButton225);
            this.groupBox43.Controls.Add(this.radioButton222);
            resources.ApplyResources(this.groupBox43, "groupBox43");
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.TabStop = false;
            // 
            // textBox44
            // 
            resources.ApplyResources(this.textBox44, "textBox44");
            this.textBox44.Name = "textBox44";
            this.textBox44.TextChanged += new System.EventHandler(this.textBox44_TextChanged);
            // 
            // label87
            // 
            resources.ApplyResources(this.label87, "label87");
            this.label87.Name = "label87";
            // 
            // label88
            // 
            resources.ApplyResources(this.label88, "label88");
            this.label88.Name = "label88";
            // 
            // radioButton219
            // 
            resources.ApplyResources(this.radioButton219, "radioButton219");
            this.radioButton219.Name = "radioButton219";
            this.radioButton219.TabStop = true;
            this.radioButton219.UseVisualStyleBackColor = true;
            this.radioButton219.CheckedChanged += new System.EventHandler(this.radioButton219_CheckedChanged);
            // 
            // radioButton220
            // 
            resources.ApplyResources(this.radioButton220, "radioButton220");
            this.radioButton220.Name = "radioButton220";
            this.radioButton220.TabStop = true;
            this.radioButton220.UseVisualStyleBackColor = true;
            this.radioButton220.CheckedChanged += new System.EventHandler(this.radioButton220_CheckedChanged);
            // 
            // radioButton221
            // 
            resources.ApplyResources(this.radioButton221, "radioButton221");
            this.radioButton221.Name = "radioButton221";
            this.radioButton221.TabStop = true;
            this.radioButton221.UseVisualStyleBackColor = true;
            this.radioButton221.CheckedChanged += new System.EventHandler(this.radioButton221_CheckedChanged);
            // 
            // radioButton225
            // 
            resources.ApplyResources(this.radioButton225, "radioButton225");
            this.radioButton225.Name = "radioButton225";
            this.radioButton225.TabStop = true;
            this.radioButton225.UseVisualStyleBackColor = true;
            this.radioButton225.CheckedChanged += new System.EventHandler(this.radioButton225_CheckedChanged);
            // 
            // radioButton222
            // 
            resources.ApplyResources(this.radioButton222, "radioButton222");
            this.radioButton222.Name = "radioButton222";
            this.radioButton222.TabStop = true;
            this.radioButton222.UseVisualStyleBackColor = true;
            this.radioButton222.CheckedChanged += new System.EventHandler(this.radioButton222_CheckedChanged);
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.textBox45);
            this.groupBox44.Controls.Add(this.label89);
            this.groupBox44.Controls.Add(this.label90);
            this.groupBox44.Controls.Add(this.radioButton223);
            this.groupBox44.Controls.Add(this.radioButton224);
            this.groupBox44.Controls.Add(this.radioButton226);
            this.groupBox44.Controls.Add(this.radioButton229);
            this.groupBox44.Controls.Add(this.radioButton227);
            resources.ApplyResources(this.groupBox44, "groupBox44");
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.TabStop = false;
            // 
            // textBox45
            // 
            resources.ApplyResources(this.textBox45, "textBox45");
            this.textBox45.Name = "textBox45";
            this.textBox45.TextChanged += new System.EventHandler(this.textBox45_TextChanged);
            // 
            // label89
            // 
            resources.ApplyResources(this.label89, "label89");
            this.label89.Name = "label89";
            // 
            // label90
            // 
            resources.ApplyResources(this.label90, "label90");
            this.label90.Name = "label90";
            // 
            // radioButton223
            // 
            resources.ApplyResources(this.radioButton223, "radioButton223");
            this.radioButton223.Name = "radioButton223";
            this.radioButton223.TabStop = true;
            this.radioButton223.UseVisualStyleBackColor = true;
            this.radioButton223.CheckedChanged += new System.EventHandler(this.radioButton223_CheckedChanged);
            // 
            // radioButton224
            // 
            resources.ApplyResources(this.radioButton224, "radioButton224");
            this.radioButton224.Name = "radioButton224";
            this.radioButton224.TabStop = true;
            this.radioButton224.UseVisualStyleBackColor = true;
            this.radioButton224.CheckedChanged += new System.EventHandler(this.radioButton224_CheckedChanged);
            // 
            // radioButton226
            // 
            resources.ApplyResources(this.radioButton226, "radioButton226");
            this.radioButton226.Name = "radioButton226";
            this.radioButton226.TabStop = true;
            this.radioButton226.UseVisualStyleBackColor = true;
            this.radioButton226.CheckedChanged += new System.EventHandler(this.radioButton226_CheckedChanged);
            // 
            // radioButton229
            // 
            resources.ApplyResources(this.radioButton229, "radioButton229");
            this.radioButton229.Name = "radioButton229";
            this.radioButton229.TabStop = true;
            this.radioButton229.UseVisualStyleBackColor = true;
            this.radioButton229.CheckedChanged += new System.EventHandler(this.radioButton229_CheckedChanged);
            // 
            // radioButton227
            // 
            resources.ApplyResources(this.radioButton227, "radioButton227");
            this.radioButton227.Name = "radioButton227";
            this.radioButton227.TabStop = true;
            this.radioButton227.UseVisualStyleBackColor = true;
            this.radioButton227.CheckedChanged += new System.EventHandler(this.radioButton227_CheckedChanged);
            // 
            // groupBox45
            // 
            this.groupBox45.Controls.Add(this.textBox47);
            this.groupBox45.Controls.Add(this.label94);
            this.groupBox45.Controls.Add(this.label95);
            this.groupBox45.Controls.Add(this.radioButton236);
            this.groupBox45.Controls.Add(this.radioButton237);
            this.groupBox45.Controls.Add(this.radioButton238);
            this.groupBox45.Controls.Add(this.radioButton239);
            this.groupBox45.Controls.Add(this.radioButton240);
            resources.ApplyResources(this.groupBox45, "groupBox45");
            this.groupBox45.Name = "groupBox45";
            this.groupBox45.TabStop = false;
            // 
            // textBox47
            // 
            resources.ApplyResources(this.textBox47, "textBox47");
            this.textBox47.Name = "textBox47";
            this.textBox47.TextChanged += new System.EventHandler(this.textBox47_TextChanged);
            // 
            // label94
            // 
            resources.ApplyResources(this.label94, "label94");
            this.label94.Name = "label94";
            // 
            // label95
            // 
            resources.ApplyResources(this.label95, "label95");
            this.label95.Name = "label95";
            // 
            // radioButton236
            // 
            resources.ApplyResources(this.radioButton236, "radioButton236");
            this.radioButton236.Name = "radioButton236";
            this.radioButton236.TabStop = true;
            this.radioButton236.UseVisualStyleBackColor = true;
            this.radioButton236.CheckedChanged += new System.EventHandler(this.radioButton236_CheckedChanged);
            // 
            // radioButton237
            // 
            resources.ApplyResources(this.radioButton237, "radioButton237");
            this.radioButton237.Name = "radioButton237";
            this.radioButton237.TabStop = true;
            this.radioButton237.UseVisualStyleBackColor = true;
            this.radioButton237.CheckedChanged += new System.EventHandler(this.radioButton237_CheckedChanged);
            // 
            // radioButton238
            // 
            resources.ApplyResources(this.radioButton238, "radioButton238");
            this.radioButton238.Name = "radioButton238";
            this.radioButton238.TabStop = true;
            this.radioButton238.UseVisualStyleBackColor = true;
            this.radioButton238.CheckedChanged += new System.EventHandler(this.radioButton238_CheckedChanged);
            // 
            // radioButton239
            // 
            resources.ApplyResources(this.radioButton239, "radioButton239");
            this.radioButton239.Name = "radioButton239";
            this.radioButton239.TabStop = true;
            this.radioButton239.UseVisualStyleBackColor = true;
            this.radioButton239.CheckedChanged += new System.EventHandler(this.radioButton239_CheckedChanged);
            // 
            // radioButton240
            // 
            resources.ApplyResources(this.radioButton240, "radioButton240");
            this.radioButton240.Name = "radioButton240";
            this.radioButton240.TabStop = true;
            this.radioButton240.UseVisualStyleBackColor = true;
            this.radioButton240.CheckedChanged += new System.EventHandler(this.radioButton240_CheckedChanged);
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.txtA);
            this.groupBox46.Controls.Add(this.textBox48);
            this.groupBox46.Controls.Add(this.label92);
            this.groupBox46.Controls.Add(this.label93);
            this.groupBox46.Controls.Add(this.radioButton231);
            this.groupBox46.Controls.Add(this.radioButton232);
            this.groupBox46.Controls.Add(this.radioButton233);
            this.groupBox46.Controls.Add(this.radioButton234);
            this.groupBox46.Controls.Add(this.radioButton235);
            resources.ApplyResources(this.groupBox46, "groupBox46");
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.TabStop = false;
            // 
            // txtA
            // 
            resources.ApplyResources(this.txtA, "txtA");
            this.txtA.Name = "txtA";
            // 
            // textBox48
            // 
            resources.ApplyResources(this.textBox48, "textBox48");
            this.textBox48.Name = "textBox48";
            this.textBox48.TextChanged += new System.EventHandler(this.textBox48_TextChanged);
            // 
            // label92
            // 
            resources.ApplyResources(this.label92, "label92");
            this.label92.Name = "label92";
            // 
            // label93
            // 
            resources.ApplyResources(this.label93, "label93");
            this.label93.Name = "label93";
            // 
            // radioButton231
            // 
            resources.ApplyResources(this.radioButton231, "radioButton231");
            this.radioButton231.Name = "radioButton231";
            this.radioButton231.TabStop = true;
            this.radioButton231.UseVisualStyleBackColor = true;
            this.radioButton231.CheckedChanged += new System.EventHandler(this.radioButton231_CheckedChanged);
            // 
            // radioButton232
            // 
            resources.ApplyResources(this.radioButton232, "radioButton232");
            this.radioButton232.Name = "radioButton232";
            this.radioButton232.TabStop = true;
            this.radioButton232.UseVisualStyleBackColor = true;
            this.radioButton232.CheckedChanged += new System.EventHandler(this.radioButton232_CheckedChanged);
            // 
            // radioButton233
            // 
            resources.ApplyResources(this.radioButton233, "radioButton233");
            this.radioButton233.Name = "radioButton233";
            this.radioButton233.TabStop = true;
            this.radioButton233.UseVisualStyleBackColor = true;
            this.radioButton233.CheckedChanged += new System.EventHandler(this.radioButton233_CheckedChanged);
            // 
            // radioButton234
            // 
            resources.ApplyResources(this.radioButton234, "radioButton234");
            this.radioButton234.Name = "radioButton234";
            this.radioButton234.TabStop = true;
            this.radioButton234.UseVisualStyleBackColor = true;
            this.radioButton234.CheckedChanged += new System.EventHandler(this.radioButton234_CheckedChanged);
            // 
            // radioButton235
            // 
            resources.ApplyResources(this.radioButton235, "radioButton235");
            this.radioButton235.Name = "radioButton235";
            this.radioButton235.TabStop = true;
            this.radioButton235.UseVisualStyleBackColor = true;
            this.radioButton235.CheckedChanged += new System.EventHandler(this.radioButton235_CheckedChanged);
            // 
            // groupBox47
            // 
            this.groupBox47.Controls.Add(this.textBox50);
            this.groupBox47.Controls.Add(this.label96);
            this.groupBox47.Controls.Add(this.label97);
            this.groupBox47.Controls.Add(this.radioButton241);
            this.groupBox47.Controls.Add(this.radioButton242);
            this.groupBox47.Controls.Add(this.radioButton243);
            this.groupBox47.Controls.Add(this.radioButton244);
            this.groupBox47.Controls.Add(this.radioButton245);
            resources.ApplyResources(this.groupBox47, "groupBox47");
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.TabStop = false;
            // 
            // textBox50
            // 
            resources.ApplyResources(this.textBox50, "textBox50");
            this.textBox50.Name = "textBox50";
            this.textBox50.TextChanged += new System.EventHandler(this.textBox50_TextChanged);
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.Name = "label96";
            // 
            // label97
            // 
            resources.ApplyResources(this.label97, "label97");
            this.label97.Name = "label97";
            // 
            // radioButton241
            // 
            resources.ApplyResources(this.radioButton241, "radioButton241");
            this.radioButton241.Name = "radioButton241";
            this.radioButton241.TabStop = true;
            this.radioButton241.UseVisualStyleBackColor = true;
            this.radioButton241.CheckedChanged += new System.EventHandler(this.radioButton241_CheckedChanged);
            // 
            // radioButton242
            // 
            resources.ApplyResources(this.radioButton242, "radioButton242");
            this.radioButton242.Name = "radioButton242";
            this.radioButton242.TabStop = true;
            this.radioButton242.UseVisualStyleBackColor = true;
            this.radioButton242.CheckedChanged += new System.EventHandler(this.radioButton242_CheckedChanged);
            // 
            // radioButton243
            // 
            resources.ApplyResources(this.radioButton243, "radioButton243");
            this.radioButton243.Name = "radioButton243";
            this.radioButton243.TabStop = true;
            this.radioButton243.UseVisualStyleBackColor = true;
            this.radioButton243.CheckedChanged += new System.EventHandler(this.radioButton243_CheckedChanged);
            // 
            // radioButton244
            // 
            resources.ApplyResources(this.radioButton244, "radioButton244");
            this.radioButton244.Name = "radioButton244";
            this.radioButton244.TabStop = true;
            this.radioButton244.UseVisualStyleBackColor = true;
            this.radioButton244.CheckedChanged += new System.EventHandler(this.radioButton244_CheckedChanged);
            // 
            // radioButton245
            // 
            resources.ApplyResources(this.radioButton245, "radioButton245");
            this.radioButton245.Name = "radioButton245";
            this.radioButton245.TabStop = true;
            this.radioButton245.UseVisualStyleBackColor = true;
            this.radioButton245.CheckedChanged += new System.EventHandler(this.radioButton245_CheckedChanged);
            // 
            // groupBox48
            // 
            this.groupBox48.Controls.Add(this.textBox42);
            this.groupBox48.Controls.Add(this.label98);
            this.groupBox48.Controls.Add(this.label91);
            this.groupBox48.Controls.Add(this.radioButton206);
            this.groupBox48.Controls.Add(this.radioButton228);
            this.groupBox48.Controls.Add(this.radioButton212);
            this.groupBox48.Controls.Add(this.radioButton207);
            this.groupBox48.Controls.Add(this.radioButton218);
            resources.ApplyResources(this.groupBox48, "groupBox48");
            this.groupBox48.Name = "groupBox48";
            this.groupBox48.TabStop = false;
            // 
            // textBox42
            // 
            resources.ApplyResources(this.textBox42, "textBox42");
            this.textBox42.Name = "textBox42";
            this.textBox42.TextChanged += new System.EventHandler(this.textBox42_TextChanged);
            // 
            // label98
            // 
            resources.ApplyResources(this.label98, "label98");
            this.label98.Name = "label98";
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.Name = "label91";
            // 
            // radioButton206
            // 
            resources.ApplyResources(this.radioButton206, "radioButton206");
            this.radioButton206.Name = "radioButton206";
            this.radioButton206.TabStop = true;
            this.radioButton206.UseVisualStyleBackColor = true;
            this.radioButton206.CheckedChanged += new System.EventHandler(this.radioButton206_CheckedChanged);
            // 
            // radioButton228
            // 
            resources.ApplyResources(this.radioButton228, "radioButton228");
            this.radioButton228.Name = "radioButton228";
            this.radioButton228.TabStop = true;
            this.radioButton228.UseVisualStyleBackColor = true;
            this.radioButton228.CheckedChanged += new System.EventHandler(this.radioButton228_CheckedChanged);
            // 
            // radioButton212
            // 
            resources.ApplyResources(this.radioButton212, "radioButton212");
            this.radioButton212.Name = "radioButton212";
            this.radioButton212.TabStop = true;
            this.radioButton212.UseVisualStyleBackColor = true;
            this.radioButton212.CheckedChanged += new System.EventHandler(this.radioButton212_CheckedChanged);
            // 
            // radioButton207
            // 
            resources.ApplyResources(this.radioButton207, "radioButton207");
            this.radioButton207.Name = "radioButton207";
            this.radioButton207.TabStop = true;
            this.radioButton207.UseVisualStyleBackColor = true;
            this.radioButton207.CheckedChanged += new System.EventHandler(this.radioButton207_CheckedChanged);
            // 
            // radioButton218
            // 
            resources.ApplyResources(this.radioButton218, "radioButton218");
            this.radioButton218.Name = "radioButton218";
            this.radioButton218.TabStop = true;
            this.radioButton218.UseVisualStyleBackColor = true;
            this.radioButton218.CheckedChanged += new System.EventHandler(this.radioButton218_CheckedChanged);
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.textBox43);
            this.groupBox49.Controls.Add(this.label84);
            this.groupBox49.Controls.Add(this.label85);
            this.groupBox49.Controls.Add(this.radioButton208);
            this.groupBox49.Controls.Add(this.radioButton209);
            this.groupBox49.Controls.Add(this.radioButton210);
            this.groupBox49.Controls.Add(this.radioButton211);
            this.groupBox49.Controls.Add(this.radioButton230);
            resources.ApplyResources(this.groupBox49, "groupBox49");
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.TabStop = false;
            // 
            // textBox43
            // 
            resources.ApplyResources(this.textBox43, "textBox43");
            this.textBox43.Name = "textBox43";
            this.textBox43.TextChanged += new System.EventHandler(this.textBox43_TextChanged);
            // 
            // label84
            // 
            resources.ApplyResources(this.label84, "label84");
            this.label84.Name = "label84";
            // 
            // label85
            // 
            resources.ApplyResources(this.label85, "label85");
            this.label85.Name = "label85";
            // 
            // radioButton208
            // 
            resources.ApplyResources(this.radioButton208, "radioButton208");
            this.radioButton208.Name = "radioButton208";
            this.radioButton208.TabStop = true;
            this.radioButton208.UseVisualStyleBackColor = true;
            this.radioButton208.CheckedChanged += new System.EventHandler(this.radioButton208_CheckedChanged);
            // 
            // radioButton209
            // 
            resources.ApplyResources(this.radioButton209, "radioButton209");
            this.radioButton209.Name = "radioButton209";
            this.radioButton209.TabStop = true;
            this.radioButton209.UseVisualStyleBackColor = true;
            this.radioButton209.CheckedChanged += new System.EventHandler(this.radioButton209_CheckedChanged);
            // 
            // radioButton210
            // 
            resources.ApplyResources(this.radioButton210, "radioButton210");
            this.radioButton210.Name = "radioButton210";
            this.radioButton210.TabStop = true;
            this.radioButton210.UseVisualStyleBackColor = true;
            this.radioButton210.CheckedChanged += new System.EventHandler(this.radioButton210_CheckedChanged);
            // 
            // radioButton211
            // 
            resources.ApplyResources(this.radioButton211, "radioButton211");
            this.radioButton211.Name = "radioButton211";
            this.radioButton211.TabStop = true;
            this.radioButton211.UseVisualStyleBackColor = true;
            this.radioButton211.CheckedChanged += new System.EventHandler(this.radioButton211_CheckedChanged);
            // 
            // radioButton230
            // 
            resources.ApplyResources(this.radioButton230, "radioButton230");
            this.radioButton230.Name = "radioButton230";
            this.radioButton230.TabStop = true;
            this.radioButton230.UseVisualStyleBackColor = true;
            this.radioButton230.CheckedChanged += new System.EventHandler(this.radioButton230_CheckedChanged);
            // 
            // groupBox50
            // 
            this.groupBox50.Controls.Add(this.textBox49);
            this.groupBox50.Controls.Add(this.label99);
            this.groupBox50.Controls.Add(this.label100);
            this.groupBox50.Controls.Add(this.radioButton246);
            this.groupBox50.Controls.Add(this.radioButton247);
            this.groupBox50.Controls.Add(this.radioButton248);
            this.groupBox50.Controls.Add(this.radioButton249);
            this.groupBox50.Controls.Add(this.radioButton250);
            resources.ApplyResources(this.groupBox50, "groupBox50");
            this.groupBox50.Name = "groupBox50";
            this.groupBox50.TabStop = false;
            // 
            // textBox49
            // 
            resources.ApplyResources(this.textBox49, "textBox49");
            this.textBox49.Name = "textBox49";
            this.textBox49.TextChanged += new System.EventHandler(this.textBox49_TextChanged);
            // 
            // label99
            // 
            resources.ApplyResources(this.label99, "label99");
            this.label99.Name = "label99";
            // 
            // label100
            // 
            resources.ApplyResources(this.label100, "label100");
            this.label100.Name = "label100";
            // 
            // radioButton246
            // 
            resources.ApplyResources(this.radioButton246, "radioButton246");
            this.radioButton246.Name = "radioButton246";
            this.radioButton246.TabStop = true;
            this.radioButton246.UseVisualStyleBackColor = true;
            this.radioButton246.CheckedChanged += new System.EventHandler(this.radioButton246_CheckedChanged);
            // 
            // radioButton247
            // 
            resources.ApplyResources(this.radioButton247, "radioButton247");
            this.radioButton247.Name = "radioButton247";
            this.radioButton247.TabStop = true;
            this.radioButton247.UseVisualStyleBackColor = true;
            this.radioButton247.CheckedChanged += new System.EventHandler(this.radioButton247_CheckedChanged);
            // 
            // radioButton248
            // 
            resources.ApplyResources(this.radioButton248, "radioButton248");
            this.radioButton248.Name = "radioButton248";
            this.radioButton248.TabStop = true;
            this.radioButton248.UseVisualStyleBackColor = true;
            this.radioButton248.CheckedChanged += new System.EventHandler(this.radioButton248_CheckedChanged);
            // 
            // radioButton249
            // 
            resources.ApplyResources(this.radioButton249, "radioButton249");
            this.radioButton249.Name = "radioButton249";
            this.radioButton249.TabStop = true;
            this.radioButton249.UseVisualStyleBackColor = true;
            this.radioButton249.CheckedChanged += new System.EventHandler(this.radioButton249_CheckedChanged);
            // 
            // radioButton250
            // 
            resources.ApplyResources(this.radioButton250, "radioButton250");
            this.radioButton250.Name = "radioButton250";
            this.radioButton250.TabStop = true;
            this.radioButton250.UseVisualStyleBackColor = true;
            this.radioButton250.CheckedChanged += new System.EventHandler(this.radioButton250_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.groupBox31);
            this.tabPage4.Controls.Add(this.groupBox32);
            this.tabPage4.Controls.Add(this.groupBox33);
            this.tabPage4.Controls.Add(this.groupBox34);
            this.tabPage4.Controls.Add(this.groupBox35);
            this.tabPage4.Controls.Add(this.groupBox36);
            this.tabPage4.Controls.Add(this.groupBox37);
            this.tabPage4.Controls.Add(this.groupBox38);
            this.tabPage4.Controls.Add(this.groupBox39);
            this.tabPage4.Controls.Add(this.groupBox40);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.textBox31);
            this.groupBox31.Controls.Add(this.label62);
            this.groupBox31.Controls.Add(this.label63);
            this.groupBox31.Controls.Add(this.radioButton151);
            this.groupBox31.Controls.Add(this.radioButton152);
            this.groupBox31.Controls.Add(this.radioButton153);
            this.groupBox31.Controls.Add(this.radioButton154);
            this.groupBox31.Controls.Add(this.radioButton155);
            resources.ApplyResources(this.groupBox31, "groupBox31");
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.TabStop = false;
            // 
            // textBox31
            // 
            resources.ApplyResources(this.textBox31, "textBox31");
            this.textBox31.Name = "textBox31";
            this.textBox31.TextChanged += new System.EventHandler(this.textBox31_TextChanged);
            // 
            // label62
            // 
            resources.ApplyResources(this.label62, "label62");
            this.label62.Name = "label62";
            // 
            // label63
            // 
            resources.ApplyResources(this.label63, "label63");
            this.label63.Name = "label63";
            // 
            // radioButton151
            // 
            resources.ApplyResources(this.radioButton151, "radioButton151");
            this.radioButton151.Name = "radioButton151";
            this.radioButton151.TabStop = true;
            this.radioButton151.UseVisualStyleBackColor = true;
            this.radioButton151.CheckedChanged += new System.EventHandler(this.radioButton151_CheckedChanged);
            // 
            // radioButton152
            // 
            resources.ApplyResources(this.radioButton152, "radioButton152");
            this.radioButton152.Name = "radioButton152";
            this.radioButton152.TabStop = true;
            this.radioButton152.UseVisualStyleBackColor = true;
            this.radioButton152.CheckedChanged += new System.EventHandler(this.radioButton152_CheckedChanged);
            // 
            // radioButton153
            // 
            resources.ApplyResources(this.radioButton153, "radioButton153");
            this.radioButton153.Name = "radioButton153";
            this.radioButton153.TabStop = true;
            this.radioButton153.UseVisualStyleBackColor = true;
            this.radioButton153.CheckedChanged += new System.EventHandler(this.radioButton153_CheckedChanged);
            // 
            // radioButton154
            // 
            resources.ApplyResources(this.radioButton154, "radioButton154");
            this.radioButton154.Name = "radioButton154";
            this.radioButton154.TabStop = true;
            this.radioButton154.UseVisualStyleBackColor = true;
            this.radioButton154.CheckedChanged += new System.EventHandler(this.radioButton154_CheckedChanged);
            // 
            // radioButton155
            // 
            resources.ApplyResources(this.radioButton155, "radioButton155");
            this.radioButton155.Name = "radioButton155";
            this.radioButton155.TabStop = true;
            this.radioButton155.UseVisualStyleBackColor = true;
            this.radioButton155.CheckedChanged += new System.EventHandler(this.radioButton155_CheckedChanged);
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.txtO);
            this.groupBox32.Controls.Add(this.textBox36);
            this.groupBox32.Controls.Add(this.label61);
            this.groupBox32.Controls.Add(this.label66);
            this.groupBox32.Controls.Add(this.radioButton163);
            this.groupBox32.Controls.Add(this.radioButton164);
            this.groupBox32.Controls.Add(this.radioButton165);
            this.groupBox32.Controls.Add(this.radioButton166);
            this.groupBox32.Controls.Add(this.radioButton167);
            resources.ApplyResources(this.groupBox32, "groupBox32");
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.TabStop = false;
            // 
            // txtO
            // 
            resources.ApplyResources(this.txtO, "txtO");
            this.txtO.Name = "txtO";
            // 
            // textBox36
            // 
            resources.ApplyResources(this.textBox36, "textBox36");
            this.textBox36.Name = "textBox36";
            this.textBox36.TextChanged += new System.EventHandler(this.textBox36_TextChanged);
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.Name = "label61";
            // 
            // label66
            // 
            resources.ApplyResources(this.label66, "label66");
            this.label66.Name = "label66";
            // 
            // radioButton163
            // 
            resources.ApplyResources(this.radioButton163, "radioButton163");
            this.radioButton163.Name = "radioButton163";
            this.radioButton163.TabStop = true;
            this.radioButton163.UseVisualStyleBackColor = true;
            this.radioButton163.CheckedChanged += new System.EventHandler(this.radioButton163_CheckedChanged);
            // 
            // radioButton164
            // 
            resources.ApplyResources(this.radioButton164, "radioButton164");
            this.radioButton164.Name = "radioButton164";
            this.radioButton164.TabStop = true;
            this.radioButton164.UseVisualStyleBackColor = true;
            this.radioButton164.CheckedChanged += new System.EventHandler(this.radioButton164_CheckedChanged);
            // 
            // radioButton165
            // 
            resources.ApplyResources(this.radioButton165, "radioButton165");
            this.radioButton165.Name = "radioButton165";
            this.radioButton165.TabStop = true;
            this.radioButton165.UseVisualStyleBackColor = true;
            this.radioButton165.CheckedChanged += new System.EventHandler(this.radioButton165_CheckedChanged);
            // 
            // radioButton166
            // 
            resources.ApplyResources(this.radioButton166, "radioButton166");
            this.radioButton166.Name = "radioButton166";
            this.radioButton166.TabStop = true;
            this.radioButton166.UseVisualStyleBackColor = true;
            this.radioButton166.CheckedChanged += new System.EventHandler(this.radioButton166_CheckedChanged);
            // 
            // radioButton167
            // 
            resources.ApplyResources(this.radioButton167, "radioButton167");
            this.radioButton167.Name = "radioButton167";
            this.radioButton167.TabStop = true;
            this.radioButton167.UseVisualStyleBackColor = true;
            this.radioButton167.CheckedChanged += new System.EventHandler(this.radioButton167_CheckedChanged);
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.textBox34);
            this.groupBox33.Controls.Add(this.label67);
            this.groupBox33.Controls.Add(this.label68);
            this.groupBox33.Controls.Add(this.radioButton169);
            this.groupBox33.Controls.Add(this.radioButton170);
            this.groupBox33.Controls.Add(this.radioButton171);
            this.groupBox33.Controls.Add(this.radioButton175);
            this.groupBox33.Controls.Add(this.radioButton172);
            resources.ApplyResources(this.groupBox33, "groupBox33");
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.TabStop = false;
            // 
            // textBox34
            // 
            resources.ApplyResources(this.textBox34, "textBox34");
            this.textBox34.Name = "textBox34";
            this.textBox34.TextChanged += new System.EventHandler(this.textBox34_TextChanged);
            // 
            // label67
            // 
            resources.ApplyResources(this.label67, "label67");
            this.label67.Name = "label67";
            // 
            // label68
            // 
            resources.ApplyResources(this.label68, "label68");
            this.label68.Name = "label68";
            // 
            // radioButton169
            // 
            resources.ApplyResources(this.radioButton169, "radioButton169");
            this.radioButton169.Name = "radioButton169";
            this.radioButton169.TabStop = true;
            this.radioButton169.UseVisualStyleBackColor = true;
            this.radioButton169.CheckedChanged += new System.EventHandler(this.radioButton169_CheckedChanged);
            // 
            // radioButton170
            // 
            resources.ApplyResources(this.radioButton170, "radioButton170");
            this.radioButton170.Name = "radioButton170";
            this.radioButton170.TabStop = true;
            this.radioButton170.UseVisualStyleBackColor = true;
            this.radioButton170.CheckedChanged += new System.EventHandler(this.radioButton170_CheckedChanged);
            // 
            // radioButton171
            // 
            resources.ApplyResources(this.radioButton171, "radioButton171");
            this.radioButton171.Name = "radioButton171";
            this.radioButton171.TabStop = true;
            this.radioButton171.UseVisualStyleBackColor = true;
            this.radioButton171.CheckedChanged += new System.EventHandler(this.radioButton171_CheckedChanged);
            // 
            // radioButton175
            // 
            resources.ApplyResources(this.radioButton175, "radioButton175");
            this.radioButton175.Name = "radioButton175";
            this.radioButton175.TabStop = true;
            this.radioButton175.UseVisualStyleBackColor = true;
            this.radioButton175.CheckedChanged += new System.EventHandler(this.radioButton175_CheckedChanged);
            // 
            // radioButton172
            // 
            resources.ApplyResources(this.radioButton172, "radioButton172");
            this.radioButton172.Name = "radioButton172";
            this.radioButton172.TabStop = true;
            this.radioButton172.UseVisualStyleBackColor = true;
            this.radioButton172.CheckedChanged += new System.EventHandler(this.radioButton172_CheckedChanged);
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.textBox35);
            this.groupBox34.Controls.Add(this.label69);
            this.groupBox34.Controls.Add(this.label70);
            this.groupBox34.Controls.Add(this.radioButton173);
            this.groupBox34.Controls.Add(this.radioButton174);
            this.groupBox34.Controls.Add(this.radioButton176);
            this.groupBox34.Controls.Add(this.radioButton179);
            this.groupBox34.Controls.Add(this.radioButton177);
            resources.ApplyResources(this.groupBox34, "groupBox34");
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.TabStop = false;
            // 
            // textBox35
            // 
            resources.ApplyResources(this.textBox35, "textBox35");
            this.textBox35.Name = "textBox35";
            this.textBox35.TextChanged += new System.EventHandler(this.textBox35_TextChanged);
            // 
            // label69
            // 
            resources.ApplyResources(this.label69, "label69");
            this.label69.Name = "label69";
            // 
            // label70
            // 
            resources.ApplyResources(this.label70, "label70");
            this.label70.Name = "label70";
            // 
            // radioButton173
            // 
            resources.ApplyResources(this.radioButton173, "radioButton173");
            this.radioButton173.Name = "radioButton173";
            this.radioButton173.TabStop = true;
            this.radioButton173.UseVisualStyleBackColor = true;
            this.radioButton173.CheckedChanged += new System.EventHandler(this.radioButton173_CheckedChanged);
            // 
            // radioButton174
            // 
            resources.ApplyResources(this.radioButton174, "radioButton174");
            this.radioButton174.Name = "radioButton174";
            this.radioButton174.TabStop = true;
            this.radioButton174.UseVisualStyleBackColor = true;
            this.radioButton174.CheckedChanged += new System.EventHandler(this.radioButton174_CheckedChanged);
            // 
            // radioButton176
            // 
            resources.ApplyResources(this.radioButton176, "radioButton176");
            this.radioButton176.Name = "radioButton176";
            this.radioButton176.TabStop = true;
            this.radioButton176.UseVisualStyleBackColor = true;
            this.radioButton176.CheckedChanged += new System.EventHandler(this.radioButton176_CheckedChanged);
            // 
            // radioButton179
            // 
            resources.ApplyResources(this.radioButton179, "radioButton179");
            this.radioButton179.Name = "radioButton179";
            this.radioButton179.TabStop = true;
            this.radioButton179.UseVisualStyleBackColor = true;
            this.radioButton179.CheckedChanged += new System.EventHandler(this.radioButton179_CheckedChanged);
            // 
            // radioButton177
            // 
            resources.ApplyResources(this.radioButton177, "radioButton177");
            this.radioButton177.Name = "radioButton177";
            this.radioButton177.TabStop = true;
            this.radioButton177.UseVisualStyleBackColor = true;
            this.radioButton177.CheckedChanged += new System.EventHandler(this.radioButton177_CheckedChanged);
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.textBox37);
            this.groupBox35.Controls.Add(this.label74);
            this.groupBox35.Controls.Add(this.label75);
            this.groupBox35.Controls.Add(this.radioButton186);
            this.groupBox35.Controls.Add(this.radioButton187);
            this.groupBox35.Controls.Add(this.radioButton188);
            this.groupBox35.Controls.Add(this.radioButton189);
            this.groupBox35.Controls.Add(this.radioButton190);
            resources.ApplyResources(this.groupBox35, "groupBox35");
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.TabStop = false;
            // 
            // textBox37
            // 
            resources.ApplyResources(this.textBox37, "textBox37");
            this.textBox37.Name = "textBox37";
            this.textBox37.TextChanged += new System.EventHandler(this.textBox37_TextChanged);
            // 
            // label74
            // 
            resources.ApplyResources(this.label74, "label74");
            this.label74.Name = "label74";
            // 
            // label75
            // 
            resources.ApplyResources(this.label75, "label75");
            this.label75.Name = "label75";
            // 
            // radioButton186
            // 
            resources.ApplyResources(this.radioButton186, "radioButton186");
            this.radioButton186.Name = "radioButton186";
            this.radioButton186.TabStop = true;
            this.radioButton186.UseVisualStyleBackColor = true;
            this.radioButton186.CheckedChanged += new System.EventHandler(this.radioButton186_CheckedChanged);
            // 
            // radioButton187
            // 
            resources.ApplyResources(this.radioButton187, "radioButton187");
            this.radioButton187.Name = "radioButton187";
            this.radioButton187.TabStop = true;
            this.radioButton187.UseVisualStyleBackColor = true;
            this.radioButton187.CheckedChanged += new System.EventHandler(this.radioButton187_CheckedChanged);
            // 
            // radioButton188
            // 
            resources.ApplyResources(this.radioButton188, "radioButton188");
            this.radioButton188.Name = "radioButton188";
            this.radioButton188.TabStop = true;
            this.radioButton188.UseVisualStyleBackColor = true;
            this.radioButton188.CheckedChanged += new System.EventHandler(this.radioButton188_CheckedChanged);
            // 
            // radioButton189
            // 
            resources.ApplyResources(this.radioButton189, "radioButton189");
            this.radioButton189.Name = "radioButton189";
            this.radioButton189.TabStop = true;
            this.radioButton189.UseVisualStyleBackColor = true;
            this.radioButton189.CheckedChanged += new System.EventHandler(this.radioButton189_CheckedChanged);
            // 
            // radioButton190
            // 
            resources.ApplyResources(this.radioButton190, "radioButton190");
            this.radioButton190.Name = "radioButton190";
            this.radioButton190.TabStop = true;
            this.radioButton190.UseVisualStyleBackColor = true;
            this.radioButton190.CheckedChanged += new System.EventHandler(this.radioButton190_CheckedChanged);
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.textBox38);
            this.groupBox36.Controls.Add(this.label72);
            this.groupBox36.Controls.Add(this.label73);
            this.groupBox36.Controls.Add(this.radioButton181);
            this.groupBox36.Controls.Add(this.radioButton182);
            this.groupBox36.Controls.Add(this.radioButton183);
            this.groupBox36.Controls.Add(this.radioButton184);
            this.groupBox36.Controls.Add(this.radioButton185);
            resources.ApplyResources(this.groupBox36, "groupBox36");
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.TabStop = false;
            // 
            // textBox38
            // 
            resources.ApplyResources(this.textBox38, "textBox38");
            this.textBox38.Name = "textBox38";
            this.textBox38.TextChanged += new System.EventHandler(this.textBox38_TextChanged);
            // 
            // label72
            // 
            resources.ApplyResources(this.label72, "label72");
            this.label72.Name = "label72";
            // 
            // label73
            // 
            resources.ApplyResources(this.label73, "label73");
            this.label73.Name = "label73";
            // 
            // radioButton181
            // 
            resources.ApplyResources(this.radioButton181, "radioButton181");
            this.radioButton181.Name = "radioButton181";
            this.radioButton181.TabStop = true;
            this.radioButton181.UseVisualStyleBackColor = true;
            this.radioButton181.CheckedChanged += new System.EventHandler(this.radioButton181_CheckedChanged);
            // 
            // radioButton182
            // 
            resources.ApplyResources(this.radioButton182, "radioButton182");
            this.radioButton182.Name = "radioButton182";
            this.radioButton182.TabStop = true;
            this.radioButton182.UseVisualStyleBackColor = true;
            this.radioButton182.CheckedChanged += new System.EventHandler(this.radioButton182_CheckedChanged);
            // 
            // radioButton183
            // 
            resources.ApplyResources(this.radioButton183, "radioButton183");
            this.radioButton183.Name = "radioButton183";
            this.radioButton183.TabStop = true;
            this.radioButton183.UseVisualStyleBackColor = true;
            this.radioButton183.CheckedChanged += new System.EventHandler(this.radioButton183_CheckedChanged);
            // 
            // radioButton184
            // 
            resources.ApplyResources(this.radioButton184, "radioButton184");
            this.radioButton184.Name = "radioButton184";
            this.radioButton184.TabStop = true;
            this.radioButton184.UseVisualStyleBackColor = true;
            this.radioButton184.CheckedChanged += new System.EventHandler(this.radioButton184_CheckedChanged);
            // 
            // radioButton185
            // 
            resources.ApplyResources(this.radioButton185, "radioButton185");
            this.radioButton185.Name = "radioButton185";
            this.radioButton185.TabStop = true;
            this.radioButton185.UseVisualStyleBackColor = true;
            this.radioButton185.CheckedChanged += new System.EventHandler(this.radioButton185_CheckedChanged);
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.textBox40);
            this.groupBox37.Controls.Add(this.label76);
            this.groupBox37.Controls.Add(this.label77);
            this.groupBox37.Controls.Add(this.radioButton191);
            this.groupBox37.Controls.Add(this.radioButton192);
            this.groupBox37.Controls.Add(this.radioButton193);
            this.groupBox37.Controls.Add(this.radioButton194);
            this.groupBox37.Controls.Add(this.radioButton195);
            resources.ApplyResources(this.groupBox37, "groupBox37");
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.TabStop = false;
            // 
            // textBox40
            // 
            resources.ApplyResources(this.textBox40, "textBox40");
            this.textBox40.Name = "textBox40";
            this.textBox40.TextChanged += new System.EventHandler(this.textBox40_TextChanged);
            // 
            // label76
            // 
            resources.ApplyResources(this.label76, "label76");
            this.label76.Name = "label76";
            // 
            // label77
            // 
            resources.ApplyResources(this.label77, "label77");
            this.label77.Name = "label77";
            // 
            // radioButton191
            // 
            resources.ApplyResources(this.radioButton191, "radioButton191");
            this.radioButton191.Name = "radioButton191";
            this.radioButton191.TabStop = true;
            this.radioButton191.UseVisualStyleBackColor = true;
            this.radioButton191.CheckedChanged += new System.EventHandler(this.radioButton191_CheckedChanged);
            // 
            // radioButton192
            // 
            resources.ApplyResources(this.radioButton192, "radioButton192");
            this.radioButton192.Name = "radioButton192";
            this.radioButton192.TabStop = true;
            this.radioButton192.UseVisualStyleBackColor = true;
            this.radioButton192.CheckedChanged += new System.EventHandler(this.radioButton192_CheckedChanged);
            // 
            // radioButton193
            // 
            resources.ApplyResources(this.radioButton193, "radioButton193");
            this.radioButton193.Name = "radioButton193";
            this.radioButton193.TabStop = true;
            this.radioButton193.UseVisualStyleBackColor = true;
            this.radioButton193.CheckedChanged += new System.EventHandler(this.radioButton193_CheckedChanged);
            // 
            // radioButton194
            // 
            resources.ApplyResources(this.radioButton194, "radioButton194");
            this.radioButton194.Name = "radioButton194";
            this.radioButton194.TabStop = true;
            this.radioButton194.UseVisualStyleBackColor = true;
            this.radioButton194.CheckedChanged += new System.EventHandler(this.radioButton194_CheckedChanged);
            // 
            // radioButton195
            // 
            resources.ApplyResources(this.radioButton195, "radioButton195");
            this.radioButton195.Name = "radioButton195";
            this.radioButton195.TabStop = true;
            this.radioButton195.UseVisualStyleBackColor = true;
            this.radioButton195.CheckedChanged += new System.EventHandler(this.radioButton195_CheckedChanged);
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.textBox32);
            this.groupBox38.Controls.Add(this.label78);
            this.groupBox38.Controls.Add(this.label71);
            this.groupBox38.Controls.Add(this.radioButton156);
            this.groupBox38.Controls.Add(this.radioButton178);
            this.groupBox38.Controls.Add(this.radioButton162);
            this.groupBox38.Controls.Add(this.radioButton157);
            this.groupBox38.Controls.Add(this.radioButton168);
            resources.ApplyResources(this.groupBox38, "groupBox38");
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.TabStop = false;
            // 
            // textBox32
            // 
            resources.ApplyResources(this.textBox32, "textBox32");
            this.textBox32.Name = "textBox32";
            this.textBox32.TextChanged += new System.EventHandler(this.textBox32_TextChanged);
            // 
            // label78
            // 
            resources.ApplyResources(this.label78, "label78");
            this.label78.Name = "label78";
            // 
            // label71
            // 
            resources.ApplyResources(this.label71, "label71");
            this.label71.Name = "label71";
            // 
            // radioButton156
            // 
            resources.ApplyResources(this.radioButton156, "radioButton156");
            this.radioButton156.Name = "radioButton156";
            this.radioButton156.TabStop = true;
            this.radioButton156.UseVisualStyleBackColor = true;
            this.radioButton156.CheckedChanged += new System.EventHandler(this.radioButton156_CheckedChanged);
            // 
            // radioButton178
            // 
            resources.ApplyResources(this.radioButton178, "radioButton178");
            this.radioButton178.Name = "radioButton178";
            this.radioButton178.TabStop = true;
            this.radioButton178.UseVisualStyleBackColor = true;
            this.radioButton178.CheckedChanged += new System.EventHandler(this.radioButton178_CheckedChanged);
            // 
            // radioButton162
            // 
            resources.ApplyResources(this.radioButton162, "radioButton162");
            this.radioButton162.Name = "radioButton162";
            this.radioButton162.TabStop = true;
            this.radioButton162.UseVisualStyleBackColor = true;
            this.radioButton162.CheckedChanged += new System.EventHandler(this.radioButton162_CheckedChanged);
            // 
            // radioButton157
            // 
            resources.ApplyResources(this.radioButton157, "radioButton157");
            this.radioButton157.Name = "radioButton157";
            this.radioButton157.TabStop = true;
            this.radioButton157.UseVisualStyleBackColor = true;
            this.radioButton157.CheckedChanged += new System.EventHandler(this.radioButton157_CheckedChanged);
            // 
            // radioButton168
            // 
            resources.ApplyResources(this.radioButton168, "radioButton168");
            this.radioButton168.Name = "radioButton168";
            this.radioButton168.TabStop = true;
            this.radioButton168.UseVisualStyleBackColor = true;
            this.radioButton168.CheckedChanged += new System.EventHandler(this.radioButton168_CheckedChanged);
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.textBox33);
            this.groupBox39.Controls.Add(this.label64);
            this.groupBox39.Controls.Add(this.label65);
            this.groupBox39.Controls.Add(this.radioButton158);
            this.groupBox39.Controls.Add(this.radioButton159);
            this.groupBox39.Controls.Add(this.radioButton160);
            this.groupBox39.Controls.Add(this.radioButton161);
            this.groupBox39.Controls.Add(this.radioButton180);
            resources.ApplyResources(this.groupBox39, "groupBox39");
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.TabStop = false;
            // 
            // textBox33
            // 
            resources.ApplyResources(this.textBox33, "textBox33");
            this.textBox33.Name = "textBox33";
            this.textBox33.TextChanged += new System.EventHandler(this.textBox33_TextChanged);
            // 
            // label64
            // 
            resources.ApplyResources(this.label64, "label64");
            this.label64.Name = "label64";
            // 
            // label65
            // 
            resources.ApplyResources(this.label65, "label65");
            this.label65.Name = "label65";
            // 
            // radioButton158
            // 
            resources.ApplyResources(this.radioButton158, "radioButton158");
            this.radioButton158.Name = "radioButton158";
            this.radioButton158.TabStop = true;
            this.radioButton158.UseVisualStyleBackColor = true;
            this.radioButton158.CheckedChanged += new System.EventHandler(this.radioButton158_CheckedChanged);
            // 
            // radioButton159
            // 
            resources.ApplyResources(this.radioButton159, "radioButton159");
            this.radioButton159.Name = "radioButton159";
            this.radioButton159.TabStop = true;
            this.radioButton159.UseVisualStyleBackColor = true;
            this.radioButton159.CheckedChanged += new System.EventHandler(this.radioButton159_CheckedChanged);
            // 
            // radioButton160
            // 
            resources.ApplyResources(this.radioButton160, "radioButton160");
            this.radioButton160.Name = "radioButton160";
            this.radioButton160.TabStop = true;
            this.radioButton160.UseVisualStyleBackColor = true;
            this.radioButton160.CheckedChanged += new System.EventHandler(this.radioButton160_CheckedChanged);
            // 
            // radioButton161
            // 
            resources.ApplyResources(this.radioButton161, "radioButton161");
            this.radioButton161.Name = "radioButton161";
            this.radioButton161.TabStop = true;
            this.radioButton161.UseVisualStyleBackColor = true;
            this.radioButton161.CheckedChanged += new System.EventHandler(this.radioButton161_CheckedChanged);
            // 
            // radioButton180
            // 
            resources.ApplyResources(this.radioButton180, "radioButton180");
            this.radioButton180.Name = "radioButton180";
            this.radioButton180.TabStop = true;
            this.radioButton180.UseVisualStyleBackColor = true;
            this.radioButton180.CheckedChanged += new System.EventHandler(this.radioButton180_CheckedChanged);
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.textBox39);
            this.groupBox40.Controls.Add(this.label79);
            this.groupBox40.Controls.Add(this.label80);
            this.groupBox40.Controls.Add(this.radioButton196);
            this.groupBox40.Controls.Add(this.radioButton197);
            this.groupBox40.Controls.Add(this.radioButton198);
            this.groupBox40.Controls.Add(this.radioButton199);
            this.groupBox40.Controls.Add(this.radioButton200);
            resources.ApplyResources(this.groupBox40, "groupBox40");
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.TabStop = false;
            // 
            // textBox39
            // 
            resources.ApplyResources(this.textBox39, "textBox39");
            this.textBox39.Name = "textBox39";
            this.textBox39.TextChanged += new System.EventHandler(this.textBox39_TextChanged);
            // 
            // label79
            // 
            resources.ApplyResources(this.label79, "label79");
            this.label79.Name = "label79";
            // 
            // label80
            // 
            resources.ApplyResources(this.label80, "label80");
            this.label80.Name = "label80";
            // 
            // radioButton196
            // 
            resources.ApplyResources(this.radioButton196, "radioButton196");
            this.radioButton196.Name = "radioButton196";
            this.radioButton196.TabStop = true;
            this.radioButton196.UseVisualStyleBackColor = true;
            this.radioButton196.CheckedChanged += new System.EventHandler(this.radioButton196_CheckedChanged);
            // 
            // radioButton197
            // 
            resources.ApplyResources(this.radioButton197, "radioButton197");
            this.radioButton197.Name = "radioButton197";
            this.radioButton197.TabStop = true;
            this.radioButton197.UseVisualStyleBackColor = true;
            this.radioButton197.CheckedChanged += new System.EventHandler(this.radioButton197_CheckedChanged);
            // 
            // radioButton198
            // 
            resources.ApplyResources(this.radioButton198, "radioButton198");
            this.radioButton198.Name = "radioButton198";
            this.radioButton198.TabStop = true;
            this.radioButton198.UseVisualStyleBackColor = true;
            this.radioButton198.CheckedChanged += new System.EventHandler(this.radioButton198_CheckedChanged);
            // 
            // radioButton199
            // 
            resources.ApplyResources(this.radioButton199, "radioButton199");
            this.radioButton199.Name = "radioButton199";
            this.radioButton199.TabStop = true;
            this.radioButton199.UseVisualStyleBackColor = true;
            this.radioButton199.CheckedChanged += new System.EventHandler(this.radioButton199_CheckedChanged);
            // 
            // radioButton200
            // 
            resources.ApplyResources(this.radioButton200, "radioButton200");
            this.radioButton200.Name = "radioButton200";
            this.radioButton200.TabStop = true;
            this.radioButton200.UseVisualStyleBackColor = true;
            this.radioButton200.CheckedChanged += new System.EventHandler(this.radioButton200_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox21);
            this.tabPage3.Controls.Add(this.groupBox22);
            this.tabPage3.Controls.Add(this.groupBox23);
            this.tabPage3.Controls.Add(this.groupBox24);
            this.tabPage3.Controls.Add(this.groupBox25);
            this.tabPage3.Controls.Add(this.groupBox26);
            this.tabPage3.Controls.Add(this.groupBox27);
            this.tabPage3.Controls.Add(this.groupBox28);
            this.tabPage3.Controls.Add(this.groupBox29);
            this.tabPage3.Controls.Add(this.groupBox30);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.textBox23);
            this.groupBox21.Controls.Add(this.label44);
            this.groupBox21.Controls.Add(this.label41);
            this.groupBox21.Controls.Add(this.radioButton101);
            this.groupBox21.Controls.Add(this.radioButton103);
            this.groupBox21.Controls.Add(this.radioButton102);
            this.groupBox21.Controls.Add(this.radioButton104);
            this.groupBox21.Controls.Add(this.radioButton105);
            resources.ApplyResources(this.groupBox21, "groupBox21");
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.TabStop = false;
            // 
            // textBox23
            // 
            resources.ApplyResources(this.textBox23, "textBox23");
            this.textBox23.Name = "textBox23";
            this.textBox23.TextChanged += new System.EventHandler(this.textBox23_TextChanged);
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // radioButton101
            // 
            resources.ApplyResources(this.radioButton101, "radioButton101");
            this.radioButton101.Name = "radioButton101";
            this.radioButton101.TabStop = true;
            this.radioButton101.UseVisualStyleBackColor = true;
            this.radioButton101.CheckedChanged += new System.EventHandler(this.radioButton101_CheckedChanged);
            // 
            // radioButton103
            // 
            resources.ApplyResources(this.radioButton103, "radioButton103");
            this.radioButton103.Name = "radioButton103";
            this.radioButton103.TabStop = true;
            this.radioButton103.UseVisualStyleBackColor = true;
            this.radioButton103.CheckedChanged += new System.EventHandler(this.radioButton103_CheckedChanged);
            // 
            // radioButton102
            // 
            resources.ApplyResources(this.radioButton102, "radioButton102");
            this.radioButton102.Name = "radioButton102";
            this.radioButton102.TabStop = true;
            this.radioButton102.UseVisualStyleBackColor = true;
            this.radioButton102.CheckedChanged += new System.EventHandler(this.radioButton102_CheckedChanged);
            // 
            // radioButton104
            // 
            resources.ApplyResources(this.radioButton104, "radioButton104");
            this.radioButton104.Name = "radioButton104";
            this.radioButton104.TabStop = true;
            this.radioButton104.UseVisualStyleBackColor = true;
            this.radioButton104.CheckedChanged += new System.EventHandler(this.radioButton104_CheckedChanged);
            // 
            // radioButton105
            // 
            resources.ApplyResources(this.radioButton105, "radioButton105");
            this.radioButton105.Name = "radioButton105";
            this.radioButton105.TabStop = true;
            this.radioButton105.UseVisualStyleBackColor = true;
            this.radioButton105.CheckedChanged += new System.EventHandler(this.radioButton105_CheckedChanged);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.txtE);
            this.groupBox22.Controls.Add(this.textBox24);
            this.groupBox22.Controls.Add(this.label48);
            this.groupBox22.Controls.Add(this.label49);
            this.groupBox22.Controls.Add(this.radioButton115);
            this.groupBox22.Controls.Add(this.radioButton116);
            this.groupBox22.Controls.Add(this.radioButton117);
            this.groupBox22.Controls.Add(this.radioButton118);
            this.groupBox22.Controls.Add(this.radioButton119);
            resources.ApplyResources(this.groupBox22, "groupBox22");
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.TabStop = false;
            // 
            // txtE
            // 
            resources.ApplyResources(this.txtE, "txtE");
            this.txtE.Name = "txtE";
            // 
            // textBox24
            // 
            resources.ApplyResources(this.textBox24, "textBox24");
            this.textBox24.Name = "textBox24";
            this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // radioButton115
            // 
            resources.ApplyResources(this.radioButton115, "radioButton115");
            this.radioButton115.Name = "radioButton115";
            this.radioButton115.TabStop = true;
            this.radioButton115.UseVisualStyleBackColor = true;
            this.radioButton115.CheckedChanged += new System.EventHandler(this.radioButton115_CheckedChanged);
            // 
            // radioButton116
            // 
            resources.ApplyResources(this.radioButton116, "radioButton116");
            this.radioButton116.Name = "radioButton116";
            this.radioButton116.TabStop = true;
            this.radioButton116.UseVisualStyleBackColor = true;
            this.radioButton116.CheckedChanged += new System.EventHandler(this.radioButton116_CheckedChanged);
            // 
            // radioButton117
            // 
            resources.ApplyResources(this.radioButton117, "radioButton117");
            this.radioButton117.Name = "radioButton117";
            this.radioButton117.TabStop = true;
            this.radioButton117.UseVisualStyleBackColor = true;
            this.radioButton117.CheckedChanged += new System.EventHandler(this.radioButton117_CheckedChanged);
            // 
            // radioButton118
            // 
            resources.ApplyResources(this.radioButton118, "radioButton118");
            this.radioButton118.Name = "radioButton118";
            this.radioButton118.TabStop = true;
            this.radioButton118.UseVisualStyleBackColor = true;
            this.radioButton118.CheckedChanged += new System.EventHandler(this.radioButton118_CheckedChanged);
            // 
            // radioButton119
            // 
            resources.ApplyResources(this.radioButton119, "radioButton119");
            this.radioButton119.Name = "radioButton119";
            this.radioButton119.TabStop = true;
            this.radioButton119.UseVisualStyleBackColor = true;
            this.radioButton119.CheckedChanged += new System.EventHandler(this.radioButton119_CheckedChanged);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.textBox26);
            this.groupBox23.Controls.Add(this.label50);
            this.groupBox23.Controls.Add(this.label46);
            this.groupBox23.Controls.Add(this.radioButton120);
            this.groupBox23.Controls.Add(this.radioButton121);
            this.groupBox23.Controls.Add(this.radioButton122);
            this.groupBox23.Controls.Add(this.radioButton123);
            this.groupBox23.Controls.Add(this.radioButton124);
            resources.ApplyResources(this.groupBox23, "groupBox23");
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.TabStop = false;
            // 
            // textBox26
            // 
            resources.ApplyResources(this.textBox26, "textBox26");
            this.textBox26.Name = "textBox26";
            this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // radioButton120
            // 
            resources.ApplyResources(this.radioButton120, "radioButton120");
            this.radioButton120.Name = "radioButton120";
            this.radioButton120.TabStop = true;
            this.radioButton120.UseVisualStyleBackColor = true;
            this.radioButton120.CheckedChanged += new System.EventHandler(this.radioButton120_CheckedChanged);
            // 
            // radioButton121
            // 
            resources.ApplyResources(this.radioButton121, "radioButton121");
            this.radioButton121.Name = "radioButton121";
            this.radioButton121.TabStop = true;
            this.radioButton121.UseVisualStyleBackColor = true;
            this.radioButton121.CheckedChanged += new System.EventHandler(this.radioButton121_CheckedChanged);
            // 
            // radioButton122
            // 
            resources.ApplyResources(this.radioButton122, "radioButton122");
            this.radioButton122.Name = "radioButton122";
            this.radioButton122.TabStop = true;
            this.radioButton122.UseVisualStyleBackColor = true;
            this.radioButton122.CheckedChanged += new System.EventHandler(this.radioButton122_CheckedChanged);
            // 
            // radioButton123
            // 
            resources.ApplyResources(this.radioButton123, "radioButton123");
            this.radioButton123.Name = "radioButton123";
            this.radioButton123.TabStop = true;
            this.radioButton123.UseVisualStyleBackColor = true;
            this.radioButton123.CheckedChanged += new System.EventHandler(this.radioButton123_CheckedChanged);
            // 
            // radioButton124
            // 
            resources.ApplyResources(this.radioButton124, "radioButton124");
            this.radioButton124.Name = "radioButton124";
            this.radioButton124.TabStop = true;
            this.radioButton124.UseVisualStyleBackColor = true;
            this.radioButton124.CheckedChanged += new System.EventHandler(this.radioButton124_CheckedChanged);
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.textBox25);
            this.groupBox24.Controls.Add(this.label51);
            this.groupBox24.Controls.Add(this.label52);
            this.groupBox24.Controls.Add(this.radioButton125);
            this.groupBox24.Controls.Add(this.radioButton126);
            this.groupBox24.Controls.Add(this.radioButton127);
            this.groupBox24.Controls.Add(this.radioButton128);
            this.groupBox24.Controls.Add(this.radioButton129);
            resources.ApplyResources(this.groupBox24, "groupBox24");
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.TabStop = false;
            // 
            // textBox25
            // 
            resources.ApplyResources(this.textBox25, "textBox25");
            this.textBox25.Name = "textBox25";
            this.textBox25.TextChanged += new System.EventHandler(this.textBox25_TextChanged);
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.Name = "label51";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // radioButton125
            // 
            resources.ApplyResources(this.radioButton125, "radioButton125");
            this.radioButton125.Name = "radioButton125";
            this.radioButton125.TabStop = true;
            this.radioButton125.UseVisualStyleBackColor = true;
            this.radioButton125.CheckedChanged += new System.EventHandler(this.radioButton125_CheckedChanged);
            // 
            // radioButton126
            // 
            resources.ApplyResources(this.radioButton126, "radioButton126");
            this.radioButton126.Name = "radioButton126";
            this.radioButton126.TabStop = true;
            this.radioButton126.UseVisualStyleBackColor = true;
            this.radioButton126.CheckedChanged += new System.EventHandler(this.radioButton126_CheckedChanged);
            // 
            // radioButton127
            // 
            resources.ApplyResources(this.radioButton127, "radioButton127");
            this.radioButton127.Name = "radioButton127";
            this.radioButton127.TabStop = true;
            this.radioButton127.UseVisualStyleBackColor = true;
            this.radioButton127.CheckedChanged += new System.EventHandler(this.radioButton127_CheckedChanged);
            // 
            // radioButton128
            // 
            resources.ApplyResources(this.radioButton128, "radioButton128");
            this.radioButton128.Name = "radioButton128";
            this.radioButton128.TabStop = true;
            this.radioButton128.UseVisualStyleBackColor = true;
            this.radioButton128.CheckedChanged += new System.EventHandler(this.radioButton128_CheckedChanged);
            // 
            // radioButton129
            // 
            resources.ApplyResources(this.radioButton129, "radioButton129");
            this.radioButton129.Name = "radioButton129";
            this.radioButton129.TabStop = true;
            this.radioButton129.UseVisualStyleBackColor = true;
            this.radioButton129.CheckedChanged += new System.EventHandler(this.radioButton129_CheckedChanged);
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.textBox22);
            this.groupBox25.Controls.Add(this.label42);
            this.groupBox25.Controls.Add(this.label43);
            this.groupBox25.Controls.Add(this.radioButton106);
            this.groupBox25.Controls.Add(this.radioButton107);
            this.groupBox25.Controls.Add(this.radioButton108);
            this.groupBox25.Controls.Add(this.radioButton109);
            this.groupBox25.Controls.Add(this.radioButton110);
            resources.ApplyResources(this.groupBox25, "groupBox25");
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.TabStop = false;
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.Name = "textBox22";
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // radioButton106
            // 
            resources.ApplyResources(this.radioButton106, "radioButton106");
            this.radioButton106.Name = "radioButton106";
            this.radioButton106.TabStop = true;
            this.radioButton106.UseVisualStyleBackColor = true;
            this.radioButton106.CheckedChanged += new System.EventHandler(this.radioButton106_CheckedChanged);
            // 
            // radioButton107
            // 
            resources.ApplyResources(this.radioButton107, "radioButton107");
            this.radioButton107.Name = "radioButton107";
            this.radioButton107.TabStop = true;
            this.radioButton107.UseVisualStyleBackColor = true;
            this.radioButton107.CheckedChanged += new System.EventHandler(this.radioButton107_CheckedChanged);
            // 
            // radioButton108
            // 
            resources.ApplyResources(this.radioButton108, "radioButton108");
            this.radioButton108.Name = "radioButton108";
            this.radioButton108.TabStop = true;
            this.radioButton108.UseVisualStyleBackColor = true;
            this.radioButton108.CheckedChanged += new System.EventHandler(this.radioButton108_CheckedChanged);
            // 
            // radioButton109
            // 
            resources.ApplyResources(this.radioButton109, "radioButton109");
            this.radioButton109.Name = "radioButton109";
            this.radioButton109.TabStop = true;
            this.radioButton109.UseVisualStyleBackColor = true;
            this.radioButton109.CheckedChanged += new System.EventHandler(this.radioButton109_CheckedChanged);
            // 
            // radioButton110
            // 
            resources.ApplyResources(this.radioButton110, "radioButton110");
            this.radioButton110.Name = "radioButton110";
            this.radioButton110.TabStop = true;
            this.radioButton110.UseVisualStyleBackColor = true;
            this.radioButton110.CheckedChanged += new System.EventHandler(this.radioButton110_CheckedChanged);
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.textBox21);
            this.groupBox26.Controls.Add(this.label53);
            this.groupBox26.Controls.Add(this.label54);
            this.groupBox26.Controls.Add(this.radioButton130);
            this.groupBox26.Controls.Add(this.radioButton131);
            this.groupBox26.Controls.Add(this.radioButton132);
            this.groupBox26.Controls.Add(this.radioButton133);
            this.groupBox26.Controls.Add(this.radioButton134);
            resources.ApplyResources(this.groupBox26, "groupBox26");
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.TabStop = false;
            // 
            // textBox21
            // 
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.Name = "textBox21";
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.Name = "label53";
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.Name = "label54";
            // 
            // radioButton130
            // 
            resources.ApplyResources(this.radioButton130, "radioButton130");
            this.radioButton130.Name = "radioButton130";
            this.radioButton130.TabStop = true;
            this.radioButton130.UseVisualStyleBackColor = true;
            this.radioButton130.CheckedChanged += new System.EventHandler(this.radioButton130_CheckedChanged);
            // 
            // radioButton131
            // 
            resources.ApplyResources(this.radioButton131, "radioButton131");
            this.radioButton131.Name = "radioButton131";
            this.radioButton131.TabStop = true;
            this.radioButton131.UseVisualStyleBackColor = true;
            this.radioButton131.CheckedChanged += new System.EventHandler(this.radioButton131_CheckedChanged);
            // 
            // radioButton132
            // 
            resources.ApplyResources(this.radioButton132, "radioButton132");
            this.radioButton132.Name = "radioButton132";
            this.radioButton132.TabStop = true;
            this.radioButton132.UseVisualStyleBackColor = true;
            this.radioButton132.CheckedChanged += new System.EventHandler(this.radioButton132_CheckedChanged);
            // 
            // radioButton133
            // 
            resources.ApplyResources(this.radioButton133, "radioButton133");
            this.radioButton133.Name = "radioButton133";
            this.radioButton133.TabStop = true;
            this.radioButton133.UseVisualStyleBackColor = true;
            this.radioButton133.CheckedChanged += new System.EventHandler(this.radioButton133_CheckedChanged);
            // 
            // radioButton134
            // 
            resources.ApplyResources(this.radioButton134, "radioButton134");
            this.radioButton134.Name = "radioButton134";
            this.radioButton134.TabStop = true;
            this.radioButton134.UseVisualStyleBackColor = true;
            this.radioButton134.CheckedChanged += new System.EventHandler(this.radioButton134_CheckedChanged);
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.textBox27);
            this.groupBox27.Controls.Add(this.label55);
            this.groupBox27.Controls.Add(this.label56);
            this.groupBox27.Controls.Add(this.radioButton136);
            this.groupBox27.Controls.Add(this.radioButton137);
            this.groupBox27.Controls.Add(this.radioButton138);
            this.groupBox27.Controls.Add(this.radioButton139);
            this.groupBox27.Controls.Add(this.radioButton140);
            resources.ApplyResources(this.groupBox27, "groupBox27");
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.TabStop = false;
            // 
            // textBox27
            // 
            resources.ApplyResources(this.textBox27, "textBox27");
            this.textBox27.Name = "textBox27";
            this.textBox27.TextChanged += new System.EventHandler(this.textBox27_TextChanged);
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.Name = "label55";
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.Name = "label56";
            // 
            // radioButton136
            // 
            resources.ApplyResources(this.radioButton136, "radioButton136");
            this.radioButton136.Name = "radioButton136";
            this.radioButton136.TabStop = true;
            this.radioButton136.UseVisualStyleBackColor = true;
            this.radioButton136.CheckedChanged += new System.EventHandler(this.radioButton136_CheckedChanged);
            // 
            // radioButton137
            // 
            resources.ApplyResources(this.radioButton137, "radioButton137");
            this.radioButton137.Name = "radioButton137";
            this.radioButton137.TabStop = true;
            this.radioButton137.UseVisualStyleBackColor = true;
            this.radioButton137.CheckedChanged += new System.EventHandler(this.radioButton137_CheckedChanged);
            // 
            // radioButton138
            // 
            resources.ApplyResources(this.radioButton138, "radioButton138");
            this.radioButton138.Name = "radioButton138";
            this.radioButton138.TabStop = true;
            this.radioButton138.UseVisualStyleBackColor = true;
            this.radioButton138.CheckedChanged += new System.EventHandler(this.radioButton138_CheckedChanged);
            // 
            // radioButton139
            // 
            resources.ApplyResources(this.radioButton139, "radioButton139");
            this.radioButton139.Name = "radioButton139";
            this.radioButton139.TabStop = true;
            this.radioButton139.UseVisualStyleBackColor = true;
            this.radioButton139.CheckedChanged += new System.EventHandler(this.radioButton139_CheckedChanged);
            // 
            // radioButton140
            // 
            resources.ApplyResources(this.radioButton140, "radioButton140");
            this.radioButton140.Name = "radioButton140";
            this.radioButton140.TabStop = true;
            this.radioButton140.UseVisualStyleBackColor = true;
            this.radioButton140.CheckedChanged += new System.EventHandler(this.radioButton140_CheckedChanged);
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.textBox29);
            this.groupBox28.Controls.Add(this.label47);
            this.groupBox28.Controls.Add(this.label45);
            this.groupBox28.Controls.Add(this.radioButton111);
            this.groupBox28.Controls.Add(this.radioButton112);
            this.groupBox28.Controls.Add(this.radioButton113);
            this.groupBox28.Controls.Add(this.radioButton114);
            this.groupBox28.Controls.Add(this.radioButton135);
            resources.ApplyResources(this.groupBox28, "groupBox28");
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.TabStop = false;
            // 
            // textBox29
            // 
            resources.ApplyResources(this.textBox29, "textBox29");
            this.textBox29.Name = "textBox29";
            this.textBox29.TextChanged += new System.EventHandler(this.textBox29_TextChanged);
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // radioButton111
            // 
            resources.ApplyResources(this.radioButton111, "radioButton111");
            this.radioButton111.Name = "radioButton111";
            this.radioButton111.TabStop = true;
            this.radioButton111.UseVisualStyleBackColor = true;
            this.radioButton111.CheckedChanged += new System.EventHandler(this.radioButton111_CheckedChanged);
            // 
            // radioButton112
            // 
            resources.ApplyResources(this.radioButton112, "radioButton112");
            this.radioButton112.Name = "radioButton112";
            this.radioButton112.TabStop = true;
            this.radioButton112.UseVisualStyleBackColor = true;
            this.radioButton112.CheckedChanged += new System.EventHandler(this.radioButton112_CheckedChanged);
            // 
            // radioButton113
            // 
            resources.ApplyResources(this.radioButton113, "radioButton113");
            this.radioButton113.Name = "radioButton113";
            this.radioButton113.TabStop = true;
            this.radioButton113.UseVisualStyleBackColor = true;
            this.radioButton113.CheckedChanged += new System.EventHandler(this.radioButton113_CheckedChanged);
            // 
            // radioButton114
            // 
            resources.ApplyResources(this.radioButton114, "radioButton114");
            this.radioButton114.Name = "radioButton114";
            this.radioButton114.TabStop = true;
            this.radioButton114.UseVisualStyleBackColor = true;
            this.radioButton114.CheckedChanged += new System.EventHandler(this.radioButton114_CheckedChanged);
            // 
            // radioButton135
            // 
            resources.ApplyResources(this.radioButton135, "radioButton135");
            this.radioButton135.Name = "radioButton135";
            this.radioButton135.TabStop = true;
            this.radioButton135.UseVisualStyleBackColor = true;
            this.radioButton135.CheckedChanged += new System.EventHandler(this.radioButton135_CheckedChanged);
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.textBox28);
            this.groupBox29.Controls.Add(this.label57);
            this.groupBox29.Controls.Add(this.label58);
            this.groupBox29.Controls.Add(this.radioButton141);
            this.groupBox29.Controls.Add(this.radioButton142);
            this.groupBox29.Controls.Add(this.radioButton143);
            this.groupBox29.Controls.Add(this.radioButton144);
            this.groupBox29.Controls.Add(this.radioButton145);
            resources.ApplyResources(this.groupBox29, "groupBox29");
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.TabStop = false;
            // 
            // textBox28
            // 
            resources.ApplyResources(this.textBox28, "textBox28");
            this.textBox28.Name = "textBox28";
            this.textBox28.TextChanged += new System.EventHandler(this.textBox28_TextChanged);
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.Name = "label57";
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.Name = "label58";
            // 
            // radioButton141
            // 
            resources.ApplyResources(this.radioButton141, "radioButton141");
            this.radioButton141.Name = "radioButton141";
            this.radioButton141.TabStop = true;
            this.radioButton141.UseVisualStyleBackColor = true;
            this.radioButton141.CheckedChanged += new System.EventHandler(this.radioButton141_CheckedChanged);
            // 
            // radioButton142
            // 
            resources.ApplyResources(this.radioButton142, "radioButton142");
            this.radioButton142.Name = "radioButton142";
            this.radioButton142.TabStop = true;
            this.radioButton142.UseVisualStyleBackColor = true;
            this.radioButton142.CheckedChanged += new System.EventHandler(this.radioButton142_CheckedChanged);
            // 
            // radioButton143
            // 
            resources.ApplyResources(this.radioButton143, "radioButton143");
            this.radioButton143.Name = "radioButton143";
            this.radioButton143.TabStop = true;
            this.radioButton143.UseVisualStyleBackColor = true;
            this.radioButton143.CheckedChanged += new System.EventHandler(this.radioButton143_CheckedChanged);
            // 
            // radioButton144
            // 
            resources.ApplyResources(this.radioButton144, "radioButton144");
            this.radioButton144.Name = "radioButton144";
            this.radioButton144.TabStop = true;
            this.radioButton144.UseVisualStyleBackColor = true;
            this.radioButton144.CheckedChanged += new System.EventHandler(this.radioButton144_CheckedChanged);
            // 
            // radioButton145
            // 
            resources.ApplyResources(this.radioButton145, "radioButton145");
            this.radioButton145.Name = "radioButton145";
            this.radioButton145.TabStop = true;
            this.radioButton145.UseVisualStyleBackColor = true;
            this.radioButton145.CheckedChanged += new System.EventHandler(this.radioButton145_CheckedChanged);
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.textBox30);
            this.groupBox30.Controls.Add(this.label59);
            this.groupBox30.Controls.Add(this.label60);
            this.groupBox30.Controls.Add(this.radioButton146);
            this.groupBox30.Controls.Add(this.radioButton147);
            this.groupBox30.Controls.Add(this.radioButton148);
            this.groupBox30.Controls.Add(this.radioButton149);
            this.groupBox30.Controls.Add(this.radioButton150);
            resources.ApplyResources(this.groupBox30, "groupBox30");
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.TabStop = false;
            // 
            // textBox30
            // 
            resources.ApplyResources(this.textBox30, "textBox30");
            this.textBox30.Name = "textBox30";
            this.textBox30.TextChanged += new System.EventHandler(this.textBox30_TextChanged);
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.Name = "label59";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.Name = "label60";
            // 
            // radioButton146
            // 
            resources.ApplyResources(this.radioButton146, "radioButton146");
            this.radioButton146.Name = "radioButton146";
            this.radioButton146.TabStop = true;
            this.radioButton146.UseVisualStyleBackColor = true;
            this.radioButton146.CheckedChanged += new System.EventHandler(this.radioButton146_CheckedChanged);
            // 
            // radioButton147
            // 
            resources.ApplyResources(this.radioButton147, "radioButton147");
            this.radioButton147.Name = "radioButton147";
            this.radioButton147.TabStop = true;
            this.radioButton147.UseVisualStyleBackColor = true;
            this.radioButton147.CheckedChanged += new System.EventHandler(this.radioButton147_CheckedChanged);
            // 
            // radioButton148
            // 
            resources.ApplyResources(this.radioButton148, "radioButton148");
            this.radioButton148.Name = "radioButton148";
            this.radioButton148.TabStop = true;
            this.radioButton148.UseVisualStyleBackColor = true;
            this.radioButton148.CheckedChanged += new System.EventHandler(this.radioButton148_CheckedChanged);
            // 
            // radioButton149
            // 
            resources.ApplyResources(this.radioButton149, "radioButton149");
            this.radioButton149.Name = "radioButton149";
            this.radioButton149.TabStop = true;
            this.radioButton149.UseVisualStyleBackColor = true;
            this.radioButton149.CheckedChanged += new System.EventHandler(this.radioButton149_CheckedChanged);
            // 
            // radioButton150
            // 
            resources.ApplyResources(this.radioButton150, "radioButton150");
            this.radioButton150.Name = "radioButton150";
            this.radioButton150.TabStop = true;
            this.radioButton150.UseVisualStyleBackColor = true;
            this.radioButton150.CheckedChanged += new System.EventHandler(this.radioButton150_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox17);
            this.tabPage2.Controls.Add(this.groupBox18);
            this.tabPage2.Controls.Add(this.groupBox19);
            this.tabPage2.Controls.Add(this.groupBox20);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox17);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.radioButton51);
            this.groupBox11.Controls.Add(this.radioButton52);
            this.groupBox11.Controls.Add(this.radioButton53);
            this.groupBox11.Controls.Add(this.radioButton54);
            this.groupBox11.Controls.Add(this.radioButton55);
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // radioButton51
            // 
            resources.ApplyResources(this.radioButton51, "radioButton51");
            this.radioButton51.Name = "radioButton51";
            this.radioButton51.TabStop = true;
            this.radioButton51.UseVisualStyleBackColor = true;
            this.radioButton51.CheckedChanged += new System.EventHandler(this.radioButton51_CheckedChanged);
            // 
            // radioButton52
            // 
            resources.ApplyResources(this.radioButton52, "radioButton52");
            this.radioButton52.Name = "radioButton52";
            this.radioButton52.TabStop = true;
            this.radioButton52.UseVisualStyleBackColor = true;
            this.radioButton52.CheckedChanged += new System.EventHandler(this.radioButton52_CheckedChanged);
            // 
            // radioButton53
            // 
            resources.ApplyResources(this.radioButton53, "radioButton53");
            this.radioButton53.Name = "radioButton53";
            this.radioButton53.TabStop = true;
            this.radioButton53.UseVisualStyleBackColor = true;
            this.radioButton53.CheckedChanged += new System.EventHandler(this.radioButton53_CheckedChanged);
            // 
            // radioButton54
            // 
            resources.ApplyResources(this.radioButton54, "radioButton54");
            this.radioButton54.Name = "radioButton54";
            this.radioButton54.TabStop = true;
            this.radioButton54.UseVisualStyleBackColor = true;
            this.radioButton54.CheckedChanged += new System.EventHandler(this.radioButton54_CheckedChanged);
            // 
            // radioButton55
            // 
            resources.ApplyResources(this.radioButton55, "radioButton55");
            this.radioButton55.Name = "radioButton55";
            this.radioButton55.TabStop = true;
            this.radioButton55.UseVisualStyleBackColor = true;
            this.radioButton55.CheckedChanged += new System.EventHandler(this.radioButton55_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox18);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.radioButton56);
            this.groupBox12.Controls.Add(this.radioButton57);
            this.groupBox12.Controls.Add(this.radioButton58);
            this.groupBox12.Controls.Add(this.radioButton59);
            this.groupBox12.Controls.Add(this.radioButton60);
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // radioButton56
            // 
            resources.ApplyResources(this.radioButton56, "radioButton56");
            this.radioButton56.Name = "radioButton56";
            this.radioButton56.TabStop = true;
            this.radioButton56.UseVisualStyleBackColor = true;
            this.radioButton56.CheckedChanged += new System.EventHandler(this.radioButton56_CheckedChanged);
            // 
            // radioButton57
            // 
            resources.ApplyResources(this.radioButton57, "radioButton57");
            this.radioButton57.Name = "radioButton57";
            this.radioButton57.TabStop = true;
            this.radioButton57.UseVisualStyleBackColor = true;
            this.radioButton57.CheckedChanged += new System.EventHandler(this.radioButton57_CheckedChanged);
            // 
            // radioButton58
            // 
            resources.ApplyResources(this.radioButton58, "radioButton58");
            this.radioButton58.Name = "radioButton58";
            this.radioButton58.TabStop = true;
            this.radioButton58.UseVisualStyleBackColor = true;
            this.radioButton58.CheckedChanged += new System.EventHandler(this.radioButton58_CheckedChanged);
            // 
            // radioButton59
            // 
            resources.ApplyResources(this.radioButton59, "radioButton59");
            this.radioButton59.Name = "radioButton59";
            this.radioButton59.TabStop = true;
            this.radioButton59.UseVisualStyleBackColor = true;
            this.radioButton59.CheckedChanged += new System.EventHandler(this.radioButton59_CheckedChanged);
            // 
            // radioButton60
            // 
            resources.ApplyResources(this.radioButton60, "radioButton60");
            this.radioButton60.Name = "radioButton60";
            this.radioButton60.TabStop = true;
            this.radioButton60.UseVisualStyleBackColor = true;
            this.radioButton60.CheckedChanged += new System.EventHandler(this.radioButton60_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBox20);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.label26);
            this.groupBox13.Controls.Add(this.radioButton61);
            this.groupBox13.Controls.Add(this.radioButton62);
            this.groupBox13.Controls.Add(this.radioButton63);
            this.groupBox13.Controls.Add(this.radioButton64);
            this.groupBox13.Controls.Add(this.radioButton65);
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            // 
            // textBox20
            // 
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.Name = "textBox20";
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // radioButton61
            // 
            resources.ApplyResources(this.radioButton61, "radioButton61");
            this.radioButton61.Name = "radioButton61";
            this.radioButton61.TabStop = true;
            this.radioButton61.UseVisualStyleBackColor = true;
            this.radioButton61.CheckedChanged += new System.EventHandler(this.radioButton61_CheckedChanged);
            // 
            // radioButton62
            // 
            resources.ApplyResources(this.radioButton62, "radioButton62");
            this.radioButton62.Name = "radioButton62";
            this.radioButton62.TabStop = true;
            this.radioButton62.UseVisualStyleBackColor = true;
            this.radioButton62.CheckedChanged += new System.EventHandler(this.radioButton62_CheckedChanged);
            // 
            // radioButton63
            // 
            resources.ApplyResources(this.radioButton63, "radioButton63");
            this.radioButton63.Name = "radioButton63";
            this.radioButton63.TabStop = true;
            this.radioButton63.UseVisualStyleBackColor = true;
            this.radioButton63.CheckedChanged += new System.EventHandler(this.radioButton63_CheckedChanged);
            // 
            // radioButton64
            // 
            resources.ApplyResources(this.radioButton64, "radioButton64");
            this.radioButton64.Name = "radioButton64";
            this.radioButton64.TabStop = true;
            this.radioButton64.UseVisualStyleBackColor = true;
            this.radioButton64.CheckedChanged += new System.EventHandler(this.radioButton64_CheckedChanged);
            // 
            // radioButton65
            // 
            resources.ApplyResources(this.radioButton65, "radioButton65");
            this.radioButton65.Name = "radioButton65";
            this.radioButton65.TabStop = true;
            this.radioButton65.UseVisualStyleBackColor = true;
            this.radioButton65.CheckedChanged += new System.EventHandler(this.radioButton65_CheckedChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBox19);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.label28);
            this.groupBox14.Controls.Add(this.radioButton66);
            this.groupBox14.Controls.Add(this.radioButton67);
            this.groupBox14.Controls.Add(this.radioButton68);
            this.groupBox14.Controls.Add(this.radioButton69);
            this.groupBox14.Controls.Add(this.radioButton70);
            resources.ApplyResources(this.groupBox14, "groupBox14");
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.TabStop = false;
            // 
            // textBox19
            // 
            resources.ApplyResources(this.textBox19, "textBox19");
            this.textBox19.Name = "textBox19";
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // radioButton66
            // 
            resources.ApplyResources(this.radioButton66, "radioButton66");
            this.radioButton66.Name = "radioButton66";
            this.radioButton66.TabStop = true;
            this.radioButton66.UseVisualStyleBackColor = true;
            this.radioButton66.CheckedChanged += new System.EventHandler(this.radioButton66_CheckedChanged);
            // 
            // radioButton67
            // 
            resources.ApplyResources(this.radioButton67, "radioButton67");
            this.radioButton67.Name = "radioButton67";
            this.radioButton67.TabStop = true;
            this.radioButton67.UseVisualStyleBackColor = true;
            this.radioButton67.CheckedChanged += new System.EventHandler(this.radioButton67_CheckedChanged);
            // 
            // radioButton68
            // 
            resources.ApplyResources(this.radioButton68, "radioButton68");
            this.radioButton68.Name = "radioButton68";
            this.radioButton68.TabStop = true;
            this.radioButton68.UseVisualStyleBackColor = true;
            this.radioButton68.CheckedChanged += new System.EventHandler(this.radioButton68_CheckedChanged);
            // 
            // radioButton69
            // 
            resources.ApplyResources(this.radioButton69, "radioButton69");
            this.radioButton69.Name = "radioButton69";
            this.radioButton69.TabStop = true;
            this.radioButton69.UseVisualStyleBackColor = true;
            this.radioButton69.CheckedChanged += new System.EventHandler(this.radioButton69_CheckedChanged);
            // 
            // radioButton70
            // 
            resources.ApplyResources(this.radioButton70, "radioButton70");
            this.radioButton70.Name = "radioButton70";
            this.radioButton70.TabStop = true;
            this.radioButton70.UseVisualStyleBackColor = true;
            this.radioButton70.CheckedChanged += new System.EventHandler(this.radioButton70_CheckedChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox13);
            this.groupBox15.Controls.Add(this.label29);
            this.groupBox15.Controls.Add(this.label30);
            this.groupBox15.Controls.Add(this.radioButton71);
            this.groupBox15.Controls.Add(this.radioButton72);
            this.groupBox15.Controls.Add(this.radioButton73);
            this.groupBox15.Controls.Add(this.radioButton74);
            this.groupBox15.Controls.Add(this.radioButton75);
            resources.ApplyResources(this.groupBox15, "groupBox15");
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.TabStop = false;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // radioButton71
            // 
            resources.ApplyResources(this.radioButton71, "radioButton71");
            this.radioButton71.Name = "radioButton71";
            this.radioButton71.TabStop = true;
            this.radioButton71.UseVisualStyleBackColor = true;
            this.radioButton71.CheckedChanged += new System.EventHandler(this.radioButton71_CheckedChanged);
            // 
            // radioButton72
            // 
            resources.ApplyResources(this.radioButton72, "radioButton72");
            this.radioButton72.Name = "radioButton72";
            this.radioButton72.TabStop = true;
            this.radioButton72.UseVisualStyleBackColor = true;
            this.radioButton72.CheckedChanged += new System.EventHandler(this.radioButton72_CheckedChanged);
            // 
            // radioButton73
            // 
            resources.ApplyResources(this.radioButton73, "radioButton73");
            this.radioButton73.Name = "radioButton73";
            this.radioButton73.TabStop = true;
            this.radioButton73.UseVisualStyleBackColor = true;
            this.radioButton73.CheckedChanged += new System.EventHandler(this.radioButton73_CheckedChanged);
            // 
            // radioButton74
            // 
            resources.ApplyResources(this.radioButton74, "radioButton74");
            this.radioButton74.Name = "radioButton74";
            this.radioButton74.TabStop = true;
            this.radioButton74.UseVisualStyleBackColor = true;
            this.radioButton74.CheckedChanged += new System.EventHandler(this.radioButton74_CheckedChanged);
            // 
            // radioButton75
            // 
            resources.ApplyResources(this.radioButton75, "radioButton75");
            this.radioButton75.Name = "radioButton75";
            this.radioButton75.TabStop = true;
            this.radioButton75.UseVisualStyleBackColor = true;
            this.radioButton75.CheckedChanged += new System.EventHandler(this.radioButton75_CheckedChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.txtN);
            this.groupBox16.Controls.Add(this.textBox12);
            this.groupBox16.Controls.Add(this.label31);
            this.groupBox16.Controls.Add(this.label32);
            this.groupBox16.Controls.Add(this.radioButton76);
            this.groupBox16.Controls.Add(this.radioButton77);
            this.groupBox16.Controls.Add(this.radioButton78);
            this.groupBox16.Controls.Add(this.radioButton79);
            this.groupBox16.Controls.Add(this.radioButton80);
            resources.ApplyResources(this.groupBox16, "groupBox16");
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.TabStop = false;
            // 
            // txtN
            // 
            resources.ApplyResources(this.txtN, "txtN");
            this.txtN.Name = "txtN";
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // radioButton76
            // 
            resources.ApplyResources(this.radioButton76, "radioButton76");
            this.radioButton76.Name = "radioButton76";
            this.radioButton76.TabStop = true;
            this.radioButton76.UseVisualStyleBackColor = true;
            this.radioButton76.CheckedChanged += new System.EventHandler(this.radioButton76_CheckedChanged);
            // 
            // radioButton77
            // 
            resources.ApplyResources(this.radioButton77, "radioButton77");
            this.radioButton77.Name = "radioButton77";
            this.radioButton77.TabStop = true;
            this.radioButton77.UseVisualStyleBackColor = true;
            this.radioButton77.CheckedChanged += new System.EventHandler(this.radioButton77_CheckedChanged);
            // 
            // radioButton78
            // 
            resources.ApplyResources(this.radioButton78, "radioButton78");
            this.radioButton78.Name = "radioButton78";
            this.radioButton78.TabStop = true;
            this.radioButton78.UseVisualStyleBackColor = true;
            this.radioButton78.CheckedChanged += new System.EventHandler(this.radioButton78_CheckedChanged);
            // 
            // radioButton79
            // 
            resources.ApplyResources(this.radioButton79, "radioButton79");
            this.radioButton79.Name = "radioButton79";
            this.radioButton79.TabStop = true;
            this.radioButton79.UseVisualStyleBackColor = true;
            this.radioButton79.CheckedChanged += new System.EventHandler(this.radioButton79_CheckedChanged);
            // 
            // radioButton80
            // 
            resources.ApplyResources(this.radioButton80, "radioButton80");
            this.radioButton80.Name = "radioButton80";
            this.radioButton80.TabStop = true;
            this.radioButton80.UseVisualStyleBackColor = true;
            this.radioButton80.CheckedChanged += new System.EventHandler(this.radioButton80_CheckedChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox11);
            this.groupBox17.Controls.Add(this.label33);
            this.groupBox17.Controls.Add(this.label34);
            this.groupBox17.Controls.Add(this.radioButton81);
            this.groupBox17.Controls.Add(this.radioButton82);
            this.groupBox17.Controls.Add(this.radioButton83);
            this.groupBox17.Controls.Add(this.radioButton84);
            this.groupBox17.Controls.Add(this.radioButton85);
            resources.ApplyResources(this.groupBox17, "groupBox17");
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.TabStop = false;
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // radioButton81
            // 
            resources.ApplyResources(this.radioButton81, "radioButton81");
            this.radioButton81.Name = "radioButton81";
            this.radioButton81.TabStop = true;
            this.radioButton81.UseVisualStyleBackColor = true;
            this.radioButton81.CheckedChanged += new System.EventHandler(this.radioButton81_CheckedChanged);
            // 
            // radioButton82
            // 
            resources.ApplyResources(this.radioButton82, "radioButton82");
            this.radioButton82.Name = "radioButton82";
            this.radioButton82.TabStop = true;
            this.radioButton82.UseVisualStyleBackColor = true;
            this.radioButton82.CheckedChanged += new System.EventHandler(this.radioButton82_CheckedChanged);
            // 
            // radioButton83
            // 
            resources.ApplyResources(this.radioButton83, "radioButton83");
            this.radioButton83.Name = "radioButton83";
            this.radioButton83.TabStop = true;
            this.radioButton83.UseVisualStyleBackColor = true;
            this.radioButton83.CheckedChanged += new System.EventHandler(this.radioButton83_CheckedChanged);
            // 
            // radioButton84
            // 
            resources.ApplyResources(this.radioButton84, "radioButton84");
            this.radioButton84.Name = "radioButton84";
            this.radioButton84.TabStop = true;
            this.radioButton84.UseVisualStyleBackColor = true;
            this.radioButton84.CheckedChanged += new System.EventHandler(this.radioButton84_CheckedChanged);
            // 
            // radioButton85
            // 
            resources.ApplyResources(this.radioButton85, "radioButton85");
            this.radioButton85.Name = "radioButton85";
            this.radioButton85.TabStop = true;
            this.radioButton85.UseVisualStyleBackColor = true;
            this.radioButton85.CheckedChanged += new System.EventHandler(this.radioButton85_CheckedChanged);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.textBox16);
            this.groupBox18.Controls.Add(this.label35);
            this.groupBox18.Controls.Add(this.label36);
            this.groupBox18.Controls.Add(this.radioButton86);
            this.groupBox18.Controls.Add(this.radioButton87);
            this.groupBox18.Controls.Add(this.radioButton88);
            this.groupBox18.Controls.Add(this.radioButton89);
            this.groupBox18.Controls.Add(this.radioButton90);
            resources.ApplyResources(this.groupBox18, "groupBox18");
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.TabStop = false;
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // radioButton86
            // 
            resources.ApplyResources(this.radioButton86, "radioButton86");
            this.radioButton86.Name = "radioButton86";
            this.radioButton86.TabStop = true;
            this.radioButton86.UseVisualStyleBackColor = true;
            this.radioButton86.CheckedChanged += new System.EventHandler(this.radioButton86_CheckedChanged);
            // 
            // radioButton87
            // 
            resources.ApplyResources(this.radioButton87, "radioButton87");
            this.radioButton87.Name = "radioButton87";
            this.radioButton87.TabStop = true;
            this.radioButton87.UseVisualStyleBackColor = true;
            this.radioButton87.CheckedChanged += new System.EventHandler(this.radioButton87_CheckedChanged);
            // 
            // radioButton88
            // 
            resources.ApplyResources(this.radioButton88, "radioButton88");
            this.radioButton88.Name = "radioButton88";
            this.radioButton88.TabStop = true;
            this.radioButton88.UseVisualStyleBackColor = true;
            this.radioButton88.CheckedChanged += new System.EventHandler(this.radioButton88_CheckedChanged);
            // 
            // radioButton89
            // 
            resources.ApplyResources(this.radioButton89, "radioButton89");
            this.radioButton89.Name = "radioButton89";
            this.radioButton89.TabStop = true;
            this.radioButton89.UseVisualStyleBackColor = true;
            this.radioButton89.CheckedChanged += new System.EventHandler(this.radioButton89_CheckedChanged);
            // 
            // radioButton90
            // 
            resources.ApplyResources(this.radioButton90, "radioButton90");
            this.radioButton90.Name = "radioButton90";
            this.radioButton90.TabStop = true;
            this.radioButton90.UseVisualStyleBackColor = true;
            this.radioButton90.CheckedChanged += new System.EventHandler(this.radioButton90_CheckedChanged);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.textBox15);
            this.groupBox19.Controls.Add(this.label37);
            this.groupBox19.Controls.Add(this.label38);
            this.groupBox19.Controls.Add(this.radioButton91);
            this.groupBox19.Controls.Add(this.radioButton92);
            this.groupBox19.Controls.Add(this.radioButton93);
            this.groupBox19.Controls.Add(this.radioButton94);
            this.groupBox19.Controls.Add(this.radioButton95);
            resources.ApplyResources(this.groupBox19, "groupBox19");
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.TabStop = false;
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // radioButton91
            // 
            resources.ApplyResources(this.radioButton91, "radioButton91");
            this.radioButton91.Name = "radioButton91";
            this.radioButton91.TabStop = true;
            this.radioButton91.UseVisualStyleBackColor = true;
            this.radioButton91.CheckedChanged += new System.EventHandler(this.radioButton91_CheckedChanged);
            // 
            // radioButton92
            // 
            resources.ApplyResources(this.radioButton92, "radioButton92");
            this.radioButton92.Name = "radioButton92";
            this.radioButton92.TabStop = true;
            this.radioButton92.UseVisualStyleBackColor = true;
            this.radioButton92.CheckedChanged += new System.EventHandler(this.radioButton92_CheckedChanged);
            // 
            // radioButton93
            // 
            resources.ApplyResources(this.radioButton93, "radioButton93");
            this.radioButton93.Name = "radioButton93";
            this.radioButton93.TabStop = true;
            this.radioButton93.UseVisualStyleBackColor = true;
            this.radioButton93.CheckedChanged += new System.EventHandler(this.radioButton93_CheckedChanged);
            // 
            // radioButton94
            // 
            resources.ApplyResources(this.radioButton94, "radioButton94");
            this.radioButton94.Name = "radioButton94";
            this.radioButton94.TabStop = true;
            this.radioButton94.UseVisualStyleBackColor = true;
            this.radioButton94.CheckedChanged += new System.EventHandler(this.radioButton94_CheckedChanged);
            // 
            // radioButton95
            // 
            resources.ApplyResources(this.radioButton95, "radioButton95");
            this.radioButton95.Name = "radioButton95";
            this.radioButton95.TabStop = true;
            this.radioButton95.UseVisualStyleBackColor = true;
            this.radioButton95.CheckedChanged += new System.EventHandler(this.radioButton95_CheckedChanged);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.textBox14);
            this.groupBox20.Controls.Add(this.label39);
            this.groupBox20.Controls.Add(this.label40);
            this.groupBox20.Controls.Add(this.radioButton96);
            this.groupBox20.Controls.Add(this.radioButton97);
            this.groupBox20.Controls.Add(this.radioButton98);
            this.groupBox20.Controls.Add(this.radioButton99);
            this.groupBox20.Controls.Add(this.radioButton100);
            resources.ApplyResources(this.groupBox20, "groupBox20");
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.TabStop = false;
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // radioButton96
            // 
            resources.ApplyResources(this.radioButton96, "radioButton96");
            this.radioButton96.Name = "radioButton96";
            this.radioButton96.TabStop = true;
            this.radioButton96.UseVisualStyleBackColor = true;
            this.radioButton96.CheckedChanged += new System.EventHandler(this.radioButton96_CheckedChanged);
            // 
            // radioButton97
            // 
            resources.ApplyResources(this.radioButton97, "radioButton97");
            this.radioButton97.Name = "radioButton97";
            this.radioButton97.TabStop = true;
            this.radioButton97.UseVisualStyleBackColor = true;
            this.radioButton97.CheckedChanged += new System.EventHandler(this.radioButton97_CheckedChanged);
            // 
            // radioButton98
            // 
            resources.ApplyResources(this.radioButton98, "radioButton98");
            this.radioButton98.Name = "radioButton98";
            this.radioButton98.TabStop = true;
            this.radioButton98.UseVisualStyleBackColor = true;
            this.radioButton98.CheckedChanged += new System.EventHandler(this.radioButton98_CheckedChanged);
            // 
            // radioButton99
            // 
            resources.ApplyResources(this.radioButton99, "radioButton99");
            this.radioButton99.Name = "radioButton99";
            this.radioButton99.TabStop = true;
            this.radioButton99.UseVisualStyleBackColor = true;
            this.radioButton99.CheckedChanged += new System.EventHandler(this.radioButton99_CheckedChanged);
            // 
            // radioButton100
            // 
            resources.ApplyResources(this.radioButton100, "radioButton100");
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.TabStop = true;
            this.radioButton100.UseVisualStyleBackColor = true;
            this.radioButton100.CheckedChanged += new System.EventHandler(this.radioButton100_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox10);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.radioButton46);
            this.groupBox10.Controls.Add(this.radioButton47);
            this.groupBox10.Controls.Add(this.radioButton48);
            this.groupBox10.Controls.Add(this.radioButton49);
            this.groupBox10.Controls.Add(this.radioButton50);
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // radioButton46
            // 
            resources.ApplyResources(this.radioButton46, "radioButton46");
            this.radioButton46.Name = "radioButton46";
            this.radioButton46.TabStop = true;
            this.radioButton46.UseVisualStyleBackColor = true;
            this.radioButton46.CheckedChanged += new System.EventHandler(this.radioButton46_CheckedChanged);
            // 
            // radioButton47
            // 
            resources.ApplyResources(this.radioButton47, "radioButton47");
            this.radioButton47.Name = "radioButton47";
            this.radioButton47.TabStop = true;
            this.radioButton47.UseVisualStyleBackColor = true;
            this.radioButton47.CheckedChanged += new System.EventHandler(this.radioButton47_CheckedChanged);
            // 
            // radioButton48
            // 
            resources.ApplyResources(this.radioButton48, "radioButton48");
            this.radioButton48.Name = "radioButton48";
            this.radioButton48.TabStop = true;
            this.radioButton48.UseVisualStyleBackColor = true;
            this.radioButton48.CheckedChanged += new System.EventHandler(this.radioButton48_CheckedChanged);
            // 
            // radioButton49
            // 
            resources.ApplyResources(this.radioButton49, "radioButton49");
            this.radioButton49.Name = "radioButton49";
            this.radioButton49.TabStop = true;
            this.radioButton49.UseVisualStyleBackColor = true;
            this.radioButton49.CheckedChanged += new System.EventHandler(this.radioButton49_CheckedChanged);
            // 
            // radioButton50
            // 
            resources.ApplyResources(this.radioButton50, "radioButton50");
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.TabStop = true;
            this.radioButton50.UseVisualStyleBackColor = true;
            this.radioButton50.CheckedChanged += new System.EventHandler(this.radioButton50_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox9);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.radioButton41);
            this.groupBox9.Controls.Add(this.radioButton42);
            this.groupBox9.Controls.Add(this.radioButton43);
            this.groupBox9.Controls.Add(this.radioButton44);
            this.groupBox9.Controls.Add(this.radioButton45);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // radioButton41
            // 
            resources.ApplyResources(this.radioButton41, "radioButton41");
            this.radioButton41.Name = "radioButton41";
            this.radioButton41.TabStop = true;
            this.radioButton41.UseVisualStyleBackColor = true;
            this.radioButton41.CheckedChanged += new System.EventHandler(this.radioButton41_CheckedChanged);
            // 
            // radioButton42
            // 
            resources.ApplyResources(this.radioButton42, "radioButton42");
            this.radioButton42.Name = "radioButton42";
            this.radioButton42.TabStop = true;
            this.radioButton42.UseVisualStyleBackColor = true;
            this.radioButton42.CheckedChanged += new System.EventHandler(this.radioButton42_CheckedChanged);
            // 
            // radioButton43
            // 
            resources.ApplyResources(this.radioButton43, "radioButton43");
            this.radioButton43.Name = "radioButton43";
            this.radioButton43.TabStop = true;
            this.radioButton43.UseVisualStyleBackColor = true;
            this.radioButton43.CheckedChanged += new System.EventHandler(this.radioButton43_CheckedChanged);
            // 
            // radioButton44
            // 
            resources.ApplyResources(this.radioButton44, "radioButton44");
            this.radioButton44.Name = "radioButton44";
            this.radioButton44.TabStop = true;
            this.radioButton44.UseVisualStyleBackColor = true;
            this.radioButton44.CheckedChanged += new System.EventHandler(this.radioButton44_CheckedChanged);
            // 
            // radioButton45
            // 
            resources.ApplyResources(this.radioButton45, "radioButton45");
            this.radioButton45.Name = "radioButton45";
            this.radioButton45.TabStop = true;
            this.radioButton45.UseVisualStyleBackColor = true;
            this.radioButton45.CheckedChanged += new System.EventHandler(this.radioButton45_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox8);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.radioButton36);
            this.groupBox8.Controls.Add(this.radioButton37);
            this.groupBox8.Controls.Add(this.radioButton38);
            this.groupBox8.Controls.Add(this.radioButton39);
            this.groupBox8.Controls.Add(this.radioButton40);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // radioButton36
            // 
            resources.ApplyResources(this.radioButton36, "radioButton36");
            this.radioButton36.Name = "radioButton36";
            this.radioButton36.TabStop = true;
            this.radioButton36.UseVisualStyleBackColor = true;
            this.radioButton36.CheckedChanged += new System.EventHandler(this.radioButton36_CheckedChanged);
            // 
            // radioButton37
            // 
            resources.ApplyResources(this.radioButton37, "radioButton37");
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.TabStop = true;
            this.radioButton37.UseVisualStyleBackColor = true;
            this.radioButton37.CheckedChanged += new System.EventHandler(this.radioButton37_CheckedChanged);
            // 
            // radioButton38
            // 
            resources.ApplyResources(this.radioButton38, "radioButton38");
            this.radioButton38.Name = "radioButton38";
            this.radioButton38.TabStop = true;
            this.radioButton38.UseVisualStyleBackColor = true;
            this.radioButton38.CheckedChanged += new System.EventHandler(this.radioButton38_CheckedChanged);
            // 
            // radioButton39
            // 
            resources.ApplyResources(this.radioButton39, "radioButton39");
            this.radioButton39.Name = "radioButton39";
            this.radioButton39.TabStop = true;
            this.radioButton39.UseVisualStyleBackColor = true;
            this.radioButton39.CheckedChanged += new System.EventHandler(this.radioButton39_CheckedChanged);
            // 
            // radioButton40
            // 
            resources.ApplyResources(this.radioButton40, "radioButton40");
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.TabStop = true;
            this.radioButton40.UseVisualStyleBackColor = true;
            this.radioButton40.CheckedChanged += new System.EventHandler(this.radioButton40_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox7);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.radioButton31);
            this.groupBox7.Controls.Add(this.radioButton32);
            this.groupBox7.Controls.Add(this.radioButton33);
            this.groupBox7.Controls.Add(this.radioButton34);
            this.groupBox7.Controls.Add(this.radioButton35);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // radioButton31
            // 
            resources.ApplyResources(this.radioButton31, "radioButton31");
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.TabStop = true;
            this.radioButton31.UseVisualStyleBackColor = true;
            this.radioButton31.CheckedChanged += new System.EventHandler(this.radioButton31_CheckedChanged);
            // 
            // radioButton32
            // 
            resources.ApplyResources(this.radioButton32, "radioButton32");
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.TabStop = true;
            this.radioButton32.UseVisualStyleBackColor = true;
            this.radioButton32.CheckedChanged += new System.EventHandler(this.radioButton32_CheckedChanged);
            // 
            // radioButton33
            // 
            resources.ApplyResources(this.radioButton33, "radioButton33");
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.TabStop = true;
            this.radioButton33.UseVisualStyleBackColor = true;
            this.radioButton33.CheckedChanged += new System.EventHandler(this.radioButton33_CheckedChanged);
            // 
            // radioButton34
            // 
            resources.ApplyResources(this.radioButton34, "radioButton34");
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.TabStop = true;
            this.radioButton34.UseVisualStyleBackColor = true;
            this.radioButton34.CheckedChanged += new System.EventHandler(this.radioButton34_CheckedChanged);
            // 
            // radioButton35
            // 
            resources.ApplyResources(this.radioButton35, "radioButton35");
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.TabStop = true;
            this.radioButton35.UseVisualStyleBackColor = true;
            this.radioButton35.CheckedChanged += new System.EventHandler(this.radioButton35_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.radioButton26);
            this.groupBox6.Controls.Add(this.radioButton27);
            this.groupBox6.Controls.Add(this.radioButton28);
            this.groupBox6.Controls.Add(this.radioButton29);
            this.groupBox6.Controls.Add(this.radioButton30);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // radioButton26
            // 
            resources.ApplyResources(this.radioButton26, "radioButton26");
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.TabStop = true;
            this.radioButton26.UseVisualStyleBackColor = true;
            this.radioButton26.CheckedChanged += new System.EventHandler(this.radioButton26_CheckedChanged);
            // 
            // radioButton27
            // 
            resources.ApplyResources(this.radioButton27, "radioButton27");
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.TabStop = true;
            this.radioButton27.UseVisualStyleBackColor = true;
            this.radioButton27.CheckedChanged += new System.EventHandler(this.radioButton27_CheckedChanged);
            // 
            // radioButton28
            // 
            resources.ApplyResources(this.radioButton28, "radioButton28");
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.TabStop = true;
            this.radioButton28.UseVisualStyleBackColor = true;
            this.radioButton28.CheckedChanged += new System.EventHandler(this.radioButton28_CheckedChanged);
            // 
            // radioButton29
            // 
            resources.ApplyResources(this.radioButton29, "radioButton29");
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.TabStop = true;
            this.radioButton29.UseVisualStyleBackColor = true;
            this.radioButton29.CheckedChanged += new System.EventHandler(this.radioButton29_CheckedChanged);
            // 
            // radioButton30
            // 
            resources.ApplyResources(this.radioButton30, "radioButton30");
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.TabStop = true;
            this.radioButton30.UseVisualStyleBackColor = true;
            this.radioButton30.CheckedChanged += new System.EventHandler(this.radioButton30_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.radioButton21);
            this.groupBox5.Controls.Add(this.radioButton22);
            this.groupBox5.Controls.Add(this.radioButton23);
            this.groupBox5.Controls.Add(this.radioButton24);
            this.groupBox5.Controls.Add(this.radioButton25);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // radioButton21
            // 
            resources.ApplyResources(this.radioButton21, "radioButton21");
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.TabStop = true;
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // radioButton22
            // 
            resources.ApplyResources(this.radioButton22, "radioButton22");
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.TabStop = true;
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.radioButton22_CheckedChanged);
            // 
            // radioButton23
            // 
            resources.ApplyResources(this.radioButton23, "radioButton23");
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.TabStop = true;
            this.radioButton23.UseVisualStyleBackColor = true;
            this.radioButton23.CheckedChanged += new System.EventHandler(this.radioButton23_CheckedChanged);
            // 
            // radioButton24
            // 
            resources.ApplyResources(this.radioButton24, "radioButton24");
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.TabStop = true;
            this.radioButton24.UseVisualStyleBackColor = true;
            this.radioButton24.CheckedChanged += new System.EventHandler(this.radioButton24_CheckedChanged);
            // 
            // radioButton25
            // 
            resources.ApplyResources(this.radioButton25, "radioButton25");
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.TabStop = true;
            this.radioButton25.UseVisualStyleBackColor = true;
            this.radioButton25.CheckedChanged += new System.EventHandler(this.radioButton25_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.radioButton16);
            this.groupBox4.Controls.Add(this.radioButton17);
            this.groupBox4.Controls.Add(this.radioButton18);
            this.groupBox4.Controls.Add(this.radioButton19);
            this.groupBox4.Controls.Add(this.radioButton20);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // radioButton16
            // 
            resources.ApplyResources(this.radioButton16, "radioButton16");
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.TabStop = true;
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton17
            // 
            resources.ApplyResources(this.radioButton17, "radioButton17");
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton18
            // 
            resources.ApplyResources(this.radioButton18, "radioButton18");
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton19
            // 
            resources.ApplyResources(this.radioButton19, "radioButton19");
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.TabStop = true;
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // radioButton20
            // 
            resources.ApplyResources(this.radioButton20, "radioButton20");
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.TabStop = true;
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.radioButton11);
            this.groupBox3.Controls.Add(this.radioButton12);
            this.groupBox3.Controls.Add(this.radioButton13);
            this.groupBox3.Controls.Add(this.radioButton14);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radioButton10
            // 
            resources.ApplyResources(this.radioButton10, "radioButton10");
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            resources.ApplyResources(this.radioButton11, "radioButton11");
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            resources.ApplyResources(this.radioButton12, "radioButton12");
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton13
            // 
            resources.ApplyResources(this.radioButton13, "radioButton13");
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton14
            // 
            resources.ApplyResources(this.radioButton14, "radioButton14");
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.TabStop = true;
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            resources.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            resources.ApplyResources(this.radioButton7, "radioButton7");
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            resources.ApplyResources(this.radioButton8, "radioButton8");
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            resources.ApplyResources(this.radioButton9, "radioButton9");
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton15);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton15
            // 
            resources.ApplyResources(this.radioButton15, "radioButton15");
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Controls.Add(this.tabPage14);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage12);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.groupBox74);
            this.tabPage13.Controls.Add(this.groupBox75);
            this.tabPage13.Controls.Add(this.groupBox76);
            this.tabPage13.Controls.Add(this.groupBox77);
            this.tabPage13.Controls.Add(this.groupBox78);
            resources.ApplyResources(this.tabPage13, "tabPage13");
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // groupBox74
            // 
            this.groupBox74.Controls.Add(this.comboBox25);
            this.groupBox74.Controls.Add(this.comboBox26);
            this.groupBox74.Controls.Add(this.label179);
            this.groupBox74.Controls.Add(this.label180);
            this.groupBox74.Controls.Add(this.label181);
            this.groupBox74.Controls.Add(this.label182);
            resources.ApplyResources(this.groupBox74, "groupBox74");
            this.groupBox74.Name = "groupBox74";
            this.groupBox74.TabStop = false;
            // 
            // comboBox25
            // 
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Items.AddRange(new object[] {
            resources.GetString("comboBox25.Items"),
            resources.GetString("comboBox25.Items1"),
            resources.GetString("comboBox25.Items2"),
            resources.GetString("comboBox25.Items3"),
            resources.GetString("comboBox25.Items4")});
            resources.ApplyResources(this.comboBox25, "comboBox25");
            this.comboBox25.Name = "comboBox25";
            // 
            // comboBox26
            // 
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Items.AddRange(new object[] {
            resources.GetString("comboBox26.Items"),
            resources.GetString("comboBox26.Items1"),
            resources.GetString("comboBox26.Items2"),
            resources.GetString("comboBox26.Items3"),
            resources.GetString("comboBox26.Items4")});
            resources.ApplyResources(this.comboBox26, "comboBox26");
            this.comboBox26.Name = "comboBox26";
            // 
            // label179
            // 
            resources.ApplyResources(this.label179, "label179");
            this.label179.Name = "label179";
            // 
            // label180
            // 
            resources.ApplyResources(this.label180, "label180");
            this.label180.Name = "label180";
            // 
            // label181
            // 
            resources.ApplyResources(this.label181, "label181");
            this.label181.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label181.Name = "label181";
            // 
            // label182
            // 
            this.label182.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label182.AllowDrop = true;
            this.label182.AutoEllipsis = true;
            resources.ApplyResources(this.label182, "label182");
            this.label182.BackColor = System.Drawing.Color.Transparent;
            this.label182.ForeColor = System.Drawing.Color.DarkRed;
            this.label182.Name = "label182";
            this.label182.UseCompatibleTextRendering = true;
            // 
            // groupBox75
            // 
            this.groupBox75.Controls.Add(this.comboBox27);
            this.groupBox75.Controls.Add(this.comboBox28);
            this.groupBox75.Controls.Add(this.label183);
            this.groupBox75.Controls.Add(this.label184);
            this.groupBox75.Controls.Add(this.label185);
            this.groupBox75.Controls.Add(this.label186);
            resources.ApplyResources(this.groupBox75, "groupBox75");
            this.groupBox75.Name = "groupBox75";
            this.groupBox75.TabStop = false;
            // 
            // comboBox27
            // 
            this.comboBox27.FormattingEnabled = true;
            this.comboBox27.Items.AddRange(new object[] {
            resources.GetString("comboBox27.Items"),
            resources.GetString("comboBox27.Items1"),
            resources.GetString("comboBox27.Items2"),
            resources.GetString("comboBox27.Items3"),
            resources.GetString("comboBox27.Items4")});
            resources.ApplyResources(this.comboBox27, "comboBox27");
            this.comboBox27.Name = "comboBox27";
            // 
            // comboBox28
            // 
            this.comboBox28.FormattingEnabled = true;
            this.comboBox28.Items.AddRange(new object[] {
            resources.GetString("comboBox28.Items"),
            resources.GetString("comboBox28.Items1"),
            resources.GetString("comboBox28.Items2"),
            resources.GetString("comboBox28.Items3"),
            resources.GetString("comboBox28.Items4")});
            resources.ApplyResources(this.comboBox28, "comboBox28");
            this.comboBox28.Name = "comboBox28";
            // 
            // label183
            // 
            resources.ApplyResources(this.label183, "label183");
            this.label183.Name = "label183";
            // 
            // label184
            // 
            resources.ApplyResources(this.label184, "label184");
            this.label184.Name = "label184";
            // 
            // label185
            // 
            resources.ApplyResources(this.label185, "label185");
            this.label185.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label185.Name = "label185";
            // 
            // label186
            // 
            this.label186.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label186.AllowDrop = true;
            this.label186.AutoEllipsis = true;
            resources.ApplyResources(this.label186, "label186");
            this.label186.BackColor = System.Drawing.Color.Transparent;
            this.label186.ForeColor = System.Drawing.Color.DarkRed;
            this.label186.Name = "label186";
            this.label186.UseCompatibleTextRendering = true;
            // 
            // groupBox76
            // 
            this.groupBox76.Controls.Add(this.comboBox29);
            this.groupBox76.Controls.Add(this.comboBox30);
            this.groupBox76.Controls.Add(this.label187);
            this.groupBox76.Controls.Add(this.label188);
            this.groupBox76.Controls.Add(this.label189);
            this.groupBox76.Controls.Add(this.label190);
            resources.ApplyResources(this.groupBox76, "groupBox76");
            this.groupBox76.Name = "groupBox76";
            this.groupBox76.TabStop = false;
            // 
            // comboBox29
            // 
            this.comboBox29.FormattingEnabled = true;
            this.comboBox29.Items.AddRange(new object[] {
            resources.GetString("comboBox29.Items"),
            resources.GetString("comboBox29.Items1"),
            resources.GetString("comboBox29.Items2"),
            resources.GetString("comboBox29.Items3"),
            resources.GetString("comboBox29.Items4")});
            resources.ApplyResources(this.comboBox29, "comboBox29");
            this.comboBox29.Name = "comboBox29";
            // 
            // comboBox30
            // 
            this.comboBox30.FormattingEnabled = true;
            this.comboBox30.Items.AddRange(new object[] {
            resources.GetString("comboBox30.Items"),
            resources.GetString("comboBox30.Items1"),
            resources.GetString("comboBox30.Items2"),
            resources.GetString("comboBox30.Items3"),
            resources.GetString("comboBox30.Items4")});
            resources.ApplyResources(this.comboBox30, "comboBox30");
            this.comboBox30.Name = "comboBox30";
            // 
            // label187
            // 
            resources.ApplyResources(this.label187, "label187");
            this.label187.Name = "label187";
            // 
            // label188
            // 
            resources.ApplyResources(this.label188, "label188");
            this.label188.Name = "label188";
            // 
            // label189
            // 
            resources.ApplyResources(this.label189, "label189");
            this.label189.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label189.Name = "label189";
            // 
            // label190
            // 
            this.label190.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label190.AllowDrop = true;
            this.label190.AutoEllipsis = true;
            resources.ApplyResources(this.label190, "label190");
            this.label190.BackColor = System.Drawing.Color.Transparent;
            this.label190.ForeColor = System.Drawing.Color.DarkRed;
            this.label190.Name = "label190";
            this.label190.UseCompatibleTextRendering = true;
            // 
            // groupBox77
            // 
            this.groupBox77.Controls.Add(this.comboBox31);
            this.groupBox77.Controls.Add(this.comboBox32);
            this.groupBox77.Controls.Add(this.label191);
            this.groupBox77.Controls.Add(this.label192);
            this.groupBox77.Controls.Add(this.label193);
            this.groupBox77.Controls.Add(this.label194);
            resources.ApplyResources(this.groupBox77, "groupBox77");
            this.groupBox77.Name = "groupBox77";
            this.groupBox77.TabStop = false;
            // 
            // comboBox31
            // 
            this.comboBox31.FormattingEnabled = true;
            this.comboBox31.Items.AddRange(new object[] {
            resources.GetString("comboBox31.Items"),
            resources.GetString("comboBox31.Items1"),
            resources.GetString("comboBox31.Items2"),
            resources.GetString("comboBox31.Items3"),
            resources.GetString("comboBox31.Items4")});
            resources.ApplyResources(this.comboBox31, "comboBox31");
            this.comboBox31.Name = "comboBox31";
            // 
            // comboBox32
            // 
            this.comboBox32.FormattingEnabled = true;
            this.comboBox32.Items.AddRange(new object[] {
            resources.GetString("comboBox32.Items"),
            resources.GetString("comboBox32.Items1"),
            resources.GetString("comboBox32.Items2"),
            resources.GetString("comboBox32.Items3"),
            resources.GetString("comboBox32.Items4"),
            resources.GetString("comboBox32.Items5")});
            resources.ApplyResources(this.comboBox32, "comboBox32");
            this.comboBox32.Name = "comboBox32";
            // 
            // label191
            // 
            resources.ApplyResources(this.label191, "label191");
            this.label191.Name = "label191";
            // 
            // label192
            // 
            resources.ApplyResources(this.label192, "label192");
            this.label192.Name = "label192";
            // 
            // label193
            // 
            resources.ApplyResources(this.label193, "label193");
            this.label193.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label193.Name = "label193";
            // 
            // label194
            // 
            this.label194.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label194.AllowDrop = true;
            this.label194.AutoEllipsis = true;
            resources.ApplyResources(this.label194, "label194");
            this.label194.BackColor = System.Drawing.Color.Transparent;
            this.label194.ForeColor = System.Drawing.Color.DarkRed;
            this.label194.Name = "label194";
            this.label194.UseCompatibleTextRendering = true;
            // 
            // groupBox78
            // 
            this.groupBox78.Controls.Add(this.comboBox33);
            this.groupBox78.Controls.Add(this.comboBox34);
            this.groupBox78.Controls.Add(this.label195);
            this.groupBox78.Controls.Add(this.label196);
            this.groupBox78.Controls.Add(this.label197);
            this.groupBox78.Controls.Add(this.label198);
            resources.ApplyResources(this.groupBox78, "groupBox78");
            this.groupBox78.Name = "groupBox78";
            this.groupBox78.TabStop = false;
            // 
            // comboBox33
            // 
            this.comboBox33.FormattingEnabled = true;
            this.comboBox33.Items.AddRange(new object[] {
            resources.GetString("comboBox33.Items"),
            resources.GetString("comboBox33.Items1"),
            resources.GetString("comboBox33.Items2"),
            resources.GetString("comboBox33.Items3"),
            resources.GetString("comboBox33.Items4"),
            resources.GetString("comboBox33.Items5")});
            resources.ApplyResources(this.comboBox33, "comboBox33");
            this.comboBox33.Name = "comboBox33";
            // 
            // comboBox34
            // 
            this.comboBox34.FormattingEnabled = true;
            this.comboBox34.Items.AddRange(new object[] {
            resources.GetString("comboBox34.Items"),
            resources.GetString("comboBox34.Items1"),
            resources.GetString("comboBox34.Items2"),
            resources.GetString("comboBox34.Items3"),
            resources.GetString("comboBox34.Items4"),
            resources.GetString("comboBox34.Items5")});
            resources.ApplyResources(this.comboBox34, "comboBox34");
            this.comboBox34.Name = "comboBox34";
            // 
            // label195
            // 
            resources.ApplyResources(this.label195, "label195");
            this.label195.Name = "label195";
            // 
            // label196
            // 
            resources.ApplyResources(this.label196, "label196");
            this.label196.Name = "label196";
            // 
            // label197
            // 
            resources.ApplyResources(this.label197, "label197");
            this.label197.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label197.Name = "label197";
            // 
            // label198
            // 
            this.label198.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label198.AllowDrop = true;
            this.label198.AutoEllipsis = true;
            resources.ApplyResources(this.label198, "label198");
            this.label198.BackColor = System.Drawing.Color.Transparent;
            this.label198.ForeColor = System.Drawing.Color.DarkRed;
            this.label198.Name = "label198";
            this.label198.UseCompatibleTextRendering = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.groupBox83);
            this.tabPage14.Controls.Add(this.groupBox84);
            this.tabPage14.Controls.Add(this.groupBox85);
            this.tabPage14.Controls.Add(this.groupBox86);
            this.tabPage14.Controls.Add(this.groupBox87);
            resources.ApplyResources(this.tabPage14, "tabPage14");
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // groupBox83
            // 
            this.groupBox83.Controls.Add(this.comboBox41);
            this.groupBox83.Controls.Add(this.comboBox42);
            this.groupBox83.Controls.Add(this.label216);
            this.groupBox83.Controls.Add(this.label217);
            this.groupBox83.Controls.Add(this.label218);
            this.groupBox83.Controls.Add(this.label219);
            resources.ApplyResources(this.groupBox83, "groupBox83");
            this.groupBox83.Name = "groupBox83";
            this.groupBox83.TabStop = false;
            // 
            // comboBox41
            // 
            this.comboBox41.FormattingEnabled = true;
            this.comboBox41.Items.AddRange(new object[] {
            resources.GetString("comboBox41.Items"),
            resources.GetString("comboBox41.Items1"),
            resources.GetString("comboBox41.Items2"),
            resources.GetString("comboBox41.Items3"),
            resources.GetString("comboBox41.Items4")});
            resources.ApplyResources(this.comboBox41, "comboBox41");
            this.comboBox41.Name = "comboBox41";
            // 
            // comboBox42
            // 
            this.comboBox42.FormattingEnabled = true;
            this.comboBox42.Items.AddRange(new object[] {
            resources.GetString("comboBox42.Items"),
            resources.GetString("comboBox42.Items1"),
            resources.GetString("comboBox42.Items2"),
            resources.GetString("comboBox42.Items3"),
            resources.GetString("comboBox42.Items4")});
            resources.ApplyResources(this.comboBox42, "comboBox42");
            this.comboBox42.Name = "comboBox42";
            // 
            // label216
            // 
            resources.ApplyResources(this.label216, "label216");
            this.label216.Name = "label216";
            // 
            // label217
            // 
            resources.ApplyResources(this.label217, "label217");
            this.label217.Name = "label217";
            // 
            // label218
            // 
            resources.ApplyResources(this.label218, "label218");
            this.label218.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label218.Name = "label218";
            // 
            // label219
            // 
            this.label219.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label219.AllowDrop = true;
            this.label219.AutoEllipsis = true;
            resources.ApplyResources(this.label219, "label219");
            this.label219.BackColor = System.Drawing.Color.Transparent;
            this.label219.ForeColor = System.Drawing.Color.DarkRed;
            this.label219.Name = "label219";
            this.label219.UseCompatibleTextRendering = true;
            // 
            // groupBox84
            // 
            this.groupBox84.Controls.Add(this.comboBox43);
            this.groupBox84.Controls.Add(this.comboBox44);
            this.groupBox84.Controls.Add(this.label220);
            this.groupBox84.Controls.Add(this.label221);
            this.groupBox84.Controls.Add(this.label222);
            this.groupBox84.Controls.Add(this.label223);
            resources.ApplyResources(this.groupBox84, "groupBox84");
            this.groupBox84.Name = "groupBox84";
            this.groupBox84.TabStop = false;
            // 
            // comboBox43
            // 
            this.comboBox43.FormattingEnabled = true;
            this.comboBox43.Items.AddRange(new object[] {
            resources.GetString("comboBox43.Items"),
            resources.GetString("comboBox43.Items1"),
            resources.GetString("comboBox43.Items2"),
            resources.GetString("comboBox43.Items3"),
            resources.GetString("comboBox43.Items4")});
            resources.ApplyResources(this.comboBox43, "comboBox43");
            this.comboBox43.Name = "comboBox43";
            // 
            // comboBox44
            // 
            this.comboBox44.FormattingEnabled = true;
            this.comboBox44.Items.AddRange(new object[] {
            resources.GetString("comboBox44.Items"),
            resources.GetString("comboBox44.Items1"),
            resources.GetString("comboBox44.Items2"),
            resources.GetString("comboBox44.Items3"),
            resources.GetString("comboBox44.Items4")});
            resources.ApplyResources(this.comboBox44, "comboBox44");
            this.comboBox44.Name = "comboBox44";
            // 
            // label220
            // 
            resources.ApplyResources(this.label220, "label220");
            this.label220.Name = "label220";
            // 
            // label221
            // 
            resources.ApplyResources(this.label221, "label221");
            this.label221.Name = "label221";
            // 
            // label222
            // 
            resources.ApplyResources(this.label222, "label222");
            this.label222.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label222.Name = "label222";
            // 
            // label223
            // 
            this.label223.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label223.AllowDrop = true;
            this.label223.AutoEllipsis = true;
            resources.ApplyResources(this.label223, "label223");
            this.label223.BackColor = System.Drawing.Color.Transparent;
            this.label223.ForeColor = System.Drawing.Color.DarkRed;
            this.label223.Name = "label223";
            this.label223.UseCompatibleTextRendering = true;
            // 
            // groupBox85
            // 
            this.groupBox85.Controls.Add(this.comboBox45);
            this.groupBox85.Controls.Add(this.comboBox46);
            this.groupBox85.Controls.Add(this.label224);
            this.groupBox85.Controls.Add(this.label225);
            this.groupBox85.Controls.Add(this.label226);
            this.groupBox85.Controls.Add(this.label227);
            resources.ApplyResources(this.groupBox85, "groupBox85");
            this.groupBox85.Name = "groupBox85";
            this.groupBox85.TabStop = false;
            // 
            // comboBox45
            // 
            this.comboBox45.FormattingEnabled = true;
            this.comboBox45.Items.AddRange(new object[] {
            resources.GetString("comboBox45.Items"),
            resources.GetString("comboBox45.Items1"),
            resources.GetString("comboBox45.Items2"),
            resources.GetString("comboBox45.Items3"),
            resources.GetString("comboBox45.Items4")});
            resources.ApplyResources(this.comboBox45, "comboBox45");
            this.comboBox45.Name = "comboBox45";
            // 
            // comboBox46
            // 
            this.comboBox46.FormattingEnabled = true;
            this.comboBox46.Items.AddRange(new object[] {
            resources.GetString("comboBox46.Items"),
            resources.GetString("comboBox46.Items1"),
            resources.GetString("comboBox46.Items2"),
            resources.GetString("comboBox46.Items3"),
            resources.GetString("comboBox46.Items4")});
            resources.ApplyResources(this.comboBox46, "comboBox46");
            this.comboBox46.Name = "comboBox46";
            // 
            // label224
            // 
            resources.ApplyResources(this.label224, "label224");
            this.label224.Name = "label224";
            // 
            // label225
            // 
            resources.ApplyResources(this.label225, "label225");
            this.label225.Name = "label225";
            // 
            // label226
            // 
            resources.ApplyResources(this.label226, "label226");
            this.label226.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label226.Name = "label226";
            // 
            // label227
            // 
            this.label227.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label227.AllowDrop = true;
            this.label227.AutoEllipsis = true;
            resources.ApplyResources(this.label227, "label227");
            this.label227.BackColor = System.Drawing.Color.Transparent;
            this.label227.ForeColor = System.Drawing.Color.DarkRed;
            this.label227.Name = "label227";
            this.label227.UseCompatibleTextRendering = true;
            // 
            // groupBox86
            // 
            this.groupBox86.Controls.Add(this.comboBox47);
            this.groupBox86.Controls.Add(this.comboBox48);
            this.groupBox86.Controls.Add(this.label228);
            this.groupBox86.Controls.Add(this.label229);
            this.groupBox86.Controls.Add(this.label230);
            this.groupBox86.Controls.Add(this.label231);
            resources.ApplyResources(this.groupBox86, "groupBox86");
            this.groupBox86.Name = "groupBox86";
            this.groupBox86.TabStop = false;
            // 
            // comboBox47
            // 
            this.comboBox47.FormattingEnabled = true;
            this.comboBox47.Items.AddRange(new object[] {
            resources.GetString("comboBox47.Items"),
            resources.GetString("comboBox47.Items1"),
            resources.GetString("comboBox47.Items2"),
            resources.GetString("comboBox47.Items3"),
            resources.GetString("comboBox47.Items4")});
            resources.ApplyResources(this.comboBox47, "comboBox47");
            this.comboBox47.Name = "comboBox47";
            // 
            // comboBox48
            // 
            this.comboBox48.FormattingEnabled = true;
            this.comboBox48.Items.AddRange(new object[] {
            resources.GetString("comboBox48.Items"),
            resources.GetString("comboBox48.Items1"),
            resources.GetString("comboBox48.Items2"),
            resources.GetString("comboBox48.Items3"),
            resources.GetString("comboBox48.Items4"),
            resources.GetString("comboBox48.Items5")});
            resources.ApplyResources(this.comboBox48, "comboBox48");
            this.comboBox48.Name = "comboBox48";
            // 
            // label228
            // 
            resources.ApplyResources(this.label228, "label228");
            this.label228.Name = "label228";
            // 
            // label229
            // 
            resources.ApplyResources(this.label229, "label229");
            this.label229.Name = "label229";
            // 
            // label230
            // 
            resources.ApplyResources(this.label230, "label230");
            this.label230.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label230.Name = "label230";
            // 
            // label231
            // 
            this.label231.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label231.AllowDrop = true;
            this.label231.AutoEllipsis = true;
            resources.ApplyResources(this.label231, "label231");
            this.label231.BackColor = System.Drawing.Color.Transparent;
            this.label231.ForeColor = System.Drawing.Color.DarkRed;
            this.label231.Name = "label231";
            this.label231.UseCompatibleTextRendering = true;
            // 
            // groupBox87
            // 
            this.groupBox87.Controls.Add(this.comboBox49);
            this.groupBox87.Controls.Add(this.comboBox50);
            this.groupBox87.Controls.Add(this.label232);
            this.groupBox87.Controls.Add(this.label233);
            this.groupBox87.Controls.Add(this.label234);
            this.groupBox87.Controls.Add(this.label235);
            resources.ApplyResources(this.groupBox87, "groupBox87");
            this.groupBox87.Name = "groupBox87";
            this.groupBox87.TabStop = false;
            // 
            // comboBox49
            // 
            this.comboBox49.FormattingEnabled = true;
            this.comboBox49.Items.AddRange(new object[] {
            resources.GetString("comboBox49.Items"),
            resources.GetString("comboBox49.Items1"),
            resources.GetString("comboBox49.Items2"),
            resources.GetString("comboBox49.Items3"),
            resources.GetString("comboBox49.Items4"),
            resources.GetString("comboBox49.Items5")});
            resources.ApplyResources(this.comboBox49, "comboBox49");
            this.comboBox49.Name = "comboBox49";
            // 
            // comboBox50
            // 
            this.comboBox50.FormattingEnabled = true;
            this.comboBox50.Items.AddRange(new object[] {
            resources.GetString("comboBox50.Items"),
            resources.GetString("comboBox50.Items1"),
            resources.GetString("comboBox50.Items2"),
            resources.GetString("comboBox50.Items3"),
            resources.GetString("comboBox50.Items4"),
            resources.GetString("comboBox50.Items5")});
            resources.ApplyResources(this.comboBox50, "comboBox50");
            this.comboBox50.Name = "comboBox50";
            // 
            // label232
            // 
            resources.ApplyResources(this.label232, "label232");
            this.label232.Name = "label232";
            // 
            // label233
            // 
            resources.ApplyResources(this.label233, "label233");
            this.label233.Name = "label233";
            // 
            // label234
            // 
            resources.ApplyResources(this.label234, "label234");
            this.label234.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label234.Name = "label234";
            // 
            // label235
            // 
            this.label235.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label235.AllowDrop = true;
            this.label235.AutoEllipsis = true;
            resources.ApplyResources(this.label235, "label235");
            this.label235.BackColor = System.Drawing.Color.Transparent;
            this.label235.ForeColor = System.Drawing.Color.DarkRed;
            this.label235.Name = "label235";
            this.label235.UseCompatibleTextRendering = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.btnUpdate);
            this.tabPage11.Controls.Add(this.textBox63);
            this.tabPage11.Controls.Add(this.groupBox82);
            resources.ApplyResources(this.tabPage11, "tabPage11");
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox63
            // 
            resources.ApplyResources(this.textBox63, "textBox63");
            this.textBox63.Name = "textBox63";
            // 
            // groupBox82
            // 
            this.groupBox82.Controls.Add(this.radioButton302);
            this.groupBox82.Controls.Add(this.radioButton301);
            resources.ApplyResources(this.groupBox82, "groupBox82");
            this.groupBox82.Name = "groupBox82";
            this.groupBox82.TabStop = false;
            // 
            // radioButton302
            // 
            resources.ApplyResources(this.radioButton302, "radioButton302");
            this.radioButton302.Name = "radioButton302";
            this.radioButton302.TabStop = true;
            this.radioButton302.UseVisualStyleBackColor = true;
            this.radioButton302.CheckedChanged += new System.EventHandler(this.radioButton302_CheckedChanged);
            // 
            // radioButton301
            // 
            resources.ApplyResources(this.radioButton301, "radioButton301");
            this.radioButton301.Name = "radioButton301";
            this.radioButton301.TabStop = true;
            this.radioButton301.UseVisualStyleBackColor = true;
            this.radioButton301.CheckedChanged += new System.EventHandler(this.radioButton301_CheckedChanged);
            // 
            // tabPage10
            // 
            resources.ApplyResources(this.tabPage10, "tabPage10");
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            resources.ApplyResources(this.tabPage12, "tabPage12");
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tB_NeoTableAdapter
            // 
            this.tB_NeoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox64
            // 
            resources.ApplyResources(this.textBox64, "textBox64");
            this.textBox64.Name = "textBox64";
            // 
            // textBox67
            // 
            resources.ApplyResources(this.textBox67, "textBox67");
            this.textBox67.Name = "textBox67";
            this.textBox67.TextChanged += new System.EventHandler(this.textBox67_TextChanged);
            // 
            // textBox68
            // 
            resources.ApplyResources(this.textBox68, "textBox68");
            this.textBox68.Name = "textBox68";
            this.textBox68.TextChanged += new System.EventHandler(this.textBox68_TextChanged);
            // 
            // textBox69
            // 
            resources.ApplyResources(this.textBox69, "textBox69");
            this.textBox69.Name = "textBox69";
            this.textBox69.TextChanged += new System.EventHandler(this.textBox69_TextChanged);
            // 
            // textBox71
            // 
            resources.ApplyResources(this.textBox71, "textBox71");
            this.textBox71.Name = "textBox71";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox71);
            this.Controls.Add(this.textBox69);
            this.Controls.Add(this.textBox68);
            this.Controls.Add(this.textBox67);
            this.Controls.Add(this.textBox64);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartNeo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox61);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBNeoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNeoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_NeoBindingSource)).EndInit();
            this.groupBox61.ResumeLayout(false);
            this.groupBox61.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.groupBox62.ResumeLayout(false);
            this.groupBox62.PerformLayout();
            this.groupBox63.ResumeLayout(false);
            this.groupBox63.PerformLayout();
            this.groupBox64.ResumeLayout(false);
            this.groupBox64.PerformLayout();
            this.groupBox65.ResumeLayout(false);
            this.groupBox65.PerformLayout();
            this.groupBox66.ResumeLayout(false);
            this.groupBox66.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox73.ResumeLayout(false);
            this.groupBox73.PerformLayout();
            this.groupBox72.ResumeLayout(false);
            this.groupBox72.PerformLayout();
            this.groupBox79.ResumeLayout(false);
            this.groupBox79.PerformLayout();
            this.groupBox80.ResumeLayout(false);
            this.groupBox80.PerformLayout();
            this.groupBox81.ResumeLayout(false);
            this.groupBox81.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGNEO)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox51.ResumeLayout(false);
            this.groupBox51.PerformLayout();
            this.groupBox52.ResumeLayout(false);
            this.groupBox52.PerformLayout();
            this.groupBox53.ResumeLayout(false);
            this.groupBox53.PerformLayout();
            this.groupBox54.ResumeLayout(false);
            this.groupBox54.PerformLayout();
            this.groupBox55.ResumeLayout(false);
            this.groupBox55.PerformLayout();
            this.groupBox56.ResumeLayout(false);
            this.groupBox56.PerformLayout();
            this.groupBox57.ResumeLayout(false);
            this.groupBox57.PerformLayout();
            this.groupBox58.ResumeLayout(false);
            this.groupBox58.PerformLayout();
            this.groupBox59.ResumeLayout(false);
            this.groupBox59.PerformLayout();
            this.groupBox60.ResumeLayout(false);
            this.groupBox60.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            this.groupBox42.ResumeLayout(false);
            this.groupBox42.PerformLayout();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox45.ResumeLayout(false);
            this.groupBox45.PerformLayout();
            this.groupBox46.ResumeLayout(false);
            this.groupBox46.PerformLayout();
            this.groupBox47.ResumeLayout(false);
            this.groupBox47.PerformLayout();
            this.groupBox48.ResumeLayout(false);
            this.groupBox48.PerformLayout();
            this.groupBox49.ResumeLayout(false);
            this.groupBox49.PerformLayout();
            this.groupBox50.ResumeLayout(false);
            this.groupBox50.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.groupBox74.ResumeLayout(false);
            this.groupBox74.PerformLayout();
            this.groupBox75.ResumeLayout(false);
            this.groupBox75.PerformLayout();
            this.groupBox76.ResumeLayout(false);
            this.groupBox76.PerformLayout();
            this.groupBox77.ResumeLayout(false);
            this.groupBox77.PerformLayout();
            this.groupBox78.ResumeLayout(false);
            this.groupBox78.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.groupBox83.ResumeLayout(false);
            this.groupBox83.PerformLayout();
            this.groupBox84.ResumeLayout(false);
            this.groupBox84.PerformLayout();
            this.groupBox85.ResumeLayout(false);
            this.groupBox85.PerformLayout();
            this.groupBox86.ResumeLayout(false);
            this.groupBox86.PerformLayout();
            this.groupBox87.ResumeLayout(false);
            this.groupBox87.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox82.ResumeLayout(false);
            this.groupBox82.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox4.Text);
            int bbb = int.Parse(comboBox3.Text);
            if (aaa + bbb != 5)
            {
                comboBox4.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox38.Text);
            int b = int.Parse(comboBox30.Text);
            int c = int.Parse(comboBox26.Text);
            int d = int.Parse(comboBox24.Text);
            int ee = int.Parse(comboBox1.Text);
            int f = int.Parse(comboBox8.Text);
            int g = int.Parse(comboBox18.Text);
            int h = int.Parse(comboBox16.Text);

            int A = aa + b + c + d + ee + f + g + h;
            txtPA.Text = A.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox1.Text);
            int bbb = int.Parse(comboBox2.Text);
            if (aaa + bbb != 5)
            {
                comboBox1.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");
                
            }
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox30.Text);
            int bbb = int.Parse(comboBox29.Text);
            if (aaa + bbb != 5)
            {
                comboBox30.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox26.Text);
            int bbb = int.Parse(comboBox25.Text);
            if (aaa + bbb != 5)
            {
                comboBox26.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox34.Text);
            int b = int.Parse(comboBox29.Text);
            int c = int.Parse(comboBox25.Text);
            int d = int.Parse(comboBox22.Text);
            int ee = int.Parse(comboBox6.Text);
            int f = int.Parse(comboBox10.Text);
            int g = int.Parse(comboBox20.Text);
            int h = int.Parse(comboBox14.Text);

            int B = aa + b + c + d + ee + f + g + h;
            txtPB.Text = B.ToString();
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox12.Text);
            int bbb = int.Parse(comboBox11.Text);
            if (aaa + bbb != 5)
            {
                comboBox12.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox10.Text);
            int bbb = int.Parse(comboBox9.Text);
            if (aaa + bbb != 5)
            {
                comboBox10.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox8.Text);
            int bbb = int.Parse(comboBox7.Text);
            if (aaa + bbb != 5)
            {
                comboBox8.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox14.Text);
            int bbb = int.Parse(comboBox13.Text);
            if (aaa + bbb != 5)
            {
                comboBox14.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox39.Text);
            int b = int.Parse(comboBox36.Text);
            int c = int.Parse(comboBox2.Text);
            int d = int.Parse(comboBox4.Text);
            int ee = int.Parse(comboBox11.Text);
            int f = int.Parse(comboBox9.Text);
            int g = int.Parse(comboBox7.Text);
            int h = int.Parse(comboBox13.Text);

            int D = aa + b + c + d + ee + f + g + h;
            txtPD.Text = D.ToString();
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox38.Text);
            int bbb = int.Parse(comboBox37.Text);
            if (aaa + bbb != 5)
            {
                comboBox38.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox36.Text);
            int bbb = int.Parse(comboBox35.Text);
            if (aaa + bbb != 5)
            {
                comboBox36.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox6.Text);
            int bbb = int.Parse(comboBox5.Text);
            if (aaa + bbb != 5)
            {
                comboBox6.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void groupBox80_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox32.Text);
            int bbb = int.Parse(comboBox31.Text);
            if (aaa + bbb != 5)
            {
                comboBox32.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox28.Text);
            int bbb = int.Parse(comboBox27.Text);
            if (aaa + bbb != 5)
            {
                comboBox28.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox24.Text);
            int bbb = int.Parse(comboBox23.Text);
            if (aaa + bbb != 5)
            {
                comboBox24.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox22.Text);
            int bbb = int.Parse(comboBox21.Text);
            if (aaa + bbb != 5)
            {
                comboBox22.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox3.Text);
            int b = int.Parse(comboBox5.Text);
            int c = int.Parse(comboBox37.Text);
            int d = int.Parse(comboBox35.Text);
            int ee = int.Parse(comboBox31.Text);
            int f = int.Parse(comboBox27.Text);
            int g = int.Parse(comboBox23.Text);
            int h = int.Parse(comboBox21.Text);

            int H = aa + b + c + d + ee + f + g + h;
            txtPH.Text = H.ToString();
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox34.Text);
            int bbb = int.Parse(comboBox33.Text);
            if (aaa + bbb != 5)
            {
                comboBox34.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox20.Text);
            int bbb = int.Parse(comboBox19.Text);
            if (aaa + bbb != 5)
            {
                comboBox20.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox18.Text);
            int bbb = int.Parse(comboBox17.Text);
            if (aaa + bbb != 5)
            {
                comboBox18.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aaa = int.Parse(comboBox16.Text);
            int bbb = int.Parse(comboBox15.Text);
            if (aaa + bbb != 5)
            {
                comboBox16.Focus();
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");

            }
            int aa = int.Parse(comboBox12.Text);
            int b = int.Parse(comboBox19.Text);
            int c = int.Parse(comboBox17.Text);
            int d = int.Parse(comboBox15.Text);
            int ee = int.Parse(comboBox40.Text);
            int f = int.Parse(comboBox33.Text);
            int g = int.Parse(comboBox32.Text);
            int h = int.Parse(comboBox28.Text);

            int J = aa + b + c + d + ee + f + g + h;
            txtPJ.Text = J.ToString();
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(comboBox1.Text);
            int b = int.Parse(comboBox2.Text);
            if (a+b != 5 ) {
                MessageBox.Show("جمع دو گزینه باید ۵ باشد.مثل ۱و۴ یا ۳و۲");
                comboBox1.Focus();
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void comboBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage9");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage8");
        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();
            //if (txtOrginal.Text == "" && txtTranse.Text == "")
            //{
            //    MessageBox.Show("No Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            db.InsertNeorecord(Convert.ToByte(textBox1.Text), Convert.ToByte(textBox2.Text),
                Convert.ToByte(textBox3.Text), Convert.ToByte(textBox4.Text),
                Convert.ToByte(textBox5.Text), Convert.ToByte(textBox6.Text),
                Convert.ToByte(textBox7.Text), Convert.ToByte(textBox8.Text),
                Convert.ToByte(textBox9.Text), Convert.ToByte(textBox10.Text),
                Convert.ToByte(textBox11.Text), Convert.ToByte(textBox12.Text),
                Convert.ToByte(textBox13.Text), Convert.ToByte(textBox14.Text),
                Convert.ToByte(textBox15.Text), Convert.ToByte(textBox16.Text),
                Convert.ToByte(textBox17.Text), Convert.ToByte(textBox18.Text),
                Convert.ToByte(textBox19.Text), Convert.ToByte(textBox20.Text),
                Convert.ToByte(textBox21.Text), Convert.ToByte(textBox22.Text),
                Convert.ToByte(textBox23.Text), Convert.ToByte(textBox24.Text),
                Convert.ToByte(textBox25.Text), Convert.ToByte(textBox26.Text),
                Convert.ToByte(textBox27.Text), Convert.ToByte(textBox28.Text),
                Convert.ToByte(textBox29.Text), Convert.ToByte(textBox30.Text),
                Convert.ToByte(textBox31.Text), Convert.ToByte(textBox32.Text),
                Convert.ToByte(textBox33.Text), Convert.ToByte(textBox34.Text),
                Convert.ToByte(textBox35.Text), Convert.ToByte(textBox36.Text),
                Convert.ToByte(textBox37.Text), Convert.ToByte(textBox38.Text),
                Convert.ToByte(textBox39.Text), Convert.ToByte(textBox40.Text),
                Convert.ToByte(textBox41.Text), Convert.ToByte(textBox42.Text),
                Convert.ToByte(textBox43.Text), Convert.ToByte(textBox44.Text),
                Convert.ToByte(textBox45.Text), Convert.ToByte(textBox46.Text),
                Convert.ToByte(textBox47.Text), Convert.ToByte(textBox48.Text),
                Convert.ToByte(textBox49.Text), Convert.ToByte(textBox50.Text),
                Convert.ToByte(textBox51.Text), Convert.ToByte(textBox52.Text),
                Convert.ToByte(textBox53.Text), Convert.ToByte(textBox54.Text),
                Convert.ToByte(textBox55.Text), Convert.ToByte(textBox56.Text),
                Convert.ToByte(textBox57.Text), Convert.ToByte(textBox58.Text),
                Convert.ToByte(textBox59.Text), Convert.ToByte(textBox60.Text),
               txtName.Text,txtNameF.Text, txtDate.Text, txtMeli.Text, txtAdressM.Text, txtPhoneH.Text, txtPhoneM.Text, txtNumberSh.Text, txtAdressMK.Text, Convert.ToInt32(txtN.Text), Convert.ToInt32(txtE.Text), Convert.ToInt32(txtO.Text), Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text),
               Convert.ToByte(comboBox1.Text), Convert.ToByte(comboBox2.Text), Convert.ToByte(comboBox4.Text), Convert.ToByte(comboBox3.Text), Convert.ToByte(comboBox6.Text), Convert.ToByte(comboBox5.Text), Convert.ToByte(comboBox12.Text), Convert.ToByte(comboBox11.Text),
               Convert.ToByte(comboBox10.Text), Convert.ToByte(comboBox9.Text), Convert.ToByte(comboBox8.Text),
               Convert.ToByte(comboBox7.Text), Convert.ToByte(comboBox20.Text),
               Convert.ToByte(comboBox19.Text), Convert.ToByte(comboBox18.Text),
               Convert.ToByte(comboBox17.Text), Convert.ToByte(comboBox16.Text),
               Convert.ToByte(comboBox15.Text), Convert.ToByte(comboBox14.Text),
               Convert.ToByte(comboBox13.Text), Convert.ToByte(comboBox40.Text),
               Convert.ToByte(comboBox39.Text), Convert.ToByte(comboBox38.Text),
               Convert.ToByte(comboBox37.Text), Convert.ToByte(comboBox36.Text),
               Convert.ToByte(comboBox35.Text), Convert.ToByte(comboBox34.Text),
               Convert.ToByte(comboBox33.Text), Convert.ToByte(comboBox32.Text),
               Convert.ToByte(comboBox31.Text), Convert.ToByte(comboBox30.Text),
               Convert.ToByte(comboBox29.Text), Convert.ToByte(comboBox28.Text),
               Convert.ToByte(comboBox27.Text), Convert.ToByte(comboBox26.Text),
               Convert.ToByte(comboBox25.Text), Convert.ToByte(comboBox24.Text),
               Convert.ToByte(comboBox23.Text), Convert.ToByte(comboBox22.Text),
               Convert.ToByte(comboBox21.Text), Convert.ToInt32(txtPA.Text),
               Convert.ToInt32(txtPB.Text), Convert.ToInt32(txtPJ.Text), Convert.ToInt32(txtPD.Text),
               Convert.ToInt32(txtPH.Text), Convert.ToInt32(textBox61.Text),textBox62.Text,textBox63.Text,textBox65.Text,textBox66.Text,Convert.ToInt32(textBox71.Text));
            DGNEO.DataSource = db.TB_Neos;
            txtName.Text="";
                txtNameF.Text="";
                    txtDate.Text="";
                        txtMeli.Text="";
                            txtAdressM.Text=""; 
                                txtPhoneH.Text="";
            txtPhoneM.Text="";
                                    txtNumberSh.Text="";
                                    txtAdressMK.Text = "";
            MessageBox.Show(".اطلاعات ذخیره شد");
            //txtOrginal.Text = "";
            // txtTranse.Text = "";
            //}
            //var b = (from x in db.tbl_Dics
            //         // where ((x.id_dic == x.id_dic))
            //         orderby (x.id_dic)
            //         select x).Count();
            //label5.Text = b.ToString();
        }

        private void radioButton301_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton301.Checked == true)
            {
                textBox63.Text = "با توجه به ارزیابی انجام شده که مشاهده می کنید و مصاحبه با فرد مورد نظر، تلفیقی از مولفه های تست NEO ،پرسشنامه محتوای انگیزش و مصاحبه مورد تحلیل قرارگرفت و تشخیص نهایی بر این شد که ایشان مناسب شغل خدمات می باشند. ";
               
            }
        }

        private void radioButton302_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton302.Checked == true)
            {
                textBox63.Text = "با توجه به ارزیابی انجام شده که مشاهده می کنید و مصاحبه با فرد مورد نظر، تلفیقی از مولفه های تست NEO ،پرسشنامه محتوای انگیزش و مصاحبه مورد تحلیل قرارگرفت و تشخیص نهایی بر این شد که همکاری با ایشان درشغل مورد نظر جای تردید دارد.";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
              var db = new DCNeoDataContext();
            //if (txtOrginal.Text == "" && txtTranse.Text == "")
            //{
            //    MessageBox.Show("No Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
              db.sp_update_tbl_Neo(Convert.ToInt32(textBox64.Text), Convert.ToInt32(textBox61.Text),textBox62.Text, textBox63.Text,textBox66.Text);
              DGNEO.DataSource = db.TB_Neos;
              MessageBox.Show(".اصلاح انجام شد");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();
            if (DGNEO.RowCount > 0)
            {
               // var f = new frmUpdateDic();

                textBox64.Text = DGNEO.CurrentRow.Cells[0].Value.ToString();
                textBox61.Text = DGNEO.CurrentRow.Cells[1].Value.ToString();
 textBox62.Text = DGNEO.CurrentRow.Cells[2].Value.ToString();
                textBox63.Text = DGNEO.CurrentRow.Cells[3].Value.ToString();
textBox66.Text = DGNEO.CurrentRow.Cells[6].Value.ToString();
              //  f.ShowDialog();

                DGNEO.DataSource = db.TB_Neos;
            }
        }

        private void txtNumberSh_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();
            if (DGNEO.RowCount == 0) return;
            if (MessageBox.Show("Do you want to delete?", "Dlete", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {

                db.sp_delete_tbl_Neo(Convert.ToInt32(DGNEO.CurrentRow.Cells[0].Value));
                DGNEO.DataSource = db.TB_Neos;
            }
            var b = (from x in db.TB_Neos
                     // where ((x.id_dic == x.id_dic))
                     orderby (x.Id)
                     select x).Count();
            textBox64.Text = b.ToString();
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();
           
            var q = from a in db.TB_Neos.Where(c => c.Name.Contains(
                    textBox67.Text)).Select(c => c)

                    select a;
           
             
            DGNEO.DataSource = q;
            this.chartNeo.DataSource = q;
            this.chart1.DataSource = q;
          
            this.chartNeo.DataBind();
            this.chart1.DataBind();
           
            this.tBNeoBindingSource.DataSource = q;
         
            this.reportViewer1.RefreshReport();
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();

            var q = from a in db.TB_Neos.Where(c => c.Meli.Contains(
                    textBox68.Text)).Select(c => c)

                    select a;


            DGNEO.DataSource = q;
            this.chartNeo.DataSource = q;
            this.chart1.DataSource = q;

            this.chartNeo.DataBind();
            this.chart1.DataBind();

            this.tBNeoBindingSource.DataSource = q;

            this.reportViewer1.RefreshReport();
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();

            var q = from a in db.TB_Neos.Where(c => c.NameF.Contains(
                    textBox69.Text)).Select(c => c)

                    select a;


            DGNEO.DataSource = q;
            this.chartNeo.DataSource = q;
            this.chart1.DataSource = q;

            this.chartNeo.DataBind();
            this.chart1.DataBind();

            this.tBNeoBindingSource.DataSource = q;

            this.reportViewer1.RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var db = new DCNeoDataContext();
 
            DGNEO.DataSource = db.TB_Neos;
           
        } 
    }
}
