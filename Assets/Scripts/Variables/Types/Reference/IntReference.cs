using System;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class IntReference : Reference<int, Variable<int>>
    {
        public IntReference(int value) : base(value)
        {
        }
    }
}