namespace Kuhpik
{
    public enum EGamestate
    {
        // Don't change int values in the middle of development.
        // Otherwise all of your settings in inspector can be messed up.

        Loading = 1,
        Menu = 2,
        TapToStart = 3,
        Game = 4,
        Pause = 5,
        Victory = 10,
        Lose = 11,

        CurrencyShared = 100

        // Extend just like that
        //
        // Shop = 20,
        // Settings = 30,
        // Revive = 100
    }
}