using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Vizzener
    {
        string key;
        string input;
        string languge;

        
        public Vizzener(string key, string input, string languge)
        {
            
            this.key = key;
            this.input = input;
            this.languge = languge;
        }
        public string Shifr_Viz()
        {

            int number; 
            int disp; 
            string str; 
            int j, f; 
            int t = 0; 

            char[] input_mass = input.ToCharArray(); 
            char[] key_mass = key.ToCharArray(); 
            if (languge == "RUS")
            {
                char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                // Перебираем каждый символ сообщения
                for (int i = 0; i < input_mass.Length; i++)
                {
                    // Ищем индекс буквы
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (input_mass[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 33) // Если j равно 33, значит символ не из алфавита
                    {
                        number = j; // Индекс буквы

                        // Ключ закончился - начинаем сначала.
                        if (t > key_mass.Length - 1) { t = 0; }

                        // Ищем индекс буквы ключа
                        for (f = 0; f < alfavit.Length; f++)
                        {
                            if (key_mass[t] == alfavit[f])
                            {
                                break;
                            }
                        }

                        t++;

                        if (f != 33) // Если f равно 33, значит символ не из алфавита
                        {
                            disp = number + f;
                        }
                        else
                        {
                            disp = number;
                        }

                        // Проверяем, чтобы не вышли за пределы алфавита
                        if (disp > 32)
                        {
                            disp = disp - 33;
                        }

                        input_mass[i] = alfavit[disp]; // Меняем букву
                    }
                }

                str = new string(input_mass); // Собираем символы обратно в строку.
                return str;
            }
            else
            {
                char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                // Перебираем каждый символ сообщения
                for (int i = 0; i < input_mass.Length; i++)
                {
                    // Ищем индекс буквы
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (input_mass[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 26) // Если j равно 26, значит символ не из алфавита
                    {
                        number = j; // Индекс буквы

                        // Ключ закончился - начинаем сначала.
                        if (t > key_mass.Length - 1) { t = 0; }

                        // Ищем индекс буквы ключа
                        for (f = 0; f < alfavit.Length; f++)
                        {
                            if (key_mass[t] == alfavit[f])
                            {
                                break;
                            }
                        }

                        t++;

                        if (f != 26) // Если f равно 26, значит символ не из алфавита
                        {
                            disp = number + f;
                        }
                        else
                        {
                            disp = number;
                        }

                        // Проверяем, чтобы не вышли за пределы алфавита
                        if (disp > 25)
                        {
                            disp = disp - 26;
                        }

                        input_mass[i] = alfavit[disp]; // Меняем букву
                    }
                }

                str = new string(input_mass); // Собираем символы обратно в строку.
                return str;
            }
            
        }

        public string Deshifr_Viz()
        {
            

            int number; 
            int disp; 
            string str; 
            int j, f; 
            int t = 0; 
            char[] input_mass = input.ToCharArray(); 
            char[] key_mass = key.ToCharArray(); 
            if (languge == "RUS")
            {
                char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                
                for (int i = 0; i < input_mass.Length; i++)
                {
                    
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (input_mass[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 33) 
                    {
                        number = j; 

                        if (t > key_mass.Length - 1) 
                        { 
                            t = 0; 
                        }

                        for (f = 0; f < alfavit.Length; f++)
                        {
                            if (key_mass[t] == alfavit[f])
                            {
                                break;
                            }
                        }

                        t++;

                        if (f != 33) 
                        {
                            disp = number - f;
                        }
                        else
                        {
                            disp = number;
                        }

                        if (disp < 0)
                        {
                            disp = disp + 33;
                        }

                        input_mass[i] = alfavit[disp]; 
                    }
                }

                str = new string(input_mass);
                return str;
            }
            else
            {
                char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                
                for (int i = 0; i < input_mass.Length; i++)
                {                   
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (input_mass[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 26) 
                    {
                        number = j; 

                        if (t > key_mass.Length - 1) 
                        { 
                            t = 0; 
                        }

                        for (f = 0; f < alfavit.Length; f++)
                        {
                            if (key_mass[t] == alfavit[f])
                            {
                                break;
                            }
                        }

                        t++;

                        if (f != 26)
                        {
                            disp = number - f;
                        }
                        else
                        {
                            disp = number;
                        }

                        if (disp < 0)
                        {
                            disp = disp + 26;
                        }

                        input_mass[i] = alfavit[disp]; 
                    }
                }

                str = new string(input_mass); 
                return str;
            }

        }
    }
}
