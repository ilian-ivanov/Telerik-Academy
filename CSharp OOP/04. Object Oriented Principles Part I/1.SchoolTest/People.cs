using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTest
{
    public class People
    {
        private readonly string name;

        public People(string name)
        {
            // checks if name is only letters
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    throw new ArgumentException("The name can't be empty or less than 2 letters!");
                }
            }

            // checks if name is empty
            if (name != string.Empty && name.Length >= 2)
            {
                this.name = name;
            }
            else
            {
                throw new ArgumentException("The name can't be empty or less than 2 letters!");
            }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
