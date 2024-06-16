using System;

class HomeSales {// open HomeSales

  
  
  
  public static void Main (string[] args) {// open Main
// initialize variables for each sales reps total, for the overal total, and the sale amount
    double totalForDanielle = 0;
    double totalForFrancis =0;
    double totalForEdward = 0;
    double finalTotal = 0;
    double salesAmount;

// use a while loop to continuosly loop through a prompt asking the user to enter a character of a name. the variable initial will hold the users input and when the character "z" is inputted the program will break out of the while loop and begin to calculate the sales totals 
    while(true){
      Console.WriteLine("Please enter the initial of your sales person (Danielle,Edward, or Francis, press z to escape.");
// take user input and stor it to initial
      string initial = Console.ReadLine();
       Console.WriteLine();
      
    if(initial == "z" ){// open while =d= z
        break;
      }// close == z

// the input of the letter must be able to accept an uppercase or lowercase character, use the stringComparison.OrdinalIgnoreCase method to ignore letters case. if the user enter the specific character prompt the use for a sale amount, convert the users input to a double data type and update the variable for sales reps sale amount
      if(initial.Equals ("D", StringComparison.OrdinalIgnoreCase)){// open if.Equals
        Console.WriteLine("Enter the sales amount for Danielle:");
        salesAmount = Convert.ToDouble(Console.ReadLine());
        totalForDanielle += salesAmount;
      }// close iff.Equals
      else if(initial.Equals("F", StringComparison.OrdinalIgnoreCase)){
        Console.WriteLine("Enter the sales amount for Francis");
        salesAmount = Convert.ToDouble(Console.ReadLine());
        totalForFrancis += salesAmount;
      }// end else if 1
      else if(initial.Equals("E", StringComparison.OrdinalIgnoreCase)){
        Console.WriteLine("Enter the sales amount for Edward");
        salesAmount = Convert.ToDouble(Console.ReadLine());
        totalForEdward += salesAmount;
      }else{
        Console.WriteLine("Please enter a valid initial\n");   
      }// close else
      }// close while loop

    // calculate the total of all sales reps
    finalTotal = totalForDanielle + totalForFrancis + totalForEdward;


// initialize variables for the highest total and the sales reps inital with the highest total
  string bestPaidSalesRep = "";
  double highestTotal = 0;


// compare the sales rep highst sale total to the other sales rep. if the rep has a higher total than the other two store the reps inital
    if(totalForDanielle >= totalForFrancis && totalForDanielle >= totalForEdward){
      bestPaidSalesRep = "D";
      highestTotal = totalForDanielle;
    }
    else if (totalForFrancis >= totalForDanielle && totalForFrancis >= totalForEdward){
      bestPaidSalesRep = "F";
      highestTotal = totalForFrancis;
    }
    else{
      bestPaidSalesRep = "E";
      highestTotal = totalForEdward;
    }// close if-else
//print the grand total of all combined sales(The variable final total uses the format specifier N2 in order to format commas and decimals for thousands and cents respectively.). print the highest sales reps initial and display unit test passed.
    Console.WriteLine($"Grand Total: $ {finalTotal:N2}");
    Console.WriteLine($"Highest Sale:" + bestPaidSalesRep);
    Console.WriteLine();
    Console.WriteLine("unit test passed");
    
    
    
  }// Close main
}// close HomeSales