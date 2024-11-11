using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenTienTrung_21103100534
{
    public partial class Form1 : Form
    {
        List<SkillDB_0534> SkillDB = new List<SkillDB_0534>();
        List<PlayerSkills_0534> PlayerSkills = new List<PlayerSkills_0534>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btndocfile_0534_Click(object sender, EventArgs e)
        {
            try
            {
                string duongdan = AppDomain.CurrentDomain.BaseDirectory;

                string ddkn = Path.Combine(duongdan, "SkillDB.txt");
                string[] mangddkn = File.ReadAllLines(ddkn);

                for (int i = 1; i < mangddkn.Length; i++)
                {
                    string[] p = mangddkn[i].Split('\t');
                    if (p.Length != 4)
                    {
                        throw new Exception("Lỗi cấu trúc file SkillDB.txt");
                    }

                    SkillDB_0534 s = new SkillDB_0534
                    {
                        SkillId = int.Parse(p[0]),
                        SkillName = p[1],
                        Effectiveness = int.Parse(p[2]),
                        Rank = p[3]
                    };
                    SkillDB.Add(s);
                }

                string ddknnc = Path.Combine(duongdan, "PlayerSkills.txt");
                string[] mangddknnc = File.ReadAllLines(ddknnc);

                for (int i = 1; i < mangddknnc.Length; i++)
                {
                    string[] p = mangddknnc[i].Split('\t');
                    if (p.Length != 4)
                    {
                        throw new Exception("Lỗi cấu trúc file PlayerSkills.txt");
                    }

                    PlayerSkills_0534 ps = new PlayerSkills_0534
                    {
                        PlayerId = int.Parse(p[0]),
                        PlayerName = p[1],
                        SkillId = int.Parse(p[2]),
                        Mastery = int.Parse(p[3])
                    };
                    PlayerSkills.Add(ps);
                }

                MessageBox.Show("Đọc file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cấu trúc file: " + ex.Message);
            }
        }

        private void btnsua_0534_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerSkills_0534 p_ = null;
                foreach (var p in PlayerSkills)
                {
                    if (p.PlayerId == 2)
                    {
                        p_ = p;
                        break;
                    }
                }

                if (p_ != null)
                {
                    p_.Mastery = 88;
                    string duongdan = AppDomain.CurrentDomain.BaseDirectory;
                    string ddknnc = Path.Combine(duongdan, "PlayerSkills.txt");

                    using (StreamWriter writer = new StreamWriter(ddknnc))
                    {
                        writer.WriteLine("player_id\tplayer_name\tskill_id\tmastery");
                        foreach (var p in PlayerSkills)
                        {
                            writer.WriteLine($"{p.PlayerId}\t{p.PlayerName}\t{p.SkillId}\t{p.Mastery}");
                        }
                    }

                    MessageBox.Show("Sửa thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người chơi có player_id = 2.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin: " + ex.Message);
            }
        }

        private void btnthongke_0534_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = 0;
                foreach (var player in PlayerSkills)
                {
                    foreach (var skill in SkillDB)
                    {
                        if (player.SkillId == skill.SkillId && skill.Rank == "A")
                        {
                            sl++;
                            break;
                        }
                    }
                }

                MessageBox.Show("Số người chơi có kỹ năng rank A là " + sl + "người");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message);
            }
        }
    }
    
}
