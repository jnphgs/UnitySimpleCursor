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
            [CursorType.Move] = Load("SimpleCursor/Textures/move"),
            [CursorType.Resize_N] = Load("SimpleCursor/Textures/n-resize"),
            [CursorType.Resize_E] = Load("SimpleCursor/Textures/e-resize"),
            [CursorType.Resize_W] = Load("SimpleCursor/Textures/w-resize"),
            [CursorType.Resize_S] = Load("SimpleCursor/Textures/s-resize"),
            [CursorType.Resize_NE] = Load("SimpleCursor/Textures/ne-resize"),
            [CursorType.Resize_NW] = Load("SimpleCursor/Textures/nw-resize"),
            [CursorType.Resize_SE] = Load("SimpleCursor/Textures/se-resize"),
            [CursorType.Resize_SW] = Load("SimpleCursor/Textures/sw-resize"),
            [CursorType.Rotate_N] = Load("SimpleCursor/Textures/n-rotate"),
            [CursorType.Rotate_E] = Load("SimpleCursor/Textures/e-rotate"),
            [CursorType.Rotate_W] = Load("SimpleCursor/Textures/w-rotate"),
            [CursorType.Rotate_S] = Load("SimpleCursor/Textures/s-rotate"),
            [CursorType.Rotate_NE] = Load("SimpleCursor/Textures/ne-rotate"),
            [CursorType.Rotate_NW] = Load("SimpleCursor/Textures/nw-rotate"),
            [CursorType.Rotate_SE] = Load("SimpleCursor/Textures/se-rotate"),
            [CursorType.Rotate_SW] = Load("SimpleCursor/Textures/sw-rotate"),
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
        Move,
        Resize_N,
        Resize_E,
        Resize_W,
        Resize_S,
        Resize_NE,
        Resize_NW,
        Resize_SE,
        Resize_SW,
        Rotate_N,
        Rotate_E,
        Rotate_W,
        Rotate_S,
        Rotate_NE,
        Rotate_NW,
        Rotate_SE,
        Rotate_SW,
    }
}
