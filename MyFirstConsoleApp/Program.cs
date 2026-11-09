OperatorExamples();

void OperatorExamples()
{
    // Эта команда объявляет переменную и присваивает ей значение 3
    int width = 3;
    // Оператор ++ инкрементирует переменную (увеличивает ее на 1)
    width++;
    // Объявляем еще две переменные int для хранения чисел
    // и используем операторы + и * для сложения и умножения значений
    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);

    while (area < 50)
    {
        height++;
        area = width * height;
    }

    do
    {
        width--;
        area = width * height;

    } while (area > 25);


    // Следующие две команды объявляют строковые переменные
    // и объединяют их оператором + (эта операция называется конкатенацией)
    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result);
    // Логическая переменная может содержать
    // либо true, либо false
    bool truthValue = true;
    Console.WriteLine(truthValue);
}