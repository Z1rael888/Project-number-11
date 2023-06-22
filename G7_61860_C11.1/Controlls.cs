using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace G7_61860_C11._1
{
    public class Controlls
    {
       
        public Button Create_Button(string name,int x,int y,int width,int height,Font czcionka,Color foreColor, Color backColor,string text)
        {
            Button button = new Button
            {
                Name = name,
                Location = new Point(x,y),
                Width = width,
                Height = height,
                AutoSize = false,
                Font = czcionka,
                ForeColor = foreColor,
                BackColor = backColor,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            return button;
        }

        public CheckBox Create_CheckBox(string name, int x, int y, int width, int height, Font czcionka, Color foreColor,bool selected, string text)
        {
            CheckBox checkBox = new CheckBox
            {
                Name = name,
                Location = new Point(x, y),
                Width = width,
                Height = height,
                AutoSize = false,
                Font = czcionka,
                ForeColor = foreColor,
                Checked = selected,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            return checkBox;
        }

        public GroupBox Create_GroupBox(string name, int x, int y, int width, int height,  string text)
        {
            GroupBox groupBox = new GroupBox
            {
                Name = name,
                Location = new Point(x, y),
                Width = width,
                Height = height,
                Text = text
            };
            return groupBox;
        }

        public Label Create_Label(string name, Point Location, int width, int height,Font czcionka,Color backColor,Color foreColor, string text)
        {
            Label label = new Label
            {
                Name = name,
                Location = Location,
                Width = width,
                Height = height,
                AutoSize = false,
                Font = czcionka,
                BackColor = backColor,
                ForeColor = foreColor,
                Text = text
            };
            return label;
        }

        public TextBox Create_TextBox(string name, Point Location, int width, int height, Font czcionka, Color backColor,  Color foreColor)
        {
            TextBox textBox = new TextBox
            {
                Name = name,
                Location = Location,
                Width = width,
                Height = height,
                AutoSize = false,
                Font = czcionka,
                BackColor = backColor,
                ForeColor = foreColor,
                BorderStyle = BorderStyle.FixedSingle,

            };
            return textBox;
        }
    }
}
