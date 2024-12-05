using System.Security.Cryptography.X509Certificates;

namespace Linq1;

public delegate int TestDelegate(int number);

public class testAnonymous
{
    private int number;

    private TestDelegate test = number =>
    {
        number += number;
        return number;
    };

    // public static int addNumber(int number)
    // {
    // };
}