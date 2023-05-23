using GUIProject.shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIProject
{
    public class FormStateContainer
    {
        public List<IShape> DrawnShapesDrawingBoard1 = new List<IShape>();
        public List<GroupShape> Groups = new List<GroupShape>();

        public FormStateContainer(KnockOffPhotoShop name)
        {
            DrawnShapesDrawingBoard1 = name.DrawnShapesDrawingBoard1;
            Groups = name.Groups;
        }
        public FormStateContainer()
        {
        }
    }
}
