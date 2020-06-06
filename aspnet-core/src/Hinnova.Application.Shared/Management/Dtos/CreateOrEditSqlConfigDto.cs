
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace Hinnova.Management.Dtos
{
    public class CreateOrEditSqlConfigDto : EntityDto<int?>
    {

		public string Code { get; set; }
		
		
		public string Name { get; set; }
		
		
		public bool IsRawQuery { get; set; }
		
		
		public string SqlContent { get; set; }
		
		
		public int? GroupLevel { get; set; }
		
		
		public int? DisplayType { get; set; }
		
		
		public int? Version { get; set; }
		
		
		public bool IsDynamicColumn { get; set; }
		
		
		public int? TypeGetColumn { get; set; }
		
		

    }
}