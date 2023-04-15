namespace Shopping{
    class Customer {
      int id{get;set;}
      string name{get;set;}
      string email {get;set;}
      string address{get;set;}
      public void ViewItems(Items items){
        foreach (Items item in items)
           Console.WriteLine(items);

          
      }
      public void AddToCart(){}
      public void BuyItems(){}
      public void MakePayment(){}






    }
    }
