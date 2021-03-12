using System;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class StringReference : Reference<string, Variable<string>>
    {
        public StringReference(string value) : base(value)
        {
        }
    }
}