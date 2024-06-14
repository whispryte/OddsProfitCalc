namespace OddsCalcTest;

public class OddsProfitCalc
{
    public enum Market
    {
        // Match Winner | First Half Winner | Second Half Winner
        Win, // Победа команды
        Draw, // Ничья
        Lose, // Поражение

        // Double Chance | Double Chance - First Half | Double Chance - Second Half
        WinOrDraw, // Победа или ничья
        WinOrLose, // Победа или поражение
        DrawOrLose, // Поражение или ничья

        // Home/Away
        WinNoBet, // Победа или возврат
        LoseNoBet, // Поражение или возврат

        #region TOTALS

        // Goals Over/Under | Goals Over/Under First Half | Goals Over/Under - Second Half
        TotalOver05, // Тотал голов больше 0.5
        TotalUnder05, // Тотал голов меньше 0.5
        TotalOver1, // Тотал голов больше 1. (Если тотал == 1, то возврат)
        TotalUnder1, // Тотал голов меньше 2
        TotalOver15, // Тотал голов больше 1.5
        TotalUnder15, // Тотал голов меньше 1.5
        TotalOver2,
        TotalUnder2,
        TotalOver25,
        TotalUnder25,
        TotalOver3,
        TotalUnder3,
        TotalOver35,
        TotalUnder35,
        TotalOver4,
        TotalUnder4,
        TotalOver45,
        TotalUnder45,

        // Total - Home | Home Team Total Goals(1st Half) | Home Team Total Goals(2nd Half) | Total - Away | Away Team Total Goals(1st Half) | Away Team Total Goals(2nd Half)
        TeamTotalOver05, // Индивидуальный тотал команды больше 0.5
        TeamTotalUnder05,
        TeamTotalOver1,
        TeamTotalUnder1,
        TeamTotalOver15,
        TeamTotalUnder15,
        TeamTotalOver2,
        TeamTotalUnder2,
        TeamTotalOver25,
        TeamTotalUnder25,
        TeamTotalOver3,
        TeamTotalUnder3,
        TeamTotalOver35,
        TeamTotalUnder35,

        // Home Team Total Goals(1st Half) | Home Team Total Goals(2nd Half) | Away Team Total Goals(1st Half) | Away Team Total Goals(2nd Half)
        TeamOppTotalOver05, // Индивидуальный тотал соперника больше 0.5
        TeamOppTotalUnder05,
        TeamOppTotalOver1,
        TeamOppTotalUnder1,
        TeamOppTotalOver15,
        TeamOppTotalUnder15,
        TeamOppTotalOver2,
        TeamOppTotalUnder2,
        TeamOppTotalOver25,
        TeamOppTotalUnder25,
        TeamOppTotalOver3,
        TeamOppTotalUnder3,
        TeamOppTotalOver35,
        TeamOppTotalUnder35,

        #endregion

        #region Result Total

        // Result/Total Goals
        ResultWinOver05, // Победа и тотал матча больше 0.5
        ResultLoseOver05, // Поражение и тотал матча больше 0.5
        ResultWinOver15, // Победа и тотал больше 1.5
        ResultLoseOver15, // Поражение и тотал больше 1.5
        ResultWinOver25,
        ResultLoseOver25,
        ResultWinOver35,
        ResultLoseOver35,
        ResultWinOver45,
        ResultLoseOver45,

        #endregion

        #region ASIAN HANDICAP

        // Asian Handicap
        AhWinM35, // Asian Handicap -3.5 win. Победа с форой -3.5
        AhLoseM35, // Asian Handicap -3.5 lose. Поражение с форой -3.5
        AhWinM325, // Asian Handicap -3.25 win. Победа с форой -3.25
        AhLoseM325, // Asian Handicap -3.25 lose. Поражение с форой -3.25
        AhWinM3, // Asian Handicap -3 lose. Победа с форой -3 (если преимущество ровно в 3 гола, то возврат)
        AhLoseM3,
        AhWinM275,
        AhLoseM275,
        AhWinM25,
        AhLoseM25,
        AhWinM225,
        AhLoseM225,
        AhWinM2,
        AhLoseM2,
        AhWinM175,
        AhLoseM175,
        AhWinM15,
        AhLoseM15,
        AhWinM125,
        AhLoseM125,
        AhWinM1,
        AhLoseM1,
        AhWinM075,
        AhLoseM075,
        AhWinM05,
        AhLoseM05,
        AhWinM025,
        AhLoseM025,
        AhWin0, // Фора 0. Победа или возврат
        AhLose0, // Фора 0. Поражеие или возврат
        AhWin025,
        AhLose025,
        AhWinP05, // Asian Handicap +0.5 win. Победа с форой +0.5
        AhLoseP05, // Asian Handicap +0.5 win. Поражение с форой +0.5
        AhWin075,
        AhLose075,
        AhWinP1,
        AhLoseP1,
        AhWinP125,
        AhLoseP125,
        AhWinP15,
        AhLoseP15,
        AhWinP175,
        AhLoseP175,
        AhWinP2,
        AhLoseP2,
        AhWinP225,
        AhLoseP225,
        AhWinP25,
        AhLoseP25,
        AhWinP275,
        AhLoseP275,
        AhWinP3,
        AhLoseP3,
        AhWinP325,
        AhLoseP325,
        AhWinP35,
        AhLoseP35,

        #endregion

        #region Corners

        CornersOver25, // общий Тотал угловых больше 2.5
        CornersUnder25, // общий Тотал угловых меньше 2.5
        CornersOver35,
        CornersUnder35,
        CornersOver45,
        CornersUnder45,
        CornersOver55,
        CornersUnder55,
        CornersOver65,
        CornersUnder65,
        CornersOver75,
        CornersUnder75,
        CornersOver85,
        CornersUnder85,
        CornersOver95,
        CornersUnder95,
        CornersOver105, // > 10.5
        CornersUnder105,
        CornersOver115, // > 11.5
        CornersUnder115,
        CornersOver125, // > 12.5
        CornersUnder125,
        CornersOver135, // > 13.5
        CornersUnder135,

        // Home Corners Over/Under | Home Total Corners (1st Half) | Home Total Corners (2nd Half) | Away Corners Over/Under | Away Total Corners (1st Half) | Away Total Corners (2nd Half)
        TeamCornersOver05, // индивидуальный Тотал угловых больше 0.5
        TeamCornersUnder05, // индивидуальный Тотал угловых меньше 0.5
        TeamCornersOver1, // индивидуальный Тотал угловых больше 1. (Если тотал == 1, то возврат)
        TeamCornersUnder1,
        TeamCornersOver15,
        TeamCornersUnder15,
        TeamCornersOver2,
        TeamCornersUnder2,
        TeamCornersOver25,
        TeamCornersUnder25,
        TeamCornersOver3,
        TeamCornersUnder3,
        TeamCornersOver35,
        TeamCornersUnder35,
        TeamCornersOver4,
        TeamCornersUnder4,
        TeamCornersOver45,
        TeamCornersUnder45,
        TeamCornersOver5,
        TeamCornersUnder5,
        TeamCornersOver55,
        TeamCornersUnder55,
        TeamCornersOver6,
        TeamCornersUnder6,
        TeamCornersOver65,
        TeamCornersUnder65,
        TeamCornersOver7,
        TeamCornersUnder7,
        TeamCornersOver75,
        TeamCornersUnder75,
        TeamCornersOver8,
        TeamCornersUnder8,
        TeamCornersOver85,
        TeamCornersUnder85,
        TeamCornersOver9,
        TeamCornersUnder9,
        TeamCornersOver95,
        TeamCornersUnder95,

        // Home Corners Over/Under | Home Total Corners (1st Half) | Home Total Corners (2nd Half) | Away Corners Over/Under | Away Total Corners (1st Half) | Away Total Corners (2nd Half)
        OppCornersOver05, // команда соперника: индивидуальный Тотал угловых больше 0.5
        OppCornersUnder05, // команда соперника: индивидуальный Тотал угловых меньше 0.5
        OppCornersOver1, // команда соперника: индивидуальный Тотал угловых больше 1. (Если тотал == 1, то возврат)
        OppCornersUnder1,
        OppCornersOver15,
        OppCornersUnder15,
        OppCornersOver2,
        OppCornersUnder2,
        OppCornersOver25,
        OppCornersUnder25,
        OppCornersOver3,
        OppCornersUnder3,
        OppCornersOver35,
        OppCornersUnder35,
        OppCornersOver4,
        OppCornersUnder4,
        OppCornersOver45,
        OppCornersUnder45,
        OppCornersOver5,
        OppCornersUnder5,
        OppCornersOver55,
        OppCornersUnder55,
        OppCornersOver6,
        OppCornersUnder6,
        OppCornersOver65,
        OppCornersUnder65,
        OppCornersOver7,
        OppCornersUnder7,
        OppCornersOver75,
        OppCornersUnder75,
        OppCornersOver8,
        OppCornersUnder8,
        OppCornersOver85,
        OppCornersUnder85,
        OppCornersOver9,
        OppCornersUnder9,
        OppCornersOver95,
        OppCornersUnder95,
        
        // Corners 1x2
        Corners1x2_Win,
        Corners1x2_Draw,
        Corners1x2_Lose,

        #endregion

        #region CARDS
        // Cards Over/Under
        CardsOver15, // Карточки (Ж+К). Тотал
        CardsUnder15,
        CardsOver2,
        CardsUnder2,
        CardsOver25,
        CardsUnder25,
        CardsOver3,
        CardsUnder3,
        CardsOver35,
        CardsUnder35,
        CardsOver4,
        CardsUnder4,
        CardsOver45,
        CardsUnder45,

        // Away Team Total Cards | Home Team Total Cards
        TeamCardsOver05, // Карточки (Ж+К). Индивидуальный Тотал
        TeamCardsUnder05,
        TeamCardsOver1,
        TeamCardsUnder1,
        TeamCardsOver15,
        TeamCardsUnder15,
        TeamCardsOver2,
        TeamCardsUnder2,
        TeamCardsOver25,
        TeamCardsUnder25,
        TeamCardsOver3,
        TeamCardsUnder3,
        TeamCardsOver35,
        TeamCardsUnder35,
        TeamCardsOver4,
        TeamCardsUnder4,
        TeamCardsOver45,
        TeamCardsUnder45,

        // Away Team Total Cards | Home Team Total Cards
        OppCardsOver05, // Карточки (Ж+К). Индивидуальный Тотал соперника
        OppCardsUnder05,
        OppCardsOver1,
        OppCardsUnder1,
        OppCardsOver15,
        OppCardsUnder15,
        OppCardsOver2,
        OppCardsUnder2,
        OppCardsOver25,
        OppCardsUnder25,
        OppCardsOver3,
        OppCardsUnder3,
        OppCardsOver35,
        OppCardsUnder35,
        OppCardsOver4,
        OppCardsUnder4,
        OppCardsOver45,
        OppCardsUnder45,

        // Cards Asian Handicap
        CardsAhWin05, // Карточки (Ж+К). Азиатский гандикап. Команда набирает больше карточек чем противник
        CardsAhLose05, // Карточки (Ж+К). Азиатский гандикап. Команда набирает меньше карточек чем противник
        CardsAhWin1,
        CardsAhLose1,
        CardsAhWin15,
        CardsAhLose15,
        CardsAhWin2,
        CardsAhLose2,
        CardsAhWin25,
        CardsAhLose25,
        CardsAhWin3,
        CardsAhLose3,
        CardsAhWin35,
        CardsAhLose35,

        // RCARD
        RedCardsYes, // Будет ли красная карточка в матче 
        RedCardsNo, // Красных карточек не будет
        
        // Yellow Cards 1x2 | Yellow Cards 1x2 (1st Half) | Yellow Cards 1x2 (2nd Half)
        YellowCardsWin,
        YellowCardsDraw,
        YellowCardsLose,

        #endregion

        #region Score

        // Exact Goals Number
        ExactGoals_0, // Точное количество голов == 0
        ExactGoals_1,
        ExactGoals_2,
        ExactGoals_3,
        ExactGoals_4,
        ExactGoals_5,
        ExactGoals_6,

        // Exact Score | Correct Score - First Half | Correct Score - Second Half
        ExactScore_0_0, // Точный счет 0:0 (Первое число - эта комана, второе, команда опонента)
        ExactScore_1_0,
        ExactScore_2_0,
        ExactScore_3_0,
        ExactScore_4_0,
        ExactScore_1_1,
        ExactScore_2_1,
        ExactScore_3_1,
        ExactScore_4_1,
        ExactScore_1_2,
        ExactScore_2_2,
        ExactScore_3_2,
        ExactScore_4_2,
        ExactScore_1_3,
        ExactScore_2_3,
        ExactScore_3_3,
        ExactScore_4_3,
        ExactScore_1_4,
        ExactScore_2_4,
        ExactScore_3_4,
        ExactScore_4_4,

        #endregion

        #region Fouls

        // Fouls. 1x2
        Fouls_1x2_Win, // Эта команда заработала больше фолов
        Fouls_1x2_Draw, // ничья по фолам
        Fouls_1x2_Lose, // Команда противника заработала больше фолов

        // Fouls. Handicap
        FoulsAhWin05, // Фолы. Азиатский гандикап. Команда набирает больше фолов чем противник
        FoulsAhLose05, // Фолы. Азиатский гандикап. Команда набирает меньше фолов чем противник
        FoulsAhWin1,
        FoulsAhLose1,
        FoulsAhWin15,
        FoulsAhLose15,
        FoulsAhWin2,
        FoulsAhLose2,
        FoulsAhWin25,
        FoulsAhLose25,
        FoulsAhWin3,
        FoulsAhLose3,
        FoulsAhWin35,
        FoulsAhLose35,
        FoulsAhWin4,
        FoulsAhLose4,
        FoulsAhWin45,
        FoulsAhLose45,
        FoulsAhWin5,
        FoulsAhLose5,
        FoulsAhWin55,
        FoulsAhLose55,

        #endregion

        // Win Both Halves
        BothHalvesWin, // Команда выигрыает оба периода. (Учитываются только голы забитые в конкретном тайме)
        BothHalves, // В обоих таймаъ ничья по голам
        BothHalvesLose, // В обоих таймах поражение по количеству голов


        // Both Teams Score | Both Teams Score - First Half | Both Teams To Score - Second Half
        BtsYes, // Обе команды забют - да
        BtsNo, // Обе команды забют - нет (одна из команд не забивает)

        // Clean Sheet | Clean Sheet - Home | Clean Sheet - Away
        TeamCleanSheetYes, // Эта команда не пропустит - да
        TeamCleanSheetNo, // Эта команда не пропустит - нет
        TeamCleanSheetOpp, // Команда соперника не пропустит - да
        TeamCleanSheetOppNo, // Команда соперника не пропустит - ytn

        // Win To Nil | Win to Nil - Home | Win to Nil - Away
        WinToNilYes, // Эта команда выиграет и не пропустит
        WinToNilNo, // Эта команда не сможет выиграть и не пропустить
        
        // To Win Either Half | Home team will win either half
        WinEitherHalf, // Эта команда выиграет хотя бы один тайм
        WinEitherHalfOpp, // Команад соперника выиграет хотя бы один тайм

        // Team To Score First
        ScoreFirst,
        ScoreFirstOpp,

        // First Team to Score
        FirstTeamToScore, // Первой забъет эта команда
        FirstTeamToScoreOpp, // Первой забъет команда противника

        // Home Team Score a Goal | Away Team Score a Goal
        TeamToScore, // Эта команда забъет хотя бы один гол
        TeamToScoreNo, // Эта команда не забъет ни одного гола
        OppTeamToScore, // команда соперника забъет хотя бы один гол
        OppTeamToScoreNo, // команда соперника не забъет ни одного гола

        // Both Teams To Score in Both Halves
        BtsInBothHalves, // Обе команды забьют в обоих таймах

        Bts1stAnd2nd_YesYes, // Обе забьют в 1ом и 2ом тайме 
        Bts1stAnd2nd_YesNo, // Обе забьют в 1ом таймне - да, во 2ом тайме - нет
        Bts1stAnd2nd_NoYes, // Обе забьют в 1ом таймне - нет, во 2ом тайме - да
        
        // Odd/Even | Odd/Even - First Half | Odd/Even - Second Half
        OddEven_Odd, // Нечетное количество голов
        OddEven_Even,  // Четное количество голов
        TeamOddEven_Odd, // Нечетное количество голов этой команды
        TeamOddEven_Even,  // Четное количество голов этой команды
        // Home Odd/Even | Away Odd/Even
        OppOddEven_Odd, // Нечетное количество голов команды соперника
        OppTeamOddEven_Even, 

        // 1x2 - 15 minutes
        w1x2_15_Win, // Счет на 15 минуте был в пользу команды
        w1x2_15_Draw, // На 15 минуте счет был равный
        w1x2_15_Lose, // Счет на 15 минуте был в пользу соперника
        w1x2_30_Lose,
        w1x2_30_Draw,
        w1x2_30_Win,
        w1x2_60_Lose,
        w1x2_60_Draw,
        w1x2_60_Win,
        w1x2_75_Lose,
        w1x2_75_Draw,
        w1x2_75_Win,

        // DC - 15 minutes
        DC_15_WinOrDraw, // Счет на 15 минуту. Победа или ничья
        DC_15_LoseOrDraw, // Счет на 15 минуту. Поражение или ничья
        DC_15_WinOrLose, // Счет на 15 минуту. Победа или поражение
        DC_30_WinOrDraw,
        DC_30_LoseOrDraw,
        DC_30_WinOrLose,
        DC_75_WinOrDraw,
        DC_75_LoseOrDraw,
        DC_75_WinOrLose,

        // Goal in 1-15 minutes
        GoalIn_1_15_Yes, // Гол на 1 - 15 минутах - да
        GoalIn_1_15_No, // Гол на 1 - 15 минутах - нет
        GoalIn_16_30_Yes,
        GoalIn_31_45_No,
        GoalIn_46_60_Yes,
        GoalIn_46_60_No,
        GoalIn_61_75_Yes,
        GoalIn_61_75_No,
        GoalIn_76_90_Yes,
        GoalIn_76_90_No,
        
        // Penalty Awarded
        PenaltyAwardedYes,
        PenaltyAwardedNo,
    }

    private readonly int _teamId;

    public readonly Dictionary<Market, float> Profit = new();
    public readonly Dictionary<Market, float> ProfitFirstHalf = new();
    public readonly Dictionary<Market, float> ProfitSecondHalf = new();

    private readonly Market[] _markets;

    public OddsProfitCalc(int teamId, Market[]? markets = null)
    {
        _teamId = teamId;
        _markets = markets ?? Enum.GetValues<Market>();

        //Profit = _markets.ToDictionary(i => i, _ => 0f);
    }

    public void Update(CachedGame game)
    {
        if (game.Odds == null)
            return;

        foreach (var market in _markets)
        {
            if (game.HomeTeamId != _teamId && game.AwayTeamId != _teamId)
                continue;

            var profit = GetProfit(market, game);
            if (profit == null) continue;

            Profit.TryAdd(market, 0);
            Profit[market] += profit.Value;

            var profitFirstHalf = GetProfit(market, game, 1);
            if (profitFirstHalf != null)
            {
                ProfitFirstHalf.TryAdd(market, 0);
                ProfitFirstHalf[market] += profitFirstHalf.Value;
            }

            var profitSecondHalf = GetProfit(market, game, 2);
            if (profitSecondHalf != null)
            {
                ProfitSecondHalf.TryAdd(market, 0);
                ProfitSecondHalf[market] += profitSecondHalf.Value;
            }
        }
    }

    private float? GetProfit(Market market, CachedGame game, byte period = 0)
    {
        var odds = GetOdds(market);
        if (odds == null)
            return null;

        var profitOdds = market switch
        {
            Market.Win => Score() > ScoreOpp() ? odds : 0,
            Market.Draw => Score() == ScoreOpp() ? odds : 0,
            Market.Lose => Score() < ScoreOpp() ? odds : 0,
            Market.WinOrDraw => Score() >= ScoreOpp() ? odds : 0,
            Market.WinOrLose => Score() != ScoreOpp() ? odds : 0,
            Market.DrawOrLose => Score() <= ScoreOpp() ? odds : 0,
            Market.WinNoBet => Score() > ScoreOpp()
                ? odds
                : (Score() == ScoreOpp() ? 1 : 0),
            Market.LoseNoBet => Score() < ScoreOpp()
                ? odds
                : (Score() == ScoreOpp() ? 1 : 0),
            Market.TotalOver05 => Score() + ScoreOpp() > 0.5 ? odds : 0,
            Market.TotalUnder05 => Score() + ScoreOpp() < 0.5 ? odds : 0,
            Market.TotalOver1 => Score() + ScoreOpp() > 1
                ? odds
                : (Score() + ScoreOpp() == 1 ? 1 : 0),
            Market.TotalUnder1 => Score() + ScoreOpp() < 1
                ? odds
                : (Score() + ScoreOpp() == 1 ? 1 : 0),
            Market.TotalOver15 => Score() + ScoreOpp() > 1.5 ? odds : 0,
            Market.TotalUnder15 => Score() + ScoreOpp() < 1.5 ? odds : 0,
            Market.TotalOver2 => Score() + ScoreOpp() > 2
                ? odds
                : (Score() + ScoreOpp() == 2 ? 1 : 0),
            Market.TotalUnder2 => Score() + ScoreOpp() > 2
                ? odds
                : (Score() + ScoreOpp() == 2 ? 1 : 0),
            Market.TotalOver25 => Score() + ScoreOpp() > 2.5 ? odds : 0,
            Market.TotalUnder25 => Score() + ScoreOpp() < 2.5 ? odds : 0,

            Market.CornersOver25 => Corners() + CornersOpp() > 2.5 ? odds : 0,
            Market.CornersOver35 => Corners() + CornersOpp() > 3.5 ? odds : 0,

            Market.CardsOver15 => Cards() + CardsOpp() > 1.5 ? odds : 0,
            Market.CardsOver2 => Cards() + CardsOpp() > 2 ? odds : (Cards() + CardsOpp() == 2 ? 1 : 0),
            
            Market.TeamCardsOver05 => Cards() > 0.5 ? odds : 0,
            Market.TeamCardsUnder05 => Cards() > 0.5 ? odds : 0,
            Market.OppCardsOver05 => CardsOpp() < 0.5 ? odds : 0,
            Market.OppCardsUnder05 => CardsOpp() < 0.5 ? odds : 0,

            // TODO Реализовать остальные исходы

            _ => null
        };

        return profitOdds - 1;

        #region local functions

        float? OddsVal(params short[] betId)
        {
            foreach (var id in betId)
            {
                if (game.Odds.TryGetValue(id, out var o))
                    return o;
            }

            return null;
        }

        float? Odds()
        {
            return GetOdds(market);
        }

        float? GetOdds(Market m)
        {
            return m switch
            {
                Market.Win => IsHome() ? OddsVal(1) : OddsVal(3),
                Market.Draw => OddsVal(2),
                Market.Lose => IsHome() ? OddsVal(3) : OddsVal(1),
                Market.WinOrDraw => IsHome() ? OddsVal(428) : OddsVal(430),
                Market.WinOrLose => OddsVal(429),
                Market.DrawOrLose => IsHome() ? OddsVal(430) : OddsVal(428),
                Market.WinNoBet => IsHome() ? OddsVal(4) : OddsVal(5),
                Market.LoseNoBet => IsHome() ? OddsVal(5) : OddsVal(4),

                // TODO Реализовать остальные исходы

                // Market.TotalOver05 => expr,
                // Market.TotalUnder05 => expr,
                // Market.TotalOver1 => expr,
                // Market.TotalUnder1 => expr,
                // Market.TotalOver15 => expr,
                // Market.TotalUnder15 => expr,
                // Market.TotalOver2 => expr,
                // Market.TotalUnder2 => expr,
                // Market.TotalOver25 => expr,
                // Market.TotalUnder25 => expr,
                // Market.TotalOver3 => expr,
                // Market.TotalUnder3 => expr,
                // Market.TotalOver35 => expr,
                // Market.TotalUnder35 => expr,
                // Market.TotalOver4 => expr,
                // Market.TotalUnder4 => expr,
                // Market.TotalOver45 => expr,
                // Market.TotalUnder45 => expr,
                // Market.TeamTotalOver05 => expr,
                // Market.TeamTotalUnder05 => expr,
                // Market.TeamTotalOver1 => expr,
                // Market.TeamTotalUnder1 => expr,
                // Market.TeamTotalOver15 => expr,
                // Market.TeamTotalUnder15 => expr,
                // Market.TeamTotalOver2 => expr,
                // Market.TeamTotalUnder2 => expr,
                // Market.TeamTotalOver25 => expr,
                // Market.TeamTotalUnder25 => expr,
                // Market.TeamTotalOver3 => expr,
                // Market.TeamTotalUnder3 => expr,
                // Market.TeamTotalOver35 => expr,
                // Market.TeamTotalUnder35 => expr,
                // Market.TeamOppTotalOver05 => expr,
                // Market.TeamOppTotalUnder05 => expr,
                // Market.TeamOppTotalOver1 => expr,
                // Market.TeamOppTotalUnder1 => expr,
                // Market.TeamOppTotalOver15 => expr,
                // Market.TeamOppTotalUnder15 => expr,
                // Market.TeamOppTotalOver2 => expr,
                // Market.TeamOppTotalUnder2 => expr,
                // Market.TeamOppTotalOver25 => expr,
                // Market.TeamOppTotalUnder25 => expr,
                // Market.TeamOppTotalOver3 => expr,
                // Market.TeamOppTotalUnder3 => expr,
                // Market.TeamOppTotalOver35 => expr,
                // Market.TeamOppTotalUnder35 => expr,
                // Market.ResultWinOver05 => expr,
                // Market.ResultLoseOver05 => expr,
                // Market.ResultWinOver15 => expr,
                // Market.ResultLoseOver15 => expr,
                // Market.ResultWinOver25 => expr,
                // Market.ResultLoseOver25 => expr,
                // Market.ResultWinOver35 => expr,
                // Market.ResultLoseOver35 => expr,
                // Market.ResultWinOver45 => expr,
                // Market.ResultLoseOver45 => expr,
                // Market.AhWinM35 => expr,
                // Market.AhLoseM35 => expr,
                // Market.AhWinM325 => expr,
                // Market.AhLoseM325 => expr,
                // Market.AhWinM3 => expr,
                // Market.AhLoseM3 => expr,
                // Market.AhWinM275 => expr,
                // Market.AhLoseM275 => expr,
                // Market.AhWinM25 => expr,
                // Market.AhLoseM25 => expr,
                // Market.AhWinM225 => expr,
                // Market.AhLoseM225 => expr,
                // Market.AhWinM2 => expr,
                // Market.AhLoseM2 => expr,
                // Market.AhWinM175 => expr,
                // Market.AhLoseM175 => expr,
                // Market.AhWinM15 => expr,
                // Market.AhLoseM15 => expr,
                // Market.AhWinM125 => expr,
                // Market.AhLoseM125 => expr,
                // Market.AhWinM1 => expr,
                // Market.AhLoseM1 => expr,
                // Market.AhWinM075 => expr,
                // Market.AhLoseM075 => expr,
                // Market.AhWinM05 => expr,
                // Market.AhLoseM05 => expr,
                // Market.AhWinM025 => expr,
                // Market.AhLoseM025 => expr,
                // Market.AhWin0 => expr,
                // Market.AhLose0 => expr,
                // Market.AhWin025 => expr,
                // Market.AhLose025 => expr,
                // Market.AhWinP05 => expr,
                // Market.AhLoseP05 => expr,
                // Market.AhWin075 => expr,
                // Market.AhLose075 => expr,
                // Market.AhWinP1 => expr,
                // Market.AhLoseP1 => expr,
                // Market.AhWinP125 => expr,
                // Market.AhLoseP125 => expr,
                // Market.AhWinP15 => expr,
                // Market.AhLoseP15 => expr,
                // Market.AhWinP175 => expr,
                // Market.AhLoseP175 => expr,
                // Market.AhWinP2 => expr,
                // Market.AhLoseP2 => expr,
                // Market.AhWinP225 => expr,
                // Market.AhLoseP225 => expr,
                // Market.AhWinP25 => expr,
                // Market.AhLoseP25 => expr,
                // Market.AhWinP275 => expr,
                // Market.AhLoseP275 => expr,
                // Market.AhWinP3 => expr,
                // Market.AhLoseP3 => expr,
                // Market.AhWinP325 => expr,
                // Market.AhLoseP325 => expr,
                // Market.AhWinP35 => expr,
                // Market.AhLoseP35 => expr,
                //Market.CornersOver05 => expr,
                // Market.CornersUnder05 => expr,
                // Market.CornersOver1 => expr,
                // Market.CornersUnder1 => expr,
                // Market.CornersOver15 => expr,
                // Market.CornersUnder15 => expr,
                // Market.CornersOver2 => expr,
                // Market.CornersUnder2 => expr,
                Market.CornersOver25 => OddsVal(677),
                Market.CornersUnder25 => OddsVal(678),
                // Market.CornersOver3 => expr,
                // Market.CornersUnder3 => expr,
                // Market.CornersOver35 => expr,
                // Market.CornersUnder35 => expr,
                // Market.CornersOver4 => expr,
                // Market.CornersUnder4 => expr,
                // Market.CornersOver45 => expr,
                // Market.CornersUnder45 => expr,
                // Market.CornersOver5 => expr,
                // Market.CornersUnder5 => expr,
                // Market.CornersOver55 => expr,
                // Market.CornersUnder55 => expr,
                // Market.CornersOver6 => expr,
                // Market.CornersUnder6 => expr,
                // Market.CornersOver65 => expr,
                // Market.CornersUnder65 => expr,
                // Market.CornersOver7 => expr,
                // Market.CornersUnder7 => expr,
                // Market.CornersOver75 => expr,
                // Market.CornersUnder75 => expr,
                // Market.CornersOver8 => expr,
                // Market.CornersUnder8 => expr,
                // Market.CornersOver85 => expr,
                // Market.CornersUnder85 => expr,
                // Market.CornersOver9 => expr,
                // Market.CornersUnder9 => expr,
                // Market.CornersOver95 => expr,
                // Market.CornersUnder95 => expr,
                // Market.TeamCornersOver05 => expr,
                // Market.TeamCornersUnder05 => expr,
                // Market.TeamCornersOver1 => expr,
                // Market.TeamCornersUnder1 => expr,
                // Market.TeamCornersOver15 => expr,
                // Market.TeamCornersUnder15 => expr,
                // Market.TeamCornersOver2 => expr,
                // Market.TeamCornersUnder2 => expr,
                // Market.TeamCornersOver25 => expr,
                // Market.TeamCornersUnder25 => expr,
                // Market.TeamCornersOver3 => expr,
                // Market.TeamCornersUnder3 => expr,
                // Market.TeamCornersOver35 => expr,
                // Market.TeamCornersUnder35 => expr,
                // Market.TeamCornersOver4 => expr,
                // Market.TeamCornersUnder4 => expr,
                // Market.TeamCornersOver45 => expr,
                // Market.TeamCornersUnder45 => expr,
                // Market.TeamCornersOver5 => expr,
                // Market.TeamCornersUnder5 => expr,
                // Market.TeamCornersOver55 => expr,
                // Market.TeamCornersUnder55 => expr,
                // Market.TeamCornersOver6 => expr,
                // Market.TeamCornersUnder6 => expr,
                // Market.TeamCornersOver65 => expr,
                // Market.TeamCornersUnder65 => expr,
                // Market.TeamCornersOver7 => expr,
                // Market.TeamCornersUnder7 => expr,
                // Market.TeamCornersOver75 => expr,
                // Market.TeamCornersUnder75 => expr,
                // Market.TeamCornersOver8 => expr,
                // Market.TeamCornersUnder8 => expr,
                // Market.TeamCornersOver85 => expr,
                // Market.TeamCornersUnder85 => expr,
                // Market.TeamCornersOver9 => expr,
                // Market.TeamCornersUnder9 => expr,
                // Market.TeamCornersOver95 => expr,
                // Market.TeamCornersUnder95 => expr,
                // Market.OppCornersOver05 => expr,
                // Market.OppCornersUnder05 => expr,
                // Market.OppCornersOver1 => expr,
                // Market.OppCornersUnder1 => expr,
                // Market.OppCornersOver15 => expr,
                // Market.OppCornersUnder15 => expr,
                // Market.OppCornersOver2 => expr,
                // Market.OppCornersUnder2 => expr,
                // Market.OppCornersOver25 => expr,
                // Market.OppCornersUnder25 => expr,
                // Market.OppCornersOver3 => expr,
                // Market.OppCornersUnder3 => expr,
                // Market.OppCornersOver35 => expr,
                // Market.OppCornersUnder35 => expr,
                // Market.OppCornersOver4 => expr,
                // Market.OppCornersUnder4 => expr,
                // Market.OppCornersOver45 => expr,
                // Market.OppCornersUnder45 => expr,
                // Market.OppCornersOver5 => expr,
                // Market.OppCornersUnder5 => expr,
                // Market.OppCornersOver55 => expr,
                // Market.OppCornersUnder55 => expr,
                // Market.OppCornersOver6 => expr,
                // Market.OppCornersUnder6 => expr,
                // Market.OppCornersOver65 => expr,
                // Market.OppCornersUnder65 => expr,
                // Market.OppCornersOver7 => expr,
                // Market.OppCornersUnder7 => expr,
                // Market.OppCornersOver75 => expr,
                // Market.OppCornersUnder75 => expr,
                // Market.OppCornersOver8 => expr,
                // Market.OppCornersUnder8 => expr,
                // Market.OppCornersOver85 => expr,
                // Market.OppCornersUnder85 => expr,
                // Market.OppCornersOver9 => expr,
                // Market.OppCornersUnder9 => expr,
                // Market.OppCornersOver95 => expr,
                // Market.OppCornersUnder95 => expr,
   
                Market.CardsOver15 => OddsVal(1271),
                Market.CardsUnder15 => OddsVal(1272),
                Market.CardsOver2 => OddsVal(1269),
                Market.CardsUnder2 => OddsVal(1270),
                // Market.CardsOver25 => expr,
                // Market.CardsUnder25 => expr,
                // Market.CardsOver3 => expr,
                // Market.CardsUnder3 => expr,
                // Market.CardsOver35 => expr,
                // Market.CardsUnder35 => expr,
                // Market.CardsOver4 => expr,
                // Market.CardsUnder4 => expr,
                // Market.CardsOver45 => expr,
                // Market.CardsUnder45 => expr,
                Market.TeamCardsOver05 => IsHome() ? OddsVal(1291) : OddsVal(1299),
                Market.TeamCardsUnder05 => IsHome() ? OddsVal(1292) : OddsVal(1300),
                // Market.TeamCardsOver1 => expr,
                // Market.TeamCardsUnder1 => expr,
                // Market.TeamCardsOver15 => expr,
                // Market.TeamCardsUnder15 => expr,
                // Market.TeamCardsOver2 => expr,
                // Market.TeamCardsUnder2 => expr,
                // Market.TeamCardsOver25 => expr,
                // Market.TeamCardsUnder25 => expr,
                // Market.TeamCardsOver3 => expr,
                // Market.TeamCardsUnder3 => expr,
                // Market.TeamCardsOver35 => expr,
                // Market.TeamCardsUnder35 => expr,
                // Market.TeamCardsOver4 => expr,
                // Market.TeamCardsUnder4 => expr,
                // Market.TeamCardsOver45 => expr,
                // Market.TeamCardsUnder45 => expr,
                Market.OppCardsOver05 => _teamId == game.HomeTeamId ? OddsVal(1299) : OddsVal(1291),
                Market.OppCardsUnder05 => _teamId == game.HomeTeamId ? OddsVal(1300) : OddsVal(1292),
                // Market.OppCardsOver1 => expr,
                // Market.OppCardsUnder1 => expr,
                // Market.OppCardsOver15 => expr,
                // Market.OppCardsUnder15 => expr,
                // Market.OppCardsOver2 => expr,
                // Market.OppCardsUnder2 => expr,
                // Market.OppCardsOver25 => expr,
                // Market.OppCardsUnder25 => expr,
                // Market.OppCardsOver3 => expr,
                // Market.OppCardsUnder3 => expr,
                // Market.OppCardsOver35 => expr,
                // Market.OppCardsUnder35 => expr,
                // Market.OppCardsOver4 => expr,
                // Market.OppCardsUnder4 => expr,
                // Market.OppCardsOver45 => expr,
                // Market.OppCardsUnder45 => expr,
                // Market.CardsAhWin05 => expr,
                // Market.CardsAhLose05 => expr,
                // Market.CardsAhWin1 => expr,
                // Market.CardsAhLose1 => expr,
                // Market.CardsAhWin15 => expr,
                // Market.CardsAhLose15 => expr,
                // Market.CardsAhWin2 => expr,
                // Market.CardsAhLose2 => expr,
                // Market.CardsAhWin25 => expr,
                // Market.CardsAhLose25 => expr,
                // Market.CardsAhWin3 => expr,
                // Market.CardsAhLose3 => expr,
                // Market.CardsAhWin35 => expr,
                // Market.CardsAhLose35 => expr,
                // Market.RedCardsYes => expr,
                // Market.RedCardsNo => expr,
                // Market.ExactGoals_0 => expr,
                // Market.ExactGoals_1 => expr,
                // Market.ExactGoals_2 => expr,
                // Market.ExactGoals_3 => expr,
                // Market.ExactGoals_4 => expr,
                // Market.ExactGoals_5 => expr,
                // Market.ExactGoals_6 => expr,
                // Market.ExactScore_0_0 => expr,
                // Market.ExactScore_1_0 => expr,
                // Market.ExactScore_2_0 => expr,
                // Market.ExactScore_3_0 => expr,
                // Market.ExactScore_4_0 => expr,
                // Market.ExactScore_1_1 => expr,
                // Market.ExactScore_2_1 => expr,
                // Market.ExactScore_3_1 => expr,
                // Market.ExactScore_4_1 => expr,
                // Market.ExactScore_1_2 => expr,
                // Market.ExactScore_2_2 => expr,
                // Market.ExactScore_3_2 => expr,
                // Market.ExactScore_4_2 => expr,
                // Market.ExactScore_1_3 => expr,
                // Market.ExactScore_2_3 => expr,
                // Market.ExactScore_3_3 => expr,
                // Market.ExactScore_4_3 => expr,
                // Market.ExactScore_1_4 => expr,
                // Market.ExactScore_2_4 => expr,
                // Market.ExactScore_3_4 => expr,
                // Market.ExactScore_4_4 => expr,
                // Market.Fouls_1x2_Win => expr,
                // Market.Fouls_1x2_Draw => expr,
                // Market.Fouls_1x2_Lose => expr,
                // Market.FoulsAhWin05 => expr,
                // Market.FoulsAhLose05 => expr,
                // Market.FoulsAhWin1 => expr,
                // Market.FoulsAhLose1 => expr,
                // Market.FoulsAhWin15 => expr,
                // Market.FoulsAhLose15 => expr,
                // Market.FoulsAhWin2 => expr,
                // Market.FoulsAhLose2 => expr,
                // Market.FoulsAhWin25 => expr,
                // Market.FoulsAhLose25 => expr,
                // Market.FoulsAhWin3 => expr,
                // Market.FoulsAhLose3 => expr,
                // Market.FoulsAhWin35 => expr,
                // Market.FoulsAhLose35 => expr,
                // Market.FoulsAhWin4 => expr,
                // Market.FoulsAhLose4 => expr,
                // Market.FoulsAhWin45 => expr,
                // Market.FoulsAhLose45 => expr,
                // Market.FoulsAhWin5 => expr,
                // Market.FoulsAhLose5 => expr,
                // Market.FoulsAhWin55 => expr,
                // Market.FoulsAhLose55 => expr,
                // Market.BothHalvesWin => expr,
                // Market.BothHalves => expr,
                // Market.BothHalvesLose => expr,
                // Market.BtsYes => expr,
                // Market.BtsNo => expr,
                Market.TeamCleanSheetYes => IsHome() ? OddsVal(2473, 164) : OddsVal(2474, 166),
                Market.TeamCleanSheetOpp => IsHome() ? OddsVal(2474, 166) : OddsVal(2473, 164),
                // Market.WinToNilYes => expr,
                // Market.WinToNilNo => expr,
                // Market.ScoreFirst => expr,
                // Market.ScoreFirstOpp => expr,
                // Market.FirstCorner => expr,
                // Market.FirstCornerOpp => expr,
                // Market.LastCorner => expr,
                // Market.LastCornerOpp => expr,
                // Market.FirstTeamToScore => expr,
                // Market.FirstTeamToScoreOpp => expr,
                // Market.TeamToScore => expr,
                // Market.TeamToScoreNo => expr,
                // Market.OppTeamToScore => expr,
                // Market.OppTeamToScoreNo => expr,
                // Market.BtsInBothHalves => expr,
                // Market.Bts1stAnd2nd_YesYes => expr,
                // Market.Bts1stAnd2nd_YesNo => expr,
                // Market.Bts1stAnd2nd_NoYes => expr,
                // Market.w1x2_15_Win => expr,
                // Market.w1x2_15_Draw => expr,
                // Market.w1x2_15_Lose => expr,
                // Market.w1x2_30_Lose => expr,
                // Market.w1x2_30_Draw => expr,
                // Market.w1x2_30_Win => expr,
                // Market.w1x2_60_Lose => expr,
                // Market.w1x2_60_Draw => expr,
                // Market.w1x2_60_Win => expr,
                // Market.w1x2_75_Lose => expr,
                // Market.w1x2_75_Draw => expr,
                // Market.w1x2_75_Win => expr,
                // Market.DC_15_WinOrDraw => expr,
                // Market.DC_15_LoseOrDraw => expr,
                // Market.DC_15_WinOrLose => expr,
                // Market.DC_30_WinOrDraw => expr,
                // Market.DC_30_LoseOrDraw => expr,
                // Market.DC_30_WinOrLose => expr,
                // Market.DC_75_WinOrDraw => expr,
                // Market.DC_75_LoseOrDraw => expr,
                // Market.DC_75_WinOrLose => expr,
                // Market.GoalIn_1_15 => expr,
                // Market.GoalIn_16_30 => expr,
                // Market.GoalIn_31_45 => expr,
                // Market.GoalIn_46_60 => expr,
                // Market.GoalIn_61_75 => expr,
                // Market.GoalIn_76_90 => expr,
                _ => null
            };
        }

        bool IsHome() => _teamId == game.HomeTeamId;
        
        byte Score() // Счет команды
        {
            return period switch
            {
                1 => (_teamId == game.HomeTeamId ? game.ScoreHomeHT : game.ScoreAwayHT) ?? throw new Exception("Счет 1ого тайма не определен"),
                2 => (byte?)(_teamId == game.HomeTeamId ? game.ScoreHomeFT - game.ScoreHomeHT : game.ScoreAwayFT - game.ScoreAwayHT) ??
                     throw new Exception("Счет 1ого тайма не определен"),
                _ => _teamId == game.HomeTeamId ? game.ScoreHomeFT : game.ScoreAwayFT
            };
        }

        byte ScoreOpp() // Счет команды противника
        {
            return period switch
            {
                1 => (_teamId == game.HomeTeamId ? game.ScoreAwayHT : game.ScoreHomeHT) ?? throw new Exception("Счет 1ого тайма не определен"),
                2 => (byte?)(_teamId == game.HomeTeamId ? game.ScoreAwayFT - game.ScoreAwayHT : game.ScoreHomeFT - game.ScoreHomeHT) ??
                     throw new Exception("Счет 1ого тайма не определен"),
                _ => _teamId == game.HomeTeamId ? game.ScoreAwayFT : game.ScoreHomeFT
            };
        }

        byte? Corners() => game.HomeTeamId == _teamId ? game.Statistics?.CornerKicksHome : game.Statistics?.CornerKicksAway;
        byte? CornersOpp() => game.HomeTeamId == _teamId ? game.Statistics?.CornerKicksAway : game.Statistics?.CornerKicksHome;

        byte? Cards() => (byte?)(game.HomeTeamId == _teamId
            ? game.Statistics?.RedCardsHome + game.Statistics?.YellowCardsHome
            : game.Statistics?.RedCardsAway + game.Statistics?.YellowCardsAway);

        byte? CardsOpp() => (byte?)(game.HomeTeamId == _teamId
            ? game.Statistics?.RedCardsAway + game.Statistics?.YellowCardsAway
            : game.Statistics?.RedCardsHome + game.Statistics?.YellowCardsHome);

        #endregion
    }
}