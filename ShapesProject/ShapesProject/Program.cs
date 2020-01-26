using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = -1;

            while ((num !=7) && (num != 0))
            {
                Console.WriteLine("Please enter your selection number below and press Enter:\n\n" +
                                   "1.Add new shape\n" +
                                   "2.List all shapes\n" +
                                   "3.Sum all circumferences\n" +
                                   "4.Sum all areas\n" +
                                   "5.Find biggest circumference\n" +
                                   "6.Find biggest area\n" +
                                   "7.Exit\n");

                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter only numbers!\n");
                }

                MainSelection(num);

                Console.ReadKey();
            }

        }

        public static void MainSelection(int num)
        {
            int n = num;

            switch (n)
            {
                case 0:
                    break;

                case 1: /*Add new shape*/
                    {
                        int tempShapeNum = -1;

                        Console.WriteLine("Please choose shape:\n" +
                                          "1.Square\n" +
                                          "2.Rectangle\n" +
                                          "3.Circle\n" +
                                          "4.Right triangle\n");

                        try
                        {
                            tempShapeNum = Convert.ToInt32(Console.ReadLine());
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Please enter only numbers!\n");
                        }

                        ShapeSelection(tempShapeNum);


                        break;
                    }

                case 2: /*List all shapes*/
                    {
                        foreach (var item in GlobalData.arrayOfShapes)
                            Console.WriteLine(item);

                        break;
                    }

                case 3: /*Sum all circumferences*/
                    {
                        SumCircumferenceOrSumArea(GlobalData.arrayOfShapes, 3);
                        
                        break;
                    }

                case 4: /*Sum all areas*/
                    {
                        SumCircumferenceOrSumArea(GlobalData.arrayOfShapes, 4);

                        break;
                    }
                    
                case 5: /*Find biggest circumference*/
                    {
                        MaxCircumferenceOrMaxArea(GlobalData.arrayOfShapes, 5);

                        break;
                    }

                case 6: /*Find biggest area*/
                    {
                        MaxCircumferenceOrMaxArea(GlobalData.arrayOfShapes, 6);

                    }
                    break;

                case 7: /*Exit*/
                    {
                        Environment.Exit(0);
                        break;
                    }

                default:
                    break;
            }
        }

        public static void ShapeSelection(int num)
        {
            int temp = num;

            switch (temp)
            {
                case 0:
                    break;
                case 1: /*Square*/
                    {
                        Console.WriteLine("Please enter square width:\n");

                        try
                        {
                            int width = Convert.ToInt32(Console.ReadLine());

                            GlobalData.arrayOfShapes[GlobalData.i] = new Square(width);
                            GlobalData.i++;
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Please enter only numbers!\n");
                        }
                       

                        break;
                    }
                case 2: /*Rectangle*/
                    {
                        try
                        {
                            Console.WriteLine("Please enter rectangle height:\n");
                            int height = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Please enter rectangle width:\n");
                            int width = Convert.ToInt32(Console.ReadLine());

                            GlobalData.arrayOfShapes[GlobalData.i] = new Rectangle(height, width);
                            GlobalData.i++;
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Please enter only numbers!\n");
                        }

                        break;
                    }

                case 3: /*Circle*/
                    {
                        try
                        {
                            Console.WriteLine("Please enter circle radius:\n");
                            int radius = Convert.ToInt32(Console.ReadLine());


                            GlobalData.arrayOfShapes[GlobalData.i] = new Circle(radius);
                            GlobalData.i++;
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Please enter only numbers!\n");
                        }

                        break;
                    }

                case 4: /*Right triangle*/
                    {
                        try
                        {
                            Console.WriteLine("Please enter right triangle height:\n");
                            int height = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Please enter right triangle width:\n");
                            int width = Convert.ToInt32(Console.ReadLine());

                            GlobalData.arrayOfShapes[GlobalData.i] = new Right_triangle(height, width);
                            GlobalData.i++;
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Please enter only numbers!\n");
                        }

                        break;
                    }

                default:
                    break;
            }
        }

        /// <summary>
        /// Globals
        /// </summary>
        public static class GlobalData
        {
            public static Shape[] arrayOfShapes = new Shape[4];
            
            public static int i = 0;

        };


        public static void MaxCircumferenceOrMaxArea(Shape[] arrayOfShapes, int MenuIndex)
        {
            if (MenuIndex == 5)
            {
                double max = arrayOfShapes[0].GetCircumference();
                //המיקום במערך שרוצים לשלוף נתונים
                int temp = 0;

                for (int i = 0; i < GlobalData.i; i++)
                {
                    if (arrayOfShapes[i].GetCircumference() > max)
                    {
                        max = arrayOfShapes[i].GetCircumference();

                        temp = i;
                    }
                }

                Console.WriteLine("The biggest circumference: {0}", max);

                Console.WriteLine(arrayOfShapes[temp]);
            }

            else if(MenuIndex == 6)
            {
                double max = arrayOfShapes[0].GetArea();
                //המיקום במערך שרוצים לשלוף נתונים
                int temp = 0;

                for (int i = 0; i < GlobalData.i; i++)
                {
                    if (arrayOfShapes[i].GetArea() > max)
                    {
                        max = arrayOfShapes[i].GetArea();

                        temp = i;
                    }
                }

                Console.WriteLine("The biggest Area: {0}", max);

                Console.WriteLine(arrayOfShapes[temp]);
            }
        }


        public static void SumCircumferenceOrSumArea(Shape[] arrayOfShapes, int MenuIndex)
        {
            if (MenuIndex == 3)
            {
                double sumCircumferences = 0;
                //המיקום במערך שרוצים לשלוף נתונים
                //int temp = 0;

                for (int i = 0; i < GlobalData.i; i++)
                {
                    //double t = GlobalData.arrayOfShapes[i].GetCircumference();

                    sumCircumferences += GlobalData.arrayOfShapes[i].GetCircumference();
                }

                Console.WriteLine("The sum of all circumferences: {0}", sumCircumferences);

            }

            else if(MenuIndex == 4)
            {
                double sumAllAreas = 0;
                //המיקום במערך שרוצים לשלוף נתונים

                for (int i = 0; i < GlobalData.i; i++)
                {
                    //double t = GlobalData.arrayOfShapes[i].GetArea();

                    sumAllAreas += GlobalData.arrayOfShapes[i].GetArea();
                }

                Console.WriteLine("The sum of all Areas: {0}", sumAllAreas);
            }
        }
    }
}
