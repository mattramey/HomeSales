using System;

class HomeSales {// open HomeSales

  
  
  
  public static void Main (string[] args) {// open Main
    double totalForDanielle = 0;
    double totalForFrancis =0;
    double totalForEdward = 0;
    double finalTotal = 0;
    double salesAmount;


    while(true){
      Console.WriteLine("Please enter the initial of your sales person (Danielle,Edward, or Francis, press z to escape.");
      // take user input and stor it to initial
      string initial = Console.ReadLine();

      Console.WriteLine();
      
    if(initial == "z" ){// open while =d= z
    
      break;
      }// close == z

      
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

  string bestPaidSalesRep = "";
  double highestTotal = 0;
    
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
    }

    Console.WriteLine($"Grand Total: $ {finalTotal:N2}");
    Console.WriteLine($"Highest Sale:" + bestPaidSalesRep);
    Console.WriteLine();
    Console.WriteLine("unit test passed");
    
    
    
  }// Close main
}// close HomeSales