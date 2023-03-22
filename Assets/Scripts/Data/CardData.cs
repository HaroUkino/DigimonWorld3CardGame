using UnityEngine;
namespace DWCG {
    public class CardData : ScriptableObject {

        public Sprite CardSprite;
        public ushort ID;
        public CardColor cardColor;

        public sbyte AP;
        public sbyte HP;

        public string CardsDescription;
    }

    public enum CardType { Digimon, Program }
    public enum CardColor { White, Green, Blue, Red, Black, Brown }
}