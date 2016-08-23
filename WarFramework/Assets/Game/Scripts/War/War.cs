using UnityEngine;
using System.Collections;

namespace Games
{
	/** 战斗对外接口 */
	public class War 
	{
		/** 战斗配置数据 */
		public static WarModel		model {		get {return Game.mode.war;}		}

		/** 战斗启动数据 */
		public static WarEnterData 		enterData;
		/** 战斗场景数据 */
		public static WarSceneData		sceneData;

		/** 战斗初始化 */
		public static void Init()
		{
		}

		/** 启动战斗 */
		public static void Start(WarEnterData enterData)
		{
			War.enterData = enterData;
			War.sceneData = WarSceneData.Generate(enterData);
		}


		/** 退出战斗 */
		public static void Exit()
		{

		}

	}
}