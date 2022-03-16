// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

bool? value = false;
//Sometimes we get a warning here
var a = value switch
{
    null => "s",
    false => "aa",
    true => "aa"
};

namespace SwitchTest
{
    public class Test
    {
        public bool? Value { get; set; }
        public override string ToString()
        {
            //we always get warnings here
            var a = Value switch
            {
                null => nameof(Value),
                false => "aa",
                true => "aa"
            };
            return a;
        }

        public string S
        {
            get
            {
                //and here
                return Value switch
                {
                    null => nameof(Value),
                    false => "aa",
                    true => "aa"
                };
            }
        }
    }
}