using System;

class Program {
  public static void Main (string[] args) {

    //ASK USER FOR A NUMBER AND SAVE AS AN INTEGER
    Console.WriteLine("Enter a number: ");
    int multiple = int.Parse(Console.ReadLine());

    //IF NUBER IS 2,3 OR 5, IT SHOULD BE MARKED AS PRIME
    if (multiple==2) {
    Console.WriteLine("Prime.");
} else if (multiple==3) {
    Console.WriteLine("Prime.");
} else if (multiple==5) {
    Console.WriteLine("Prime.");
    //ANYTHING ELSE, SHOULD FOLLOW THE ELSE STATEMENT
} else {
  //SET A BOOLEAN TO BE TRUE
    bool isPrime = true;
    //IF NUMBER IS DIVISIBLE BY 2,3, OR 5, TELL USER IT IS A MULTIPLE OF THAT NUMBER
    //IF ANY OF THEM WORK, CHANGE THE BOOLEAN VALUE TO FALSE SO IT DOES NOT PRINT LATER
    if (multiple%2==0) {
        Console.WriteLine("x2\n");
        isPrime = false;
    } if (multiple%3==0) {
        Console.WriteLine("x3\n");
        isPrime = false;
    } if (multiple%5==0) {
        Console.WriteLine("x5\n");
        isPrime = false;
        //IF SYSTEM IS HERE, THE BOOLEAN WIL BE TRUE, TELLING THE USER IT IS PRIME.
    } if (isPrime) {
        Console.WriteLine("Prime.");
    }
  }
}
}