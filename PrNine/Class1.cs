using System;
namespace PRNINE
{
    public class Class1
    {
        public struct Participant
        {
            public string FIO; // ��� ����������
            public int Number; // ����� ���������
            public double Result; // ��������� ������ (� ��������)

            //������������� ����������
            public Participant(string fio, int number, double result)
            {
                FIO = fio;
                Number = number;
                Result = result;
            }
        }
    }

}
