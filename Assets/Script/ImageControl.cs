﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageControl : MonoBehaviour
{
    [SerializeField] Image QuizImage;
    [SerializeField] TextMeshProUGUI QuizNumber;
    RectTransform size;
    
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        size = GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (QuizNumber.text == "Quiz3" || QuizNumber.text == "Quiz4" || QuizNumber.text == "Quiz5")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question3_4png");
            size.sizeDelta = new Vector2(697.7f, 312.6f);
        }

        else if(QuizNumber.text == "Quiz8")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question8");
            size.sizeDelta = new Vector2(242.5f, 266.5f);
           
        }

        else if (QuizNumber.text == "Quiz9")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question9");
            size.sizeDelta = new Vector2(697.7f, 312.6f);
        }

        else if (QuizNumber.text == "Quiz12")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question12");
            size.sizeDelta = new Vector2(353.6f, 312.6f);
        }

        else if (QuizNumber.text == "Quiz14" || QuizNumber.text == "Quiz15")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question14_15");
            size.sizeDelta = new Vector2(697.7f, 312.6f);
        }

        else
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            
        }



    }

    void ImageScale255()
    {
        QuizImage.sprite = sprite;
        GetComponent<Image>().color = new Color32(255, 255, 255, 255);

    }

    
}
