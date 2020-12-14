using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponButtonHandler : MonoBehaviour
{
    public void ChangeWeapon()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        print("Arma cambiada a: "+ txt.text); 
    }
}
