using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpriteControl : MonoBehaviour
{
    SpriteRenderer sp;

    [SerializeField] TextMeshProUGUI QuizNumber;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (QuizNumber.text == "Quiz3" || QuizNumber.text == "Quiz4" || QuizNumber.text == "Quiz5")
        {
            StandardPosition();
            transform.localScale = new Vector2(1.3f,1.3f);
            sp.sprite = Resources.Load<Sprite>("Question3_4png");
        }

        else if (QuizNumber.text == "Quiz8")
        {
            StandardPosition();
            transform.localScale = new Vector2(1.5f,1.5f);
            sp.sprite = Resources.Load<Sprite>("Question8");
        }

        else if (QuizNumber.text == "Quiz9")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question9");
            transform.localScale = new Vector2(1f,0.7f);
            
        }

        else if (QuizNumber.text == "Quiz12")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question12");
            transform.localScale = new Vector2(1f,0.7f);
        }

         else if (QuizNumber.text == "Quiz14" || QuizNumber.text == "Quiz15")
        {
            
            sp.sprite = Resources.Load<Sprite>("Question14_15");
            transform.position = new Vector3(-0.03f,1.59f,0.8827f);
            transform.localScale = new Vector2(0.8f,0.8f);
        }

        else if (QuizNumber.text == "Quiz18" || QuizNumber.text == "Quiz19" || QuizNumber.text == "Quiz20")
        {
            transform.position = new Vector3(-0.03f,1.56f,0.8827f);
            sp.sprite = Resources.Load<Sprite>("Question18_19_20");
            transform.localScale = new Vector2(0.6f,0.6f);
        }

        else if (QuizNumber.text == "Quiz21" || QuizNumber.text == "Quiz22")
        {
            sp.sprite = Resources.Load<Sprite>("Question21_22");
            transform.position = new Vector3(-0.03f,1.30f,0.8827f);
            transform.localScale = new Vector2(0.6f,0.6f);
        }

        else if (QuizNumber.text == "Quiz24" || QuizNumber.text == "Quiz25")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question24_25");
           
        }

        else if (QuizNumber.text == "Quiz26")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question26");

        }

        else if (QuizNumber.text == "Quiz27" || QuizNumber.text == "Quiz28" || QuizNumber.text == "Quiz29")
        {
            sp.sprite = Resources.Load<Sprite>("Question27_28_29");
            transform.position = new Vector3(-0.03f,1.65f,0.8827f);

        }

        else if (QuizNumber.text == "Quiz30" || QuizNumber.text == "Quiz31")
        {
            sp.sprite = Resources.Load<Sprite>("Question30_31");
            transform.position = new Vector3(-0.03f,0.88f,0.8827f);
            transform.localScale = new Vector2(0.6f,0.6f);

        }

        else if (QuizNumber.text == "Quiz32")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question32_33");
        }

        else if (QuizNumber.text == "Quiz33")
        {
            
            sp.sprite = Resources.Load<Sprite>("Question32_33");
            transform.position = new Vector3(-0.03f,1.36f,0.8827f);
        }

        else if (QuizNumber.text == "Quiz37")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question37");

        }

        else if (QuizNumber.text == "Quiz38")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question38");

        }

        else if (QuizNumber.text == "Quiz39")
        {
            sp.sprite = Resources.Load<Sprite>("Question39");
            transform.position = new Vector3(-0.03f,1.5f,0.8827f);



        }

        else if (QuizNumber.text == "Quiz42" || QuizNumber.text == "Quiz43")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question42_43");
        }

        else if (QuizNumber.text == "Quiz49")
        {
            StandardPosition();
            sp.sprite = Resources.Load<Sprite>("Question49");
        }

        else
        {
            sp.sprite = null;
            transform.localScale = new Vector2(1,1);
            StandardPosition();

        }
        
    }

    void StandardPosition()
    {
        transform.position = new Vector3(-0.03f,1.96f,0.8827f);
    }

    
}
