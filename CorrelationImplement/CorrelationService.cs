#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace CorrelationImplement
{
    /// <summary>
    /// 相関関数を求めるライブラリです。
    /// </summary>
    public static class CorrelationService
    {
        /// <summary>
        /// ピアソンの積率相関係数を計算します。
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double SampleCorrelationCoefficient(IList<double> x, IList<double> y)
        {
            var averageX = x.Average();
            var averageY = y.Average();

            var numerator = Enumerable.Range(0, x.Count).Sum(i => (x[i] - averageX) * (y[i] - averageY));
            var denominator = Math.Pow(x.Sum(i => Math.Pow(i - averageX, 2)) * y.Sum(i => Math.Pow(i - averageY, 2)), 0.5);
            return numerator / denominator;
        }
    }
}