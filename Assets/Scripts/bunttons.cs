using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Sprite button,pressed;
    public bool music;
    private Image img;
     void Start(){

        img = GetComponent<Image>();
    }
     void onMouseDown(){
        img.sprite = pressed;
    }
   
}
