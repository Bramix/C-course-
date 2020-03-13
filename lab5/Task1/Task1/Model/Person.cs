using System;

namespace Task1
{
    public abstract class Person
    {
        protected string firstName;
        protected string secondName;
        protected DateTime birthDay;

        abstract public void ShowInformation();
        
        /*
         * Has some implementation for all cases
         */
        
        public int CalculateAge()
        {
            int res = DateTime.Now.Year - birthDay.Year;
            if (birthDay.Month - DateTime.Now.Month >= 6) res--;
            return res;
        }
        
        protected Person(string firstName, string secondName, DateTime birthDay)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.birthDay = birthDay;
        }

        public override string ToString()
        {
            return $"{nameof(firstName)}: {firstName}, {nameof(secondName)}: {secondName}, {nameof(birthDay)}: {birthDay.ToString("yyyy-MM-dd")}";
        }
    }
}