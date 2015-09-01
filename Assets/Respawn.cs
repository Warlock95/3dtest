using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
    GameObject Spawner;       
	// Use this for initialization
	void Start () {  
     Spawner =   GameObject.FindWithTag("Respawn");
    }
	
	// Update is called once per frame
	void Update () {
       if(transform.position.y<-20) transform.position=new Vector3(Spawner.transform.position.x, Spawner.transform.position.y, Spawner.transform.position.z);
       
                }
}
