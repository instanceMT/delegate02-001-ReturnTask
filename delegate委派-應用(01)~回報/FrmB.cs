using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static delegate委派_應用_01__回報.TaskHelper;

namespace delegate委派_應用_01__回報
{
    public partial class FrmB : Form
    {
        ReturnHelp? _returnHelp = null;
        public FrmB()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 交付任務端以本方法交付任務給B
        /// 並將完工時回報的方法(合於委派~ReturnHelp規範) 傳送至B
        /// </summary>
        /// <param name="returnHelp"></param>
        public void AcceptHelp(ReturnHelp returnHelp)
        {
            if (_returnHelp == null)
            {
                _returnHelp = returnHelp;
            }
        }

        private void FrmB_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 完成工作後，B以委派 _returnHelp 指向的方法向交付端回報
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReturnHelp_Click(object sender, EventArgs e)
        {
            if (_returnHelp != default)
            {
                _returnHelp(this);
                _returnHelp = null;
            }
        }
    }
}
