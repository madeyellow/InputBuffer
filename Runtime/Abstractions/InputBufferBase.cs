using UnityEngine;

namespace MadeYellow.InputCaching.Abstractions
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

        /// <summary>
        /// How long input should hold
        /// </summary>
        [SerializeField]
        [Range(0f, 10f)]
        private float _duration = 0.25f;

        /// <summary>
        /// Indicates if buffer hold input data at this moment
        /// </summary>
        public bool hasBuffer => _timestamp + _duration >= Time.time;

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
    }
}