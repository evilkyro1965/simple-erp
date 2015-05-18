using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simpleerp.model.test
{
    [TestClass]
    public class InventoryUOMTEst:BaseTest
    {
        private DaoContext dao = new DaoContext();

        [TestInitialize()]
        public void Initialize()
        {
            setupDB();
        }

        [TestMethod]
        public void TestAdd()
        {
            InventoryUOM inventoryUOM = new InventoryUOM();
            inventoryUOM.Name = "test";
            
            dao.InventoryUOM.Add(inventoryUOM);
            dao.SaveChanges();
        }
    }
}
