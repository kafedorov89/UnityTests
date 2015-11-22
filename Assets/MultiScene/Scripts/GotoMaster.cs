using UnityEngine;
using System.Collections;

public class GotoMaster : MonoBehaviour {

    public bool doChange;
    public string targetName;
    public GameObject mainObject;

    //public static StaticParamClass transformSaver;
    //static public StaticParamClass transformSaver;

    // Use this for initialization
    void Start()
    {
        //StaticParamClass.ballPosition = Transform();
        //transformSaver = this;
        doChange = false;
        //transformSaver.
        //mainObject.transform = StaticParamClass.
    }

    // Update is called once per frame
    void Update()
    {
        if (doChange)
        {
            doChange = false;
            DontDestroyScript.Enabled = true;
            Application.LoadLevel(targetName);
        }
    }
}
