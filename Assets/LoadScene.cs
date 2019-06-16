using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, 0);
    }

    public void repeat()
    {
        SceneManager.LoadScene("QuizScene");

    }
}
