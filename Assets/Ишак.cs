using UnityEngine;
using System.Collections;

public class DildloMaker : MonoBehaviour {

    public GameObject obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space));
        {
            Instantiate(obj, GameObject.Find("poj").transform.position, new Quaternion(0, 0, 0, 0));
            Debug.Log("XYN");
        }
	}
}
