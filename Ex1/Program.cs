using System.Threading.Tasks;
using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 1");
            Management m = new Management();
            m.addStudent(new Student("520H0619", "Kuo Nhan Dung", 8.1));
            m.addStudent(new Student("520H0625", "Đỗ Thanh Tùng", 8.6));
            m.addStudent(new Student("520H0854", "Lương Gia Vinh", 7.4));
            m.addStudent(new Student("520H0556", "Nguyễn Kháng", 5.5));
            

            m.removeStudent("520H0854");
            
            Console.WriteLine(m.searchStudent("520H0619").toString());
            
        }
    }

    class Management
    {
        private List<Student> studentList;

        public Management()
        {
            studentList = new List<Student>();
        }

        public void showList()
        {
            foreach (Student s in studentList)
            {
                Console.WriteLine(s.toString());
            }
        }

        public bool isEmpty()
        {
            return studentList.Count == 0;
        }

        public int numOfStudents()
        {
            return studentList.Count;
        }

        public void addStudent(Student s)
        {
            studentList.Add(s);
        }

        public void removeStudent(string sid)
        {
            if (isEmpty())
            {
                return;
            }

            foreach (Student s in studentList)
            {
                if (s.getSid() == sid)
                {
                    studentList.Remove(s);
                    Console.WriteLine("Student {0} is removed", sid);
                    return;
                }
            }

            Console.WriteLine("This student doesn't exist");
            return;
        }

        public void updateStudent(string sid, string name, double gpa)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].getSid() == sid)
                {
                    studentList[i].setName(name);
                    studentList[i].setGPA(gpa);
                    Console.WriteLine("Student {0} is updated", sid);
                    return;
                }
            }

            Console.WriteLine("This student doesn't exist");
            return;
        }

        public Student searchStudent(string sid)
        {
            foreach (Student s in studentList)
            {
                if (s.getSid() == sid)
                {
                    return s;
                }
            }

            return null;
        }
    }

    class Student
    {
        private string sid;
        private string name;
        private double gpa;

        public Student() { }

        public Student(string sid, string name, double gpa)
        {
            this.sid = sid;
            this.name = name;
            this.gpa = gpa;
        }

        public string getSid()
        {
            return sid;
        }

        public string getName()
        {
            return name;
        }

        public double getGPA()
        {
            return gpa;
        }

        public void setSid(string sid)
        {
            this.sid = sid;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setGPA(double gpa)
        {
            this.gpa = gpa;
        } 

        public string toString()
        {
            return sid + " " + name + " - " + gpa;
        }
     }
}