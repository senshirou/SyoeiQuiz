using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    //判定のオブジェクトを挿入
    [SerializeField] Image maru;
    [SerializeField] Image batu;
    //AnswerButton1～4を取得
    [SerializeField] Button answer1;
    [SerializeField] Button answer2;
    [SerializeField] Button answer3;
    [SerializeField] Button answer4;
    [SerializeField] QuizPrototype  quiz;

    [SerializeField] TextMeshProUGUI AnswerA;

    

    

    

    //正解の配列を宣言
    string[] collect ;

    

    //ボタンのテキストを宣言
    


    // Start is called before the first frame update
    void Start()
    {
        float weight = quiz.weight;
        Debug.Log(weight);
        collect = new string[]{"エッチング →　酸洗　→　フラックス","だめだ","Android",$"{0.2f + weight}mm","共晶半田"} ;
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    
    //クイズ解答部分
    public void QuizAns()
    {
        //判定をfalseにする
        bool hantei = false;


        //ボタンのテキストを取得する
        Text AnsButton = GetComponentInChildren<Text>();


        //ボタンのテキストと正解の配列を判定
        for (int i = 0; i < collect.Length; i++)
        {

            if(AnsButton.text == collect[i])
            {
                //テキストと正解の配列がイコールならtrueにする。
                hantei = true;
            }
        }

        //hanteiがtrueの場合〇を出力
        if(hantei == true)
        {
            Answermaru();
           
        }

        //そうでない場合は×出力
        else
        {
            Answerbatu();
            
        }
        
        
    }

    void Answerbatu()
    {
        batu.enabled = true;
        AnswerA.enabled = true;
        Buttonfalse();
        Invoke("NextQuiz",2f);
        
        
    }

    void Answermaru()
    {
        maru.enabled = true;
        Buttonfalse();
        Invoke("NextQuiz",2f);
        
        
    }

    void Buttonfalse()
    {
        answer1.enabled = false;
        answer2.enabled = false;
        answer3.enabled = false;
        answer4.enabled = false;
        

    }

    void NextQuiz()
    {
        AnswerA.enabled = false;
        quiz.stage1();
    }

    
   
    
}
