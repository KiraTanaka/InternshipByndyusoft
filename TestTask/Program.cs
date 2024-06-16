using TestTask;

SmartClass smartClass = new SmartClass();
int[] arr = [4, 0, 3, 19, 492, -10, 1];
int? result = smartClass.SumTwoMinElements(arr);
Console.WriteLine("result = " + result);
