using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WustenMaler.Front.Services
{
    public interface IBookService
    {
        IEnumerable<Book> MostPopular(int numberToTake);
    }
}
