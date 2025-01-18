
using Rectangle = Assignment.Classes.Rectangle;

using Circle = Assignment.Classes.Circle;
using Assignment.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inheritfrom IShape.Implement these interfaces in classes Circle and Rectangle. Testyour implementation by creating instances of both classes and displaying theirshape information.

            Rectangle R = new Rectangle();

            R.Area = 10;

            R.DisplayShapeInfo();

            Circle Circle = new Circle();

            Circle.Area = 25;

            Circle.DisplayShapeInfo();

            #endregion



        }
    }
}
