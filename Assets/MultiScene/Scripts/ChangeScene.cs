using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public bool doChange;
    public string targetName;
    public GameObject mainObject;

    public int savedParameter;

    public Vector3 ballPosition;

    public GameObject levelGameObject;

    //public static StaticParamClass transformSaver;
    //static public StaticParamClass transformSaver;
    
    // Use this for initialization
	void Start () {
        //StaticParamClass.ballPosition = Transform();
        //transformSaver = this;
        doChange = false;
        //transformSaver.
        //mainObject.transform = StaticParamClass.
        ballPosition = mainObject.transform.localPosition;
        //levelGameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        mainObject.transform.localPosition = ballPosition;
        
        if(doChange)
        {
            doChange = false;
            //StaticParamClass.SavePos(mainObject.transform.localPosition);
            ballPosition = mainObject.transform.localPosition;
            levelGameObject.SetActive(false);
            
            //Always last command
            Application.LoadLevel(targetName);
            DontDestroyScript.Enabled = false;
        }
	}

    void OnLevelWasLoaded()
    {
        levelGameObject.SetActive(DontDestroyScript.Enabled);
        //StaticParamClass.LoadPos(mainObject.transform.localPosition);
    }
}
