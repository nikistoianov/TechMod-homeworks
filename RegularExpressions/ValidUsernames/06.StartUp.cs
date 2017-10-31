using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = @"ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref";
            List<User> users = new List<User>();
            int maxSum = 0, maxIndex = 0;
            foreach (var match in Regex.Split(input, @"[ \/\\(\)]+"))
            {
                var user = UserFromString(match);
                
                if (user.IsValid)
                {
                    if (users.Count > 0)
                    {
                        user.sum = user.Name.Length + users.Last().Name.Length;
                        if (user.sum > maxSum)
                        {
                            maxSum = Math.Max(maxSum, user.sum);
                            maxIndex = users.Count;
                        }
                    }
                    users.Add(user);
                }
                
            }
            Console.WriteLine(users[maxIndex - 1].Name);
            Console.WriteLine(users[maxIndex].Name);
            //Console.WriteLine(maxSum);
            //Console.WriteLine(maxIndex);
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Name} -> {user.IsValid} -> {user.sum}");
            //}
        }

        private static User UserFromString(string text)
        {
            return new User { Name = text, IsValid = ValidateUser(text)};
        }

        private static bool ValidateUser(string user)
        {
            return Regex.IsMatch(user, @"^[A-Za-z]\w{2,24}$");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public bool IsValid { get; set; }
        public int sum { get; set; }
    }
}
