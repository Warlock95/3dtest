using UnityEngine;
using System.Collections;

public class DildoMaker : MonoBehaviour
{

    public GameObject obj;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
                Instantiate(obj, transform.position, new Quaternion(0, 0, 0, 0));
        }
    }
}