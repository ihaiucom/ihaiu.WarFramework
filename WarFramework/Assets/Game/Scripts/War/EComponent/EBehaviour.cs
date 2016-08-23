using UnityEngine;
using System.Collections;
using System;

namespace Games
{
	/** 实体行为 */
	public class EBehaviour : MonoBehaviour, IEComponent 
	{

		/** 重置, 用在对象池 */
		public void CReset()
		{
		}
		
		/** 释放,一般用在销毁或对象池释放 */
		public void CRelease()
		{
		}
		
		/** 销毁内存分配 */
		public void CDealloc()
		{
		}


	}
}
