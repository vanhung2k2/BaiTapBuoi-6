namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Nguyen Van Hung", "CNTT1", 9);
            Student s2 = new Student(2, "Nguyen Van Nam", "CNTT2", 8);
            Student s3 = new Student(3, "Nguyen Van Thinh", "CNTT3", 99);
            Student s4 = new Student(4, "Nguyen Van Long", "CNTT4", 6);
            Student s5 = new Student(5, "Nguyen Van Manh", "CNTT5", 5);
            Dictionary<int, Student> _dictionary = new Dictionary<int, Student>();
            _dictionary.Add(1, s1);
            _dictionary.Add(2, s2);
            _dictionary.Add(3, s3);
            _dictionary.Add(4, s4);
            _dictionary.Add(5, s5);

            int max = _dictionary.Values.Max(Student => Student.Gpa);
            foreach (var entry in _dictionary)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
            //1 : Sinh vien co diem cao nhat ;
            var topStudent = _dictionary.Values.First(Student => Student.Gpa == max);
            Console.WriteLine($"Thi sinh co diem cao nhat la :    {topStudent}");
            Console.WriteLine();

            //2 : Lay danh sach ten sinh vien co diem lon hon mot gia tri cho trc
            var listSinhVienCoDiemLonHonX = _dictionary.Values.Where(Student => Student.Gpa >= 5).ToList();
            for ( int i = 0; i < listSinhVienCoDiemLonHonX.Count; i++)
            {
                Console.WriteLine($"Ten thi sinh co diem lon hon gia tri cho trc '5' la  : {listSinhVienCoDiemLonHonX[i].Name}");
            }
            Console.WriteLine();

            //3 : Dem so luong sinh vien co diem trung binh tro len 
            Console.WriteLine($"So sinh vien co diem tren trung binh la : {listSinhVienCoDiemLonHonX.Count} " );
        }
    }
}
