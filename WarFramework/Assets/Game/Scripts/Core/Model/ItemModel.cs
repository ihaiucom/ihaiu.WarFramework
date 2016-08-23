using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Games
{
	/** 物品配置数据  */
	public class ItemModel : BaseModel
	{
		/** 物品配置 */
		public Dictionary<int, ItemConfig> items = new Dictionary<int, ItemConfig>();

		/** 获取物品配置 */
		override public ItemConfig GetItemConfig(int id)
		{
			ItemConfig config = null;
			if(!items.TryGetValue(id, out config))
			{
				Debug.LogErrorFormat("[Error] 获取物品配置失败 ItemModel.GetItemConfig({0})", id);
			}

			return config;
		}
	}
}