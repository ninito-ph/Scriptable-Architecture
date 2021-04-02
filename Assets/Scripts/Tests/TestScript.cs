using UnityEngine;
using ManyTools.Variables;

public class TestScript : MonoBehaviour
{
    [Header("Int Reference Types")]
    [SerializeField]
    public IntReference _myIntReferenceAsConstant = new IntReference(0);
    [SerializeField]
    public IntReference _myIntReferenceAsVariable;

    [SerializeField] public AnimationCurveReference _myAnimCurve;


    [Header("Int Variable Types")]
    [SerializeField]
    public IntVariable _IntVariable;
}
