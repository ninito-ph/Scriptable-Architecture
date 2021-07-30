namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class IntReference : Reference<int, IntVariable>
    {
        public IntReference(int value) : base(value)
        {
        }
    }
}