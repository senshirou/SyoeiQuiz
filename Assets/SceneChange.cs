﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    [SerializeField] GameObject Delete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuizSelect()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizScene");
        Delete.SetActive(false);
    }
}
