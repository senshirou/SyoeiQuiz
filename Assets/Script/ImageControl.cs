using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageControl : MonoBehaviour
{
    [SerializeField] Image QuizImage;
    [SerializeField] TextMeshProUGUI QuizNumber;
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        
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

        else
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }



    }

    
}
