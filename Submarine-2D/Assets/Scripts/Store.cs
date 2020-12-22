using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public void BuyCommonItem()
    {
        Debug.Log("Compraste un item COMUN");
    }
    
    public void BuyRareItem()
    {
        Debug.Log("Compraste un item RARO");
    }
    
    public void BuyLegendItem()
    {
        Debug.Log("Compraste un item LEGENDARIO");
    }
    
}
