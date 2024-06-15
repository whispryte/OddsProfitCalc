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

        // Result/Total Goals | Halftime Result/Total Goals
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

        // Asian Handicap | Asian Handicap First Half | Asian Handicap (2nd Half)
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

        // Home Corners Over/Under | Away Corners Over/Under 
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

        // Home Corners Over/Under | Away Corners Over/Under 
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

        // Exact Goals Number | Exact Goals Number - First Half
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
        BothHalvesDraw, // В обоих таймаъ ничья по голам
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

        // Odd/Even | Odd/Even - First Half | Odd/Even - Second Half
        OddEven_Odd, // Нечетное количество голов
        OddEven_Even, // Четное количество голов
        TeamOddEven_Odd, // Нечетное количество голов этой команды
        TeamOddEven_Even, // Четное количество голов этой команды

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

    // Типы исходов: Победа, Ничья, Поражение, Тотал меньше...
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

            // Полный матча
            var profit = GetProfit(market, game);
            if (profit == null) continue;

            Profit.TryAdd(market, 0);
            Profit[market] += profit.Value;

            // 1ый тайм
            var profitFirstHalf = GetProfit(market, game, 1);
            if (profitFirstHalf != null)
            {
                ProfitFirstHalf.TryAdd(market, 0);
                ProfitFirstHalf[market] += profitFirstHalf.Value;
            }

            // 2ой тайм
            var profitSecondHalf = GetProfit(market, game, 2);
            if (profitSecondHalf != null)
            {
                ProfitSecondHalf.TryAdd(market, 0);
                ProfitSecondHalf[market] += profitSecondHalf.Value;
            }
        }
    }

    /// <summary>
    /// Подсчет прибыли для конкретного матча и конкретного исхода. Т.е сыграла ли конкретная ставка для этого матча.
    /// Если ставка зашла: коэф-1. Если возврат: 0, Если проигрыш: -1
    /// </summary>
    /// <param name="market"></param>
    /// <param name="game"></param>
    /// <param name="period"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    private float? GetProfit(Market market, CachedGame game, byte period = 0)
    {
        var odds = Odds(); // Коэфициент на ставку с учетом тайма
        
        // Если коэф для данного периода не найден, то вычисление не происходит
        if (odds == null)
            return null;

        // Результирующий коэф из которого потом вычитается 1, чтобы получить прибыль.
        // switch должен возвращать значение без вычитания еденицы.
        // Если ставка зашла: возвращается коэф ставки, Если возврат - возвращается 1, если ставка не зашла, то возвращается 0
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

            Market.TotalOver3 => throw new NotImplementedException(),
            Market.TotalUnder3 => throw new NotImplementedException(),
            Market.TotalOver35 => throw new NotImplementedException(),
            Market.TotalUnder35 => throw new NotImplementedException(),
            Market.TotalOver4 => throw new NotImplementedException(),
            Market.TotalUnder4 => throw new NotImplementedException(),
            Market.TotalOver45 => throw new NotImplementedException(),
            Market.TotalUnder45 => throw new NotImplementedException(),
            Market.TeamTotalOver05 => throw new NotImplementedException(),
            Market.TeamTotalUnder05 => throw new NotImplementedException(),
            Market.TeamTotalOver1 => throw new NotImplementedException(),
            Market.TeamTotalUnder1 => throw new NotImplementedException(),
            Market.TeamTotalOver15 => throw new NotImplementedException(),
            Market.TeamTotalUnder15 => throw new NotImplementedException(),
            Market.TeamTotalOver2 => throw new NotImplementedException(),
            Market.TeamTotalUnder2 => throw new NotImplementedException(),
            Market.TeamTotalOver25 => throw new NotImplementedException(),
            Market.TeamTotalUnder25 => throw new NotImplementedException(),
            Market.TeamTotalOver3 => throw new NotImplementedException(),
            Market.TeamTotalUnder3 => throw new NotImplementedException(),
            Market.TeamTotalOver35 => throw new NotImplementedException(),
            Market.TeamTotalUnder35 => throw new NotImplementedException(),
            Market.TeamOppTotalOver05 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder05 => throw new NotImplementedException(),
            Market.TeamOppTotalOver1 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder1 => throw new NotImplementedException(),
            Market.TeamOppTotalOver15 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder15 => throw new NotImplementedException(),
            Market.TeamOppTotalOver2 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder2 => throw new NotImplementedException(),
            Market.TeamOppTotalOver25 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder25 => throw new NotImplementedException(),
            Market.TeamOppTotalOver3 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder3 => throw new NotImplementedException(),
            Market.TeamOppTotalOver35 => throw new NotImplementedException(),
            Market.TeamOppTotalUnder35 => throw new NotImplementedException(),
            Market.ResultWinOver05 => throw new NotImplementedException(),
            Market.ResultLoseOver05 => throw new NotImplementedException(),
            Market.ResultWinOver15 => throw new NotImplementedException(),
            Market.ResultLoseOver15 => throw new NotImplementedException(),
            Market.ResultWinOver25 => throw new NotImplementedException(),
            Market.ResultLoseOver25 => throw new NotImplementedException(),
            Market.ResultWinOver35 => throw new NotImplementedException(),
            Market.ResultLoseOver35 => throw new NotImplementedException(),
            Market.ResultWinOver45 => throw new NotImplementedException(),
            Market.ResultLoseOver45 => throw new NotImplementedException(),
            Market.AhWinM35 => throw new NotImplementedException(),
            Market.AhLoseM35 => throw new NotImplementedException(),
            Market.AhWinM325 => throw new NotImplementedException(),
            Market.AhLoseM325 => throw new NotImplementedException(),
            Market.AhWinM3 => throw new NotImplementedException(),
            Market.AhLoseM3 => throw new NotImplementedException(),
            Market.AhWinM275 => throw new NotImplementedException(),
            Market.AhLoseM275 => throw new NotImplementedException(),
            Market.AhWinM25 => throw new NotImplementedException(),
            Market.AhLoseM25 => throw new NotImplementedException(),
            Market.AhWinM225 => throw new NotImplementedException(),
            Market.AhLoseM225 => throw new NotImplementedException(),
            Market.AhWinM2 => throw new NotImplementedException(),
            Market.AhLoseM2 => throw new NotImplementedException(),
            Market.AhWinM175 => throw new NotImplementedException(),
            Market.AhLoseM175 => throw new NotImplementedException(),
            Market.AhWinM15 => throw new NotImplementedException(),
            Market.AhLoseM15 => throw new NotImplementedException(),
            Market.AhWinM125 => throw new NotImplementedException(),
            Market.AhLoseM125 => throw new NotImplementedException(),
            Market.AhWinM1 => throw new NotImplementedException(),
            Market.AhLoseM1 => throw new NotImplementedException(),
            Market.AhWinM075 => throw new NotImplementedException(),
            Market.AhLoseM075 => throw new NotImplementedException(),
            Market.AhWinM05 => throw new NotImplementedException(),
            Market.AhLoseM05 => throw new NotImplementedException(),
            Market.AhWinM025 => throw new NotImplementedException(),
            Market.AhLoseM025 => throw new NotImplementedException(),
            Market.AhWin0 => throw new NotImplementedException(),
            Market.AhLose0 => throw new NotImplementedException(),
            Market.AhWin025 => throw new NotImplementedException(),
            Market.AhLose025 => throw new NotImplementedException(),
            Market.AhWinP05 => throw new NotImplementedException(),
            Market.AhLoseP05 => throw new NotImplementedException(),
            Market.AhWin075 => throw new NotImplementedException(),
            Market.AhLose075 => throw new NotImplementedException(),
            Market.AhWinP1 => throw new NotImplementedException(),
            Market.AhLoseP1 => throw new NotImplementedException(),
            Market.AhWinP125 => throw new NotImplementedException(),
            Market.AhLoseP125 => throw new NotImplementedException(),
            Market.AhWinP15 => throw new NotImplementedException(),
            Market.AhLoseP15 => throw new NotImplementedException(),
            Market.AhWinP175 => throw new NotImplementedException(),
            Market.AhLoseP175 => throw new NotImplementedException(),
            Market.AhWinP2 => throw new NotImplementedException(),
            Market.AhLoseP2 => throw new NotImplementedException(),
            Market.AhWinP225 => throw new NotImplementedException(),
            Market.AhLoseP225 => throw new NotImplementedException(),
            Market.AhWinP25 => throw new NotImplementedException(),
            Market.AhLoseP25 => throw new NotImplementedException(),
            Market.AhWinP275 => throw new NotImplementedException(),
            Market.AhLoseP275 => throw new NotImplementedException(),
            Market.AhWinP3 => throw new NotImplementedException(),
            Market.AhLoseP3 => throw new NotImplementedException(),
            Market.AhWinP325 => throw new NotImplementedException(),
            Market.AhLoseP325 => throw new NotImplementedException(),
            Market.AhWinP35 => throw new NotImplementedException(),
            Market.AhLoseP35 => throw new NotImplementedException(),
            Market.CornersUnder25 => throw new NotImplementedException(),
            Market.CornersUnder35 => throw new NotImplementedException(),
            Market.CornersOver45 => throw new NotImplementedException(),
            Market.CornersUnder45 => throw new NotImplementedException(),
            Market.CornersOver55 => throw new NotImplementedException(),
            Market.CornersUnder55 => throw new NotImplementedException(),
            Market.CornersOver65 => throw new NotImplementedException(),
            Market.CornersUnder65 => throw new NotImplementedException(),
            Market.CornersOver75 => throw new NotImplementedException(),
            Market.CornersUnder75 => throw new NotImplementedException(),
            Market.CornersOver85 => throw new NotImplementedException(),
            Market.CornersUnder85 => throw new NotImplementedException(),
            Market.CornersOver95 => throw new NotImplementedException(),
            Market.CornersUnder95 => throw new NotImplementedException(),
            Market.CornersOver105 => throw new NotImplementedException(),
            Market.CornersUnder105 => throw new NotImplementedException(),
            Market.CornersOver115 => throw new NotImplementedException(),
            Market.CornersUnder115 => throw new NotImplementedException(),
            Market.CornersOver125 => throw new NotImplementedException(),
            Market.CornersUnder125 => throw new NotImplementedException(),
            Market.CornersOver135 => throw new NotImplementedException(),
            Market.CornersUnder135 => throw new NotImplementedException(),
            Market.TeamCornersOver05 => throw new NotImplementedException(),
            Market.TeamCornersUnder05 => throw new NotImplementedException(),
            Market.TeamCornersOver1 => throw new NotImplementedException(),
            Market.TeamCornersUnder1 => throw new NotImplementedException(),
            Market.TeamCornersOver15 => throw new NotImplementedException(),
            Market.TeamCornersUnder15 => throw new NotImplementedException(),
            Market.TeamCornersOver2 => throw new NotImplementedException(),
            Market.TeamCornersUnder2 => throw new NotImplementedException(),
            Market.TeamCornersOver25 => throw new NotImplementedException(),
            Market.TeamCornersUnder25 => throw new NotImplementedException(),
            Market.TeamCornersOver3 => throw new NotImplementedException(),
            Market.TeamCornersUnder3 => throw new NotImplementedException(),
            Market.TeamCornersOver35 => throw new NotImplementedException(),
            Market.TeamCornersUnder35 => throw new NotImplementedException(),
            Market.TeamCornersOver4 => throw new NotImplementedException(),
            Market.TeamCornersUnder4 => throw new NotImplementedException(),
            Market.TeamCornersOver45 => throw new NotImplementedException(),
            Market.TeamCornersUnder45 => throw new NotImplementedException(),
            Market.TeamCornersOver5 => throw new NotImplementedException(),
            Market.TeamCornersUnder5 => throw new NotImplementedException(),
            Market.TeamCornersOver55 => throw new NotImplementedException(),
            Market.TeamCornersUnder55 => throw new NotImplementedException(),
            Market.TeamCornersOver6 => throw new NotImplementedException(),
            Market.TeamCornersUnder6 => throw new NotImplementedException(),
            Market.TeamCornersOver65 => throw new NotImplementedException(),
            Market.TeamCornersUnder65 => throw new NotImplementedException(),
            Market.TeamCornersOver7 => throw new NotImplementedException(),
            Market.TeamCornersUnder7 => throw new NotImplementedException(),
            Market.TeamCornersOver75 => throw new NotImplementedException(),
            Market.TeamCornersUnder75 => throw new NotImplementedException(),
            Market.TeamCornersOver8 => throw new NotImplementedException(),
            Market.TeamCornersUnder8 => throw new NotImplementedException(),
            Market.TeamCornersOver85 => throw new NotImplementedException(),
            Market.TeamCornersUnder85 => throw new NotImplementedException(),
            Market.TeamCornersOver9 => throw new NotImplementedException(),
            Market.TeamCornersUnder9 => throw new NotImplementedException(),
            Market.TeamCornersOver95 => throw new NotImplementedException(),
            Market.TeamCornersUnder95 => throw new NotImplementedException(),
            Market.OppCornersOver05 => throw new NotImplementedException(),
            Market.OppCornersUnder05 => throw new NotImplementedException(),
            Market.OppCornersOver1 => throw new NotImplementedException(),
            Market.OppCornersUnder1 => throw new NotImplementedException(),
            Market.OppCornersOver15 => throw new NotImplementedException(),
            Market.OppCornersUnder15 => throw new NotImplementedException(),
            Market.OppCornersOver2 => throw new NotImplementedException(),
            Market.OppCornersUnder2 => throw new NotImplementedException(),
            Market.OppCornersOver25 => throw new NotImplementedException(),
            Market.OppCornersUnder25 => throw new NotImplementedException(),
            Market.OppCornersOver3 => throw new NotImplementedException(),
            Market.OppCornersUnder3 => throw new NotImplementedException(),
            Market.OppCornersOver35 => throw new NotImplementedException(),
            Market.OppCornersUnder35 => throw new NotImplementedException(),
            Market.OppCornersOver4 => throw new NotImplementedException(),
            Market.OppCornersUnder4 => throw new NotImplementedException(),
            Market.OppCornersOver45 => throw new NotImplementedException(),
            Market.OppCornersUnder45 => throw new NotImplementedException(),
            Market.OppCornersOver5 => throw new NotImplementedException(),
            Market.OppCornersUnder5 => throw new NotImplementedException(),
            Market.OppCornersOver55 => throw new NotImplementedException(),
            Market.OppCornersUnder55 => throw new NotImplementedException(),
            Market.OppCornersOver6 => throw new NotImplementedException(),
            Market.OppCornersUnder6 => throw new NotImplementedException(),
            Market.OppCornersOver65 => throw new NotImplementedException(),
            Market.OppCornersUnder65 => throw new NotImplementedException(),
            Market.OppCornersOver7 => throw new NotImplementedException(),
            Market.OppCornersUnder7 => throw new NotImplementedException(),
            Market.OppCornersOver75 => throw new NotImplementedException(),
            Market.OppCornersUnder75 => throw new NotImplementedException(),
            Market.OppCornersOver8 => throw new NotImplementedException(),
            Market.OppCornersUnder8 => throw new NotImplementedException(),
            Market.OppCornersOver85 => throw new NotImplementedException(),
            Market.OppCornersUnder85 => throw new NotImplementedException(),
            Market.OppCornersOver9 => throw new NotImplementedException(),
            Market.OppCornersUnder9 => throw new NotImplementedException(),
            Market.OppCornersOver95 => throw new NotImplementedException(),
            Market.OppCornersUnder95 => throw new NotImplementedException(),
            Market.Corners1x2_Win => throw new NotImplementedException(),
            Market.Corners1x2_Draw => throw new NotImplementedException(),
            Market.Corners1x2_Lose => throw new NotImplementedException(),
            Market.CardsUnder15 => throw new NotImplementedException(),
            Market.CardsUnder2 => throw new NotImplementedException(),
            Market.CardsOver25 => throw new NotImplementedException(),
            Market.CardsUnder25 => throw new NotImplementedException(),
            Market.CardsOver3 => throw new NotImplementedException(),
            Market.CardsUnder3 => throw new NotImplementedException(),
            Market.CardsOver35 => throw new NotImplementedException(),
            Market.CardsUnder35 => throw new NotImplementedException(),
            Market.CardsOver4 => throw new NotImplementedException(),
            Market.CardsUnder4 => throw new NotImplementedException(),
            Market.CardsOver45 => throw new NotImplementedException(),
            Market.CardsUnder45 => throw new NotImplementedException(),
            Market.TeamCardsOver1 => throw new NotImplementedException(),
            Market.TeamCardsUnder1 => throw new NotImplementedException(),
            Market.TeamCardsOver15 => throw new NotImplementedException(),
            Market.TeamCardsUnder15 => throw new NotImplementedException(),
            Market.TeamCardsOver2 => throw new NotImplementedException(),
            Market.TeamCardsUnder2 => throw new NotImplementedException(),
            Market.TeamCardsOver25 => throw new NotImplementedException(),
            Market.TeamCardsUnder25 => throw new NotImplementedException(),
            Market.TeamCardsOver3 => throw new NotImplementedException(),
            Market.TeamCardsUnder3 => throw new NotImplementedException(),
            Market.TeamCardsOver35 => throw new NotImplementedException(),
            Market.TeamCardsUnder35 => throw new NotImplementedException(),
            Market.TeamCardsOver4 => throw new NotImplementedException(),
            Market.TeamCardsUnder4 => throw new NotImplementedException(),
            Market.TeamCardsOver45 => throw new NotImplementedException(),
            Market.TeamCardsUnder45 => throw new NotImplementedException(),
            Market.OppCardsOver1 => throw new NotImplementedException(),
            Market.OppCardsUnder1 => throw new NotImplementedException(),
            Market.OppCardsOver15 => throw new NotImplementedException(),
            Market.OppCardsUnder15 => throw new NotImplementedException(),
            Market.OppCardsOver2 => throw new NotImplementedException(),
            Market.OppCardsUnder2 => throw new NotImplementedException(),
            Market.OppCardsOver25 => throw new NotImplementedException(),
            Market.OppCardsUnder25 => throw new NotImplementedException(),
            Market.OppCardsOver3 => throw new NotImplementedException(),
            Market.OppCardsUnder3 => throw new NotImplementedException(),
            Market.OppCardsOver35 => throw new NotImplementedException(),
            Market.OppCardsUnder35 => throw new NotImplementedException(),
            Market.OppCardsOver4 => throw new NotImplementedException(),
            Market.OppCardsUnder4 => throw new NotImplementedException(),
            Market.OppCardsOver45 => throw new NotImplementedException(),
            Market.OppCardsUnder45 => throw new NotImplementedException(),
            Market.CardsAhWin05 => throw new NotImplementedException(),
            Market.CardsAhLose05 => throw new NotImplementedException(),
            Market.CardsAhWin1 => throw new NotImplementedException(),
            Market.CardsAhLose1 => throw new NotImplementedException(),
            Market.CardsAhWin15 => throw new NotImplementedException(),
            Market.CardsAhLose15 => throw new NotImplementedException(),
            Market.CardsAhWin2 => throw new NotImplementedException(),
            Market.CardsAhLose2 => throw new NotImplementedException(),
            Market.CardsAhWin25 => throw new NotImplementedException(),
            Market.CardsAhLose25 => throw new NotImplementedException(),
            Market.CardsAhWin3 => throw new NotImplementedException(),
            Market.CardsAhLose3 => throw new NotImplementedException(),
            Market.CardsAhWin35 => throw new NotImplementedException(),
            Market.CardsAhLose35 => throw new NotImplementedException(),
            Market.RedCardsYes => throw new NotImplementedException(),
            Market.RedCardsNo => throw new NotImplementedException(),
            Market.YellowCardsWin => throw new NotImplementedException(),
            Market.YellowCardsDraw => throw new NotImplementedException(),
            Market.YellowCardsLose => throw new NotImplementedException(),
            Market.ExactGoals_0 => throw new NotImplementedException(),
            Market.ExactGoals_1 => throw new NotImplementedException(),
            Market.ExactGoals_2 => throw new NotImplementedException(),
            Market.ExactGoals_3 => throw new NotImplementedException(),
            Market.ExactGoals_4 => throw new NotImplementedException(),
            Market.ExactGoals_5 => throw new NotImplementedException(),
            Market.ExactGoals_6 => throw new NotImplementedException(),
            Market.ExactScore_0_0 => throw new NotImplementedException(),
            Market.ExactScore_1_0 => throw new NotImplementedException(),
            Market.ExactScore_2_0 => throw new NotImplementedException(),
            Market.ExactScore_3_0 => throw new NotImplementedException(),
            Market.ExactScore_4_0 => throw new NotImplementedException(),
            Market.ExactScore_1_1 => throw new NotImplementedException(),
            Market.ExactScore_2_1 => throw new NotImplementedException(),
            Market.ExactScore_3_1 => throw new NotImplementedException(),
            Market.ExactScore_4_1 => throw new NotImplementedException(),
            Market.ExactScore_1_2 => throw new NotImplementedException(),
            Market.ExactScore_2_2 => throw new NotImplementedException(),
            Market.ExactScore_3_2 => throw new NotImplementedException(),
            Market.ExactScore_4_2 => throw new NotImplementedException(),
            Market.ExactScore_1_3 => throw new NotImplementedException(),
            Market.ExactScore_2_3 => throw new NotImplementedException(),
            Market.ExactScore_3_3 => throw new NotImplementedException(),
            Market.ExactScore_4_3 => throw new NotImplementedException(),
            Market.ExactScore_1_4 => throw new NotImplementedException(),
            Market.ExactScore_2_4 => throw new NotImplementedException(),
            Market.ExactScore_3_4 => throw new NotImplementedException(),
            Market.ExactScore_4_4 => throw new NotImplementedException(),
            Market.Fouls_1x2_Win => throw new NotImplementedException(),
            Market.Fouls_1x2_Draw => throw new NotImplementedException(),
            Market.Fouls_1x2_Lose => throw new NotImplementedException(),
            Market.FoulsAhWin05 => throw new NotImplementedException(),
            Market.FoulsAhLose05 => throw new NotImplementedException(),
            Market.FoulsAhWin1 => throw new NotImplementedException(),
            Market.FoulsAhLose1 => throw new NotImplementedException(),
            Market.FoulsAhWin15 => throw new NotImplementedException(),
            Market.FoulsAhLose15 => throw new NotImplementedException(),
            Market.FoulsAhWin2 => throw new NotImplementedException(),
            Market.FoulsAhLose2 => throw new NotImplementedException(),
            Market.FoulsAhWin25 => throw new NotImplementedException(),
            Market.FoulsAhLose25 => throw new NotImplementedException(),
            Market.FoulsAhWin3 => throw new NotImplementedException(),
            Market.FoulsAhLose3 => throw new NotImplementedException(),
            Market.FoulsAhWin35 => throw new NotImplementedException(),
            Market.FoulsAhLose35 => throw new NotImplementedException(),
            Market.FoulsAhWin4 => throw new NotImplementedException(),
            Market.FoulsAhLose4 => throw new NotImplementedException(),
            Market.FoulsAhWin45 => throw new NotImplementedException(),
            Market.FoulsAhLose45 => throw new NotImplementedException(),
            Market.FoulsAhWin5 => throw new NotImplementedException(),
            Market.FoulsAhLose5 => throw new NotImplementedException(),
            Market.FoulsAhWin55 => throw new NotImplementedException(),
            Market.FoulsAhLose55 => throw new NotImplementedException(),
            Market.BothHalvesWin => throw new NotImplementedException(),
            Market.BothHalvesDraw => throw new NotImplementedException(),
            Market.BothHalvesLose => throw new NotImplementedException(),
            Market.BtsYes => throw new NotImplementedException(),
            Market.BtsNo => throw new NotImplementedException(),
            Market.TeamCleanSheetYes => throw new NotImplementedException(),
            Market.TeamCleanSheetNo => throw new NotImplementedException(),
            Market.TeamCleanSheetOpp => throw new NotImplementedException(),
            Market.TeamCleanSheetOppNo => throw new NotImplementedException(),
            Market.WinToNilYes => throw new NotImplementedException(),
            Market.WinToNilNo => throw new NotImplementedException(),
            Market.WinEitherHalf => throw new NotImplementedException(),
            Market.WinEitherHalfOpp => throw new NotImplementedException(),
            Market.ScoreFirst => throw new NotImplementedException(),
            Market.ScoreFirstOpp => throw new NotImplementedException(),
            Market.FirstTeamToScore => throw new NotImplementedException(),
            Market.FirstTeamToScoreOpp => throw new NotImplementedException(),
            Market.TeamToScore => throw new NotImplementedException(),
            Market.TeamToScoreNo => throw new NotImplementedException(),
            Market.OppTeamToScore => throw new NotImplementedException(),
            Market.OppTeamToScoreNo => throw new NotImplementedException(),
            Market.BtsInBothHalves => throw new NotImplementedException(),
            Market.OddEven_Odd => throw new NotImplementedException(),
            Market.OddEven_Even => throw new NotImplementedException(),
            Market.TeamOddEven_Odd => throw new NotImplementedException(),
            Market.TeamOddEven_Even => throw new NotImplementedException(),
            Market.OppOddEven_Odd => throw new NotImplementedException(),
            Market.OppTeamOddEven_Even => throw new NotImplementedException(),
            Market.w1x2_15_Win => throw new NotImplementedException(),
            Market.w1x2_15_Draw => throw new NotImplementedException(),
            Market.w1x2_15_Lose => throw new NotImplementedException(),
            Market.w1x2_30_Lose => throw new NotImplementedException(),
            Market.w1x2_30_Draw => throw new NotImplementedException(),
            Market.w1x2_30_Win => throw new NotImplementedException(),
            Market.w1x2_60_Lose => throw new NotImplementedException(),
            Market.w1x2_60_Draw => throw new NotImplementedException(),
            Market.w1x2_60_Win => throw new NotImplementedException(),
            Market.w1x2_75_Lose => throw new NotImplementedException(),
            Market.w1x2_75_Draw => throw new NotImplementedException(),
            Market.w1x2_75_Win => throw new NotImplementedException(),
            Market.DC_15_WinOrDraw => throw new NotImplementedException(),
            Market.DC_15_LoseOrDraw => throw new NotImplementedException(),
            Market.DC_15_WinOrLose => throw new NotImplementedException(),
            Market.DC_30_WinOrDraw => throw new NotImplementedException(),
            Market.DC_30_LoseOrDraw => throw new NotImplementedException(),
            Market.DC_30_WinOrLose => throw new NotImplementedException(),
            Market.DC_75_WinOrDraw => throw new NotImplementedException(),
            Market.DC_75_LoseOrDraw => throw new NotImplementedException(),
            Market.DC_75_WinOrLose => throw new NotImplementedException(),
            Market.GoalIn_1_15_Yes => throw new NotImplementedException(),
            Market.GoalIn_1_15_No => throw new NotImplementedException(),
            Market.GoalIn_16_30_Yes => throw new NotImplementedException(),
            Market.GoalIn_31_45_No => throw new NotImplementedException(),
            Market.GoalIn_46_60_Yes => throw new NotImplementedException(),
            Market.GoalIn_46_60_No => throw new NotImplementedException(),
            Market.GoalIn_61_75_Yes => throw new NotImplementedException(),
            Market.GoalIn_61_75_No => throw new NotImplementedException(),
            Market.GoalIn_76_90_Yes => throw new NotImplementedException(),
            Market.GoalIn_76_90_No => throw new NotImplementedException(),
            Market.PenaltyAwardedYes => throw new NotImplementedException(),
            Market.PenaltyAwardedNo => throw new NotImplementedException(),

            _ => null
        };

        return profitOdds - 1;

        #region local functions

        // Получить значение коэфициента на основе идентификатора. Значения можно найти в markets.csv
        // в enum Market есть названия ставок. Над группой ставок есть строковый идентификатор, например 'Asian Handicap | Asian Handicap First Half | Asian Handicap (2nd Half)'
        // По этим строковым идентификаторам нужно искать числовой идентификатор для каждого из таймов
        float? OddsVal(params short[] betId)
        {
            foreach (var id in betId)
            {
                if (game.Odds!.TryGetValue(id, out var o))
                    return o;
            }

            return null;
        }

        float? Odds()
        {
            return period switch
            {
                1 => GetOdds1Half(market),
                2 => GetOdds2Half(market),
                _ => GetOdds(market)
            };
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

                Market.CornersOver25 => OddsVal(677),
                Market.CornersUnder25 => OddsVal(678),
                Market.CardsOver15 => OddsVal(1271),
                Market.CardsUnder15 => OddsVal(1272),
                Market.CardsOver2 => OddsVal(1269),
                Market.CardsUnder2 => OddsVal(1270),
                Market.TeamCardsOver05 => IsHome() ? OddsVal(1291) : OddsVal(1299),
                Market.TeamCardsUnder05 => IsHome() ? OddsVal(1292) : OddsVal(1300),
                Market.OppCardsOver05 => _teamId == game.HomeTeamId ? OddsVal(1299) : OddsVal(1291),
                Market.OppCardsUnder05 => _teamId == game.HomeTeamId ? OddsVal(1300) : OddsVal(1292),
                Market.TeamCleanSheetYes => IsHome() ? OddsVal(2473, 164) : OddsVal(2474, 166),
                Market.TeamCleanSheetOpp => IsHome() ? OddsVal(2474, 166) : OddsVal(2473, 164),

                // TODO Реализовать остальные исходы

                Market.TotalOver05 => throw new NotImplementedException(),
                Market.TotalUnder05 => throw new NotImplementedException(),
                Market.TotalOver1 => throw new NotImplementedException(),
                Market.TotalUnder1 => throw new NotImplementedException(),
                Market.TotalOver15 => throw new NotImplementedException(),
                Market.TotalUnder15 => throw new NotImplementedException(),
                Market.TotalOver2 => throw new NotImplementedException(),
                Market.TotalUnder2 => throw new NotImplementedException(),
                Market.TotalOver25 => throw new NotImplementedException(),
                Market.TotalUnder25 => throw new NotImplementedException(),
                Market.TotalOver3 => throw new NotImplementedException(),
                Market.TotalUnder3 => throw new NotImplementedException(),
                Market.TotalOver35 => throw new NotImplementedException(),
                Market.TotalUnder35 => throw new NotImplementedException(),
                Market.TotalOver4 => throw new NotImplementedException(),
                Market.TotalUnder4 => throw new NotImplementedException(),
                Market.TotalOver45 => throw new NotImplementedException(),
                Market.TotalUnder45 => throw new NotImplementedException(),
                Market.TeamTotalOver05 => throw new NotImplementedException(),
                Market.TeamTotalUnder05 => throw new NotImplementedException(),
                Market.TeamTotalOver1 => throw new NotImplementedException(),
                Market.TeamTotalUnder1 => throw new NotImplementedException(),
                Market.TeamTotalOver15 => throw new NotImplementedException(),
                Market.TeamTotalUnder15 => throw new NotImplementedException(),
                Market.TeamTotalOver2 => throw new NotImplementedException(),
                Market.TeamTotalUnder2 => throw new NotImplementedException(),
                Market.TeamTotalOver25 => throw new NotImplementedException(),
                Market.TeamTotalUnder25 => throw new NotImplementedException(),
                Market.TeamTotalOver3 => throw new NotImplementedException(),
                Market.TeamTotalUnder3 => throw new NotImplementedException(),
                Market.TeamTotalOver35 => throw new NotImplementedException(),
                Market.TeamTotalUnder35 => throw new NotImplementedException(),
                Market.TeamOppTotalOver05 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder05 => throw new NotImplementedException(),
                Market.TeamOppTotalOver1 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder1 => throw new NotImplementedException(),
                Market.TeamOppTotalOver15 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder15 => throw new NotImplementedException(),
                Market.TeamOppTotalOver2 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder2 => throw new NotImplementedException(),
                Market.TeamOppTotalOver25 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder25 => throw new NotImplementedException(),
                Market.TeamOppTotalOver3 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder3 => throw new NotImplementedException(),
                Market.TeamOppTotalOver35 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder35 => throw new NotImplementedException(),
                Market.ResultWinOver05 => throw new NotImplementedException(),
                Market.ResultLoseOver05 => throw new NotImplementedException(),
                Market.ResultWinOver15 => throw new NotImplementedException(),
                Market.ResultLoseOver15 => throw new NotImplementedException(),
                Market.ResultWinOver25 => throw new NotImplementedException(),
                Market.ResultLoseOver25 => throw new NotImplementedException(),
                Market.ResultWinOver35 => throw new NotImplementedException(),
                Market.ResultLoseOver35 => throw new NotImplementedException(),
                Market.ResultWinOver45 => throw new NotImplementedException(),
                Market.ResultLoseOver45 => throw new NotImplementedException(),
                Market.AhWinM35 => throw new NotImplementedException(),
                Market.AhLoseM35 => throw new NotImplementedException(),
                Market.AhWinM325 => throw new NotImplementedException(),
                Market.AhLoseM325 => throw new NotImplementedException(),
                Market.AhWinM3 => throw new NotImplementedException(),
                Market.AhLoseM3 => throw new NotImplementedException(),
                Market.AhWinM275 => throw new NotImplementedException(),
                Market.AhLoseM275 => throw new NotImplementedException(),
                Market.AhWinM25 => throw new NotImplementedException(),
                Market.AhLoseM25 => throw new NotImplementedException(),
                Market.AhWinM225 => throw new NotImplementedException(),
                Market.AhLoseM225 => throw new NotImplementedException(),
                Market.AhWinM2 => throw new NotImplementedException(),
                Market.AhLoseM2 => throw new NotImplementedException(),
                Market.AhWinM175 => throw new NotImplementedException(),
                Market.AhLoseM175 => throw new NotImplementedException(),
                Market.AhWinM15 => throw new NotImplementedException(),
                Market.AhLoseM15 => throw new NotImplementedException(),
                Market.AhWinM125 => throw new NotImplementedException(),
                Market.AhLoseM125 => throw new NotImplementedException(),
                Market.AhWinM1 => throw new NotImplementedException(),
                Market.AhLoseM1 => throw new NotImplementedException(),
                Market.AhWinM075 => throw new NotImplementedException(),
                Market.AhLoseM075 => throw new NotImplementedException(),
                Market.AhWinM05 => throw new NotImplementedException(),
                Market.AhLoseM05 => throw new NotImplementedException(),
                Market.AhWinM025 => throw new NotImplementedException(),
                Market.AhLoseM025 => throw new NotImplementedException(),
                Market.AhWin0 => throw new NotImplementedException(),
                Market.AhLose0 => throw new NotImplementedException(),
                Market.AhWin025 => throw new NotImplementedException(),
                Market.AhLose025 => throw new NotImplementedException(),
                Market.AhWinP05 => throw new NotImplementedException(),
                Market.AhLoseP05 => throw new NotImplementedException(),
                Market.AhWin075 => throw new NotImplementedException(),
                Market.AhLose075 => throw new NotImplementedException(),
                Market.AhWinP1 => throw new NotImplementedException(),
                Market.AhLoseP1 => throw new NotImplementedException(),
                Market.AhWinP125 => throw new NotImplementedException(),
                Market.AhLoseP125 => throw new NotImplementedException(),
                Market.AhWinP15 => throw new NotImplementedException(),
                Market.AhLoseP15 => throw new NotImplementedException(),
                Market.AhWinP175 => throw new NotImplementedException(),
                Market.AhLoseP175 => throw new NotImplementedException(),
                Market.AhWinP2 => throw new NotImplementedException(),
                Market.AhLoseP2 => throw new NotImplementedException(),
                Market.AhWinP225 => throw new NotImplementedException(),
                Market.AhLoseP225 => throw new NotImplementedException(),
                Market.AhWinP25 => throw new NotImplementedException(),
                Market.AhLoseP25 => throw new NotImplementedException(),
                Market.AhWinP275 => throw new NotImplementedException(),
                Market.AhLoseP275 => throw new NotImplementedException(),
                Market.AhWinP3 => throw new NotImplementedException(),
                Market.AhLoseP3 => throw new NotImplementedException(),
                Market.AhWinP325 => throw new NotImplementedException(),
                Market.AhLoseP325 => throw new NotImplementedException(),
                Market.AhWinP35 => throw new NotImplementedException(),
                Market.AhLoseP35 => throw new NotImplementedException(),
                Market.CornersOver35 => throw new NotImplementedException(),
                Market.CornersUnder35 => throw new NotImplementedException(),
                Market.CornersOver45 => throw new NotImplementedException(),
                Market.CornersUnder45 => throw new NotImplementedException(),
                Market.CornersOver55 => throw new NotImplementedException(),
                Market.CornersUnder55 => throw new NotImplementedException(),
                Market.CornersOver65 => throw new NotImplementedException(),
                Market.CornersUnder65 => throw new NotImplementedException(),
                Market.CornersOver75 => throw new NotImplementedException(),
                Market.CornersUnder75 => throw new NotImplementedException(),
                Market.CornersOver85 => throw new NotImplementedException(),
                Market.CornersUnder85 => throw new NotImplementedException(),
                Market.CornersOver95 => throw new NotImplementedException(),
                Market.CornersUnder95 => throw new NotImplementedException(),
                Market.CornersOver105 => throw new NotImplementedException(),
                Market.CornersUnder105 => throw new NotImplementedException(),
                Market.CornersOver115 => throw new NotImplementedException(),
                Market.CornersUnder115 => throw new NotImplementedException(),
                Market.CornersOver125 => throw new NotImplementedException(),
                Market.CornersUnder125 => throw new NotImplementedException(),
                Market.CornersOver135 => throw new NotImplementedException(),
                Market.CornersUnder135 => throw new NotImplementedException(),
                Market.TeamCornersOver05 => throw new NotImplementedException(),
                Market.TeamCornersUnder05 => throw new NotImplementedException(),
                Market.TeamCornersOver1 => throw new NotImplementedException(),
                Market.TeamCornersUnder1 => throw new NotImplementedException(),
                Market.TeamCornersOver15 => throw new NotImplementedException(),
                Market.TeamCornersUnder15 => throw new NotImplementedException(),
                Market.TeamCornersOver2 => throw new NotImplementedException(),
                Market.TeamCornersUnder2 => throw new NotImplementedException(),
                Market.TeamCornersOver25 => throw new NotImplementedException(),
                Market.TeamCornersUnder25 => throw new NotImplementedException(),
                Market.TeamCornersOver3 => throw new NotImplementedException(),
                Market.TeamCornersUnder3 => throw new NotImplementedException(),
                Market.TeamCornersOver35 => throw new NotImplementedException(),
                Market.TeamCornersUnder35 => throw new NotImplementedException(),
                Market.TeamCornersOver4 => throw new NotImplementedException(),
                Market.TeamCornersUnder4 => throw new NotImplementedException(),
                Market.TeamCornersOver45 => throw new NotImplementedException(),
                Market.TeamCornersUnder45 => throw new NotImplementedException(),
                Market.TeamCornersOver5 => throw new NotImplementedException(),
                Market.TeamCornersUnder5 => throw new NotImplementedException(),
                Market.TeamCornersOver55 => throw new NotImplementedException(),
                Market.TeamCornersUnder55 => throw new NotImplementedException(),
                Market.TeamCornersOver6 => throw new NotImplementedException(),
                Market.TeamCornersUnder6 => throw new NotImplementedException(),
                Market.TeamCornersOver65 => throw new NotImplementedException(),
                Market.TeamCornersUnder65 => throw new NotImplementedException(),
                Market.TeamCornersOver7 => throw new NotImplementedException(),
                Market.TeamCornersUnder7 => throw new NotImplementedException(),
                Market.TeamCornersOver75 => throw new NotImplementedException(),
                Market.TeamCornersUnder75 => throw new NotImplementedException(),
                Market.TeamCornersOver8 => throw new NotImplementedException(),
                Market.TeamCornersUnder8 => throw new NotImplementedException(),
                Market.TeamCornersOver85 => throw new NotImplementedException(),
                Market.TeamCornersUnder85 => throw new NotImplementedException(),
                Market.TeamCornersOver9 => throw new NotImplementedException(),
                Market.TeamCornersUnder9 => throw new NotImplementedException(),
                Market.TeamCornersOver95 => throw new NotImplementedException(),
                Market.TeamCornersUnder95 => throw new NotImplementedException(),
                Market.OppCornersOver05 => throw new NotImplementedException(),
                Market.OppCornersUnder05 => throw new NotImplementedException(),
                Market.OppCornersOver1 => throw new NotImplementedException(),
                Market.OppCornersUnder1 => throw new NotImplementedException(),
                Market.OppCornersOver15 => throw new NotImplementedException(),
                Market.OppCornersUnder15 => throw new NotImplementedException(),
                Market.OppCornersOver2 => throw new NotImplementedException(),
                Market.OppCornersUnder2 => throw new NotImplementedException(),
                Market.OppCornersOver25 => throw new NotImplementedException(),
                Market.OppCornersUnder25 => throw new NotImplementedException(),
                Market.OppCornersOver3 => throw new NotImplementedException(),
                Market.OppCornersUnder3 => throw new NotImplementedException(),
                Market.OppCornersOver35 => throw new NotImplementedException(),
                Market.OppCornersUnder35 => throw new NotImplementedException(),
                Market.OppCornersOver4 => throw new NotImplementedException(),
                Market.OppCornersUnder4 => throw new NotImplementedException(),
                Market.OppCornersOver45 => throw new NotImplementedException(),
                Market.OppCornersUnder45 => throw new NotImplementedException(),
                Market.OppCornersOver5 => throw new NotImplementedException(),
                Market.OppCornersUnder5 => throw new NotImplementedException(),
                Market.OppCornersOver55 => throw new NotImplementedException(),
                Market.OppCornersUnder55 => throw new NotImplementedException(),
                Market.OppCornersOver6 => throw new NotImplementedException(),
                Market.OppCornersUnder6 => throw new NotImplementedException(),
                Market.OppCornersOver65 => throw new NotImplementedException(),
                Market.OppCornersUnder65 => throw new NotImplementedException(),
                Market.OppCornersOver7 => throw new NotImplementedException(),
                Market.OppCornersUnder7 => throw new NotImplementedException(),
                Market.OppCornersOver75 => throw new NotImplementedException(),
                Market.OppCornersUnder75 => throw new NotImplementedException(),
                Market.OppCornersOver8 => throw new NotImplementedException(),
                Market.OppCornersUnder8 => throw new NotImplementedException(),
                Market.OppCornersOver85 => throw new NotImplementedException(),
                Market.OppCornersUnder85 => throw new NotImplementedException(),
                Market.OppCornersOver9 => throw new NotImplementedException(),
                Market.OppCornersUnder9 => throw new NotImplementedException(),
                Market.OppCornersOver95 => throw new NotImplementedException(),
                Market.OppCornersUnder95 => throw new NotImplementedException(),
                Market.Corners1x2_Win => throw new NotImplementedException(),
                Market.Corners1x2_Draw => throw new NotImplementedException(),
                Market.Corners1x2_Lose => throw new NotImplementedException(),
                Market.CardsOver25 => throw new NotImplementedException(),
                Market.CardsUnder25 => throw new NotImplementedException(),
                Market.CardsOver3 => throw new NotImplementedException(),
                Market.CardsUnder3 => throw new NotImplementedException(),
                Market.CardsOver35 => throw new NotImplementedException(),
                Market.CardsUnder35 => throw new NotImplementedException(),
                Market.CardsOver4 => throw new NotImplementedException(),
                Market.CardsUnder4 => throw new NotImplementedException(),
                Market.CardsOver45 => throw new NotImplementedException(),
                Market.CardsUnder45 => throw new NotImplementedException(),
                Market.TeamCardsOver1 => throw new NotImplementedException(),
                Market.TeamCardsUnder1 => throw new NotImplementedException(),
                Market.TeamCardsOver15 => throw new NotImplementedException(),
                Market.TeamCardsUnder15 => throw new NotImplementedException(),
                Market.TeamCardsOver2 => throw new NotImplementedException(),
                Market.TeamCardsUnder2 => throw new NotImplementedException(),
                Market.TeamCardsOver25 => throw new NotImplementedException(),
                Market.TeamCardsUnder25 => throw new NotImplementedException(),
                Market.TeamCardsOver3 => throw new NotImplementedException(),
                Market.TeamCardsUnder3 => throw new NotImplementedException(),
                Market.TeamCardsOver35 => throw new NotImplementedException(),
                Market.TeamCardsUnder35 => throw new NotImplementedException(),
                Market.TeamCardsOver4 => throw new NotImplementedException(),
                Market.TeamCardsUnder4 => throw new NotImplementedException(),
                Market.TeamCardsOver45 => throw new NotImplementedException(),
                Market.TeamCardsUnder45 => throw new NotImplementedException(),
                Market.OppCardsOver1 => throw new NotImplementedException(),
                Market.OppCardsUnder1 => throw new NotImplementedException(),
                Market.OppCardsOver15 => throw new NotImplementedException(),
                Market.OppCardsUnder15 => throw new NotImplementedException(),
                Market.OppCardsOver2 => throw new NotImplementedException(),
                Market.OppCardsUnder2 => throw new NotImplementedException(),
                Market.OppCardsOver25 => throw new NotImplementedException(),
                Market.OppCardsUnder25 => throw new NotImplementedException(),
                Market.OppCardsOver3 => throw new NotImplementedException(),
                Market.OppCardsUnder3 => throw new NotImplementedException(),
                Market.OppCardsOver35 => throw new NotImplementedException(),
                Market.OppCardsUnder35 => throw new NotImplementedException(),
                Market.OppCardsOver4 => throw new NotImplementedException(),
                Market.OppCardsUnder4 => throw new NotImplementedException(),
                Market.OppCardsOver45 => throw new NotImplementedException(),
                Market.OppCardsUnder45 => throw new NotImplementedException(),
                Market.CardsAhWin05 => throw new NotImplementedException(),
                Market.CardsAhLose05 => throw new NotImplementedException(),
                Market.CardsAhWin1 => throw new NotImplementedException(),
                Market.CardsAhLose1 => throw new NotImplementedException(),
                Market.CardsAhWin15 => throw new NotImplementedException(),
                Market.CardsAhLose15 => throw new NotImplementedException(),
                Market.CardsAhWin2 => throw new NotImplementedException(),
                Market.CardsAhLose2 => throw new NotImplementedException(),
                Market.CardsAhWin25 => throw new NotImplementedException(),
                Market.CardsAhLose25 => throw new NotImplementedException(),
                Market.CardsAhWin3 => throw new NotImplementedException(),
                Market.CardsAhLose3 => throw new NotImplementedException(),
                Market.CardsAhWin35 => throw new NotImplementedException(),
                Market.CardsAhLose35 => throw new NotImplementedException(),
                Market.RedCardsYes => throw new NotImplementedException(),
                Market.RedCardsNo => throw new NotImplementedException(),
                Market.YellowCardsWin => throw new NotImplementedException(),
                Market.YellowCardsDraw => throw new NotImplementedException(),
                Market.YellowCardsLose => throw new NotImplementedException(),
                Market.ExactGoals_0 => throw new NotImplementedException(),
                Market.ExactGoals_1 => throw new NotImplementedException(),
                Market.ExactGoals_2 => throw new NotImplementedException(),
                Market.ExactGoals_3 => throw new NotImplementedException(),
                Market.ExactGoals_4 => throw new NotImplementedException(),
                Market.ExactGoals_5 => throw new NotImplementedException(),
                Market.ExactGoals_6 => throw new NotImplementedException(),
                Market.ExactScore_0_0 => throw new NotImplementedException(),
                Market.ExactScore_1_0 => throw new NotImplementedException(),
                Market.ExactScore_2_0 => throw new NotImplementedException(),
                Market.ExactScore_3_0 => throw new NotImplementedException(),
                Market.ExactScore_4_0 => throw new NotImplementedException(),
                Market.ExactScore_1_1 => throw new NotImplementedException(),
                Market.ExactScore_2_1 => throw new NotImplementedException(),
                Market.ExactScore_3_1 => throw new NotImplementedException(),
                Market.ExactScore_4_1 => throw new NotImplementedException(),
                Market.ExactScore_1_2 => throw new NotImplementedException(),
                Market.ExactScore_2_2 => throw new NotImplementedException(),
                Market.ExactScore_3_2 => throw new NotImplementedException(),
                Market.ExactScore_4_2 => throw new NotImplementedException(),
                Market.ExactScore_1_3 => throw new NotImplementedException(),
                Market.ExactScore_2_3 => throw new NotImplementedException(),
                Market.ExactScore_3_3 => throw new NotImplementedException(),
                Market.ExactScore_4_3 => throw new NotImplementedException(),
                Market.ExactScore_1_4 => throw new NotImplementedException(),
                Market.ExactScore_2_4 => throw new NotImplementedException(),
                Market.ExactScore_3_4 => throw new NotImplementedException(),
                Market.ExactScore_4_4 => throw new NotImplementedException(),
                Market.Fouls_1x2_Win => throw new NotImplementedException(),
                Market.Fouls_1x2_Draw => throw new NotImplementedException(),
                Market.Fouls_1x2_Lose => throw new NotImplementedException(),
                Market.FoulsAhWin05 => throw new NotImplementedException(),
                Market.FoulsAhLose05 => throw new NotImplementedException(),
                Market.FoulsAhWin1 => throw new NotImplementedException(),
                Market.FoulsAhLose1 => throw new NotImplementedException(),
                Market.FoulsAhWin15 => throw new NotImplementedException(),
                Market.FoulsAhLose15 => throw new NotImplementedException(),
                Market.FoulsAhWin2 => throw new NotImplementedException(),
                Market.FoulsAhLose2 => throw new NotImplementedException(),
                Market.FoulsAhWin25 => throw new NotImplementedException(),
                Market.FoulsAhLose25 => throw new NotImplementedException(),
                Market.FoulsAhWin3 => throw new NotImplementedException(),
                Market.FoulsAhLose3 => throw new NotImplementedException(),
                Market.FoulsAhWin35 => throw new NotImplementedException(),
                Market.FoulsAhLose35 => throw new NotImplementedException(),
                Market.FoulsAhWin4 => throw new NotImplementedException(),
                Market.FoulsAhLose4 => throw new NotImplementedException(),
                Market.FoulsAhWin45 => throw new NotImplementedException(),
                Market.FoulsAhLose45 => throw new NotImplementedException(),
                Market.FoulsAhWin5 => throw new NotImplementedException(),
                Market.FoulsAhLose5 => throw new NotImplementedException(),
                Market.FoulsAhWin55 => throw new NotImplementedException(),
                Market.FoulsAhLose55 => throw new NotImplementedException(),
                Market.BothHalvesWin => throw new NotImplementedException(),
                Market.BothHalvesLose => throw new NotImplementedException(),
                Market.BtsYes => throw new NotImplementedException(),
                Market.BtsNo => throw new NotImplementedException(),
                Market.TeamCleanSheetNo => throw new NotImplementedException(),
                Market.TeamCleanSheetOppNo => throw new NotImplementedException(),
                Market.WinToNilYes => throw new NotImplementedException(),
                Market.WinToNilNo => throw new NotImplementedException(),
                Market.WinEitherHalf => throw new NotImplementedException(),
                Market.WinEitherHalfOpp => throw new NotImplementedException(),
                Market.ScoreFirst => throw new NotImplementedException(),
                Market.ScoreFirstOpp => throw new NotImplementedException(),
                Market.FirstTeamToScore => throw new NotImplementedException(),
                Market.FirstTeamToScoreOpp => throw new NotImplementedException(),
                Market.TeamToScore => throw new NotImplementedException(),
                Market.TeamToScoreNo => throw new NotImplementedException(),
                Market.OppTeamToScore => throw new NotImplementedException(),
                Market.OppTeamToScoreNo => throw new NotImplementedException(),
                Market.BtsInBothHalves => throw new NotImplementedException(),
                Market.OddEven_Odd => throw new NotImplementedException(),
                Market.OddEven_Even => throw new NotImplementedException(),
                Market.TeamOddEven_Odd => throw new NotImplementedException(),
                Market.TeamOddEven_Even => throw new NotImplementedException(),
                Market.OppOddEven_Odd => throw new NotImplementedException(),
                Market.OppTeamOddEven_Even => throw new NotImplementedException(),
                Market.w1x2_15_Win => throw new NotImplementedException(),
                Market.w1x2_15_Draw => throw new NotImplementedException(),
                Market.w1x2_15_Lose => throw new NotImplementedException(),
                Market.w1x2_30_Lose => throw new NotImplementedException(),
                Market.w1x2_30_Draw => throw new NotImplementedException(),
                Market.w1x2_30_Win => throw new NotImplementedException(),
                Market.w1x2_60_Lose => throw new NotImplementedException(),
                Market.w1x2_60_Draw => throw new NotImplementedException(),
                Market.w1x2_60_Win => throw new NotImplementedException(),
                Market.w1x2_75_Lose => throw new NotImplementedException(),
                Market.w1x2_75_Draw => throw new NotImplementedException(),
                Market.w1x2_75_Win => throw new NotImplementedException(),
                Market.DC_15_WinOrDraw => throw new NotImplementedException(),
                Market.DC_15_LoseOrDraw => throw new NotImplementedException(),
                Market.DC_15_WinOrLose => throw new NotImplementedException(),
                Market.DC_30_WinOrDraw => throw new NotImplementedException(),
                Market.DC_30_LoseOrDraw => throw new NotImplementedException(),
                Market.DC_30_WinOrLose => throw new NotImplementedException(),
                Market.DC_75_WinOrDraw => throw new NotImplementedException(),
                Market.DC_75_LoseOrDraw => throw new NotImplementedException(),
                Market.DC_75_WinOrLose => throw new NotImplementedException(),
                Market.GoalIn_1_15_Yes => throw new NotImplementedException(),
                Market.GoalIn_1_15_No => throw new NotImplementedException(),
                Market.GoalIn_16_30_Yes => throw new NotImplementedException(),
                Market.GoalIn_31_45_No => throw new NotImplementedException(),
                Market.GoalIn_46_60_Yes => throw new NotImplementedException(),
                Market.GoalIn_46_60_No => throw new NotImplementedException(),
                Market.GoalIn_61_75_Yes => throw new NotImplementedException(),
                Market.GoalIn_61_75_No => throw new NotImplementedException(),
                Market.GoalIn_76_90_Yes => throw new NotImplementedException(),
                Market.GoalIn_76_90_No => throw new NotImplementedException(),
                Market.PenaltyAwardedYes => throw new NotImplementedException(),
                Market.PenaltyAwardedNo => throw new NotImplementedException(),


                _ => null
            };
        }

        float? GetOdds1Half(Market m)
        {
            return m switch
            {
                Market.Win => IsHome() ? OddsVal(431) : OddsVal(433),
                Market.Draw => OddsVal(432),
                Market.Lose => IsHome() ? OddsVal(433) : OddsVal(431),

                // TODO Реализовать остальные исходы

                Market.WinOrDraw => throw new NotImplementedException(),
                Market.WinOrLose => throw new NotImplementedException(),
                Market.DrawOrLose => throw new NotImplementedException(),
                Market.WinNoBet => throw new NotImplementedException(),
                Market.LoseNoBet => throw new NotImplementedException(),
                Market.TotalOver05 => throw new NotImplementedException(),
                Market.TotalUnder05 => throw new NotImplementedException(),
                Market.TotalOver1 => throw new NotImplementedException(),
                Market.TotalUnder1 => throw new NotImplementedException(),
                Market.TotalOver15 => throw new NotImplementedException(),
                Market.TotalUnder15 => throw new NotImplementedException(),
                Market.TotalOver2 => throw new NotImplementedException(),
                Market.TotalUnder2 => throw new NotImplementedException(),
                Market.TotalOver25 => throw new NotImplementedException(),
                Market.TotalUnder25 => throw new NotImplementedException(),
                Market.TotalOver3 => throw new NotImplementedException(),
                Market.TotalUnder3 => throw new NotImplementedException(),
                Market.TotalOver35 => throw new NotImplementedException(),
                Market.TotalUnder35 => throw new NotImplementedException(),
                Market.TotalOver4 => throw new NotImplementedException(),
                Market.TotalUnder4 => throw new NotImplementedException(),
                Market.TotalOver45 => throw new NotImplementedException(),
                Market.TotalUnder45 => throw new NotImplementedException(),
                Market.TeamTotalOver05 => throw new NotImplementedException(),
                Market.TeamTotalUnder05 => throw new NotImplementedException(),
                Market.TeamTotalOver1 => throw new NotImplementedException(),
                Market.TeamTotalUnder1 => throw new NotImplementedException(),
                Market.TeamTotalOver15 => throw new NotImplementedException(),
                Market.TeamTotalUnder15 => throw new NotImplementedException(),
                Market.TeamTotalOver2 => throw new NotImplementedException(),
                Market.TeamTotalUnder2 => throw new NotImplementedException(),
                Market.TeamTotalOver25 => throw new NotImplementedException(),
                Market.TeamTotalUnder25 => throw new NotImplementedException(),
                Market.TeamTotalOver3 => throw new NotImplementedException(),
                Market.TeamTotalUnder3 => throw new NotImplementedException(),
                Market.TeamTotalOver35 => throw new NotImplementedException(),
                Market.TeamTotalUnder35 => throw new NotImplementedException(),
                Market.TeamOppTotalOver05 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder05 => throw new NotImplementedException(),
                Market.TeamOppTotalOver1 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder1 => throw new NotImplementedException(),
                Market.TeamOppTotalOver15 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder15 => throw new NotImplementedException(),
                Market.TeamOppTotalOver2 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder2 => throw new NotImplementedException(),
                Market.TeamOppTotalOver25 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder25 => throw new NotImplementedException(),
                Market.TeamOppTotalOver3 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder3 => throw new NotImplementedException(),
                Market.TeamOppTotalOver35 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder35 => throw new NotImplementedException(),
                
                Market.AhWinM35 => throw new NotImplementedException(),
                Market.AhLoseM35 => throw new NotImplementedException(),
                Market.AhWinM325 => throw new NotImplementedException(),
                Market.AhLoseM325 => throw new NotImplementedException(),
                Market.AhWinM3 => throw new NotImplementedException(),
                Market.AhLoseM3 => throw new NotImplementedException(),
                Market.AhWinM275 => throw new NotImplementedException(),
                Market.AhLoseM275 => throw new NotImplementedException(),
                Market.AhWinM25 => throw new NotImplementedException(),
                Market.AhLoseM25 => throw new NotImplementedException(),
                Market.AhWinM225 => throw new NotImplementedException(),
                Market.AhLoseM225 => throw new NotImplementedException(),
                Market.AhWinM2 => throw new NotImplementedException(),
                Market.AhLoseM2 => throw new NotImplementedException(),
                Market.AhWinM175 => throw new NotImplementedException(),
                Market.AhLoseM175 => throw new NotImplementedException(),
                Market.AhWinM15 => throw new NotImplementedException(),
                Market.AhLoseM15 => throw new NotImplementedException(),
                Market.AhWinM125 => throw new NotImplementedException(),
                Market.AhLoseM125 => throw new NotImplementedException(),
                Market.AhWinM1 => throw new NotImplementedException(),
                Market.AhLoseM1 => throw new NotImplementedException(),
                Market.AhWinM075 => throw new NotImplementedException(),
                Market.AhLoseM075 => throw new NotImplementedException(),
                Market.AhWinM05 => throw new NotImplementedException(),
                Market.AhLoseM05 => throw new NotImplementedException(),
                Market.AhWinM025 => throw new NotImplementedException(),
                Market.AhLoseM025 => throw new NotImplementedException(),
                Market.AhWin0 => throw new NotImplementedException(),
                Market.AhLose0 => throw new NotImplementedException(),
                Market.AhWin025 => throw new NotImplementedException(),
                Market.AhLose025 => throw new NotImplementedException(),
                Market.AhWinP05 => throw new NotImplementedException(),
                Market.AhLoseP05 => throw new NotImplementedException(),
                Market.AhWin075 => throw new NotImplementedException(),
                Market.AhLose075 => throw new NotImplementedException(),
                Market.AhWinP1 => throw new NotImplementedException(),
                Market.AhLoseP1 => throw new NotImplementedException(),
                Market.AhWinP125 => throw new NotImplementedException(),
                Market.AhLoseP125 => throw new NotImplementedException(),
                Market.AhWinP15 => throw new NotImplementedException(),
                Market.AhLoseP15 => throw new NotImplementedException(),
                Market.AhWinP175 => throw new NotImplementedException(),
                Market.AhLoseP175 => throw new NotImplementedException(),
                Market.AhWinP2 => throw new NotImplementedException(),
                Market.AhLoseP2 => throw new NotImplementedException(),
                Market.AhWinP225 => throw new NotImplementedException(),
                Market.AhLoseP225 => throw new NotImplementedException(),
                Market.AhWinP25 => throw new NotImplementedException(),
                Market.AhLoseP25 => throw new NotImplementedException(),
                Market.AhWinP275 => throw new NotImplementedException(),
                Market.AhLoseP275 => throw new NotImplementedException(),
                Market.AhWinP3 => throw new NotImplementedException(),
                Market.AhLoseP3 => throw new NotImplementedException(),
                Market.AhWinP325 => throw new NotImplementedException(),
                Market.AhLoseP325 => throw new NotImplementedException(),
                Market.AhWinP35 => throw new NotImplementedException(),
                Market.AhLoseP35 => throw new NotImplementedException(),

                Market.ExactGoals_0 => throw new NotImplementedException(),
                Market.ExactGoals_1 => throw new NotImplementedException(),
                Market.ExactGoals_2 => throw new NotImplementedException(),
                Market.ExactGoals_3 => throw new NotImplementedException(),
                Market.ExactGoals_4 => throw new NotImplementedException(),
                Market.ExactGoals_5 => throw new NotImplementedException(),
                Market.ExactGoals_6 => throw new NotImplementedException(),
                
                Market.ExactScore_0_0 => throw new NotImplementedException(),
                Market.ExactScore_1_0 => throw new NotImplementedException(),
                Market.ExactScore_2_0 => throw new NotImplementedException(),
                Market.ExactScore_3_0 => throw new NotImplementedException(),
                Market.ExactScore_4_0 => throw new NotImplementedException(),
                Market.ExactScore_1_1 => throw new NotImplementedException(),
                Market.ExactScore_2_1 => throw new NotImplementedException(),
                Market.ExactScore_3_1 => throw new NotImplementedException(),
                Market.ExactScore_4_1 => throw new NotImplementedException(),
                Market.ExactScore_1_2 => throw new NotImplementedException(),
                Market.ExactScore_2_2 => throw new NotImplementedException(),
                Market.ExactScore_3_2 => throw new NotImplementedException(),
                Market.ExactScore_4_2 => throw new NotImplementedException(),
                Market.ExactScore_1_3 => throw new NotImplementedException(),
                Market.ExactScore_2_3 => throw new NotImplementedException(),
                Market.ExactScore_3_3 => throw new NotImplementedException(),
                Market.ExactScore_4_3 => throw new NotImplementedException(),
                Market.ExactScore_1_4 => throw new NotImplementedException(),
                Market.ExactScore_2_4 => throw new NotImplementedException(),
                Market.ExactScore_3_4 => throw new NotImplementedException(),
                Market.ExactScore_4_4 => throw new NotImplementedException(),
                Market.BtsYes => throw new NotImplementedException(),
                Market.BtsNo => throw new NotImplementedException(),
                Market.OddEven_Odd => throw new NotImplementedException(),
                Market.OddEven_Even => throw new NotImplementedException(),
                Market.TeamOddEven_Odd => throw new NotImplementedException(),
                Market.TeamOddEven_Even => throw new NotImplementedException(),
                Market.OppOddEven_Odd => throw new NotImplementedException(),
                Market.OppTeamOddEven_Even => throw new NotImplementedException(),

                _ => null
            };
        }

        float? GetOdds2Half(Market m)
        {
            return m switch
            {
                Market.Win => IsHome() ? OddsVal(6) : OddsVal(8),
                Market.Draw => OddsVal(7),
                Market.Lose => IsHome() ? OddsVal(8) : OddsVal(6),

                // TODO Реализовать остальные исходы

                Market.WinOrDraw => throw new NotImplementedException(),
                Market.WinOrLose => throw new NotImplementedException(),
                Market.DrawOrLose => throw new NotImplementedException(),
                Market.WinNoBet => throw new NotImplementedException(),
                Market.LoseNoBet => throw new NotImplementedException(),
                Market.TotalOver05 => throw new NotImplementedException(),
                Market.TotalUnder05 => throw new NotImplementedException(),
                Market.TotalOver1 => throw new NotImplementedException(),
                Market.TotalUnder1 => throw new NotImplementedException(),
                Market.TotalOver15 => throw new NotImplementedException(),
                Market.TotalUnder15 => throw new NotImplementedException(),
                Market.TotalOver2 => throw new NotImplementedException(),
                Market.TotalUnder2 => throw new NotImplementedException(),
                Market.TotalOver25 => throw new NotImplementedException(),
                Market.TotalUnder25 => throw new NotImplementedException(),
                Market.TotalOver3 => throw new NotImplementedException(),
                Market.TotalUnder3 => throw new NotImplementedException(),
                Market.TotalOver35 => throw new NotImplementedException(),
                Market.TotalUnder35 => throw new NotImplementedException(),
                Market.TotalOver4 => throw new NotImplementedException(),
                Market.TotalUnder4 => throw new NotImplementedException(),
                Market.TotalOver45 => throw new NotImplementedException(),
                Market.TotalUnder45 => throw new NotImplementedException(),
                Market.TeamTotalOver05 => throw new NotImplementedException(),
                Market.TeamTotalUnder05 => throw new NotImplementedException(),
                Market.TeamTotalOver1 => throw new NotImplementedException(),
                Market.TeamTotalUnder1 => throw new NotImplementedException(),
                Market.TeamTotalOver15 => throw new NotImplementedException(),
                Market.TeamTotalUnder15 => throw new NotImplementedException(),
                Market.TeamTotalOver2 => throw new NotImplementedException(),
                Market.TeamTotalUnder2 => throw new NotImplementedException(),
                Market.TeamTotalOver25 => throw new NotImplementedException(),
                Market.TeamTotalUnder25 => throw new NotImplementedException(),
                Market.TeamTotalOver3 => throw new NotImplementedException(),
                Market.TeamTotalUnder3 => throw new NotImplementedException(),
                Market.TeamTotalOver35 => throw new NotImplementedException(),
                Market.TeamTotalUnder35 => throw new NotImplementedException(),
                Market.TeamOppTotalOver05 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder05 => throw new NotImplementedException(),
                Market.TeamOppTotalOver1 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder1 => throw new NotImplementedException(),
                Market.TeamOppTotalOver15 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder15 => throw new NotImplementedException(),
                Market.TeamOppTotalOver2 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder2 => throw new NotImplementedException(),
                Market.TeamOppTotalOver25 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder25 => throw new NotImplementedException(),
                Market.TeamOppTotalOver3 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder3 => throw new NotImplementedException(),
                Market.TeamOppTotalOver35 => throw new NotImplementedException(),
                Market.TeamOppTotalUnder35 => throw new NotImplementedException(),
                
                Market.AhWinM35 => throw new NotImplementedException(),
                Market.AhLoseM35 => throw new NotImplementedException(),
                Market.AhWinM325 => throw new NotImplementedException(),
                Market.AhLoseM325 => throw new NotImplementedException(),
                Market.AhWinM3 => throw new NotImplementedException(),
                Market.AhLoseM3 => throw new NotImplementedException(),
                Market.AhWinM275 => throw new NotImplementedException(),
                Market.AhLoseM275 => throw new NotImplementedException(),
                Market.AhWinM25 => throw new NotImplementedException(),
                Market.AhLoseM25 => throw new NotImplementedException(),
                Market.AhWinM225 => throw new NotImplementedException(),
                Market.AhLoseM225 => throw new NotImplementedException(),
                Market.AhWinM2 => throw new NotImplementedException(),
                Market.AhLoseM2 => throw new NotImplementedException(),
                Market.AhWinM175 => throw new NotImplementedException(),
                Market.AhLoseM175 => throw new NotImplementedException(),
                Market.AhWinM15 => throw new NotImplementedException(),
                Market.AhLoseM15 => throw new NotImplementedException(),
                Market.AhWinM125 => throw new NotImplementedException(),
                Market.AhLoseM125 => throw new NotImplementedException(),
                Market.AhWinM1 => throw new NotImplementedException(),
                Market.AhLoseM1 => throw new NotImplementedException(),
                Market.AhWinM075 => throw new NotImplementedException(),
                Market.AhLoseM075 => throw new NotImplementedException(),
                Market.AhWinM05 => throw new NotImplementedException(),
                Market.AhLoseM05 => throw new NotImplementedException(),
                Market.AhWinM025 => throw new NotImplementedException(),
                Market.AhLoseM025 => throw new NotImplementedException(),
                Market.AhWin0 => throw new NotImplementedException(),
                Market.AhLose0 => throw new NotImplementedException(),
                Market.AhWin025 => throw new NotImplementedException(),
                Market.AhLose025 => throw new NotImplementedException(),
                Market.AhWinP05 => throw new NotImplementedException(),
                Market.AhLoseP05 => throw new NotImplementedException(),
                Market.AhWin075 => throw new NotImplementedException(),
                Market.AhLose075 => throw new NotImplementedException(),
                Market.AhWinP1 => throw new NotImplementedException(),
                Market.AhLoseP1 => throw new NotImplementedException(),
                Market.AhWinP125 => throw new NotImplementedException(),
                Market.AhLoseP125 => throw new NotImplementedException(),
                Market.AhWinP15 => throw new NotImplementedException(),
                Market.AhLoseP15 => throw new NotImplementedException(),
                Market.AhWinP175 => throw new NotImplementedException(),
                Market.AhLoseP175 => throw new NotImplementedException(),
                Market.AhWinP2 => throw new NotImplementedException(),
                Market.AhLoseP2 => throw new NotImplementedException(),
                Market.AhWinP225 => throw new NotImplementedException(),
                Market.AhLoseP225 => throw new NotImplementedException(),
                Market.AhWinP25 => throw new NotImplementedException(),
                Market.AhLoseP25 => throw new NotImplementedException(),
                Market.AhWinP275 => throw new NotImplementedException(),
                Market.AhLoseP275 => throw new NotImplementedException(),
                Market.AhWinP3 => throw new NotImplementedException(),
                Market.AhLoseP3 => throw new NotImplementedException(),
                Market.AhWinP325 => throw new NotImplementedException(),
                Market.AhLoseP325 => throw new NotImplementedException(),
                Market.AhWinP35 => throw new NotImplementedException(),
                Market.AhLoseP35 => throw new NotImplementedException(),

                Market.ExactGoals_0 => throw new NotImplementedException(),
                Market.ExactGoals_1 => throw new NotImplementedException(),
                Market.ExactGoals_2 => throw new NotImplementedException(),
                Market.ExactGoals_3 => throw new NotImplementedException(),
                Market.ExactGoals_4 => throw new NotImplementedException(),
                Market.ExactGoals_5 => throw new NotImplementedException(),
                Market.ExactGoals_6 => throw new NotImplementedException(),
                
                Market.ExactScore_0_0 => throw new NotImplementedException(),
                Market.ExactScore_1_0 => throw new NotImplementedException(),
                Market.ExactScore_2_0 => throw new NotImplementedException(),
                Market.ExactScore_3_0 => throw new NotImplementedException(),
                Market.ExactScore_4_0 => throw new NotImplementedException(),
                Market.ExactScore_1_1 => throw new NotImplementedException(),
                Market.ExactScore_2_1 => throw new NotImplementedException(),
                Market.ExactScore_3_1 => throw new NotImplementedException(),
                Market.ExactScore_4_1 => throw new NotImplementedException(),
                Market.ExactScore_1_2 => throw new NotImplementedException(),
                Market.ExactScore_2_2 => throw new NotImplementedException(),
                Market.ExactScore_3_2 => throw new NotImplementedException(),
                Market.ExactScore_4_2 => throw new NotImplementedException(),
                Market.ExactScore_1_3 => throw new NotImplementedException(),
                Market.ExactScore_2_3 => throw new NotImplementedException(),
                Market.ExactScore_3_3 => throw new NotImplementedException(),
                Market.ExactScore_4_3 => throw new NotImplementedException(),
                Market.ExactScore_1_4 => throw new NotImplementedException(),
                Market.ExactScore_2_4 => throw new NotImplementedException(),
                Market.ExactScore_3_4 => throw new NotImplementedException(),
                Market.ExactScore_4_4 => throw new NotImplementedException(),
                Market.BtsYes => throw new NotImplementedException(),
                Market.BtsNo => throw new NotImplementedException(),
                Market.OddEven_Odd => throw new NotImplementedException(),
                Market.OddEven_Even => throw new NotImplementedException(),
                Market.TeamOddEven_Odd => throw new NotImplementedException(),
                Market.TeamOddEven_Even => throw new NotImplementedException(),
                Market.OppOddEven_Odd => throw new NotImplementedException(),
                Market.OppTeamOddEven_Even => throw new NotImplementedException(),
                _ => null
            };
        }


        // нужная команда - хозяева или гости
        bool IsHome() => _teamId == game.HomeTeamId;

        // Счет команды. Учитывается тайм
        byte Score()
        {
            return period switch
            {
                1 => (IsHome() ? game.ScoreHomeHT : game.ScoreAwayHT) ?? throw new Exception("Счет 1ого тайма не определен"),
                2 => (byte?)(IsHome() ? game.ScoreHomeFT - game.ScoreHomeHT : game.ScoreAwayFT - game.ScoreAwayHT) ??
                     throw new Exception("Счет 1ого тайма не определен"),
                _ => IsHome() ? game.ScoreHomeFT : game.ScoreAwayFT
            };
        }

        // Счет команды противника. Учитывается тайм
        byte ScoreOpp()
        {
            return period switch
            {
                1 => (IsHome() ? game.ScoreAwayHT : game.ScoreHomeHT) ?? throw new Exception("Счет 1ого тайма не определен"),
                2 => (byte?)(IsHome() ? game.ScoreAwayFT - game.ScoreAwayHT : game.ScoreHomeFT - game.ScoreHomeHT) ??
                     throw new Exception("Счет 1ого тайма не определен"),
                _ => IsHome() ? game.ScoreAwayFT : game.ScoreHomeFT
            };
        }

        // Угловые. Тайм не учитывается, т.к в статистике нет данных по таймам
        byte? Corners() => IsHome() ? game.Statistics?.CornerKicksHome : game.Statistics?.CornerKicksAway;
        byte? CornersOpp() => IsHome() ? game.Statistics?.CornerKicksAway : game.Statistics?.CornerKicksHome;

        // Карточки (Ж+К). Тайм не учитывается, т.к в статистике нет данных по таймам
        byte? Cards() => (byte?)(IsHome()
            ? game.Statistics?.RedCardsHome + game.Statistics?.YellowCardsHome
            : game.Statistics?.RedCardsAway + game.Statistics?.YellowCardsAway);

        byte? CardsOpp() => (byte?)(IsHome()
            ? game.Statistics?.RedCardsAway + game.Statistics?.YellowCardsAway
            : game.Statistics?.RedCardsHome + game.Statistics?.YellowCardsHome);

        #endregion
    }
}