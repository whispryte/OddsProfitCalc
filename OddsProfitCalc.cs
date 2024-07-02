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

            try
            {
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
            catch (NotImplementedException ex)
            {
                
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
            Market.TotalUnder2 => Score() + ScoreOpp() < 2
                ? odds
                : (Score() + ScoreOpp() == 2 ? 1 : 0),
            Market.TotalOver25 => Score() + ScoreOpp() > 2.5 ? odds : 0,
            Market.TotalUnder25 => Score() + ScoreOpp() < 2.5 ? odds : 0,

            Market.CornersOver25 => Corners() + CornersOpp() > 2.5 ? odds : 0,
            Market.CornersOver35 => Corners() + CornersOpp() > 3.5 ? odds : 0,

            Market.CardsOver15 => Cards() + CardsOpp() > 1.5 ? odds : 0,
            Market.CardsOver2 => Cards() + CardsOpp() > 2 ? odds : (Cards() + CardsOpp() == 2 ? 1 : 0),

            Market.TeamCardsOver05 => Cards() > 0.5 ? odds : 0,
            Market.TeamCardsUnder05 => Cards() < 0.5 ? odds : 0,
            Market.OppCardsOver05 => CardsOpp() > 0.5 ? odds : 0,
            Market.OppCardsUnder05 => CardsOpp() < 0.5 ? odds : 0,

            Market.TotalOver3 => Score() + ScoreOpp() > 3
                ? odds
                : (Score() + ScoreOpp() == 3 ? 1 : 0),
            Market.TotalUnder3 => Score() + ScoreOpp() < 3
                ? odds
                : (Score() + ScoreOpp() == 3 ? 1 : 0),
            Market.TotalOver35 => Score() + ScoreOpp() > 3.5 ? odds : 0,
            Market.TotalUnder35 => Score() + ScoreOpp() < 3.5 ? odds : 0,
            Market.TotalOver4 => Score() + ScoreOpp() > 4
                ? odds
                : (Score() + ScoreOpp() == 4 ? 1 : 0),
            Market.TotalUnder4 => Score() + ScoreOpp() < 4
                ? odds
                : (Score() + ScoreOpp() == 4 ? 1 : 0),
            Market.TotalOver45 => Score() + ScoreOpp() > 4.5 ? odds : 0,
            Market.TotalUnder45 => Score() + ScoreOpp() < 4.5 ? odds : 0,

            Market.TeamTotalOver05 => Score() > 0.5 ? odds : 0,
            Market.TeamTotalUnder05 => Score() < 0.5 ? odds : 0,
            Market.TeamTotalOver1 => Score() > 1 ? odds : (Score() == 1 ? 1 : 0),
            Market.TeamTotalUnder1 => Score() < 1 ? odds : (Score() == 1 ? 1 : 0),
            Market.TeamTotalOver15 => Score() > 1.5 ? odds : 0,
            Market.TeamTotalUnder15 => Score() < 1.5 ? odds : 0,
            Market.TeamTotalOver2 => Score() > 2 ? odds : (Score() == 2 ? 1 : 0),
            Market.TeamTotalUnder2 => Score() < 2 ? odds : (Score() == 2 ? 1 : 0),
            Market.TeamTotalOver25 => Score() > 2.5 ? odds : 0,
            Market.TeamTotalUnder25 => Score() < 2.5 ? odds : 0,
            Market.TeamTotalOver3 => Score() > 3 ? odds : (Score() == 3 ? 1 : 0),
            Market.TeamTotalUnder3 => Score() < 3 ? odds : (Score() == 3 ? 1 : 0),
            Market.TeamTotalOver35 => Score() > 3.5 ? odds : 0,
            Market.TeamTotalUnder35 => Score() < 3.5 ? odds : 0,
            Market.TeamOppTotalOver05 => ScoreOpp() > 0.5 ? odds : 0,
            Market.TeamOppTotalUnder05 => ScoreOpp() < 0.5 ? odds : 0,
            Market.TeamOppTotalOver1 => ScoreOpp() > 1 ? odds : (ScoreOpp() == 1 ? 1 : 0),
            Market.TeamOppTotalUnder1 => ScoreOpp() < 1 ? odds : (ScoreOpp() == 1 ? 1 : 0),
            Market.TeamOppTotalOver15 => ScoreOpp() > 1.5 ? odds : 0,
            Market.TeamOppTotalUnder15 => ScoreOpp() < 1.5 ? odds : 0,
            Market.TeamOppTotalOver2 => ScoreOpp() > 2 ? odds : (ScoreOpp() == 2 ? 1 : 0),
            Market.TeamOppTotalUnder2 => ScoreOpp() < 2 ? odds : (ScoreOpp() == 2 ? 1 : 0),
            Market.TeamOppTotalOver25 => ScoreOpp() > 2.5 ? odds : 0,
            Market.TeamOppTotalUnder25 => ScoreOpp() < 2.5 ? odds : 0,
            Market.TeamOppTotalOver3 => ScoreOpp() > 3 ? odds : (ScoreOpp() == 3 ? 1 : 0),
            Market.TeamOppTotalUnder3 => ScoreOpp() < 3 ? odds : (ScoreOpp() == 3 ? 1 : 0),
            Market.TeamOppTotalOver35 => ScoreOpp() > 3.5 ? odds : 0,
            Market.TeamOppTotalUnder35 => ScoreOpp() < 3.5 ? odds : 0,

            Market.ResultWinOver05 => (Score() > ScoreOpp() && Score() + ScoreOpp() > 0.5) ? odds : 0,
            Market.ResultLoseOver05 => (Score() < ScoreOpp() && Score() + ScoreOpp() > 0.5) ? odds : 0,
            Market.ResultWinOver15 => (Score() > ScoreOpp() && Score() + ScoreOpp() > 1.5) ? odds : 0,
            Market.ResultLoseOver15 => (Score() < ScoreOpp() && Score() + ScoreOpp() > 1.5) ? odds : 0,
            Market.ResultWinOver25 => (Score() > ScoreOpp() && Score() + ScoreOpp() > 2.5) ? odds : 0,
            Market.ResultLoseOver25 => (Score() < ScoreOpp() && Score() + ScoreOpp() > 2.5) ? odds : 0,
            Market.ResultWinOver35 => (Score() > ScoreOpp() && Score() + ScoreOpp() > 3.5) ? odds : 0,
            Market.ResultLoseOver35 => (Score() < ScoreOpp() && Score() + ScoreOpp() > 3.5) ? odds : 0,
            Market.ResultWinOver45 => (Score() > ScoreOpp() && Score() + ScoreOpp() > 4.5) ? odds : 0,
            Market.ResultLoseOver45 => (Score() < ScoreOpp() && Score() + ScoreOpp() > 4.5) ? odds : 0,

            Market.AhWinM35 => ScoreOpp() < Score() - 3.5 ? odds : 0,
            Market.AhLoseM35 => ScoreOpp() > Score() - 3.5 ? odds : 0,
            Market.AhWinM325 => ScoreOpp() < Score() - 3.25 ? odds : 0,
            Market.AhLoseM325 => ScoreOpp() > Score() - 3.25 ? odds : 0,
            Market.AhWinM3 => ScoreOpp() < Score() - 3 ? odds : (ScoreOpp() - 3 == Score() ? 1 : 0),
            Market.AhLoseM3 => Score() < ScoreOpp() - 3 ? odds : (ScoreOpp() - 3 == Score() ? 1 : 0),
            Market.AhWinM275 => ScoreOpp() < Score() - 2.75 ? odds : 0,
            Market.AhLoseM275 => ScoreOpp() > Score() - 2.75 ? odds : 0,
            Market.AhWinM25 => ScoreOpp() < Score() - 2.5 ? odds : 0,
            Market.AhLoseM25 => ScoreOpp() > Score() - 2.5 ? odds : 0,
            Market.AhWinM225 => ScoreOpp() < Score() - 2.25 ? odds : 0,
            Market.AhLoseM225 => ScoreOpp() > Score() - 2.25 ? odds : 0,
            Market.AhWinM2 => ScoreOpp() < Score() - 2 ? odds : (ScoreOpp() - 2 == Score() ? 1 : 0),
            Market.AhLoseM2 => Score() < ScoreOpp() - 2 ? odds : (ScoreOpp() - 2 == Score() ? 1 : 0),
            Market.AhWinM175 => ScoreOpp() < Score() - 1.75 ? odds : 0,
            Market.AhLoseM175 => ScoreOpp() > Score() - 1.75 ? odds : 0,
            Market.AhWinM15 => ScoreOpp() < Score() - 1.5 ? odds : 0,
            Market.AhLoseM15 => ScoreOpp() > Score() - 1.5 ? odds : 0,
            Market.AhWinM125 => ScoreOpp() < Score() - 1.25 ? odds : 0,
            Market.AhLoseM125 => ScoreOpp() > Score() - 1.25 ? odds : 0,
            Market.AhWinM1 => ScoreOpp() < Score() - 1 ? odds : (ScoreOpp() - 1 == Score() ? 1 : 0),
            Market.AhLoseM1 => Score() < ScoreOpp() - 1 ? odds : (ScoreOpp() - 1 == Score() ? 1 : 0),
            Market.AhWinM075 => ScoreOpp() < Score() - 0.75 ? odds : 0,
            Market.AhLoseM075 => ScoreOpp() > Score() - 0.75 ? odds : 0,
            Market.AhWinM05 => ScoreOpp() < Score() - 0.5 ? odds : 0,
            Market.AhLoseM05 => ScoreOpp() > Score() - 0.5 ? odds : 0,
            Market.AhWinM025 => ScoreOpp() < Score() - 0.25 ? odds : 0,
            Market.AhLoseM025 => ScoreOpp() > Score() - 0.25 ? odds : 0,

            Market.AhWin0 => ScoreOpp() < Score() ? odds : (ScoreOpp() == Score() ? 1 : 0),
            Market.AhLose0 => Score() < ScoreOpp() ? odds : (Score() == ScoreOpp() ? 1 : 0),

            Market.AhWin025 => ScoreOpp() < Score() + 0.25 ? odds : 0,
            Market.AhLose025 => Score() + 0.25 < ScoreOpp() ? odds : 0,
            Market.AhWinP05 => ScoreOpp() < Score() + 0.5 ? odds : 0,
            Market.AhLoseP05 => Score() + 0.5 < ScoreOpp() ? odds : 0,
            Market.AhWin075 => ScoreOpp() < Score() + 0.75 ? odds : 0,
            Market.AhLose075 => Score() + 0.75 < ScoreOpp() ? odds : 0,
            Market.AhWinP1 => ScoreOpp() < Score() + 1 ? odds : (ScoreOpp() + 1 == Score() ? 1 : 0),
            Market.AhLoseP1 => Score() + 1 < ScoreOpp() ? odds : (Score() + 1 == ScoreOpp() ? 1 : 0),
            Market.AhWinP125 => ScoreOpp() < Score() + 1.25 ? odds : 0,
            Market.AhLoseP125 => Score() + 1.25 < ScoreOpp() ? odds : 0,
            Market.AhWinP15 => ScoreOpp() < Score() + 1.5 ? odds : 0,
            Market.AhLoseP15 => Score() + 1.5 < ScoreOpp() ? odds : 0,
            Market.AhWinP175 => ScoreOpp() < Score() + 1.75 ? odds : 0,
            Market.AhLoseP175 => Score() + 1.75 < ScoreOpp() ? odds : 0,
            Market.AhWinP2 => ScoreOpp() < Score() + 2 ? odds : (ScoreOpp() + 2 == Score() ? 1 : 0),
            Market.AhLoseP2 => Score() + 2 < ScoreOpp() ? odds : (Score() + 2 == ScoreOpp() ? 1 : 0),
            Market.AhWinP225 => ScoreOpp() < Score() + 2.25 ? odds : 0,
            Market.AhLoseP225 => Score() + 2.25 < ScoreOpp() ? odds : 0,
            Market.AhWinP25 => ScoreOpp() < Score() + 2.5 ? odds : 0,
            Market.AhLoseP25 => Score() + 2.5 < ScoreOpp() ? odds : 0,
            Market.AhWinP275 => ScoreOpp() < Score() + 2.75 ? odds : 0,
            Market.AhLoseP275 => Score() + 2.75 < ScoreOpp() ? odds : 0,
            Market.AhWinP3 => ScoreOpp() < Score() + 3 ? odds : (ScoreOpp() + 3 == Score() ? 1 : 0),
            Market.AhLoseP3 => Score() + 3 < ScoreOpp() ? odds : (Score() + 3 == ScoreOpp() ? 1 : 0),
            Market.AhWinP325 => ScoreOpp() < Score() + 3.25 ? odds : 0,
            Market.AhLoseP325 => Score() + 3.25 < ScoreOpp() ? odds : 0,
            Market.AhWinP35 => ScoreOpp() < Score() + 3.5 ? odds : 0,
            Market.AhLoseP35 => Score() + 3.5 < ScoreOpp() ? odds : 0,

            Market.CornersUnder25 => Corners() + CornersOpp() < 2.5 ? odds : 0,
            Market.CornersUnder35 => Corners() + CornersOpp() < 3.5 ? odds : 0,
            Market.CornersOver45 => Corners() + CornersOpp() > 4.5 ? odds : 0,
            Market.CornersUnder45 => Corners() + CornersOpp() < 4.5 ? odds : 0,
            Market.CornersOver55 => Corners() + CornersOpp() > 5.5 ? odds : 0,
            Market.CornersUnder55 => Corners() + CornersOpp() < 5.5 ? odds : 0,
            Market.CornersOver65 => Corners() + CornersOpp() > 6.5 ? odds : 0,
            Market.CornersUnder65 => Corners() + CornersOpp() < 6.5 ? odds : 0,
            Market.CornersOver75 => Corners() + CornersOpp() > 7.5 ? odds : 0,
            Market.CornersUnder75 => Corners() + CornersOpp() < 7.5 ? odds : 0,
            Market.CornersOver85 => Corners() + CornersOpp() > 8.5 ? odds : 0,
            Market.CornersUnder85 => Corners() + CornersOpp() < 8.5 ? odds : 0,
            Market.CornersOver95 => Corners() + CornersOpp() > 9.5 ? odds : 0,
            Market.CornersUnder95 => Corners() + CornersOpp() < 9.5 ? odds : 0,
            Market.CornersOver105 => Corners() + CornersOpp() > 10.5 ? odds : 0,
            Market.CornersUnder105 => Corners() + CornersOpp() < 10.5 ? odds : 0,
            Market.CornersOver115 => Corners() + CornersOpp() > 11.5 ? odds : 0,
            Market.CornersUnder115 => Corners() + CornersOpp() < 11.5 ? odds : 0,
            Market.CornersOver125 => Corners() + CornersOpp() > 12.5 ? odds : 0,
            Market.CornersUnder125 => Corners() + CornersOpp() < 12.5 ? odds : 0,
            Market.CornersOver135 => Corners() + CornersOpp() > 13.5 ? odds : 0,
            Market.CornersUnder135 => Corners() + CornersOpp() < 13.5 ? odds : 0,

            Market.TeamCornersOver05 => Corners() > 0.5 ? odds : 0,
            Market.TeamCornersUnder05 => Corners() < 0.5 ? odds : 0,
            Market.TeamCornersOver1 => Corners() > 1 ? odds : (Corners() == 1 ? 1 : 0) ,
            Market.TeamCornersUnder1 => Corners() < 1 ? odds : (Corners() == 1 ? 1 : 0),
            Market.TeamCornersOver15 => Corners() > 1.5 ? odds : 0,
            Market.TeamCornersUnder15 => Corners() < 1.5 ? odds : 0,
            Market.TeamCornersOver2 => Corners() > 2 ? odds : (Corners() == 2 ? 1 : 0),
            Market.TeamCornersUnder2 => Corners() < 2 ? odds : (Corners() == 2 ? 1 : 0),
            Market.TeamCornersOver25 => Corners() > 2.5 ? odds : 0,
            Market.TeamCornersUnder25 => Corners() < 2.5 ? odds : 0,
            Market.TeamCornersOver3 => Corners() > 3 ? odds : (Corners() == 3 ? 1 : 0),
            Market.TeamCornersUnder3 => Corners() < 3 ? odds : (Corners() == 3 ? 1 : 0),
            Market.TeamCornersOver35 => Corners() > 3.5 ? odds : 0,
            Market.TeamCornersUnder35 => Corners() < 3.5 ? odds : 0,
            Market.TeamCornersOver4 => Corners() > 4 ? odds : (Corners() == 4 ? 1 : 0),
            Market.TeamCornersUnder4 => Corners() < 4 ? odds : (Corners() == 4 ? 1 : 0),
            Market.TeamCornersOver45 => Corners() > 4.5 ? odds : 0,
            Market.TeamCornersUnder45 => Corners() < 4.5 ? odds : 0,
            Market.TeamCornersOver5 => Corners() > 5 ? odds : (Corners() == 5 ? 1 : 0),
            Market.TeamCornersUnder5 => Corners() < 5 ? odds : (Corners() == 5 ? 1 : 0),
            Market.TeamCornersOver55 => Corners() > 5.5 ? odds : 0,
            Market.TeamCornersUnder55 => Corners() < 5.5 ? odds : 0,
            Market.TeamCornersOver6 => Corners() > 6 ? odds : (Corners() == 6 ? 1 : 0),
            Market.TeamCornersUnder6 => Corners() < 6 ? odds : (Corners() == 6 ? 1 : 0),
            Market.TeamCornersOver65 => Corners() > 6.5 ? odds : 0,
            Market.TeamCornersUnder65 => Corners() < 6.5 ? odds : 0,
            Market.TeamCornersOver7 => Corners() > 7 ? odds : (Corners() == 7 ? 1 : 0),
            Market.TeamCornersUnder7 => Corners() < 7 ? odds : (Corners() == 7 ? 1 : 0),
            Market.TeamCornersOver75 => Corners() > 7.5 ? odds : 0,
            Market.TeamCornersUnder75 => Corners() < 7.5 ? odds : 0,
            Market.TeamCornersOver8 => Corners() > 8 ? odds : (Corners() == 8 ? 1 : 0),
            Market.TeamCornersUnder8 => Corners() < 8 ? odds : (Corners() == 8 ? 1 : 0),
            Market.TeamCornersOver85 => Corners() > 8.5 ? odds : 0,
            Market.TeamCornersUnder85 => Corners() < 8.5 ? odds : 0,
            Market.TeamCornersOver9 => Corners() > 9 ? odds : (Corners() == 9 ? 1 : 0),
            Market.TeamCornersUnder9 => Corners() < 9 ? odds : (Corners() == 9 ? 1 : 0),
            Market.TeamCornersOver95 => Corners() > 9.5 ? odds : 0,
            Market.TeamCornersUnder95 => Corners() < 9.5 ? odds : 0,

            Market.OppCornersOver05 => CornersOpp() > 0.5 ? odds : 0,
            Market.OppCornersUnder05 => CornersOpp() < 0.5 ? odds : 0,
            Market.OppCornersOver1 => CornersOpp() > 1 ? odds : (CornersOpp() == 1 ? 1 : 0),
            Market.OppCornersUnder1 => CornersOpp() < 1 ? odds : (CornersOpp() == 1 ? 1 : 0),
            Market.OppCornersOver15 => CornersOpp() > 1.5 ? odds : 0,
            Market.OppCornersUnder15 => CornersOpp() < 1.5 ? odds : 0,
            Market.OppCornersOver2 => CornersOpp() > 2 ? odds : (CornersOpp() == 2 ? 1 : 0),
            Market.OppCornersUnder2 => CornersOpp() < 2 ? odds : (CornersOpp() == 2 ? 1 : 0),
            Market.OppCornersOver25 => CornersOpp() > 2.5 ? odds : 0,
            Market.OppCornersUnder25 => CornersOpp() < 2.5 ? odds : 0,
            Market.OppCornersOver3 => CornersOpp() > 3 ? odds : (CornersOpp() == 3 ? 1 : 0),
            Market.OppCornersUnder3 => CornersOpp() < 3 ? odds : (CornersOpp() == 3 ? 1 : 0),
            Market.OppCornersOver35 => CornersOpp() > 3.5 ? odds : 0,
            Market.OppCornersUnder35 => CornersOpp() < 3.5 ? odds : 0,
            Market.OppCornersOver4 => CornersOpp() > 4 ? odds : (CornersOpp() == 4 ? 1 : 0),
            Market.OppCornersUnder4 => CornersOpp() < 4 ? odds : (CornersOpp() == 4 ? 1 : 0),
            Market.OppCornersOver45 => CornersOpp() > 4.5 ? odds : 0,
            Market.OppCornersUnder45 => CornersOpp() < 4.5 ? odds : 0,
            Market.OppCornersOver5 => CornersOpp() > 5 ? odds : (CornersOpp() == 5 ? 1 : 0),
            Market.OppCornersUnder5 => CornersOpp() < 5 ? odds : (CornersOpp() == 5 ? 1 : 0),
            Market.OppCornersOver55 => CornersOpp() > 5.5 ? odds : 0,
            Market.OppCornersUnder55 => CornersOpp() < 5.5 ? odds : 0,
            Market.OppCornersOver6 => CornersOpp() > 6 ? odds : (CornersOpp() == 6 ? 1 : 0),
            Market.OppCornersUnder6 => CornersOpp() < 6 ? odds : (CornersOpp() == 6 ? 1 : 0),
            Market.OppCornersOver65 => CornersOpp() > 6.5 ? odds : 0,
            Market.OppCornersUnder65 => CornersOpp() < 6.5 ? odds : 0,
            Market.OppCornersOver7 => CornersOpp() > 7 ? odds : (CornersOpp() == 7 ? 1 : 0),
            Market.OppCornersUnder7 => CornersOpp() < 7 ? odds : (CornersOpp() == 7 ? 1 : 0),
            Market.OppCornersOver75 => CornersOpp() > 7.5 ? odds : 0,
            Market.OppCornersUnder75 => CornersOpp() < 7.5 ? odds : 0,
            Market.OppCornersOver8 => CornersOpp() > 8 ? odds : (CornersOpp() == 8 ? 1 : 0),
            Market.OppCornersUnder8 => CornersOpp() < 8 ? odds : (CornersOpp() == 8 ? 1 : 0),
            Market.OppCornersOver85 => CornersOpp() > 8.5 ? odds : 0,
            Market.OppCornersUnder85 => CornersOpp() < 8.5 ? odds : 0,
            Market.OppCornersOver9 => CornersOpp() > 9 ? odds : (CornersOpp() == 9 ? 1 : 0),
            Market.OppCornersUnder9 => CornersOpp() < 9 ? odds : (CornersOpp() == 9 ? 1 : 0),
            Market.OppCornersOver95 => CornersOpp() > 9.5 ? odds : 0,
            Market.OppCornersUnder95 => CornersOpp() < 9.5 ? odds : 0,

            Market.Corners1x2_Win => Corners() > CornersOpp() ? odds : 0,
            Market.Corners1x2_Draw => Corners() == CornersOpp() ? odds : 0,
            Market.Corners1x2_Lose => Corners() < CornersOpp() ? odds : 0,

            Market.CardsUnder15 => Cards() + CardsOpp() < 1.5 ? odds : 0,
            Market.CardsUnder2 => Cards() + CardsOpp() < 2 ? odds : (Cards() + CardsOpp() == 2 ? 1 : 0),
            Market.CardsOver25 => Cards() + CardsOpp() > 2.5 ? odds : 0,
            Market.CardsUnder25 => Cards() + CardsOpp() < 2.5 ? odds : 0,
            Market.CardsOver3 => Cards() + CardsOpp() > 3 ? odds : (Cards() + CardsOpp() == 3 ? 1 : 0),
            Market.CardsUnder3 => Cards() + CardsOpp() < 3 ? odds : (Cards() + CardsOpp() == 3 ? 1 : 0),
            Market.CardsOver35 => Cards() + CardsOpp() > 3.5 ? odds : 0,
            Market.CardsUnder35 => Cards() + CardsOpp() < 3.5 ? odds : 0,
            Market.CardsOver4 => Cards() + CardsOpp() > 4 ? odds : (Cards() + CardsOpp() == 4 ? 1 : 0),
            Market.CardsUnder4 => Cards() + CardsOpp() < 4 ? odds : (Cards() + CardsOpp() == 4 ? 1 : 0),
            Market.CardsOver45 => Cards() + CardsOpp() > 4.5 ? odds : 0,
            Market.CardsUnder45 => Cards() + CardsOpp() < 4.5 ? odds : 0,

            Market.TeamCardsOver1 => Cards() > 1 ? odds : (Cards() == 1 ? 1 : 0),
            Market.TeamCardsUnder1 => Cards() < 1 ? odds : (Cards() == 1 ? 1 : 0),
            Market.TeamCardsOver15 => Cards() > 1.5 ? odds : 0,
            Market.TeamCardsUnder15 => Cards() < 1.5 ? odds : 0,
            Market.TeamCardsOver2 => Cards() > 2 ? odds : (Cards() == 2 ? 1 : 0),
            Market.TeamCardsUnder2 => Cards() < 2 ? odds : (Cards() == 2 ? 1 : 0),
            Market.TeamCardsOver25 => Cards() > 2.5 ? odds : 0,
            Market.TeamCardsUnder25 => Cards() < 2.5 ? odds : 0,
            Market.TeamCardsOver3 => Cards() > 3 ? odds : (Cards() == 3 ? 1 : 0),
            Market.TeamCardsUnder3 => Cards() < 3 ? odds : (Cards() == 3 ? 1 : 0),
            Market.TeamCardsOver35 => Cards() > 3.5 ? odds : 0,
            Market.TeamCardsUnder35 => Cards() < 3.5 ? odds : 0,
            Market.TeamCardsOver4 => Cards() > 4 ? odds : (Cards() == 4 ? 1 : 0),
            Market.TeamCardsUnder4 => Cards() < 4 ? odds : (Cards() == 4 ? 1 : 0),
            Market.TeamCardsOver45 => Cards() > 4.5 ? odds : 0,
            Market.TeamCardsUnder45 => Cards() < 4.5 ? odds : 0,

            Market.OppCardsOver1 => CardsOpp() > 1 ? odds : (CardsOpp() == 1 ? 1 : 0),
            Market.OppCardsUnder1 => CardsOpp() < 1 ? odds : (CardsOpp() == 1 ? 1 : 0),
            Market.OppCardsOver15 => CardsOpp() > 1.5 ? odds : 0,
            Market.OppCardsUnder15 => CardsOpp() < 1.5 ? odds : 0,
            Market.OppCardsOver2 => CardsOpp() > 2 ? odds : (CardsOpp() == 2 ? 1 : 0),
            Market.OppCardsUnder2 => CardsOpp() < 2 ? odds : (CardsOpp() == 2 ? 1 : 0),
            Market.OppCardsOver25 => CardsOpp() > 2.5 ? odds : 0,
            Market.OppCardsUnder25 => CardsOpp() < 2.5 ? odds : 0,
            Market.OppCardsOver3 => CardsOpp() > 3 ? odds : (CardsOpp() == 3 ? 1 : 0),
            Market.OppCardsUnder3 => CardsOpp() < 3 ? odds : (CardsOpp() == 3 ? 1 : 0),
            Market.OppCardsOver35 => CardsOpp() > 3.5 ? odds : 0,
            Market.OppCardsUnder35 => CardsOpp() < 3.5 ? odds : 0,
            Market.OppCardsOver4 => CardsOpp() > 4 ? odds : (CardsOpp() == 4 ? 1 : 0),
            Market.OppCardsUnder4 => CardsOpp() < 4 ? odds : (CardsOpp() == 4 ? 1 : 0),
            Market.OppCardsOver45 => CardsOpp() > 4.5 ? odds : 0,
            Market.OppCardsUnder45 => CardsOpp() < 4.5 ? odds : 0,

            Market.CardsAhWin05 => Cards() - 0.5 > CardsOpp() ? odds : 0,
            Market.CardsAhLose05 => Cards() - 0.5 < CardsOpp() ? odds : 0,
            Market.CardsAhWin1 => Cards() - 1 > CardsOpp() ? odds : (Cards() - 1 == CardsOpp() ? 1 : 0),
            Market.CardsAhLose1 => Cards() - 1 < CardsOpp() ? odds : (Cards() - 1 == CardsOpp() ? 1 : 0),
            Market.CardsAhWin15 => Cards() - 1.5 > CardsOpp() ? odds : 0,
            Market.CardsAhLose15 => Cards() - 1.5 < CardsOpp() ? odds : 0,
            Market.CardsAhWin2 => Cards() - 2 > CardsOpp() ? odds : (Cards() - 2 == CardsOpp() ? 1 : 0),
            Market.CardsAhLose2 => Cards() - 2 < CardsOpp() ? odds : (Cards() - 2 == CardsOpp() ? 1 : 0),
            Market.CardsAhWin25 => Cards() - 2.5 > CardsOpp() ? odds : 0,
            Market.CardsAhLose25 => Cards() - 2.5 < CardsOpp() ? odds : 0,
            Market.CardsAhWin3 => Cards() - 3 > CardsOpp() ? odds : (Cards() - 3 == CardsOpp() ? 1 : 0),
            Market.CardsAhLose3 => Cards() - 3 < CardsOpp() ? odds : (Cards() - 3 == CardsOpp() ? 1 : 0),
            Market.CardsAhWin35 => Cards() - 3.5 > CardsOpp() ? odds : 0,
            Market.CardsAhLose35 => Cards() - 3.5 < CardsOpp() ? odds : 0,

            Market.RedCardsYes => game.Statistics?.RedCardsHome + game.Statistics?.RedCardsAway > 0 ? odds : 0,
            Market.RedCardsNo => game.Statistics?.RedCardsHome + game.Statistics?.RedCardsAway == 0 ? odds : 0,

            Market.YellowCardsWin => game.Statistics?.YellowCardsHome > game.Statistics?.YellowCardsAway ? odds : 0,
            Market.YellowCardsDraw => game.Statistics?.YellowCardsHome == game.Statistics?.YellowCardsAway ? odds : 0,
            Market.YellowCardsLose => game.Statistics?.YellowCardsHome < game.Statistics?.YellowCardsAway ? odds : 0,

            Market.ExactGoals_0 => Score() + ScoreOpp() == 0 ? odds : 0,
            Market.ExactGoals_1 => Score() + ScoreOpp() == 1 ? odds : 0,
            Market.ExactGoals_2 => Score() + ScoreOpp() == 2 ? odds : 0,
            Market.ExactGoals_3 => Score() + ScoreOpp() == 3 ? odds : 0,
            Market.ExactGoals_4 => Score() + ScoreOpp() == 4 ? odds : 0,
            Market.ExactGoals_5 => Score() + ScoreOpp() == 5 ? odds : 0,
            Market.ExactGoals_6 => Score() + ScoreOpp() == 6 ? odds : 0,

            Market.ExactScore_0_0 => Score() == 0 && ScoreOpp() == 0 ? odds : 0,
            Market.ExactScore_1_0 => Score() == 1 && ScoreOpp() == 0 ? odds : 0,
            Market.ExactScore_2_0 => Score() == 2 && ScoreOpp() == 0 ? odds : 0,
            Market.ExactScore_3_0 => Score() == 3 && ScoreOpp() == 0 ? odds : 0,
            Market.ExactScore_4_0 => Score() == 4 && ScoreOpp() == 0 ? odds : 0,
            Market.ExactScore_1_1 => Score() == 1 && ScoreOpp() == 1 ? odds : 0,
            Market.ExactScore_2_1 => Score() == 2 && ScoreOpp() == 1 ? odds : 0,
            Market.ExactScore_3_1 => Score() == 3 && ScoreOpp() == 1 ? odds : 0,
            Market.ExactScore_4_1 => Score() == 4 && ScoreOpp() == 1 ? odds : 0,
            Market.ExactScore_1_2 => Score() == 1 && ScoreOpp() == 2 ? odds : 0,
            Market.ExactScore_2_2 => Score() == 2 && ScoreOpp() == 2 ? odds : 0,
            Market.ExactScore_3_2 => Score() == 3 && ScoreOpp() == 2 ? odds : 0,
            Market.ExactScore_4_2 => Score() == 4 && ScoreOpp() == 2 ? odds : 0,
            Market.ExactScore_1_3 => Score() == 1 && ScoreOpp() == 3 ? odds : 0,
            Market.ExactScore_2_3 => Score() == 2 && ScoreOpp() == 3 ? odds : 0,
            Market.ExactScore_3_3 => Score() == 3 && ScoreOpp() == 3 ? odds : 0,
            Market.ExactScore_4_3 => Score() == 4 && ScoreOpp() == 3 ? odds : 0,
            Market.ExactScore_1_4 => Score() == 1 && ScoreOpp() == 4 ? odds : 0,
            Market.ExactScore_2_4 => Score() == 2 && ScoreOpp() == 4 ? odds : 0,
            Market.ExactScore_3_4 => Score() == 3 && ScoreOpp() == 4 ? odds : 0,
            Market.ExactScore_4_4 => Score() == 4 && ScoreOpp() == 4 ? odds : 0,

            Market.Fouls_1x2_Win => game.Statistics?.FoulsHome > game.Statistics?.FoulsAway ? odds : 0,
            Market.Fouls_1x2_Draw => game.Statistics?.FoulsHome == game.Statistics?.FoulsAway ? odds : 0,
            Market.Fouls_1x2_Lose => game.Statistics?.FoulsHome < game.Statistics?.FoulsAway ? odds : 0,

            Market.FoulsAhWin05 => game.Statistics?.FoulsHome - 0.5 > game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhLose05 => game.Statistics?.FoulsHome - 0.5 < game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhWin1 => game.Statistics?.FoulsHome - 1 > game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 1 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhLose1 => game.Statistics?.FoulsHome - 1 < game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 1 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhWin15 => game.Statistics?.FoulsHome - 1.5 > game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhLose15 => game.Statistics?.FoulsHome - 1.5 < game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhWin2 => game.Statistics?.FoulsHome - 2 > game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 2 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhLose2 => game.Statistics?.FoulsHome - 2 < game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 2 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhWin25 => game.Statistics?.FoulsHome - 2.5 > game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhLose25 => game.Statistics?.FoulsHome - 2.5 < game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhWin3 => game.Statistics?.FoulsHome - 3 > game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 3 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhLose3 => game.Statistics?.FoulsHome - 3 < game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 3 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhWin35 => game.Statistics?.FoulsHome - 3.5 > game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhLose35 => game.Statistics?.FoulsHome - 3.5 < game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhWin4 => game.Statistics?.FoulsHome - 4 > game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 4 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhLose4 => game.Statistics?.FoulsHome - 4 < game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 4 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhWin45 => game.Statistics?.FoulsHome - 4.5 > game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhLose45 => game.Statistics?.FoulsHome - 4.5 < game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhWin5 => game.Statistics?.FoulsHome - 5 > game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 5 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhLose5 => game.Statistics?.FoulsHome - 5 < game.Statistics?.FoulsAway ? odds : (game.Statistics?.FoulsHome - 5 == game.Statistics?.FoulsAway ? 1 : 0),
            Market.FoulsAhWin55 => game.Statistics?.FoulsHome - 5.5 > game.Statistics?.FoulsAway ? odds : 0,
            Market.FoulsAhLose55 => game.Statistics?.FoulsHome - 5.5 < game.Statistics?.FoulsAway ? odds : 0,

            Market.BothHalvesWin => game.ScoreHomeHT > game.ScoreAwayHT
                && game.ScoreHomeFT - game.ScoreHomeHT > game.ScoreAwayFT - game.ScoreAwayHT ? odds : 0,
            Market.BothHalvesDraw => game.ScoreHomeHT == game.ScoreAwayHT
                && game.ScoreHomeFT - game.ScoreHomeHT == game.ScoreAwayFT - game.ScoreAwayHT ? odds : 0,
            Market.BothHalvesLose => game.ScoreAwayHT > game.ScoreHomeHT
                && game.ScoreAwayFT - game.ScoreAwayHT > game.ScoreHomeFT - game.ScoreHomeHT ? odds : 0,

            Market.BtsYes => Score() > 0 && ScoreOpp() > 0 ? odds : 0,
            Market.BtsNo => Score() == 0 || ScoreOpp() == 0 ? odds : 0,

            Market.TeamCleanSheetYes => ScoreOpp() == 0 ? odds : 0,
            Market.TeamCleanSheetNo => ScoreOpp() > 0 ? odds : 0,
            Market.TeamCleanSheetOpp => Score() == 0 ? odds : 0,
            Market.TeamCleanSheetOppNo => Score() > 0 ? odds : 0,

            Market.WinToNilYes => Score() > ScoreOpp() && ScoreOpp() == 0 ? odds : 0,
            Market.WinToNilNo => !(Score() > ScoreOpp() && ScoreOpp() == 0) ? odds : 0,

            Market.WinEitherHalf => game.ScoreHomeHT > game.ScoreAwayHT 
                || game.ScoreHomeFT - game.ScoreHomeHT > game.ScoreAwayFT - game.ScoreAwayHT ? odds : 0,
            Market.WinEitherHalfOpp => game.ScoreAwayHT > game.ScoreHomeHT
                || game.ScoreAwayFT - game.ScoreAwayHT > game.ScoreHomeFT - game.ScoreHomeHT ? odds : 0,

            Market.ScoreFirst => game.HomeGoalsMinutes?.Length > 0 && 
                (game.AwayGoalsMinutes?.Length == 0 || game.HomeGoalsMinutes.First() < game.AwayGoalsMinutes?.First()) 
                    ? odds : 0,
            Market.ScoreFirstOpp => game.AwayGoalsMinutes?.Length > 0 &&
                (game.HomeGoalsMinutes?.Length == 0 || game.AwayGoalsMinutes.First() < game.HomeGoalsMinutes?.First())
                    ? odds : 0,

            Market.FirstTeamToScore => game.HomeGoalsMinutes?.Length > 0 &&
                (game.AwayGoalsMinutes?.Length == 0 || game.HomeGoalsMinutes.First() < game.AwayGoalsMinutes?.First())
                    ? odds : 0,
            Market.FirstTeamToScoreOpp => game.AwayGoalsMinutes?.Length > 0 &&
                (game.HomeGoalsMinutes?.Length == 0 || game.AwayGoalsMinutes.First() < game.HomeGoalsMinutes?.First())
                    ? odds : 0,

            Market.TeamToScore => Score() > 0 ? odds : 0,
            Market.TeamToScoreNo => Score() == 0 ? odds : 0,
            Market.OppTeamToScore => ScoreOpp() > 0 ? odds : 0,
            Market.OppTeamToScoreNo => ScoreOpp() == 0 ? odds : 0,

            Market.BtsInBothHalves => game.ScoreHomeHT > 0 && game.ScoreAwayHT > 0
                && (game.ScoreHomeFT - game.ScoreHomeHT > 0) && (game.ScoreAwayFT - game.ScoreAwayHT > 0)
                ? odds : 0,

            Market.OddEven_Odd => (Score() + ScoreOpp()) % 2 != 0 ? odds : 0,
            Market.OddEven_Even => (Score() + ScoreOpp()) % 2 == 0 ? odds : 0,

            Market.TeamOddEven_Odd => Score() % 2 != 0 ? odds : 0,
            Market.TeamOddEven_Even => Score() % 2 == 0 ? odds : 0,

            Market.OppOddEven_Odd => ScoreOpp() % 2 != 0 ? odds : 0,
            Market.OppTeamOddEven_Even => ScoreOpp() % 2 == 0 ? odds : 0,

            Market.w1x2_15_Win => game.HomeGoalsMinutes?.Where(goal => goal <= 15).Count() 
                > game.AwayGoalsMinutes?.Where(goal => goal <= 15).Count()
                ? odds : 0,
            Market.w1x2_15_Draw => game.HomeGoalsMinutes?.Where(goal => goal <= 15).Count() 
                == game.AwayGoalsMinutes?.Where(goal => goal <= 15).Count()
                ? odds : 0,
            Market.w1x2_15_Lose => game.HomeGoalsMinutes?.Where(goal => goal <= 15).Count() 
                < game.AwayGoalsMinutes?.Where(goal => goal <= 15).Count()
                ? odds : 0,
            Market.w1x2_30_Lose => game.HomeGoalsMinutes?.Where(goal => goal <= 30).Count() 
                < game.AwayGoalsMinutes?.Where(goal => goal <= 30).Count()
                ? odds : 0,
            Market.w1x2_30_Draw => game.HomeGoalsMinutes?.Where(goal => goal <= 30).Count() 
                == game.AwayGoalsMinutes?.Where(goal => goal <= 30).Count()
                ? odds : 0,
            Market.w1x2_30_Win => game.HomeGoalsMinutes?.Where(goal => goal <= 30).Count() 
                > game.AwayGoalsMinutes?.Where(goal => goal <= 30).Count()
                ? odds : 0,
            Market.w1x2_60_Lose => game.HomeGoalsMinutes?.Where(goal => goal <= 60).Count() 
                < game.AwayGoalsMinutes?.Where(goal => goal <= 60).Count()
                ? odds : 0,
            Market.w1x2_60_Draw => game.HomeGoalsMinutes?.Where(goal => goal <= 60).Count() 
                == game.AwayGoalsMinutes?.Where(goal => goal <= 60).Count()
                ? odds : 0,
            Market.w1x2_60_Win => game.HomeGoalsMinutes?.Where(goal => goal <= 60).Count() 
                > game.AwayGoalsMinutes?.Where(goal => goal <= 60).Count()
                ? odds : 0,
            Market.w1x2_75_Lose => game.HomeGoalsMinutes?.Where(goal => goal <= 75).Count() 
                < game.AwayGoalsMinutes?.Where(goal => goal <= 75).Count()
                ? odds : 0,
            Market.w1x2_75_Draw => game.HomeGoalsMinutes?.Where(goal => goal <= 75).Count() 
                == game.AwayGoalsMinutes?.Where(goal => goal <= 75).Count()
                ? odds : 0,
            Market.w1x2_75_Win => game.HomeGoalsMinutes?.Where(goal => goal <= 75).Count() 
                > game.AwayGoalsMinutes?.Where(goal => goal <= 75).Count()
                ? odds : 0,

            Market.DC_15_WinOrDraw => game.HomeGoalsMinutes?.Where(goal => goal <= 15).Count()
                >= game.AwayGoalsMinutes?.Where(goal => goal <= 15).Count()
                ? odds : 0,
            Market.DC_15_LoseOrDraw => game.HomeGoalsMinutes?.Where(goal => goal <= 15).Count()
                <= game.AwayGoalsMinutes?.Where(goal => goal <= 15).Count()
                ? odds : 0,
            Market.DC_15_WinOrLose => game.HomeGoalsMinutes?.Where(goal => goal <= 15).Count()
                != game.AwayGoalsMinutes?.Where(goal => goal <= 15).Count()
                ? odds : 0,
            Market.DC_30_WinOrDraw => game.HomeGoalsMinutes?.Where(goal => goal <= 30).Count()
                >= game.AwayGoalsMinutes?.Where(goal => goal <= 30).Count()
                ? odds : 0,
            Market.DC_30_LoseOrDraw => game.HomeGoalsMinutes?.Where(goal => goal <= 30).Count()
                <= game.AwayGoalsMinutes?.Where(goal => goal <= 30).Count()
                ? odds : 0,
            Market.DC_30_WinOrLose => game.HomeGoalsMinutes?.Where(goal => goal <= 30).Count()
                != game.AwayGoalsMinutes?.Where(goal => goal <= 30).Count()
                ? odds : 0,
            Market.DC_75_WinOrDraw => game.HomeGoalsMinutes?.Where(goal => goal <= 75).Count()
                >= game.AwayGoalsMinutes?.Where(goal => goal <= 75).Count()
                ? odds : 0,
            Market.DC_75_LoseOrDraw => game.HomeGoalsMinutes?.Where(goal => goal <= 75).Count()
                <= game.AwayGoalsMinutes?.Where(goal => goal <= 75).Count()
                ? odds : 0,
            Market.DC_75_WinOrLose => game.HomeGoalsMinutes?.Where(goal => goal <= 75).Count()
                != game.AwayGoalsMinutes?.Where(goal => goal <= 75).Count()
                ? odds : 0,

            Market.GoalIn_1_15_Yes => game.HomeGoalsMinutes?.Where(goal => goal >= 1 && goal <= 15).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 1 && goal <= 15).Count() > 0 ? odds : 0,
            Market.GoalIn_1_15_No => game.HomeGoalsMinutes?.Where(goal => goal >= 1 && goal <= 15).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 1 && goal <= 15).Count() == 0 ? odds : 0,
            Market.GoalIn_16_30_Yes => game.HomeGoalsMinutes?.Where(goal => goal >= 16 && goal <= 30).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 16 && goal <= 30).Count() > 0 ? odds : 0,
            Market.GoalIn_31_45_No => game.HomeGoalsMinutes?.Where(goal => goal >= 31 && goal <= 45).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 31 && goal <= 45).Count() == 0 ? odds : 0,
            Market.GoalIn_46_60_Yes => game.HomeGoalsMinutes?.Where(goal => goal >= 46 && goal <= 60).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 46 && goal <= 60).Count() > 0 ? odds : 0,
            Market.GoalIn_46_60_No => game.HomeGoalsMinutes?.Where(goal => goal >= 46 && goal <= 60).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 46 && goal <= 60).Count() == 0 ? odds : 0,
            Market.GoalIn_61_75_Yes => game.HomeGoalsMinutes?.Where(goal => goal >= 61 && goal <= 75).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 61 && goal <= 75).Count() > 0 ? odds : 0,
            Market.GoalIn_61_75_No => game.HomeGoalsMinutes?.Where(goal => goal >= 61 && goal <= 75).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 61 && goal <= 75).Count() == 0 ? odds : 0,
            Market.GoalIn_76_90_Yes => game.HomeGoalsMinutes?.Where(goal => goal >= 76 && goal <= 90).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 76 && goal <= 90).Count() > 0 ? odds : 0,
            Market.GoalIn_76_90_No => game.HomeGoalsMinutes?.Where(goal => goal >= 76 && goal <= 90).Count()
                + game.AwayGoalsMinutes?.Where(goal => goal >= 76 && goal <= 90).Count() == 0 ? odds : 0,

            //Не нашел информации о пенальти в игре внутри экземпляра game

            //Market.PenaltyAwardedYes => throw new NotImplementedException(),
            //Market.PenaltyAwardedNo => throw new NotImplementedException(),

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

                Market.TotalOver05 => OddsVal(17),
                Market.TotalUnder05 => OddsVal(18),
                Market.TotalOver1 => OddsVal(49),
                Market.TotalUnder1 => OddsVal(50),
                Market.TotalOver15 => OddsVal(11),
                Market.TotalUnder15 => OddsVal(12),
                Market.TotalOver2 => OddsVal(43),
                Market.TotalUnder2 => OddsVal(44),
                Market.TotalOver25 => OddsVal(15),
                Market.TotalUnder25 => OddsVal(16),
                Market.TotalOver3 => OddsVal(25),
                Market.TotalUnder3 => OddsVal(26),
                Market.TotalOver35 => OddsVal(9),
                Market.TotalUnder35 => OddsVal(10),
                Market.TotalOver4 => OddsVal(45),
                Market.TotalUnder4 => OddsVal(46),
                Market.TotalOver45 => OddsVal(13),
                Market.TotalUnder45 => OddsVal(14),

                Market.TeamTotalOver05 => IsHome() ? OddsVal(443) : OddsVal(475),
                Market.TeamTotalUnder05 => IsHome() ? OddsVal(444) : OddsVal(476),
                Market.TeamTotalOver1 => IsHome() ? OddsVal(453) : OddsVal(482),
                Market.TeamTotalUnder1 => IsHome() ? OddsVal(454) : OddsVal(483),
                Market.TeamTotalOver15 => IsHome() ? OddsVal(439) : OddsVal(471),
                Market.TeamTotalUnder15 => IsHome() ? OddsVal(440) : OddsVal(472),
                Market.TeamTotalOver2 => IsHome() ? OddsVal(449) : OddsVal(478),
                Market.TeamTotalUnder2 => IsHome() ? OddsVal(450) : OddsVal(479),
                Market.TeamTotalOver25 => IsHome() ? OddsVal(441) : OddsVal(473),
                Market.TeamTotalUnder25 => IsHome() ? OddsVal(442) : OddsVal(474),
                Market.TeamTotalOver3 => IsHome() ? OddsVal(451) : OddsVal(480),
                Market.TeamTotalUnder3 => IsHome() ? OddsVal(452) : OddsVal(481),
                Market.TeamTotalOver35 => IsHome() ? OddsVal(437) : OddsVal(469),
                Market.TeamTotalUnder35 => IsHome() ? OddsVal(438) : OddsVal(470),

                Market.TeamOppTotalOver05 => IsHome() ? OddsVal(475) : OddsVal(443),
                Market.TeamOppTotalUnder05 => IsHome() ? OddsVal(476) : OddsVal(444),
                Market.TeamOppTotalOver1 => IsHome() ? OddsVal(482) : OddsVal(453),
                Market.TeamOppTotalUnder1 => IsHome() ? OddsVal(483) : OddsVal(454),
                Market.TeamOppTotalOver15 => IsHome() ? OddsVal(471) : OddsVal(439),
                Market.TeamOppTotalUnder15 => IsHome() ? OddsVal(472) : OddsVal(440),
                Market.TeamOppTotalOver2 => IsHome() ? OddsVal(478) : OddsVal(449),
                Market.TeamOppTotalUnder2 => IsHome() ? OddsVal(479) : OddsVal(450),
                Market.TeamOppTotalOver25 => IsHome() ? OddsVal(473) : OddsVal(441),
                Market.TeamOppTotalUnder25 => IsHome() ? OddsVal(474) : OddsVal(442),
                Market.TeamOppTotalOver3 => IsHome() ? OddsVal(480) : OddsVal(451),
                Market.TeamOppTotalUnder3 => IsHome() ? OddsVal(481) : OddsVal(452),
                Market.TeamOppTotalOver35 => IsHome() ? OddsVal(469) : OddsVal(437),
                Market.TeamOppTotalUnder35 => IsHome() ? OddsVal(470) : OddsVal(438),

                Market.ResultWinOver05 => IsHome() ? OddsVal(568) : OddsVal(570),
                Market.ResultLoseOver05 => IsHome() ? OddsVal(570) : OddsVal(568),
                Market.ResultWinOver15 => IsHome() ? OddsVal(550) : OddsVal(551),
                Market.ResultLoseOver15 => IsHome() ? OddsVal(551) : OddsVal(550),
                Market.ResultWinOver25 => IsHome() ? OddsVal(562) : OddsVal(564),
                Market.ResultLoseOver25 => IsHome() ? OddsVal(564) : OddsVal(562),
                Market.ResultWinOver35 => IsHome() ? OddsVal(544) : OddsVal(546),
                Market.ResultLoseOver35 => IsHome() ? OddsVal(546) : OddsVal(544),
                Market.ResultWinOver45 => IsHome() ? OddsVal(556) : OddsVal(558),
                Market.ResultLoseOver45 => IsHome() ? OddsVal(558) : OddsVal(556),

                Market.AhWinM35 => IsHome() ? OddsVal(733) : OddsVal(734),
                Market.AhLoseM35 => IsHome() ? OddsVal(734) : OddsVal(733),
                Market.AhWinM325 => IsHome() ? OddsVal(737) : OddsVal(738),
                Market.AhLoseM325 => IsHome() ? OddsVal(738) : OddsVal(737),
                Market.AhWinM3 => IsHome() ? OddsVal(731) : OddsVal(732),
                Market.AhLoseM3 => IsHome() ? OddsVal(732) : OddsVal(731),
                Market.AhWinM275 => IsHome() ? OddsVal(723) : OddsVal(724),
                Market.AhLoseM275 => IsHome() ? OddsVal(724) : OddsVal(723),
                Market.AhWinM25 => IsHome() ? OddsVal(719) : OddsVal(720),
                Market.AhLoseM25 => IsHome() ? OddsVal(720) : OddsVal(719),
                Market.AhWinM225 => IsHome() ? OddsVal(721) : OddsVal(722),
                Market.AhLoseM225 => IsHome() ? OddsVal(722) : OddsVal(721),
                Market.AhWinM2 => IsHome() ? OddsVal(717) : OddsVal(718),
                Market.AhLoseM2 => IsHome() ? OddsVal(718) : OddsVal(717),
                Market.AhWinM175 => IsHome() ? OddsVal(715) : OddsVal(716),
                Market.AhLoseM175 => IsHome() ? OddsVal(716) : OddsVal(715),
                Market.AhWinM15 => IsHome() ? OddsVal(713) : OddsVal(714),
                Market.AhLoseM15 => IsHome() ? OddsVal(714) : OddsVal(713),
                Market.AhWinM125 => IsHome() ? OddsVal(703) : OddsVal(704),
                Market.AhLoseM125 => IsHome() ? OddsVal(704) : OddsVal(703),
                Market.AhWinM1 => IsHome() ? OddsVal(701) : OddsVal(702),
                Market.AhLoseM1 => IsHome() ? OddsVal(702) : OddsVal(701),
                Market.AhWinM075 => IsHome() ? OddsVal(699) : OddsVal(700),
                Market.AhLoseM075 => IsHome() ? OddsVal(700) : OddsVal(699),
                Market.AhWinM05 => IsHome() ? OddsVal(697) : OddsVal(698),
                Market.AhLoseM05 => IsHome() ? OddsVal(698) : OddsVal(697),
                Market.AhWinM025 => IsHome() ? OddsVal(695) : OddsVal(696),
                Market.AhLoseM025 => IsHome() ? OddsVal(696) : OddsVal(695),

                Market.AhWin0 => IsHome() ? OddsVal(705) : OddsVal(706),
                Market.AhLose0 => IsHome() ? OddsVal(706) : OddsVal(705),
                
                Market.AhWin025 => IsHome() ? OddsVal(707) : OddsVal(708),
                Market.AhLose025 => IsHome() ? OddsVal(708) : OddsVal(707),
                Market.AhWinP05 => IsHome() ? OddsVal(709) : OddsVal(710),
                Market.AhLoseP05 => IsHome() ? OddsVal(710) : OddsVal(709),
                Market.AhWin075 => IsHome() ? OddsVal(711) : OddsVal(712),
                Market.AhLose075 => IsHome() ? OddsVal(712) : OddsVal(711),
                Market.AhWinP1 => IsHome() ? OddsVal(725) : OddsVal(726),
                Market.AhLoseP1 => IsHome() ? OddsVal(726) : OddsVal(725),
                Market.AhWinP125 => IsHome() ? OddsVal(729) : OddsVal(730),
                Market.AhLoseP125 => IsHome() ? OddsVal(730) : OddsVal(729),
                Market.AhWinP15 => IsHome() ? OddsVal(727) : OddsVal(728),
                Market.AhLoseP15 => IsHome() ? OddsVal(728) : OddsVal(727),
                Market.AhWinP175 => IsHome() ? OddsVal(735) : OddsVal(736),
                Market.AhLoseP175 => IsHome() ? OddsVal(736) : OddsVal(735),
                Market.AhWinP2 => IsHome() ? OddsVal(741) : OddsVal(742),
                Market.AhLoseP2 => IsHome() ? OddsVal(742) : OddsVal(741),
                Market.AhWinP225 => IsHome() ? OddsVal(745) : OddsVal(746),
                Market.AhLoseP225 => IsHome() ? OddsVal(746) : OddsVal(745),
                Market.AhWinP25 => IsHome() ? OddsVal(743) : OddsVal(744),
                Market.AhLoseP25 => IsHome() ? OddsVal(744) : OddsVal(743),
                Market.AhWinP275 => IsHome() ? OddsVal(747) : OddsVal(748),
                Market.AhLoseP275 => IsHome() ? OddsVal(748) : OddsVal(747),
                Market.AhWinP3 => IsHome() ? OddsVal(751) : OddsVal(752),
                Market.AhLoseP3 => IsHome() ? OddsVal(752) : OddsVal(751),
                Market.AhWinP325 => IsHome() ? OddsVal(753) : OddsVal(754),
                Market.AhLoseP325 => IsHome() ? OddsVal(754) : OddsVal(753),
                Market.AhWinP35 => IsHome() ? OddsVal(755) : OddsVal(756),
                Market.AhLoseP35 => IsHome() ? OddsVal(756) : OddsVal(755),

                Market.CornersOver35 => OddsVal(675),
                Market.CornersUnder35 => OddsVal(676),
                Market.CornersOver45 => OddsVal(656),
                Market.CornersUnder45 => OddsVal(639),
                Market.CornersOver55 => OddsVal(619),
                Market.CornersUnder55 => OddsVal(620),
                Market.CornersOver65 => OddsVal(621),
                Market.CornersUnder65 => OddsVal(622),
                Market.CornersOver75 => OddsVal(611),
                Market.CornersUnder75 => OddsVal(612),
                Market.CornersOver85 => OddsVal(607),
                Market.CornersUnder85 => OddsVal(608),
                Market.CornersOver95 => OddsVal(601),
                Market.CornersUnder95 => OddsVal(602),
                Market.CornersOver105 => OddsVal(603),
                Market.CornersUnder105 => OddsVal(604),
                Market.CornersOver115 => OddsVal(605),
                Market.CornersUnder115 => OddsVal(606),
                Market.CornersOver125 => OddsVal(609),
                Market.CornersUnder125 => OddsVal(610),
                Market.CornersOver135 => OddsVal(623),
                Market.CornersUnder135 => OddsVal(624),

                Market.TeamCornersOver05 => IsHome() ? OddsVal(2014) : OddsVal(2025),
                Market.TeamCornersUnder05 => IsHome() ? OddsVal(2019) : OddsVal(2021),
                //Market.TeamCornersOver1 => IsHome() ? OddsVal() : OddsVal(1146),
                //Market.TeamCornersUnder1 => IsHome() ? OddsVal() : OddsVal(1147),
                Market.TeamCornersOver15 => IsHome() ? OddsVal(1118) : OddsVal(1132),
                Market.TeamCornersUnder15 => IsHome() ? OddsVal(1119) : OddsVal(1133),
                Market.TeamCornersOver2 => IsHome() ? OddsVal(1120) : OddsVal(1144),
                Market.TeamCornersUnder2 => IsHome() ? OddsVal(1121) : OddsVal(1145),
                Market.TeamCornersOver25 => IsHome() ? OddsVal(1100) : OddsVal(1128),
                Market.TeamCornersUnder25 => IsHome() ? OddsVal(1101) : OddsVal(1129),
                Market.TeamCornersOver3 => IsHome() ? OddsVal(1110) : OddsVal(1138),
                Market.TeamCornersUnder3 => IsHome() ? OddsVal(1111) : OddsVal(1139),
                Market.TeamCornersOver35 => IsHome() ? OddsVal(1094) : OddsVal(1122),
                Market.TeamCornersUnder35 => IsHome() ? OddsVal(1095) : OddsVal(1123),
                Market.TeamCornersOver4 => IsHome() ? OddsVal(1102) : OddsVal(1140),
                Market.TeamCornersUnder4 => IsHome() ? OddsVal(1103) : OddsVal(1141),
                Market.TeamCornersOver45 => IsHome() ? OddsVal(1092) : OddsVal(1124),
                Market.TeamCornersUnder45 => IsHome() ? OddsVal(1093) : OddsVal(1125),
                Market.TeamCornersOver5 => IsHome() ? OddsVal(1104) : OddsVal(1136),
                Market.TeamCornersUnder5 => IsHome() ? OddsVal(1105) : OddsVal(1137),
                Market.TeamCornersOver55 => IsHome() ? OddsVal(1088) : OddsVal(1126),
                Market.TeamCornersUnder55 => IsHome() ? OddsVal(1089) : OddsVal(1127),
                Market.TeamCornersOver6 => IsHome() ? OddsVal(1107) : OddsVal(1143),
                Market.TeamCornersUnder6 => IsHome() ? OddsVal(1106) : OddsVal(1142),
                Market.TeamCornersOver65 => IsHome() ? OddsVal(1090) : OddsVal(1130),
                Market.TeamCornersUnder65 => IsHome() ? OddsVal(1091) : OddsVal(1131),
                Market.TeamCornersOver7 => IsHome() ? OddsVal(1109) : OddsVal(1149),
                Market.TeamCornersUnder7 => IsHome() ? OddsVal(1108) : OddsVal(1148),
                Market.TeamCornersOver75 => IsHome() ? OddsVal(1096) : OddsVal(1134),
                Market.TeamCornersUnder75 => IsHome() ? OddsVal(1097) : OddsVal(1135),
                Market.TeamCornersOver8 => IsHome() ? OddsVal(1113) : OddsVal(1153),
                Market.TeamCornersUnder8 => IsHome() ? OddsVal(1112) : OddsVal(1152),
                Market.TeamCornersOver85 => IsHome() ? OddsVal(1098) : OddsVal(1150),
                Market.TeamCornersUnder85 => IsHome() ? OddsVal(1099) : OddsVal(1151),
                Market.TeamCornersOver9 => IsHome() ? OddsVal(1117) : OddsVal(2024),
                Market.TeamCornersUnder9 => IsHome() ? OddsVal(1116) : OddsVal(2027),
                Market.TeamCornersOver95 => IsHome() ? OddsVal(1114) : OddsVal(2020),
                Market.TeamCornersUnder95 => IsHome() ? OddsVal(1115) : OddsVal(2022),

                Market.OppCornersOver05 => IsHome() ? OddsVal(2025) : OddsVal(2014),
                Market.OppCornersUnder05 => IsHome() ? OddsVal(2021) : OddsVal(2019),
                //Market.OppCornersOver1 => IsHome() ? OddsVal(1146) : OddsVal(),
                //Market.OppCornersUnder1 => IsHome() ? OddsVal(1147) : OddsVal(),
                Market.OppCornersOver15 => IsHome() ? OddsVal(1132) : OddsVal(1118),
                Market.OppCornersUnder15 => IsHome() ? OddsVal(1133) : OddsVal(1119),
                Market.OppCornersOver2 => IsHome() ? OddsVal(1144) : OddsVal(1120),
                Market.OppCornersUnder2 => IsHome() ? OddsVal(1145) : OddsVal(1121),
                Market.OppCornersOver25 => IsHome() ? OddsVal(1128) : OddsVal(1100),
                Market.OppCornersUnder25 => IsHome() ? OddsVal(1129) : OddsVal(1101),
                Market.OppCornersOver3 => IsHome() ? OddsVal(1138) : OddsVal(1110),
                Market.OppCornersUnder3 => IsHome() ? OddsVal(1139) : OddsVal(1111),
                Market.OppCornersOver35 => IsHome() ? OddsVal(1122) : OddsVal(1094),
                Market.OppCornersUnder35 => IsHome() ? OddsVal(1123) : OddsVal(1095),
                Market.OppCornersOver4 => IsHome() ? OddsVal(1140) : OddsVal(1102),
                Market.OppCornersUnder4 => IsHome() ? OddsVal(1141) : OddsVal(1103),
                Market.OppCornersOver45 => IsHome() ? OddsVal(1124) : OddsVal(1092),
                Market.OppCornersUnder45 => IsHome() ? OddsVal(1125) : OddsVal(1093),
                Market.OppCornersOver5 => IsHome() ? OddsVal(1136) : OddsVal(1104),
                Market.OppCornersUnder5 => IsHome() ? OddsVal(1137) : OddsVal(1105),
                Market.OppCornersOver55 => IsHome() ? OddsVal(1126) : OddsVal(1088),
                Market.OppCornersUnder55 => IsHome() ? OddsVal(1127) : OddsVal(1089),
                Market.OppCornersOver6 => IsHome() ? OddsVal(1143) : OddsVal(1107),
                Market.OppCornersUnder6 => IsHome() ? OddsVal(1142) : OddsVal(1106),
                Market.OppCornersOver65 => IsHome() ? OddsVal(1130) : OddsVal(1090),
                Market.OppCornersUnder65 => IsHome() ? OddsVal(1131) : OddsVal(1091),
                Market.OppCornersOver7 => IsHome() ? OddsVal(1149) : OddsVal(1109),
                Market.OppCornersUnder7 => IsHome() ? OddsVal(1148) : OddsVal(1108),
                Market.OppCornersOver75 => IsHome() ? OddsVal(1134) : OddsVal(1096),
                Market.OppCornersUnder75 => IsHome() ? OddsVal(1135) : OddsVal(1097),
                Market.OppCornersOver8 => IsHome() ? OddsVal(1153) : OddsVal(1113),
                Market.OppCornersUnder8 => IsHome() ? OddsVal(1152) : OddsVal(1112),
                Market.OppCornersOver85 => IsHome() ? OddsVal(1150) : OddsVal(1098),
                Market.OppCornersUnder85 => IsHome() ? OddsVal(1151) : OddsVal(1099),
                Market.OppCornersOver9 => IsHome() ? OddsVal(2024) : OddsVal(1117),
                Market.OppCornersUnder9 => IsHome() ? OddsVal(2027) : OddsVal(116),
                Market.OppCornersOver95 => IsHome() ? OddsVal(2020) : OddsVal(1114),
                Market.OppCornersUnder95 => IsHome() ? OddsVal(2022) : OddsVal(1115),

                Market.Corners1x2_Win => IsHome() ? OddsVal(908) : OddsVal(910),
                Market.Corners1x2_Draw => OddsVal(909),
                Market.Corners1x2_Lose => IsHome() ? OddsVal(910) : OddsVal(908),

                Market.CardsOver25 => OddsVal(1263),
                Market.CardsUnder25 => OddsVal(1264),
                Market.CardsOver3 => OddsVal(1265),
                Market.CardsUnder3 => OddsVal(1266),
                Market.CardsOver35 => OddsVal(1253),
                Market.CardsUnder35 => OddsVal(1254),
                Market.CardsOver4 => OddsVal(1267),
                Market.CardsUnder4 => OddsVal(1268),
                Market.CardsOver45 => OddsVal(1255),
                Market.CardsUnder45 => OddsVal(1256),

                //Market.TeamCardsOver1 => IsHome() ? OddsVal() : OddsVal(),
                //Market.TeamCardsUnder1 => IsHome() ? OddsVal() : OddsVal(),
                Market.TeamCardsOver15 => IsHome() ? OddsVal(1285) : OddsVal(1297),
                Market.TeamCardsUnder15 => IsHome() ? OddsVal(1286) : OddsVal(1298),
                Market.TeamCardsOver2 => IsHome() ? OddsVal(2106) : OddsVal(2114),
                Market.TeamCardsUnder2 => IsHome() ? OddsVal(2108) : OddsVal(2118),
                Market.TeamCardsOver25 => IsHome() ? OddsVal(1287) : OddsVal(1293),
                Market.TeamCardsUnder25 => IsHome() ? OddsVal(1288) : OddsVal(1294),
                //Market.TeamCardsOver3 => IsHome() ? OddsVal() : OddsVal(2111),
                //Market.TeamCardsUnder3 => IsHome() ? OddsVal() : OddsVal(2115),
                Market.TeamCardsOver35 => IsHome() ? OddsVal(1289) : OddsVal(1295),
                Market.TeamCardsUnder35 => IsHome() ? OddsVal(1290) : OddsVal(1296),
                //Market.TeamCardsOver4 => IsHome() ? OddsVal() : OddsVal(),
                //Market.TeamCardsUnder4 => IsHome() ? OddsVal() : OddsVal(),
                Market.TeamCardsOver45 => IsHome() ? OddsVal(2110) : OddsVal(2113),
                Market.TeamCardsUnder45 => IsHome() ? OddsVal(2107) : OddsVal(2116),

                //Market.OppCardsOver1 => IsHome() ? OddsVal() : OddsVal(),
                //Market.OppCardsUnder1 => IsHome() ? OddsVal() : OddsVal(),
                Market.OppCardsOver15 => IsHome() ? OddsVal(1297) : OddsVal(1285),
                Market.OppCardsUnder15 => IsHome() ? OddsVal(1298) : OddsVal(1286),
                Market.OppCardsOver2 => IsHome() ? OddsVal(2114) : OddsVal(2106),
                Market.OppCardsUnder2 => IsHome() ? OddsVal(2118) : OddsVal(2108),
                Market.OppCardsOver25 => IsHome() ? OddsVal(1293) : OddsVal(1287),
                Market.OppCardsUnder25 => IsHome() ? OddsVal(1294) : OddsVal(1288),
                //Market.OppCardsOver3 => IsHome() ? OddsVal(2111) : OddsVal(),
                //Market.OppCardsUnder3 => IsHome() ? OddsVal(2115) : OddsVal(),
                Market.OppCardsOver35 => IsHome() ? OddsVal(1295) : OddsVal(1289),
                Market.OppCardsUnder35 => IsHome() ? OddsVal(1296) : OddsVal(1290),
                //Market.OppCardsOver4 => IsHome() ? OddsVal() : OddsVal(),
                //Market.OppCardsUnder4 => IsHome() ? OddsVal() : OddsVal(),
                Market.OppCardsOver45 => IsHome() ? OddsVal(2113) : OddsVal(2110),
                Market.OppCardsUnder45 => IsHome() ? OddsVal(2116) : OddsVal(2107),

                Market.CardsAhWin05 => IsHome() ? OddsVal(1279) : OddsVal(1280),
                Market.CardsAhLose05 => IsHome() ? OddsVal(1280) : OddsVal(1279),
                Market.CardsAhWin1 => IsHome() ? OddsVal(1281) : OddsVal(1282),
                Market.CardsAhLose1 => IsHome() ? OddsVal(1282) : OddsVal(1281),
                Market.CardsAhWin15 => IsHome() ? OddsVal(2104) : OddsVal(2103),
                Market.CardsAhLose15 => IsHome() ? OddsVal(2103) : OddsVal(2104),
                Market.CardsAhWin2 => IsHome() ? OddsVal(2099) : OddsVal(2095),
                Market.CardsAhLose2 => IsHome() ? OddsVal(2095) : OddsVal(2099),

                //Отсутствуют значения в таблице
                //Market.CardsAhWin25 => IsHome() ? OddsVal() : OddsVal(),
                //Market.CardsAhLose25 => IsHome() ? OddsVal() : OddsVal(),
                //Market.CardsAhWin3 => IsHome() ? OddsVal() : OddsVal(),
                //Market.CardsAhLose3 => IsHome() ? OddsVal() : OddsVal(),
                //Market.CardsAhWin35 => IsHome() ? OddsVal() : OddsVal(),
                //Market.CardsAhLose35 => IsHome() ? OddsVal() : OddsVal(),

                Market.RedCardsYes => OddsVal(1365),
                Market.RedCardsNo => OddsVal(1366),

                Market.YellowCardsWin => IsHome() ? OddsVal(1728) : OddsVal(1729),
                Market.YellowCardsDraw => OddsVal(1727),
                Market.YellowCardsLose => IsHome() ? OddsVal(1729) : OddsVal(1728),

                Market.ExactGoals_0 => OddsVal(815),
                Market.ExactGoals_1 => OddsVal(814),
                Market.ExactGoals_2 => OddsVal(812),
                Market.ExactGoals_3 => OddsVal(813),
                Market.ExactGoals_4 => OddsVal(817),
                Market.ExactGoals_5 => OddsVal(818),
                Market.ExactGoals_6 => OddsVal(820),

                Market.ExactScore_0_0 => OddsVal(223),
                Market.ExactScore_1_0 => OddsVal(213),
                Market.ExactScore_2_0 => OddsVal(214),
                Market.ExactScore_3_0 => OddsVal(216),
                Market.ExactScore_4_0 => OddsVal(219),
                Market.ExactScore_1_1 => OddsVal(224),
                Market.ExactScore_2_1 => OddsVal(215),
                Market.ExactScore_3_1 => OddsVal(217),
                Market.ExactScore_4_1 => OddsVal(220),
                Market.ExactScore_1_2 => OddsVal(232),
                Market.ExactScore_2_2 => OddsVal(225),
                Market.ExactScore_3_2 => OddsVal(218),
                Market.ExactScore_4_2 => OddsVal(221),
                Market.ExactScore_1_3 => OddsVal(233),
                Market.ExactScore_2_3 => OddsVal(235),
                Market.ExactScore_3_3 => OddsVal(226),
                Market.ExactScore_4_3 => OddsVal(222),
                Market.ExactScore_1_4 => OddsVal(234),
                Market.ExactScore_2_4 => OddsVal(236),
                Market.ExactScore_3_4 => OddsVal(237),
                Market.ExactScore_4_4 => OddsVal(227),

                Market.Fouls_1x2_Win => IsHome() ? OddsVal(1801) : OddsVal(1799),
                Market.Fouls_1x2_Draw => OddsVal(1800),
                Market.Fouls_1x2_Lose => IsHome() ? OddsVal(1799) : OddsVal(1801),

                //Market.FoulsAhWin05 => IsHome() ? OddsVal() : OddsVal(),
                //Market.FoulsAhLose05 => IsHome() ? OddsVal() : OddsVal(),
                Market.FoulsAhWin1 => IsHome() ? OddsVal(2421) : OddsVal(2400),
                Market.FoulsAhLose1 => IsHome() ? OddsVal(2400) : OddsVal(2421),
                Market.FoulsAhWin15 => IsHome() ? OddsVal(1794) : OddsVal(1791),
                Market.FoulsAhLose15 => IsHome() ? OddsVal(1791) : OddsVal(1794),
                Market.FoulsAhWin2 => IsHome() ? OddsVal(2386) : OddsVal(2403),
                Market.FoulsAhLose2 => IsHome() ? OddsVal(2403) : OddsVal(2386),
                Market.FoulsAhWin25 => IsHome() ? OddsVal(1795) : OddsVal(1790),
                Market.FoulsAhLose25 => IsHome() ? OddsVal(1790) : OddsVal(1795),
                Market.FoulsAhWin3 => IsHome() ? OddsVal(2426) : OddsVal(2414),
                Market.FoulsAhLose3 => IsHome() ? OddsVal(2414) : OddsVal(2426),
                Market.FoulsAhWin35 => IsHome() ? OddsVal(2391) : OddsVal(2418),
                Market.FoulsAhLose35 => IsHome() ? OddsVal(2418) : OddsVal(2391),
                Market.FoulsAhWin4 => IsHome() ? OddsVal(2425) : OddsVal(2427),
                Market.FoulsAhLose4 => IsHome() ? OddsVal(2427) : OddsVal(2425),
                Market.FoulsAhWin45 => IsHome() ? OddsVal(2416) : OddsVal(2398),
                Market.FoulsAhLose45 => IsHome() ? OddsVal(2398) : OddsVal(2416),
                Market.FoulsAhWin5 => IsHome() ? OddsVal(2393) : OddsVal(2405),
                Market.FoulsAhLose5 => IsHome() ? OddsVal(2405) : OddsVal(2393),
                Market.FoulsAhWin55 => IsHome() ? OddsVal(2422) : OddsVal(2408),
                Market.FoulsAhLose55 => IsHome() ? OddsVal(2408) : OddsVal(2422),

                Market.BothHalvesWin => OddsVal(434),
                Market.BothHalvesLose => OddsVal(436),

                Market.BtsYes => OddsVal(168),
                Market.BtsNo => OddsVal(169),

                Market.TeamCleanSheetNo => OddsVal(165),
                Market.TeamCleanSheetOppNo => OddsVal(167),

                Market.WinToNilYes => OddsVal(170),
                Market.WinToNilNo => OddsVal(171),

                Market.WinEitherHalf => IsHome() ? OddsVal(906) : OddsVal(907),
                Market.WinEitherHalfOpp => IsHome() ? OddsVal(907) : OddsVal(906),

                Market.ScoreFirst => IsHome() ? OddsVal(851) : OddsVal(853),
                Market.ScoreFirstOpp => IsHome() ? OddsVal(853) : OddsVal(851),

                Market.FirstTeamToScore => IsHome() ? OddsVal(2430) : OddsVal(2431),
                Market.FirstTeamToScoreOpp => IsHome() ? OddsVal(2431) : OddsVal(2430),

                Market.TeamToScore => OddsVal(597),
                Market.TeamToScoreNo => OddsVal(598),
                Market.OppTeamToScore => OddsVal(599),
                Market.OppTeamToScoreNo => OddsVal(600),

                Market.BtsInBothHalves => OddsVal(1430),

                Market.OddEven_Odd => OddsVal(534),
                Market.OddEven_Even => OddsVal(535),

                Market.TeamOddEven_Odd => OddsVal(804),
                Market.TeamOddEven_Even => OddsVal(805),
                Market.OppOddEven_Odd => OddsVal(806),
                Market.OppTeamOddEven_Even => OddsVal(807),

                Market.w1x2_15_Win => IsHome() ? OddsVal(1597) : OddsVal(1596),
                Market.w1x2_15_Draw => OddsVal(1598),
                Market.w1x2_15_Lose => IsHome() ? OddsVal(1596) : OddsVal(1597),
                Market.w1x2_30_Lose => IsHome() ? OddsVal(1605) : OddsVal(1606),
                Market.w1x2_30_Draw => OddsVal(1607),
                Market.w1x2_30_Win => IsHome() ? OddsVal(1606) : OddsVal(1605),
                Market.w1x2_60_Lose => IsHome() ? OddsVal(1601) : OddsVal(1599),
                Market.w1x2_60_Draw => OddsVal(1600),
                Market.w1x2_60_Win => IsHome() ? OddsVal(1599) : OddsVal(1601),
                Market.w1x2_75_Lose => IsHome() ? OddsVal(1602) : OddsVal(1603),
                Market.w1x2_75_Draw => OddsVal(1604),
                Market.w1x2_75_Win => IsHome() ? OddsVal(1603) : OddsVal(1602),

                Market.DC_15_WinOrDraw => IsHome() ? OddsVal(1612) : OddsVal(1611),
                Market.DC_15_LoseOrDraw => IsHome() ? OddsVal(1611) : OddsVal(1612),
                Market.DC_15_WinOrLose => OddsVal(1613),
                Market.DC_30_WinOrDraw => IsHome() ? OddsVal(1608) : OddsVal(1610),
                Market.DC_30_LoseOrDraw => IsHome() ? OddsVal(1610) : OddsVal(1608),
                Market.DC_30_WinOrLose => OddsVal(1609),
                Market.DC_75_WinOrDraw => IsHome() ? OddsVal(1618) : OddsVal(1619),
                Market.DC_75_LoseOrDraw => IsHome() ? OddsVal(1619) : OddsVal(1618),
                Market.DC_75_WinOrLose => OddsVal(1617),

                Market.GoalIn_1_15_Yes => OddsVal(1621),
                Market.GoalIn_1_15_No => OddsVal(1620),
                Market.GoalIn_16_30_Yes => OddsVal(1623),
                Market.GoalIn_31_45_No => OddsVal(1624),
                Market.GoalIn_46_60_Yes => OddsVal(1626),
                Market.GoalIn_46_60_No => OddsVal(1627),
                Market.GoalIn_61_75_Yes => OddsVal(1629),
                Market.GoalIn_61_75_No => OddsVal(1628),
                Market.GoalIn_76_90_Yes => OddsVal(1631),
                Market.GoalIn_76_90_No => OddsVal(1630),

                Market.PenaltyAwardedYes => OddsVal(1756),
                Market.PenaltyAwardedNo => OddsVal(1757),


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

                Market.WinOrDraw => IsHome() ? OddsVal(524) : OddsVal(526),
                Market.WinOrLose => OddsVal(525),
                Market.DrawOrLose => IsHome() ? OddsVal(526) : OddsVal(524),

                //Нет информации по таймам
                //Market.WinNoBet => throw new NotImplementedException(),
                //Market.LoseNoBet => throw new NotImplementedException(),

                Market.TotalOver05 => OddsVal(94),
                Market.TotalUnder05 => OddsVal(95),
                Market.TotalOver1 => OddsVal(98),
                Market.TotalUnder1 => OddsVal(99),
                Market.TotalOver15 => OddsVal(89),
                Market.TotalUnder15 => OddsVal(90),
                Market.TotalOver2 => OddsVal(106),
                Market.TotalUnder2 => OddsVal(107),
                Market.TotalOver25 => OddsVal(92),
                Market.TotalUnder25 => OddsVal(93),
                Market.TotalOver3 => OddsVal(111),
                Market.TotalUnder3 => OddsVal(112),
                Market.TotalOver35 => OddsVal(87),
                Market.TotalUnder35 => OddsVal(88),
                Market.TotalOver4 => OddsVal(117),
                Market.TotalUnder4 => OddsVal(118),
                Market.TotalOver45 => OddsVal(91),
                Market.TotalUnder45 => OddsVal(110),

                Market.TeamTotalOver05 => IsHome() ? OddsVal(1394) : OddsVal(1398),
                Market.TeamTotalUnder05 => IsHome() ? OddsVal(1387) : OddsVal(1396),
                Market.TeamTotalOver1 => IsHome() ? OddsVal(1392) : OddsVal(1402),
                Market.TeamTotalUnder1 => IsHome() ? OddsVal(1390) : OddsVal(1400),
                Market.TeamTotalOver15 => IsHome() ? OddsVal(1391) : OddsVal(1395),
                Market.TeamTotalUnder15 => IsHome() ? OddsVal(1389) : OddsVal(1399),
                Market.TeamTotalOver2 => IsHome() ? OddsVal(1388) : OddsVal(1397),
                Market.TeamTotalUnder2 => IsHome() ? OddsVal(1393) : OddsVal(1401),
                Market.TeamTotalOver25 => IsHome() ? OddsVal(2157) : OddsVal(2163),
                Market.TeamTotalUnder25 => IsHome() ? OddsVal(2158) : OddsVal(2162),
                //Отсутствуют значения в таблице, если команда играет в гостях!
                //Market.TeamTotalOver3 => IsHome() ? OddsVal(2155) : OddsVal(),
                //Market.TeamTotalUnder3 => IsHome() ? OddsVal(2159) : OddsVal(),
                Market.TeamTotalOver35 => IsHome() ? OddsVal(2154) : OddsVal(2165),
                Market.TeamTotalUnder35 => IsHome() ? OddsVal(2156) : OddsVal(2161),

                Market.TeamOppTotalOver05 => IsHome() ? OddsVal(1398) : OddsVal(1394),
                Market.TeamOppTotalUnder05 => IsHome() ? OddsVal(1396) : OddsVal(1387),
                Market.TeamOppTotalOver1 => IsHome() ? OddsVal(1402) : OddsVal(1392),
                Market.TeamOppTotalUnder1 => IsHome() ? OddsVal(1400) : OddsVal(1390),
                Market.TeamOppTotalOver15 => IsHome() ? OddsVal(1395) : OddsVal(1391),
                Market.TeamOppTotalUnder15 => IsHome() ? OddsVal(1399) : OddsVal(1389),
                Market.TeamOppTotalOver2 => IsHome() ? OddsVal(1397) : OddsVal(1388),
                Market.TeamOppTotalUnder2 => IsHome() ? OddsVal(1401) : OddsVal(1393),
                Market.TeamOppTotalOver25 => IsHome() ? OddsVal(2163) : OddsVal(2157),
                Market.TeamOppTotalUnder25 => IsHome() ? OddsVal(2162) : OddsVal(2158),
                //Market.TeamOppTotalOver3 => IsHome() ? OddsVal() : OddsVal(),
                //Market.TeamOppTotalUnder3 => IsHome() ? OddsVal() : OddsVal(),
                Market.TeamOppTotalOver35 => IsHome() ? OddsVal(2165) : OddsVal(2154),
                Market.TeamOppTotalUnder35 => IsHome() ? OddsVal(2161) : OddsVal(2156),

                Market.AhWinM35 => IsHome() ? OddsVal(904) : OddsVal(905),
                Market.AhLoseM35 => IsHome() ? OddsVal(905) : OddsVal(904),
                Market.AhWinM325 => IsHome() ? OddsVal(902) : OddsVal(903),
                Market.AhLoseM325 => IsHome() ? OddsVal(903) : OddsVal(902),
                Market.AhWinM3 => IsHome() ? OddsVal(898) : OddsVal(899),
                Market.AhLoseM3 => IsHome() ? OddsVal(899) : OddsVal(898),
                Market.AhWinM275 => IsHome() ? OddsVal(896) : OddsVal(897),
                Market.AhLoseM275 => IsHome() ? OddsVal(897) : OddsVal(896),
                Market.AhWinM25 => IsHome() ? OddsVal(880) : OddsVal(881),
                Market.AhLoseM25 => IsHome() ? OddsVal(881) : OddsVal(880),
                Market.AhWinM225 => IsHome() ? OddsVal(892) : OddsVal(893),
                Market.AhLoseM225 => IsHome() ? OddsVal(893) : OddsVal(892),
                Market.AhWinM2 => IsHome() ? OddsVal(878) : OddsVal(879),
                Market.AhLoseM2 => IsHome() ? OddsVal(879) : OddsVal(878),
                Market.AhWinM175 => IsHome() ? OddsVal(882) : OddsVal(883),
                Market.AhLoseM175 => IsHome() ? OddsVal(883) : OddsVal(882),
                Market.AhWinM15 => IsHome() ? OddsVal(870) : OddsVal(871),
                Market.AhLoseM15 => IsHome() ? OddsVal(871) : OddsVal(870),
                Market.AhWinM125 => IsHome() ? OddsVal(872) : OddsVal(873),
                Market.AhLoseM125 => IsHome() ? OddsVal(873) : OddsVal(872),
                Market.AhWinM1 => IsHome() ? OddsVal(868) : OddsVal(869),
                Market.AhLoseM1 => IsHome() ? OddsVal(869) : OddsVal(868),
                Market.AhWinM075 => IsHome() ? OddsVal(864) : OddsVal(865),
                Market.AhLoseM075 => IsHome() ? OddsVal(865) : OddsVal(864),
                Market.AhWinM05 => IsHome() ? OddsVal(856) : OddsVal(857),
                Market.AhLoseM05 => IsHome() ? OddsVal(857) : OddsVal(856),
                Market.AhWinM025 => IsHome() ? OddsVal(854) : OddsVal(855),
                Market.AhLoseM025 => IsHome() ? OddsVal(855) : OddsVal(854),

                Market.AhWin0 => IsHome() ? OddsVal(858) : OddsVal(859),
                Market.AhLose0 => IsHome() ? OddsVal(859) : OddsVal(858),

                Market.AhWin025 => IsHome() ? OddsVal(860) : OddsVal(861),
                Market.AhLose025 => IsHome() ? OddsVal(861) : OddsVal(860),
                Market.AhWinP05 => IsHome() ? OddsVal(862) : OddsVal(863),
                Market.AhLoseP05 => IsHome() ? OddsVal(863) : OddsVal(862),
                Market.AhWin075 => IsHome() ? OddsVal(866) : OddsVal(867),
                Market.AhLose075 => IsHome() ? OddsVal(867) : OddsVal(866),
                Market.AhWinP1 => IsHome() ? OddsVal(874) : OddsVal(875),
                Market.AhLoseP1 => IsHome() ? OddsVal(875) : OddsVal(874),
                Market.AhWinP125 => IsHome() ? OddsVal(884) : OddsVal(885),
                Market.AhLoseP125 => IsHome() ? OddsVal(885) : OddsVal(884),
                Market.AhWinP15 => IsHome() ? OddsVal(876) : OddsVal(877),
                Market.AhLoseP15 => IsHome() ? OddsVal(877) : OddsVal(876),
                Market.AhWinP175 => IsHome() ? OddsVal(890) : OddsVal(891),
                Market.AhLoseP175 => IsHome() ? OddsVal(891) : OddsVal(890),
                Market.AhWinP2 => IsHome() ? OddsVal(886) : OddsVal(887),
                Market.AhLoseP2 => IsHome() ? OddsVal(887) : OddsVal(886),
                Market.AhWinP225 => IsHome() ? OddsVal(894) : OddsVal(895),
                Market.AhLoseP225 => IsHome() ? OddsVal(895) : OddsVal(894),
                Market.AhWinP25 => IsHome() ? OddsVal(888) : OddsVal(889),
                Market.AhLoseP25 => IsHome() ? OddsVal(889) : OddsVal(888),
                Market.AhWinP275 => IsHome() ? OddsVal(900) : OddsVal(901),
                Market.AhLoseP275 => IsHome() ? OddsVal(901) : OddsVal(900),
                Market.AhWinP3 => IsHome() ? OddsVal(1899) : OddsVal(1900),
                Market.AhLoseP3 => IsHome() ? OddsVal(1900) : OddsVal(1899),
                Market.AhWinP325 => IsHome() ? OddsVal(1902) : OddsVal(1903),
                Market.AhLoseP325 => IsHome() ? OddsVal(1903) : OddsVal(1902),
                Market.AhWinP35 => IsHome() ? OddsVal(1898) : OddsVal(1905),
                Market.AhLoseP35 => IsHome() ? OddsVal(1905) : OddsVal(1898),

                Market.ExactGoals_0 => OddsVal(843),
                Market.ExactGoals_1 => OddsVal(842),
                Market.ExactGoals_2 => OddsVal(841),
                Market.ExactGoals_3 => OddsVal(845),
                Market.ExactGoals_4 => OddsVal(847),
                Market.ExactGoals_5 => OddsVal(849),
                //Market.ExactGoals_6 => OddsVal(),
                
                Market.ExactScore_0_0 => OddsVal(351),
                Market.ExactScore_1_0 => OddsVal(342),
                Market.ExactScore_2_0 => OddsVal(343),
                Market.ExactScore_3_0 => OddsVal(345),
                Market.ExactScore_4_0 => OddsVal(348),
                Market.ExactScore_1_1 => OddsVal(352),
                Market.ExactScore_2_1 => OddsVal(344),
                Market.ExactScore_3_1 => OddsVal(346),
                Market.ExactScore_4_1 => OddsVal(349),
                Market.ExactScore_1_2 => OddsVal(359),
                Market.ExactScore_2_2 => OddsVal(353),
                Market.ExactScore_3_2 => OddsVal(347),
                Market.ExactScore_4_2 => OddsVal(350),
                Market.ExactScore_1_3 => OddsVal(360),
                Market.ExactScore_2_3 => OddsVal(362),
                Market.ExactScore_3_3 => OddsVal(354),
                Market.ExactScore_4_3 => OddsVal(364),
                Market.ExactScore_1_4 => OddsVal(361),
                Market.ExactScore_2_4 => OddsVal(363),
                Market.ExactScore_3_4 => OddsVal(374),
                Market.ExactScore_4_4 => OddsVal(370),

                Market.BtsYes => OddsVal(530),
                Market.BtsNo => OddsVal(531),

                Market.OddEven_Odd => OddsVal(536),
                Market.OddEven_Even => OddsVal(537),

                //Отсутствует информация по таймам

                //Market.TeamOddEven_Odd => OddsVal(),
                //Market.TeamOddEven_Even => OddsVal(),
                //Market.OppOddEven_Odd => OddsVal(),
                //Market.OppTeamOddEven_Even => OddsVal(),

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

                Market.WinOrDraw => IsHome() ? OddsVal(527) : OddsVal(529),
                Market.WinOrLose => OddsVal(528),
                Market.DrawOrLose => IsHome() ? OddsVal(529) : OddsVal(527),

                //Нет информации по таймам
                //Market.WinNoBet => throw new NotImplementedException(),
                //Market.LoseNoBet => throw new NotImplementedException(),

                Market.TotalOver05 => OddsVal(125),
                Market.TotalUnder05 => OddsVal(126),
                Market.TotalOver1 => OddsVal(131),
                Market.TotalUnder1 => OddsVal(132),
                Market.TotalOver15 => OddsVal(121),
                Market.TotalUnder15 => OddsVal(122),
                Market.TotalOver2 => OddsVal(129),
                Market.TotalUnder2 => OddsVal(130),
                Market.TotalOver25 => OddsVal(123),
                Market.TotalUnder25 => OddsVal(124),
                Market.TotalOver3 => OddsVal(141),
                Market.TotalUnder3 => OddsVal(142),
                Market.TotalOver35 => OddsVal(119),
                Market.TotalUnder35 => OddsVal(120),
                Market.TotalOver4 => OddsVal(153),
                Market.TotalUnder4 => OddsVal(154),
                Market.TotalOver45 => OddsVal(127),
                Market.TotalUnder45 => OddsVal(128),

                Market.TeamTotalOver05 => IsHome() ? OddsVal(1412) : OddsVal(1420),
                Market.TeamTotalUnder05 => IsHome() ? OddsVal(1405) : OddsVal(1418),
                Market.TeamTotalOver1 => IsHome() ? OddsVal(1409) : OddsVal(1419),
                Market.TeamTotalUnder1 => IsHome() ? OddsVal(1411) : OddsVal(1416),
                Market.TeamTotalOver15 => IsHome() ? OddsVal(1406) : OddsVal(1414),
                Market.TeamTotalUnder15 => IsHome() ? OddsVal(1407) : OddsVal(1415),
                Market.TeamTotalOver2 => IsHome() ? OddsVal(1403) : OddsVal(1417),
                Market.TeamTotalUnder2 => IsHome() ? OddsVal(1410) : OddsVal(1413),
                Market.TeamTotalOver25 => IsHome() ? OddsVal(1408) : OddsVal(2172),
                Market.TeamTotalUnder25 => IsHome() ? OddsVal(1404) : OddsVal(2171),
                //Отсутствуют значения в таблице, если команда играет в гостях!
                //Market.TeamTotalOver3 => IsHome() ? OddsVal(2166) : OddsVal(),
                //Market.TeamTotalUnder3 => IsHome() ? OddsVal(2169) : OddsVal(),
                Market.TeamTotalOver35 => IsHome() ? OddsVal(2168) : OddsVal(2173),
                //Market.TeamTotalUnder35 => IsHome() ? OddsVal(2167) : OddsVal(),

                Market.TeamOppTotalOver05 => IsHome() ? OddsVal(1420) : OddsVal(1412),
                Market.TeamOppTotalUnder05 => IsHome() ? OddsVal(1418) : OddsVal(1405),
                Market.TeamOppTotalOver1 => IsHome() ? OddsVal(1419) : OddsVal(1409),
                Market.TeamOppTotalUnder1 => IsHome() ? OddsVal(1416) : OddsVal(1411),
                Market.TeamOppTotalOver15 => IsHome() ? OddsVal(1414) : OddsVal(1406),
                Market.TeamOppTotalUnder15 => IsHome() ? OddsVal(1415) : OddsVal(1407),
                Market.TeamOppTotalOver2 => IsHome() ? OddsVal(1417) : OddsVal(1403),
                Market.TeamOppTotalUnder2 => IsHome() ? OddsVal(1413) : OddsVal(1410),
                Market.TeamOppTotalOver25 => IsHome() ? OddsVal(2172) : OddsVal(1408),
                Market.TeamOppTotalUnder25 => IsHome() ? OddsVal(2171) : OddsVal(1404),
                //Market.TeamOppTotalOver3 => IsHome() ? OddsVal() : OddsVal(),
                //Market.TeamOppTotalUnder3 => IsHome() ? OddsVal() : OddsVal(),
                Market.TeamOppTotalOver35 => IsHome() ? OddsVal(2173) : OddsVal(2168),
                //Market.TeamOppTotalUnder35 => IsHome() ? OddsVal() : OddsVal(),

                Market.AhWinM35 => IsHome() ? OddsVal(2132) : OddsVal(2128),
                Market.AhLoseM35 => IsHome() ? OddsVal(2128) : OddsVal(2132),
                //Market.AhWinM325 => IsHome() ? OddsVal() : OddsVal(),
                //Market.AhLoseM325 => IsHome() ? OddsVal() : OddsVal(),
                Market.AhWinM3 => IsHome() ? OddsVal(2140) : OddsVal(2142),
                Market.AhLoseM3 => IsHome() ? OddsVal(2142) : OddsVal(2140),
                //Market.AhWinM275 => IsHome() ? OddsVal() : OddsVal(),
                //Market.AhLoseM275 => IsHome() ? OddsVal() : OddsVal(),
                Market.AhWinM25 => IsHome() ? OddsVal(1383) : OddsVal(1379),
                Market.AhLoseM25 => IsHome() ? OddsVal(1379) : OddsVal(1383),
                Market.AhWinM225 => IsHome() ? OddsVal(2149) : OddsVal(2133),
                Market.AhLoseM225 => IsHome() ? OddsVal(2133) : OddsVal(2149),
                Market.AhWinM2 => IsHome() ? OddsVal(1377) : OddsVal(1372),
                Market.AhLoseM2 => IsHome() ? OddsVal(1372) : OddsVal(1377),
                Market.AhWinM175 => IsHome() ? OddsVal(2151) : OddsVal(2136),
                Market.AhLoseM175 => IsHome() ? OddsVal(2136) : OddsVal(2151),
                Market.AhWinM15 => IsHome() ? OddsVal(1384) : OddsVal(1385),
                Market.AhLoseM15 => IsHome() ? OddsVal(1385) : OddsVal(1384),
                Market.AhWinM125 => IsHome() ? OddsVal(2148) : OddsVal(2150),
                Market.AhLoseM125 => IsHome() ? OddsVal(2150) : OddsVal(2148),
                Market.AhWinM1 => IsHome() ? OddsVal(1380) : OddsVal(1386),
                Market.AhLoseM1 => IsHome() ? OddsVal(1386) : OddsVal(1380),
                Market.AhWinM075 => IsHome() ? OddsVal(2152) : OddsVal(2127),
                Market.AhLoseM075 => IsHome() ? OddsVal(2127) : OddsVal(2152),
                Market.AhWinM05 => IsHome() ? OddsVal(2130) : OddsVal(2153),
                Market.AhLoseM05 => IsHome() ? OddsVal(2153) : OddsVal(2130),
                Market.AhWinM025 => IsHome() ? OddsVal(2141) : OddsVal(2129),
                Market.AhLoseM025 => IsHome() ? OddsVal(2129) : OddsVal(2141),

                Market.AhWin0 => IsHome() ? OddsVal(1373) : OddsVal(1369),
                Market.AhLose0 => IsHome() ? OddsVal(1369) : OddsVal(1373),

                Market.AhWin025 => IsHome() ? OddsVal(2145) : OddsVal(2139),
                Market.AhLose025 => IsHome() ? OddsVal(2139) : OddsVal(2145),
                Market.AhWinP05 => IsHome() ? OddsVal(2125) : OddsVal(2138),
                Market.AhLoseP05 => IsHome() ? OddsVal(2138) : OddsVal(2125),
                Market.AhWin075 => IsHome() ? OddsVal(2126) : OddsVal(2131),
                Market.AhLose075 => IsHome() ? OddsVal(2131) : OddsVal(2126),
                Market.AhWinP1 => IsHome() ? OddsVal(1382) : OddsVal(1371),
                Market.AhLoseP1 => IsHome() ? OddsVal(1371) : OddsVal(1382),
                Market.AhWinP125 => IsHome() ? OddsVal(2135) : OddsVal(2143),
                Market.AhLoseP125 => IsHome() ? OddsVal(2143) : OddsVal(2135),
                Market.AhWinP15 => IsHome() ? OddsVal(1376) : OddsVal(1381),
                Market.AhLoseP15 => IsHome() ? OddsVal(1381) : OddsVal(1376),
                Market.AhWinP175 => IsHome() ? OddsVal(2124) : OddsVal(2146),
                Market.AhLoseP175 => IsHome() ? OddsVal(2146) : OddsVal(2124),
                Market.AhWinP2 => IsHome() ? OddsVal(1374) : OddsVal(1370),
                Market.AhLoseP2 => IsHome() ? OddsVal(1370) : OddsVal(1374),
                Market.AhWinP225 => IsHome() ? OddsVal(2137) : OddsVal(2147),
                Market.AhLoseP225 => IsHome() ? OddsVal(2147) : OddsVal(2137),
                Market.AhWinP25 => IsHome() ? OddsVal(1378) : OddsVal(1375),
                Market.AhLoseP25 => IsHome() ? OddsVal(1375) : OddsVal(1378),
                //Market.AhWinP275 => IsHome() ? OddsVal() : OddsVal(),
                //Market.AhLoseP275 => IsHome() ? OddsVal() : OddsVal(),
                Market.AhWinP3 => IsHome() ? OddsVal(2134) : OddsVal(2144),
                Market.AhLoseP3 => IsHome() ? OddsVal(2144) : OddsVal(2134),
                //Market.AhWinP325 => IsHome() ? OddsVal() : OddsVal(),
                //Market.AhLoseP325 => IsHome() ? OddsVal() : OddsVal(),
                //Market.AhWinP35 => IsHome() ? OddsVal() : OddsVal(),
                //Market.AhLoseP35 => IsHome() ? OddsVal() : OddsVal(),

                Market.ExactGoals_0 => OddsVal(916),
                Market.ExactGoals_1 => OddsVal(915),
                Market.ExactGoals_2 => OddsVal(913),
                Market.ExactGoals_3 => OddsVal(914),
                Market.ExactGoals_4 => OddsVal(918),
                //Market.ExactGoals_5 => OddsVal(), нет точного значения, есть значение more 4 - 917
                //Market.ExactGoals_6 => OddsVal(), нет точного значения, есть значение more 5 - 919

                Market.ExactScore_0_0 => OddsVal(395),
                Market.ExactScore_1_0 => OddsVal(385),
                Market.ExactScore_2_0 => OddsVal(386),
                Market.ExactScore_3_0 => OddsVal(388),
                Market.ExactScore_4_0 => OddsVal(391),
                Market.ExactScore_1_1 => OddsVal(396),
                Market.ExactScore_2_1 => OddsVal(387),
                Market.ExactScore_3_1 => OddsVal(389),
                Market.ExactScore_4_1 => OddsVal(392),
                Market.ExactScore_1_2 => OddsVal(403),
                Market.ExactScore_2_2 => OddsVal(397),
                Market.ExactScore_3_2 => OddsVal(390),
                Market.ExactScore_4_2 => OddsVal(393),
                Market.ExactScore_1_3 => OddsVal(404),
                Market.ExactScore_2_3 => OddsVal(406),
                Market.ExactScore_3_3 => OddsVal(398),
                Market.ExactScore_4_3 => OddsVal(394),
                Market.ExactScore_1_4 => OddsVal(405),
                Market.ExactScore_2_4 => OddsVal(407),
                Market.ExactScore_3_4 => OddsVal(408),
                Market.ExactScore_4_4 => OddsVal(415),

                Market.BtsYes => OddsVal(532),
                Market.BtsNo => OddsVal(533),

                Market.OddEven_Odd => OddsVal(923),
                Market.OddEven_Even => OddsVal(924),

                //В таблице нет информации по таймам
                //Market.TeamOddEven_Odd => throw new NotImplementedException(),
                //Market.TeamOddEven_Even => throw new NotImplementedException(),
                //Market.OppOddEven_Odd => throw new NotImplementedException(),
                //Market.OppTeamOddEven_Even => throw new NotImplementedException(),
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