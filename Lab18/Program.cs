using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Проверка расстановки скобок*/
            string text = "Тескт (кото[рый]набрал {от}балды)в 03:57[ночи] субботы";
            List<char> listText = new List<char>();
            listText.AddRange(text.ToArray());
            Stack<string> brackets = new Stack<string>();
            for (int i = 0; i < listText.Count; i++)
            {
                if (listText[i] == Convert.ToChar("{"))
                {
                    brackets.Push("}");
                }
                else
                {
                    if (listText[i] == Convert.ToChar("["))
                    {
                        brackets.Push("]");
                    }
                    else
                    {
                        if (listText[i] == Convert.ToChar("("))
                        {
                            brackets.Push(")");
                        }
                        else
                        {
                            if (listText[i] == Convert.ToChar("}"))
                            {
                                if (brackets.Count > 0 && listText[i] == Convert.ToChar(brackets.Peek()))
                                {
                                    brackets.Pop();
                                }
                                else
                                {
                                    brackets.Push("}");
                                    break;
                                }
                            }
                            else
                            {
                                if (listText[i] == Convert.ToChar("]"))
                                {
                                    if (brackets.Count > 0 && listText[i] == Convert.ToChar(brackets.Peek()))
                                    {
                                        brackets.Pop();
                                    }
                                    else
                                    {
                                        brackets.Push("]");
                                        break;
                                    }
                                }
                                else
                                {
                                    if (listText[i] == Convert.ToChar(")"))
                                    {
                                        if (brackets.Count > 0 && listText[i] == Convert.ToChar(brackets.Peek()))
                                        {
                                            brackets.Pop();
                                        }
                                        else
                                        {
                                            brackets.Push(")");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (brackets.Count == 0)
            {
                Console.WriteLine("В тексте корректно раставлены скобки");
            }
            else
            {
                Console.WriteLine("В тексте некорректно раставлены скобки");
            }
            Console.ReadKey();
        }
    }
}
