using UnityEngine;
using System.Collections;

public class DontDestroyScript : MonoBehaviour {

    public static DontDestroyScript Instance;
    public static bool Enabled;

    void Awake()
    {
        // If no Player ever existed, we are it.
        if (Instance == null)
        {
            Debug.Log("DON'T Destroy");
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
        
        /*if (!created)
        {
            Debug.Log("Object was NOT destryed");
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Debug.Log("Object was destroyed");
            Destroy(this.gameObject);
        }*/
    }
    
    // Use this for initialization
	void Start () {
        //Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
