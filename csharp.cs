using System; 

public class Student
{
	public int roll;
	public String sname;

	public void takeData()
	{
		Console.Write("Enter Student name:");
		sname = Console.ReadLine();
		Console.Write("Enter Roll number:");
		roll = Convert.ToInt32(Console.ReadLine());
		
	}

	public void showData()
	{
		Console.WriteLine("Student Details => ");
		Console.WriteLine("Student name :" + sname);
		Console.WriteLine("Roll number :" + roll);
		
	}

	public static void Main(string[] args)
	{
		Student one = new Student();
		one.takeData();
		one.showData();
	}
}