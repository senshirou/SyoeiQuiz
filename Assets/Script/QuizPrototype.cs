using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class QuizPrototype : MonoBehaviour {

    
	
	//リストを作成
	[SerializeField] List<string> questionList;

    

	//Listのインデックスを0に指定
	int questionIndex = 0;

	//解答用配列を作成
	string[] array;
	//配列arrayをシャッフルする為の配列
	string[] array2;

	//長さの単位
	public float weight;

	

	//ボタンのテキストを指定
	Text labels;
	//問題
	[SerializeField] TextMeshProUGUI Questionlabel;
	//解答の表示
	[SerializeField] TextMeshProUGUI AnswerA;
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
		 
		 //製品寸法1の乱数
		 weight = UnityEngine.Random.Range(80,290);
		 
		 //コンソールでweightの数字を出力
		 Debug.Log(weight);

		//stage1()を実行
		 stage1();

       
        
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
		if(questionIndex == questionList.Count)
			{
				//問題が残っていない場合は処理を行わない
				Debug.Log("NoQuestion List");
				
				
				return;
			}

			//問題1
			if(questionList[questionIndex] == "Quiz1")
			{
				Questionlabel.text = "耐熱フラックス工程で製品が流れる順番は（水洗除く）";
				AnswerA.text = "エッチング →　酸洗　→　フラックス";

				array = new string[]{"エッチング →　酸洗　→　フラックス","酸洗　→　エッチング　→　フラックス","フラックス　→　エッチング　→　酸洗","エッチング　→　フラックス　→　酸洗"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			//問題2
			if(questionList[questionIndex] == "Quiz2")
			{
				AnswerA.text = "共晶半田";
				Questionlabel.text = "この中で鉛が含まれているのは?";
				array = new string[] {Quiz.Quiz2, "鉛フリー半田","フラックス","無電解金"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			//問題3
			if(questionList[questionIndex] == "Quiz3")
			{
				AnswerA.text = "±0.1";
                Questionlabel.text = "プリント板長手方向寸法400mm以下の場合穴ズレの許容差はいくつ？";

                array = new string[] {Quiz.Quiz3, "±0.05", "±0.15", "±0.2" };

                array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			//問題4
			if(questionList[questionIndex] == "Quiz4")
			{
				AnswerA.text = $"{0.2f + weight}mm";
				Questionlabel.text = $"寸法サイズが{weight}mmの時、寸法の許容値は？";
				array = new string[]{$"{0.2f + weight}mm",$"{0.1f + weight}mm",$"{0.5f + weight}mm",$"{1f + weight}mm"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

            //問題5
            if (questionList[questionIndex] == "Quiz5")
            {
                AnswerA.text = "±0.1";
                Questionlabel.text = "図に示す基準穴の穴位置(b)>=300mmの許容差はいくつ？";

                array = new string[] {Quiz.Quiz5, "±0.05", "±0.15", "±0.2" };
                array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
                for (int i = 1; i <= array.Length; i++)
                {
                    labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
                    labels.text = array2[i - 1];
                }
            }

            //問題6
            if (questionList[questionIndex] == "Quiz6")
            {
                AnswerA.text = "±0.15";
                Questionlabel.text = "図に示す基準穴の穴位置(b)>=300mmの許容差はいくつ？";

                array = new string[] {Quiz.Quiz6, "±0.05", "±0.1", "±0.12" };

                array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
                for (int i = 1; i <= array.Length; i++)
                {
                    labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
                    labels.text = array2[i - 1];
                }
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

	

	

	

	
}
