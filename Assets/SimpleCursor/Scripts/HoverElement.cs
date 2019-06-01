using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SimpleCursor{

    public class HoverElement : MonoBehaviour
        , IPointerClickHandler
         , IDragHandler
         , IPointerEnterHandler
         , IPointerExitHandler
    {
        public Text text;
        public CursorType Type;

        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnValidate() // call in editor
        {
            if (text != null)
            {
                text.text = Type.ToString();
            }
            gameObject.name = Type.ToString();
        }

        public void OnDrag(PointerEventData eventData)
        {

        }

        public void OnPointerClick(PointerEventData eventData)
        {

        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            CursorUtilities.ChangeCursor(Type);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            CursorUtilities.ChangeCursor(CursorType.Default);
        }
    }


}