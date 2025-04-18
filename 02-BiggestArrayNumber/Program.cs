int[] arrayOfNumbers = {3, 50, 43, 3, 1, 0, 50};

int biggestNumber = arrayOfNumbers[0];

foreach(int number in arrayOfNumbers){
    if(number > biggestNumber){
        biggestNumber = number;
    }
}

Console.WriteLine(biggestNumber);