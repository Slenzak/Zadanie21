int number1 = 3;
int number2 = 4;
PerformOperation(number1, number2, Add);
PerformOperation(number1, number2, subtract);
PerformOperation(number1, number2, multiply);
PerformOperation(number1, number2, divide);
int[] list1 = new int[2];
int[] list2 = new int[2];
list1[0] = number1;
list1[1] = number2;
list2[0] = number1+number2+number2;
list2[1] = number1+number2+number1;
FilterNumber(list1, even);
FilterNumber(list2, even);
FilterNumber(list1, biggerthan10);
FilterNumber(list2, biggerthan10);
FilterNumber(list1, lessthan0);
FilterNumber(list2, lessthan0);
Map(list1,square);
Map(list2,doubling);
Map(list2,minus1);

int Add(int a, int b)
{
    return a + b;
}
int subtract(int a, int b)
{
    return a - b;
}
int multiply(int a, int b)
{
    return a * b;
}
int divide(int a, int b)
{
    return a / b;
}
void PerformOperation(int a, int b, MathOperation operation)
{
    int result = operation(a, b);
    Console.WriteLine("The result is " + result);
}
bool even(int[] list)
{
    foreach (int i in list)
    {
        if (i % 2 != 0)
        {
            return false;
        }
    }
    return true;
}

bool biggerthan10(int[] list)
{
    foreach (int i in list)
    {
        if (i < 10)
        {
            return false;
        }
    }
    return true;
}
bool lessthan0(int[] list)
{
    foreach (int i in list)
    {
        if (i > 0)
        {
            return false;
        }
    }
    return true;
}
void FilterNumber(int[] list, Filter filter)
{
    bool result = filter(list);
    if(result == true)
    {
        Console.WriteLine("This list meets condition: ");
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        Console.WriteLine("This list doesn't meet this condition");
    }
}
int square(int a)
{
    return a * a;
}
int doubling(int a)
{
    return a * 2;
}
int minus1(int a)
{
    return a - 1;
}
void Map(int[] list,Transform transform)
{
    int[] result= new int[list.Length];
    for(int temp =0; temp < list.Length; temp++)
    {
        result[temp] = transform(list[temp]);
    }
    Console.WriteLine("Transformed list: ");
    foreach (int i in result)
    {
        Console.WriteLine(i);
    }
}

delegate bool Filter(int[] a);
delegate int MathOperation(int a, int b);
delegate int Transform(int a);
