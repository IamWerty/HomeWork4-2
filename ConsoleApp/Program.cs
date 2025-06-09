using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Яку дію будете використовувати?\n+(Додавання), -(Мінусування), *(Множення), /(Ділення)\n");
var operation = Console.ReadLine();
if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
{
    Console.WriteLine("Помилка: невідома операція.");
    return;
}

Console.Write("Введіть першу цифру:\n");
var firstNumber = Convert.ToInt16(Console.ReadLine());

Console.Write("Введіть другу цифру:\n");
var secondNumber = Convert.ToInt16(Console.ReadLine());

int result = 0;
var validOperation = true;

switch (operation)
{
        case "+":
                result = firstNumber + secondNumber;
                break;
        case "-":
                result = firstNumber - secondNumber;
                break;
        case "*":
                result = firstNumber * secondNumber;
                break;
        case "/":
                if (secondNumber == 0)
                {
                        Console.WriteLine("На 0 ділити не можна!(Ну взагалі можна... Ну добре, буде тобі результат!)");
                        Console.WriteLine("Ваш результат: ∞");
                        validOperation = false;
                        break;
                }
                else
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"Ваш результат: {result}");
                break;
}
if (validOperation = true && operation != "/")
{
    Console.WriteLine($"Ваш результат: {result}");
}
