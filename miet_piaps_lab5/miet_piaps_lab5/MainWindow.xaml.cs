using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace miet_piaps.Lab5.Interpreter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Models.TextEditorInterpreter interpreter;
        public MainWindow()
        {
            InitializeComponent();
            interpreter = new Models.TextEditorInterpreter();
            inputTextBox.Text =
                "   Cоздать    простейший      интерпретатор\n" +
                "Разработать UML–диаграммы\n" +
                "C помощью паттерна “Interpreter”\n" +
                "Неправильное   использование       табуляторов\n" +
                "Наличие «лишнего» пробела после ( открывающей скобки), (перед закрывающей скобкой ), перед запятой , перед точкой .\n" +
                "Наличие \n\nмножественных символов \n\n\nперевода строки";

            #region Должно быть:
            /*
                1   Cоздать простейший интерпретатор (множественные пробелы)
                2   Разработать UML-диаграммы (дефис а не тире)
                3   C помощью паттерна «Interpreter» (правильные кавычки)
                4   Неправильное использование табуляторов
                5	 Наличие «лишнего» пробела после (открывающей скобки), (перед закрывающей скобкой), перед запятой, перед точкой.
                6   Наличие \nмножественных символов \nперевода строки
            */
            #endregion
        }

        private void CorrectionButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = interpreter.Interpret(inputTextBox.Text);
        }
    }
}
