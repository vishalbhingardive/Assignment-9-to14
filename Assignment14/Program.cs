
//14.Demart owner want  to store  Customerinformation. Theywant  give discount to customer based on customer type("dailly_Cust","Weeklly_Cust","Monthly_cust","Other")

//usingfollowing data made a program for Demart.

//Note :Five class should be there in assignment.
//          Used AbstractionApproach while solving program

//    Properties need in classes:

//Customer--      cust_name,cust_phone,cust_address,total_amt,actual_paidAmount,date_of_order
//(actual_paidAmount  means what amount will be paid after the given discount;)
//dailly_cust--discountRate,
//Weeklly_Cust--  discountRate,
//Monthly_cust--  discountRate

//    1.dailly_Cust have 4 % discount on purchase.
//    2. Weeklly_Cust have 3% discount on purchase.
//    3. Monthly_cust have 2% discount on purchase.
//    4. other have not discount.




//===========================Classes================================================== 

//1. Demart Owner
//2. Product
//3. Actual Paid Amount
//4. customer
//5. order


DemartOwner d = new Customer("Vishal", 989999999, "Nagar");
DemartOwner d1 = new Order(DateTime.Now.AddYears(-2));
DemartOwner d2 = new Product("Laptop");
DemartOwner d3 = new ActualPaid(2000,2);
Console.WriteLine("Name  Phone Number Address Product   Discounted Price     Date Time");
Console.WriteLine("==========================================================================");
d.Display();
d2.Display();
d3.Display();
d1.Display();
Console.WriteLine("\n==========================================================================");
public class Product:DemartOwner
{
    public string product;

    public Product(string product)
    {
        this.product = product;
    }
    public override void Display()
    {
        Console.Write("   "+product); 
    }
}

public class ActualPaid:DemartOwner
{

    public int total_amt;
    public int Discount;
    public int actual_paidAmount;

    public ActualPaid(int total, int discount)
    {
        this.total_amt = total;
        this.Discount = discount;   
    }
    
        
    
    public override void Display()
    {
        actual_paidAmount = total_amt - (total_amt * Discount / 100);

        Console.Write($"{actual_paidAmount,10}");
    }
}

public class Customer:DemartOwner
{
    public string cust_name;
    public long cust_phone;
    public string cust_address;

    public Customer(string name, long phone, string address)
    {
        this.cust_name = name;
        this.cust_phone = phone;
        this.cust_address = address;
    }
    public override void Display()
    {
        Console.Write($"{cust_name} {cust_phone}    {cust_address}");
    }

}

public class Order : DemartOwner
{
    public DateTime date_of_order;

    public Order(DateTime order)
    {
        date_of_order = order;
    }
    public override void Display()
    {
       Console.Write($"{date_of_order,30}");
    }
}
public abstract class DemartOwner
{
    public abstract void Display();
    
}


