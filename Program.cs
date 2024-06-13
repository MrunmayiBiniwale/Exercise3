namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            //Get user input and validate if it is between the range
            while (true) {
                Console.WriteLine("Please enter an integer between 1 and 1000");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (!(0 < userInput && userInput < 1000))
                {
                    Console.WriteLine("The limit is 1-1000.");
                }
                else
                {
                    break;
                }
            }
            
            //Calculate the half length for adding same positive and negative numbers
            List<int> list = new List<int>();
            int halfLength = (userInput / 2);
            int listSum = 0;
            string resultingList = "";

            //add zero to the list if the userInput is even number
            if ((userInput % 2) != 0)
                list.Add(0);

            //Add the same positive and negative numbers in the list 
            for (int i = 1; i <= halfLength; i++)
            {
                list.Add(i * -1);
                list.Add(i);
            }

            //get the sum and sort the list
            listSum = list.Sum();
            list.Sort();

            //Display the list
            if (listSum == 0) {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == list.Count - 1)
                        resultingList += list[i];
                    else
                        resultingList += list[i] + ",";
                }
                Console.WriteLine("Output : [" + resultingList + "]");
            }           
        }
    }
}
