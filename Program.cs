bool isWork = true;

while (isWork)
{
	Console.Write("Введите номер задания :");

int.TryParse(Console.ReadLine(), out int z);
	{
		switch (z)
		{
			case 1:
			{
				    System.Console.WriteLine("Введите число");
                    int.TryParse(Console.ReadLine(), out int a);
                    int i = 1;
                    while (i <= a)
                    {
                        int result = (int) Math.Pow(i,3);
                        i++;
                        System.Console.WriteLine(result);
                    }
			break;
			}
			case 2:
			{
                    System.Console.WriteLine("Введите значение a1");
                    int.TryParse(Console.ReadLine(), out int a1);
                    System.Console.WriteLine("Введите значение b1");
                    int.TryParse(Console.ReadLine(), out int b1);
                    System.Console.WriteLine("Введите значение c1");
                    int.TryParse(Console.ReadLine(), out int c1);
                    System.Console.WriteLine("Введите значение a2");
                    int.TryParse(Console.ReadLine(), out int a2);
                    System.Console.WriteLine("Введите значение b2");
                    int.TryParse(Console.ReadLine(), out int b2);
                    System.Console.WriteLine("Введите значение c2");
                    int.TryParse(Console.ReadLine(), out int c2);
                    double distance = 0;
                    
                    distance = Math.Sqrt(Math.Pow(a1-a2,2) + Math.Pow(b1-b2,2)+ Math.Pow(c1-c2,2));
                    
                    System.Console.WriteLine($"Растояние равно {distance}");
                    
            break;         
			}
				
            case 3:
			{
                    System.Console.WriteLine("Введите пятизначное число!");
                    int.TryParse(Console.ReadLine(), out int i);

                    int a1 = i / 10000;
                    System.Console.Write(a1);
                    int b2 = i % 100 / 10;
                    System.Console.Write(b2);
                    int a2 = i / 1000 % 10;
                    System.Console.Write(a2);
                    int b1 = i % 10;
                    System.Console.Write(b1);

                    if (a1 == b1 || a2 == b2) System.Console.WriteLine(" - число является палиндромом!");
                    else System.Console.WriteLine(" - число не является палиндромом!");
                    
            break;
            }
            
			case -1: isWork = false; break;
		}

	}}

