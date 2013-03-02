using System;

namespace _1.SchoolTest
{
    public class Discipline : IOptional
    {
        // FIELDS --------------------------------------------
        private string name;
        private readonly uint numberLecture;
        private readonly uint numberExercise;
        private string freeText;

        // CONSTRUCTORS ---------------------------------------
        public Discipline(string name, uint numberLecture, uint numberExercise)
            : this(name, numberLecture, numberExercise, null)
        {
        }

        public Discipline(string name, uint numberLecture, uint numberExercise, string freeText)
        {
            this.Name = name;
            this.numberLecture = numberLecture;
            this.numberExercise = numberExercise;
            this.freeText = freeText;
        }

        // PROPERTIES -------------------------------------------------
        public string Name
        {
            get { return this.name; }
            set
            {
                // checks if name is only letters
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("The name of discipline can't be empty or less than 4 letters!");
                    }
                }

                if (value != string.Empty && value.Length >= 4)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The name of discipline can't be empty or less than 4 letters!");
                }
            }
        }

        public uint NumberLectures
        {
            get { return this.numberLecture; }
        }

        public uint NumberExercise
        {
            get { return this.numberExercise; }
        }

        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }

    }
}
