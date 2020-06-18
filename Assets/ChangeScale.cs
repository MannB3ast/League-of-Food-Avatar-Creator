using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public float scaleShiftFactor = 1.06f;
    private Vector3 defaultPos;
    private void Start() {
        defaultPos = transform.position;
    }
    public void ScaleUp(){
        GetComponent<RectTransform>().sizeDelta *= 1.25f;
        Vector3 newPos = transform.localPosition;
        newPos.x *= scaleShiftFactor;
        transform.localPosition = newPos;
    }

    public void ScaleDown(){
        GetComponent<RectTransform>().sizeDelta /= 1.25f;
        transform.position = defaultPos;
    }
}
