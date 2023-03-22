using System.Collections.Generic;
using UnityEngine;
namespace DWCG {
    [CreateAssetMenu( fileName = "New Deck", menuName = "Create Deck" )]
    public class DeckData : ScriptableObject {

        public string DeckName;

        public string DeckOwner;

        // public DeckTyype deckType; 40 cards|50 cards

        public CardData[] Deck;
        public int[] Amount;

        public bool GotBrownCard() {
            for (int i = 0; i < Deck.Length; i++) {
                if (Deck[ i ] != null && Deck[ i ].cardColor == CardColor.Brown)
                    return true;
            }
            return false;
        }

        public List<CardData> GetAsList() {
            List<CardData> list = new List<CardData>();
            for (int i = 0; i < Deck.Length; i++) {
                if (Deck[ i ] != null) {
                    for (int j = 0; j < Amount[ i ]; j++)
                        list.Add( Deck[ i ] );
                }
            }
            return list;
        }
    }
}