namespace DWCG {
    [System.Serializable]
    public class PlayerData {

        public string Name;
        public DeckData[] DeckRecipe;
        public int CurrentRecipeIndex;
        public PlayerRank Rank;
        public int RankPoints;

        public DeckData CurrentRecipe { get { return DeckRecipe[ CurrentRecipeIndex ]; } }

        public PlayerData( string name, DeckData[] recipes ) {
            Name = name;
            DeckRecipe = recipes;
            CurrentRecipeIndex = 0;
        }

        public PlayerData( string name, DeckData[] recipes, int currentRecipe, PlayerRank rank, int rankPoints ) {
            Name = name;
            DeckRecipe = recipes;
            CurrentRecipeIndex = currentRecipe;
            Rank = rank;
            RankPoints = rankPoints;

        }

    }

    public enum PlayerRank { Amateur, Novice, Adept, Expert, Professional }
}