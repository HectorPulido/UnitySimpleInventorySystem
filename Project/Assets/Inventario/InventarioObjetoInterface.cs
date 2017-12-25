using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventarioObjetoInterface : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public Text cantidad;
    public Image sprite;
    public Button boton;
    public int id;

    public InventarioManager manager;

    public static InventarioObjetoInterface arrastrando;

    public void OnBeginDrag(PointerEventData eventData)
    {
        arrastrando = this;
        InventarioObjetoInterfacePlaceHolder.current.sprite.sprite = sprite.sprite;
    }

    public void OnDrag(PointerEventData eventData)
    {
        InventarioObjetoInterfacePlaceHolder.current.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        arrastrando = null;

        InventarioObjetoInterfacePlaceHolder.current.transform.position = new Vector3(10000, 1000, 100);
    }

    public void OnDrop(PointerEventData data)
    {
        if (arrastrando == null)
            return;
        if (arrastrando == this)
            return;

       manager.IntercambiarPuestos(id, arrastrando.id);
    }
}
