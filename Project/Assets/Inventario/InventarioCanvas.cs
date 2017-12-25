using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioCanvas : MonoBehaviour {

    public GameObject Inventario;

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventario.SetActive(!Inventario.activeInHierarchy);
        }
	}
}
