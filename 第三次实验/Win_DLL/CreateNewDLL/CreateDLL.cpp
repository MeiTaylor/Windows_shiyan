#include "pch.h"
#include "CreateDLL.h"

#include <stdexcept> // 引入标准异常库
#include <climits>   // 引入INT_MAX


int __stdcall Factorial(int number)
{
    if (number < 0)
    {
        throw std::invalid_argument("负数不能进行阶乘");
    }
    if (number == 0 || number == 1)
    {
        return 1;
    }

    // 检查乘法前是否会溢出
    int result = Factorial(number - 1);
    if (result > INT_MAX / number)
    {
        throw std::overflow_error("阶乘结果超出了int的范围");
    }

    return number * result;
}



int __stdcall CalculateDifference(int a, int b)
{
    // 如果a小于b，则交换a和b的值
    if (a < b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // 计算差值
    int result = a - b;
    return result;
}


