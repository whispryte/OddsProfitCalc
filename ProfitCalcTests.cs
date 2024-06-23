using MessagePack;

namespace OddsCalcTest;

[TestClass]
public class ProfitCalcTests 
{
    async Task<List<CachedGame>> LoadFromFile(string path)
    {
        await using var openFile = File.OpenRead(path);
        var data2 = await MessagePackSerializer.DeserializeAsync<List<CachedGame>>(openFile, MessagePack.Resolvers.ContractlessStandardResolver.Options);
        return data2;
    }

    [TestMethod]
    public async Task TestProfit()
    {
        const int teamId = 44;
        var games = (await LoadFromFile("test_games.bin"))
            .Where(i=>i.HomeTeamId == teamId || i.AwayTeamId == teamId)
            .OrderByDescending(i=>i.Date).Take(5).ToArray();
        

        // Экземпляр класса подсчитывает профит для одной конкретной команды
        OddsProfitCalc calc = new(teamId); 

        foreach (var g in games)
        {
            calc.Update(g);
        }

        foreach (var (m, v) in calc.Profit)
        {
            Console.WriteLine(m + ": " + v);
        }
        
        Assert.AreEqual(-2.37f, calc.Profit[OddsProfitCalc.Market.Win]);
        Assert.AreEqual(-1.83f, calc.ProfitFirstHalf[OddsProfitCalc.Market.Win],0.01f);
    }

    [TestMethod]
    public async Task AsianHandicapTest()
    {
        const int teamId = 47;
        var allGames = await LoadFromFile("test_games.bin");
        var games = allGames.Where(i=>i.HomeTeamId == teamId || i.AwayTeamId == teamId)
            .OrderByDescending(i=>i.Date).Take(5).ToArray();
        
        Console.WriteLine(string.Join("\n",games.Select(i=>i.DisplayAh())));
        
        OddsProfitCalc calc = new(teamId); 
        
        foreach (var g in games)
        {
            calc.Update(g);
        }
        
        Assert.AreEqual(-0.2f, calc.Profit[OddsProfitCalc.Market.AhLoseP1], 0.01);
        
    }
    
}