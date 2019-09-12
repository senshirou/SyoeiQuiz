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
        Debug.Log(transform.position);
        
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

        else if (QuizNumber.text == "Quiz18" || QuizNumber.text == "Quiz19" || QuizNumber.text == "Quiz20")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question18_19_20");
            size.sizeDelta = new Vector2(361f, 361f);
        }

        else if (QuizNumber.text == "Quiz21" || QuizNumber.text == "Quiz22")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question21_22");
            size.sizeDelta = new Vector2(436f,195f);
            transform.position = new Vector2(172.9f,400.3f);
        }

        else if (QuizNumber.text == "Quiz24" || QuizNumber.text == "Quiz25")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question24_25");
            size.sizeDelta = new Vector2(697.7f, 312.6f);
           
        }

        else if (QuizNumber.text == "Quiz26")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question26");
            size.sizeDelta = new Vector2(697.7f, 312.6f);

        }

        else if (QuizNumber.text == "Quiz27" || QuizNumber.text == "Quiz28" || QuizNumber.text == "Quiz29")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question27_28_29");
            size.sizeDelta = new Vector2(697.7f,150.6f);
            transform.position = new Vector2(172.9f,400.3f);

        }

        else if (QuizNumber.text == "Quiz30" || QuizNumber.text == "Quiz31")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question30_31");
            size.sizeDelta = new Vector2(697.7f, 150.6f);
            transform.position = new Vector2(172.9f,380.3f);

        }

        else if (QuizNumber.text == "Quiz32")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question32_33");
            size.sizeDelta = new Vector2(697.7f, 312.6f);

        }

        else if (QuizNumber.text == "Quiz33")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question32_33");
            size.sizeDelta = new Vector2(697.7f, 150.6f);
            transform.position = new Vector2(172.9f,400.3f);

        }

        else if (QuizNumber.text == "Quiz34")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question34");
            size.sizeDelta = new Vector2(697.7f, 312.6f);

        }

        else if (QuizNumber.text == "Quiz37")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question37");
            size.sizeDelta = new Vector2(697.7f, 312.6f);

        }

        else if (QuizNumber.text == "Quiz38")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question38");
            size.sizeDelta = new Vector2(697.7f, 312.6f);

        }

        else if (QuizNumber.text == "Quiz39")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question39");
            size.sizeDelta = new Vector2(242.5f, 266.5f);
            transform.position = new Vector2(172.9f,400.3f);



        }

        else if (QuizNumber.text == "Quiz42" || QuizNumber.text == "Quiz43")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question42_43");
            size.sizeDelta = new Vector2(242.5f, 266.5f);
            transform.position = new Vector2(172.9f,400.3f);



        }

        else if (QuizNumber.text == "Quiz49")
        {
            ImageScale255();
            sprite = Resources.Load<Sprite>("Question49");
            size.sizeDelta = new Vector2(697.7f, 312.6f);


        }


        else
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            transform.position = new Vector2(172.9f,419.3f);

        }



    }

    void ImageScale255()
    {
        QuizImage.sprite = sprite;
        GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        transform.position = new Vector2(172.9f,419.3f);

    }

    
}
