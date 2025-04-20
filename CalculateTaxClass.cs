/*
Write a program to calculate tax if Salary and Tax Brackets are given as list in the form [ [10000, .3],[20000, .2], [30000, .1], [None, .1]]. You don’t know in the beginning how many tax brackets are there. You have to test for all of them
*/
// TC => O(n)
// SC => O(1)
class HelloWorld {
    public static double CalculateTax(List<List<double>> taxSlabs, double salary){
        int i = 0;
        double left = salary, tax = 0.0, limit = 0.0;
        
        while(left > 0){
            List<double> li = taxSlabs[i];
            double percent = li[1];
            if(li[0] == 0.0){
                tax += left * percent;
                return tax;
            }
            double taxableIncome = Math.Min(li[0] - limit, left);
            tax += taxableIncome * percent;
            i++;
            limit = li[0];
            left -= taxableIncome;
        }
        
        return tax;
    }
    static void Main() {
        List<List<double>> taxSlabs = new List<List<double>>();
        taxSlabs.Add(new List<double>(){10000.0, 0.3});
        taxSlabs.Add(new List<double>(){20000.0, 0.2});
        taxSlabs.Add(new List<double>(){30000.0, 0.1});
        taxSlabs.Add(new List<double>(){0.0, 0.1});
        
        Console.WriteLine(CalculateTax(taxSlabs, 15000.0));
        Console.WriteLine(CalculateTax(taxSlabs, 45000.0));
    }
}