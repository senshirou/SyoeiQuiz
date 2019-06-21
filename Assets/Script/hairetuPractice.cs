using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hairetuPractice : MonoBehaviour
{
    public Text arrayText;
  private string[] stringArray = new string[99]; //配列の宣言

    void Start () {
    arrayText.text = ""; //テキストの初期化
    for (int i = 0; i < stringArray.Length; i++)
    {
      stringArray[i] = Random.Range(1, 100).ToString(); //乱数の生成
      arrayText.text = arrayText.text + stringArray[i] + ","; //テキストの上書き
      Debug.Log(stringArray[i]);
    }
    }
}
