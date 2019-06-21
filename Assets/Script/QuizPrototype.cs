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
	float weight;

	//ボタンのテキストを指定
	Text labels;

	[SerializeField] TextMeshProUGUI Questionlabel;

	// Use this for initialization
	void Start () {

		//リストをシャッフルする
		 questionList = questionList.OrderBy ( a => Guid.NewGuid () ).ToList ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(questionIndex == questionList.Count)
			{
				//問題が残っていない場合は処理を行わない。
				Debug.Log("NoQuestion List");
				
				return;
			}

			if(questionList[questionIndex] == "Quiz1")
			{
				Questionlabel.text = "メッシュで表示した";

				array = new string[]{"これは","いいよ","とっても","すごい"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			if(questionList[questionIndex] == "Quiz2")
			{
				array = new string[]{"だが","しかし","これだと","だめだ"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			if(questionList[questionIndex] == "Quiz3")
			{
				array = new string[]{"Android","IOS","Windows","Ubuntu"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			if(questionList[questionIndex] == "Quiz4")
			{
				weight = UnityEngine.Random.Range(80,290);
				array = new string[]{$"{0.2f + weight}",$"{0.2f + weight}",$"{0.2f + weight}",$"{0.2f + weight}"};
		        array2 = array.OrderBy(a => Guid.NewGuid()).ToArray();
				for (int i = 1; i <= array.Length; i++)
				{
					labels = GameObject.Find("Quiz/Answer" + i).GetComponentInChildren<Text>();
					labels.text = array2[i-1];
				}
			}

			//出題する
			//Debug.Log(questionList[questionIndex]);
			Debug.Log(questionIndex);

			//インデックスを動かす
			questionIndex++;
		}

		
		
	}

	

	
}
