namespace assignment_abstraction
{
    public abstract class Admission
    {
        public abstract int JambRegNo { get; set; }
        public abstract string Name(string studentNam);
        public Admission()
        {
                
        }
    }
    public class Acceptance : Admission
    {
        public override int JambRegNo { get; set; }
        public override string Name (string studentName)
        {
            return studentName; 
        }
    }
    internal class Student : IAdmissionRules
    {
        public bool FirstChoice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool WaecResult(bool fiveCredits)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("You have been admitted");
        }
    }

    internal interface IAdmissionRules
    {
        public bool FirstChoice { get; set; }
        public bool WaecResult(bool fiveCredits);
    }
}