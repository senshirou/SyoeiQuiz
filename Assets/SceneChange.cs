using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    [SerializeField] GameObject Delete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuizSelect1()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizSceneSection1");
        Delete.SetActive(false);
    }

    public void QuizSelect2()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizSceneSection2");
        Delete.SetActive(false);
    }

    public void QuizSelect3()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizSceneSection3");
        Delete.SetActive(false);
    }

    public void QuizSelect4()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizSceneSection4");
        Delete.SetActive(false);
    }

    public void QuizSelect5()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizSceneSection5");
        Delete.SetActive(false);
    }

    public void QuizSelectKensa()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizSceneSectionKensa");
        Delete.SetActive(false);
    }

    public void QuizSelectAll()
    {
        //シーン切り替え・切り替え時にDelete(BackGround除くすべてのUI)をfalseにする。
        SceneManager.LoadScene("QuizScene");
        Delete.SetActive(false);
    }
}
