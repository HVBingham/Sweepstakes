using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class Contestants
    {
        string firstName;
        string lastName;
        string email;
        int registrationNumber;
        public Contestants()
        {
            
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
           
            
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
           
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
         
        }
    
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }
       
      

        



    }
}
