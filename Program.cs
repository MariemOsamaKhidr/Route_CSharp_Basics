namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enums
            /*
            Console.Write("Enter a day number (0-6)");
            int day=int.Parse(Console.ReadLine());
            switch (day)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"Day:{(Days)day}");
                    if (day==0 || day==1)
                    {
                        Console.WriteLine("It's the weekend");      
                    }
                    else
                    {
                        Console.WriteLine("It's a workday");
                    }
                    break;
            }*/
            #endregion
            #region array

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            double sum = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"element number {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine($"sum is:{sum}");
            Console.WriteLine($"Average is:{(sum) / size}");
            Console.WriteLine($"Max is : {max}");
            Console.WriteLine($"Min is : {min}");
            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
            Console.WriteLine("Reversed array: " + string.Join(", ", array));

            #endregion
            #region 2d array

            //double[,] students=new double[3,4];
            //double sum1 = 0;
            //double sum2 = 0;
            //double sum3 = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Enter arr[{i}][{j}]: ");
            //        students[i,j]=double.Parse( Console.ReadLine());
            //        if (i == 0)
            //        {
            //           sum1+= students[i, j];
            //        }
            //        else if (i==1){
            //            sum2 += students[i, j];
            //        }
            //        else
            //        {
            //            sum3+= students[i, j];
            //        }

            //    }
            //}
            //double totalsum = sum1 + sum2 + sum3;
            //Console.WriteLine($"Average grade for student 1 is:{sum1/4}");
            //Console.WriteLine($"Average grade for student 2 is:{sum2 / 4}");
            //Console.WriteLine($"Average grade for student 3 is:{sum3 / 4}");
            //Console.WriteLine($"Overall class Average :{totalsum / 12}");



            #endregion
            #region method
            //Q1
            // Console.Write("Enter the first number:");
            // double num1 = double.Parse(Console.ReadLine());
            // Console.Write("Enter the second number:");
            // double num2= double.Parse(Console.ReadLine());
            // Console.WriteLine($"There are 4 operations to chhose from \n 1:add \n 2:subtract \n 3:multiply \n 4:divide \n");
            // Console.Write("Choose one operation from the list :)");
            //int operation=int.Parse(Console.ReadLine());
            // switch (operation) {
            //     case 1:
            //         {

            //             Console.WriteLine($"result: {Calculator.add(num1, num2)}");
            //             break;
            //         }
            //     case 2:
            //         {
            //             Console.WriteLine($"result:{Calculator.subtract(num1, num2)} ");

            //             break;
            //         }


            //      case 3:
            //         {

            //             Console.WriteLine($"result: {Calculator.multiply(num1, num2)}");
            //             break;
            //         }
            //      case 4:
            //         {
            //             Console.WriteLine($"result: {Calculator.divide(num1, num2)}");
            //             break;
            //         }
            // }


            //Q2
            //Console.Write("Enter the radius of the circle: ");

            //if (double.TryParse(Console.ReadLine(), out double radius))
            //{
            //    double circleArea;
            //    double circleCircumference;
            //    Calculator.CalculateCircle(radius, out circleArea, out circleCircumference);               
            //    Console.WriteLine($"\nResults for radius = {radius}:");
            //    Console.WriteLine($"Area          = {circleArea:F4}");
            //    Console.WriteLine($"Circumference = {circleCircumference:F4}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            #endregion

        }
    }
}
