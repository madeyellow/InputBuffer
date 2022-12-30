namespace MadeYellow.InputCaching.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    [System.Serializable]
    public abstract class InputBufferValueBase<TValue> : InputBufferBase
    {
        public TValue value { get; private set; }

        /// <summary>
        /// Set up buffer with value
        /// </summary>
        /// <param name="value"></param>
        public void Set(TValue value)
        {
            this.value = value;

            SetTimestamp();
        }
    }
}