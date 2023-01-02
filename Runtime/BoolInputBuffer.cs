using MadeYellow.InputBuffer.Abstractions;

namespace MadeYellow.InputBuffer
{
    /// <summary>
    /// Buffers input value of type <see cref="bool"/>
    /// </summary>
    [System.Serializable]
    public class BoolInputBuffer : InputBufferValueBase<bool>
    {
        public BoolInputBuffer()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="holdTime">Time span after which buffer should be reset</param>
        public BoolInputBuffer(float holdTime) : base(holdTime)
        {

        }
    }
}