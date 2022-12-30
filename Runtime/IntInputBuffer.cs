using MadeYellow.InputCaching.Abstractions;

namespace MadeYellow.InputCaching
{
    /// <summary>
    /// Buffers input value of type <see cref="int"/>
    /// </summary>
    [System.Serializable]
    public class IntInputBuffer : InputBufferValueBase<int>
    {
        public IntInputBuffer()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="holdTime">Time span after which buffer should be reset</param>
        public IntInputBuffer(float holdTime) : base(holdTime)
        {

        }
    }
}