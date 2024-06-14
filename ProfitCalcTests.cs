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
    }
    
}