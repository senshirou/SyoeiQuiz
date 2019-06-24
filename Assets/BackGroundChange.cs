using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundChange : MonoBehaviour
{
    //背景イメージの宣言
    [SerializeField] Image background;
    [SerializeField] Sprite forest;
    [SerializeField] Sprite Starrysky;
    [SerializeField] Sprite Sand;
    //Set this in the Inspector
    [SerializeField] Sprite Sakura;

    void Start()
    {
        //Fetch the Image from the GameObject
        
    }

    
    
    //桜に変更
    public void SakuraChange()
    {
        background.sprite = Sakura;
    }
    //空に変更
    public void SkyChange()
    {
        background.sprite = forest;
    }

    //空に変更
    public void StarryskyChange()
    {
        background.sprite = Starrysky;
    }

    //空に変更
    public void SandChange()
    {
        background.sprite = Sand;
    }

    

    

    
   

    
}
