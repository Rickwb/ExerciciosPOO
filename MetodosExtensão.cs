using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public static class MetodosExtensão
    {
        public static int MaiorNumero(this int[] nums)
        {
            return nums.Max();
        }
        public static bool TrySubtring(this string s, int StartIndex, out string substring)
        {
            try
            {
                if (StartIndex > s.Length || StartIndex * -1 < s.Length * -1)
                {
                    throw new IndexOutOfRangeException();
                }
                if (String.IsNullOrEmpty(s))
                {
                    throw new ArgumentNullException();
                }
                substring = s.Substring(StartIndex);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                substring = null;
                return false;
            }
            catch (ArgumentNullException)
            {
                substring = null;
                return false;
            }
        }

        public static bool TrySubtring(this string s, int StartIndex, int EndIndex, out string substring)
        {
            try
            {
                if (StartIndex > s.Length || StartIndex * -1 < s.Length * -1)
                {
                    throw new IndexOutOfRangeException();
                }
                if (String.IsNullOrEmpty(s))
                {
                    throw new ArgumentNullException();
                }

                substring = s.Substring(StartIndex, EndIndex);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                substring = null;
                return false;
                throw;
            }
            catch (ArgumentNullException)
            {
                substring = null;
                return false;
            }
        }
        public static bool SubstringEverting(this string s, int StartIndex, int EndIndex, out string substring)
        {
            try
            {
                if (StartIndex > s.Length || StartIndex * -1 < s.Length * -1)
                {
                    StartIndex -= s.Length;
                    if (StartIndex > s.Length)
                    {
                        var rdn = new Random();
                        substring = " ";
                        return false;
                    }
                    else
                    {
                        substring = s.Substring(StartIndex, EndIndex);
                    }
                }
                if (String.IsNullOrEmpty(s))
                {
                    throw new ArgumentNullException();
                }

                substring = s.Substring(StartIndex, EndIndex);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                substring = null;
                return false;
                throw;
            }
            catch (ArgumentNullException)
            {
                substring = null;
                return false;
            }
        }

        public static int[] OrdenarInteiros(this int[] arr)
        {
            return arr.OrderBy(x => x).ToArray();
        }

        public static string RemoverAcentos(this string s)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            for (int i = 0; i < comAcentos.Length; i++)
            {
                s = s.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return s;
        }

        public static char RetornarChar(this string s, int index)
        {
            try
            {
                if (s.Length < index)
                    throw new ArgumentOutOfRangeException("index");
                else
                    return s[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                return ' ';
            }
        }
        public static string ReverterFrase(this string s)
        {
            return new string(s.Reverse().ToArray());
        }

        public static string[] ToArrayString(this int[] listaNum)
        {
            List<string> s = new List<string>();
            foreach (var item in listaNum)
            {
                s.Add(item.ToString());
            }
            return s.ToArray();
        }


    }
}

