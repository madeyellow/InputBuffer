using MadeYellow.InputBuffer.Abstractions;

namespace MadeYellow.InputBuffer
{
    /// <summary>
    /// Buffers input value of type <see cref="int"/>. Best for buffering single axis
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