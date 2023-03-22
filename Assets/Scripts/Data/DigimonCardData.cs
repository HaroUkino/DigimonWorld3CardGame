namespace DWCG {
    public class DigimonCardData : CardData {

        public DigimonTier digimonTier;
        public SpecialTarget specialTarget;
        public byte SpecialValue;
        public bool BothPlayersCount;

        public DigimonCardData ComboCard;

    }

    public enum DigimonTier { Rookie, Champion, Ultimate, Mega, Special }
    public enum SpecialTarget { Hand, Trash, Field }
}