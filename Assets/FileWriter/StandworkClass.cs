using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StandworkClass : MonoBehaviour {

    public int StandworkNumber = 0;
    public Dictionary<int, int> ConnectionsList = new Dictionary<int, int>();

    public string convertToJSONString(StandworkClass standworkClass)
    {
        string jsonString = "";

        //Convert standworkClass to jsonString

        return jsonString;
    }

    public StandworkClass convertToStandworkClass(string jsonString)
    {
        StandworkClass standworkClass = new StandworkClass();
        jsonString = "";

        //Convert jsonString to standworkClass

        return standworkClass;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
