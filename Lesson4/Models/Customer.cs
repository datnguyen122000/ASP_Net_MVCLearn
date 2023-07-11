namespace Lesson4.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public Customer()
        {
            
        }
        public Customer(int id,string name, string phoneNumber,string address,string email,string sex)
        {
            Id = id;
            Name = name;            
            PhoneNumber = phoneNumber;  
            Address = address;  
            Email = email;  
            Sex = sex;  
        }
    }
}
