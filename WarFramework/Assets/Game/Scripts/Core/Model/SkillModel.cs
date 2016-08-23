using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Games
{
	/** 技能配置数据  */
	public class SkillModel : BaseModel
	{
		/** 技能配置 */
		public Dictionary<int, SkillConfig> skills = new Dictionary<int, SkillConfig>();

		/** 获取技能配置 */
		override public SkillConfig GetSkillConfig(int id)
		{
			SkillConfig config = null;
			if(!skills.TryGetValue(id, out config))
			{
				Debug.LogErrorFormat("[Error] 获取技能配置失败 SkillModel.GetSkillConfig({0})", id);
			}

			return config;
		}
	}
}