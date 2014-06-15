using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine
{
	/// <summary>
	/// 完整的一大波怪
	/// </summary>
    public class Wave
    {
        public int ID;
		/// <summary>
		/// 包含的一组组小怪
		/// </summary>
        public UnitCreep[] Creeps = new UnitCreep[1];
		/// <summary>
		/// 单位是秒,与上一波的时间间隔
		/// </summary>
        public float Interval;

		//
    }
}
