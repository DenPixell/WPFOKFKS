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



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            string synbols = " !@#$%^&*()_+№;%:?*{}[]''|/,.<>`~ёЁ";

            string shifr = Shifrs.Text;
            string key_str = keys.Text;
            string input = inputs.Text;
            int key;
            
            for(int i=0; i<synbols.Length; i++)
            {
                input=input.Replace(synbols[i].ToString(), "");
            }

            string vibor = "";
            string languge = "";
            if (shif.IsChecked == true)
            {
                vibor = "SHIFR";
            }
            else
            {
                vibor = "DESHIFR";
            }

            if (ENG.IsChecked == true)
            {
                languge = "ENG";
            }
            else
            {
                languge = "RUS";
            }

            if (shifr == "Шифр Цезаря")
            {
                try
                {
                    key = Convert.ToInt32(key_str);
                    Cesar cesar = new Cesar(key, input, vibor, languge);
                    string s = cesar.Shifr_Cesaria();
                    outputs.Text = s;
                }
                catch
                {
                    keys.Text = "Ключ введен неверно";
                }
                
            }

            else if (shifr == "Рельсовый шифр")
            {
                if (vibor == "SHIFR")
                {
                    try
                    {
                        key = Convert.ToInt32(key_str);
                        Rails rails = new Rails(key, input);
                        outputs.Text = rails.Shifr();
                    }
                    catch
                    {
                        keys.Text = "Ключ должен содержать число";
                    }
                    
                }
                if (vibor == "DESHIFR")
                {
                    try
                    {
                        key = Convert.ToInt32(key_str);
                        if (key < input.Length)
                        {
                            Rails rails = new Rails(key, input);
                            outputs.Text = rails.Deshifr();
                        }
                        else
                        {
                            keys.Text = "Ключ больше или равен длинне вводимого текста";
                        }
                    }
                    catch
                    {
                        keys.Text = "Ключ должен содержать число";
                    }
                    
                }
            }
            else if (shifr == "Шифр Виженера")
            {
                if (vibor == "SHIFR")
                {
                    try
                    {
                        Vizzener viz = new Vizzener(key_str, input, languge);
                        string s = viz.Shifr_Viz();
                        outputs.Text = s;
                    }
                    catch
                    {
                        keys.Text = "Ключ не должен содержать чисел";
                    }
                    
                }
                if (vibor == "DESHIFR")
                {
                    try
                    {   
                        Vizzener viz = new Vizzener(key_str, input, languge);
                        string s = viz.Deshifr_Viz();
                        outputs.Text = s;
                    }
                    catch
                    {
                        keys.Text = "Ключ не должен содержать чисел";
                    }

                }
            }
            else if (shifr == "Шифр Вернама")
            {
                if (languge == "RUS")
                {
                    try
                    {
                        Vernam ver = new Vernam(key_str, input, languge, vibor);
                        string s = ver.RUS_Ver();
                        outputs.Text = s;
                    }
                    catch
                    {
                        keys.Text = "Ключ не должен содержать чисел";
                    }
                    
                }
                if (languge == "ENG")
                {
                    try
                    {
                        Vernam ver = new Vernam(key_str, input, languge, vibor);
                    string s = ver.ENG_Ver();
                    outputs.Text = s;
                    }
                    catch
                    {
                        keys.Text = "Ключ не должен содержать чисел";
                    }
                    
                }
            }
            else
            {
                outputs.Text = "qeqweqe";
            }

        }

        
        }
        //outputs.Text = shifr + key + input + vibor;

    }



    

