#include "pch.h"
#include "CreateDLL.h"

#include <stdexcept> // �����׼�쳣��
#include <climits>   // ����INT_MAX


int __stdcall Factorial(int number)
{
    if (number < 0)
    {
        throw std::invalid_argument("�������ܽ��н׳�");
    }
    if (number == 0 || number == 1)
    {
        return 1;
    }

    // ���˷�ǰ�Ƿ�����
    int result = Factorial(number - 1);
    if (result > INT_MAX / number)
    {
        throw std::overflow_error("�׳˽��������int�ķ�Χ");
    }

    return number * result;
}



int __stdcall CalculateDifference(int a, int b)
{
    // ���aС��b���򽻻�a��b��ֵ
    if (a < b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // �����ֵ
    int result = a - b;
    return result;
}


