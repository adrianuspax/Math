using UnityEngine;

namespace ASPax.Math
{
    /// <summary>
    /// Calculations for normalization values
    /// </summary>
    public class Normalization
    {
        /// <summary>
        /// Normalization between two values
        /// </summary>
        /// <param name="value">Value to be normalized</param>
        /// <param name="min">Minimum limiting value</param>
        /// <param name="max">Maximum limiting value</param>
        /// <returns>Returns a value between 0 and 1</returns>
        public static float ClampMinMax(float value, float min, float max)
        {
            value = Mathf.Clamp(value, min, max);
            var a = 1f / (max - min);
            var b = 1f / (max - min) * min;
            return (a * value) - b;
        }
    }
}