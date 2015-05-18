using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simpleerp.model.test
{
    [TestClass]
    public class VendorTest:BaseTest
    {
        private DaoContext dao = new DaoContext();

        [TestInitialize()]
        public void Initialize()
        {
            setupDB();
        }

        [TestMethod]
        public void TestAddVendor()
        {

            VendorContact contact = new VendorContact();
            contact.Name = "fahrur";
            contact.IsPrimary = true;

            Vendor vendor = new Vendor();
            vendor.Contacts.Add(contact);
            vendor.Name = "Toko ABC";
            vendor.IsActive = false;
            dao.Vendors.Add(vendor);
            dao.SaveChanges();

        }
    }
}
