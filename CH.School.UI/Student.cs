namespace CH.School.UI
{
    public class Student
    {
        //Method 1
        //Used for businesss logic or data validation 
        //Private Field
        private int id;

        //Public Property 
        public int ID
        {
            get { return id; }
            set 
            { 
                if (value > 0)
                {
                    id = value;
                }
                
            }
        }

        //Method 2

        //property
        //Make a caluclated Property 
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double GPA { get; set; } 

        //void if there is no returned  type 
        public void Study()
        {
            //Create an instance of the a Course Class ==> Object 
            //Method One
            Course course1;
            course1 = new Course();

            //Method Two 
            Course course2 = new Course();

            // Set the property values 
            //Method 1

            //object.property = value
            course1.Name = "ASP.net";
            course1.ID = 1;

            // Method 2
            course2 = new Course { ID = 2, Name = "c# Intermediate" };

            //Get data from an object 
            string name = course2.Name;
            int ID = course1.ID;





        }

        private bool CompleteHomework()
        {
            return true; 
        }


        


    }
}
