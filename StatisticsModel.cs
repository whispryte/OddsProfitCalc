namespace OddsCalcTest;

public partial class sapi_SaStatistics
	{
		public int     FixtureId           { get; set; } // int
		public byte?   ShotsOnGoalHome     { get; set; } // tinyint
		public byte?   ShotsOnGoalAway     { get; set; } // tinyint
		public byte?   ShotsOffGoalHome    { get; set; } // tinyint
		public byte?   ShotsOffGoalAway    { get; set; } // tinyint
		public byte?   TotalShotsHome      { get; set; } // tinyint
		public byte?   TotalShotsAway      { get; set; } // tinyint
		public byte?   BlockedShotsHome    { get; set; } // tinyint
		public byte?   BlockedShotsAway    { get; set; } // tinyint
		public byte?   ShotsInsideBoxHome  { get; set; } // tinyint
		public byte?   ShotsInsideBoxAway  { get; set; } // tinyint
		public byte?   ShotsOutsideBoxHome { get; set; } // tinyint
		public byte?   ShotsOutsideBoxAway { get; set; } // tinyint
		public byte?   FoulsHome           { get; set; } // tinyint
		public byte?   FoulsAway           { get; set; } // tinyint
		public byte?   CornerKicksHome     { get; set; } // tinyint
		public byte?   CornerKicksAway     { get; set; } // tinyint
		public byte?   BallPossessionHome  { get; set; } // tinyint
		public byte?   BallPossessionAway  { get; set; } // tinyint
		public byte?   YellowCardsHome     { get; set; } // tinyint
		public byte?   YellowCardsAway     { get; set; } // tinyint
		public byte?   GoalkeeperSavesHome { get; set; } // tinyint
		public byte?   GoalkeeperSavesAway { get; set; } // tinyint
		public short?  TotalPassesHome     { get; set; } // smallint
		public short?  TotalPassesAway     { get; set; } // smallint
		public short?  PassesAccurateHome  { get; set; } // smallint
		public short?  PassesAccurateAway  { get; set; } // smallint
		public byte?   OffsidesHome        { get; set; } // tinyint
		public byte?   OffsidesAway        { get; set; } // tinyint
		public byte?   RedCardsHome        { get; set; } // tinyint
		public byte?   RedCardsAway        { get; set; } // tinyint
		
	}