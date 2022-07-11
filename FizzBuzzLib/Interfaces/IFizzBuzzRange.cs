namespace FizzBuzzLib.Interfaces
{
    using System.Collections.Generic;

    interface IFizzBuzzRange
    {
        IEnumerable<string> FizzBuzzValuesForRange(int start, int end);
    }
}
