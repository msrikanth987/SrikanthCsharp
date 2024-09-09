using System;

namespace MyTest
{
    class testcar:IMydetails, IContactDetails
    {
    // here i am inslalling the properties
        public string Name // property
        { get; set; }
           
        public string Model { get; set; }
        public testcar()
        {
           
        }
        
        public void Myfullname()
        {
            Console.WriteLine("Srikanth MArtha");
            //get name from db
            //get name afrom api call
            //firstname + last name

        }
        public void GetMyAddress()
        {
            Console.WriteLine("Srikanth MArtha address");
        }



    }

    interface IMydetails
    {
        void Myfullname();
    }
    interface IContactDetails
    {
        void GetMyAddress();
    }
}
