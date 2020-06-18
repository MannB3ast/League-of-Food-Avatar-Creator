using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;
using UnityEngine.UI;

namespace Unity.U2D.Animation.Sample
{
    public class ChangeGritty : MonoBehaviour
    {
        private SpriteResolver resolver;
        private SpriteLibraryAsset currentSpriteLibrary;
        // Start is called before the first frame update
        void Start()
        {
            resolver = GetComponent<SpriteResolver>();
            currentSpriteLibrary = resolver.spriteLibrary.spriteLibraryAsset;
        }

        internal void UpdateSelectionChoice()
        {
            // var options = new List<Dropdown.OptionData>(spriteLibraries.Length);
            // for (int i = 0; i < spriteLibraries.Length; ++i)
            // {
            //     options.Add(new Dropdown.OptionData(spriteLibraries[i].name));
            // }
        }

        public void ToggleGritty(){
            IEnumerator<string> catList = currentSpriteLibrary.GetCategoryNames().GetEnumerator();
            IEnumerable<string> labelList = currentSpriteLibrary.GetCategorylabelNames(catList.Current);
            catList.MoveNext(); //iterate to next category
            resolver.SetCategoryAndLabel(catList.Current, "Yellow Shirt");
            
            // if(index < spriteLibraries.Length - 1){
            //     index++;
            // } else {
            //     index = 0;
            // }

            // Debug.Log("My current Gritty is = " + spriteLibraries[index].name);
        }

        public void ToggleCategory(){

        }
    }

}