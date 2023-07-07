Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2 && num1 > num3){
    Console.WriteLine("Наибольшим является число: "+num1);
}
else if(num2 > num1 && num2 > num3){
    Console.WriteLine("Наибольшим является число: "+num2);
}
else if(num3 > num1 && num3 > num2){
    Console.WriteLine("Наибольшим является число: "+num3);
}
else{
    Console.WriteLine("Введенные значения некорекнты или равны друг другу");
}
