using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain.Validation
{
    public class ValidationWrapper : IValidationDictionary
    {
        private ModelStateValidation _modelState;
        public ValidationWrapper(ModelStateValidation modelState)
        {
            this._modelState = modelState;
        }
        public bool IsValid => _modelState.isValid;

        public void AddError(string key, string ErrorMessage)
        {
            _modelState.addError(key, ErrorMessage);
        }

        public void DictionaryClear()
        {
            _modelState.Clear();
        }
    }
}
