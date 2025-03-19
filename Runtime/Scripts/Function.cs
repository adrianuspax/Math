using UnityEngine;

namespace ASPax.Math
{
    /// <summary>
    /// Useful math calculations
    /// </summary>
    public class Function
    {
        /// <summary>
        /// In a Cartesian graph, returns the y value based on the x value entered in a range bounded on the X and Y axes: y = ax + b
        /// </summary>
        /// <param name="x">Value within the X-axis delimited range to return its Y-axis equivalence</param>
        /// <param name="vectorA">Graph coordinates at point A: (xa)</param>
        /// <param name="vectorB">Graph coordinates at point B: (xb)</param>
        /// <returns>Returns the value on the Cartesian line y over a range of ymin and ymax</returns>
        public static float Linear(float x, Vector2 vectorA, Vector2 vectorB)
        {
            var a = (vectorB.y - vectorA.y) / (vectorB.x - vectorA.x);
            var b = vectorA.y - (((vectorB.y - vectorA.y) / (vectorB.x - vectorA.x)) * vectorA.x);
            var y = (a * x) + b;
            return y;
        }
        /// <summary>
        /// On a Cartesian graph, returns the value of y based on the range of x-axis values in a quadratic function: y = ax² + bx + c
        /// </summary>
        /// <param name="x">Value within the X-axis delimited range to return its Y-axis equivalence</param>
        /// <param name="vectorA">Graph coordinates at point A: (A.x, A.y)</param>
        /// <param name="vectorB">Graph coordinates at point B: (B.x, B.y)</param>
        /// <returns>Returns the value of the quadratic function on the y-axis over a range of ymin and ymax</returns>
        public static float Quadratic(float x, Vector2 vectorA, Vector2 vectorB)
        {
            var x2 = Mathf.Pow(x, 2f);
            var k = 1f / Mathf.Pow((vectorB.x - vectorA.x), 2f);
            var a = 4f * (vectorA.y - vectorB.y) * k;
            var b = 4f * (vectorB.y - vectorA.y) * (vectorB.x + vectorA.x) * k;
            var c = ((vectorA.y - vectorB.y) * Mathf.Pow((vectorB.x + vectorA.x), 2f) * k) + vectorB.y;
            var y = (a * x2) + (b * x) + c;
            return y;
        }
    }
}