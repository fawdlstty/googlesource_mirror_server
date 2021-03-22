using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace googlesource_mirror_server.Models {
	/// <summary>
	/// 配置表
	/// </summary>
	[Table("tb_AppConfig")]
	public class Model_AppConfig : BasePoco {
		[Key]
		[DatabaseGenerated (DatabaseGeneratedOption.Identity)]
		public new long ID { get; set; }

		[Display (Name = "配置名称")]
		[Required (ErrorMessage = "{0}为必填项")]
		[StringLength (32, ErrorMessage = "{0}长度最大为{1}个字符")]
		public string Name { get; set; }

		[Display (Name = "配置内容")]
		[Required (ErrorMessage = "{0}为必填项")]
		public string Content { get; set; }
	}
}
