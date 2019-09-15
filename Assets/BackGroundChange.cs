using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundChange : MonoBehaviour
{
    //背景イメージの宣言
    
    
    [SerializeField] GameObject Starrysky;
    
    //Set this in the Inspector
    [SerializeField] GameObject Sakura;

    void Start()
    {
        //Fetch the Image from the GameObject
        
    }

    
    
    //桜に変更
    public void SakuraChange()
    {
        Sakura.SetActive(true);
        Starrysky.SetActive(false);
        
    }
    //空に変更
    

    //空に変更
    public void StarryskyChange()
    {
        Sakura.SetActive(false);
        Starrysky.SetActive(true);
        
    }

    //空に変更
    

    

    

    
   

    
}
