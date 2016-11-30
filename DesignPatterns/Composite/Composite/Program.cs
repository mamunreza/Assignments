using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single control");
            CheckSingleTextBoxValidation();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Basic info form");
            CheckBasicFormValidation();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Details info form");
            CheckDetailsFormValidation();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Contact info form");
            CheckContactFormValidation();

            Console.ReadKey();
        }

        private static void CheckSingleTextBoxValidation()
        {
            BaseValidate textBoxValidate1 = new TextBoxValidate("One");
            textBoxValidate1.Validate();
        }

        private static void CheckBasicFormValidation()
        {
            var basicValidation = new CompositValidate("BasicForm");

            BaseValidate validateFirstName = new TextBoxValidate("TextBox, FirstName");
            BaseValidate validateLastName = new TextBoxValidate("TextBox, LastName");
            BaseValidate validateGender = new DropDownValidate("DropDown, Gender");

            basicValidation.Add(validateFirstName);
            basicValidation.Add(validateLastName);
            basicValidation.Add(validateGender);

            basicValidation.Validate();
        }

        private static void CheckContactFormValidation()
        {
            var contactValidation = new CompositValidate("ContactForm");

            SetContactDetails(contactValidation);
            BaseValidate validateMessage = new TextAreaValidate("TextBox, Message");

            contactValidation.Add(validateMessage);

            contactValidation.Validate();
        }

        private static void CheckDetailsFormValidation()
        {
            var detailsValidation = new CompositValidate("DetailsForm");

            SetProfessionalDetails(detailsValidation);
            SetContactDetails(detailsValidation);
            BaseValidate validateImage = new ImageValidate("Image, ProfilePic");
            BaseValidate validateInterest = new ImageValidate("CheckBox, Interest");

            detailsValidation.Add(validateImage);
            detailsValidation.Add(validateInterest);

            detailsValidation.Validate();
        }

        private static void SetProfessionalDetails(CompositValidate compositValidate)
        {
            BaseValidate validateCompany = new DropDownValidate("DropDown, Company");
            BaseValidate validateDesignation = new DropDownValidate("DropDown, Designation");
            BaseValidate validateDepartment = new DropDownValidate("DropDown, Department");
            BaseValidate validateAge = new TextBoxValidate("TextBox, Age");

            compositValidate.Add(validateCompany);
            compositValidate.Add(validateDesignation);
            compositValidate.Add(validateDepartment);
            compositValidate.Add(validateAge);
        }

        private static void SetContactDetails(CompositValidate compositValidate)
        {
            BaseValidate validatePhone = new TextBoxValidate("TextBox, Phone");
            BaseValidate validateEmail = new TextBoxValidate("TextBox, Email");

            compositValidate.Add(validatePhone);
            compositValidate.Add(validateEmail);
        }
    }
}
