using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Games.Wars
{
	/** 英雄数据 */
	public class HeroData : EffectData
	{
		/** 英雄配置 */
		public HeroConfig 	heroConfig;
		/** 英雄参数 */
		public HeroArg 		heroArg;

		/** 技能数据列表 */
		public List<SkillData> skillList = new List<SkillData>();
		/** 物品数据列表 */
		public List<ItemData> itemList = new List<ItemData>();
	}
}
