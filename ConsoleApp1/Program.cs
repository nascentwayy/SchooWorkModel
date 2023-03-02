Console.Write("Введите название школы: ");
School newSchool = new School(Console.ReadLine());
Console.WriteLine($"Школа с названием {newSchool.NameOfSchool} успешно создана.");

while (true)
{
    Console.Write($"Хотите посмотреть список всех учеников школы {newSchool.NameOfSchool}? Да / Нет: ");
    bool answerUserAboutInfoOfStudents = GetAnswerAdmin(Console.ReadLine());

    if (answerUserAboutInfoOfStudents == true)
    {
        newSchool.PrintListOfStudents();
    }
    else break;

    Console.Write($"Хотите добавить нового ученика в список {newSchool.NameOfSchool}? Да / Нет: ");
    bool answerUserAboutAddNewStudent = GetAnswerAdmin(Console.ReadLine());
    if (answerUserAboutAddNewStudent == true)
    {
        Console.Write("Введите имя ученика: ");
        string firstName = Console.ReadLine();
        Console.Write("Введите фамилию ученика: ");
        string lastName = Console.ReadLine();
        Console.Write("Введите возраст ученика: ");
        int ageStudent = Convert.ToInt32(Console.ReadLine());
        Student newStudent = new Student(firstName, lastName, ageStudent);
        newSchool.AddNewStudent(newStudent);

        Console.Write("Хотите отчислить ученика? Да / Нет ");

        bool answerUserAboutRemoveStudent = GetAnswerAdmin(Console.ReadLine());
        if (answerUserAboutRemoveStudent == true)
        {
            Console.Write("Введите номер ученика, которого хотите удалить, будьте внимательны при вводе данных: ");
            newSchool.RemoveStudent(GetDigitAfterVerification(Console.ReadLine(), newSchool.Students.Count));
            Console.WriteLine("Ученик успешно удален!");
        }
        Console.Write("Хотите очистить экран консоли для удобства? Все внесенные данные будут сохранены. Да / Нет: ");
        bool answerAboutClearConsole = GetAnswerAdmin(Console.ReadLine());
        if (answerAboutClearConsole == true) Console.Clear();


    }
    else break;
}
Console.WriteLine("Выполнение программы завершено!");

static bool GetAnswerAdmin(string answer)
{
    while (true)
    {
        answer = answer.ToLower().Trim();
        if (answer == "да")
        {
            return true;
        }
        else if (answer != "да" && answer != "нет")
        {
            Console.Write("Введите корректный ответ! ");
        }
        else return false;
        answer = Console.ReadLine();
    }
}

static int GetDigitAfterVerification(string answer, int countElements)
{
    while (true)
    {
        try
        {
            if (int.Parse(answer) > 0 && int.Parse(answer) <= countElements)
            {
                return int.Parse(answer);
            }
            else
            {
                Console.Write("Проверьте правильность введенных данных! Введите номер ученика для отчисления: ");
                answer = Console.ReadLine();
                continue;
            }
        }
        catch
        {
            Console.Write("Проверьте правильность введенных данных! Введите номер ученика для отчисления: ");
            answer = Console.ReadLine();
            continue;
        }
    }
}