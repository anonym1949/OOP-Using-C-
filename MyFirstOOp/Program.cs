class MyFirstOOP
{

    public class ClsPerson
    {
        private int _Id;
        private string _Name;


       public ClsPerson(int id, string name)
        {
            _Id = id;
            _Name = name;
        }


        public void SetName(string Name)
        {
            _Name = Name;
        }
        public string GetName()
        {
            return _Name;
        }

        public int GetId()
        {
            return _Id; 
        }
    }

   
        internal class Program
        {
         static int Main()
            {
                ClsPerson Person1 = new ClsPerson(10,"Mustapha");
                Person1.SetName("Mustapha Bottte");
                Console.WriteLine(Person1.GetName() + Person1.GetId());
            return 0;
            }
        }
        
 }