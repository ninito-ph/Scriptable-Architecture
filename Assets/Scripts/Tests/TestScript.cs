using UnityEngine;
using ScriptableArchitecture.Variables;

public class TestScript : MonoBehaviour
{
    [Header("Int Reference Types")]
    [SerializeField]
    public IntReference _myIntReferenceAsConstant = new IntReference(0);
    [SerializeField]
    public IntReference _myIntReferenceAsVariable;


    [Header("Int Variable Types")]
    [SerializeField]
    public IntVariable _IntVariable;
}
