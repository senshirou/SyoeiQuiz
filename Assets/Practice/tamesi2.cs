using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamesi2 : MonoBehaviour
{
    public tamesi playerScript;

    void Start(){
    int bCount;
    bCount = playerScript.bulletCount;
    Debug.Log(bCount); //5
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
