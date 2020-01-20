using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Hybrid.Template.Identity.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;

using Hybrid.AspNetCore.Mvc;
using Hybrid.Collections;
using Hybrid.Core.Modules;
using Hybrid.Entity;


namespace Hybrid.Template.Web.Controllers
{
    public class Test2Controller : ApiController
    {
        private readonly DefaultDbContext _dbContext;

        public Test2Controller(DefaultDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 功能注释
        /// </summary>
        /// <returns>返回数据</returns>
        [HttpGet]
        [ModuleInfo]
        [Description("测试一下")]
        public string Test02()
        {
            return DependencyContext.Default.CompileLibraries.Select(m => $"{m.Name},{m.Version}").ExpandAndToString("\r\n");
        }
    }
}
