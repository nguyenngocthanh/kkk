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

        // --- Function first commit by team 1
        private static IList<String> GetNames()
        {
            var members = new List<string>();
			members.Add("Pham Phuoc Nguyen");
			members.Add("Lieu Chi Quan");
		    members.Add("Le Minh Y");
		    members.Add("Huynh Minh Bao");
            members.Add("Le Quang Tran");
	        members.Add("Nguyen Van Tuan");

            return members;
        }
    }
}