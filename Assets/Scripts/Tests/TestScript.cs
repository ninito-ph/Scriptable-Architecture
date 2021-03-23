using UnityEngine;
using ScriptableArchitecture.Variables;

public class TestScript : MonoBehaviour
{
    [Header("Int Reference Types")]
    [SerializeField]
    public IntReference _myIntReferenceAsConstant = new IntReference(0);
    [SerializeField]
    public Vector4Reference _myIntReferenceAsVariable;

    public Vector3Reference _vec3;

    public Vector4 _vec3normal;

    [Header("Int Variable Types")]
    [SerializeField]
    public IntVariable _IntVariable;
}
