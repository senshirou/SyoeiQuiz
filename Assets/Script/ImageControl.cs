using System.Collections;
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
        if (QuizNumber.text == "Quiz3" || QuizNumber.text == "Quiz4")
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            sprite = Resources.Load<Sprite>("Question3_4png");
            QuizImage.sprite = sprite;
        }

        else if(QuizNumber.text == "Quiz8")
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            sprite = Resources.Load<Sprite>("Question8");
            QuizImage.sprite = sprite;
            size.sizeDelta = new Vector2(242.5f, 266.5f);
            

        }

        else
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            
        }



    }

    
}
