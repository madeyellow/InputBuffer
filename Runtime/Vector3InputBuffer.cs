using MadeYellow.InputBuffer.Abstractions;
using UnityEngine;

namespace MadeYellow.InputBuffer
{
    /// <summary>
    /// Buffers input value of type <see cref="Vector3"/>
    /// </summary>
    [System.Serializable]
    public class Vector3InputBuffer : InputBufferValueBase<Vector3>
    {
        public Vector3InputBuffer()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="holdTime">Time span after which buffer should be reset</param>
        public Vector3InputBuffer(float holdTime) : base(holdTime)
        {

        }
    }
}