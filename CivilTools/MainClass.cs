using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CivilTools
{

    public class MainClass
    {
        [CommandMethod("US")]//CAD启动界面
        public void UiStart()
        {
            TestForm myfrom = new TestForm();
            //  Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(myfrom); //  模态显示

            Autodesk.AutoCAD.ApplicationServices.Application.ShowModelessDialog(myfrom); //  非模态显示

        }
    }
}
