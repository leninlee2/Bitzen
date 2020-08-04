using Bitzen_LeninAguiar_InfraStructure.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Bitzen_LeninAguiar_UnitTest
{
    [TestClass]
    public class InfraStructure_Test
    {
        [TestMethod]
        public void ContextTest()
        {
            String message = String.Empty;
            bool status = false;
            try
            {
                //try connect database:
                using(var context = new DBBitzenContext())
                {
                    //execute a basic query
                    var result = context.Supply.ToList();
                }
                status = true;
            }catch(Exception ex)
            {
                message = ex.Message;
            }

            Assert.IsTrue(status, message);

        }

    }
}
