using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain.Validation
{
    public class ModelStateValidation : Dictionary<string,string>
    {
        public void addError(string key, string ErrorMessage)
        {
            this.Add(key, ErrorMessage);
        }
        public bool isValid { get { return this.Count <= 0; } }
    }
}
