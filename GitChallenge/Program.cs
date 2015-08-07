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

            // --- Ví dụ mẫu : memebers.Add("Hoàng Võ Nhật Khoa");
	    members.Add("Nguyen Van Tuan");
            
            return members;
        }
    }
}
