using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour
{
    public List<Sprite> bgImages = new List<Sprite>();
    int index = 0;
    public void ChangeBG(){
        if(index < bgImages.Count - 1){
                index++;
            } else {
                index = 0;
            }
            UpdateBackground();
    }

    public void UpdateBackground(){
        GetComponent<Image>().sprite = bgImages[index];
    }
}
