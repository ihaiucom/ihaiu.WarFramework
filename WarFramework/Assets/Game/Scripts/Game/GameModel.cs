using UnityEngine;
using System.Collections;
using System.Collections.Generic;



namespace Games
{
	/** 游戏配置数据 */
	public class GameModel : BaseModel
	{
		/** 技能配置数据  */
		public SkillModel 		skill = new SkillModel();
		/** 物品配置数据  */
		public ItemModel 		item = new ItemModel();
		/** 英雄配置数据  */
		public HeroModel 		hero = new HeroModel();
		/** 战斗配置数据 */
		public WarModel 		war = new WarModel();



	}
}