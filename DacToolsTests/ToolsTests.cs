using Microsoft.VisualStudio.TestTools.UnitTesting;
using DacTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.Dac.Extensions;




/// <summary>
/// Use these tests to prove your dactools are returning the correct metadata and to 
/// research and expand further the types of metadata you can retrive.  If this does not
/// work then your real database projects will be hopeless.
/// </summary>
namespace DacTools.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void PrimaryKeysTest()
        {
            TSqlModel Model = new TSqlModel(@"DacToolsDb.dacpac");
            foreach (var table in Model.Tables())
            {
                Assert.IsNotNull(table.PrimaryKeyColumns());
                Assert.IsTrue(table.PrimaryKeyColumns().Count > 0);
                foreach (var column in table.PrimaryKeyColumns())
                {
                    Assert.IsFalse(string.IsNullOrEmpty(column.Name.ToString()));
                }
            }
        }
    }
}