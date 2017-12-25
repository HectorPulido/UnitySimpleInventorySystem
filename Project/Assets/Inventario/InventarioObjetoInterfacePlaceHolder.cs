using System;
using UnityEngine;
using UnityEngine.UI;


public class InventarioObjetoInterfacePlaceHolder : MonoBehaviour
{ 
    public Image sprite;
    public static InventarioObjetoInterfacePlaceHolder current;

    void Start () {
        if (current != null)
            Destroy(gameObject);

        sprite = GetComponent<Image>();
        current = this;
	}

}
