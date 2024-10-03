using System;

namespace Coding.Exercise
{
    public class PairOfArrays<TLeft, TRight>
    {
        private readonly TLeft[] _left;
        private readonly TRight[] _right;

        public PairOfArrays(
            TLeft[] left, TRight[] right)
        {
            _left = left;
            _right = right;
        }

        public (TLeft Left, TRight Right) this[int indexLeft, int indexRight]
        {
            get
            {
                return (_left[indexLeft], _right[indexRight]);
            }

            set
            {
                _left[indexLeft] = value.Left;
                _right[indexRight] = value.Right;
            }
        }
    }
}
