package testProgram;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		String name , dob, age, nationality, nic, course; 
		
		Scanner scnr = new Scanner(System.in);
		
		System.out.println("Enter Student Name : ");
		name = scnr.nextLine();
		System.out.println("Enter Student DOB : ");
		dob = scnr.nextLine();
		System.out.println("Enter Student AGE : ");
		age = scnr.nextLine();
		System.out.println("Enter Student Nationality : ");
		nationality = scnr.nextLine();
		System.out.println("Enter Student NIC : ");
		nic = scnr.nextLine();
		System.out.println("Enter Student Enrolled Course : ");
		course = scnr.nextLine();

		System.out.println("");
		System.out.println("=============================");
		System.out.println("");
		System.out.println("Name Of The Student Is " + name);
		System.out.println("DOB Of Student Is " + dob);
		System.out.println("Age Of Student Is " + age);
		System.out.println("Nationality Of Student Is " + nationality );
		System.out.println("NIC Of Student Is " + nic);
		System.out.println("Course Student Enrolled Is " + course);
	}
}
