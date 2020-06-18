using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

namespace Unity.U2D.Animation.Sample
{
    public class ChangeGritty : MonoBehaviour
    {
        private SpriteResolver resolver;
        List<string> catList = new List<string>();
        List<string> labelList = new List<string>();
        int catIndex = 0;
        int labelIndex = 0;
        // Start is called before the first frame update
        void Start()
        {
            resolver = GetComponent<SpriteResolver>();
            foreach(string cat in resolver.spriteLibrary.spriteLibraryAsset.GetCategoryNames()){
                catList.Add(cat);
                Debug.Log("Categories = " + cat);
            }
            foreach(string lab in resolver.spriteLibrary.spriteLibraryAsset.GetCategoryLabelNames(catList[0])){
                labelList.Add(lab);
                Debug.Log("Label = " + lab);
            }
        }

        public void ChangeCategory(){ //Loop through Gritty Colors
            if(catIndex < catList.Count - 1){
                catIndex++;
            } else {
                catIndex = 0;
            }
            UpdateSprite();
        }

        public void ChangeLabel(){ //Loop through Shirt Colors
            if(labelIndex < labelList.Count - 1){
                labelIndex++;
            } else {
                labelIndex = 0;
            }
            UpdateSprite();
        }

        public void StartHeadbangAnimation(){
            GetComponent<Animator>().SetTrigger("StartHeadbang");
        }

        public void StartDanceAnimation(){
            GetComponent<Animator>().SetTrigger("StartDance");
        }

        public void StartIdleAnimation(){
            GetComponent<Animator>().SetTrigger("Idle");
        }

        void UpdateSprite(){
            resolver.SetCategoryAndLabel(catList[catIndex], labelList[labelIndex]);
        }
    }
}