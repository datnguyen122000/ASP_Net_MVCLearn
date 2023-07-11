namespace Lesson4.Models
{
    public static class ListCustomer
    {
        public static List<Customer> customers = new List<Customer>()
        {
               new Customer(1,"Nguyen Quoc Dat","0948854268","Datnguyen122000@gmail.com","Nam Dinh","Male"),
               new Customer(2,"Nguyen Quoc Vuong","0915361593","Vuongnguyen23012003@gmail.com","Nam Dinh", "Male"),
               new Customer(3,"Tran Thi Hue","0123456789","Hueabc@gmail.com","Ha Nam", "Female")
        };
    }
}
