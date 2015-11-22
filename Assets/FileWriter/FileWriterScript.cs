using UnityEngine;
using System.Collections;
using System.IO;


public class FileWriterScript : MonoBehaviour {

    public string folderName = "Standworks";
    public string folderPath = "";
    public string fileName = "";
    public int StandworkNumber = 0;


    void StandworkFileWriter(string standworkJSONContent, int standworkNumber)
    {
        fileName = "Standwork_" + StandworkNumber.ToString() + ".json";
        //Debug.Log("Directory.GetCurrentDirectory" + Directory.GetCurrentDirectory());
        folderPath = Application.dataPath + "/../" + folderName + "/";
        Debug.Log("folderPath: " + folderPath);
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("folder doesn't exist");
            Directory.CreateDirectory(folderName);
            Debug.Log("folder was created");
        }
        else
        {
            Debug.Log("folder alredy exist");
        }

        //Directory.CreateDirectory(folderName);

        if (File.Exists(fileName))
        {
            Debug.Log(fileName + " already exists.");
            return;
        }

        StreamWriter sr = File.CreateText(folderPath + fileName);
        sr.Write(standworkJSONContent);
        //sr.WriteLine("This is my file.");
        //sr.WriteLine("I can write ints {0} or floats {1}, and so on.", 1, 4.2);
        sr.Close();
    }

    void Start()
    {
        StandworkClass standworkObject = new StandworkClass();

        standworkObject.ConnectionsList.Add(0, 1);
        standworkObject.ConnectionsList.Add(1, 0);

        standworkObject.ConnectionsList.Add(2, 3);
        standworkObject.ConnectionsList.Add(3, 2);

        standworkObject.ConnectionsList.Add(4, 5);
        standworkObject.ConnectionsList.Add(5, 4);

        standworkObject.ConnectionsList.Add(6, 7);
        standworkObject.ConnectionsList.Add(7, 6);

        standworkObject.ConnectionsList.Add(8, 9);
        standworkObject.ConnectionsList.Add(9, 8);

        standworkObject.StandworkNumber = 1;

        StandworkFileWriter("12341452345\n4352345234524\n34523452345234556745785678567\n23412313\ndfvsdfvsdfvsdfv\nsdfvsdfvs3453456456353546", 1);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
