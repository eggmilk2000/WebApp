using System;

namespace WebApp.Models
{
    public class Members
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public string BirthPlace { get; set; }

        
        public Members(){
            
         }
        public Members(string FirstName, string LastName, string Gender, DateTime DateOfBirth, int Phone, string BirthPlace){
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.BirthPlace = BirthPlace;
         }
         
    }
}