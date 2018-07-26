using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Helper
{
    public static class ModelStateHelper
    {
        public static List<ModelError> GetError(ModelStateDictionary modelStateDictionary)
        {
            List<ModelError> Errors = new List<ModelError>();
            foreach (var values in modelStateDictionary.Values)
            {
                foreach (var error in values.Errors)
                {
                    Errors.Add(error);
                }
            }
            return Errors;
        }
    }
}
