using Azure.Identity;

namespace EmployeeManagmentCore.Models
{
    public class NewEmployeeData
    {
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string UserType { get; set;}
        public string Pincode { get; set;}
        public string UserName { get; set;}

    }
}
