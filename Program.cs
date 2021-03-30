using System;
using System.Drawing;
using Console = Colorful.Console;

namespace ColorPicker
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Input of the verse - ���� �����
            string verse = InputOfTheVerse();

            //Overriding verse in the array - ��������������� ����� � ������ 
            string[] versearr = OverridingVerseInTheArray(verse);

            //Entering colors of words of verse - ���� ������ ���� �����
            string[] colorarr = EnteringColorsOfWordsOfVerse(versearr);

            Console.WriteLine();

            //Output of verse in color - ����� ����� � �����
            OutputOfVerseInColor(versearr, colorarr);
            
            Console.ReadKey();
        }

        //The method of input of the verse - ����� ����� �����
        public static string InputOfTheVerse()
        {
            Console.WriteLine("������� ����");
            string verse = Convert.ToString(Console.ReadLine()) + " \n";
            string count = " ";

            //Entering of the verse is not yet entered by an empty Enter - ���� ����� ���� �� ����� ������ ������ Enter
            while (count != "")
            {
                count = Convert.ToString(Console.ReadLine());
                verse += count + " \n";
            }

            return verse;
        }

        //The method of overriding verse in the array - ����� ��������������� ����� � ������
        public static string[] OverridingVerseInTheArray(string verse)
        {
            //Formation of an array of words of divided spaces - ������������ ������� �� ���� ������������ ���������
            string[] versearr = verse.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return versearr;
        }

        //The method of inning the colors of words of verse - ����� ����� ������ ���� �����
        public static string[] EnteringColorsOfWordsOfVerse(string[] versearr)
        {
            Console.WriteLine("������� ����");
            string[] colorarr = new string[versearr.Length-2];

            //Introducting color and correction of his writing - ���� ����� � ��������� ��� ��������� 
            for(int i = 0; i < versearr.Length-2; i++)
            { 
                //string wordofverse = versearr[i].Replace('\n', ' ');
                char[] trimChars = {'\n', '.', ',', ';', ':', '!', ' '};
                string wordOfVerse = versearr[i].Trim(trimChars);
                Console.WriteLine("������� ���� ����� " + wordOfVerse.ToLower());

                colorarr[i] = Convert.ToString(Console.ReadLine());
                colorarr[i].ToLower();
            }

            return colorarr;
        }

        //The method of output of verse in color - ����� ������ ����� � �����
        public static void OutputOfVerseInColor(string[] versearr, string[] colorarr)
        {
            for (int i = 0; i < versearr.Length-2; i++)
            {
                string color = colorarr[i].Replace('�', 'e');
                Console.ForegroundColor = (color) switch
                {
                    "�����-�����" => ColorTranslator.FromHtml("#000080"),
                    "�����" => ColorTranslator.FromHtml("#0000FF"),
                    "���������" => ColorTranslator.FromHtml("#008080"),
                    "����" => ColorTranslator.FromHtml("#00FFFF"),
                    "�������" => ColorTranslator.FromHtml("#008000"),
                    "��������" => ColorTranslator.FromHtml("#00FF00"),
                    "���������" => ColorTranslator.FromHtml("#808000"),
                    "������" => ColorTranslator.FromHtml("#FFFF00"),
                    "��������" => ColorTranslator.FromHtml("#800000"),
                    "�������" => ColorTranslator.FromHtml("#FF0000"),
                    "���������" => ColorTranslator.FromHtml("#800080"),
                    "������" => ColorTranslator.FromHtml("#FF00FF"),
                    "�����" => ColorTranslator.FromHtml("#FFFFFF"),
                    "�����������" => ColorTranslator.FromHtml("#C0C0C0"),
                    "�����" => ColorTranslator.FromHtml("#808080"),
                    "������-�����" => ColorTranslator.FromHtml("#696969"),
                    "�����-�����" => ColorTranslator.FromHtml("#A9A9A9"),
                    "������-�����" => ColorTranslator.FromHtml("#D3D3D3"),
                    "��������" => ColorTranslator.FromHtml("#DCDCDC"),
                    "��������" => ColorTranslator.FromHtml("#F5F5F5"),
                    "�������" => ColorTranslator.FromHtml("#FFFAFA"),
                    "������-����������" => ColorTranslator.FromHtml("#BC8F8F"),
                    "������-����������" => ColorTranslator.FromHtml("#F08080"),
                    "����������" => ColorTranslator.FromHtml("#A52A2A"),
                    "���������" => ColorTranslator.FromHtml("#B22222"),
                    "������ ������-����������" => ColorTranslator.FromHtml("#800000"),
                    "�����-�������" => ColorTranslator.FromHtml("#8B0000"),
                    "���������" => ColorTranslator.FromHtml("#FA8072"),
                    "�������-�������" => ColorTranslator.FromHtml("#FFE4E1"),
                    "��������" => ColorTranslator.FromHtml("#FF6347"),
                    "�����-���������" => ColorTranslator.FromHtml("#E9967A"),
                    "��������-�������" => ColorTranslator.FromHtml("#FF4500"),
                    "������-���������" => ColorTranslator.FromHtml("#FFA07A"),
                    "����" => ColorTranslator.FromHtml("#A0522D"),
                    "������� ��������" => ColorTranslator.FromHtml("#FFF5EE"),
                    "��������� �����" => ColorTranslator.FromHtml("#8B4513"),
                    "����������" => ColorTranslator.FromHtml("#D2691E"),
                    "����������" => ColorTranslator.FromHtml("#FFDAB9"),
                    "���������" => ColorTranslator.FromHtml("#F4A460"),
                    "�������" => ColorTranslator.FromHtml("#FAF0E6"),
                    "������-����������" => ColorTranslator.FromHtml("#FFE4C4"),
                    "�����-���������" => ColorTranslator.FromHtml("#FF8C00"),
                    "�������� �����" => ColorTranslator.FromHtml("#FAEBD7"),
                    "��������� ����" => ColorTranslator.FromHtml("#D2B48C"),
                    "������� ���������" => ColorTranslator.FromHtml("#DEB887"),
                    "����������" => ColorTranslator.FromHtml("#FFEBCD"),
                    "������ ������" => ColorTranslator.FromHtml("#FFEFD5"),
                    "������� �������" => ColorTranslator.FromHtml("#FDF5E6"),
                    "���������" => ColorTranslator.FromHtml("#F5DEB3"),
                    "���������" => ColorTranslator.FromHtml("#FFA500"),
                    "��������-�����" => ColorTranslator.FromHtml("#FFA50"),
                    "���������-�������" => ColorTranslator.FromHtml("#DAA520"),
                    "������ ���������-�������" => ColorTranslator.FromHtml("#B8860B"),
                    "������� ��������" => ColorTranslator.FromHtml("#FFF8DC"),
                    "����������" => ColorTranslator.FromHtml("#FFD700"),
                    "��������� ������" => ColorTranslator.FromHtml("#FFFACD"),
                    "����" => ColorTranslator.FromHtml("#F0E68C"),
                    "������� ���������-�������" => ColorTranslator.FromHtml("#EEE8AA"),
                    "������ ����" => ColorTranslator.FromHtml("#BDB76B"),
                    "�������� �����" => ColorTranslator.FromHtml("#FFFFF0"),
                    "���" => ColorTranslator.FromHtml("#F5F5DC"),
                    "������-������" => ColorTranslator.FromHtml("#FFFFE0"),
                    "�����-���������" => ColorTranslator.FromHtml("#6B8E23"),
                    "�����-�������" => ColorTranslator.FromHtml("#9ACD32"),
                    "������ ��������-�������" => ColorTranslator.FromHtml("#556B2F"),
                    "������-������" => ColorTranslator.FromHtml("#ADFF2F"),
                    "������� �������" => ColorTranslator.FromHtml("#7CFC00"),
                    "������-�������" => ColorTranslator.FromHtml("#7FFF00"),
                    "������� ����" => ColorTranslator.FromHtml("#F0FFF0"),
                    "������ ������� �����" => ColorTranslator.FromHtml("#8FBC8F"),
                    "������-�������" => ColorTranslator.FromHtml("#90EE90"),
                    "������ ������" => ColorTranslator.FromHtml("#228B22"),
                    "�������� �����" => ColorTranslator.FromHtml("#32CD32"),
                    "�����-�������" => ColorTranslator.FromHtml("#006400"),
                    "�����" => ColorTranslator.FromHtml("#00FF00"),
                    "������� �����" => ColorTranslator.FromHtml("#2E8B57"),
                    "��������� ������� �����" => ColorTranslator.FromHtml("#3CB371"),
                    "������� �����" => ColorTranslator.FromHtml("#F5FFFA"),
                    "�������� ������" => ColorTranslator.FromHtml("#00FF7F"),
                    "��������� �������� ������" => ColorTranslator.FromHtml("#00FA9A"),
                    "��������� �������������" => ColorTranslator.FromHtml("#66CDAA"),
                    "������-�������" => ColorTranslator.FromHtml("#7FFFD4"),
                    "������� ������� �����" => ColorTranslator.FromHtml("#20B2AA"),
                    "��������� ���������" => ColorTranslator.FromHtml("#48D1CC"),
                    "��������" => ColorTranslator.FromHtml("#F0FFFF"),
                    "������-���������" => ColorTranslator.FromHtml("#AFEEEE"),
                    "������ �������-�����" => ColorTranslator.FromHtml("#2F4F4F"),
                    "�����-��������" => ColorTranslator.FromHtml("#008B8B"),
                    "������-��������" => ColorTranslator.FromHtml("#E0FFFF"),
                    "�����-���������" => ColorTranslator.FromHtml("#00CED1"),
                    "������� ������" => ColorTranslator.FromHtml("#B0E0E6"),
                    "������-�������" => ColorTranslator.FromHtml("#ADD8E6"),
                    "��������� �������-�������" => ColorTranslator.FromHtml("#00BFFF"),
                    "�������-�������" => ColorTranslator.FromHtml("#87CEEB"),
                    "������� �������-�������" => ColorTranslator.FromHtml("#87CEFA"),
                    "����������-��������" => ColorTranslator.FromHtml("#4682B4"),
                    "�������-�����" => ColorTranslator.FromHtml("#708090"),
                    "������� �������-�����" => ColorTranslator.FromHtml("#778899"),
                    "������� ����������-��������" => ColorTranslator.FromHtml("#BOC4DE"),
                    "�����������" => ColorTranslator.FromHtml("#6495ED"),
                    "����������� �������" => ColorTranslator.FromHtml("#4169E0"),
                    "���������-�����" => ColorTranslator.FromHtml("#F8F8FF"),
                    "����������" => ColorTranslator.FromHtml("#E6E6FA"),
                    "����� �������" => ColorTranslator.FromHtml("#191970"),
                    "��������" => ColorTranslator.FromHtml("#000080"),
                    "�������" => ColorTranslator.FromHtml("#0000FF"),
                    "������ �������-�����" => ColorTranslator.FromHtml("#483D8B"),
                    "��������� ���������" => ColorTranslator.FromHtml("#9370DB"),
                    "����-����������" => ColorTranslator.FromHtml("#8A2BE2"),
                    "������" => ColorTranslator.FromHtml("#4B0082"),
                    "�����-�������" => ColorTranslator.FromHtml("#9932CC"),
                    "�����-����������" => ColorTranslator.FromHtml("#9400D3"),
                    "��������� �������" => ColorTranslator.FromHtml("#BA55D3"),
                    "�����������" => ColorTranslator.FromHtml("#D8BFD8"),
                    "��������" => ColorTranslator.FromHtml("#DDA0DD"),
                    "����������" => ColorTranslator.FromHtml("#EE82EE"),
                    "������ ������" => ColorTranslator.FromHtml("#8B008B"),
                    "������" => ColorTranslator.FromHtml("#FF00FF"),
                    "��������� ������-�������" => ColorTranslator.FromHtml("#C71585"),
                    "���������� �������" => ColorTranslator.FromHtml("#FF1493"),
                    "����� �������" => ColorTranslator.FromHtml("#FF69B4"),
                    "����������� �������" => ColorTranslator.FromHtml("#FFF0F5"),
                    "������� ������-�������" => ColorTranslator.FromHtml("#DB7093"),
                    "���������" => ColorTranslator.FromHtml("#DC143C"),
                    "�������" => ColorTranslator.FromHtml("#FFC0CB"),
                    "������-�������" => ColorTranslator.FromHtml("#FFB6C1"),
                    _ => ColorTranslator.FromHtml("#FFFFFF"),
                };

                Console.Write(versearr[i] + " ");
                Console.ResetColor();
            }
        }
    }
}