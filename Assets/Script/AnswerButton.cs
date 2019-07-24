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

    public string Quiz1 = "±0.1";
    public string Quiz2 = "±0.1";
    public string Quiz3 = "±0.08";
    public string Quiz4 = "±0.15";
    public string Quiz5 = "±0.1";
    public string Quiz6 = "±0.1";
    public string Quiz7 = "±0.15";
    public string Quiz8 = "30μ以下";
    public string Quiz9 = "±25μ";
    public string Quiz10 = "3μ以上";
    public string Quiz11 = "0.8μ以上";
    public string Quiz12 = "3個";
    public string Quiz13 = "25%";
    public string Quiz14 = "±0.05";
    public string Quiz15 = "±0.05";
    public string Quiz16 = "0.02";
    public string Quiz17 = "±0.2";
    public string Quiz18 = "0.02";
    public string Quiz19 = "0.05";
    public string Quiz20 = "0.02";
    public string Quiz21 = "0.02";
    public string Quiz22 = "400を超えるものは、100までの寸法増加ごとに0.05を加える";
    public string Quiz23 = "±0.1";
    public string Quiz24 = "±0.05";
    public string Quiz25 = "±0.05";
    public string Quiz26 = "0.1";
    public string Quiz27 = "w:最小導体間げきを満足し、かつ設計導体間げき値の20%以下。ℓ:その部分の設計導体間げき値を超えてはならない。個数:隣接する導体間に1個以下、かつ100×100mm中に2個までOK";
    public string Quiz28 = "w:仕上がり幅の25%以下 ℓ:仕上がり導体幅以下  個数:X:3y3";
    public string Quiz29 = "w:仕上がり幅の20%以下 ℓ:仕上がり導体幅以下  個数:X=1 Y=2";
    public string Quiz30 = "w:最小導体間げきを満足し、かつ設計導体間げき値の20%以下。ℓ:その部分の設計導体間げき値を超えてはならない。個数:隣接する導体間に1個以下、かつ100×100mm中に2個までOK";
    public string Quiz31 = "w:0.2mm以下。ℓ:その部分の設計導体間げき値を超えてはならない。個数:隣接する導体間に2個以下、かつ100×100mm中に3個までOK";
    public string Quiz32 = "欠損面積の割合:ランド面積の25%以下 、(p):0.05mm以上、(q):0.15mm以上";
    public string Quiz33 = "(a):20%　(b):0.2mm";
    public string Quiz34 = "数字をランダムにする為保留。";
    public string Quiz35 = "数字をランダムにする為保留。";
    public string Quiz36 = "0個";
    public string Quiz37 = "反り:1.0 ねじれ:1.5";
    public string Quiz38 = "8μ";
    public string Quiz39 = "(a):0.05mm以上 (b)穴の接線までは可。";
    public string Quiz40 = "レジストの傷";
    public string Quiz41 = "インク塗布面の色ムラ";
    public string Quiz42 = "0.15";
    public string Quiz43 = "0.8";
    public string Quiz44 = "文字、記号のかすれ、にじみはあってはならない";
    public string Quiz45 = "0.8μ";
    public string Quiz46 = "±0.2";
    public string Quiz47 = "50までの寸法増加毎に0.1加える。";
    public string Quiz48 = "6.0";
    public string Quiz49 = "0.4";
    public string Quiz50 = "3ヶ月";
    public string Quiz51 = "6ヶ月";
    public string Quiz52 = "ベーキング処理して再フラックス";
    public string Quiz53 = "ベーキング処理";










    //正解の配列を宣言
    string[] collect ;

    

    //ボタンのテキストを宣言
    


    // Start is called before the first frame update
    void Start()
    {
        float weight = quiz.weight;
        Debug.Log(weight);
        collect = new string[]{"エッチング →　酸洗　→　フラックス","だめだ","Android",$"{0.2f + weight}mm",Quiz1, Quiz2,  Quiz3,  Quiz4,  Quiz5,  Quiz6,  Quiz7,  Quiz8,  Quiz9,  Quiz10, Quiz11, Quiz12, Quiz13, Quiz14, Quiz15, Quiz16, Quiz17, Quiz18, Quiz19, Quiz20, Quiz21, Quiz22, Quiz23, Quiz24, Quiz25, Quiz26, Quiz27, Quiz28, Quiz29, Quiz30, Quiz31, Quiz32, Quiz33, Quiz34, Quiz35, Quiz36, Quiz37, Quiz38, Quiz39, Quiz40, Quiz41, Quiz42, Quiz43, Quiz44, Quiz45, Quiz46, Quiz47, Quiz48, Quiz49, Quiz50, Quiz51, Quiz52, Quiz53};
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
