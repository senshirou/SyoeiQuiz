using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    [SerializeField] TextMeshProUGUI ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Maru(int seikai)
    {
        //正解は10点
        Score += seikai;
        //ScoreText.text = Score.ToString();

        

    }
}
