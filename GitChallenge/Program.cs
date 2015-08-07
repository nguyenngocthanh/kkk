using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        private static IList<KeyValuePair<int, string>> _randomizedNames { get; set; }
        private static IList<KeyValuePair<int, string>> _randomizedNickNames { get; set; }


        private static IList<KeyValuePair<int, string>> DoRandomizeList(IList<string> list)
        {
            var result = new List<KeyValuePair<int, string>>();

            return result;
        }

	private static IList<string> GetNickNames()
	{
   	    var nickNames = new List<string>();
   
            return nickNames;
	}	
    }
}
