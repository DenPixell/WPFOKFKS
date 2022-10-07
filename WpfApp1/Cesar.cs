using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cesar
    {
        int key;
        string input;
        string vibor;
        string languge;
        public Cesar(int key, string input, string vibor, string languge)
        {
            this.key = key;
            this.input = input;
            this.vibor = vibor;
            this.languge = languge;
        }

        public string Shifr_Cesaria()
        {
            int number;
            int disp; 
            string str; 
            int j = 0;

            char[] massage = input.ToCharArray(); 
            if (vibor == "SHIFR")
            {
                if (languge == "RUS")
                {
                    char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

                    
                    for (int i = 0; i < massage.Length; i++)
                    {
                        for (j = 0; j < alfavit.Length; j++)
                        {
                            if (massage[i] == alfavit[j])
                            {
                                break;
                            }
                        }

                        if (j != 33) 
                        {
                            number = j; 
                            disp = number + key; 

                            if (disp > 32)
                            {
                                disp = disp - 33;
                            }

                            massage[i] = alfavit[disp]; 
                        }
                    }

                    str = new string(massage);
                    return str;
                }

                else if (languge == "ENG")
                {
                    char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                    for (int i = 0; i < massage.Length; i++)
                    {
                        for (j = 0; j < alfavit.Length; j++)
                        {
                            if (massage[i] == alfavit[j])
                            {
                                break;
                            }
                        }

                        if (j != 26) 
                        {
                            number = j; 
                            disp = number + key; 

                            if (disp > 25)
                            {
                                disp = disp - 26;
                            }

                            massage[i] = alfavit[disp]; 
                        }
                    }

                    str = new string(massage); 
                    return str;
                }


            }
            else if (vibor == "DESHIFR")
            {
                if (languge == "RUS")
                {
                    char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

                    for (int i = 0; i < massage.Length; i++)
                    {
                        for (j = 0; j < alfavit.Length; j++)
                        {
                            if (massage[i] == alfavit[j])
                            {
                                break;
                            }
                        }

                        if (j != 33)
                        {
                            number = j; 
                            disp = number - key;

                            if (disp < 0)
                            {
                                disp = disp + 33;
                            }

                            massage[i] = alfavit[disp]; 
                        }
                    }

                    str = new string(massage); 
                    return str;
                }

                else if (languge == "ENG")
                {
                    char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


                    for (int i = 0; i < massage.Length; i++)
                    {

                        for (j = 0; j < alfavit.Length; j++)
                        {
                            if (massage[i] == alfavit[j])
                            {
                                break;
                            }
                        }

                        if (j != 26) 
                        {
                            number = j; 
                            disp = number - key;
                            if (disp < 0)
                            {
                                disp = disp + 26;
                            }

                            massage[i] = alfavit[disp]; 
                        }
                    }

                    str = new string(massage); 
                    return str;

                }

            }
            return "qweqweqweqwew";

        }
    }
}
