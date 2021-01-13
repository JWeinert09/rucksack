using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D texture;
    public CursorMode mode = CursorMode.Auto;
    public Vector2 spot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(texture, spot, mode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
