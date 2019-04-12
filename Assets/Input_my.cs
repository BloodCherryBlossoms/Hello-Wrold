using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_my : MonoBehaviour
{

    private string names;
    public Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        names = "Holle wrold";
        Debug.Log(names);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWDown = Input.GetKeyDown(KeyCode.S);
        rd = gameObject.GetComponent<Rigidbody>();
        rd.AddForce(0, 0, 5);
        Debug.Log("123");
    }
}