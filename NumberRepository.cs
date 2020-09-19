using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class NumberRepository
    {
        private List<SetNumber> _listOfNumbers = new List<SetNumber>();

        //Add a number to the repository
        public void AddNumberofList(SetNumber number)
        {
            _listOfNumbers.Add(number);
        }

        //Read the list of numbers
        public List<SetNumber> GetNumberList()
        {
            return _listOfNumbers;
        }


    }
}
