using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace googlesource_mirror_server.Models {
	/// <summary>
	/// 镜像仓库表
	/// </summary>
	[Table("tb_GitRepo")]
	public class Model_GitRepo : BasePoco {
		[Key]
		[DatabaseGenerated (DatabaseGeneratedOption.Identity)]
		public new long ID { get; set; }

		[Display (Name = "仓库名称")]
		[Required (ErrorMessage = "{0}为必填项")]
		[StringLength (64, ErrorMessage = "{0}长度最大为{1}个字符")]
		public string Name { get; set; }

		[Display (Name = "源地址")]
		[Required (ErrorMessage = "{0}为必填项")]
		[StringLength (255, ErrorMessage = "{0}长度最大为{1}个字符")]
		public string SrcUrl { get; set; }

		[Display (Name = "镜像同步地址")]
		[Required (ErrorMessage = "{0}为必填项")]
		[StringLength (255, ErrorMessage = "{0}长度最大为{1}个字符")]
		public string ImageUrl { get; set; }
	}
}
