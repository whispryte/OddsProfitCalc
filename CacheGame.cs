namespace OddsCalcTest;

public class CachedGame
{
    public int Id;
    public DateOnly Date;
    public int LeagueId;
    public int HomeTeamId;
    public int AwayTeamId;
    public byte? ScoreHomeHT;
    public byte? ScoreAwayHT;
    public byte ScoreHomeFT;
    public byte ScoreAwayFT;

    public sapi_SaStatistics? Statistics;
    public Dictionary<short, float>? Odds;

    // Массив минут забитых голов 1-45 - 1ый тайм, 46-90 - второй тайм
    public byte[]? HomeGoalsMinutes;
    public byte[]? AwayGoalsMinutes;

    public string DisplayAh()
    {
        return $"{Id}: {HomeTeamId} {ScoreHomeFT}-{ScoreAwayFT} {AwayTeamId} | {Odds.GetValueOrDefault((short)725)} / {Odds.GetValueOrDefault((short)726)}";
    }
}