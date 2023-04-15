
namespace Shopping
{
 class Admin
{
   public string name{get; set;}
   public int id {get;set;} 
   public string email{get;set;}
    public int passward {get; set;} 
    public int passward(){return passward;}
    public void UpdateCatalog(){}
    
    public void AddItems(Items item){
        Items item = Console.ReadLine();
    List<Items> item = new List <Items>();
    item.Add(input);
    Items item = Console.ReadLine();
    userList.Add(inputNewItem);
    foreach(var item in userList){
      Console.WriteLine(user);
    }
    }
        public Admin ( string name,int id ,string email, int passward){
            this.name = name;
            this.id= id;
            this.email = email;
            this.passward = passward;
        }
       
    
    protected void RemoveItems()
    {
    Console.WriteLine("Do you want to remove item?");
       string check = Console.ReadLine();
       if ( check=="yes"||check=="Yes")
       {
        Items item  = null;
       }
    }
       
    

}
 public static void Main(string [] args)
 {

   // our Admins in the system 
    List<Admin> Admin = new List <Admin>();
    Admin.Add(new Admin("maha",1,"mo452@mail.com",89756321));
    Admin.Add(new Admin("Esaam",2,"mo452@mail.com",98763215));
    Admin.Add(new Admin("Joe",3,"joe4520@mail.com",8569745));
    Admin.Add(new Admin("Peter",4,"peter666@mail.com",123456789));
    Admin.Add(new Admin("Mohamed",5,"mo425806@mail.com",01020801921));

#region  to check the passowrd and user name of our admins
    System.Console.WriteLine("please enter your mail");
    string name1 ="";
   Admin admin ;
    while (true)
    {
       try
       {
         name1 = Console.ReadLine();
         string user = Admin.firstOrDefult(a=> a.name ==name1);
         if(name1 != null){
            break;
         }
         else
         {
            System.Console.WriteLine("your name not found, please try again");
         }
         

       }
       catch 
       {
        System.Console.WriteLine("your name not found");
       
       } 
    }

    System.Console.WriteLine("please enter your pin :");
     int adminpass = 0;
     while (true){
        adminpass =int.Parse(Console.ReadLine());
        if (admin.passward == adminpass){
         break ;
        }
        else{System.Console.WriteLine("Incorrect passwprd , please try again");}
     
     }

     #endregion
      

      //our customers 

       List<Customer> Customer = new List <Customer>();
   Customer.Add(new Customer("Sami",20,"ss5689@mail.com",111111));
   Customer.Add(new Customer("Ahmed",40,"ahmed122@mail.com",111112));
   Customer.Add(new Customer("Ali",60,"Ali4520@mail.com",5099853));
   Customer.Add(new Customer("Hossam",80,"Hossam66@mail.com",56289));
   Customer.Add(new Customer("Mohamed",100,"mo45006@mail.com",895622));
      
 }


}
   