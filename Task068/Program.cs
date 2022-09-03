// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    // else if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    //Почему если я пишу строчку 9 вместо 12 получаю сообщение ниже? И как тогда надо правильно оформить?
    //"Ackermann(int, int)": не все пути к коду возвращают значение.
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = 2;
int n = 2;
int res = Ackermann(m, n);
Console.WriteLine($"Значение функции Акермана = {res}");