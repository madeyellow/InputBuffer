using MadeYellow.InputCaching.Abstractions;
using UnityEngine;

namespace MadeYellow.InputCaching
{
    /// <summary>
    /// Buffers input value of type <see cref="Vector2"/>
    /// </summary>
    [System.Serializable]
    public class Vector2InputBuffer : InputBufferValueBase<Vector2>
    {
        public Vector2InputBuffer()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="holdTime">Time span after which buffer should be reset</param>
        public Vector2InputBuffer(float holdTime) : base(holdTime)
        {

        }
    }
}