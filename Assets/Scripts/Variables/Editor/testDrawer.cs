using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableArchitecture.Variables;

public class testDrawer : MonoBehaviour
{
    [SerializeField]
    public IntReference _myIntReferenceAsConstant = new IntReference(0);
    [SerializeField]
    public IntReference _myIntReferenceAsVariable;
}
// https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Variables/Editor/FloatReferenceDrawer.cs