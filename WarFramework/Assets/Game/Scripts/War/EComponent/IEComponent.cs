using UnityEngine;
using System.Collections;
using System;

namespace Games
{
	/** 实体组件接口 */
	public interface IEComponent 
	{
		/** 重置, 用在对象池 */
		void CReset();

		/** 释放,一般用在销毁或对象池释放 */
		void CRelease();

		/** 销毁内存分配 */
		void CDealloc();
	}
}
