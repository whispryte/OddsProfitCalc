### Реализовать подсчет прибыльности разных видов ставок

Прибыльность означает суммарный выигрыш при постоянной ставке на один исход.
Например, сколько можно выиграть если всегда ставить на победу определенной команды.

--- 

### Исходные данные:
Список матчей с результатами и коэффициентами на разные события.

--- 
### Задача:
Подсчитать прибыль по всем видам ставок из списка (enum Market).

Код уже содержит реализацию некоторых некотрых ставок. Нужно по аналогии реализовать другие

TODO по проекту показывает в каких местах ожидаются доработки

--- 

Подсчет производится в классе OddsProfitCalc.cs. Экземпляр класса подсчитывает прибыль для определенной команды. 
В параметр конструктора передаётся Id команды. 

в enum OddsProfitCalc.Market содержится список всех видов ставок, прибыль по которым необходимо подсчтать.
Список идентификаторов коэффициентов содержится в markets.csv.
Над группой ставок есть строковый идентификатор, например 'Asian Handicap | Asian Handicap First Half | Asian Handicap (2nd Half)'.
По этим строковым идентификаторам нужно искать числовой идентификатор для каждого из таймов

_Примечание: некоторые исходы enum могут иметь два идентификатора.
Например: Win Both Halves | Home win both halves | Away win both halves_

Прибыль должна быть подсчитана для каждого из таймов и для всего матча.
Но, т.к не все типы ставок разделяются на таймы, наприме 1X2 разделяется, а гол в первые 15 мин - не раздялятеся,
то подсчитывать с раздалением на таймы нужно не все типы из списка.

---

### Пример:

ProfitCalcTests.сs сожержит юнит тесты и примеры

Разбор вычисления на примере вычисления **_TeamTotalOver05_**, **_TeamOppTotalOver05_** и _**teamId=44**_:

1. Переходим в enum Market. Ищем TeamTotalOver05. 

Над группой есть подсказка:         
_// Total - Home | Home Team Total Goals(1st Half) | Home Team Total Goals(2nd Half) | Total - Away | Away Team Total Goals(1st Half) | Away Team Total Goals(2nd Half)_

где | - разделитель.

вычисление _TeamTotalOver05_ зависит от того, нужная команда является хозяевами или гостями
1) Если хозяева (HomeTeamId==44) и период - полный матча, то в markets.csv ищется 'Total - Home'. Таким значением будет **443**
2) Если гости (AwayTeamId==44) и период - полный матча, то в markets.csv ищется 'Total - Away'. Таким значением будет **475**
3) Если хозяева (HomeTeamId==44) и период - 1 ый тайм, то в markets.csv ищется 'Home Team Total Goals(1st Half)'. Таким значением будет **1394**
4) Если гости (AwayTeamId==44) и период - 1 ый тайм, то в markets.csv ищется 'Away Team Total Goals(1st Half)'. Таким значением будет **1398**
5) Если хозяева (HomeTeamId==44) и период - 2ой тайм, то в markets.csv ищется 'Home Team Total Goals(2nd Half)'. Таким значением будет **1412**
6) Если гости (AwayTeamId==44) и период - 2ой тайм, то в markets.csv ищется 'Away Team Total Goals(2nd Half)'. Таким значением будет **1420**

для вычисления _TeamOppTotalOver05_ (значение команды противника) необходимо поменять в вышеперечисленных вычислениях домашную и гостевую команды местами.
1) ищется значение 'Total - Away'. **475**
2) ищется значение 'Total - Home'. **443**
3) ... и т.д

_всё это в коде_: (этот код представляет собой вычисления для двух полей. такое же нужно проделать с остальными полями)

```c#
// GetOdds 

Market.TeamTotalOver05 => IsHome() ? OddsVal(443) : OddsVal(475),
Market.TeamOppTotalOver05 => IsHome() ? OddsVal(475) : OddsVal(443),

// GetOdds1Half

Market.TeamTotalOver05 => IsHome() ? OddsVal(1394) : OddsVal(1398),
Market.TeamOppTotalOver05 => IsHome() ? OddsVal(1398) : OddsVal(1394),

// GetOdds2Half

Market.TeamTotalOver05 => IsHome() ? OddsVal(1412) : OddsVal(1420),
Market.TeamOppTotalOver05 => IsHome() ? OddsVal(1420) : OddsVal(1412),

// GetProfit
Market.TeamTotalOver05 => Score() > 0.5 ? odds : 0,
Market.TeamOppTotalOver05 => ScoreOpp() > 0.5 ? odds : 0,
```

