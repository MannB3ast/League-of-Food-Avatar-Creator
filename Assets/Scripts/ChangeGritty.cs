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
        // Start is called before the first frame update
        void Start()
        {
            resolver = GetComponent<SpriteResolver>();
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
            resolver.SetCategoryAndLabel("Yellow Grittys", "Yellow Shirt");
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