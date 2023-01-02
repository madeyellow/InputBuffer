using UnityEngine;

namespace MadeYellow.InputBuffer.Abstractions
{
    /// <summary>
    /// Basis for buffering input data
    /// </summary>
    [System.Serializable]
    public abstract class InputBufferBase
    {
        /// <summary>
        /// <see cref="Time.time"/> of last <see cref="SetTimestamp()"/> usage 
        /// </summary>
        private float _timestamp = float.MinValue;

        
        [SerializeField]
        [Range(0f, 10f)]
        private float _holdTime = 0.25f;

        /// <summary>
        /// Time span after which buffer should be reset
        /// </summary>
        public float holdTime => _holdTime;

        /// <summary>
        /// Indicates if buffer hold input data at this moment
        /// </summary>
        public bool hasBuffer => _timestamp + _holdTime >= Time.time;

        public InputBufferBase()
        {

        }

        public InputBufferBase(float holdTime)
        {
            _holdTime = holdTime;
        }

        /// <summary>
        /// Updates <see cref="_timestamp"/>, so <see cref="hasBuffer"/> can be checked
        /// </summary>
        protected void SetTimestamp()
        {
            _timestamp = Time.time;
        }

        /// <summary>
        /// Resets buffer
        /// </summary>
        public void Reset()
        {
            _timestamp = float.MinValue;
        }

        /// <summary>
        /// Changes time span after which buffer should be reset
        /// </summary>
        /// <param name="holdTime"></param>
        public void UpdateHoldTIme(float holdTime)
        {
            _holdTime = holdTime;
        }
    }
}