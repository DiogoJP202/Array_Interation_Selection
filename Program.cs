class Program
{
    public static void Main()
    {
        Student[] students = [new("Sophia"), new("Andrew"), new("Emma"), new("Logan")]; 
        
        Console.WriteLine("Student\t\tGrade");
        foreach(Student student in students)
        {
            Console.WriteLine($"{student.Name}:\t\t{Math.Round(student.AVG, 1)}\t{student.VeficarNota()}");
        }
        
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}

class Student
{

    private readonly Random _rdn = new();

    public Student(string name, int[]? grades = null)
    {
        grades ??= [_rdn.Next(0,101), _rdn.Next(0, 101), _rdn.Next(0, 101), _rdn.Next(0, 101), _rdn.Next(0, 101)];
        // ??= is a compound assignment operator.
        // It checks if the left-hand side (LHS) operand is null. If it is null, it assigns the right-hand side (RHS) value to the LHS. If it is not null, it does nothing (keeps the original value).

        Name = name;
        Grades = grades;
    }
    
    public string Name { get; set; }
    public int[] Grades { get; set; }
    public double AVG {
        get { 
            double totalSum = 0;

            foreach(int grade in Grades)
                totalSum += grade;

            return (double) totalSum / Grades.Length; 
        }
    }

    public string VeficarNota(){
        if (AVG <= 59) return "F";
        if (AVG <= 62) return "D-";
        if (AVG <= 66) return "D";
        if (AVG <= 69) return "D+";
        if (AVG <= 72) return "C-";
        if (AVG <= 76) return "C";
        if (AVG <= 79) return "C+";
        if (AVG <= 82) return "B-";
        if (AVG <= 86) return "B";
        if (AVG <= 89) return "B+";
        if (AVG <= 92) return "A-";
        if (AVG <= 96) return "A";
        return "A+";
    }
}