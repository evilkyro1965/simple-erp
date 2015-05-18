using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simpleerp.model.test
{
    [TestClass]
    public class InventoryItemTest:BaseTest
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
            InventoryCategory category = new InventoryCategory();
            category.Name = "test";

            InventoryUOM uom = new InventoryUOM();
            uom.Name = "test";

            InventoryItem item = new InventoryItem();
            item.Category = category;
            item.UOM = uom;
            item.Type = InventoryType.NON_STOCK;
            item.Name = "test";
            item.Code = "123";

            dao.InventoryItems.Add(item);
            dao.SaveChanges();
        }
    }
}
