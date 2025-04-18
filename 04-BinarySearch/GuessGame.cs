class GuessGame{
    
    public static void GuessTheNumber(){
        int[] arrayOfNumbers = {1, 5, 14, 23, 34, 56, 76, 80, 97};

        Console.WriteLine("Guess the number:");
        Console.WriteLine("Please provide a number from 1 to 100!");
        Console.WriteLine("Type 'exit' to quit.");


        while (true)
        {
            Console.Write("Your guess: ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye! 👋");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                int index = BinarySearch(arrayOfNumbers, number);

                if (index >= 0 && index < arrayOfNumbers.Length)
                {
                    Console.WriteLine($"Number found at index {index}: {arrayOfNumbers[index]}");
                    break; // exit loop after correct guess
                }
                else
                {
                    Console.WriteLine("Number not found. Try again!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number or type 'exit' to quit.");
            }
        }
    }


    public static int BinarySearch(int[] args, int item){
        int low = 0;
        int high = args.Length - 1;

        while(low <= high){ // until you narrow it down to one element
            int mid = (low + high) / 2; // middle element
            int guess = args[mid];

            if(guess == item){
                return mid;  // Found it!
            }
            else if(guess > item){
                high = mid - 1; // Search left half
            }
            else{
                low = mid + 1; // Search right half
            }
        }

        return -1; // Not found
    }
}