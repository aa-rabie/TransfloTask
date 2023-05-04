using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transflo.Driver.Application.Interfaces;

namespace Transflo.Driver.Application.Services
{
    public class AlphabetizerService : IAlphabetizerService
    {
        private string? AlphabetizeWord(string? input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            return String.Concat(input.ToLowerInvariant().OrderBy(ch => ch));
        }

        public string? Alphabetize(string? txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return txt;
            }
           var words = txt.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var result = string.Join(' ', words.Select(w => AlphabetizeWord(w)));
            return result;
        }
    }
}
