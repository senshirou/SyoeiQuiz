using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class QuizManager : MonoBehaviour
{private int[][] intValues;
	private string[][] stringValues;
 
	// Use this for initialization
	void Start () {
		intValues = new int[3][];
 
		intValues [0] = new int[2];
		intValues [1] = new int[3];
		intValues [2] = new int[2];
 
		intValues [0] [0] = 0;
		intValues [0] [1] = 1;
		intValues [1] [0] = 2;
		intValues [1] [1] = 3;
		intValues [1] [2] = 4;
		intValues [2] [0] = 5;
		intValues [2] [1] = 6;
 
		foreach (var lines in intValues) {
			foreach (var line in lines) {
				Debug.Log (line);
			}
		}
 
		int[][][] intValues2 = new int[2][][];
 
		intValues2 [0] = new int[2][];
		intValues2 [1] = new int[2][];
 
		intValues2 [0] [0] = new int[1];
		intValues2 [0] [1] = new int[1];
 
		intValues2 [0] [0] [0] = 0;
 
		stringValues = new string[][] { new string[] { "abc" }, new string[] { "def", "ghi" }, new string[] { "jkl" } };
 
		for (int i = 0; i < stringValues.Length; i++) {
			foreach (var stringValue in stringValues[i]) {
				Debug.Log (i + ":" + stringValue);
			}
		}
 
		string[][] stringValues2 = new string[2][];
 
		stringValues2 [0] = new string[1];
		stringValues2 [1] = new string[2];
 
		stringValues2 [0] [0] = "a";
		stringValues2 [1] [0] = "b";
		stringValues2 [1] [1] = "c";
 
		for (int i = 0; i < stringValues2.Length; i++) {
			foreach (var stringValue2 in stringValues2[i]) {
				Debug.Log (i + ":" + stringValue2);
			}
		}
	}
}
