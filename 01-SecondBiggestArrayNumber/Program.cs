int[] arrayOfNumbers = {2, 50, 3, 6, 10, 40, 55, 2, 51};

int biggestNumber = arrayOfNumbers[0];
int secondBiggestNumber = arrayOfNumbers[0];

foreach(int number in arrayOfNumbers){
    if(number > biggestNumber){
        secondBiggestNumber = biggestNumber;
        biggestNumber = number;
    }
    else if(number > secondBiggestNumber && secondBiggestNumber != biggestNumber){
        secondBiggestNumber = number;
    }
}


Console.WriteLine(secondBiggestNumber);