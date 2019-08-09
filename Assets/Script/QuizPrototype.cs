using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class QuizPrototype : MonoBehaviour {
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
    public string Quiz27 = "W:20% X:1個  Y:2個";
    public string Quiz28 = "w:仕上がり幅の25%以下 ℓ:仕上がり導体幅以下  個数:X:3y3";
    public string Quiz29 = "w:仕上がり幅の20%以下 ℓ:仕上がり導体幅以下  個数:X=1 Y=2";
    public string Quiz30 = "X:20%以下。Y:1個以下 Z:2個まで";
    public string Quiz31 = "X:0.2mm以下  Y:2個以下  Z:3個まで";
    public string Quiz32 = "(o):ランド面積の25%以下 、(p):0.05mm以上、(q):0.15mm以上";
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



    //リストを作成
    public List<string> questionList;

    

	//Listのインデックスを0に指定
	public int questionIndex = 0;

	//解答用配列を作成
	string[] array;
	//配列arrayをシャッフルする為の配列
	string[] array2;

	//長さの単位
	public float weight;

    bool seigyo;

	

	//ボタンのテキストを指定
	Text labels;
	//問題
	[SerializeField] TextMeshProUGUI Questionlabel;
	//解答の表示
	[SerializeField] TextMeshProUGUI AnswerA;

    [SerializeField] TextMeshProUGUI QuestionNumber;
	//〇と×の宣言
	[SerializeField] Image maru;
	[SerializeField] Image batu;

	//回答ボタン宣言
	[SerializeField] Button answer1;
    [SerializeField] Button answer2;
    [SerializeField] Button answer3;
    [SerializeField] Button answer4;

    AnswerButton Quiz;


    

    

	

	

	// Use this for initialization
	void Start () {


		//リストをシャッフルする
		 questionList = questionList.OrderBy ( a => Guid.NewGuid () ).ToList ();

        //AnswerButtonの配列を取得
        Quiz = GameObject.Find("Answer1").GetComponent<AnswerButton>();

        //stage1()を実行
        stage1();

        //製品寸法1の乱数
        weight = UnityEngine.Random.Range(80,290);
		 
		 //コンソールでweightの数字を出力
		 Debug.Log(weight);

		

       
        
	}

    void Update()
    {
        Quiz = GameObject.Find("Answer1").GetComponent<AnswerButton>();
    }

    // Update is called once per frame
    // void Update () {

    // 	if(Input.GetKeyDown(KeyCode.Space))
    // 	{
    // 		if(questionIndex == questionList.Count)
    // 		{
    // 			//問題が残っていない場合は処理を行わない。
    // 			Debug.Log("NoQuestion List");

    // 			return;
    // 		}

    // 		//問題1
    // 		if(questionList[questionIndex] == "Quiz1")
    // 		{
    // 			Questionlabel.text = "耐熱フラックス工程で製品が流れる順番は（水洗除く）";

    // 			array = new string[]{"エッチング →　酸洗　→　フラックス","酸洗　→　エッチング　→　フラックス","フラックス　→　エッチング　→　酸洗","エッチング　→　フラックス　→　酸洗"};
    // 	        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
    // 			for (int i = 1; i <= array.Length; i++)
    // 			{
    // 				labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
    // 				labels.text = array2[i-1];
    // 			}
    // 		}

    // 		//問題2
    // 		if(questionList[questionIndex] == "Quiz2")
    // 		{
    // 			Questionlabel.text = "この中で鉛が含まれているのは?";
    // 			array = new string[]{"共晶半田","鉛フリー半田","フラックス","無電解金"};
    // 	        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
    // 			for (int i = 1; i <= array.Length; i++)
    // 			{
    // 				labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
    // 				labels.text = array2[i-1];
    // 			}
    // 		}

    // 		//問題3
    // 		if(questionList[questionIndex] == "Quiz3")
    // 		{
    // 			array = new string[]{"Android","IOS","Windows","Ubuntu"};
    // 	        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
    // 			for (int i = 1; i <= array.Length; i++)
    // 			{
    // 				labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
    // 				labels.text = array2[i-1];
    // 			}
    // 		}

    // 		//問題4
    // 		if(questionList[questionIndex] == "Quiz4")
    // 		{

    // 			Questionlabel.text = $"寸法サイズが{weight}mmの時、寸法の許容値は？";
    // 			array = new string[]{$"{0.2f + weight}mm",$"{0.1f + weight}mm",$"{0.5f + weight}mm",$"{1f + weight}mm"};
    // 	        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
    // 			for (int i = 1; i <= array.Length; i++)
    // 			{
    // 				labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
    // 				labels.text = array2[i-1];
    // 			}


    // 		}

    // 		//出題する
    // 		//Debug.Log(questionList[questionIndex]);
    // 		Debug.Log(questionIndex);

    // 		//〇・×のイメージを表示しない、回答ボタンfalse →　true　へ
    // 		maru.enabled = false;
    // 		batu.enabled = false;
    // 		answer1.enabled = true;
    //     	answer2.enabled = true;
    //     	answer3.enabled = true;
    //     	answer4.enabled = true;

    // 		//インデックスを動かす
    // 		questionIndex++;
    // 	}



    // }

    public void stage1()
	{
        seigyo = false;
        
        if (questionIndex == questionList.Count)
			{
				//問題が残っていない場合は処理を行わない
				Debug.Log("NoQuestion List");
				
				
				return;
			}

			////問題1
			//if(questionList[questionIndex] == "Quiz1")
			//{
			//	Questionlabel.text = "耐熱フラックス工程で製品が流れる順番は（水洗除く）";
			//	AnswerA.text = "エッチング →　酸洗　→　フラックス";

			//	array = new string[]{"エッチング →　酸洗　→　フラックス","酸洗　→　エッチング　→　フラックス","フラックス　→　エッチング　→　酸洗","エッチング　→　フラックス　→　酸洗"};
		 //       array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
			//	for (int i = 1; i <= array.Length; i++)
			//	{
			//		labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
			//		labels.text = array2[i-1];
			//	}
			//}

			////問題2
			//if(questionList[questionIndex] == "Quiz2")
			//{
			//	AnswerA.text = "共晶半田";
			//	Questionlabel.text = "この中で鉛が含まれているのは?";
			//	array = new string[] {Quiz.Quiz2, "鉛フリー半田","フラックス","無電解金"};
		 //       array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
			//	for (int i = 1; i <= array.Length; i++)
			//	{
			//		labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
			//		labels.text = array2[i-1];
			//	}
			//}

			////問題3
			//if(questionList[questionIndex] == "Quiz3")
			//{
			//	AnswerA.text = "±0.1";
   //             Questionlabel.text = "プリント板長手方向寸法400mm以下の場合穴ズレの許容差はいくつ？";

   //             array = new string[] {Quiz.Quiz3, "±0.05", "±0.15", "±0.2" };

   //             array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
			//	for (int i = 1; i <= array.Length; i++)
			//	{
			//		labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
			//		labels.text = array2[i-1];
			//	}
			//}

			

   //         //問題5
   //         if (questionList[questionIndex] == "Quiz5")
   //         {
   //             AnswerA.text = "±0.15";
   //             Questionlabel.text = "図に示す基準穴の穴位置(b)>=300mmの許容差はいくつ？";

   //             array = new string[] {Quiz.Quiz5, "±0.05", "±0.15", "±0.2" };
   //             array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
   //             for (int i = 1; i <= array.Length; i++)
   //             {
   //                 labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
   //                 labels.text = array2[i - 1];
   //             }
   //         }

   //         //問題6
   //         if (questionList[questionIndex] == "Quiz6")
   //         {
   //             AnswerA.text = "±0.15";
   //             Questionlabel.text = "図に示す基準穴の穴位置(b)<=150の許容差はいくつ？";

   //             array = new string[] {Quiz.Quiz6, "±0.05", "±0.1", "±0.15" };

   //             array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
   //             for (int i = 1; i <= array.Length; i++)
   //             {
   //                 labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
   //                 labels.text = array2[i - 1];
   //             }
   //         }

            //問題7
            if (questionList[questionIndex] == "Quiz72")
            {
            //AnswerA.text = "±0.15";
            //Questionlabel.text = "図に示す基準穴の穴位置150mm<=(b)<300mmの許容差はいくつ？";

            //array = new string[] { "±0.1", "±0.05", "±0.08", "±0.12" };
            Question72();
            ArrayButton();
            

                //array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
                //for (int i = 1; i <= array.Length; i++)
                //{
                //    labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
                //    labels.text = array2[i - 1];
                //}
            }

            //問題4(修正する）
            if (questionList[questionIndex] == "Quiz74")
            {
                AnswerA.text = $"{0.2f + weight}mm";
                Questionlabel.text = $"寸法サイズが{weight}mmの時、寸法の許容値は？";
                array = new string[] { $"{0.2f + weight}mm", $"{0.1f + weight}mm", $"{0.5f + weight}mm", $"{1f + weight}mm" };
                array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
                for (int i = 1; i <= array.Length; i++)
                {
                    labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
                    labels.text = array2[i - 1];
                }
            }

         //ここからが本題

            if (questionList[questionIndex] == "Quiz1")
            {
                 QuestionNumber.text = "Quiz1" ;
                seigyo = true;
                
                Question1();
                ArrayButton();
            seigyo = false;
            }
            if (questionList[questionIndex] == "Quiz2")
            {
                QuestionNumber.text = "Quiz2";
                AnswerA.text = "±0.1";
                Questionlabel.text = "スルーホールメッキありでΦ0.6～2.0未満の場合、部品穴の穴径許容差はいくつ？";
                array = new string[] { "±0.1", "±0.05", "±0.15", "±0.2" };
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz3")
            {
                QuestionNumber.text = "Quiz3";
                seigyo = true;
                Question3();
                ArrayButton();
            }

            if (questionList[questionIndex] == "Quiz4")
            {
                QuestionNumber.text = "Quiz4";
                seigyo = true;
                Question4();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz5")
            {
                QuestionNumber.text = "Quiz5";
                seigyo = true;
                Question5();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz6")
            {
                QuestionNumber.text = "Quiz6";
                seigyo = true;
                Question6();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz7")
            {
                QuestionNumber.text = "Quiz7";
                Question7();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz8")
            {
                QuestionNumber.text = "Quiz8";
                Question8();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz9")
            {
                QuestionNumber.text = "Quiz9";
                Question9();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz10")
            {
                QuestionNumber.text = "Quiz10";
                Question10();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz11")
            {
                QuestionNumber.text = "Quiz11";
                Question11();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz12")
            {
                QuestionNumber.text = "Quiz12";
                Question12();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz13")
            {
                QuestionNumber.text = "Quiz13";
                Question13();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz14")
            {
                QuestionNumber.text = "Quiz14";
                Question14();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz15")
            {
                QuestionNumber.text = "Quiz15";
                Question15();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz16")
            {
                QuestionNumber.text = "Quiz16";
                Question16();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz17")
            {
                QuestionNumber.text = "Quiz17";
                Question17();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz18")
            {
                QuestionNumber.text = "Quiz18";
                Question18();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz19")
            {
                QuestionNumber.text = "Quiz19";
                Question19();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz20")
            {
                QuestionNumber.text = "Quiz20";
                Question20();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz21")
                {
                QuestionNumber.text = "Quiz21";
                Question21();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz22")
            {
            QuestionNumber.text = "Quiz22";
            Question22();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz23")
            {
                QuestionNumber.text = "Quiz23";
                Question23();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz24")
            {
                QuestionNumber.text = "Quiz24";
                Question24();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz25")
            {
                QuestionNumber.text = "Quiz25";
                Question25();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz26")
            {
                QuestionNumber.text = "Quiz26";
                Question26();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz27")
            {
                QuestionNumber.text = "Quiz27";
                Question27();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz28")
            {
                QuestionNumber.text = "Quiz28";
                Question28();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz29")
            {
                QuestionNumber.text = "Quiz29";
                Question29();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz30")
            {
                QuestionNumber.text = "Quiz30";
                Question30();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz31")
            {
                QuestionNumber.text = "Quiz31";
                Question31();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz32")
            {
                QuestionNumber.text = "Quiz32";
                Question32();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz33")
            {
                QuestionNumber.text = "Quiz33";
                Question33();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz34")
            {
                QuestionNumber.text = "Quiz34";
                Question34();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz35")
            {
                QuestionNumber.text = "Quiz35";
                Question35();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz36")
            {
                QuestionNumber.text = "Quiz36";
                Question36();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz37")
            {
                QuestionNumber.text = "Quiz37";
                Question37();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz38")
            {
                QuestionNumber.text = "Quiz38";
                Question38();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz39")
            {
                QuestionNumber.text = "Quiz39";
                Question39();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz40")
            {
                QuestionNumber.text = "Quiz40";
                Question40();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz41")
            {
                QuestionNumber.text = "Quiz41";
                Question41();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz42")
            {
                QuestionNumber.text = "Quiz42";
                Question42();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz43")
            {
                QuestionNumber.text = "Quiz43";
                Question43();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz44")
            {
                QuestionNumber.text = "Quiz44";
                Question44();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz45")
            {
                QuestionNumber.text = "Quiz45";
                Question45();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz46")
            {
                QuestionNumber.text = "Quiz46";
                Question46();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz47")
            {
                QuestionNumber.text = "Quiz47";
                Question47();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz48")
            {
                QuestionNumber.text = "Quiz48";
                Question48();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz49")
            {
                QuestionNumber.text = "Quiz49";
                Question49();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz50")
            {
                QuestionNumber.text = "Quiz50";
                Question50();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz51")
            {
                QuestionNumber.text = "Quiz51";
                Question51();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz52")
            {
                QuestionNumber.text = "Quiz52";
                Question52();
                ArrayButton();
            }
            if (questionList[questionIndex] == "Quiz53")
            {
                QuestionNumber.text = "Quiz53";
                Question53();
                ArrayButton();
            }
            





        //出題する
        //Debug.Log(questionList[questionIndex]);
        Debug.Log(questionIndex);
			
			//〇・×のイメージを表示しない、回答ボタンfalse →　true　へ
			maru.enabled = false;
			batu.enabled = false;
			answer1.enabled = true;
        	answer2.enabled = true;
        	answer3.enabled = true;
        	answer4.enabled = true;

			//インデックスを動かす
			questionIndex++;
		
		

	}

    void Question72()
    {
        AnswerA.text = "±0.15";
        Questionlabel.text = "図に示す基準穴の穴位置150mm<=(b)<300mmの許容差はいくつ？";

        array = new string[] { "±0.1", "±0.05", "±0.08", "±0.12" };
    }

    void Question1() { AnswerA.text = "±0.1"; Questionlabel.text = "プリント板長手方向寸法400mm以下の場合穴ズレの許容差はいくつ？"; array = new string[] {Quiz1, "±0.05", "±0.15", "±0.2" }; }
    void Question2() { AnswerA.text = "±0.1"; Questionlabel.text = "スルーホールメッキありでΦ0.6～2.0未満の場合、部品穴の穴径許容差はいくつ？"; array = new string[] {Quiz2, "±0.05", "±0.15", "±0.2" }; }
    void Question3() { AnswerA.text = "±0.08"; Questionlabel.text = "図に示す基準穴の穴位置(b)<=150の許容差はいくつ？"; array = new string[] {Quiz3, "±0.05", "±0.1", "±0.15" }; }
    void Question4() { AnswerA.text = "±0.15"; Questionlabel.text = "図に示す基準穴の穴位置(b)>=300mmの許容差はいくつ？"; array = new string[] {Quiz4, "±0.05", "±0.1", "±0.12" }; }
    void Question5() { AnswerA.text = "±0.1"; Questionlabel.text = "図に示す基準穴の穴位置150mm<=(b)<300mmの許容差はいくつ？"; array = new string[] {Quiz5, "±0.05", "±0.08", "±0.12" }; }
    void Question6() { AnswerA.text = "±0.1"; Questionlabel.text = "基準穴の穴径許容差はいくつ？"; array = new string[] {Quiz6, "±0.15", "±0.08", "±0.12" }; }
    void Question7() { AnswerA.text = "±0.15"; Questionlabel.text = "長穴の公差はいくつ？"; array = new string[] {Quiz7, "±0.2", "±0.1", "±0.05" }; }
    void Question8() { AnswerA.text = "30μ以下"; Questionlabel.text = "穴内壁粗さの許容値(ガラスクロスに対して90度方向）はいくつ?"; array = new string[] {Quiz8, "40μ以下", "45μ以下", "25μ以下" }; }
    void Question9() { AnswerA.text = "±25μ"; Questionlabel.text = "板厚1.2mm以上の銅メッキの許容値はいくつ？"; array = new string[] {Quiz9, "±10μ", "±15μ", "±20μ" }; }
    void Question10() { AnswerA.text = "3μ以上"; Questionlabel.text = "ニッケルメッキの厚みはいくつ以上必要？"; array = new string[] {Quiz10, "2μ以上", "4μ以上", "1μ以上" }; }
    void Question11() { AnswerA.text = "0.8μ以上"; Questionlabel.text = "電解金メッキの厚みはいくつ以上必要？"; array = new string[] {Quiz11, "1μ以上", "1.2μ以上", "0.6μ以上" }; }
    void Question12() { AnswerA.text = "3個"; Questionlabel.text = "銅メッキ穴壁面に発生するボイドの許容数は？"; array = new string[] {Quiz12, "2個", "1個", "出てはいけない" }; }
    void Question13() { AnswerA.text = "25%"; Questionlabel.text = "ボイドの大きさは板厚・円周の何%以下まで？"; array = new string[] {Quiz13, "20%", "15%", "10%" }; }
    void Question14() { AnswerA.text = "±0.05"; Questionlabel.text = "図に示す設計最小導体幅に対するその仕上がり後の導体幅(wb,wt)の許容差は"; array = new string[] {Quiz14, "±0.04", "±0.06", "±0.07" }; }
    void Question15() { AnswerA.text = "±0.05"; Questionlabel.text = "図に示す設計最小導体間げきに対するその仕上がり後の導体間げき(d)の許容差は?"; array = new string[] {Quiz15, "±0.04", "±0.06", "±0.07" }; }
    void Question16() { AnswerA.text = "0.02"; Questionlabel.text = "導体から板端までの距離(d)は何mm以上が標準となるか?(プリントコンタクト・グランドは除く）"; array = new string[] {Quiz16, "0.01", "0.03", "0.04" }; }
    void Question17() { AnswerA.text = "±0.2"; Questionlabel.text = "ランド・スルーホールの中心間のズレの許容差はいくつか？"; array = new string[] {Quiz17, "±0.1", "±0.3", "±0.15" }; }
    void Question18() { AnswerA.text = "0.02"; Questionlabel.text = "図に示す、ランドと穴とのズレに起因する最小ランド幅(w)は部品挿入穴で半田面の場合何mm?"; array = new string[] {Quiz18, "0.03", "0.04", "0.05" }; }
    void Question19() { AnswerA.text = "0.05"; Questionlabel.text = "図に示す、ランドと穴とのズレに起因する最小ランド幅(w)は部品挿入穴で部品面の場合何mm?"; array = new string[] {Quiz19, "0.04", "0.03", "0.02" }; }
    void Question20() { AnswerA.text = "0.02"; Questionlabel.text = "図に示す、ランドと穴とのズレに起因する最小ランド幅(w)は導通穴の場合何mm?"; array = new string[] {Quiz20, "0.03", "0.04", "0.05" }; }
    void Question21() { AnswerA.text = "0.02"; Questionlabel.text = "図に示す、基準穴又は基準マークからフットプリントまでの位置(j1)(j2)の許容差はプリント板長手寸法400mm以下の場合何mmか？"; array = new string[] {Quiz21, "0.01", "0.03", "0.04" }; }
    void Question22() { AnswerA.text = "400を超えるものは、100までの寸法増加ごとに0.05を加える"; Questionlabel.text = "図に示す、基準穴又は基準マークからフットプリントまでの位置(j1)(j2)の許容差はプリント板長手寸法400mm以下の場合何mmか？"; array = new string[] {Quiz22, "", "", "" }; }
    void Question23() { AnswerA.text = "±0.1"; Questionlabel.text = "プリントコンタクト(端子メッキ）の中心距離許容差は何mm"; array = new string[] {Quiz23, "±0.2", "±0.05", "±0.15" }; }
    void Question24() { AnswerA.text = "±0.05"; Questionlabel.text = "図に示すプリントコンタクトの端子幅(wt)が1.0mm未満の場合許容差は何mm?"; array = new string[] {Quiz24, "±0.1", "±0.15", "±0.20" }; }
    void Question25() { AnswerA.text = "±0.05"; Questionlabel.text = "図に示すプリントコンタクトの端子幅(wt)が1.0mm以下の場合許容差は何mm?"; array = new string[] {Quiz25, "±0.1", "±0.15", "±0.20" }; }
    void Question26() { AnswerA.text = "0.1"; Questionlabel.text = "図に示すプリントコンタクトの中心感のずれ(f)はいくつか?"; array = new string[] {Quiz26, "0.15", "0.2", "0.3" }; }
    void Question27() { AnswerA.text = "W:20% X:1個  Y:2個"; Questionlabel.text = "図に示す導体幅が0.99～0.50mmの欠損部分は最小導体間げきを満足し、かつ設計導体間隙値の(w)以下で設計導体間げきを超えない事、個数(1導体(X)個以下、100×100m中に(Y)個以下）とする。"; array = new string[]{ "W:20% X:1個  Y:2個", "W:25%  X:2個、Y:2個","W:30%。X:1個、Y:2個","W:20%以下  X:2個  Y:2個"}; }
    void Question28() { AnswerA.text = "w:仕上がり幅の25%以下 ℓ:仕上がり導体幅以下  個数:X:3y3"; array = new string[] {Quiz28, "w:仕上がり幅の30%以下 ℓ:仕上がり導体幅以下  個数:X:3y3", "w:仕上がり幅の20%以下 ℓ:仕上がり導体幅以下  個数:X:3y3", "w:仕上がり幅の30%以下 ℓ:仕上がり導体幅以下  個数:(X)=1 (Y)=2" }; }
    void Question29() { AnswerA.text = "w:仕上がり幅の20%以下 ℓ:仕上がり導体幅以下  個数:X=1 Y=2"; Questionlabel.text = "図に示す導体の幅が0.19mm以下の欠損部分の幅(w)、長さ(ℓ)・個数(1導体(X)個、100×100m中に(Z)個以下）の許容差は？"; array = new string[] {Quiz29, "w:仕上がり幅の25%以下 ℓ:仕上がり導体幅以下  個数: X=3 Y=3", "w:仕上がり幅の20%以下 ℓ:仕上がり導体幅以下  個数:X=3 Y=3", "w:仕上がり幅の30%以下 ℓ:仕上がり導体幅以下  個数:X=1 Y=2" }; }
    void Question30() { AnswerA.text = AnswerA.text = "X:20%以下。Y:1個以下 Z:2個まで"; Questionlabel.text = "導体間げき部が1.0mm未満で図に示す導体残りの時、最小導体間げきを満足し、設計導体導体間げき値の(X)。個数：隣接する導体間に(Y)、かつ100×100mm中に(Z)とする"; array = new string[] { "X:20%以下。Y:1個以下 Z:2個まで", "X:25%以下。Y:2個以下、Y2個まで", "X:20%以下 Y:2個以下 Z:2個まで", "X:30%以下。Y:1個以下  Z:2個まで" };}
    void Question31() { AnswerA.text = "X:0.2mm以下  Y:2個以下  Z:3個まで"; Questionlabel.text = "導体間げき部が1.0mm以上で図に示す導体残りがある場合、導体の残りの幅(X)でその部分の設計導体間隙値を超えてはならない。個体は隣接する導体間に(Y)、かつ100×100mm中に(Z)"; array = new string[] { "X:0.2mm以下  Y:2個以下  Z:3個まで", "X:20%以下  Y:2個以下  Z:2個まで", "X:25%以下  Y:1個以下  Z:2個まで", "X:0.2mm以下。Y:1個以下、Z:2個まで" }; }
    void Question32() { AnswerA.text = "欠損面積の割合:ランド面積の25%以下 、(p):0.05mm以上、(q):0.15mm以上"; Questionlabel.text = "図に示すようなランドの欠損に起因する欠損面積(o)、残り幅(p)、(q)、突起(w)の許容値は"; array = new string[] {Quiz32, "(o):ランド面積の30%以下 、(p):0.05mm以上、(q):0.25mm以上", "(o):ランド面積の20%以下 、(p):0.05mm以上、(q):0.12mm以上", "(o):ランド面積の25%以下 、(p):0.10mm以上、(q):0.15mm以上" }; }
    void Question33() { AnswerA.text = "(a):20%　(b):0.2mm"; Questionlabel.text = "ランドの突起(w)は隣接する導体間隙が1.0mm未満の時、最小導体間隙の値を満足かつ導体間げきの(a)以下。導体間隙1.0mm以上は(b)以下。"; array = new string[] {Quiz33, "(a):25%　(b):0.2mm", "(a):15%　(b):0.15mm", "(a):20%　(b):0.15mm" }; }
    void Question34() { AnswerA.text = "ランダム問題の為現在作成中。"; array = new string[] {Quiz34, "", "", "" }; }
    void Question35() { AnswerA.text = "ランダム問題の為現在作成中"; array = new string[] {Quiz35, "", "", "" }; }
    void Question36() { AnswerA.text = "0個"; Questionlabel.text = "導体表面の膨れ、しわ、き裂、導体の浮き等実用上有害な凸凹の許容数は？"; array = new string[] {Quiz36, "1個", "2個", "3個" }; }
    void Question37() { AnswerA.text = "反り:1.0 ねじれ:1.5"; Questionlabel.text = "反り・ねじれの値(h)mmの許容差は？"; array = new string[] {Quiz37, "反り:1.5 ねじれ:2.0", "反り:0.7 ねじれ:1.0", "反り:1.0 ねじれ:2.0" }; }
    void Question38() { AnswerA.text = "8μ"; Questionlabel.text = "レジストインクの膜厚は導体上平均何μ以上必要か。"; array = new string[] {Quiz38, "7μ", "6μ", "5μ" }; }
    void Question39() { AnswerA.text = "(a):0.05mm以上 (b)穴の接線までは可。"; Questionlabel.text = "図に示すソルダレジストのズレで、半田付けに有効な仕上がり後の最小ランド幅(mm)は、半田面は(a)、部品面は(b)"; array = new string[] {Quiz39, "(a):0.05mm以上 (b)0.02m以上", "(a)穴の接線までは可 (b)0.05mm以上", "(a):0.02mm以上 (b)0.05mm以上" }; }
    void Question40() { AnswerA.text = "レジストの傷"; Questionlabel.text = "ソルダレジストの欠陥で不良にならないのはどれか"; array = new string[] {Quiz40, "レジスト剥がれによる銅の露出", "外観を著しく損なう塗りムラ", "導電性異物混入" }; }
    void Question41() { AnswerA.text = "インク塗布面の色ムラ"; Questionlabel.text = "ソルダレジストの欠陥で不良にならないものはどれか"; array = new string[] {Quiz41, "極端なハレーション・裏露光", "導体間を跨る異物混入", "スルーホール内及びランドにインク" }; }
    void Question42() { AnswerA.text = "0.15"; Questionlabel.text = "シルク印刷において文字の線幅は何mm以上を推奨するか？"; array = new string[] {Quiz42, "0.10", "0.05", "0.20" }; }
    void Question43() { AnswerA.text = "0.8"; Questionlabel.text = "シルク印刷において文字の高さは何mm以上を推奨するか"; array = new string[] {Quiz43, "0.3", "0.5", "1.0" }; }
    void Question44() { AnswerA.text = "文字、記号のかすれ、にじみはあってはならない"; Questionlabel.text = "シンボルの規格で間違っているのはどれ？"; array = new string[] {Quiz44, "社章・ロゴ等のかすれにじみはあってはならない", "文字・記号及びかすれ、消えは修正を容認する。", "シルクのずれは実用上支障を及ぼさない範囲であること。" }; }
    void Question45() { AnswerA.text = "0.8μ"; Questionlabel.text = "半田・鉛フリー半田の厚みに規定は無いが狙いとしは最小何μ以上か。"; array = new string[] {Quiz45, "1μ", "1.5μ", "3μ" }; }
    void Question46() { AnswerA.text = "±0.2"; Questionlabel.text = "外形寸法が100mm未満の許容差(mm)は?"; array = new string[] {Quiz46, "±0.1", "±0.4", "±0.3" }; }
    void Question47() { AnswerA.text = "ランダム問題の為現在作成中"; array = new string[] {Quiz47, "", "", "" }; }
    void Question48() { AnswerA.text = "6.0"; Questionlabel.text = "ルーター加工の丸穴は何mm以上が加工範囲か"; array = new string[] {Quiz48, "5.5", "6.05", "5.55" }; }
    void Question49() { AnswerA.text = "0.4"; Questionlabel.text = "VカットはV溝中心からパターンまでの必要距離は何mmか？"; array = new string[] {Quiz49, "0.2", "0.3", "0.5" }; }
    void Question50() { AnswerA.text = "3ヶ月"; Questionlabel.text = "プリフラックス製品の推奨保管期限はいくつか？"; array = new string[] {Quiz50, "6ヶ月", "9ヶ月", "1ヶ月" }; }
    void Question51() { AnswerA.text = "6ヶ月"; Questionlabel.text = "半田レベラー等表面処理に金属を含む製品の推奨保管期限はいくつか？"; array = new string[] {Quiz51, "3ヶ月", "9ヶ月", "1ヶ月" }; }
    void Question52() { AnswerA.text = "ベーキング処理して再フラックス"; Questionlabel.text = "プリフラック製品の保管期限6ヶ月以上過ぎた場合の正しい対応を選べ。"; array = new string[] {Quiz52, "再フラックス", "製品を処分する", "ベーキング" }; }
    void Question53() { AnswerA.text = "ベーキング処理"; Questionlabel.text = "半田レベラー等表面処理に6ヶ月以上過ぎた場合の正しい対応を選べ"; array = new string[] {Quiz53, "ベーキング後再処理", "製品を処分", "再フラックス" }; }



    void ArrayButton()
    {
        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
        for (int i = 1; i <= array.Length; i++)
        {
            labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
            labels.text = array2[i - 1];
        }

    }



	

	

	

	
}
