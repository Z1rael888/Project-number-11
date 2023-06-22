using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G7_61860_C11._1
{
    public partial class WorkPanel : Form
    {
       
        public static WorkPanel ob_61860_workPanel; // deklarujemy publiczną zmienną WorkPanel typu WorkPanel.
        Controlls ob_61860_crl = new Controlls();  // Przypisujemu new Controlls() do zmiennej ob_61860_crl wskazuje,
                                          // że tworzony jest nowy obiekt typu Controlls przy użyciu konstruktora domyślnego tej klasy.
        Button ob_61860_clearButton = new Button(); // tworzymy inatację klasy Button i przypisujemy ją do zmiennej ob_61860_clearButton
        Button ob_61860_manualButton = new Button(); // tworzymy inatację klasy Button i przypisujemy ją do zmiennej ob_61860_manualButton
        Button ob_61860_exitButton = new Button(); // tworzymy inatację klasy Button i przypisujemy ją do zmiennej ob_61860_exitButton
        Button ob_61860_autoButton = new Button(); // tworzymy inatację klasy Button i przypisujemy ją do zmiennej ob_61860_autoButton
        Button ob_61860_generateButton = new Button(); // tworzymy inatację klasy Button i przypisujemy ją do zmiennej ob_61860_generateButton

        private Color ob_61860_selectedForeColor { get; set; } // deklarujemy prywatną właściwość ob_61860_selectedForeColor aby zapisać wybrany kolor
        private Color ob_61860_selectedBackColor { get; set; } // deklarujemy prywatną właściwość ob_61860_selectedBackColor aby zapisać wybrany kolor

        GroupBox ob_61860_Gb003 { get; set; } // deklarujemy zmenną o nazwie ob_61860_Gb003 typu GroupBox
        public WorkPanel()
        {
            InitializeComponent();
            ob_61860_workPanel = this; // inicializujemy pole ob_61860_workPanel
            OB_61860_LoadControls(); // wywołamy metodu OB_61860_LoadControls();
            ob_61860_crl = new Controlls(); // tworzymy object typu Controlls iprzeisujemy do zmiennej ob_61860_crl

            OB_61860_ZmienKolor(ob_61860_clearButton, 1); // wywołamy metodę OB_61860_ZmienKolor dla ob_61860_clearButton w postaci 1
            OB_61860_ZmienKolor(ob_61860_exitButton, 1); // wywołamy metodę OB_61860_ZmienKolor dla ob_61860_exitButton w postaci 1
            OB_61860_ZmienKolor(ob_61860_manualButton, 1); // wywołamy metodę OB_61860_ZmienKolor dla ob_61860_manualButton w postaci 1
            OB_61860_ZmienKolor(ob_61860_autoButton, 1); // wywołamy metodę OB_61860_ZmienKolor dla ob_61860_autoButton w postaci 1


        }
        private void OB_61860_LoadControls()
        {
            Font ob_61860_font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold); // tworzymy object typu Font o nazwie ob_61860_font
            Color ob_61860_foreColor = Color.DarkBlue; // tworzymy object typu Color o nazwie forColor
            Color ob_61860_backColor = Color.FromKnownColor(KnownColor.Control); // tworzymy object typu Color o nazwie ob_61860_backColor
            string ob_61860_text = ""; // inicializujemy ob_61860_text pustym ciągem znaków

            GroupBox ob_61860_Gb001 = ob_61860_crl.Create_GroupBox("GbWorkPanel", 15, 10, 825, 450, "Work Panel"); // stosujemy metodę Create_GroupBox do tworzenia grupy elementów GroupBox o nazwie ob_61860_Gb001 z parametrami
            ob_61860_workPanel.Controls.Add(ob_61860_Gb001); // dodajemy ob_61860_Gb001 do ob_61860_workPanel

            GroupBox ob_61860_Gb002 = ob_61860_crl.Create_GroupBox("GbArrangements", 850, 10, 120, 450, "Arrangements"); // stosujemy metodę Create_GroupBox do tworzenia grupy elementów GroupBox o nazwie ob_61860_Gb002 z parametrami
            ob_61860_workPanel.Controls.Add(ob_61860_Gb002); // dodajemy ob_61860_Gb002 do ob_61860_workPanel

            ob_61860_Gb003 = ob_61860_crl.Create_GroupBox("GbParameters", 15, 465, 955, 80, "Parameters"); // stosujemy metodę Create_GroupBox do tworzenia grupy elementów GroupBox o nazwie ob_61860_Gb003 z parametrami
            ob_61860_workPanel.Controls.Add(ob_61860_Gb003); // dadajemy ob_61860_Gb003 do ob_61860_workPanel

            // tworzymy przycisk ob_61860_autoButton z parametrami
            ob_61860_autoButton = ob_61860_crl.Create_Button("Auto Button", 12, 25, 95, 50, ob_61860_font, ob_61860_foreColor, ob_61860_backColor, ob_61860_text = "AUTO");
            ob_61860_autoButton.Click += new EventHandler(autoButton_Click); // odwołanie na metodu autoButton_Click
            ob_61860_autoButton.MouseHover += new EventHandler(autoButton_MouseHover); // odwołanie na metodu autoButton_MouseHover
            ob_61860_autoButton.MouseLeave += new EventHandler(autoButton_MouseLeave); // odwołanie na metodu autoButton_Click
            ob_61860_Gb002.Controls.Add(ob_61860_autoButton); // dodajemy przycisk ob_61860_autoButton do ob_61860_workPanel

          
            ob_61860_manualButton = ob_61860_crl.Create_Button("Manual Button", 12, 85, 95, 50, ob_61860_font, ob_61860_foreColor, ob_61860_backColor, ob_61860_text = "MANUAL");
            ob_61860_manualButton.Click += new EventHandler(manualButton_Click); 
            ob_61860_manualButton.MouseHover += new EventHandler(manualButton_MouseHover);
            ob_61860_manualButton.MouseLeave += new EventHandler(manualButton_MouseLeave);
            ob_61860_Gb002.Controls.Add(ob_61860_manualButton);

            ob_61860_exitButton = ob_61860_crl.Create_Button("Exit Button", 12, 360, 95, 50, ob_61860_font, ob_61860_foreColor, ob_61860_backColor, ob_61860_text = "EXIT");
            ob_61860_exitButton.Click += new EventHandler(exitButton_Click);
            ob_61860_exitButton.MouseHover += new EventHandler(exitButton_MouseHover);
            ob_61860_exitButton.MouseLeave += new EventHandler(exitButton_MouseLeave);
            ob_61860_Gb002.Controls.Add(ob_61860_exitButton);

            ob_61860_clearButton = ob_61860_crl.Create_Button("Clear Button", 12, 300, 95, 50, ob_61860_font, ob_61860_foreColor, ob_61860_backColor, ob_61860_text = "CLEAR");
            ob_61860_clearButton.Click += new EventHandler(clearButton_Click);
            ob_61860_clearButton.MouseHover += new EventHandler(clearButton_MouseHover);
            ob_61860_clearButton.MouseLeave += new EventHandler(clearButton_MouseLeave);
            ob_61860_Gb002.Controls.Add(ob_61860_clearButton);

        }

        private void OB_61860_LoadParameteres()
        {
            Font ob_61860_font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold); // tworzymy object typu Font o nazwie ob_61860_font
            Color ob_61860_foreColor = Color.DarkBlue; // tworzymy object typu Color o nazwie forColor
            Color ob_61860_backColor = Color.FromKnownColor(KnownColor.Control); // tworzymy object typu Color o nazwie ob_61860_backColor
            string ob_61860_text = ""; // inicializujemy ob_61860_text pustym ciągem znaków
            OB_61860_ZmienKolor(ob_61860_generateButton, 1); // Wywołujemy metody OB_61860_ZmienKolor z argumentem ob_61860_generateButton i wartością 1.

            // Sprawdzenie, czy ob_61860_Gb003 nie jest null.
            if (ob_61860_Gb003 != null)
            {
                // tworzymy przycisk ob_61860_generateButton z parametrami
                ob_61860_generateButton = ob_61860_crl.Create_Button("Generate Button", 848, 15, 95, 50, ob_61860_font, ob_61860_foreColor, Color.Orange, ob_61860_text = "GENERATE");
                ob_61860_generateButton.Click += new EventHandler(ob_61860_generateButton_Click); // odwołanie na metodu ob_61860_generateButton_Click
                ob_61860_generateButton.MouseHover += new EventHandler(generateButton_MouseHover); // odwołanie na metodu generateButton_MouseHover
                ob_61860_generateButton.MouseLeave += new EventHandler(generateButton_MouseLeave); // odwołanie na metodu generateButton_MouseHover
                ob_61860_Gb003.Controls.Add(ob_61860_generateButton);

                CheckBox ob_61860_labelCheckBox = ob_61860_crl.Create_CheckBox("ob_61860_labelCheckBox", 15, 15, 70, 20, ob_61860_font, ob_61860_foreColor, false, "Label"); // tworzenie kontrolki CheckBox o nazwie ob_61860_labelCheckBox i dodawanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_labelCheckBox);

                CheckBox ob_61860_textBoxCheckBox = ob_61860_crl.Create_CheckBox("ob_61860_textBoxCheckBox", 15, 40, 80, 20, ob_61860_font, ob_61860_foreColor, false, "TextBox"); // tworzenie kontrolki CheckBox o nazwie ob_61860_textBoxCheckBox i dodawanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_textBoxCheckBox);

                Label ob_61860_widthLabel = ob_61860_crl.Create_Label("ob_61860_widthLabel", new Point(100, 15), 50, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Width:"); // Tworzenie etykiety WidthLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_widthLabel);

                Label ob_61860_heightLabel = ob_61860_crl.Create_Label("ob_61860_heightLabel", new Point(100, 40), 50, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Height:"); // Tworzenie etykiety ob_61860_heightLabel i włączenie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_heightLabel);

                Label ob_61860_backColorLabel = ob_61860_crl.Create_Label("ob_61860_backColorLabel", new Point(230, 15), 75, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Back Color:"); // Tworzenie etykiety ob_61860_backColorLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_backColorLabel);

                Label ob_61860_foreColorLabel = ob_61860_crl.Create_Label("ob_61860_foreColorLabel", new Point(230, 40), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Fore Color:"); // Tworzenie etykiety ob_61860_foreColorLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_foreColorLabel);

                Label ob_61860_topMarginLabel = ob_61860_crl.Create_Label("ob_61860_topMarginLabel", new Point(390, 15), 80, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Top Margin:"); // Tworzenie etykiety ob_61860_topMarginLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_topMarginLabel);

                Label ob_61860_leftmarginLabel = ob_61860_crl.Create_Label("ob_61860_leftmarginLabel", new Point(390, 40), 80, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Left Margin:"); // Tworzenie etykiety ob_61860_leftmarginLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_leftmarginLabel);

                Label ob_61860_columnsShiftLabel = ob_61860_crl.Create_Label("ob_61860_columnsShiftLabel", new Point(550, 15), 100, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Columns shift:"); // Tworzenie etykiety ob_61860_columnsShiftLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_columnsShiftLabel);

                Label ob_61860_RowsShiftLabel = ob_61860_crl.Create_Label("ob_61860_RowsShiftLabel", new Point(550, 40), 100, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor, "Rows shift:"); // Tworzenie etykiety ob_61860_RowsShiftLabel i dodanie jej do ob_61860_Gb003.
                ob_61860_Gb003.Controls.Add(ob_61860_RowsShiftLabel);

                TextBox ob_61860_widthTextBox = ob_61860_crl.Create_TextBox("ob_61860_widthTextBox", new Point(150, 15), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_widthTextBox do ob_61860_Gb003
                ob_61860_widthTextBox.KeyPress += new KeyPressEventHandler(ob_61860_widthTextBox_KeyPress); //  dodanie zdarzenia obsługi KeyPress
                ob_61860_Gb003.Controls.Add(ob_61860_widthTextBox);

                TextBox ob_61860_backColorTextBox = ob_61860_crl.Create_TextBox("ob_61860_backColorTextBox", new Point(310, 15), 70, 20, ob_61860_font, Color.Green, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_backColorTextBox do ob_61860_Gb003
                ob_61860_backColorTextBox.Click += new EventHandler(backColorTextBox_Click); // dodanie zdarzenia obsługi Click
                ob_61860_Gb003.Controls.Add(ob_61860_backColorTextBox);

                TextBox ob_61860_foreColorTextBox = ob_61860_crl.Create_TextBox("ob_61860_foreColorTextBox", new Point(310, 40), 70, 20, ob_61860_font, Color.Black, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_foreColorTextBox do ob_61860_Gb003
                ob_61860_foreColorTextBox.Click += new EventHandler(foreColorTextBox_Click);
                ob_61860_Gb003.Controls.Add(ob_61860_foreColorTextBox);

                TextBox ob_61860_heightTextBox = ob_61860_crl.Create_TextBox("ob_61860_heightTextBox", new Point(150, 40), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_heightTextBox do ob_61860_Gb003
                ob_61860_heightTextBox.KeyPress += new KeyPressEventHandler(ob_61860_heightTextBox_KeyPress); // dodanie zdarzenia obsługi KeyPress
                ob_61860_Gb003.Controls.Add(ob_61860_heightTextBox);

                TextBox ob_61860_topMarginTextBox = ob_61860_crl.Create_TextBox("ob_61860_topMarginTextBox", new Point(470, 15), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_topMarginTextBox do ob_61860_Gb003
                ob_61860_topMarginTextBox.KeyPress += new KeyPressEventHandler(ob_61860_topMarginTextBox_KeyPress);
                ob_61860_Gb003.Controls.Add(ob_61860_topMarginTextBox);

                TextBox ob_61860_leftMarginTextBox = ob_61860_crl.Create_TextBox("ob_61860_leftMarginTextBox", new Point(470, 40), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_leftMarginTextBox do ob_61860_Gb003
                ob_61860_leftMarginTextBox.KeyPress += new KeyPressEventHandler(ob_61860_leftMarginTextBox_KeyPress);
                ob_61860_Gb003.Controls.Add(ob_61860_leftMarginTextBox);

                TextBox ob_61860_columnsTextBox = ob_61860_crl.Create_TextBox("ob_61860_columnsTextBox", new Point(650, 15), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_columnsTextBox do ob_61860_Gb003
                ob_61860_columnsTextBox.KeyPress += new KeyPressEventHandler(ob_61860_columnsTextBox_KeyPress);
                ob_61860_Gb003.Controls.Add(ob_61860_columnsTextBox);

                TextBox ob_61860_rowsTextBox = ob_61860_crl.Create_TextBox("ob_61860_rowsTextBox", new Point(650, 40), 70, 20, ob_61860_font, ob_61860_backColor, ob_61860_foreColor); // Dodawanie pola tekstowego ob_61860_rowsTextBox do ob_61860_Gb003
                ob_61860_rowsTextBox.KeyPress += new KeyPressEventHandler(ob_61860_rowsTextBox_KeyPress);
                ob_61860_Gb003.Controls.Add(ob_61860_rowsTextBox);
            }
        }

        //Dzięki tej metodzie kontrolka ob_61860_rowsTextBox obsługuje zdarzenie KeyPress.
        //Jej obowiązkiem jest sprawdzenie, czy wprowadzony znak jest cyfrą lub znakiem kontrolnym, takim jak backspace.
        //Jeśli nie, wyświetla komunikat o błędzie i blokuje wprowadzanie znaku.
        private void ob_61860_rowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Wystąpił błąd! Wprowadż liczbe tyłko");
                e.Handled = true;
            }


        }


        //Dzięki tej metodzie kontrolka ob_61860_columnsTextBox obsługuje zdarzenie KeyPress.
        //Jej obowiązkiem jest sprawdzenie, czy wprowadzony znak jest cyfrą lub znakiem kontrolnym, takim jak backspace.
        //Jeśli nie, wyświetla komunikat o błędzie i blokuje wprowadzanie znaku.
        private void ob_61860_columnsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Wystąpił błąd! Wprowadż liczbe tyłko");
                e.Handled = true;
            }

        }

        //Dzięki tej metodzie kontrolka ob_61860_rowsTextBox obsługuje zdarzenie KeyPress.
        //Jej obowiązkiem jest sprawdzenie, czy wprowadzony znak jest cyfrą lub znakiem kontrolnym, takim jak backspace.
        //Jeśli nie, wyświetla komunikat o błędzie i blokuje wprowadzanie znaku.
        private void ob_61860_leftMarginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Wystąpił błąd! Wprowadż liczbe tyłko");
                e.Handled = true;
            }
        }


        //Dzięki tej metodzie kontrolka ob_61860_topMarginTextBox obsługuje zdarzenie KeyPress.
        //Jej obowiązkiem jest sprawdzenie, czy wprowadzony znak jest cyfrą lub znakiem kontrolnym, takim jak backspace.
        //Jeśli nie, wyświetla komunikat o błędzie i blokuje wprowadzanie znaku.
        private void ob_61860_topMarginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Wystąpił błąd! Wprowadż liczbe tyłko");
                e.Handled = true;
            }
        }


        //Dzięki tej metodzie kontrolka ob_61860_widthTextBox obsługuje zdarzenie KeyPress.
        //Jej obowiązkiem jest sprawdzenie, czy wprowadzony znak jest cyfrą lub znakiem kontrolnym, takim jak backspace.
        //Jeśli nie, wyświetla komunikat o błędzie i blokuje wprowadzanie znaku.
        private void ob_61860_widthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Wystąpił błąd! Wprowadż liczbe tyłko");
                e.Handled = true;
            }
        }


        //Dzięki tej metodzie kontrolka ob_61860_heightTextBox obsługuje zdarzenie KeyPress.
        //Jej obowiązkiem jest sprawdzenie, czy wprowadzony znak jest cyfrą lub znakiem kontrolnym, takim jak backspace.
        //Jeśli nie, wyświetla komunikat o błędzie i blokuje wprowadzanie znaku.
        private void ob_61860_heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Wystąpił błąd! Wprowadż liczbe tyłko");
                e.Handled = true;
            }
        }

        //to jest metoda ob_61860_generateButton_Click, która obsługuje ten przycisk
        private void ob_61860_generateButton_Click(object sender, EventArgs e)
        {
            //najpierw szukamy tego kontenera WorkPanel
            GroupBox ob_61860_gb = (GroupBox)this.Controls.Find("GbWorkPanel", true)[0];
            // sprawdzenie, czy kontener zawiera jakieś kontrolki
            if (ob_61860_gb.Controls.Count > 0)
                ob_61860_gb.Controls.Clear();

            //szukamy nasze textboxy z których pobieramy dane wejściowe
            TextBox ob_61860_widthTextBox = (TextBox)this.Controls.Find("ob_61860_widthTextBox", true)[0];
            string ob_61860_width = ob_61860_widthTextBox.Text;
            int ob_61860_widthResult = int.Parse(ob_61860_width);
            //szukamy nasze textboxy z których pobieramy dane wejściowe
            TextBox ob_61860_heightTextBox = (TextBox)this.Controls.Find("ob_61860_heightTextBox", true)[0];
            string ob_61860_height = ob_61860_heightTextBox.Text;
            int ob_61860_heightResult = int.Parse(ob_61860_height);
            //szukamy nasze textboxy z których pobieramy dane wejściowe
            TextBox ob_61860_topMarginTextBox = (TextBox)this.Controls.Find("ob_61860_topMarginTextBox", true)[0];
            string ob_61860_topMargin= ob_61860_topMarginTextBox.Text;
            int ob_61860_topMarginResult = int.Parse(ob_61860_topMargin);
            //szukamy nasze textboxy z których pobieramy dane wejściowe
            TextBox ob_61860_leftMarginTextBox = (TextBox)this.Controls.Find("ob_61860_leftMarginTextBox", true)[0];
            string ob_61860_leftMargin = ob_61860_leftMarginTextBox.Text;
            int ob_61860_leftMarginResult = int.Parse(ob_61860_leftMargin);
            //szukamy nasze textboxy z których pobieramy dane wejściowe
            TextBox ob_61860_rowsTextBox = (TextBox)this.Controls.Find("ob_61860_rowsTextBox", true)[0];
            string ob_61860_rowsShift = ob_61860_rowsTextBox.Text;
            int ob_61860_rowsShiftResult = int.Parse(ob_61860_rowsShift);
            //szukamy nasze textboxy z których pobieramy dane wejściowe
            TextBox ob_61860_columnsTextBox = (TextBox)this.Controls.Find("ob_61860_columnsTextBox", true)[0];
            string ob_61860_columnsShift = ob_61860_columnsTextBox.Text;
            int ob_61860_columnsShiftResult = int.Parse(ob_61860_columnsShift);

            //szukamy checkBox ob_61860_labelCheckBox
            CheckBox ob_61860_labelCheckBox = (CheckBox)ob_61860_Gb003.Controls.Find("ob_61860_labelCheckBox", true)[0];
            //warunek , kiedy labelCheckbox Checked
            if (ob_61860_labelCheckBox.Checked)
            {
                int ob_61860_rowsShiftX = ob_61860_rowsShiftResult;
                int ob_61860_columnsShiftX = ob_61860_columnsShiftResult;
                int ob_61860_topMarginX =  ob_61860_topMarginResult;
                int ob_61860_leftMarginX = ob_61860_leftMarginResult;
                int ob_61860_nbOfControlls = 110;
                int ob_61860_labelWidth = ob_61860_widthResult;
                int ob_61860_labelHeight = ob_61860_heightResult;
                Font ob_61860_labelFont = new Font("Tahoma", 12, FontStyle.Bold);
                Point ob_61860_controllPoint = new Point(ob_61860_leftMarginX, ob_61860_topMarginX);
                Color ob_61860_labelColor = ob_61860_selectedBackColor;
                Color ob_61860_foreColor = ob_61860_selectedForeColor;
                string ob_61860_controlName = "";
                for (int i = 1; i <= ob_61860_nbOfControlls; i++)
                {
                    // dodanie obiektu typu Label
                    ob_61860_controlName = "Lb" + i.ToString();
                    Label ob_61860_newLabel = ob_61860_crl.Create_Label(ob_61860_controlName, ob_61860_controllPoint,
                    ob_61860_labelWidth, ob_61860_labelHeight, ob_61860_labelFont, ob_61860_labelColor,
                    ob_61860_foreColor, i.ToString());
                    ob_61860_gb.Controls.Add(ob_61860_newLabel);
                    ob_61860_controllPoint.X = ob_61860_controllPoint.X + ob_61860_rowsShiftX;
                    ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + ob_61860_columnsShiftX;

                    ob_61860_controllPoint.X = ob_61860_leftMarginX ;

                    if (ob_61860_controllPoint.Y + 35 > ob_61860_gb.Height)
                    {
                        ob_61860_leftMarginX = ob_61860_leftMarginX + 130;
                        ob_61860_controllPoint.X = ob_61860_leftMarginX;
                        ob_61860_controllPoint.Y = ob_61860_topMarginX;
                    }
                    else
                        ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + 25;
                    if (ob_61860_controllPoint.X + 125 > ob_61860_gb.Width)
                        i = ob_61860_nbOfControlls;
                }
            }
            //szukamy checkBox ob_61860_textBoxCheckBox
            CheckBox ob_61860_textBoxCheckBox = (CheckBox)ob_61860_Gb003.Controls.Find("ob_61860_textBoxCheckBox", true)[0];
            //warunek kiedy ob_61860_textBox jest Checked
            if (ob_61860_textBoxCheckBox.Checked)
            {

                int ob_61860_rowsShiftX = ob_61860_rowsShiftResult;
                int ob_61860_columnsShiftX = ob_61860_columnsShiftResult;
                int ob_61860_nbOfControlls = 110;
                int ob_61860_topMarginX =  ob_61860_topMarginResult;
                int ob_61860_leftMarginX = ob_61860_leftMarginResult;
                int ob_61860_textBoxWidth = ob_61860_widthResult;
                int ob_61860_textBoxHeight = ob_61860_heightResult;
                Font ob_61860_textboxFont = new Font("Tahoma", 8, FontStyle.Bold);
                Color ob_61860_textboxColor = ob_61860_selectedBackColor;
                Color ob_61860_foreColor = ob_61860_selectedForeColor;
                string ob_61860_controlName = "";
                Point ob_61860_controllPoint = new Point(ob_61860_leftMarginX, ob_61860_topMarginX);
                for (int i = 1; i <= ob_61860_nbOfControlls; i++)
                {
                    // dodanie obiektu typu ob_61860_textBox
                    ob_61860_controlName = "Tb" + i.ToString();
                    TextBox ob_61860_newTextBox = ob_61860_crl.Create_TextBox(ob_61860_controlName,
                    ob_61860_controllPoint, ob_61860_textBoxWidth, ob_61860_textBoxHeight, ob_61860_textboxFont,
                    ob_61860_textboxColor, ob_61860_foreColor);
                    ob_61860_gb.Controls.Add(ob_61860_newTextBox);
                    ob_61860_controllPoint.X = ob_61860_controllPoint.X + ob_61860_rowsShiftX;
                    ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + ob_61860_columnsShiftX;

                    ob_61860_controllPoint.X = ob_61860_leftMarginX;

                    if (ob_61860_controllPoint.Y + 35 > ob_61860_gb.Height)
                    {
                        ob_61860_leftMarginX = ob_61860_leftMarginX + 130;
                        ob_61860_controllPoint.X = ob_61860_leftMarginX;
                        ob_61860_controllPoint.Y = ob_61860_topMarginX;
                    }
                    else
                        ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + 25;
                    if (ob_61860_controllPoint.X + 125 > ob_61860_gb.Width)
                        i = ob_61860_nbOfControlls;
                }
            }
            //warunek kiedy dwa tych checboksy są checked
            if(ob_61860_labelCheckBox.Checked && ob_61860_textBoxCheckBox.Checked)
            {

                GroupBox ob_61860_gb1 = (GroupBox)this.Controls.Find("GbWorkPanel", true)[0];
                // sprawdzenie, czy kontener zawiera jakieś kontrolki
                if (ob_61860_gb1.Controls.Count > 0)
                    ob_61860_gb1.Controls.Clear();

                // deklaracja zmiennych lokalnych
                int ob_61860_rowsShiftX = ob_61860_rowsShiftResult;
                int ob_61860_columnsShiftX = ob_61860_columnsShiftResult;
                int ob_61860_topmargin = ob_61860_topMarginResult;
                int ob_61860_leftmargin = ob_61860_leftMarginResult;
                int ob_61860_labelWidth = ob_61860_widthResult;
                int ob_61860_labelHeight = ob_61860_heightResult;
                int ob_61860_nbOfControlls = 110;
                string ob_61860_controlName = "";
                Point ob_61860_controllPoint = new Point(ob_61860_leftmargin, ob_61860_topmargin);
                Font ob_61860_labelFont = new Font("Tahoma", 12, FontStyle.Bold);
                Font ob_61860_textboxFont = new Font("Tahoma", 8, FontStyle.Bold);
                Color ob_61860_labelColor = ob_61860_selectedBackColor;
                Color ob_61860_textboxColor = ob_61860_selectedBackColor;
                Color ob_61860_foreColor = ob_61860_selectedForeColor;
                // iteracyjne rozmieszczenie obiektów typu Label i TextBox
                for (int i = 1; i <= ob_61860_nbOfControlls; i++)
                {
                    // dodanie obiektu typu Label
                    ob_61860_controlName = "Lb" + i.ToString();
                    Label ob_61860_newLabel = ob_61860_crl.Create_Label(ob_61860_controlName, ob_61860_controllPoint,
                    ob_61860_labelWidth, ob_61860_labelHeight, ob_61860_labelFont, ob_61860_labelColor,
                    ob_61860_foreColor, i.ToString());
                    ob_61860_gb.Controls.Add(ob_61860_newLabel);
                    ob_61860_controllPoint.X = ob_61860_controllPoint.X + 40;
                    ob_61860_controllPoint.Y = ob_61860_controllPoint.Y +  ob_61860_columnsShiftX;
                    // dodanie obiektu typu ob_61860_textBox
                    ob_61860_controlName = "Tb" + i.ToString();
                    TextBox newTextBox = ob_61860_crl.Create_TextBox(ob_61860_controlName,
                    ob_61860_controllPoint, 60, 15, ob_61860_textboxFont,
                    ob_61860_textboxColor, ob_61860_foreColor);
                    ob_61860_gb.Controls.Add(newTextBox);

                    ob_61860_controllPoint.X = ob_61860_leftmargin;

                    if (ob_61860_controllPoint.Y + 35 > ob_61860_gb.Height)
                    {
                        ob_61860_leftmargin = ob_61860_leftmargin + 130;
                        ob_61860_controllPoint.X = ob_61860_leftmargin;
                        ob_61860_controllPoint.Y = ob_61860_topmargin;
                    }
                    else
                        ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + 25;
                    if (ob_61860_controllPoint.X + 125 > ob_61860_gb.Width)
                        i = ob_61860_nbOfControlls;
                }
            }
        }
        private void autoButton_Click(object sender, EventArgs e)
        {
            GroupBox ob_61860_gb = (GroupBox)this.Controls.Find("GbWorkPanel", true)[0]; // Pobieramy jest kontener typu GroupBox o nazwie "GbWorkPanel" za pomocą metody 
            // sprawdzenie, czy kontener zawiera jakieś kontrolki
            if (ob_61860_gb.Controls.Count > 0)
                ob_61860_gb.Controls.Clear();

            // deklaracja zmiennych lokalnych
            int ob_61860_topMargin = 20;
            int ob_61860_leftMargin = 15;
            int ob_61860_labelWidth = 40;
            int ob_61860_labelHeight = 25;
            int ob_61860_nbOfControlls = 110;
            string ob_61860_controlName = "";
            Point ob_61860_controllPoint = new Point(ob_61860_leftMargin, ob_61860_topMargin);
            Font ob_61860_labelFont = new Font("Tahoma", 12, FontStyle.Bold);
            Font ob_61860_textboxFont = new Font("Tahoma", 8, FontStyle.Bold);
            Color ob_61860_labelColor = Color.FromKnownColor(KnownColor.Control);
            Color ob_61860_textboxColor = Color.Bisque;
            Color ob_61860_foreColor = Color.Red;
            // iteracyjne rozmieszczenie obiektów typu Label i TextBox
            for (int i = 1; i <= ob_61860_nbOfControlls; i++)
            {
                // dodanie obiektu typu Label
               ob_61860_controlName = "Lb" + i.ToString();
                Label ob_61860_newLabel = ob_61860_crl.Create_Label(ob_61860_controlName, ob_61860_controllPoint,
                ob_61860_labelWidth, ob_61860_labelHeight, ob_61860_labelFont, ob_61860_labelColor,
                ob_61860_foreColor, i.ToString());
                ob_61860_gb.Controls.Add(ob_61860_newLabel);
                ob_61860_controllPoint.X = ob_61860_controllPoint.X + 40;
                ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + 0;
                // dodanie obiektu typu ob_61860_textBox
                ob_61860_controlName = "Tb" + i.ToString();
                TextBox ob_61860_newTextBox = ob_61860_crl.Create_TextBox(ob_61860_controlName,
                ob_61860_controllPoint, 60, 15, ob_61860_textboxFont,
                ob_61860_textboxColor, ob_61860_foreColor);
                ob_61860_gb.Controls.Add(ob_61860_newTextBox);

                ob_61860_controllPoint.X = ob_61860_leftMargin;

                if (ob_61860_controllPoint.Y + 35 > ob_61860_gb.Height)
                {
                    ob_61860_leftMargin = ob_61860_leftMargin + 130;
                    ob_61860_controllPoint.X = ob_61860_leftMargin;
                    ob_61860_controllPoint.Y = ob_61860_topMargin;
                }
                else
                    ob_61860_controllPoint.Y = ob_61860_controllPoint.Y + 25;
                if (ob_61860_controllPoint.X + 125 > ob_61860_gb.Width)
                    i = ob_61860_nbOfControlls;
            }
        }

        // wywołanie wyścia z aplikacii dla przycisak ob_61860_exitButton
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //wywołania metody 
        private void clearButton_Click(object sender,EventArgs e0)
        {
            ClearGroupBoxes(1);
        }

        // metoda umożliwia kliknięcie w TextBox, które umożliwia wybór koloru przedniego planu.
        private void foreColorTextBox_Click(object sender, EventArgs e)
        {
            ColorDialog ob_61860_colorDialog = new ColorDialog(); // Jest tworzony obiekt ColorDialog, który pozwala użytkownikom wybierać kolory.
            DialogResult ob_61860_resultColor = ob_61860_colorDialog.ShowDialog();  // Wywołuje się okno dialogowe, w którym można wybrać kolor.

            // Jeżeli wynik wyboru koloru jest DialogResult.OK wtedy:
            if (ob_61860_resultColor == DialogResult.OK)
            {
                TextBox ob_61860_textBox = (TextBox)sender; // Obiekt sender jest pobrany jako TextBox i następnie rzutowany na typ TextBox.
                ob_61860_textBox.BackColor = ob_61860_colorDialog.Color; // Kolor (ob_61860_textBox.BackColor) jest ustawiany na wybrany kolor ob_61860_colorDialog.Color.
                ob_61860_selectedForeColor = ob_61860_colorDialog.Color; // Zmienna ob_61860_selectedForeColor przechowuje wybrany kolor jako kolor przedniego planu.
            }
        }
        private void backColorTextBox_Click(object sender, EventArgs e)
        {
            ColorDialog ob_61860_colorDialog = new ColorDialog();// Jest tworzony obiekt ColorDialog, który pozwala użytkownikom wybierać kolory.
            DialogResult ob_61860_resultColor = ob_61860_colorDialog.ShowDialog(); // Wywołuje się okno dialogowe, w którym można wybrać kolor.

            // Jeżeli wynik wyboru koloru jest DialogResult.OK wtedy:
            if (ob_61860_resultColor == DialogResult.OK)
            {

                TextBox ob_61860_textBox = (TextBox)sender; // Obiekt sender jest pobrany jako TextBox i następnie rzutowany na typ TextBox.
                ob_61860_textBox.BackColor = ob_61860_colorDialog.Color; // Kolor (ob_61860_textBox.BackColor) jest ustawiany na wybrany kolor ob_61860_colorDialog.Color.
                ob_61860_selectedBackColor = ob_61860_colorDialog.Color; // Zmienna ob_61860_selectedForeColor przechowuje wybrany kolor jako kolor przedniego planu.
            }
        }

        // wywołanie metody OB_61860_LoadParameteres dla przyciska ob_61860_manualButton
        private void manualButton_Click(object sender, EventArgs e)
        {
            OB_61860_LoadParameteres();
        }

        // metoda OB_61860_ZmienKolor
        private void OB_61860_ZmienKolor(object ob, int mode)
        {
            Button button = ob as Button; // sprawdzamy czy ob jest jako object Button
            if (ob != null) // jeżeli ob nie równa się 0 wtedy:
                switch (mode)
                {
                    case 0: // kolor tła przycisku zostaje ustawiony na domyślny kolor systemowy.
                        button.BackColor = Color.FromKnownColor(KnownColor.Control);
                        break;
                    case 1: //  kolor tła przycisku zostaje ustawiony na pomarańczowy.
                        button.BackColor = Color.Orange;
                        break;
                    
                }
        }

        // metoda ClearGroupBoxes
        private GroupBox ClearGroupBoxes(int function)
        {
            // odnalezienie kontenera GroupBox o nazwie „GbWorkPanel”
            // w kontenerze WorkPanel
            GroupBox ob_61860_gb1 = (GroupBox)this.Controls.Find("GbWorkPanel", true)[0];
            // sprawdzenie, czy kontener zawiera jakieś kontrolki
            if (ob_61860_gb1.Controls.Count > 0)
                ob_61860_gb1.Controls.Clear();
            switch (function)
            {
                case 0:
                    return null;
                    break;
                case 1:
                    return ob_61860_gb1;
                    break;
                default:
                    return null;
                    break;
            }
        }
        // obsługuje zachowanie MouseHover dla przycisku ob_61860_clearButton
        private void clearButton_MouseHover(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 0);
        }

        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_clearButton
        private void clearButton_MouseLeave(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 1);
        }
        // obsługuje zachowanie MouseHover dla przycisku ob_61860_exitButton
        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 0);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_exitButton
        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 1);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_manualButton
        private void manualButton_MouseHover(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 0);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_manualButton
        private void manualButton_MouseLeave(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 1);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_autoButton
        private void autoButton_MouseHover(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 0);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_autoButton
        private void autoButton_MouseLeave(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 1);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_generateButton
        private void generateButton_MouseHover(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 0);
        }
        // obsługuje zachowanie MouseLeave dla przycisku ob_61860_generateButton
        private void generateButton_MouseLeave(object sender, EventArgs e)
        {
            OB_61860_ZmienKolor(sender, 1);
        }

    }
}
