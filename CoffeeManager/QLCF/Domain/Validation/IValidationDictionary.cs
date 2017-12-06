using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain.Validation
{
    public interface IValidationDictionary
    {
        void DictionaryClear();
        void AddError(string key, string ErrorMessage);
        bool IsValid { get; }
    }
}
