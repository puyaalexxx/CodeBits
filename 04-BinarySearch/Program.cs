static int BinarySearch(int[] args, int item){
    int low = 0;
    int high = args.Length -1; // low and high keep track of which part of the array you'll search in

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

int[] arrayOfValues = [1, 5, 12, 25, 34, 50, 66];

Console.WriteLine(BinarySearch(arrayOfValues, 25));
Console.WriteLine(BinarySearch(arrayOfValues, 6));

GuessGame.GuessTheNumber();
