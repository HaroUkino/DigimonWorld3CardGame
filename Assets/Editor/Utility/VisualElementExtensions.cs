using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;

namespace DWCGEditor {
    public static class VisualElementExtensions {
        
        public static VisualElement AddRange( this VisualElement target, params VisualElement[] elements ) {
            foreach (var element in elements) 
                target.Add( element );
            return target;
        }

        public static VisualElement SetWidth( this VisualElement target, int width ) {
            target.style.width = width;
            return target;
        }

        public static void SetWidth( int width, params VisualElement[] elements ) {
            foreach (var element in elements)
                element.SetWidth( width );
        }

        public static VisualElement SetBorder( this VisualElement target, int radius, int width, Color color ) {
            var style = target.style;
            style.borderBottomColor = style.borderLeftColor = style.borderTopColor = style.borderRightColor = color;
            style.borderBottomLeftRadius = style.borderBottomRightRadius = style.borderTopRightRadius = style.borderTopLeftRadius = radius;
            style.borderBottomWidth = style.borderLeftWidth = style.borderTopWidth = style.borderRightWidth = width;
            return target;
        }

    }
}
