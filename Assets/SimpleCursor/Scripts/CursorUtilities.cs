using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleCursor
{
    public static class CursorUtilities
    {
        private readonly static Dictionary<CursorType, Texture2D> resources = new Dictionary<CursorType, Texture2D>()
        {
            [CursorType.Default] = Load("SimpleCursor/Textures/default"),
            [CursorType.Resize_N] = Load("SimpleCursor/Textures/n-resize"),
            [CursorType.Resize_E] = Load("SimpleCursor/Textures/e-resize"),
            [CursorType.Resize_W] = Load("SimpleCursor/Textures/w-resize"),
            [CursorType.Resize_S] = Load("SimpleCursor/Textures/s-resize"),
        };

        private static Texture2D Load(string filename)
        {
            var tex = Resources.Load<Texture2D>(filename);
            return tex;
        }

        public static void ChangeCursor(CursorType cursor)
        {
            if(cursor == CursorType.Default)
            {
                Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
            }
            else
            {
                var tex = resources[cursor];

                Cursor.SetCursor(tex, new Vector2(0.5f * tex.width, 0.5f * tex.height), CursorMode.Auto);
            }
        }
    }

    public enum CursorType
    {
        Default,
        Resize_N,
        Resize_E,
        Resize_W,
        Resize_S,
    }
}
