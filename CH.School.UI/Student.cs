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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double GPA { get; set; } 

        //void if there is no returned  type 
        public void Study()
        {

        }

        private bool CompleteHomework()
        {
            return true; 
        }


        


    }
}
