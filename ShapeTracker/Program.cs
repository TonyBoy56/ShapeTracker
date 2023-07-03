using System;
using System.Collections.Generic;
using ShapeTracker.Models;

namespace ShapeTracker
{
    class Program
    {
        static void Main()
        {
            Triangle testTriangle = new Triangle();
            Console.WriteLine(testTriangle.GetType());
        }
    }
}
