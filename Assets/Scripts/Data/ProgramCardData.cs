namespace DWCG {
    public class ProgramCardData : CardData {

        public enum ContextEffect {
            CLEAR_HAND_DRAW_SIX,
            CONTROL_ENEMY_DIGIMON,
            FORCE_THREE_CARDS,
            TRASH_TO_DECK,
            DRAW_ONE_DISCARD_ONE,
            CHOOSE_PG_CARD,
            CHOOSE_DG_CARD,
            SWAP_AP_HP,
            NEGATE_PG_CARD,
            REDUCE_ENEMY_AP_TO_ZERO,
            SUMMON_FROM_HAND
        }

        // data
        public ProgramType programType;

        public CardEffect cardEffect;
        public TargetSource targetSource;
        public TargetList targetList;
        public TargetColor targetColor;

        public DigimonCardData SummonData;
        public short EffectValue;
        public bool RandomTargets;
        public sbyte NumberOfTargets;
        public bool Non_Element;
        public ContextEffect ContextFX;
        public byte ContextValue;
    }

    public enum ProgramType { Compile, Both }
    // card effects
    public enum TargetSource { User, Enemy, Both }
    public enum TargetList { Hand, Deck, Trash, Field }
    public enum TargetColor { All, White, Green, Blue, Red, Black, Brown }
    public enum CardEffect { Destroy, RegularDraw, TargetDraw, Summon, PowerMod, SEnergyMod, Damage, Context, ReturnToHand }
}