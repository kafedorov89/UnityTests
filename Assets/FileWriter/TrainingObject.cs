using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class TrainingObject : MonoBehaviour {

	public enum TrainingObjectTypes
	{
		none = 0,
		door = 1,
		tool = 2,
		label = 3,
		machine = 4,
		stand = 5
	}
	
	public TrainingObjectTypes training_object_type = TrainingObjectTypes.none;

	//public int object_type_index;
	//public string object_type_name;

	//public string choice;

	// Use this for initialization

	void Start () {
		//object_type_index = (int)object_type;
		//object_type_name = object_type.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(training_object_type.ToString ());
		//object_type_index = (int)object_type;
		//object_type_name = object_type.ToString();
	}
}
