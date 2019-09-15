using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtotitle : MonoBehaviour
{
    GameObject background;
    
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("BackGround");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Title()
    {
        Destroy(background);
        SceneManager.LoadScene("PracticeSpace");
        
        
    }
}
