using System;

public abstract class Loan
{
    public virtual bool IsEligible(bool isCRBListed, bool isActiveLoan, bool isBelowLoanLimit)
    {
        if (isCRBListed == false && isActiveLoan == false && isBelowLoanLimit == true)
	    {
            return true;
	    }
        else if (isCRBListed == true && isActiveLoan == false && isBelowLoanLimit == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class CarLoan : Loan { }

public class MortgageLoan : Loan
{
    public override bool IsEligible(bool isCRBListed, bool isActiveLoan, bool isBelowLoanLimit)
    {
        if(isCRBListed == true || isActiveLoan == true || isBelowLoanLimit == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CarLoan carLoan = new CarLoan();
        bool isEligibleCarLoan = carLoan.IsEligible(false, false, true);
        Console.WriteLine("Car Loan Application Status = {0}", isEligibleCarLoan);

        MortgageLoan mortgageLoan = new MortgageLoan();
        bool isEligibleMortgageLoan = mortgageLoan.IsEligible(false, false, true);
        Console.WriteLine("Mortgage Loan Application Status = {0}", isEligibleMortgageLoan);
    }
}

