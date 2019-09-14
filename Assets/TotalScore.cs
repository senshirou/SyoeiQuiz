using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore : MonoBehaviour
{
    [SerializeField] QuizPrototype TotalS;
    [SerializeField] ScoreManager SManager;

    [SerializeField] TextMeshPro Level;

    TextMeshPro Result;
    // Start is called before the first frame update
    void Start()
    {

        Result = GetComponent<TextMeshPro>();
        Result.text = SManager.Score.ToString() + " / " + TotalS.questionIndex.ToString();

        //割り算をするため
        float Scorei = (float)SManager.Score;
        float TotalSS = (float)TotalS.questionIndex;
        float CorrectP = Scorei / TotalSS;

        //判定テキスト
        switch(CorrectP)
        {
            case float i when i == 1:
            Level.text = "完璧";
            break;
            case float i when i >= 0.75f:
            Level.text = "優秀";
            break;
            case float i when i >= 0.50f:
            Level.text = "普通";
            break;
            case float i when i >= 0.25f:
            Level.text = "不勉";
            break;
            case float i when i >= 0:
            Level.text = "無知";
            break;
            default:
            Level.text = "なし";
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
