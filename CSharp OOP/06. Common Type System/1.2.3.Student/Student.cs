using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3.Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        // FIELDS --------------------------------------------------------
        #region
        // makes fields public because the main thing for this exercise is to override some methods
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        #endregion

        // CONSTRUCTORS --------------------------------------------------
        #region
        // makes one big constructor for all this settings :)
        // only First name and SSN are required
        public Student(string firstName, ulong SSN, string middleName = null, string lastName = null, 
            string address = null, string mobile = null, string email = null, byte course = 1, Specialty spec = Specialty.Informatics,
            University university = University.Sofiiski, Faculty faculty = Faculty.FMI)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.Address = address;
            this.MobilePhone = mobile;
            this.Email = email;
            this.Course = course;
            this.Specialty = spec;
            this.University = university;
            this.Faculty = faculty;
        }
        #endregion

        // METHODS ---------------------------------------------------------
        #region
        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if ((object)student == null)
            {
                return false;
            }

            if (Object.Equals(this.FirstName, student.FirstName) && Object.Equals(this.SSN, student.SSN))
            {
                return true; 
            }

            return false;
        }

        public static bool operator ==(Student student1,
                                  Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1,
                           Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        // things which we take for the students to be equals are first name and SSN, so we'll print only them with this method to make check
        public override string ToString()
        {
            return string.Format("Firts name: {0}, SSN: {1}.", this.FirstName, this.SSN);
        }

        // this method we override but it returns object so we call our own method Clone, which will return student
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        // our method Clone that help not to cast
        public Student Clone()
        {
            return new Student(this.FirstName, this.SSN, this.MiddleName, this.LastName, this.Address,
                this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return this.FirstName.CompareTo(other.FirstName);
        }

        #endregion
    }
}
