using System;
using System.Drawing;
using Console = Colorful.Console;

namespace ColorPicker
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Input of the verse - Ввод стиха
            string verse = InputOfTheVerse();

            //Overriding verse in the array - Переопределение стиха в массив 
            string[] versearr = OverridingVerseInTheArray(verse);

            //Entering colors of words of verse - Ввод цветов слов стиха
            string[] colorarr = EnteringColorsOfWordsOfVerse(versearr);

            Console.WriteLine();

            //Output of verse in color - Вывод стиха в цвете
            OutputOfVerseInColor(versearr, colorarr);
            
            Console.ReadKey();
        }

        //The method of input of the verse - Метод ввода стиха
        public static string InputOfTheVerse()
        {
            Console.WriteLine("Введите стих");
            string verse = Convert.ToString(Console.ReadLine()) + " \n";
            string count = " ";

            //Entering of the verse is not yet entered by an empty Enter - Ввод стиха пока не будет введен пустой Enter
            while (count != "")
            {
                count = Convert.ToString(Console.ReadLine());
                verse += count + " \n";
            }

            return verse;
        }

        //The method of overriding verse in the array - Метод переопределения стиха в массив
        public static string[] OverridingVerseInTheArray(string verse)
        {
            //Formation of an array of words of divided spaces - Формирование массива из слов разделенными пробелами
            string[] versearr = verse.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return versearr;
        }

        //The method of inning the colors of words of verse - Метод ввода цветов слов стиха
        public static string[] EnteringColorsOfWordsOfVerse(string[] versearr)
        {
            Console.WriteLine("Введите цвет");
            string[] colorarr = new string[versearr.Length-2];

            //Introducting color and correction of his writing - Ввод цвета и коррекция его написания 
            for(int i = 0; i < versearr.Length-2; i++)
            { 
                //string wordofverse = versearr[i].Replace('\n', ' ');
                char[] trimChars = {'\n', '.', ',', ';', ':', '!', ' '};
                string wordOfVerse = versearr[i].Trim(trimChars);
                Console.WriteLine("Введите цвет слова " + wordOfVerse.ToLower());

                colorarr[i] = Convert.ToString(Console.ReadLine());
                colorarr[i].ToLower();
            }

            return colorarr;
        }

        //The method of output of verse in color - Метод вывода стиха в цвете
        public static void OutputOfVerseInColor(string[] versearr, string[] colorarr)
        {
            for (int i = 0; i < versearr.Length-2; i++)
            {
                string color = colorarr[i].Replace('ё', 'e');
                Console.ForegroundColor = (color) switch
                {
                    "темно-синий" => ColorTranslator.FromHtml("#000080"),
                    "синий" => ColorTranslator.FromHtml("#0000FF"),
                    "бирюзовый" => ColorTranslator.FromHtml("#008080"),
                    "аква" => ColorTranslator.FromHtml("#00FFFF"),
                    "зеленый" => ColorTranslator.FromHtml("#008000"),
                    "лаймовый" => ColorTranslator.FromHtml("#00FF00"),
                    "оливковый" => ColorTranslator.FromHtml("#808000"),
                    "желтый" => ColorTranslator.FromHtml("#FFFF00"),
                    "бордовый" => ColorTranslator.FromHtml("#800000"),
                    "красный" => ColorTranslator.FromHtml("#FF0000"),
                    "пурпурный" => ColorTranslator.FromHtml("#800080"),
                    "фуксия" => ColorTranslator.FromHtml("#FF00FF"),
                    "белый" => ColorTranslator.FromHtml("#FFFFFF"),
                    "серебристый" => ColorTranslator.FromHtml("#C0C0C0"),
                    "серый" => ColorTranslator.FromHtml("#808080"),
                    "тускло-серый" => ColorTranslator.FromHtml("#696969"),
                    "темно-серый" => ColorTranslator.FromHtml("#A9A9A9"),
                    "светло-серый" => ColorTranslator.FromHtml("#D3D3D3"),
                    "гейнсбро" => ColorTranslator.FromHtml("#DCDCDC"),
                    "дымчатый" => ColorTranslator.FromHtml("#F5F5F5"),
                    "снежный" => ColorTranslator.FromHtml("#FFFAFA"),
                    "розово-коричневый" => ColorTranslator.FromHtml("#BC8F8F"),
                    "светло-коралловый" => ColorTranslator.FromHtml("#F08080"),
                    "коричневый" => ColorTranslator.FromHtml("#A52A2A"),
                    "кирпичный" => ColorTranslator.FromHtml("#B22222"),
                    "густой красно-коричневый" => ColorTranslator.FromHtml("#800000"),
                    "темно-красный" => ColorTranslator.FromHtml("#8B0000"),
                    "лососевый" => ColorTranslator.FromHtml("#FA8072"),
                    "туманно-розовый" => ColorTranslator.FromHtml("#FFE4E1"),
                    "томатный" => ColorTranslator.FromHtml("#FF6347"),
                    "темно-лососевый" => ColorTranslator.FromHtml("#E9967A"),
                    "оранжево-красный" => ColorTranslator.FromHtml("#FF4500"),
                    "светло-лососевый" => ColorTranslator.FromHtml("#FFA07A"),
                    "охра" => ColorTranslator.FromHtml("#A0522D"),
                    "морской раковины" => ColorTranslator.FromHtml("#FFF5EE"),
                    "кожанного седла" => ColorTranslator.FromHtml("#8B4513"),
                    "шоколадный" => ColorTranslator.FromHtml("#D2691E"),
                    "персиковый" => ColorTranslator.FromHtml("#FFDAB9"),
                    "рыжеватый" => ColorTranslator.FromHtml("#F4A460"),
                    "льняной" => ColorTranslator.FromHtml("#FAF0E6"),
                    "светло-коричневый" => ColorTranslator.FromHtml("#FFE4C4"),
                    "темно-оранжевый" => ColorTranslator.FromHtml("#FF8C00"),
                    "античный белый" => ColorTranslator.FromHtml("#FAEBD7"),
                    "дубильной коры" => ColorTranslator.FromHtml("#D2B48C"),
                    "плотной древесины" => ColorTranslator.FromHtml("#DEB887"),
                    "миндальный" => ColorTranslator.FromHtml("#FFEBCD"),
                    "побега попайи" => ColorTranslator.FromHtml("#FFEFD5"),
                    "старого кружева" => ColorTranslator.FromHtml("#FDF5E6"),
                    "пшеничный" => ColorTranslator.FromHtml("#F5DEB3"),
                    "оранжевый" => ColorTranslator.FromHtml("#FFA500"),
                    "цветочно-белый" => ColorTranslator.FromHtml("#FFA50"),
                    "золотисто-красный" => ColorTranslator.FromHtml("#DAA520"),
                    "темный золотисто-красный" => ColorTranslator.FromHtml("#B8860B"),
                    "молодой кукурузы" => ColorTranslator.FromHtml("#FFF8DC"),
                    "золотистый" => ColorTranslator.FromHtml("#FFD700"),
                    "лимонного шифона" => ColorTranslator.FromHtml("#FFFACD"),
                    "хаки" => ColorTranslator.FromHtml("#F0E68C"),
                    "бледный золотисто-красный" => ColorTranslator.FromHtml("#EEE8AA"),
                    "темный хаки" => ColorTranslator.FromHtml("#BDB76B"),
                    "слоновой кости" => ColorTranslator.FromHtml("#FFFFF0"),
                    "беж" => ColorTranslator.FromHtml("#F5F5DC"),
                    "светло-желтый" => ColorTranslator.FromHtml("#FFFFE0"),
                    "нежно-оливковый" => ColorTranslator.FromHtml("#6B8E23"),
                    "желто-зеленый" => ColorTranslator.FromHtml("#9ACD32"),
                    "темный оливково-зеленый" => ColorTranslator.FromHtml("#556B2F"),
                    "зелено-желтый" => ColorTranslator.FromHtml("#ADFF2F"),
                    "зеленой лужайки" => ColorTranslator.FromHtml("#7CFC00"),
                    "бледно-зеленый" => ColorTranslator.FromHtml("#7FFF00"),
                    "медовой росы" => ColorTranslator.FromHtml("#F0FFF0"),
                    "темный морской волны" => ColorTranslator.FromHtml("#8FBC8F"),
                    "светло-зеленый" => ColorTranslator.FromHtml("#90EE90"),
                    "лесной зелени" => ColorTranslator.FromHtml("#228B22"),
                    "зеленого лайма" => ColorTranslator.FromHtml("#32CD32"),
                    "темно-зеленый" => ColorTranslator.FromHtml("#006400"),
                    "лайма" => ColorTranslator.FromHtml("#00FF00"),
                    "морской волны" => ColorTranslator.FromHtml("#2E8B57"),
                    "умеренный морской волны" => ColorTranslator.FromHtml("#3CB371"),
                    "мятного крема" => ColorTranslator.FromHtml("#F5FFFA"),
                    "весенней зелени" => ColorTranslator.FromHtml("#00FF7F"),
                    "умеренный весенней зелени" => ColorTranslator.FromHtml("#00FA9A"),
                    "умеренный аквамариновый" => ColorTranslator.FromHtml("#66CDAA"),
                    "зелено-голубой" => ColorTranslator.FromHtml("#7FFFD4"),
                    "светлый морской волны" => ColorTranslator.FromHtml("#20B2AA"),
                    "умеренный бирюзовый" => ColorTranslator.FromHtml("#48D1CC"),
                    "лазурный" => ColorTranslator.FromHtml("#F0FFFF"),
                    "бледно-бирюзовый" => ColorTranslator.FromHtml("#AFEEEE"),
                    "темный аспидно-серый" => ColorTranslator.FromHtml("#2F4F4F"),
                    "темно-циановый" => ColorTranslator.FromHtml("#008B8B"),
                    "светло-циановый" => ColorTranslator.FromHtml("#E0FFFF"),
                    "темно-бирюзрвый" => ColorTranslator.FromHtml("#00CED1"),
                    "голубой пороши" => ColorTranslator.FromHtml("#B0E0E6"),
                    "светло-голубой" => ColorTranslator.FromHtml("#ADD8E6"),
                    "насыщенно небесно-голубой" => ColorTranslator.FromHtml("#00BFFF"),
                    "небесно-голубой" => ColorTranslator.FromHtml("#87CEEB"),
                    "светлый небесно-голубой" => ColorTranslator.FromHtml("#87CEFA"),
                    "голубовато-стальной" => ColorTranslator.FromHtml("#4682B4"),
                    "аспидно-серый" => ColorTranslator.FromHtml("#708090"),
                    "светлый аспидно-серый" => ColorTranslator.FromHtml("#778899"),
                    "светлый голубовато-стальной" => ColorTranslator.FromHtml("#BOC4DE"),
                    "васильковый" => ColorTranslator.FromHtml("#6495ED"),
                    "королевский голубой" => ColorTranslator.FromHtml("#4169E0"),
                    "призрачно-булый" => ColorTranslator.FromHtml("#F8F8FF"),
                    "лавандовый" => ColorTranslator.FromHtml("#E6E6FA"),
                    "синей полночи" => ColorTranslator.FromHtml("#191970"),
                    "флотский" => ColorTranslator.FromHtml("#000080"),
                    "голубой" => ColorTranslator.FromHtml("#0000FF"),
                    "темный аспидно-синий" => ColorTranslator.FromHtml("#483D8B"),
                    "умеренный пурпурный" => ColorTranslator.FromHtml("#9370DB"),
                    "сине-фиолетовый" => ColorTranslator.FromHtml("#8A2BE2"),
                    "индиго" => ColorTranslator.FromHtml("#4B0082"),
                    "темно-лиловый" => ColorTranslator.FromHtml("#9932CC"),
                    "темно-фиолетовый" => ColorTranslator.FromHtml("#9400D3"),
                    "умеренный лиловый" => ColorTranslator.FromHtml("#BA55D3"),
                    "чертополоха" => ColorTranslator.FromHtml("#D8BFD8"),
                    "сливовый" => ColorTranslator.FromHtml("#DDA0DD"),
                    "фиолетовый" => ColorTranslator.FromHtml("#EE82EE"),
                    "темеый фуксин" => ColorTranslator.FromHtml("#8B008B"),
                    "фуксин" => ColorTranslator.FromHtml("#FF00FF"),
                    "умеренный лилово-красный" => ColorTranslator.FromHtml("#C71585"),
                    "насыщенный розовый" => ColorTranslator.FromHtml("#FF1493"),
                    "яркий розовый" => ColorTranslator.FromHtml("#FF69B4"),
                    "ловандового румянца" => ColorTranslator.FromHtml("#FFF0F5"),
                    "бледный лилово-красный" => ColorTranslator.FromHtml("#DB7093"),
                    "малиновый" => ColorTranslator.FromHtml("#DC143C"),
                    "розовый" => ColorTranslator.FromHtml("#FFC0CB"),
                    "светло-розовый" => ColorTranslator.FromHtml("#FFB6C1"),
                    _ => ColorTranslator.FromHtml("#FFFFFF"),
                };

                Console.Write(versearr[i] + " ");
                Console.ResetColor();
            }
        }
    }
}