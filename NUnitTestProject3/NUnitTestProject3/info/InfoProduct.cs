
namespace NUnitTestProject3.info
{
    class InfoProduct
    {
        
        public string name { get; set; }
        public string category { get; set; }
        public string supplier { get; set; }
        public string unitprice { get; set; }
        public string quantityperunit { get; set; }
        public string unitsinstock { get; set; }
        public string unitsonorder { get; set; }
        public string reorderlevel { get; set; }

        public InfoProduct()
        {
            name = "newpr";
            category = "Beverages";
            supplier = "Karkki Oy";
            unitprice = "1";
            quantityperunit = "2";
            unitsinstock = "3";
            unitsonorder = "4";
            reorderlevel = "5";
        }
    }
}
