using UnityEditor.Callbacks;
using UnityEditor;
using DWCG;

namespace DWCGEditor {
    public class AssetFileHandler {

        [OnOpenAsset( 1 )]
        public static bool OpenFile( int instanceID, int line ) {
            var obj = EditorUtility.InstanceIDToObject( instanceID );
            if (obj is DeckData data) {
                DeckEditorWindow.OpenWindow( data );
                return true;
            }
            return false;
        }

    }
}
