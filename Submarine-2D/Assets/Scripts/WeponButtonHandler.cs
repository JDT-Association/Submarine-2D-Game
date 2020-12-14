using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeponButtonHandler : MonoBehaviour
{
    public void ChangeWepon()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        print("Arma cambiada a: "+ txt.text); 
    }
}
