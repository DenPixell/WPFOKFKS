using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfApp1
{
    internal class Vernam
    {
        string key;
        string input;
        string languge;
        string vibor;
        public Vernam(string key, string input, string languge, string vibor)
        {
            this.key = key;
            this.input = input;
            this.languge = languge;
            this.vibor = vibor;
        }

        public string RUS_Ver()
        {
            if (languge == "RUS")
            {
                string alfavit = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
                var sh_de = new Shifr_Deshifr(alfavit);
                if (vibor == "SHIFR")
                {
                    return sh_de.Rus(input, key);
                }
                else
                {
                    return sh_de.Rus(input, key);
                }
            }
            else
            {
                return "qwe";
            }
        }
        public string ENG_Ver()
        {
            if (languge == "ENG")
            {
                string alfavit = "abcdefghijklmnopqrstuvwxyz";
                var sh_de = new Shifr_Deshifr(alfavit);
                
                if (vibor == "SHIFR")
                {
                    return sh_de.Eng(input, key, true);
                }
                else
                {
                    return sh_de.Eng(input, key, false);
                }
            }
            else
            {
                return "qwe";
            }
        }

    }

    
}

class Shifr_Deshifr
{
    Dictionary<char, int> alfavit = new Dictionary<char, int>();
    Dictionary<int, char> alfavit_rus = new Dictionary<int, char>();

    public Shifr_Deshifr(IEnumerable<char> Alphabet)
    {
        int i = 0;
        foreach (char c in Alphabet)
        {
            alfavit.Add(c, i);
            alfavit_rus.Add(i++, c);
        }
    }

    
    public string Eng(string Input, string Key, bool Crypt)
    {
        char[] key = Key.ToCharArray();
        char[] text = Input.ToCharArray();
        var sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            int idx;
            if (alfavit.TryGetValue(text[i], out idx))
            {
                int r = alfavit.Count + idx;
                r += (Crypt ? 1 : -1) * alfavit[key[i % key.Length]];
                sb.Append(alfavit_rus[r % alfavit.Count]);
            }
        }

        return sb.ToString();
    }

    
    public string Rus(string Input, string Key)
    {
        char[] key = Key.ToCharArray();
        char[] text = Input.ToCharArray();
        var sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            int ind;
            if (alfavit.TryGetValue(text[i], out ind))
            {
                sb.Append(alfavit_rus[(ind ^ alfavit[key[i % key.Length]]) % alfavit.Count]);
            }
        }

        return sb.ToString();
    }
}
