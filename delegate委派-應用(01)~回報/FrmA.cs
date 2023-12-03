namespace delegate委派_應用_01__回報
{
    public partial class FrmA : Form
    {
        FrmB? frmB=null;
        public FrmA()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A 按鈕請B幫忙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAskBForHelp_Click(object sender, EventArgs e)
        {
            if (frmB == default)
            {
                frmB = new FrmB();
            }
            frmB.Visible = true;

            // 將ReturnTask 方法傳送給B
            // B 端以 ReturnHelp(委派)型別接收 
            // 完工時B以這個方法向A回報
            frmB.AcceptHelp(this.ReturnTask);
        }


        /// <summary>
        /// 受委託端工作完成時以這個方法回報
        /// </summary>
        /// <param name="returnFrom">
        /// 受委託的實體(繼承 Form 的實體)
        /// </param>
        public  void ReturnTask(Form returnFrom)
        {
            returnFrom.Visible = false;
            MessageBox.Show($"{returnFrom.Text} 完成工作");
        }
    }
}
