using UnityEngine;
using System.Collections;
using UnityEditor;
//using TrainingObject;

//Creates a custom Label on the inspector for all the scripts named ScriptName
// Make sure you have a ScriptName script in your
// project, else this will not work.
[CustomEditor(typeof(TrainingObject))]
[CanEditMultipleObjects]
public class TrainingObjectEditor : Editor
{
	SerializedProperty ObjectTypeProp;

	//public string[] TrainingObjectTypes = new [] { "door", "tool", "machine" };
	//public int object_type_index = 0;
	//TrainingObjectType objectType;// = new TrainingObjectType();

	// Use this for initialization

	public void OnEnable(){
		//objectType = new TrainingObjectType ();
		ObjectTypeProp = serializedObject.FindProperty ("training_object_type");
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update ();

		GUILayout.Label ("TrainingObject type");
		ObjectTypeProp.enumValueIndex = EditorGUILayout.Popup(ObjectTypeProp.enumValueIndex, ObjectTypeProp.enumDisplayNames);

        //EditorGUILayout.IntField (.object_type_index);*/
        //Draw label
        //GUILayout.Label ("This is a Label in a Custom Editor");

        //Draw button
        //GUILayout.Button ("1234");
        /*if (GUILayout.Button("Build Object"))
        {
            myScript.BuildObject();
        }*/


        // Draw the default inspector
        //DrawDefaultInspector();

        //Draw Popup with TrainingObjectTypes list

        //GUILayout.Label ("TrainingObject type");

        /*objectType.object_type_index = EditorGUILayout.Popup(objectType.object_type_index, objectType.object_type_list);
		objectType.object_type_name = objectType.object_type_list [objectType.object_type_index];
		EditorGUILayout.LabelField (objectType.object_type_name);
		//Draw object_type_index in Int field
		//GUILayout.Label ("TrainingObject type_index");
		EditorGUILayout.IntField (objectType.object_type_index);*/

        // Update the selected choice in the underlying object
        //object_type.choice = TrainingObjectTypes[object_type_index];

        // Save the changes back to the object
        //EditorUtility.SetDirty(objectType);
        serializedObject.ApplyModifiedProperties ();
	}

	void OnGUI ()
	{
		// Choose an option from the list
		//object_type_index = EditorGUILayout.Popup(object_type_index, TrainingObjectTypes);
		// Update the selected option on the underlying instance of SomeClass
		//object_type.choice = TrainingObjectTypes[object_type_index];
	}
}

[System.Serializable]
public class TrainingObjectType
{
	public string[] object_type_list;
	[SerializeField]
	public int object_type_index;
	[SerializeField]
	public string object_type_name;

	public TrainingObjectType(){
		object_type_list = new [] { "door", "tool", "machine" };
		object_type_index = 0;
		object_type_name = object_type_list[object_type_index];
	}
}