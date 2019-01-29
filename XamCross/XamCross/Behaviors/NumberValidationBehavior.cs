// @author - Vikas(21singhvikas@gmail.com) - 23 Jan 2019
//The code, given below, is Number validation Behaviors.
//The Entry box will allow only the numeric value.

using Xamarin.Forms;

namespace XamCross.Behaviors
{
    public class NumberValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            int result;

            bool isValid = int.TryParse(args.NewTextValue, out result);

            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
