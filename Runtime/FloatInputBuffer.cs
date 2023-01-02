using MadeYellow.InputBuffer.Abstractions;

namespace MadeYellow.InputBuffer
{
    /// <summary>
    /// Buffers input value of type <see cref="float"/>. Best for buffering single axis
    /// </summary>
    [System.Serializable]
    public class FloatInputBuffer : InputBufferValueBase<float>
    {
        public FloatInputBuffer()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="holdTime">Time span after which buffer should be reset</param>
        public FloatInputBuffer(float holdTime) : base(holdTime)
        {

        }
    }
}