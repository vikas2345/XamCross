// @author - Vikas(21singhvikas@gmail.com) - 23 Jan 2019

//The code, given below, is Date of birth validation Behavior.
//I used a DatePicker and restricted the max date to be 100 years from the current day and min date to be one.
//The DOB validation Behavior is added into DatePicker control.We can re-use this Behavior to Date Picker control.

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamCross.Behaviors
{
    public class DateOfBirthValidationBehavior : Behavior<DatePicker>
    {
        protected override void OnAttachedTo(DatePicker datepicker)
        {
            datepicker.DateSelected += Datepicker_DateSelected;
            base.OnAttachedTo(datepicker);
        }

        private void Datepicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime value = e.NewDate;
            int year = DateTime.Now.Year;
            int selyear = value.Year;
            int result = selyear - year;
            bool isValid = false;
            if (result <= 100 && result > 0)
            {
                isValid = true;
            }
           ((DatePicker)sender).BackgroundColor = isValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(DatePicker datepicker)
        {
            datepicker.DateSelected -= Datepicker_DateSelected;
            base.OnDetachingFrom(datepicker);
        }

    }
}
