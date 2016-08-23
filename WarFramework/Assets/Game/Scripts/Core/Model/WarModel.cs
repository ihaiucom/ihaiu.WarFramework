using UnityEngine;
using System.Collections;
using System.Collections.Generic;



namespace Games
{
	/** 战斗配置数据 */
	public class WarModel : BaseModel
	{
		
		/** 关卡配置 */
		public Dictionary<int, StageConfig> stages = new Dictionary<int, StageConfig>();

		/** 获取关卡配置 */
		override public StageConfig GetStageConfig(int id)
		{
			StageConfig config = null;
			if(!stages.TryGetValue(id, out config))
			{
				Debug.LogErrorFormat("[Error] 获取关卡配置失败 WarModel.GetStageConfig({0})", id);
			}
			
			return config;
		}



	}
}