using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

class assignment
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------First Problem---------- ");

        //დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
        // a.კენტი რიცხვების ჯამი
        // b.ლუწი რიცხვების ნამრავლი
        // c.დაითვლის მასივში თითოეული ელემენტის რაოდენობას


        Console.WriteLine("Input n elements ");
        int odd, size, sum, multiply, even;
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter {0} elements in array:", size);
        int[] arr1 = new int[size];
        for (int n = 0; n < size; n++)
        {
            Console.Write("Number({0}) :", n + 1);
            arr1[n] = Convert.ToInt32(Console.ReadLine());
        }
        sum = 0;
        multiply = 1;
        odd = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr1[i] % 2 == 1)
            {
                odd++;
                sum = sum + arr1[i];
            }
            else
            {
                multiply = multiply * arr1[i];

            }
        }
        Console.WriteLine("Total odd elements sum is: {0}", sum);
        Console.WriteLine("Total even elements multple is: {0}", multiply);
        Console.WriteLine("count array element is: {0}", arr1.Length);


        Console.WriteLine("-----------Second Problem---------- ");
        //დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის თუ არა
        //მოცემული სტრინგი პალინდრომი
        //(პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის) 

        string word, reverse = string.Empty;
        Console.WriteLine("Input word ");
        word = Console.ReadLine();
        if (word != null)
        {
            for (int i = word.Length - 1; i >= 0; i--)
                reverse = reverse + word[i].ToString();
        }
        if (word == reverse)
        {
            Console.WriteLine(word + " Word is palindorme");
        }
        else
        {
            Console.WriteLine(word + " Word is not palindorme");
        }


        Console.WriteLine("-----------Third Problem---------- ");
        //დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს
        //ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს.
        //Მაგ 1 1 2 2 2 3 4 2 2  - უნდა დაბეჭდოს 3  და 2.






        Console.WriteLine("-----------Forth Problem---------- ");

        int[] arr4 = { 1, 2, 3, 3, 4, 5, 1, 4 };

        // bool isRepeated = false;
        for (int i = 0; i < arr4.Length; i++)
        {
            for (int j = i + 1; j < arr4.Length; j++)
            {
                if (arr4[i] == arr4[j])
                {
                    Console.WriteLine("repaete elements in array is :" + arr4[i]);
                }
            }
        }
    }
}







