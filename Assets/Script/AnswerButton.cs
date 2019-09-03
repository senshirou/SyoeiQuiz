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

    TextMeshProUGUI QuizNumber;

    string Quiz1 = "±0.1";
    string Quiz2 = "±0.1";
    string Quiz3 = "±0.08";
    string Quiz4 = "±0.15";
    string Quiz5 = "±0.1";
    string Quiz6 = "±0.1";
    string Quiz7 = "±0.15";
    string Quiz8 = "30μ以下";
    string Quiz9 = "±25μ";
    string Quiz10 = "3μ以上";
    string Quiz11 = "0.8μ以上";
    string Quiz12 = "3個";
    string Quiz13 = "25%";
    string Quiz14 = "±0.05";
    string Quiz15 = "±0.05";
    string Quiz16 = "0.02";
    string Quiz17 = "±0.2";
    string Quiz18 = "0.02";
    string Quiz19 = "0.05";
    string Quiz20 = "0.02";
    string Quiz21 = "0.02";
    string Quiz22 = "400を超えるものは、100までの寸法増加ごとに0.05を加える";
    string Quiz23 = "±0.1";
    string Quiz24 = "±0.05";
    string Quiz25 = "±0.05";
    string Quiz26 = "0.1";
    string Quiz27 = "W:20% X:1個  Y:2個";
    string Quiz28 = "w:仕上がり幅の25%以下 ℓ:仕上がり導体幅以下  個数:X:3y3";
    string Quiz29 = "w:仕上がり幅の20%以下 ℓ:仕上がり導体幅以下  個数:X=1 Y=2";
    string Quiz30 = "X:20%以下。Y:1個以下 Z:2個まで";
    string Quiz31 = "X:0.2mm以下  Y:2個以下  Z:3個まで";
    string Quiz32 = "(o):ランド面積の25%以下 、(p):0.05mm以上、(q):0.15mm以上";
    string Quiz33 = "(a):20%　(b):0.2mm";
    string Quiz34 = "数字をランダムにする為保留。";
    string Quiz35 = "数字をランダムにする為保留。";
    string Quiz36 = "0個";
    string Quiz37 = "反り:1.0 ねじれ:1.5";
    string Quiz38 = "8μ";
    string Quiz39 = "(a):0.05mm以上 (b)穴の接線までは可。";
    string Quiz40 = "レジストの傷";
    string Quiz41 = "インク塗布面の色ムラ";
    string Quiz42 = "0.15";
    string Quiz43 = "0.8";
    string Quiz44 = "文字、記号のかすれ、にじみはあってはならない";
    string Quiz45 = "0.8μ";
    string Quiz46 = "±0.2";
    string Quiz47 = "50までの寸法増加毎に0.1加える。";
    string Quiz48 = "6.0";
    string Quiz49 = "0.4";
    string Quiz50 = "3ヶ月";
    string Quiz51 = "6ヶ月";
    string Quiz52 = "ベーキング処理して再フラックス";
    string Quiz53 = "ベーキング処理";

    QuizPrototype Quiztype;
    











    //正解の配列を宣言
    string[] collect ;

    

    //ボタンのテキストを宣言

    
    


    // Start is called before the first frame update
    void Start()
    {
        QuizNumber = GameObject.Find("QuizNumber").GetComponent<TextMeshProUGUI>();
        Quiztype = GameObject.Find("QuizPrototype").GetComponent<QuizPrototype>();
        float weight = quiz.weight; //
        float Lootweight = quiz.Lootweight;
        Debug.Log(weight);
        //collect = new string[]{"エッチング →　酸洗　→　フラックス","だめだ","Android",$"{0.2f + weight}mm",Quiz1, Quiz2,  Quiz3,  Quiz4,  Quiz5,  Quiz6,  Quiz7,  Quiz8,  Quiz9,  Quiz10, Quiz11, Quiz12, Quiz13, Quiz14, Quiz15, Quiz16, Quiz17, Quiz18, Quiz19, Quiz20, Quiz21, Quiz22, Quiz23, Quiz24, Quiz25, Quiz26, Quiz27, Quiz28, Quiz29, Quiz30, Quiz31, Quiz32, Quiz33, Quiz34, Quiz35, Quiz36, Quiz37, Quiz38, Quiz39, Quiz40, Quiz41, Quiz42, Quiz43, Quiz44, Quiz45, Quiz46, Quiz47, Quiz48, Quiz49, Quiz50, Quiz51, Quiz52, Quiz53};
    }

    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Quiztype.questionIndex);
        
    }

    
    //クイズ解答部分
    public void QuizAns()
    {
        //判定をfalseにする
        bool hantei = false;


        //ボタンのテキストを取得する
        Text AnsButton = GetComponentInChildren<Text>();




        if (QuizNumber.text == "Quiz1") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz1) { hantei = true; } }
        if (QuizNumber.text == "Quiz2") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz2) { hantei = true; } }
        if (QuizNumber.text == "Quiz3") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz3) { hantei = true; } }
        if (QuizNumber.text == "Quiz4") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz4) { hantei = true; } }
        if (QuizNumber.text == "Quiz5") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz5) { hantei = true; } }
        if (QuizNumber.text == "Quiz6") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz6) { hantei = true; } }
        if (QuizNumber.text == "Quiz7") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz7) { hantei = true; } }
        if (QuizNumber.text == "Quiz8") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz8) { hantei = true; } }
        if (QuizNumber.text == "Quiz9") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz9) { hantei = true; } }
        if (QuizNumber.text == "Quiz10") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz10) { hantei = true; } }
        if (QuizNumber.text == "Quiz11") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz11) { hantei = true; } }
        if (QuizNumber.text == "Quiz12") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz12) { hantei = true; } }
        if (QuizNumber.text == "Quiz13") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz13) { hantei = true; } }
        if (QuizNumber.text == "Quiz14") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz14) { hantei = true; } }
        if (QuizNumber.text == "Quiz15") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz15) { hantei = true; } }
        if (QuizNumber.text == "Quiz16") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz16) { hantei = true; } }
        if (QuizNumber.text == "Quiz17") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz17) { hantei = true; } }
        if (QuizNumber.text == "Quiz18") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz18) { hantei = true; } }
        if (QuizNumber.text == "Quiz19") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz19) { hantei = true; } }
        if (QuizNumber.text == "Quiz20") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz20) { hantei = true; } }
        if (QuizNumber.text == "Quiz21") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz21) { hantei = true; } }
        if (QuizNumber.text == "Quiz22") { Debug.Log("HIT"); if (AnsButton.text == $"{0.25f + quiz.weight}mm") { hantei = true; } }
        if (QuizNumber.text == "Quiz22") { Debug.Log("HIT"); if (AnsButton.text == $"{0.30f + quiz.weight}mm") { hantei = true; } }
        if (QuizNumber.text == "Quiz22") { Debug.Log("HIT"); if (AnsButton.text == $"{0.35f + quiz.weight}mm") { hantei = true; } }
        if (QuizNumber.text == "Quiz23") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz23) { hantei = true; } }
        if (QuizNumber.text == "Quiz24") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz24) { hantei = true; } }
        if (QuizNumber.text == "Quiz25") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz25) { hantei = true; } }
        if (QuizNumber.text == "Quiz26") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz26) { hantei = true; } }
        if (QuizNumber.text == "Quiz27") { Debug.Log("HIT"); if (AnsButton.text == "W:20% X:1個  Y:2個") { hantei = true; } }
        if (QuizNumber.text == "Quiz28") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz28) { hantei = true; } }
        if (QuizNumber.text == "Quiz29") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz29) { hantei = true; } }
        if (QuizNumber.text == "Quiz30") { Debug.Log("HIT"); if (AnsButton.text == "X:20%以下。Y:1個以下 Z:2個まで") { hantei = true; } }
        if (QuizNumber.text == "Quiz31") { Debug.Log("HIT"); if (AnsButton.text == "X:0.2mm以下  Y:2個以下  Z:3個まで") { hantei = true; } }
        if (QuizNumber.text == "Quiz32") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz32) { hantei = true; } }
        if (QuizNumber.text == "Quiz33") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz33) { hantei = true; } }
        if (QuizNumber.text == "Quiz34") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz34) { hantei = true; } }
        if (QuizNumber.text == "Quiz35") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz35) { hantei = true; } }
        if (QuizNumber.text == "Quiz36") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz36) { hantei = true; } }
        if (QuizNumber.text == "Quiz37") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz37) { hantei = true; } }
        if (QuizNumber.text == "Quiz38") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz38) { hantei = true; } }
        if (QuizNumber.text == "Quiz39") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz39) { hantei = true; } }
        if (QuizNumber.text == "Quiz40") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz40) { hantei = true; } }
        if (QuizNumber.text == "Quiz41") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz41) { hantei = true; } }
        if (QuizNumber.text == "Quiz42") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz42) { hantei = true; } }
        if (QuizNumber.text == "Quiz43") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz43) { hantei = true; } }
        if (QuizNumber.text == "Quiz44") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz44) { hantei = true; } }
        if (QuizNumber.text == "Quiz45") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz45) { hantei = true; } }
        if (QuizNumber.text == "Quiz46") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz46) { hantei = true; } }
        if (QuizNumber.text == "Quiz47") { Debug.Log("HIT"); if (AnsButton.text == $"±0.3") { hantei = true; } }
        if (QuizNumber.text == "Quiz47") { Debug.Log("HIT"); if (AnsButton.text == $"±0.4") { hantei = true; } }
        if (QuizNumber.text == "Quiz47") { Debug.Log("HIT"); if (AnsButton.text == $"±0.5") { hantei = true; } }
        if (QuizNumber.text == "Quiz48") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz48) { hantei = true; } }
        if (QuizNumber.text == "Quiz49") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz49) { hantei = true; } }
        if (QuizNumber.text == "Quiz50") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz50) { hantei = true; } }
        if (QuizNumber.text == "Quiz51") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz51) { hantei = true; } }
        if (QuizNumber.text == "Quiz52") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz52) { hantei = true; } }
        if (QuizNumber.text == "Quiz53") { Debug.Log("HIT"); if (AnsButton.text == Quiztype.Quiz53) { hantei = true; } }
        if (QuizNumber.text == "Quiz54") { Debug.Log("HIT"); if (AnsButton.text == $"±0.6") { hantei = true; } }
        if (QuizNumber.text == "Quiz54") { Debug.Log("HIT"); if (AnsButton.text == $"±0.7") { hantei = true; } }
        if (QuizNumber.text == "Quiz54") { Debug.Log("HIT"); if (AnsButton.text == $"±0.8") { hantei = true; } }
        if (QuizNumber.text == "Quiz54") { Debug.Log("HIT"); if (AnsButton.text == $"±0.9") { hantei = true; } }
        if (QuizNumber.text == "Quiz54") { Debug.Log("HIT"); if (AnsButton.text == $"±1.0") { hantei = true; } }
        if (QuizNumber.text == "Quiz55") { Debug.Log("HIT"); if (AnsButton.text == $"±1.1") { hantei = true; } }
        if (QuizNumber.text == "Quiz55") { Debug.Log("HIT"); if (AnsButton.text == $"±1.2") { hantei = true; } }






        //ボタンのテキストと正解の配列を判定
        //for (int i = 0; i < collect.Length; i++)
        //{

        //    if(AnsButton.text == collect[i])
        //    {
        //        //テキストと正解の配列がイコールならtrueにする。
        //        hantei = true;
        //    }
        //}

        //hanteiがtrueの場合〇を出力
        if (hantei == true)
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
