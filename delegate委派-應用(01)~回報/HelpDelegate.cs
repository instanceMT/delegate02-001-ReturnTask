using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate委派_應用_01__回報
{
    // [存取範圍] delegate 函式回傳值型別 委派型別名稱(參數列)
    // ReturnHelp 宣告的委派物件指向没有回傳值、具一個 Form 型態參數的方法
    // 參數型態是 Form => 可以傳遞 Form 及 Form 子類別的物件
    public delegate void ReturnHelp(Form returnFrom);
}
