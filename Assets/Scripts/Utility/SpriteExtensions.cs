using UnityEngine;

namespace DWCG {
    public static class SpriteExtensions {

        public static Texture2D GetSpriteTexture( this Sprite sprite ) {
            Texture2D currentTexture = new Texture2D( ( int )sprite.rect.width, ( int )sprite.rect.height );
            Color[] pixels = sprite.texture.GetPixels( ( int )sprite.textureRect.x, ( int )sprite.textureRect.y, ( int )sprite.textureRect.width, ( int )sprite.textureRect.height );
            currentTexture.SetPixels( pixels );
            currentTexture.Apply();
            return currentTexture;
        }

    }
}
