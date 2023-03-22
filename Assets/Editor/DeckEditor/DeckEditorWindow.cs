using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;
using DWCG;

namespace DWCGEditor {
    public class DeckEditorWindow : EditorWindow {

        static DeckData _target;
        
        [MenuItem( "DWCG/Open Deck Editor" )]
        public static void OpenWindow() {
            var window = GetWindow<DeckEditorWindow>();
            window.titleContent = new GUIContent( "Deck Editor" );
            window.minSize = new Vector2( 200, 200 );
            window.Show();
        }

        public static void OpenWindow( DeckData target ) {
            _target = target;
            var window = GetWindow<DeckEditorWindow>();
            window.titleContent = new GUIContent( "Deck Editor" );
            window.minSize = new Vector2( 200, 200 );
            window.Show();
        }

        private void OnEnable() {
            rootVisualElement.Add( DrawWindow() );
        }

        VisualElement DrawWindow() {
            var container = new VisualElement();
            if (!_target) { 
                container.Add( new Label( "Please double click a deck to start editing it" ) ); 
            }
            return container;
        }

    }
}
