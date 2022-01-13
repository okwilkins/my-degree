namespace ConsoleProgram {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("RUNNING SINGLE RESPONSIBILITY PRINCIPLE: BAD");
            Console.WriteLine(new string('=', 30));
            SingleResponsibilityBefore.Program.Run();
            Console.WriteLine();

            Console.WriteLine("RUNNING SINGLE RESPONSIBILITY PRINCIPLE: GOOD");
            Console.WriteLine(new string('=', 30));
            SingleResponsibilityAfter.Program.Run();
            Console.WriteLine();


            Console.WriteLine("RUNNING OPEN CLOSED PRINCIPLE: BAD");
            Console.WriteLine(new string('=', 30));
            OpenClosedBefore.Program.Run();
            Console.WriteLine();
            
            Console.WriteLine("RUNNING OPEN CLOSED PRINCIPLE: GOOD");
            Console.WriteLine(new string('=', 30));
            OpenClosedAfter.Program.Run();
            Console.WriteLine();


            Console.WriteLine("RUNNING LISKOV SUBSTITUTION PRINCIPLE: BAD");
            Console.WriteLine(new string('=', 30));
            LiskovSubstitutionBefore.Program.Run();
            Console.WriteLine();

            Console.WriteLine("RUNNING LISKOV SUBSTITUTION PRINCIPLE: GOOD");
            Console.WriteLine(new string('=', 30));
            LiskovSubstitutionAfter.Program.Run();
            Console.WriteLine();

            Console.WriteLine("RUNNING INTERFACE SEGREGATION PRINCIPLE: GOOD");
            Console.WriteLine(new string('=', 30));
            InterfaceSegregationBefore.Program.Run();
            Console.WriteLine();

            Console.WriteLine("RUNNING INTERFACE SEGREGATION PRINCIPLE: BAD");
            Console.WriteLine(new string('=', 30));
            InterfaceSegregationAfter.Program.Run();
            Console.WriteLine();

            Console.WriteLine("RUNNING DEPENDENCY INJECTION PRINCIPLE: BAD");
            Console.WriteLine(new string('=', 30));
            DependencyInversionBefore.Program.Run();
            Console.WriteLine();

            Console.WriteLine("RUNNING DEPENDENCY INJECTION PRINCIPLE: GOOD");
            Console.WriteLine(new string('=', 30));
            DependencyInversionAfter.Program.Run();
            Console.WriteLine();

        }
    }
}