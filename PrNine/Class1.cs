using System;
namespace PRNINE
{
    public class Class1
    {
        public struct Participant
        {
            public string FIO; // ФИО участников
            public int Number; // Номер участника
            public double Result; // Результат забега (в секундах)

            //Инициализация участников
            public Participant(string fio, int number, double result)
            {
                FIO = fio;
                Number = number;
                Result = result;
            }
        }
    }

}
