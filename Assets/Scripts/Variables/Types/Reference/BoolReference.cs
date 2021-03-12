using System;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class BoolReference : Reference<bool, Variable<bool>>
    {
        public BoolReference(bool value) : base(value)
        {
        }
    }
}