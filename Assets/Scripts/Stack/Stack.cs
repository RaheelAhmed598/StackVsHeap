using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stack : MonoBehaviour
{
    public GameObject cubeObj;
    public static Stack<GameObject> cubeStack = new Stack<GameObject>();
    Vector3 Y;
    
    // Start is called before the first frame update
    void Start()
    {
       Y = new Vector3(0, 0.25f, 0);
       //cubeStack.Push(Instantiate(cubeObj, cubeObj.transform.position + Y, Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        Insert();
        Deletion();
    }

    public void Insert()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cubeStack.Push(Instantiate(cubeObj, cubeObj.transform.position + Y, Quaternion.identity));
            Y += new Vector3(0,0.25f,0);
        }
    }

    public void Deletion()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cubeObj = cubeStack.Pop();
            Destroy(cubeObj);
        }
    }
}
