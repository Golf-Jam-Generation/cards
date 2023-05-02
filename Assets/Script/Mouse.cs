using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public int ScaleCursor = 64;
    public Texture2D cursorMano, cursorNormal;
    Texture2D cursorActivo;
    void Start()
    {
        Cursor.visible = true;
        CambiarCursor("normal");
    }

    public void CambiarCursor(string tipoCursor)
    {
        if (tipoCursor == "normal")
        {
            cursorActivo = cursorNormal;
        }
        if (tipoCursor == "mano")
        {
            cursorActivo = cursorMano;
        }

    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, ScaleCursor, ScaleCursor), cursorActivo);

    }
}
