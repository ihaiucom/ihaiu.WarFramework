using UnityEngine;
using System.Collections;
using System.Collections.Generic;



namespace Games
{
	/** 战斗场景数据 */
	public class WarSceneData : BaseScript
	{
		#region stage
		/** 关卡配置 */
		public StageConfig stageConfig;
		/** 战斗启动数据 */
		public WarEnterData enterData;

		#endregion

		#region init
		/** 创建场景数据 */
		public static WarSceneData Generate(WarEnterData enterData)
		{
			return new WarSceneData().Init(enterData);
		}

		/** 初始化场景数据 */
		public WarSceneData Init(WarEnterData enterData)
		{
			this.enterData = enterData;


			return this;
		}
		#endregion

		
		#region player
		
		/** 玩家联盟集 */
		public Dictionary<int, PlayerGroup> 	playerGroupDict = new Dictionary<int, PlayerGroup>();
		/** 玩家集 */
		public Dictionary<int, Player> 			playerDict = new Dictionary<int, Player>();
		/** 自己玩家 */
		public Player ownPlayer;

		#endregion


		#region unit
		/** 单位数据集 */
		public Dictionary<int, UnitData> 	unitDataDict = new Dictionary<int, UnitData>();
		
		/** 单位控制中心集 */
		public Dictionary<int, UnitCtl> 	unitCtlDict = new Dictionary<int, UnitCtl>();

		#endregion
	}
}
