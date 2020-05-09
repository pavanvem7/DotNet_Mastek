using System;
namespace Partial_Methods
{
    partial class SampleClass
    {
        // Declaration of the partial method.
        partial void SampleMethod();

        // A public method calling the partial method
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SampleMethod();
        }
    }
}
