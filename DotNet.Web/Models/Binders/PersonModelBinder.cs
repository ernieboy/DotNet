using System;
using System.Web.Mvc;
using DotNet.Domain.Model;

namespace DotNet.Web.Models.Binders
{
    public class PersonModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (controllerContext == null) throw new ArgumentNullException(nameof(controllerContext));
            if (bindingContext == null) throw new ArgumentNullException(nameof(bindingContext));

            var person = new Person();

            try
            {
                int age = GetIntegerValueFromvalueProvider(bindingContext, "Age");
                string firstName = GetStringValueFromvalueProvider(bindingContext, "FirstName");
                string surname = GetStringValueFromvalueProvider(bindingContext, "Surname");


                person.Age = age;
                person.FirstName = firstName;
                person.Surname = surname;
            }
            catch (Exception)
            {
                bindingContext.ModelState.AddModelError("", "Could not bind model");
            }
            return person;
        }

        private string GetStringValueFromvalueProvider(ModelBindingContext bindingContext, string keyValue)
        {
            if (bindingContext == null) throw new ArgumentNullException(nameof(bindingContext));
            if (string.IsNullOrWhiteSpace(keyValue)) throw new ArgumentNullException(nameof(keyValue));
            string value = bindingContext.ValueProvider.ContainsPrefix(keyValue) ?
                bindingContext.ValueProvider.GetValue(keyValue).AttemptedValue : string.Empty;
            return value;
        }

        private int GetIntegerValueFromvalueProvider(ModelBindingContext bindingContext, string keyValue)
        {
            if (bindingContext == null) throw new ArgumentNullException(nameof(bindingContext));
            if (string.IsNullOrWhiteSpace(keyValue)) throw new ArgumentNullException(nameof(keyValue));
            int value = bindingContext.ValueProvider.ContainsPrefix(keyValue) ?
                (int)bindingContext.ValueProvider.GetValue(keyValue).ConvertTo(typeof(int)) : 0;
            return value;
        }

    }
}