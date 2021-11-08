using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WustenMaler.Front.Services;

namespace WustenMaler.Front.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> MostPopular(int numberToTake);
    }
}
