using UnityEngine;
using System.Collections;

public class StaticParamClass
{
    public static Vector3 ballPosition;

    public static void SavePos(Vector3 tr)
    {
        StaticParamClass.ballPosition = tr;
        //StaticParamClass.ballPosition.localRotation = tr.localRotation;
        //StaticParamClass.ballPosition.localScale = tr.localScale;
    }

    public static void LoadPos(Vector3 tr)
    {
        tr = StaticParamClass.ballPosition;
        //tr.localRotation = StaticParamClass.ballPosition.localRotation;
        //tr.localScale = StaticParamClass.ballPosition.localScale;
    }

}
