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
        //Result.text = SManager.Score.ToString() + " / " + TotalS.questionIndex.ToString();
        
        //割り算をするため
        float Scorei = (float)SManager.Score;
        float TotalSS = (float)TotalS.questionIndex;
        float CorrectP = Scorei / TotalSS * 100;

        //結果の表示
        Result.text = CorrectP.ToString("F0") + "%";


        //判定テキスト
        switch(CorrectP)
        {
            case float i when i == 100:
            Level.text = "完璧";
            Level.color = Color.yellow;
            break;
            case float i when i >= 75f:
            Level.text = "優秀";
            Level.color = Color.blue;
            break;
            case float i when i >= 50f:
            Level.text = "普通";
            break;
            case float i when i >= 25f:
            Level.text = "不勉";
            Level.color = Color.red;
            break;
            case float i when i >= 0:
            Level.text = "無知";
            Level.color = Color.red;
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
