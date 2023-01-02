using MadeYellow.InputBuffer.Abstractions;

namespace MadeYellow.InputBuffer
{
    /// <summary>
    /// Buffers input fact. Best for buffering button press.
    /// </summary>
    [System.Serializable]
    public class SimpleInputBuffer : InputBufferBase
    {
        public SimpleInputBuffer()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="holdTime">Time span after which buffer should be reset</param>
        public SimpleInputBuffer(float holdTime) : base(holdTime)
        {

        }

        /// <summary>
        /// Set up buffer
        /// </summary>
        public void Set()
        {
            SetTimestamp();
        }
    }
}